using Framework.Constants;
using Framework.GameMath;
using Game.Conditions;
using Game.Entities;
using System.Data;
using System.Xml.Linq;
using Trait_Editor.Models;
using Trait_Editor.Models.DB2Records;
using Trait_Editor.Utils;

namespace Trait_Editor
{
    public partial class MainForm : Form
    {
        public SpecID SelectedSpec = SpecID.None;
        public TextBox SelectedCell;

        private ContainerControl _gridContainer;
        private Dictionary<uint, PictureBox> _nodes = new();
        private bool _building = false;

        public MainForm()
        {
            InitializeComponent();

            DataAccess.LoadStores();
            TraitManager.Load();

            BuildGridContainer();
            PopulateTrees();
            listTrees.SelectedIndexChanged += ListTrees_SelectedIndexChanged;
            listTrees.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;

            FormClosed += MainForm_FormClosed;
            _gridContainer.Paint += gridContainer_Paint;
        }

        private void gridContainer_Paint(object? sender, PaintEventArgs e)
        {
            if (_building) 
                return;

            Pen pen = new Pen(Color.White, 2);

            foreach (var cell in _nodes.Values)
            {
                CellValue cellVal = (CellValue)cell.Tag;

                if (cellVal.SpellID == 0)
                    continue;

                var node = TraitManager.TraitNodes[cellVal.TraitNodeID];

                if (node.ParentNodes.Count == 0)
                    continue;

                var p1 = new Point(cell.Location.X + (cell.Width / 2), cell.Location.Y + (cell.Height / 2));

                foreach (var pnode in node.ParentNodes)
                {
                    var pcell = GetCell(pnode.Item1.Data.Id);

                    if (pcell != null)
                    {
                        var p2 = new Point(pcell.Location.X + (pcell.Width / 2), pcell.Location.Y + (pcell.Height / 2));
                        e.Graphics.DrawLine(pen, p1, p2);
                    }
                }
            }

            pen.Dispose();
        }

        private void MainForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void ListTrees_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (listTrees.SelectedItem == null)
                return;

            var selected = (TreeListItem)listTrees.SelectedItem;

            if (SelectedSpec == selected.SpecID)
                return;

            _building = true;
            ClearCells();
            uint spec = (uint)selected.SpecID;
            SelectedSpec = selected.SpecID;

            var trees = TraitManager.GetTraitTreesBySpecID((int)spec);
            List<TraitNode> genericNodes = new List<TraitNode>();

            foreach (var tree in trees)
                foreach (var node in tree.Nodes)
                {
                    if (_nodes.ContainsKey(node.Data.Id))
                        continue;

                    foreach (TraitNodeEntry entry in node.Entries)
                        foreach (TraitCondRecord condition in entry.Conditions)
                            if (TraitManager.IsSpecSetMember(condition.SpecSetID, spec))
                                CreateNode(node);

                    foreach (TraitCondRecord condition in node.Conditions)
                        if (TraitManager.IsSpecSetMember(condition.SpecSetID, spec))
                            foreach (TraitNodeEntry entry in node.Entries)
                                CreateNode(node);

                    foreach (TraitNodeGroup group in node.Groups)
                    {
                        foreach (TraitCondRecord condition in group.Conditions)
                            if (TraitManager.IsSpecSetMember(condition.SpecSetID, spec))
                                foreach (TraitNodeEntry entry in node.Entries)
                                    CreateNode(node);

                        foreach (var cost in group.Costs)
                            if (cost.TraitCurrencyID == (int)Enum.Parse<ClassTraitCurrencyID>(selected.Class.ToString()))
                                CreateNode(node);
                    }
                }

            _building = false;
            _gridContainer.Refresh();
        }

        private void CreateNode(TraitNode node)
        {
            if (_nodes.ContainsKey(node.Data.Id))
                return;

            var cell = CreateCell(node.Data.PosX, node.Data.PosY);
            _nodes[node.Data.Id] = cell;

            if (cell != null)
            {
                // DataAccess.SkillLineStorage for info
                AddCellData(cell, node);
            }
        }

        private static void AddCellData(PictureBox cell, TraitNode node)
        {
            if (!string.IsNullOrEmpty(cell.Text))
                return;

            string display = string.Empty;
            CellValue cellVal = (CellValue)cell.Tag; 

            if (TraitManager.TraitDefinitionByNodeID.ContainsKey(node.Data.Id))
            {
                var def = TraitManager.TraitDefinitionByNodeID[(int)node.Data.Id];

                if (def.SpellID != 0)
                {
                    cellVal.SpellID = def.SpellID;
                    display = def.OverrideName[Locale.enUS];

                    if (string.IsNullOrWhiteSpace(display))
                    {
                        if (def.OverridesSpellID != 0)
                            display = DataAccess.SpellNameStorage[def.OverridesSpellID].Name[Locale.enUS];
                        else
                            display = DataAccess.SpellNameStorage[def.SpellID].Name[Locale.enUS];
                    }

                    if (def.OverrideIcon != 0)
                        cell.BackgroundImage = DataAccess.GetIcon(def.OverrideIcon);
                    else
                    {
                        if (def.OverridesSpellID != 0)
                            cell.BackgroundImage = DataAccess.GetIcon(def.OverridesSpellID);
                        else
                            cell.BackgroundImage = DataAccess.GetIcon(def.SpellID);
                    }
                }
            }

            cellVal.Display = display;
            cellVal.TraitNodeID = node.Data.Id;
            cell.Text = display;
        }

        private void PopulateTrees()
        {
            foreach (var spec in TraitManager.TraitTreeLoadoutsByChrSpecialization)
            {
                int id = (int)spec.Key;
                var item = new TreeListItem()
                {
                    SpecID = (SpecID)id,
                    Class = TraitManager.ClassSpecs[id],
                    TreeID = DataAccess.TraitTreeLoadoutStorage[(uint)spec.Value.First().TraitTreeLoadoutID].TraitTreeID
                };
                item.Description = $"{item.SpecID} {item.Class}";

                listTrees.Items.Add(item);
            }
        }

        private void Box_DoubleClick(object? sender, EventArgs e)
        {
            if (sender != null)
            {
                SelectedCell = (TextBox)sender;
            }
        }

        private void BuildGridContainer()
        {
            _gridContainer = new ContainerControl();
            _gridContainer.Parent = this;
            _gridContainer.Location = new Point(268, 12);
            _gridContainer.Size = new Size(1004, 1237);
            _gridContainer.AutoScroll = true;
            _gridContainer.Visible = true;
            _gridContainer.Enabled = true;
            _gridContainer.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
        }

        private void ClearCells()
        {
            foreach (var node in _nodes)
            {
                node.Value.Dispose();
            }

            _nodes.Clear();
            _gridContainer.Controls.Clear();
        }

        private PictureBox GetCell(uint nodeId)
        {
            return _nodes.ContainsKey(nodeId) ? _nodes[nodeId] : null;
        }

        private PictureBox CreateCell(int x, int y)
        {
            PictureBox box = new PictureBox();
            box.Parent = _gridContainer;
            box.Location = new Point(x != 0 ? x / 7 : x, y != 0 ? y / 7 : y); // dont divide xy for size if it is 0
            box.Size = new Size(50, 50);
            box.Tag = new CellValue() { Coordinate = new Coordinate(x, y) };
            box.Enabled = true;
            box.DoubleClick += Box_DoubleClick;
            box.Cursor = Cursors.Arrow;
            box.BackgroundImageLayout = ImageLayout.Stretch;

            return box;
        }
    }
}