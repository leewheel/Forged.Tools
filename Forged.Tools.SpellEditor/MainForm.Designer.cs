﻿using Forged.Tools.Shared.Forms;

namespace Forged.Tools.SpellEditor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listSpells = new System.Windows.Forms.ListBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.numCurentMin = new System.Windows.Forms.NumericUpDown();
            this.numCurentMax = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabsSpellInfo = new System.Windows.Forms.TabControl();
            this.tabBasicInfo = new System.Windows.Forms.TabPage();
            this.groupSpellInfo = new System.Windows.Forms.GroupBox();
            this.spellIdChanger = new System.Windows.Forms.NumericUpDown();
            this.txtLaunchDelay = new System.Windows.Forms.TextBox();
            this.label204 = new System.Windows.Forms.Label();
            this.numModalNextSpell = new System.Windows.Forms.NumericUpDown();
            this.label197 = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.label137 = new System.Windows.Forms.Label();
            this.mlcmbRange = new Forged.Tools.Shared.Forms.MultiLineComboBox();
            this.mlcmbDuration = new Forged.Tools.Shared.Forms.MultiLineComboBox();
            this.label74 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.cmbCastTime = new System.Windows.Forms.ComboBox();
            this.label69 = new System.Windows.Forms.Label();
            this.numStackAmount = new System.Windows.Forms.NumericUpDown();
            this.numFamilyFlags4 = new System.Windows.Forms.NumericUpDown();
            this.label44 = new System.Windows.Forms.Label();
            this.numFamilyFlags3 = new System.Windows.Forms.NumericUpDown();
            this.label43 = new System.Windows.Forms.Label();
            this.numFamilyFlags2 = new System.Windows.Forms.NumericUpDown();
            this.label42 = new System.Windows.Forms.Label();
            this.numFamilyFlags1 = new System.Windows.Forms.NumericUpDown();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.txtAuraDesc = new System.Windows.Forms.TextBox();
            this.cmbSpellFamily = new System.Windows.Forms.ComboBox();
            this.txtSpellNameSubtext = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSpellName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSpellDesc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabsPowerConfig = new System.Windows.Forms.TabControl();
            this.tabPower1 = new System.Windows.Forms.TabPage();
            this.numericUpDown13 = new System.Windows.Forms.NumericUpDown();
            this.label96 = new System.Windows.Forms.Label();
            this.numericUpDown12 = new System.Windows.Forms.NumericUpDown();
            this.label95 = new System.Windows.Forms.Label();
            this.txtPwrCostPerSec1 = new System.Windows.Forms.TextBox();
            this.label94 = new System.Windows.Forms.Label();
            this.txtPwrCostMaxPct1 = new System.Windows.Forms.TextBox();
            this.label93 = new System.Windows.Forms.Label();
            this.txtPwrCost1 = new System.Windows.Forms.TextBox();
            this.label92 = new System.Windows.Forms.Label();
            this.numericUpDown11 = new System.Windows.Forms.NumericUpDown();
            this.label91 = new System.Windows.Forms.Label();
            this.numericUpDown10 = new System.Windows.Forms.NumericUpDown();
            this.label37 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
            this.label89 = new System.Windows.Forms.Label();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.cmbPowerType1 = new System.Windows.Forms.ComboBox();
            this.label88 = new System.Windows.Forms.Label();
            this.numTypeMask = new System.Windows.Forms.NumericUpDown();
            this.label31 = new System.Windows.Forms.Label();
            this.tabPower2 = new System.Windows.Forms.TabPage();
            this.label105 = new System.Windows.Forms.Label();
            this.numericUpDown14 = new System.Windows.Forms.NumericUpDown();
            this.label106 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.numericUpDown15 = new System.Windows.Forms.NumericUpDown();
            this.label98 = new System.Windows.Forms.Label();
            this.txtPwrCostPerSec2 = new System.Windows.Forms.TextBox();
            this.label99 = new System.Windows.Forms.Label();
            this.txtPwrCostMaxPct2 = new System.Windows.Forms.TextBox();
            this.label100 = new System.Windows.Forms.Label();
            this.txtPwrCost2 = new System.Windows.Forms.TextBox();
            this.label101 = new System.Windows.Forms.Label();
            this.numericUpDown16 = new System.Windows.Forms.NumericUpDown();
            this.label102 = new System.Windows.Forms.Label();
            this.numericUpDown17 = new System.Windows.Forms.NumericUpDown();
            this.label103 = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.numericUpDown18 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown19 = new System.Windows.Forms.NumericUpDown();
            this.cmbPowerType2 = new System.Windows.Forms.ComboBox();
            this.numericUpDown20 = new System.Windows.Forms.NumericUpDown();
            this.tabPower3 = new System.Windows.Forms.TabPage();
            this.label116 = new System.Windows.Forms.Label();
            this.numericUpDown21 = new System.Windows.Forms.NumericUpDown();
            this.label117 = new System.Windows.Forms.Label();
            this.label118 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.numOptionalCost3 = new System.Windows.Forms.NumericUpDown();
            this.label109 = new System.Windows.Forms.Label();
            this.txtPwrCostPerSec3 = new System.Windows.Forms.TextBox();
            this.label110 = new System.Windows.Forms.Label();
            this.txtPwrCostMaxPct3 = new System.Windows.Forms.TextBox();
            this.label111 = new System.Windows.Forms.Label();
            this.txtPwrCost3 = new System.Windows.Forms.TextBox();
            this.label112 = new System.Windows.Forms.Label();
            this.numericUpDown23 = new System.Windows.Forms.NumericUpDown();
            this.label113 = new System.Windows.Forms.Label();
            this.numericUpDown24 = new System.Windows.Forms.NumericUpDown();
            this.label114 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.numericUpDown25 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown26 = new System.Windows.Forms.NumericUpDown();
            this.cmbPowerType3 = new System.Windows.Forms.ComboBox();
            this.numericUpDown27 = new System.Windows.Forms.NumericUpDown();
            this.tabPower4 = new System.Windows.Forms.TabPage();
            this.label127 = new System.Windows.Forms.Label();
            this.numericUpDown28 = new System.Windows.Forms.NumericUpDown();
            this.label128 = new System.Windows.Forms.Label();
            this.label129 = new System.Windows.Forms.Label();
            this.label119 = new System.Windows.Forms.Label();
            this.numOptionalCost4 = new System.Windows.Forms.NumericUpDown();
            this.label120 = new System.Windows.Forms.Label();
            this.txtPwrCostPerSec4 = new System.Windows.Forms.TextBox();
            this.label121 = new System.Windows.Forms.Label();
            this.txtPwrCostMaxPct4 = new System.Windows.Forms.TextBox();
            this.label122 = new System.Windows.Forms.Label();
            this.txtPwrCost4 = new System.Windows.Forms.TextBox();
            this.label123 = new System.Windows.Forms.Label();
            this.numericUpDown30 = new System.Windows.Forms.NumericUpDown();
            this.label124 = new System.Windows.Forms.Label();
            this.numericUpDown31 = new System.Windows.Forms.NumericUpDown();
            this.label125 = new System.Windows.Forms.Label();
            this.label126 = new System.Windows.Forms.Label();
            this.numericUpDown32 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown33 = new System.Windows.Forms.NumericUpDown();
            this.cmbPowerType4 = new System.Windows.Forms.ComboBox();
            this.numericUpDown34 = new System.Windows.Forms.NumericUpDown();
            this.groupCooldown = new System.Windows.Forms.GroupBox();
            this.mlcmbEditCat = new Forged.Tools.Shared.Forms.MultiLineComboBox();
            this.numStartCooldownTime = new System.Windows.Forms.NumericUpDown();
            this.label205 = new System.Windows.Forms.Label();
            this.label138 = new System.Windows.Forms.Label();
            this.cmbPreventionType = new System.Windows.Forms.ComboBox();
            this.cmbDifficultyId = new System.Windows.Forms.ComboBox();
            this.label45 = new System.Windows.Forms.Label();
            this.numChargeCat = new System.Windows.Forms.NumericUpDown();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.cmbDamageType = new System.Windows.Forms.ComboBox();
            this.cmbMechanic = new System.Windows.Forms.ComboBox();
            this.cmbDispelType = new System.Windows.Forms.ComboBox();
            this.numStartRecCat = new System.Windows.Forms.NumericUpDown();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.listCatFlags = new System.Windows.Forms.ListBox();
            this.numCatUsesPerWeek = new System.Windows.Forms.NumericUpDown();
            this.label29 = new System.Windows.Forms.Label();
            this.numCatId = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.numCatChargeCD = new System.Windows.Forms.NumericUpDown();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.numCatCharges = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.btnSaveCategory = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.numCatCooldown = new System.Windows.Forms.NumericUpDown();
            this.numCooldown = new System.Windows.Forms.NumericUpDown();
            this.numCategory = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tabBasicInfo2 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.numScalesFromItemLevel = new System.Windows.Forms.NumericUpDown();
            this.label210 = new System.Windows.Forms.Label();
            this.numMaxScalingLevel = new System.Windows.Forms.NumericUpDown();
            this.label209 = new System.Windows.Forms.Label();
            this.numMinScalingLevel = new System.Windows.Forms.NumericUpDown();
            this.label208 = new System.Windows.Forms.Label();
            this.numShowFutureSpellPlayerConditionID = new System.Windows.Forms.NumericUpDown();
            this.label207 = new System.Windows.Forms.Label();
            this.numContentTuningID = new System.Windows.Forms.NumericUpDown();
            this.label206 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label202 = new System.Windows.Forms.Label();
            this.txtConeAngle = new System.Windows.Forms.TextBox();
            this.label203 = new System.Windows.Forms.Label();
            this.listTargetCreatureType = new System.Windows.Forms.ListBox();
            this.label161 = new System.Windows.Forms.Label();
            this.numMaxTargetLevel = new System.Windows.Forms.NumericUpDown();
            this.label135 = new System.Windows.Forms.Label();
            this.label136 = new System.Windows.Forms.Label();
            this.numMaxTargets = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVisualDelete = new System.Windows.Forms.Button();
            this.numUnitCaster = new System.Windows.Forms.NumericUpDown();
            this.label155 = new System.Windows.Forms.Label();
            this.numPlayerCaster = new System.Windows.Forms.NumericUpDown();
            this.label154 = new System.Windows.Forms.Label();
            this.numUnitViewer = new System.Windows.Forms.NumericUpDown();
            this.label153 = new System.Windows.Forms.Label();
            this.label152 = new System.Windows.Forms.Label();
            this.label151 = new System.Windows.Forms.Label();
            this.label150 = new System.Windows.Forms.Label();
            this.numPlayerViewer = new System.Windows.Forms.NumericUpDown();
            this.label149 = new System.Windows.Forms.Label();
            this.numVisualPriority = new System.Windows.Forms.NumericUpDown();
            this.label148 = new System.Windows.Forms.Label();
            this.txtVisualProbability = new System.Windows.Forms.TextBox();
            this.label147 = new System.Windows.Forms.Label();
            this.numVisualActiveIconId = new System.Windows.Forms.NumericUpDown();
            this.label146 = new System.Windows.Forms.Label();
            this.numVisualIconId = new System.Windows.Forms.NumericUpDown();
            this.label145 = new System.Windows.Forms.Label();
            this.numSpellVisualId = new System.Windows.Forms.NumericUpDown();
            this.label144 = new System.Windows.Forms.Label();
            this.btnVisualSave = new System.Windows.Forms.Button();
            this.btnVisualCopy = new System.Windows.Forms.Button();
            this.btnVisualNew = new System.Windows.Forms.Button();
            this.cmbVisualDifficulty = new System.Windows.Forms.ComboBox();
            this.label142 = new System.Windows.Forms.Label();
            this.numVisualId = new System.Windows.Forms.NumericUpDown();
            this.label141 = new System.Windows.Forms.Label();
            this.cmbSelectVisual = new System.Windows.Forms.ComboBox();
            this.label140 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numRequiredAreaId = new System.Windows.Forms.NumericUpDown();
            this.txtLabels = new System.Windows.Forms.TextBox();
            this.label196 = new System.Windows.Forms.Label();
            this.label200 = new System.Windows.Forms.Label();
            this.numExTargetAura = new System.Windows.Forms.NumericUpDown();
            this.label195 = new System.Windows.Forms.Label();
            this.numExCasterAura = new System.Windows.Forms.NumericUpDown();
            this.label194 = new System.Windows.Forms.Label();
            this.numTargetAura = new System.Windows.Forms.NumericUpDown();
            this.label193 = new System.Windows.Forms.Label();
            this.numCasterAura = new System.Windows.Forms.NumericUpDown();
            this.label192 = new System.Windows.Forms.Label();
            this.label190 = new System.Windows.Forms.Label();
            this.cmbExTargetAuraState = new System.Windows.Forms.ComboBox();
            this.label191 = new System.Windows.Forms.Label();
            this.cmbExCasterAuraState = new System.Windows.Forms.ComboBox();
            this.numFacingCasterFlags = new System.Windows.Forms.NumericUpDown();
            this.label157 = new System.Windows.Forms.Label();
            this.label156 = new System.Windows.Forms.Label();
            this.listSpellSchool = new System.Windows.Forms.ListBox();
            this.label143 = new System.Windows.Forms.Label();
            this.cmbSpellFocus = new System.Windows.Forms.ComboBox();
            this.label139 = new System.Windows.Forms.Label();
            this.cmbTargetAuraState = new System.Windows.Forms.ComboBox();
            this.label72 = new System.Windows.Forms.Label();
            this.cmbCasterAuraState = new System.Windows.Forms.ComboBox();
            this.numMaxLevel = new System.Windows.Forms.NumericUpDown();
            this.numBaseLevel = new System.Windows.Forms.NumericUpDown();
            this.numSpellLevel = new System.Windows.Forms.NumericUpDown();
            this.label134 = new System.Windows.Forms.Label();
            this.label133 = new System.Windows.Forms.Label();
            this.label132 = new System.Windows.Forms.Label();
            this.tabProcInfo = new System.Windows.Forms.TabPage();
            this.mlcmbPPM = new Forged.Tools.Shared.Forms.MultiLineComboBox();
            this.lblPPM = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.numProcCharges = new System.Windows.Forms.NumericUpDown();
            this.label68 = new System.Windows.Forms.Label();
            this.numProcCooldown = new System.Windows.Forms.NumericUpDown();
            this.label66 = new System.Windows.Forms.Label();
            this.numProcChance = new System.Windows.Forms.NumericUpDown();
            this.listProcTargets = new System.Windows.Forms.ListBox();
            this.label65 = new System.Windows.Forms.Label();
            this.listProcFlags2 = new System.Windows.Forms.ListBox();
            this.label64 = new System.Windows.Forms.Label();
            this.listProcFlags = new System.Windows.Forms.ListBox();
            this.label63 = new System.Windows.Forms.Label();
            this.tabSpellEffects = new System.Windows.Forms.TabPage();
            this.btnAddEffect = new System.Windows.Forms.Button();
            this.tabsSpellEffects = new System.Windows.Forms.TabControl();
            this.tabEffect = new System.Windows.Forms.TabPage();
            this.txtBP = new System.Windows.Forms.TextBox();
            this.label212 = new System.Windows.Forms.Label();
            this.numEffTableID = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown22 = new System.Windows.Forms.NumericUpDown();
            this.label211 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.label82 = new System.Windows.Forms.Label();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.label81 = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.label80 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label79 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label78 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label77 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label76 = new System.Windows.Forms.Label();
            this.numChainTargets = new System.Windows.Forms.NumericUpDown();
            this.txtResourceCoefficient = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.txtScalingCoefficient = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.numScalingClass = new System.Windows.Forms.NumericUpDown();
            this.txtPositionFacing = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.txtBonusCoefficient = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.txtBonusCoefficientFromAP = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.txtChainAmplitude = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.txtAmplitude = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.txtPointsPerResource = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.numAuraDuration = new System.Windows.Forms.NumericUpDown();
            this.cmbApplyAura = new System.Windows.Forms.ComboBox();
            this.label52 = new System.Windows.Forms.Label();
            this.cmbRadiusMax = new System.Windows.Forms.ComboBox();
            this.label51 = new System.Windows.Forms.Label();
            this.cmbRadiusMin = new System.Windows.Forms.ComboBox();
            this.label50 = new System.Windows.Forms.Label();
            this.cmbTargetB = new System.Windows.Forms.ComboBox();
            this.label49 = new System.Windows.Forms.Label();
            this.cmbTargetA = new System.Windows.Forms.ComboBox();
            this.label48 = new System.Windows.Forms.Label();
            this.cmbEffMechanic = new System.Windows.Forms.ComboBox();
            this.label47 = new System.Windows.Forms.Label();
            this.txtRealPoints = new System.Windows.Forms.TextBox();
            this.txtVariance = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.lblDS = new System.Windows.Forms.Label();
            this.lblBP = new System.Windows.Forms.Label();
            this.cmbSpellEffect = new System.Windows.Forms.ComboBox();
            this.lblSpellEffect = new System.Windows.Forms.Label();
            this.tabAttributes = new System.Windows.Forms.TabPage();
            this.listAttr14 = new System.Windows.Forms.ListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.listAttr13 = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.listAttr12 = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.listAttr11 = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.listAttr10 = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.listAttr9 = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.listAttr8 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listAttr7 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listAttr6 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listAttr5 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listAttr4 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listAttr3 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listAttr2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listAttr1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listAttr0 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabFlags = new System.Windows.Forms.TabPage();
            this.listChannelInterruptFlags2 = new System.Windows.Forms.ListBox();
            this.label198 = new System.Windows.Forms.Label();
            this.listChannelInterruptFlags = new System.Windows.Forms.ListBox();
            this.label199 = new System.Windows.Forms.Label();
            this.listAuraInterruptFlags2 = new System.Windows.Forms.ListBox();
            this.label160 = new System.Windows.Forms.Label();
            this.listAuraInterruptFlags = new System.Windows.Forms.ListBox();
            this.label159 = new System.Windows.Forms.Label();
            this.listInterruptFlags = new System.Windows.Forms.ListBox();
            this.label158 = new System.Windows.Forms.Label();
            this.tabFlags2 = new System.Windows.Forms.TabPage();
            this.listExStances = new System.Windows.Forms.ListBox();
            this.label162 = new System.Windows.Forms.Label();
            this.listStances = new System.Windows.Forms.ListBox();
            this.label201 = new System.Windows.Forms.Label();
            this.tabItems = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.listEquippedItemSubClass = new System.Windows.Forms.ListBox();
            this.label189 = new System.Windows.Forms.Label();
            this.listEquippedItemInvenType = new System.Windows.Forms.ListBox();
            this.label188 = new System.Windows.Forms.Label();
            this.cmbEquippedItemClass = new System.Windows.Forms.ComboBox();
            this.label187 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmbCurrencyType = new System.Windows.Forms.ComboBox();
            this.btnCurrencyDelete = new System.Windows.Forms.Button();
            this.btnCurrencySave = new System.Windows.Forms.Button();
            this.btnCurrencyCopy = new System.Windows.Forms.Button();
            this.btnCurrencyNew = new System.Windows.Forms.Button();
            this.label186 = new System.Windows.Forms.Label();
            this.numCurrencyCount = new System.Windows.Forms.NumericUpDown();
            this.label185 = new System.Windows.Forms.Label();
            this.numCurrencyId = new System.Windows.Forms.NumericUpDown();
            this.label184 = new System.Windows.Forms.Label();
            this.cmbSelectCurrency = new System.Windows.Forms.ComboBox();
            this.label183 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label181 = new System.Windows.Forms.Label();
            this.numReagentCount8 = new System.Windows.Forms.NumericUpDown();
            this.label182 = new System.Windows.Forms.Label();
            this.numReagent8 = new System.Windows.Forms.NumericUpDown();
            this.label179 = new System.Windows.Forms.Label();
            this.numReagentCount7 = new System.Windows.Forms.NumericUpDown();
            this.label180 = new System.Windows.Forms.Label();
            this.numReagent7 = new System.Windows.Forms.NumericUpDown();
            this.label177 = new System.Windows.Forms.Label();
            this.numReagentCount6 = new System.Windows.Forms.NumericUpDown();
            this.label178 = new System.Windows.Forms.Label();
            this.numReagent6 = new System.Windows.Forms.NumericUpDown();
            this.label175 = new System.Windows.Forms.Label();
            this.numReagentCount5 = new System.Windows.Forms.NumericUpDown();
            this.label176 = new System.Windows.Forms.Label();
            this.numReagent5 = new System.Windows.Forms.NumericUpDown();
            this.label173 = new System.Windows.Forms.Label();
            this.numReagentCount4 = new System.Windows.Forms.NumericUpDown();
            this.label174 = new System.Windows.Forms.Label();
            this.numReagent4 = new System.Windows.Forms.NumericUpDown();
            this.label171 = new System.Windows.Forms.Label();
            this.numReagentCount3 = new System.Windows.Forms.NumericUpDown();
            this.label172 = new System.Windows.Forms.Label();
            this.numReagent3 = new System.Windows.Forms.NumericUpDown();
            this.label169 = new System.Windows.Forms.Label();
            this.numReagentCount2 = new System.Windows.Forms.NumericUpDown();
            this.label170 = new System.Windows.Forms.Label();
            this.numReagent2 = new System.Windows.Forms.NumericUpDown();
            this.label168 = new System.Windows.Forms.Label();
            this.numReagentCount1 = new System.Windows.Forms.NumericUpDown();
            this.label167 = new System.Windows.Forms.Label();
            this.numReagent1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbTotemCategory2 = new System.Windows.Forms.ComboBox();
            this.cmbTotemCategory1 = new System.Windows.Forms.ComboBox();
            this.label166 = new System.Windows.Forms.Label();
            this.label165 = new System.Windows.Forms.Label();
            this.numTotem2 = new System.Windows.Forms.NumericUpDown();
            this.label164 = new System.Windows.Forms.Label();
            this.numTotem1 = new System.Windows.Forms.NumericUpDown();
            this.label163 = new System.Windows.Forms.Label();
            this.tabIcon = new System.Windows.Forms.TabPage();
            this.lblIconPageCount = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.numIconPage = new System.Windows.Forms.NumericUpDown();
            this.btnIconLast = new System.Windows.Forms.Button();
            this.btnIconNext = new System.Windows.Forms.Button();
            this.btnIconPrevious = new System.Windows.Forms.Button();
            this.btnIconFirst = new System.Windows.Forms.Button();
            this.txtIconSearch = new System.Windows.Forms.TextBox();
            this.lblSelIcon = new System.Windows.Forms.Label();
            this.lblActiveIcon = new System.Windows.Forms.Label();
            this.lblCurIcon = new System.Windows.Forms.Label();
            this.btnActiveIconUndo = new System.Windows.Forms.Button();
            this.btnActiveIconChange = new System.Windows.Forms.Button();
            this.btnCurIconUndo = new System.Windows.Forms.Button();
            this.btnCurIconChange = new System.Windows.Forms.Button();
            this.picSelectedIcon = new System.Windows.Forms.PictureBox();
            this.picActiveIcon = new System.Windows.Forms.PictureBox();
            this.picCurIcon = new System.Windows.Forms.PictureBox();
            this.label86 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.lvIcons = new System.Windows.Forms.ListView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.cmbIndexing = new System.Windows.Forms.ComboBox();
            this.lblCurrentSpellName = new System.Windows.Forms.Label();
            this.numNewSpellID = new System.Windows.Forms.NumericUpDown();
            this.label30 = new System.Windows.Forms.Label();
            this.numIdSearch = new System.Windows.Forms.NumericUpDown();
            this.label75 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnDeleteSpell = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCurentMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurentMax)).BeginInit();
            this.tabsSpellInfo.SuspendLayout();
            this.tabBasicInfo.SuspendLayout();
            this.groupSpellInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spellIdChanger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numModalNextSpell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStackAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFamilyFlags4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFamilyFlags3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFamilyFlags2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFamilyFlags1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabsPowerConfig.SuspendLayout();
            this.tabPower1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTypeMask)).BeginInit();
            this.tabPower2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown20)).BeginInit();
            this.tabPower3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOptionalCost3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown27)).BeginInit();
            this.tabPower4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOptionalCost4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown34)).BeginInit();
            this.groupCooldown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartCooldownTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChargeCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartRecCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCatUsesPerWeek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCatId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCatChargeCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCatCharges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCatCooldown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCooldown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCategory)).BeginInit();
            this.tabBasicInfo2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScalesFromItemLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxScalingLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinScalingLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShowFutureSpellPlayerConditionID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numContentTuningID)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxTargetLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxTargets)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitCaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayerCaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayerViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVisualPriority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVisualActiveIconId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVisualIconId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpellVisualId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVisualId)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRequiredAreaId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExTargetAura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExCasterAura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetAura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCasterAura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFacingCasterFlags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpellLevel)).BeginInit();
            this.tabProcInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProcCharges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProcCooldown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProcChance)).BeginInit();
            this.tabSpellEffects.SuspendLayout();
            this.tabsSpellEffects.SuspendLayout();
            this.tabEffect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEffTableID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChainTargets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScalingClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAuraDuration)).BeginInit();
            this.tabAttributes.SuspendLayout();
            this.tabFlags.SuspendLayout();
            this.tabFlags2.SuspendLayout();
            this.tabItems.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrencyCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrencyId)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numReagentCount8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReagent8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReagentCount7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReagent7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReagentCount6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReagent6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReagentCount5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReagent5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReagentCount4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReagent4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReagentCount3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReagent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReagentCount2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReagent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReagentCount1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReagent1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotem1)).BeginInit();
            this.tabIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIconPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picActiveIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCurIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNewSpellID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // listSpells
            // 
            this.listSpells.FormattingEnabled = true;
            this.listSpells.ItemHeight = 20;
            this.listSpells.Location = new System.Drawing.Point(14, 176);
            this.listSpells.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listSpells.Name = "listSpells";
            this.listSpells.Size = new System.Drawing.Size(305, 784);
            this.listSpells.TabIndex = 1;
            this.listSpells.SelectedIndexChanged += new System.EventHandler(this.listSpells_SelectedIndexChanged);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(14, 137);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(39, 31);
            this.btnFirst.TabIndex = 2;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(59, 137);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(39, 31);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(280, 137);
            this.btnLast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(39, 31);
            this.btnLast.TabIndex = 5;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(234, 137);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(39, 31);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // numCurentMin
            // 
            this.numCurentMin.Location = new System.Drawing.Point(14, 99);
            this.numCurentMin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numCurentMin.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numCurentMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCurentMin.Name = "numCurentMin";
            this.numCurentMin.Size = new System.Drawing.Size(146, 27);
            this.numCurentMin.TabIndex = 6;
            this.numCurentMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numCurentMax
            // 
            this.numCurentMax.Location = new System.Drawing.Point(178, 99);
            this.numCurentMax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numCurentMax.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numCurentMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCurentMax.Name = "numCurentMax";
            this.numCurentMax.Size = new System.Drawing.Size(141, 27);
            this.numCurentMax.TabIndex = 7;
            this.numCurentMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "/";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(14, 60);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search by name...";
            this.txtSearch.Size = new System.Drawing.Size(305, 27);
            this.txtSearch.TabIndex = 9;
            // 
            // tabsSpellInfo
            // 
            this.tabsSpellInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabsSpellInfo.Controls.Add(this.tabBasicInfo);
            this.tabsSpellInfo.Controls.Add(this.tabBasicInfo2);
            this.tabsSpellInfo.Controls.Add(this.tabProcInfo);
            this.tabsSpellInfo.Controls.Add(this.tabSpellEffects);
            this.tabsSpellInfo.Controls.Add(this.tabAttributes);
            this.tabsSpellInfo.Controls.Add(this.tabFlags);
            this.tabsSpellInfo.Controls.Add(this.tabFlags2);
            this.tabsSpellInfo.Controls.Add(this.tabItems);
            this.tabsSpellInfo.Controls.Add(this.tabIcon);
            this.tabsSpellInfo.Location = new System.Drawing.Point(326, 55);
            this.tabsSpellInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabsSpellInfo.Name = "tabsSpellInfo";
            this.tabsSpellInfo.SelectedIndex = 0;
            this.tabsSpellInfo.Size = new System.Drawing.Size(1142, 907);
            this.tabsSpellInfo.TabIndex = 10;
            // 
            // tabBasicInfo
            // 
            this.tabBasicInfo.Controls.Add(this.groupSpellInfo);
            this.tabBasicInfo.Controls.Add(this.groupBox1);
            this.tabBasicInfo.Controls.Add(this.groupCooldown);
            this.tabBasicInfo.Location = new System.Drawing.Point(4, 29);
            this.tabBasicInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabBasicInfo.Name = "tabBasicInfo";
            this.tabBasicInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabBasicInfo.Size = new System.Drawing.Size(1134, 874);
            this.tabBasicInfo.TabIndex = 0;
            this.tabBasicInfo.Text = "Basic Info";
            this.tabBasicInfo.UseVisualStyleBackColor = true;
            // 
            // groupSpellInfo
            // 
            this.groupSpellInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupSpellInfo.Controls.Add(this.spellIdChanger);
            this.groupSpellInfo.Controls.Add(this.txtLaunchDelay);
            this.groupSpellInfo.Controls.Add(this.label204);
            this.groupSpellInfo.Controls.Add(this.numModalNextSpell);
            this.groupSpellInfo.Controls.Add(this.label197);
            this.groupSpellInfo.Controls.Add(this.txtSpeed);
            this.groupSpellInfo.Controls.Add(this.label137);
            this.groupSpellInfo.Controls.Add(this.mlcmbRange);
            this.groupSpellInfo.Controls.Add(this.mlcmbDuration);
            this.groupSpellInfo.Controls.Add(this.label74);
            this.groupSpellInfo.Controls.Add(this.label71);
            this.groupSpellInfo.Controls.Add(this.label73);
            this.groupSpellInfo.Controls.Add(this.cmbCastTime);
            this.groupSpellInfo.Controls.Add(this.label69);
            this.groupSpellInfo.Controls.Add(this.numStackAmount);
            this.groupSpellInfo.Controls.Add(this.numFamilyFlags4);
            this.groupSpellInfo.Controls.Add(this.label44);
            this.groupSpellInfo.Controls.Add(this.numFamilyFlags3);
            this.groupSpellInfo.Controls.Add(this.label43);
            this.groupSpellInfo.Controls.Add(this.numFamilyFlags2);
            this.groupSpellInfo.Controls.Add(this.label42);
            this.groupSpellInfo.Controls.Add(this.numFamilyFlags1);
            this.groupSpellInfo.Controls.Add(this.label41);
            this.groupSpellInfo.Controls.Add(this.label40);
            this.groupSpellInfo.Controls.Add(this.txtAuraDesc);
            this.groupSpellInfo.Controls.Add(this.cmbSpellFamily);
            this.groupSpellInfo.Controls.Add(this.txtSpellNameSubtext);
            this.groupSpellInfo.Controls.Add(this.label17);
            this.groupSpellInfo.Controls.Add(this.label20);
            this.groupSpellInfo.Controls.Add(this.txtSpellName);
            this.groupSpellInfo.Controls.Add(this.label18);
            this.groupSpellInfo.Controls.Add(this.label19);
            this.groupSpellInfo.Controls.Add(this.txtSpellDesc);
            this.groupSpellInfo.Location = new System.Drawing.Point(7, 4);
            this.groupSpellInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupSpellInfo.Name = "groupSpellInfo";
            this.groupSpellInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupSpellInfo.Size = new System.Drawing.Size(408, 870);
            this.groupSpellInfo.TabIndex = 6;
            this.groupSpellInfo.TabStop = false;
            this.groupSpellInfo.Text = "Spell Info";
            // 
            // spellIdChanger
            // 
            this.spellIdChanger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spellIdChanger.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spellIdChanger.Location = new System.Drawing.Point(123, 1);
            this.spellIdChanger.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spellIdChanger.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.spellIdChanger.Name = "spellIdChanger";
            this.spellIdChanger.ReadOnly = true;
            this.spellIdChanger.Size = new System.Drawing.Size(277, 27);
            this.spellIdChanger.TabIndex = 70;
            // 
            // txtLaunchDelay
            // 
            this.txtLaunchDelay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLaunchDelay.Location = new System.Drawing.Point(123, 739);
            this.txtLaunchDelay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLaunchDelay.Name = "txtLaunchDelay";
            this.txtLaunchDelay.Size = new System.Drawing.Size(277, 27);
            this.txtLaunchDelay.TabIndex = 69;
            this.txtLaunchDelay.Tag = "";
            this.txtLaunchDelay.Text = "0";
            // 
            // label204
            // 
            this.label204.AutoSize = true;
            this.label204.Location = new System.Drawing.Point(27, 743);
            this.label204.Name = "label204";
            this.label204.Size = new System.Drawing.Size(97, 20);
            this.label204.TabIndex = 68;
            this.label204.Text = "Launch Delay";
            // 
            // numModalNextSpell
            // 
            this.numModalNextSpell.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numModalNextSpell.Location = new System.Drawing.Point(123, 584);
            this.numModalNextSpell.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numModalNextSpell.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numModalNextSpell.Name = "numModalNextSpell";
            this.numModalNextSpell.Size = new System.Drawing.Size(277, 27);
            this.numModalNextSpell.TabIndex = 67;
            // 
            // label197
            // 
            this.label197.AutoSize = true;
            this.label197.Location = new System.Drawing.Point(6, 587);
            this.label197.Name = "label197";
            this.label197.Size = new System.Drawing.Size(124, 20);
            this.label197.TabIndex = 66;
            this.label197.Text = "Modal Next Spell";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpeed.Location = new System.Drawing.Point(123, 700);
            this.txtSpeed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(277, 27);
            this.txtSpeed.TabIndex = 65;
            this.txtSpeed.Tag = "";
            this.txtSpeed.Text = "0";
            // 
            // label137
            // 
            this.label137.AutoSize = true;
            this.label137.Location = new System.Drawing.Point(72, 704);
            this.label137.Name = "label137";
            this.label137.Size = new System.Drawing.Size(51, 20);
            this.label137.TabIndex = 64;
            this.label137.Text = "Speed";
            // 
            // mlcmbRange
            // 
            this.mlcmbRange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mlcmbRange.DisplayMember = "id";
            this.mlcmbRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mlcmbRange.FormattingEnabled = true;
            this.mlcmbRange.ListItemDisplayMember = "display";
            this.mlcmbRange.Location = new System.Drawing.Point(123, 816);
            this.mlcmbRange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mlcmbRange.Name = "mlcmbRange";
            this.mlcmbRange.Size = new System.Drawing.Size(277, 28);
            this.mlcmbRange.TabIndex = 63;
            this.mlcmbRange.ValueMember = "id";
            // 
            // mlcmbDuration
            // 
            this.mlcmbDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mlcmbDuration.DisplayMember = "name";
            this.mlcmbDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mlcmbDuration.FormattingEnabled = true;
            this.mlcmbDuration.ListItemDisplayMember = "display";
            this.mlcmbDuration.Location = new System.Drawing.Point(123, 661);
            this.mlcmbDuration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mlcmbDuration.Name = "mlcmbDuration";
            this.mlcmbDuration.Size = new System.Drawing.Size(277, 28);
            this.mlcmbDuration.TabIndex = 8;
            this.mlcmbDuration.ValueMember = "id";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(71, 820);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(51, 20);
            this.label74.TabIndex = 62;
            this.label74.Text = "Range";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(56, 665);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(67, 20);
            this.label71.TabIndex = 53;
            this.label71.Text = "Duration";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(49, 781);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(74, 20);
            this.label73.TabIndex = 58;
            this.label73.Text = "Cast Time";
            // 
            // cmbCastTime
            // 
            this.cmbCastTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCastTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCastTime.Location = new System.Drawing.Point(123, 777);
            this.cmbCastTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCastTime.MaxDropDownItems = 2;
            this.cmbCastTime.Name = "cmbCastTime";
            this.cmbCastTime.Size = new System.Drawing.Size(277, 28);
            this.cmbCastTime.TabIndex = 57;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(23, 625);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(101, 20);
            this.label69.TabIndex = 51;
            this.label69.Text = "Stack Amount";
            // 
            // numStackAmount
            // 
            this.numStackAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numStackAmount.Location = new System.Drawing.Point(123, 623);
            this.numStackAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numStackAmount.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numStackAmount.Name = "numStackAmount";
            this.numStackAmount.Size = new System.Drawing.Size(277, 27);
            this.numStackAmount.TabIndex = 50;
            // 
            // numFamilyFlags4
            // 
            this.numFamilyFlags4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numFamilyFlags4.Location = new System.Drawing.Point(123, 545);
            this.numFamilyFlags4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numFamilyFlags4.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numFamilyFlags4.Name = "numFamilyFlags4";
            this.numFamilyFlags4.Size = new System.Drawing.Size(277, 27);
            this.numFamilyFlags4.TabIndex = 49;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(24, 548);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(101, 20);
            this.label44.TabIndex = 48;
            this.label44.Text = "Family Flags 4";
            // 
            // numFamilyFlags3
            // 
            this.numFamilyFlags3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numFamilyFlags3.Location = new System.Drawing.Point(123, 507);
            this.numFamilyFlags3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numFamilyFlags3.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numFamilyFlags3.Name = "numFamilyFlags3";
            this.numFamilyFlags3.Size = new System.Drawing.Size(277, 27);
            this.numFamilyFlags3.TabIndex = 47;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(24, 509);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(101, 20);
            this.label43.TabIndex = 46;
            this.label43.Text = "Family Flags 3";
            // 
            // numFamilyFlags2
            // 
            this.numFamilyFlags2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numFamilyFlags2.Location = new System.Drawing.Point(123, 468);
            this.numFamilyFlags2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numFamilyFlags2.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numFamilyFlags2.Name = "numFamilyFlags2";
            this.numFamilyFlags2.Size = new System.Drawing.Size(277, 27);
            this.numFamilyFlags2.TabIndex = 45;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(24, 471);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(101, 20);
            this.label42.TabIndex = 44;
            this.label42.Text = "Family Flags 2";
            // 
            // numFamilyFlags1
            // 
            this.numFamilyFlags1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numFamilyFlags1.Location = new System.Drawing.Point(123, 429);
            this.numFamilyFlags1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numFamilyFlags1.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numFamilyFlags1.Name = "numFamilyFlags1";
            this.numFamilyFlags1.Size = new System.Drawing.Size(277, 27);
            this.numFamilyFlags1.TabIndex = 43;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(24, 432);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(101, 20);
            this.label41.TabIndex = 42;
            this.label41.Text = "Family Flags 1";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(37, 395);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(88, 20);
            this.label40.TabIndex = 43;
            this.label40.Text = "Spell Family";
            // 
            // txtAuraDesc
            // 
            this.txtAuraDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuraDesc.Location = new System.Drawing.Point(123, 248);
            this.txtAuraDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAuraDesc.Multiline = true;
            this.txtAuraDesc.Name = "txtAuraDesc";
            this.txtAuraDesc.PlaceholderText = "Aura Description";
            this.txtAuraDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAuraDesc.Size = new System.Drawing.Size(277, 132);
            this.txtAuraDesc.TabIndex = 4;
            // 
            // cmbSpellFamily
            // 
            this.cmbSpellFamily.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSpellFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpellFamily.Location = new System.Drawing.Point(123, 391);
            this.cmbSpellFamily.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSpellFamily.MaxDropDownItems = 2;
            this.cmbSpellFamily.Name = "cmbSpellFamily";
            this.cmbSpellFamily.Size = new System.Drawing.Size(277, 28);
            this.cmbSpellFamily.TabIndex = 42;
            // 
            // txtSpellNameSubtext
            // 
            this.txtSpellNameSubtext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpellNameSubtext.Location = new System.Drawing.Point(123, 68);
            this.txtSpellNameSubtext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSpellNameSubtext.Name = "txtSpellNameSubtext";
            this.txtSpellNameSubtext.PlaceholderText = "Spell Name Subtext";
            this.txtSpellNameSubtext.Size = new System.Drawing.Size(277, 27);
            this.txtSpellNameSubtext.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(72, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Name";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(23, 72);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(103, 20);
            this.label20.TabIndex = 5;
            this.label20.Text = "Name Subtext";
            // 
            // txtSpellName
            // 
            this.txtSpellName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpellName.Location = new System.Drawing.Point(123, 37);
            this.txtSpellName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSpellName.Name = "txtSpellName";
            this.txtSpellName.PlaceholderText = "Spell Name";
            this.txtSpellName.Size = new System.Drawing.Size(277, 27);
            this.txtSpellName.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(40, 111);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 20);
            this.label18.TabIndex = 2;
            this.label18.Text = "Description";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 252);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 20);
            this.label19.TabIndex = 4;
            this.label19.Text = "Aura Description";
            // 
            // txtSpellDesc
            // 
            this.txtSpellDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpellDesc.Location = new System.Drawing.Point(123, 107);
            this.txtSpellDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSpellDesc.Multiline = true;
            this.txtSpellDesc.Name = "txtSpellDesc";
            this.txtSpellDesc.PlaceholderText = "Spell Description";
            this.txtSpellDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSpellDesc.Size = new System.Drawing.Size(277, 132);
            this.txtSpellDesc.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tabsPowerConfig);
            this.groupBox1.Location = new System.Drawing.Point(421, 548);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(707, 317);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Power";
            // 
            // tabsPowerConfig
            // 
            this.tabsPowerConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabsPowerConfig.Controls.Add(this.tabPower1);
            this.tabsPowerConfig.Controls.Add(this.tabPower2);
            this.tabsPowerConfig.Controls.Add(this.tabPower3);
            this.tabsPowerConfig.Controls.Add(this.tabPower4);
            this.tabsPowerConfig.Location = new System.Drawing.Point(7, 29);
            this.tabsPowerConfig.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabsPowerConfig.Name = "tabsPowerConfig";
            this.tabsPowerConfig.SelectedIndex = 0;
            this.tabsPowerConfig.Size = new System.Drawing.Size(694, 272);
            this.tabsPowerConfig.TabIndex = 0;
            // 
            // tabPower1
            // 
            this.tabPower1.Controls.Add(this.numericUpDown13);
            this.tabPower1.Controls.Add(this.label96);
            this.tabPower1.Controls.Add(this.numericUpDown12);
            this.tabPower1.Controls.Add(this.label95);
            this.tabPower1.Controls.Add(this.txtPwrCostPerSec1);
            this.tabPower1.Controls.Add(this.label94);
            this.tabPower1.Controls.Add(this.txtPwrCostMaxPct1);
            this.tabPower1.Controls.Add(this.label93);
            this.tabPower1.Controls.Add(this.txtPwrCost1);
            this.tabPower1.Controls.Add(this.label92);
            this.tabPower1.Controls.Add(this.numericUpDown11);
            this.tabPower1.Controls.Add(this.label91);
            this.tabPower1.Controls.Add(this.numericUpDown10);
            this.tabPower1.Controls.Add(this.label37);
            this.tabPower1.Controls.Add(this.label90);
            this.tabPower1.Controls.Add(this.numericUpDown9);
            this.tabPower1.Controls.Add(this.label89);
            this.tabPower1.Controls.Add(this.numericUpDown8);
            this.tabPower1.Controls.Add(this.cmbPowerType1);
            this.tabPower1.Controls.Add(this.label88);
            this.tabPower1.Controls.Add(this.numTypeMask);
            this.tabPower1.Controls.Add(this.label31);
            this.tabPower1.Location = new System.Drawing.Point(4, 29);
            this.tabPower1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPower1.Name = "tabPower1";
            this.tabPower1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPower1.Size = new System.Drawing.Size(686, 239);
            this.tabPower1.TabIndex = 0;
            this.tabPower1.Text = "Cost 1";
            this.tabPower1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown13
            // 
            this.numericUpDown13.Location = new System.Drawing.Point(153, 204);
            this.numericUpDown13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown13.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numericUpDown13.Name = "numericUpDown13";
            this.numericUpDown13.Size = new System.Drawing.Size(126, 27);
            this.numericUpDown13.TabIndex = 48;
            this.numericUpDown13.Tag = "RequiredAuraID";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(27, 204);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(123, 20);
            this.label96.TabIndex = 47;
            this.label96.Text = "Required Aura ID";
            // 
            // numericUpDown12
            // 
            this.numericUpDown12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown12.Location = new System.Drawing.Point(453, 163);
            this.numericUpDown12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown12.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numericUpDown12.Name = "numericUpDown12";
            this.numericUpDown12.Size = new System.Drawing.Size(126, 27);
            this.numericUpDown12.TabIndex = 46;
            this.numericUpDown12.Tag = "OptionalCost";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(352, 165);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(100, 20);
            this.label95.TabIndex = 45;
            this.label95.Text = "Optional Cost";
            // 
            // txtPwrCostPerSec1
            // 
            this.txtPwrCostPerSec1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPwrCostPerSec1.Location = new System.Drawing.Point(453, 124);
            this.txtPwrCostPerSec1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPwrCostPerSec1.Name = "txtPwrCostPerSec1";
            this.txtPwrCostPerSec1.Size = new System.Drawing.Size(125, 27);
            this.txtPwrCostPerSec1.TabIndex = 44;
            this.txtPwrCostPerSec1.Tag = "PowerPctPerSecond";
            this.txtPwrCostPerSec1.Text = "0";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(304, 127);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(149, 20);
            this.label94.TabIndex = 43;
            this.label94.Text = "Power Pct Per Second";
            // 
            // txtPwrCostMaxPct1
            // 
            this.txtPwrCostMaxPct1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPwrCostMaxPct1.Location = new System.Drawing.Point(453, 85);
            this.txtPwrCostMaxPct1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPwrCostMaxPct1.Name = "txtPwrCostMaxPct1";
            this.txtPwrCostMaxPct1.Size = new System.Drawing.Size(125, 27);
            this.txtPwrCostMaxPct1.TabIndex = 42;
            this.txtPwrCostMaxPct1.Tag = "PowerCostMaxPct";
            this.txtPwrCostMaxPct1.Text = "0";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(314, 89);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(137, 20);
            this.label93.TabIndex = 41;
            this.label93.Text = "Power Cost Max Pct";
            // 
            // txtPwrCost1
            // 
            this.txtPwrCost1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPwrCost1.Location = new System.Drawing.Point(455, 47);
            this.txtPwrCost1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPwrCost1.Name = "txtPwrCost1";
            this.txtPwrCost1.Size = new System.Drawing.Size(125, 27);
            this.txtPwrCost1.TabIndex = 40;
            this.txtPwrCost1.Tag = "PowerCostPct";
            this.txtPwrCost1.Text = "0";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(344, 51);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(105, 20);
            this.label92.TabIndex = 39;
            this.label92.Text = "Power Cost Pct";
            // 
            // numericUpDown11
            // 
            this.numericUpDown11.Location = new System.Drawing.Point(153, 163);
            this.numericUpDown11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown11.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown11.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numericUpDown11.Name = "numericUpDown11";
            this.numericUpDown11.Size = new System.Drawing.Size(126, 27);
            this.numericUpDown11.TabIndex = 35;
            this.numericUpDown11.Tag = "AltPowerBarID";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(32, 165);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(117, 20);
            this.label91.TabIndex = 34;
            this.label91.Text = "Alt Power Bar ID";
            // 
            // numericUpDown10
            // 
            this.numericUpDown10.Location = new System.Drawing.Point(153, 124);
            this.numericUpDown10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown10.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numericUpDown10.Name = "numericUpDown10";
            this.numericUpDown10.Size = new System.Drawing.Size(126, 27);
            this.numericUpDown10.TabIndex = 33;
            this.numericUpDown10.Tag = "PowerDisplayID";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(367, 12);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(84, 20);
            this.label37.TabIndex = 38;
            this.label37.Text = "Power Type";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(29, 127);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(121, 20);
            this.label90.TabIndex = 32;
            this.label90.Text = "Power Display ID";
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.Location = new System.Drawing.Point(153, 83);
            this.numericUpDown9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown9.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown9.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(126, 27);
            this.numericUpDown9.TabIndex = 31;
            this.numericUpDown9.Tag = "ManaPerSecond";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(21, 88);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(126, 20);
            this.label89.TabIndex = 30;
            this.label89.Text = "Power Per Second";
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Location = new System.Drawing.Point(153, 48);
            this.numericUpDown8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown8.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown8.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(126, 27);
            this.numericUpDown8.TabIndex = 29;
            this.numericUpDown8.Tag = "ManaCostPerLevel";
            // 
            // cmbPowerType1
            // 
            this.cmbPowerType1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPowerType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPowerType1.Location = new System.Drawing.Point(454, 8);
            this.cmbPowerType1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPowerType1.MaxDropDownItems = 2;
            this.cmbPowerType1.Name = "cmbPowerType1";
            this.cmbPowerType1.Size = new System.Drawing.Size(226, 28);
            this.cmbPowerType1.TabIndex = 34;
            this.cmbPowerType1.Tag = "PowerType";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(3, 51);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(144, 20);
            this.label88.TabIndex = 28;
            this.label88.Text = "Power Cost Per Level";
            // 
            // numTypeMask
            // 
            this.numTypeMask.Location = new System.Drawing.Point(153, 9);
            this.numTypeMask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numTypeMask.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numTypeMask.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numTypeMask.Name = "numTypeMask";
            this.numTypeMask.Size = new System.Drawing.Size(126, 27);
            this.numTypeMask.TabIndex = 27;
            this.numTypeMask.Tag = "ManaCost";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(61, 12);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(82, 20);
            this.label31.TabIndex = 26;
            this.label31.Text = "Power Cost";
            // 
            // tabPower2
            // 
            this.tabPower2.Controls.Add(this.label105);
            this.tabPower2.Controls.Add(this.numericUpDown14);
            this.tabPower2.Controls.Add(this.label106);
            this.tabPower2.Controls.Add(this.label107);
            this.tabPower2.Controls.Add(this.label97);
            this.tabPower2.Controls.Add(this.numericUpDown15);
            this.tabPower2.Controls.Add(this.label98);
            this.tabPower2.Controls.Add(this.txtPwrCostPerSec2);
            this.tabPower2.Controls.Add(this.label99);
            this.tabPower2.Controls.Add(this.txtPwrCostMaxPct2);
            this.tabPower2.Controls.Add(this.label100);
            this.tabPower2.Controls.Add(this.txtPwrCost2);
            this.tabPower2.Controls.Add(this.label101);
            this.tabPower2.Controls.Add(this.numericUpDown16);
            this.tabPower2.Controls.Add(this.label102);
            this.tabPower2.Controls.Add(this.numericUpDown17);
            this.tabPower2.Controls.Add(this.label103);
            this.tabPower2.Controls.Add(this.label104);
            this.tabPower2.Controls.Add(this.numericUpDown18);
            this.tabPower2.Controls.Add(this.numericUpDown19);
            this.tabPower2.Controls.Add(this.cmbPowerType2);
            this.tabPower2.Controls.Add(this.numericUpDown20);
            this.tabPower2.Location = new System.Drawing.Point(4, 29);
            this.tabPower2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPower2.Name = "tabPower2";
            this.tabPower2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPower2.Size = new System.Drawing.Size(686, 239);
            this.tabPower2.TabIndex = 1;
            this.tabPower2.Text = "Cost 2";
            this.tabPower2.UseVisualStyleBackColor = true;
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(21, 88);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(126, 20);
            this.label105.TabIndex = 51;
            this.label105.Text = "Power Per Second";
            // 
            // numericUpDown14
            // 
            this.numericUpDown14.Location = new System.Drawing.Point(154, 201);
            this.numericUpDown14.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown14.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numericUpDown14.Name = "numericUpDown14";
            this.numericUpDown14.Size = new System.Drawing.Size(126, 27);
            this.numericUpDown14.TabIndex = 70;
            this.numericUpDown14.Tag = "RequiredAuraID";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(3, 51);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(144, 20);
            this.label106.TabIndex = 50;
            this.label106.Text = "Power Cost Per Level";
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(61, 12);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(82, 20);
            this.label107.TabIndex = 49;
            this.label107.Text = "Power Cost";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(27, 204);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(123, 20);
            this.label97.TabIndex = 69;
            this.label97.Text = "Required Aura ID";
            // 
            // numericUpDown15
            // 
            this.numericUpDown15.Location = new System.Drawing.Point(450, 163);
            this.numericUpDown15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown15.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numericUpDown15.Name = "numericUpDown15";
            this.numericUpDown15.Size = new System.Drawing.Size(126, 27);
            this.numericUpDown15.TabIndex = 68;
            this.numericUpDown15.Tag = "OptionalCost";
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(352, 165);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(100, 20);
            this.label98.TabIndex = 67;
            this.label98.Text = "Optional Cost";
            // 
            // txtPwrCostPerSec2
            // 
            this.txtPwrCostPerSec2.Location = new System.Drawing.Point(450, 124);
            this.txtPwrCostPerSec2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPwrCostPerSec2.Name = "txtPwrCostPerSec2";
            this.txtPwrCostPerSec2.Size = new System.Drawing.Size(125, 27);
            this.txtPwrCostPerSec2.TabIndex = 66;
            this.txtPwrCostPerSec2.Tag = "PowerPctPerSecond";
            this.txtPwrCostPerSec2.Text = "0";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(304, 127);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(149, 20);
            this.label99.TabIndex = 65;
            this.label99.Text = "Power Pct Per Second";
            // 
            // txtPwrCostMaxPct2
            // 
            this.txtPwrCostMaxPct2.Location = new System.Drawing.Point(450, 85);
            this.txtPwrCostMaxPct2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPwrCostMaxPct2.Name = "txtPwrCostMaxPct2";
            this.txtPwrCostMaxPct2.Size = new System.Drawing.Size(125, 27);
            this.txtPwrCostMaxPct2.TabIndex = 64;
            this.txtPwrCostMaxPct2.Tag = "PowerCostMaxPct";
            this.txtPwrCostMaxPct2.Text = "0";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(314, 89);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(137, 20);
            this.label100.TabIndex = 63;
            this.label100.Text = "Power Cost Max Pct";
            // 
            // txtPwrCost2
            // 
            this.txtPwrCost2.Location = new System.Drawing.Point(450, 47);
            this.txtPwrCost2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPwrCost2.Name = "txtPwrCost2";
            this.txtPwrCost2.Size = new System.Drawing.Size(125, 27);
            this.txtPwrCost2.TabIndex = 62;
            this.txtPwrCost2.Tag = "PowerCostPct";
            this.txtPwrCost2.Text = "0";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(344, 51);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(105, 20);
            this.label101.TabIndex = 61;
            this.label101.Text = "Power Cost Pct";
            // 
            // numericUpDown16
            // 
            this.numericUpDown16.Location = new System.Drawing.Point(154, 163);
            this.numericUpDown16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown16.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown16.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numericUpDown16.Name = "numericUpDown16";
            this.numericUpDown16.Size = new System.Drawing.Size(126, 27);
            this.numericUpDown16.TabIndex = 59;
            this.numericUpDown16.Tag = "AltPowerBarID";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(32, 165);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(117, 20);
            this.label102.TabIndex = 58;
            this.label102.Text = "Alt Power Bar ID";
            // 
            // numericUpDown17
            // 
            this.numericUpDown17.Location = new System.Drawing.Point(154, 124);
            this.numericUpDown17.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown17.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numericUpDown17.Name = "numericUpDown17";
            this.numericUpDown17.Size = new System.Drawing.Size(126, 27);
            this.numericUpDown17.TabIndex = 56;
            this.numericUpDown17.Tag = "PowerDisplayID";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(367, 12);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(84, 20);
            this.label103.TabIndex = 60;
            this.label103.Text = "Power Type";
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(29, 127);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(121, 20);
            this.label104.TabIndex = 55;
            this.label104.Text = "Power Display ID";
            // 
            // numericUpDown18
            // 
            this.numericUpDown18.Location = new System.Drawing.Point(154, 85);
            this.numericUpDown18.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown18.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown18.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numericUpDown18.Name = "numericUpDown18";
            this.numericUpDown18.Size = new System.Drawing.Size(126, 27);
            this.numericUpDown18.TabIndex = 54;
            this.numericUpDown18.Tag = "ManaPerSecond";
            // 
            // numericUpDown19
            // 
            this.numericUpDown19.Location = new System.Drawing.Point(154, 47);
            this.numericUpDown19.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown19.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown19.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numericUpDown19.Name = "numericUpDown19";
            this.numericUpDown19.Size = new System.Drawing.Size(126, 27);
            this.numericUpDown19.TabIndex = 52;
            this.numericUpDown19.Tag = "ManaCostPerLevel";
            // 
            // cmbPowerType2
            // 
            this.cmbPowerType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPowerType2.Location = new System.Drawing.Point(450, 8);
            this.cmbPowerType2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPowerType2.MaxDropDownItems = 2;
            this.cmbPowerType2.Name = "cmbPowerType2";
            this.cmbPowerType2.Size = new System.Drawing.Size(230, 28);
            this.cmbPowerType2.TabIndex = 57;
            this.cmbPowerType2.Tag = "PowerType";
            // 
            // numericUpDown20
            // 
            this.numericUpDown20.Location = new System.Drawing.Point(154, 8);
            this.numericUpDown20.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown20.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown20.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numericUpDown20.Name = "numericUpDown20";
            this.numericUpDown20.Size = new System.Drawing.Size(126, 27);
            this.numericUpDown20.TabIndex = 50;
            this.numericUpDown20.Tag = "ManaCost";
            // 
            // tabPower3
            // 
            this.tabPower3.Controls.Add(this.label116);
            this.tabPower3.Controls.Add(this.numericUpDown21);
            this.tabPower3.Controls.Add(this.label117);
            this.tabPower3.Controls.Add(this.label118);
            this.tabPower3.Controls.Add(this.label108);
            this.tabPower3.Controls.Add(this.numOptionalCost3);
            this.tabPower3.Controls.Add(this.label109);
            this.tabPower3.Controls.Add(this.txtPwrCostPerSec3);
            this.tabPower3.Controls.Add(this.label110);
            this.tabPower3.Controls.Add(this.txtPwrCostMaxPct3);
            this.tabPower3.Controls.Add(this.label111);
            this.tabPower3.Controls.Add(this.txtPwrCost3);
            this.tabPower3.Controls.Add(this.label112);
            this.tabPower3.Controls.Add(this.numericUpDown23);
            this.tabPower3.Controls.Add(this.label113);
            this.tabPower3.Controls.Add(this.numericUpDown24);
            this.tabPower3.Controls.Add(this.label114);
            this.tabPower3.Controls.Add(this.label115);
            this.tabPower3.Controls.Add(this.numericUpDown25);
            this.tabPower3.Controls.Add(this.numericUpDown26);
            this.tabPower3.Controls.Add(this.cmbPowerType3);
            this.tabPower3.Controls.Add(this.numericUpDown27);
            this.tabPower3.Location = new System.Drawing.Point(4, 29);
            this.tabPower3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPower3.Name = "tabPower3";
            this.tabPower3.Size = new System.Drawing.Size(686, 239);
            this.tabPower3.TabIndex = 2;
            this.tabPower3.Text = "Cost 3";
            this.tabPower3.UseVisualStyleBackColor = true;
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Location = new System.Drawing.Point(21, 88);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(126, 20);
            this.label116.TabIndex = 51;
            this.label116.Text = "Power Per Second";
            // 
            // numericUpDown21
            // 
            this.numericUpDown21.Location = new System.Drawing.Point(153, 203);
            this.numericUpDown21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown21.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numericUpDown21.Name = "numericUpDown21";
            this.numericUpDown21.Size = new System.Drawing.Size(126, 27);
            this.numericUpDown21.TabIndex = 70;
            this.numericUpDown21.Tag = "RequiredAuraID";
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Location = new System.Drawing.Point(3, 51);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(144, 20);
            this.label117.TabIndex = 50;
            this.label117.Text = "Power Cost Per Level";
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(61, 12);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(82, 20);
            this.label118.TabIndex = 49;
            this.label118.Text = "Power Cost";
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(27, 204);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(123, 20);
            this.label108.TabIndex = 69;
            this.label108.Text = "Required Aura ID";
            // 
            // numOptionalCost3
            // 
            this.numOptionalCost3.Location = new System.Drawing.Point(450, 163);
            this.numOptionalCost3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numOptionalCost3.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numOptionalCost3.Name = "numOptionalCost3";
            this.numOptionalCost3.Size = new System.Drawing.Size(126, 27);
            this.numOptionalCost3.TabIndex = 68;
            this.numOptionalCost3.Tag = "OptionalCost";
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(352, 165);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(100, 20);
            this.label109.TabIndex = 67;
            this.label109.Text = "Optional Cost";
            // 
            // txtPwrCostPerSec3
            // 
            this.txtPwrCostPerSec3.Location = new System.Drawing.Point(450, 124);
            this.txtPwrCostPerSec3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPwrCostPerSec3.Name = "txtPwrCostPerSec3";
            this.txtPwrCostPerSec3.Size = new System.Drawing.Size(125, 27);
            this.txtPwrCostPerSec3.TabIndex = 66;
            this.txtPwrCostPerSec3.Tag = "PowerPctPerSecond";
            this.txtPwrCostPerSec3.Text = "0";
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(304, 127);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(149, 20);
            this.label110.TabIndex = 65;
            this.label110.Text = "Power Pct Per Second";
            // 
            // txtPwrCostMaxPct3
            // 
            this.txtPwrCostMaxPct3.Location = new System.Drawing.Point(450, 85);
            this.txtPwrCostMaxPct3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPwrCostMaxPct3.Name = "txtPwrCostMaxPct3";
            this.txtPwrCostMaxPct3.Size = new System.Drawing.Size(125, 27);
            this.txtPwrCostMaxPct3.TabIndex = 64;
            this.txtPwrCostMaxPct3.Tag = "PowerCostMaxPct";
            this.txtPwrCostMaxPct3.Text = "0";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(314, 89);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(137, 20);
            this.label111.TabIndex = 63;
            this.label111.Text = "Power Cost Max Pct";
            // 
            // txtPwrCost3
            // 
            this.txtPwrCost3.Location = new System.Drawing.Point(450, 47);
            this.txtPwrCost3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPwrCost3.Name = "txtPwrCost3";
            this.txtPwrCost3.Size = new System.Drawing.Size(125, 27);
            this.txtPwrCost3.TabIndex = 62;
            this.txtPwrCost3.Tag = "PowerCostPct";
            this.txtPwrCost3.Text = "0";
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(344, 51);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(105, 20);
            this.label112.TabIndex = 61;
            this.label112.Text = "Power Cost Pct";
            // 
            // numericUpDown23
            // 
            this.numericUpDown23.Location = new System.Drawing.Point(153, 164);
            this.numericUpDown23.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown23.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown23.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numericUpDown23.Name = "numericUpDown23";
            this.numericUpDown23.Size = new System.Drawing.Size(126, 27);
            this.numericUpDown23.TabIndex = 59;
            this.numericUpDown23.Tag = "AltPowerBarID";
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Location = new System.Drawing.Point(32, 165);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(117, 20);
            this.label113.TabIndex = 58;
            this.label113.Text = "Alt Power Bar ID";
            // 
            // numericUpDown24
            // 
            this.numericUpDown24.Location = new System.Drawing.Point(153, 125);
            this.numericUpDown24.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown24.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numericUpDown24.Name = "numericUpDown24";
            this.numericUpDown24.Size = new System.Drawing.Size(126, 27);
            this.numericUpDown24.TabIndex = 56;
            this.numericUpDown24.Tag = "PowerDisplayID";
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(367, 12);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(84, 20);
            this.label114.TabIndex = 60;
            this.label114.Text = "Power Type";
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Location = new System.Drawing.Point(29, 127);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(121, 20);
            this.label115.TabIndex = 55;
            this.label115.Text = "Power Display ID";
            // 
            // numericUpDown25
            // 
            this.numericUpDown25.Location = new System.Drawing.Point(153, 85);
            this.numericUpDown25.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown25.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown25.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numericUpDown25.Name = "numericUpDown25";
            this.numericUpDown25.Size = new System.Drawing.Size(126, 27);
            this.numericUpDown25.TabIndex = 54;
            this.numericUpDown25.Tag = "ManaPerSecond";
            // 
            // numericUpDown26
            // 
            this.numericUpDown26.Location = new System.Drawing.Point(153, 48);
            this.numericUpDown26.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown26.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown26.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numericUpDown26.Name = "numericUpDown26";
            this.numericUpDown26.Size = new System.Drawing.Size(126, 27);
            this.numericUpDown26.TabIndex = 52;
            this.numericUpDown26.Tag = "ManaCostPerLevel";
            // 
            // cmbPowerType3
            // 
            this.cmbPowerType3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPowerType3.Location = new System.Drawing.Point(450, 8);
            this.cmbPowerType3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPowerType3.MaxDropDownItems = 2;
            this.cmbPowerType3.Name = "cmbPowerType3";
            this.cmbPowerType3.Size = new System.Drawing.Size(233, 28);
            this.cmbPowerType3.TabIndex = 57;
            this.cmbPowerType3.Tag = "PowerType";
            // 
            // numericUpDown27
            // 
            this.numericUpDown27.Location = new System.Drawing.Point(153, 9);
            this.numericUpDown27.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown27.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown27.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numericUpDown27.Name = "numericUpDown27";
            this.numericUpDown27.Size = new System.Drawing.Size(126, 27);
            this.numericUpDown27.TabIndex = 50;
            this.numericUpDown27.Tag = "ManaCost";
            // 
            // tabPower4
            // 
            this.tabPower4.Controls.Add(this.label127);
            this.tabPower4.Controls.Add(this.numericUpDown28);
            this.tabPower4.Controls.Add(this.label128);
            this.tabPower4.Controls.Add(this.label129);
            this.tabPower4.Controls.Add(this.label119);
            this.tabPower4.Controls.Add(this.numOptionalCost4);
            this.tabPower4.Controls.Add(this.label120);
            this.tabPower4.Controls.Add(this.txtPwrCostPerSec4);
            this.tabPower4.Controls.Add(this.label121);
            this.tabPower4.Controls.Add(this.txtPwrCostMaxPct4);
            this.tabPower4.Controls.Add(this.label122);
            this.tabPower4.Controls.Add(this.txtPwrCost4);
            this.tabPower4.Controls.Add(this.label123);
            this.tabPower4.Controls.Add(this.numericUpDown30);
            this.tabPower4.Controls.Add(this.label124);
            this.tabPower4.Controls.Add(this.numericUpDown31);
            this.tabPower4.Controls.Add(this.label125);
            this.tabPower4.Controls.Add(this.label126);
            this.tabPower4.Controls.Add(this.numericUpDown32);
            this.tabPower4.Controls.Add(this.numericUpDown33);
            this.tabPower4.Controls.Add(this.cmbPowerType4);
            this.tabPower4.Controls.Add(this.numericUpDown34);
            this.tabPower4.Location = new System.Drawing.Point(4, 29);
            this.tabPower4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPower4.Name = "tabPower4";
            this.tabPower4.Size = new System.Drawing.Size(686, 239);
            this.tabPower4.TabIndex = 3;
            this.tabPower4.Text = "Cost 4";
            this.tabPower4.UseVisualStyleBackColor = true;
            // 
            // label127
            // 
            this.label127.AutoSize = true;
            this.label127.Location = new System.Drawing.Point(21, 88);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(126, 20);
            this.label127.TabIndex = 51;
            this.label127.Text = "Power Per Second";
            // 
            // numericUpDown28
            // 
            this.numericUpDown28.Location = new System.Drawing.Point(149, 201);
            this.numericUpDown28.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown28.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numericUpDown28.Name = "numericUpDown28";
            this.numericUpDown28.Size = new System.Drawing.Size(126, 27);
            this.numericUpDown28.TabIndex = 70;
            this.numericUpDown28.Tag = "RequiredAuraID";
            // 
            // label128
            // 
            this.label128.AutoSize = true;
            this.label128.Location = new System.Drawing.Point(3, 51);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(144, 20);
            this.label128.TabIndex = 50;
            this.label128.Text = "Power Cost Per Level";
            // 
            // label129
            // 
            this.label129.AutoSize = true;
            this.label129.Location = new System.Drawing.Point(61, 12);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(82, 20);
            this.label129.TabIndex = 49;
            this.label129.Text = "Power Cost";
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.Location = new System.Drawing.Point(27, 204);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(123, 20);
            this.label119.TabIndex = 69;
            this.label119.Text = "Required Aura ID";
            // 
            // numOptionalCost4
            // 
            this.numOptionalCost4.Location = new System.Drawing.Point(450, 163);
            this.numOptionalCost4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numOptionalCost4.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numOptionalCost4.Name = "numOptionalCost4";
            this.numOptionalCost4.Size = new System.Drawing.Size(126, 27);
            this.numOptionalCost4.TabIndex = 68;
            this.numOptionalCost4.Tag = "OptionalCost";
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Location = new System.Drawing.Point(352, 165);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(100, 20);
            this.label120.TabIndex = 67;
            this.label120.Text = "Optional Cost";
            // 
            // txtPwrCostPerSec4
            // 
            this.txtPwrCostPerSec4.Location = new System.Drawing.Point(450, 124);
            this.txtPwrCostPerSec4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPwrCostPerSec4.Name = "txtPwrCostPerSec4";
            this.txtPwrCostPerSec4.Size = new System.Drawing.Size(125, 27);
            this.txtPwrCostPerSec4.TabIndex = 66;
            this.txtPwrCostPerSec4.Tag = "PowerPctPerSecond";
            this.txtPwrCostPerSec4.Text = "0";
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Location = new System.Drawing.Point(304, 127);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(149, 20);
            this.label121.TabIndex = 65;
            this.label121.Text = "Power Pct Per Second";
            // 
            // txtPwrCostMaxPct4
            // 
            this.txtPwrCostMaxPct4.Location = new System.Drawing.Point(450, 85);
            this.txtPwrCostMaxPct4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPwrCostMaxPct4.Name = "txtPwrCostMaxPct4";
            this.txtPwrCostMaxPct4.Size = new System.Drawing.Size(125, 27);
            this.txtPwrCostMaxPct4.TabIndex = 64;
            this.txtPwrCostMaxPct4.Tag = "PowerCostMaxPct";
            this.txtPwrCostMaxPct4.Text = "0";
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Location = new System.Drawing.Point(314, 89);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(137, 20);
            this.label122.TabIndex = 63;
            this.label122.Text = "Power Cost Max Pct";
            // 
            // txtPwrCost4
            // 
            this.txtPwrCost4.Location = new System.Drawing.Point(450, 47);
            this.txtPwrCost4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPwrCost4.Name = "txtPwrCost4";
            this.txtPwrCost4.Size = new System.Drawing.Size(125, 27);
            this.txtPwrCost4.TabIndex = 62;
            this.txtPwrCost4.Tag = "PowerCostPct";
            this.txtPwrCost4.Text = "0";
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(344, 51);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(105, 20);
            this.label123.TabIndex = 61;
            this.label123.Text = "Power Cost Pct";
            // 
            // numericUpDown30
            // 
            this.numericUpDown30.Location = new System.Drawing.Point(149, 163);
            this.numericUpDown30.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown30.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown30.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numericUpDown30.Name = "numericUpDown30";
            this.numericUpDown30.Size = new System.Drawing.Size(126, 27);
            this.numericUpDown30.TabIndex = 59;
            this.numericUpDown30.Tag = "AltPowerBarID";
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.Location = new System.Drawing.Point(32, 165);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(117, 20);
            this.label124.TabIndex = 58;
            this.label124.Text = "Alt Power Bar ID";
            // 
            // numericUpDown31
            // 
            this.numericUpDown31.Location = new System.Drawing.Point(149, 124);
            this.numericUpDown31.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown31.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numericUpDown31.Name = "numericUpDown31";
            this.numericUpDown31.Size = new System.Drawing.Size(126, 27);
            this.numericUpDown31.TabIndex = 56;
            this.numericUpDown31.Tag = "PowerDisplayID";
            // 
            // label125
            // 
            this.label125.AutoSize = true;
            this.label125.Location = new System.Drawing.Point(367, 12);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(84, 20);
            this.label125.TabIndex = 60;
            this.label125.Text = "Power Type";
            // 
            // label126
            // 
            this.label126.AutoSize = true;
            this.label126.Location = new System.Drawing.Point(29, 127);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(121, 20);
            this.label126.TabIndex = 55;
            this.label126.Text = "Power Display ID";
            // 
            // numericUpDown32
            // 
            this.numericUpDown32.Location = new System.Drawing.Point(149, 85);
            this.numericUpDown32.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown32.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown32.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numericUpDown32.Name = "numericUpDown32";
            this.numericUpDown32.Size = new System.Drawing.Size(126, 27);
            this.numericUpDown32.TabIndex = 54;
            this.numericUpDown32.Tag = "ManaPerSecond";
            // 
            // numericUpDown33
            // 
            this.numericUpDown33.Location = new System.Drawing.Point(149, 47);
            this.numericUpDown33.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown33.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown33.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numericUpDown33.Name = "numericUpDown33";
            this.numericUpDown33.Size = new System.Drawing.Size(126, 27);
            this.numericUpDown33.TabIndex = 52;
            this.numericUpDown33.Tag = "ManaCostPerLevel";
            // 
            // cmbPowerType4
            // 
            this.cmbPowerType4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPowerType4.Location = new System.Drawing.Point(450, 8);
            this.cmbPowerType4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPowerType4.MaxDropDownItems = 2;
            this.cmbPowerType4.Name = "cmbPowerType4";
            this.cmbPowerType4.Size = new System.Drawing.Size(233, 28);
            this.cmbPowerType4.TabIndex = 57;
            this.cmbPowerType4.Tag = "PowerType";
            // 
            // numericUpDown34
            // 
            this.numericUpDown34.Location = new System.Drawing.Point(149, 8);
            this.numericUpDown34.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown34.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown34.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numericUpDown34.Name = "numericUpDown34";
            this.numericUpDown34.Size = new System.Drawing.Size(126, 27);
            this.numericUpDown34.TabIndex = 50;
            this.numericUpDown34.Tag = "ManaCost";
            // 
            // groupCooldown
            // 
            this.groupCooldown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupCooldown.Controls.Add(this.mlcmbEditCat);
            this.groupCooldown.Controls.Add(this.numStartCooldownTime);
            this.groupCooldown.Controls.Add(this.label205);
            this.groupCooldown.Controls.Add(this.label138);
            this.groupCooldown.Controls.Add(this.cmbPreventionType);
            this.groupCooldown.Controls.Add(this.cmbDifficultyId);
            this.groupCooldown.Controls.Add(this.label45);
            this.groupCooldown.Controls.Add(this.numChargeCat);
            this.groupCooldown.Controls.Add(this.label39);
            this.groupCooldown.Controls.Add(this.label38);
            this.groupCooldown.Controls.Add(this.label36);
            this.groupCooldown.Controls.Add(this.label35);
            this.groupCooldown.Controls.Add(this.label34);
            this.groupCooldown.Controls.Add(this.cmbDamageType);
            this.groupCooldown.Controls.Add(this.cmbMechanic);
            this.groupCooldown.Controls.Add(this.cmbDispelType);
            this.groupCooldown.Controls.Add(this.numStartRecCat);
            this.groupCooldown.Controls.Add(this.label33);
            this.groupCooldown.Controls.Add(this.label32);
            this.groupCooldown.Controls.Add(this.listCatFlags);
            this.groupCooldown.Controls.Add(this.numCatUsesPerWeek);
            this.groupCooldown.Controls.Add(this.label29);
            this.groupCooldown.Controls.Add(this.numCatId);
            this.groupCooldown.Controls.Add(this.label28);
            this.groupCooldown.Controls.Add(this.label27);
            this.groupCooldown.Controls.Add(this.numCatChargeCD);
            this.groupCooldown.Controls.Add(this.txtCatName);
            this.groupCooldown.Controls.Add(this.label26);
            this.groupCooldown.Controls.Add(this.numCatCharges);
            this.groupCooldown.Controls.Add(this.label25);
            this.groupCooldown.Controls.Add(this.btnSaveCategory);
            this.groupCooldown.Controls.Add(this.label24);
            this.groupCooldown.Controls.Add(this.numCatCooldown);
            this.groupCooldown.Controls.Add(this.numCooldown);
            this.groupCooldown.Controls.Add(this.numCategory);
            this.groupCooldown.Controls.Add(this.label23);
            this.groupCooldown.Controls.Add(this.label22);
            this.groupCooldown.Controls.Add(this.label21);
            this.groupCooldown.Location = new System.Drawing.Point(422, 5);
            this.groupCooldown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupCooldown.Name = "groupCooldown";
            this.groupCooldown.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupCooldown.Size = new System.Drawing.Size(706, 535);
            this.groupCooldown.TabIndex = 7;
            this.groupCooldown.TabStop = false;
            this.groupCooldown.Text = "Cooldown/Category";
            // 
            // mlcmbEditCat
            // 
            this.mlcmbEditCat.DisplayMember = "name";
            this.mlcmbEditCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mlcmbEditCat.FormattingEnabled = true;
            this.mlcmbEditCat.ListItemDisplayMember = "display";
            this.mlcmbEditCat.Location = new System.Drawing.Point(136, 300);
            this.mlcmbEditCat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mlcmbEditCat.Name = "mlcmbEditCat";
            this.mlcmbEditCat.Size = new System.Drawing.Size(266, 28);
            this.mlcmbEditCat.TabIndex = 48;
            this.mlcmbEditCat.ValueMember = "id";
            this.mlcmbEditCat.SelectedIndexChanged += new System.EventHandler(this.mlcmbEditCat_SelectedIndexChanged);
            // 
            // numStartCooldownTime
            // 
            this.numStartCooldownTime.Location = new System.Drawing.Point(152, 156);
            this.numStartCooldownTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numStartCooldownTime.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numStartCooldownTime.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numStartCooldownTime.Name = "numStartCooldownTime";
            this.numStartCooldownTime.Size = new System.Drawing.Size(137, 27);
            this.numStartCooldownTime.TabIndex = 47;
            // 
            // label205
            // 
            this.label205.AutoSize = true;
            this.label205.Location = new System.Drawing.Point(-1, 157);
            this.label205.Name = "label205";
            this.label205.Size = new System.Drawing.Size(149, 20);
            this.label205.TabIndex = 46;
            this.label205.Text = "Start Cooldown Time";
            // 
            // label138
            // 
            this.label138.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label138.AutoSize = true;
            this.label138.Location = new System.Drawing.Point(355, 189);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(114, 20);
            this.label138.TabIndex = 45;
            this.label138.Text = "Prevention Type";
            // 
            // cmbPreventionType
            // 
            this.cmbPreventionType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPreventionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPreventionType.Location = new System.Drawing.Point(474, 187);
            this.cmbPreventionType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPreventionType.MaxDropDownItems = 2;
            this.cmbPreventionType.Name = "cmbPreventionType";
            this.cmbPreventionType.Size = new System.Drawing.Size(222, 28);
            this.cmbPreventionType.TabIndex = 44;
            // 
            // cmbDifficultyId
            // 
            this.cmbDifficultyId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDifficultyId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDifficultyId.Location = new System.Drawing.Point(474, 108);
            this.cmbDifficultyId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDifficultyId.MaxDropDownItems = 2;
            this.cmbDifficultyId.Name = "cmbDifficultyId";
            this.cmbDifficultyId.Size = new System.Drawing.Size(222, 28);
            this.cmbDifficultyId.TabIndex = 43;
            // 
            // label45
            // 
            this.label45.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(381, 111);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(88, 20);
            this.label45.TabIndex = 42;
            this.label45.Text = "Difficulty ID";
            // 
            // numChargeCat
            // 
            this.numChargeCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numChargeCat.Location = new System.Drawing.Point(474, 31);
            this.numChargeCat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numChargeCat.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numChargeCat.Name = "numChargeCat";
            this.numChargeCat.Size = new System.Drawing.Size(222, 27);
            this.numChargeCat.TabIndex = 41;
            // 
            // label39
            // 
            this.label39.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(350, 33);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(120, 20);
            this.label39.TabIndex = 40;
            this.label39.Text = "Charge Category";
            // 
            // label38
            // 
            this.label38.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(10, 267);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(99, 20);
            this.label38.TabIndex = 39;
            this.label38.Text = "Category Info";
            // 
            // label36
            // 
            this.label36.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(370, 228);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(101, 20);
            this.label36.TabIndex = 37;
            this.label36.Text = "Damage Type";
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(392, 151);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(72, 20);
            this.label35.TabIndex = 36;
            this.label35.Text = "Mechanic";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(58, 193);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(86, 20);
            this.label34.TabIndex = 35;
            this.label34.Text = "Dispel Type";
            // 
            // cmbDamageType
            // 
            this.cmbDamageType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDamageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDamageType.Location = new System.Drawing.Point(474, 225);
            this.cmbDamageType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDamageType.MaxDropDownItems = 2;
            this.cmbDamageType.Name = "cmbDamageType";
            this.cmbDamageType.Size = new System.Drawing.Size(222, 28);
            this.cmbDamageType.TabIndex = 33;
            // 
            // cmbMechanic
            // 
            this.cmbMechanic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMechanic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMechanic.Location = new System.Drawing.Point(474, 147);
            this.cmbMechanic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbMechanic.MaxDropDownItems = 2;
            this.cmbMechanic.Name = "cmbMechanic";
            this.cmbMechanic.Size = new System.Drawing.Size(222, 28);
            this.cmbMechanic.TabIndex = 32;
            // 
            // cmbDispelType
            // 
            this.cmbDispelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDispelType.Location = new System.Drawing.Point(152, 193);
            this.cmbDispelType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDispelType.MaxDropDownItems = 2;
            this.cmbDispelType.Name = "cmbDispelType";
            this.cmbDispelType.Size = new System.Drawing.Size(177, 28);
            this.cmbDispelType.TabIndex = 28;
            // 
            // numStartRecCat
            // 
            this.numStartRecCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numStartRecCat.Location = new System.Drawing.Point(474, 69);
            this.numStartRecCat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numStartRecCat.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numStartRecCat.Name = "numStartRecCat";
            this.numStartRecCat.Size = new System.Drawing.Size(222, 27);
            this.numStartRecCat.TabIndex = 31;
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(307, 72);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(168, 20);
            this.label33.TabIndex = 30;
            this.label33.Text = "Start Recovery Category";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(86, 416);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(43, 20);
            this.label32.TabIndex = 29;
            this.label32.Text = "Flags";
            // 
            // listCatFlags
            // 
            this.listCatFlags.FormattingEnabled = true;
            this.listCatFlags.ItemHeight = 20;
            this.listCatFlags.Location = new System.Drawing.Point(137, 416);
            this.listCatFlags.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listCatFlags.Name = "listCatFlags";
            this.listCatFlags.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listCatFlags.Size = new System.Drawing.Size(341, 104);
            this.listCatFlags.TabIndex = 28;
            // 
            // numCatUsesPerWeek
            // 
            this.numCatUsesPerWeek.Location = new System.Drawing.Point(137, 377);
            this.numCatUsesPerWeek.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numCatUsesPerWeek.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numCatUsesPerWeek.Name = "numCatUsesPerWeek";
            this.numCatUsesPerWeek.Size = new System.Drawing.Size(137, 27);
            this.numCatUsesPerWeek.TabIndex = 25;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(27, 384);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(103, 20);
            this.label29.TabIndex = 24;
            this.label29.Text = "Uses Per Week";
            // 
            // numCatId
            // 
            this.numCatId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numCatId.Location = new System.Drawing.Point(474, 339);
            this.numCatId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numCatId.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numCatId.Name = "numCatId";
            this.numCatId.Size = new System.Drawing.Size(126, 27);
            this.numCatId.TabIndex = 23;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(379, 341);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(88, 20);
            this.label28.TabIndex = 22;
            this.label28.Text = "Category ID";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(419, 300);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(49, 20);
            this.label27.TabIndex = 6;
            this.label27.Text = "Name";
            // 
            // numCatChargeCD
            // 
            this.numCatChargeCD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numCatChargeCD.Location = new System.Drawing.Point(474, 377);
            this.numCatChargeCD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numCatChargeCD.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numCatChargeCD.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numCatChargeCD.Name = "numCatChargeCD";
            this.numCatChargeCD.Size = new System.Drawing.Size(126, 27);
            this.numCatChargeCD.TabIndex = 21;
            // 
            // txtCatName
            // 
            this.txtCatName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCatName.Location = new System.Drawing.Point(474, 297);
            this.txtCatName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.PlaceholderText = "Category Name";
            this.txtCatName.Size = new System.Drawing.Size(222, 27);
            this.txtCatName.TabIndex = 7;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(341, 379);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(128, 20);
            this.label26.TabIndex = 20;
            this.label26.Text = "Charge Cooldown";
            // 
            // numCatCharges
            // 
            this.numCatCharges.Location = new System.Drawing.Point(137, 339);
            this.numCatCharges.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numCatCharges.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numCatCharges.Name = "numCatCharges";
            this.numCatCharges.Size = new System.Drawing.Size(137, 27);
            this.numCatCharges.TabIndex = 19;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(39, 347);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(94, 20);
            this.label25.TabIndex = 18;
            this.label25.Text = "Max Charges";
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveCategory.Location = new System.Drawing.Point(533, 489);
            this.btnSaveCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(163, 31);
            this.btnSaveCategory.TabIndex = 17;
            this.btnSaveCategory.Text = "Save Category to DB";
            this.btnSaveCategory.UseVisualStyleBackColor = true;
            this.btnSaveCategory.Click += new System.EventHandler(this.btnSaveCategory_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(63, 308);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(69, 20);
            this.label24.TabIndex = 9;
            this.label24.Text = "Category";
            // 
            // numCatCooldown
            // 
            this.numCatCooldown.Location = new System.Drawing.Point(152, 109);
            this.numCatCooldown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numCatCooldown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numCatCooldown.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numCatCooldown.Name = "numCatCooldown";
            this.numCatCooldown.Size = new System.Drawing.Size(137, 27);
            this.numCatCooldown.TabIndex = 8;
            // 
            // numCooldown
            // 
            this.numCooldown.Location = new System.Drawing.Point(154, 71);
            this.numCooldown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numCooldown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numCooldown.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numCooldown.Name = "numCooldown";
            this.numCooldown.Size = new System.Drawing.Size(137, 27);
            this.numCooldown.TabIndex = 7;
            // 
            // numCategory
            // 
            this.numCategory.Location = new System.Drawing.Point(154, 32);
            this.numCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numCategory.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numCategory.Name = "numCategory";
            this.numCategory.Size = new System.Drawing.Size(137, 27);
            this.numCategory.TabIndex = 6;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(5, 112);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(141, 20);
            this.label23.TabIndex = 4;
            this.label23.Text = "Category Cooldown";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(63, 73);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 20);
            this.label22.TabIndex = 1;
            this.label22.Text = "Cooldown";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(55, 35);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 20);
            this.label21.TabIndex = 0;
            this.label21.Text = "Category ID";
            // 
            // tabBasicInfo2
            // 
            this.tabBasicInfo2.Controls.Add(this.groupBox9);
            this.tabBasicInfo2.Controls.Add(this.groupBox8);
            this.tabBasicInfo2.Controls.Add(this.groupBox3);
            this.tabBasicInfo2.Controls.Add(this.groupBox2);
            this.tabBasicInfo2.Location = new System.Drawing.Point(4, 29);
            this.tabBasicInfo2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabBasicInfo2.Name = "tabBasicInfo2";
            this.tabBasicInfo2.Size = new System.Drawing.Size(1134, 874);
            this.tabBasicInfo2.TabIndex = 6;
            this.tabBasicInfo2.Text = "Basic Info 2";
            this.tabBasicInfo2.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.numScalesFromItemLevel);
            this.groupBox9.Controls.Add(this.label210);
            this.groupBox9.Controls.Add(this.numMaxScalingLevel);
            this.groupBox9.Controls.Add(this.label209);
            this.groupBox9.Controls.Add(this.numMinScalingLevel);
            this.groupBox9.Controls.Add(this.label208);
            this.groupBox9.Controls.Add(this.numShowFutureSpellPlayerConditionID);
            this.groupBox9.Controls.Add(this.label207);
            this.groupBox9.Controls.Add(this.numContentTuningID);
            this.groupBox9.Controls.Add(this.label206);
            this.groupBox9.Location = new System.Drawing.Point(502, 728);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox9.Size = new System.Drawing.Size(618, 137);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Scaling";
            // 
            // numScalesFromItemLevel
            // 
            this.numScalesFromItemLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numScalesFromItemLevel.Location = new System.Drawing.Point(457, 97);
            this.numScalesFromItemLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numScalesFromItemLevel.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numScalesFromItemLevel.Name = "numScalesFromItemLevel";
            this.numScalesFromItemLevel.Size = new System.Drawing.Size(153, 27);
            this.numScalesFromItemLevel.TabIndex = 66;
            // 
            // label210
            // 
            this.label210.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label210.AutoSize = true;
            this.label210.Location = new System.Drawing.Point(345, 100);
            this.label210.Name = "label210";
            this.label210.Size = new System.Drawing.Size(111, 20);
            this.label210.TabIndex = 65;
            this.label210.Text = "Scales From ilvl";
            // 
            // numMaxScalingLevel
            // 
            this.numMaxScalingLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numMaxScalingLevel.Location = new System.Drawing.Point(457, 59);
            this.numMaxScalingLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numMaxScalingLevel.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numMaxScalingLevel.Name = "numMaxScalingLevel";
            this.numMaxScalingLevel.Size = new System.Drawing.Size(153, 27);
            this.numMaxScalingLevel.TabIndex = 64;
            // 
            // label209
            // 
            this.label209.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label209.AutoSize = true;
            this.label209.Location = new System.Drawing.Point(330, 61);
            this.label209.Name = "label209";
            this.label209.Size = new System.Drawing.Size(127, 20);
            this.label209.TabIndex = 63;
            this.label209.Text = "Max Scaling Level";
            // 
            // numMinScalingLevel
            // 
            this.numMinScalingLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numMinScalingLevel.Location = new System.Drawing.Point(459, 20);
            this.numMinScalingLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numMinScalingLevel.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numMinScalingLevel.Name = "numMinScalingLevel";
            this.numMinScalingLevel.Size = new System.Drawing.Size(153, 27);
            this.numMinScalingLevel.TabIndex = 62;
            // 
            // label208
            // 
            this.label208.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label208.AutoSize = true;
            this.label208.Location = new System.Drawing.Point(334, 23);
            this.label208.Name = "label208";
            this.label208.Size = new System.Drawing.Size(124, 20);
            this.label208.TabIndex = 61;
            this.label208.Text = "Min Scaling Level";
            // 
            // numShowFutureSpellPlayerConditionID
            // 
            this.numShowFutureSpellPlayerConditionID.Location = new System.Drawing.Point(101, 80);
            this.numShowFutureSpellPlayerConditionID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numShowFutureSpellPlayerConditionID.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numShowFutureSpellPlayerConditionID.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numShowFutureSpellPlayerConditionID.Name = "numShowFutureSpellPlayerConditionID";
            this.numShowFutureSpellPlayerConditionID.Size = new System.Drawing.Size(153, 27);
            this.numShowFutureSpellPlayerConditionID.TabIndex = 60;
            // 
            // label207
            // 
            this.label207.AutoSize = true;
            this.label207.Location = new System.Drawing.Point(7, 64);
            this.label207.Name = "label207";
            this.label207.Size = new System.Drawing.Size(94, 60);
            this.label207.TabIndex = 59;
            this.label207.Text = "Show Future \r\nSpell Player \r\nCondition ID";
            // 
            // numContentTuningID
            // 
            this.numContentTuningID.Location = new System.Drawing.Point(101, 29);
            this.numContentTuningID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numContentTuningID.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numContentTuningID.Name = "numContentTuningID";
            this.numContentTuningID.Size = new System.Drawing.Size(153, 27);
            this.numContentTuningID.TabIndex = 58;
            // 
            // label206
            // 
            this.label206.AutoSize = true;
            this.label206.Location = new System.Drawing.Point(35, 32);
            this.label206.Name = "label206";
            this.label206.Size = new System.Drawing.Size(65, 20);
            this.label206.TabIndex = 57;
            this.label206.Text = "Tunig ID";
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.txtWidth);
            this.groupBox8.Controls.Add(this.label202);
            this.groupBox8.Controls.Add(this.txtConeAngle);
            this.groupBox8.Controls.Add(this.label203);
            this.groupBox8.Controls.Add(this.listTargetCreatureType);
            this.groupBox8.Controls.Add(this.label161);
            this.groupBox8.Controls.Add(this.numMaxTargetLevel);
            this.groupBox8.Controls.Add(this.label135);
            this.groupBox8.Controls.Add(this.label136);
            this.groupBox8.Controls.Add(this.numMaxTargets);
            this.groupBox8.Location = new System.Drawing.Point(505, 356);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox8.Size = new System.Drawing.Size(615, 364);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Target Restrictions";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(135, 161);
            this.txtWidth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(231, 27);
            this.txtWidth.TabIndex = 56;
            this.txtWidth.Tag = "ResourceCoefficient";
            this.txtWidth.Text = "0";
            // 
            // label202
            // 
            this.label202.AutoSize = true;
            this.label202.Location = new System.Drawing.Point(73, 165);
            this.label202.Name = "label202";
            this.label202.Size = new System.Drawing.Size(49, 20);
            this.label202.TabIndex = 55;
            this.label202.Text = "Width";
            // 
            // txtConeAngle
            // 
            this.txtConeAngle.Location = new System.Drawing.Point(135, 123);
            this.txtConeAngle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConeAngle.Name = "txtConeAngle";
            this.txtConeAngle.Size = new System.Drawing.Size(231, 27);
            this.txtConeAngle.TabIndex = 54;
            this.txtConeAngle.Tag = "ScalingCoefficient";
            this.txtConeAngle.Text = "0";
            // 
            // label203
            // 
            this.label203.AutoSize = true;
            this.label203.Location = new System.Drawing.Point(39, 123);
            this.label203.Name = "label203";
            this.label203.Size = new System.Drawing.Size(86, 20);
            this.label203.TabIndex = 53;
            this.label203.Text = "Cone Angle";
            // 
            // listTargetCreatureType
            // 
            this.listTargetCreatureType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listTargetCreatureType.FormattingEnabled = true;
            this.listTargetCreatureType.ItemHeight = 20;
            this.listTargetCreatureType.Location = new System.Drawing.Point(375, 45);
            this.listTargetCreatureType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listTargetCreatureType.Name = "listTargetCreatureType";
            this.listTargetCreatureType.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listTargetCreatureType.Size = new System.Drawing.Size(233, 304);
            this.listTargetCreatureType.TabIndex = 12;
            // 
            // label161
            // 
            this.label161.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label161.AutoSize = true;
            this.label161.Location = new System.Drawing.Point(375, 21);
            this.label161.Name = "label161";
            this.label161.Size = new System.Drawing.Size(145, 20);
            this.label161.TabIndex = 11;
            this.label161.Text = "Target Creature Type";
            // 
            // numMaxTargetLevel
            // 
            this.numMaxTargetLevel.Location = new System.Drawing.Point(135, 45);
            this.numMaxTargetLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numMaxTargetLevel.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numMaxTargetLevel.Name = "numMaxTargetLevel";
            this.numMaxTargetLevel.Size = new System.Drawing.Size(229, 27);
            this.numMaxTargetLevel.TabIndex = 50;
            // 
            // label135
            // 
            this.label135.AutoSize = true;
            this.label135.Location = new System.Drawing.Point(9, 48);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(120, 20);
            this.label135.TabIndex = 49;
            this.label135.Text = "Max Target Level";
            // 
            // label136
            // 
            this.label136.AutoSize = true;
            this.label136.Location = new System.Drawing.Point(38, 87);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(88, 20);
            this.label136.TabIndex = 51;
            this.label136.Text = "Max Targets";
            // 
            // numMaxTargets
            // 
            this.numMaxTargets.Location = new System.Drawing.Point(135, 84);
            this.numMaxTargets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numMaxTargets.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numMaxTargets.Name = "numMaxTargets";
            this.numMaxTargets.Size = new System.Drawing.Size(229, 27);
            this.numMaxTargets.TabIndex = 52;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnVisualDelete);
            this.groupBox3.Controls.Add(this.numUnitCaster);
            this.groupBox3.Controls.Add(this.label155);
            this.groupBox3.Controls.Add(this.numPlayerCaster);
            this.groupBox3.Controls.Add(this.label154);
            this.groupBox3.Controls.Add(this.numUnitViewer);
            this.groupBox3.Controls.Add(this.label153);
            this.groupBox3.Controls.Add(this.label152);
            this.groupBox3.Controls.Add(this.label151);
            this.groupBox3.Controls.Add(this.label150);
            this.groupBox3.Controls.Add(this.numPlayerViewer);
            this.groupBox3.Controls.Add(this.label149);
            this.groupBox3.Controls.Add(this.numVisualPriority);
            this.groupBox3.Controls.Add(this.label148);
            this.groupBox3.Controls.Add(this.txtVisualProbability);
            this.groupBox3.Controls.Add(this.label147);
            this.groupBox3.Controls.Add(this.numVisualActiveIconId);
            this.groupBox3.Controls.Add(this.label146);
            this.groupBox3.Controls.Add(this.numVisualIconId);
            this.groupBox3.Controls.Add(this.label145);
            this.groupBox3.Controls.Add(this.numSpellVisualId);
            this.groupBox3.Controls.Add(this.label144);
            this.groupBox3.Controls.Add(this.btnVisualSave);
            this.groupBox3.Controls.Add(this.btnVisualCopy);
            this.groupBox3.Controls.Add(this.btnVisualNew);
            this.groupBox3.Controls.Add(this.cmbVisualDifficulty);
            this.groupBox3.Controls.Add(this.label142);
            this.groupBox3.Controls.Add(this.numVisualId);
            this.groupBox3.Controls.Add(this.label141);
            this.groupBox3.Controls.Add(this.cmbSelectVisual);
            this.groupBox3.Controls.Add(this.label140);
            this.groupBox3.Location = new System.Drawing.Point(502, 3);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(619, 343);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Visuals";
            // 
            // btnVisualDelete
            // 
            this.btnVisualDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisualDelete.Enabled = false;
            this.btnVisualDelete.Location = new System.Drawing.Point(555, 23);
            this.btnVisualDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVisualDelete.Name = "btnVisualDelete";
            this.btnVisualDelete.Size = new System.Drawing.Size(61, 31);
            this.btnVisualDelete.TabIndex = 81;
            this.btnVisualDelete.Text = "Delete";
            this.btnVisualDelete.UseVisualStyleBackColor = true;
            this.btnVisualDelete.Click += new System.EventHandler(this.btnVisualDelete_Click);
            // 
            // numUnitCaster
            // 
            this.numUnitCaster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUnitCaster.Location = new System.Drawing.Point(458, 295);
            this.numUnitCaster.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numUnitCaster.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numUnitCaster.Name = "numUnitCaster";
            this.numUnitCaster.Size = new System.Drawing.Size(153, 27);
            this.numUnitCaster.TabIndex = 80;
            // 
            // label155
            // 
            this.label155.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label155.AutoSize = true;
            this.label155.Location = new System.Drawing.Point(405, 297);
            this.label155.Name = "label155";
            this.label155.Size = new System.Drawing.Size(50, 20);
            this.label155.TabIndex = 79;
            this.label155.Text = "Caster";
            // 
            // numPlayerCaster
            // 
            this.numPlayerCaster.Location = new System.Drawing.Point(101, 295);
            this.numPlayerCaster.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numPlayerCaster.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numPlayerCaster.Name = "numPlayerCaster";
            this.numPlayerCaster.Size = new System.Drawing.Size(153, 27);
            this.numPlayerCaster.TabIndex = 78;
            // 
            // label154
            // 
            this.label154.AutoSize = true;
            this.label154.Location = new System.Drawing.Point(48, 297);
            this.label154.Name = "label154";
            this.label154.Size = new System.Drawing.Size(50, 20);
            this.label154.TabIndex = 77;
            this.label154.Text = "Caster";
            // 
            // numUnitViewer
            // 
            this.numUnitViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUnitViewer.Location = new System.Drawing.Point(458, 256);
            this.numUnitViewer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numUnitViewer.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numUnitViewer.Name = "numUnitViewer";
            this.numUnitViewer.Size = new System.Drawing.Size(153, 27);
            this.numUnitViewer.TabIndex = 76;
            // 
            // label153
            // 
            this.label153.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label153.AutoSize = true;
            this.label153.Location = new System.Drawing.Point(403, 259);
            this.label153.Name = "label153";
            this.label153.Size = new System.Drawing.Size(54, 20);
            this.label153.TabIndex = 75;
            this.label153.Text = "Viewer";
            // 
            // label152
            // 
            this.label152.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label152.AutoSize = true;
            this.label152.Location = new System.Drawing.Point(511, 232);
            this.label152.Name = "label152";
            this.label152.Size = new System.Drawing.Size(36, 20);
            this.label152.TabIndex = 74;
            this.label152.Text = "Unit";
            // 
            // label151
            // 
            this.label151.AutoSize = true;
            this.label151.Location = new System.Drawing.Point(152, 232);
            this.label151.Name = "label151";
            this.label151.Size = new System.Drawing.Size(49, 20);
            this.label151.TabIndex = 73;
            this.label151.Text = "Player";
            // 
            // label150
            // 
            this.label150.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label150.AutoSize = true;
            this.label150.Location = new System.Drawing.Point(272, 211);
            this.label150.Name = "label150";
            this.label150.Size = new System.Drawing.Size(99, 20);
            this.label150.TabIndex = 72;
            this.label150.Text = "Condition IDs";
            // 
            // numPlayerViewer
            // 
            this.numPlayerViewer.Location = new System.Drawing.Point(101, 256);
            this.numPlayerViewer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numPlayerViewer.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numPlayerViewer.Name = "numPlayerViewer";
            this.numPlayerViewer.Size = new System.Drawing.Size(153, 27);
            this.numPlayerViewer.TabIndex = 71;
            // 
            // label149
            // 
            this.label149.AutoSize = true;
            this.label149.Location = new System.Drawing.Point(46, 259);
            this.label149.Name = "label149";
            this.label149.Size = new System.Drawing.Size(54, 20);
            this.label149.TabIndex = 70;
            this.label149.Text = "Viewer";
            // 
            // numVisualPriority
            // 
            this.numVisualPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numVisualPriority.Location = new System.Drawing.Point(458, 101);
            this.numVisualPriority.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numVisualPriority.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numVisualPriority.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numVisualPriority.Name = "numVisualPriority";
            this.numVisualPriority.Size = new System.Drawing.Size(153, 27);
            this.numVisualPriority.TabIndex = 69;
            // 
            // label148
            // 
            this.label148.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label148.AutoSize = true;
            this.label148.Location = new System.Drawing.Point(400, 104);
            this.label148.Name = "label148";
            this.label148.Size = new System.Drawing.Size(56, 20);
            this.label148.TabIndex = 68;
            this.label148.Text = "Priority";
            // 
            // txtVisualProbability
            // 
            this.txtVisualProbability.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVisualProbability.Location = new System.Drawing.Point(458, 61);
            this.txtVisualProbability.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVisualProbability.Name = "txtVisualProbability";
            this.txtVisualProbability.Size = new System.Drawing.Size(153, 27);
            this.txtVisualProbability.TabIndex = 67;
            this.txtVisualProbability.Tag = "";
            this.txtVisualProbability.Text = "0";
            // 
            // label147
            // 
            this.label147.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label147.AutoSize = true;
            this.label147.Location = new System.Drawing.Point(378, 65);
            this.label147.Name = "label147";
            this.label147.Size = new System.Drawing.Size(81, 20);
            this.label147.TabIndex = 66;
            this.label147.Text = "Probability";
            // 
            // numVisualActiveIconId
            // 
            this.numVisualActiveIconId.Location = new System.Drawing.Point(107, 176);
            this.numVisualActiveIconId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numVisualActiveIconId.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numVisualActiveIconId.Name = "numVisualActiveIconId";
            this.numVisualActiveIconId.Size = new System.Drawing.Size(153, 27);
            this.numVisualActiveIconId.TabIndex = 59;
            // 
            // label146
            // 
            this.label146.AutoSize = true;
            this.label146.Location = new System.Drawing.Point(2, 179);
            this.label146.Name = "label146";
            this.label146.Size = new System.Drawing.Size(101, 20);
            this.label146.TabIndex = 58;
            this.label146.Text = "Active Icon ID";
            // 
            // numVisualIconId
            // 
            this.numVisualIconId.Location = new System.Drawing.Point(107, 137);
            this.numVisualIconId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numVisualIconId.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numVisualIconId.Name = "numVisualIconId";
            this.numVisualIconId.Size = new System.Drawing.Size(153, 27);
            this.numVisualIconId.TabIndex = 57;
            // 
            // label145
            // 
            this.label145.AutoSize = true;
            this.label145.Location = new System.Drawing.Point(43, 140);
            this.label145.Name = "label145";
            this.label145.Size = new System.Drawing.Size(56, 20);
            this.label145.TabIndex = 56;
            this.label145.Text = "Icon ID";
            // 
            // numSpellVisualId
            // 
            this.numSpellVisualId.Location = new System.Drawing.Point(107, 99);
            this.numSpellVisualId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numSpellVisualId.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numSpellVisualId.Name = "numSpellVisualId";
            this.numSpellVisualId.Size = new System.Drawing.Size(153, 27);
            this.numSpellVisualId.TabIndex = 55;
            // 
            // label144
            // 
            this.label144.AutoSize = true;
            this.label144.Location = new System.Drawing.Point(2, 101);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(104, 20);
            this.label144.TabIndex = 54;
            this.label144.Text = "Spell Visual ID";
            // 
            // btnVisualSave
            // 
            this.btnVisualSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisualSave.Enabled = false;
            this.btnVisualSave.Location = new System.Drawing.Point(497, 23);
            this.btnVisualSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVisualSave.Name = "btnVisualSave";
            this.btnVisualSave.Size = new System.Drawing.Size(53, 31);
            this.btnVisualSave.TabIndex = 53;
            this.btnVisualSave.Text = "Save";
            this.btnVisualSave.UseVisualStyleBackColor = true;
            this.btnVisualSave.Click += new System.EventHandler(this.btnVisualSave_Click);
            // 
            // btnVisualCopy
            // 
            this.btnVisualCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisualCopy.Enabled = false;
            this.btnVisualCopy.Location = new System.Drawing.Point(437, 23);
            this.btnVisualCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVisualCopy.Name = "btnVisualCopy";
            this.btnVisualCopy.Size = new System.Drawing.Size(53, 31);
            this.btnVisualCopy.TabIndex = 52;
            this.btnVisualCopy.Text = "Copy";
            this.btnVisualCopy.UseVisualStyleBackColor = true;
            this.btnVisualCopy.Click += new System.EventHandler(this.btnVisualCopy_Click);
            // 
            // btnVisualNew
            // 
            this.btnVisualNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisualNew.Enabled = false;
            this.btnVisualNew.Location = new System.Drawing.Point(378, 23);
            this.btnVisualNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVisualNew.Name = "btnVisualNew";
            this.btnVisualNew.Size = new System.Drawing.Size(53, 31);
            this.btnVisualNew.TabIndex = 51;
            this.btnVisualNew.Text = "New";
            this.btnVisualNew.UseVisualStyleBackColor = true;
            this.btnVisualNew.Click += new System.EventHandler(this.btnVisualNew_Click);
            // 
            // cmbVisualDifficulty
            // 
            this.cmbVisualDifficulty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbVisualDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVisualDifficulty.Location = new System.Drawing.Point(458, 139);
            this.cmbVisualDifficulty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbVisualDifficulty.MaxDropDownItems = 2;
            this.cmbVisualDifficulty.Name = "cmbVisualDifficulty";
            this.cmbVisualDifficulty.Size = new System.Drawing.Size(153, 28);
            this.cmbVisualDifficulty.TabIndex = 50;
            // 
            // label142
            // 
            this.label142.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label142.AutoSize = true;
            this.label142.Location = new System.Drawing.Point(373, 141);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(88, 20);
            this.label142.TabIndex = 49;
            this.label142.Text = "Difficulty ID";
            // 
            // numVisualId
            // 
            this.numVisualId.Location = new System.Drawing.Point(107, 60);
            this.numVisualId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numVisualId.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numVisualId.Name = "numVisualId";
            this.numVisualId.Size = new System.Drawing.Size(153, 27);
            this.numVisualId.TabIndex = 48;
            // 
            // label141
            // 
            this.label141.AutoSize = true;
            this.label141.Location = new System.Drawing.Point(46, 63);
            this.label141.Name = "label141";
            this.label141.Size = new System.Drawing.Size(54, 20);
            this.label141.TabIndex = 47;
            this.label141.Text = "This ID";
            // 
            // cmbSelectVisual
            // 
            this.cmbSelectVisual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectVisual.Location = new System.Drawing.Point(107, 21);
            this.cmbSelectVisual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSelectVisual.MaxDropDownItems = 2;
            this.cmbSelectVisual.Name = "cmbSelectVisual";
            this.cmbSelectVisual.Size = new System.Drawing.Size(259, 28);
            this.cmbSelectVisual.TabIndex = 45;
            this.cmbSelectVisual.SelectedIndexChanged += new System.EventHandler(this.cmbSelectVisual_SelectedIndexChanged);
            // 
            // label140
            // 
            this.label140.AutoSize = true;
            this.label140.Location = new System.Drawing.Point(11, 25);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(92, 20);
            this.label140.TabIndex = 44;
            this.label140.Text = "Select Visual";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.numRequiredAreaId);
            this.groupBox2.Controls.Add(this.txtLabels);
            this.groupBox2.Controls.Add(this.label196);
            this.groupBox2.Controls.Add(this.label200);
            this.groupBox2.Controls.Add(this.numExTargetAura);
            this.groupBox2.Controls.Add(this.label195);
            this.groupBox2.Controls.Add(this.numExCasterAura);
            this.groupBox2.Controls.Add(this.label194);
            this.groupBox2.Controls.Add(this.numTargetAura);
            this.groupBox2.Controls.Add(this.label193);
            this.groupBox2.Controls.Add(this.numCasterAura);
            this.groupBox2.Controls.Add(this.label192);
            this.groupBox2.Controls.Add(this.label190);
            this.groupBox2.Controls.Add(this.cmbExTargetAuraState);
            this.groupBox2.Controls.Add(this.label191);
            this.groupBox2.Controls.Add(this.cmbExCasterAuraState);
            this.groupBox2.Controls.Add(this.numFacingCasterFlags);
            this.groupBox2.Controls.Add(this.label157);
            this.groupBox2.Controls.Add(this.label156);
            this.groupBox2.Controls.Add(this.listSpellSchool);
            this.groupBox2.Controls.Add(this.label143);
            this.groupBox2.Controls.Add(this.cmbSpellFocus);
            this.groupBox2.Controls.Add(this.label139);
            this.groupBox2.Controls.Add(this.cmbTargetAuraState);
            this.groupBox2.Controls.Add(this.label72);
            this.groupBox2.Controls.Add(this.cmbCasterAuraState);
            this.groupBox2.Controls.Add(this.numMaxLevel);
            this.groupBox2.Controls.Add(this.numBaseLevel);
            this.groupBox2.Controls.Add(this.numSpellLevel);
            this.groupBox2.Controls.Add(this.label134);
            this.groupBox2.Controls.Add(this.label133);
            this.groupBox2.Controls.Add(this.label132);
            this.groupBox2.Location = new System.Drawing.Point(7, 3);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(491, 863);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "More Spell Info";
            // 
            // numRequiredAreaId
            // 
            this.numRequiredAreaId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numRequiredAreaId.Location = new System.Drawing.Point(189, 687);
            this.numRequiredAreaId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numRequiredAreaId.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numRequiredAreaId.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numRequiredAreaId.Name = "numRequiredAreaId";
            this.numRequiredAreaId.Size = new System.Drawing.Size(286, 27);
            this.numRequiredAreaId.TabIndex = 79;
            // 
            // txtLabels
            // 
            this.txtLabels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLabels.Location = new System.Drawing.Point(189, 725);
            this.txtLabels.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLabels.Multiline = true;
            this.txtLabels.Name = "txtLabels";
            this.txtLabels.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLabels.Size = new System.Drawing.Size(285, 128);
            this.txtLabels.TabIndex = 3;
            // 
            // label196
            // 
            this.label196.AutoSize = true;
            this.label196.Location = new System.Drawing.Point(54, 689);
            this.label196.Name = "label196";
            this.label196.Size = new System.Drawing.Size(129, 20);
            this.label196.TabIndex = 78;
            this.label196.Text = "Required Areas ID";
            // 
            // label200
            // 
            this.label200.AutoSize = true;
            this.label200.Location = new System.Drawing.Point(122, 729);
            this.label200.Name = "label200";
            this.label200.Size = new System.Drawing.Size(51, 20);
            this.label200.TabIndex = 2;
            this.label200.Text = "Labels";
            // 
            // numExTargetAura
            // 
            this.numExTargetAura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numExTargetAura.Location = new System.Drawing.Point(189, 417);
            this.numExTargetAura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numExTargetAura.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numExTargetAura.Name = "numExTargetAura";
            this.numExTargetAura.Size = new System.Drawing.Size(286, 27);
            this.numExTargetAura.TabIndex = 77;
            // 
            // label195
            // 
            this.label195.AutoSize = true;
            this.label195.Location = new System.Drawing.Point(41, 420);
            this.label195.Name = "label195";
            this.label195.Size = new System.Drawing.Size(140, 20);
            this.label195.TabIndex = 76;
            this.label195.Text = "Exclude Target Aura";
            // 
            // numExCasterAura
            // 
            this.numExCasterAura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numExCasterAura.Location = new System.Drawing.Point(189, 379);
            this.numExCasterAura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numExCasterAura.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numExCasterAura.Name = "numExCasterAura";
            this.numExCasterAura.Size = new System.Drawing.Size(286, 27);
            this.numExCasterAura.TabIndex = 75;
            // 
            // label194
            // 
            this.label194.AutoSize = true;
            this.label194.Location = new System.Drawing.Point(40, 381);
            this.label194.Name = "label194";
            this.label194.Size = new System.Drawing.Size(140, 20);
            this.label194.TabIndex = 74;
            this.label194.Text = "Exclude Caster Aura";
            // 
            // numTargetAura
            // 
            this.numTargetAura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numTargetAura.Location = new System.Drawing.Point(189, 340);
            this.numTargetAura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numTargetAura.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numTargetAura.Name = "numTargetAura";
            this.numTargetAura.Size = new System.Drawing.Size(286, 27);
            this.numTargetAura.TabIndex = 73;
            // 
            // label193
            // 
            this.label193.AutoSize = true;
            this.label193.Location = new System.Drawing.Point(91, 343);
            this.label193.Name = "label193";
            this.label193.Size = new System.Drawing.Size(85, 20);
            this.label193.TabIndex = 72;
            this.label193.Text = "Target Aura";
            // 
            // numCasterAura
            // 
            this.numCasterAura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numCasterAura.Location = new System.Drawing.Point(189, 301);
            this.numCasterAura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numCasterAura.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numCasterAura.Name = "numCasterAura";
            this.numCasterAura.Size = new System.Drawing.Size(286, 27);
            this.numCasterAura.TabIndex = 71;
            // 
            // label192
            // 
            this.label192.AutoSize = true;
            this.label192.Location = new System.Drawing.Point(90, 304);
            this.label192.Name = "label192";
            this.label192.Size = new System.Drawing.Size(85, 20);
            this.label192.TabIndex = 70;
            this.label192.Text = "Caster Aura";
            // 
            // label190
            // 
            this.label190.AutoSize = true;
            this.label190.Location = new System.Drawing.Point(7, 267);
            this.label190.Name = "label190";
            this.label190.Size = new System.Drawing.Size(178, 20);
            this.label190.TabIndex = 69;
            this.label190.Text = "Exclude Target Aura State";
            // 
            // cmbExTargetAuraState
            // 
            this.cmbExTargetAuraState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbExTargetAuraState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExTargetAuraState.Location = new System.Drawing.Point(189, 263);
            this.cmbExTargetAuraState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbExTargetAuraState.MaxDropDownItems = 2;
            this.cmbExTargetAuraState.Name = "cmbExTargetAuraState";
            this.cmbExTargetAuraState.Size = new System.Drawing.Size(285, 28);
            this.cmbExTargetAuraState.TabIndex = 68;
            // 
            // label191
            // 
            this.label191.AutoSize = true;
            this.label191.Location = new System.Drawing.Point(7, 228);
            this.label191.Name = "label191";
            this.label191.Size = new System.Drawing.Size(178, 20);
            this.label191.TabIndex = 67;
            this.label191.Text = "Exclude Caster Aura State";
            // 
            // cmbExCasterAuraState
            // 
            this.cmbExCasterAuraState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbExCasterAuraState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExCasterAuraState.Location = new System.Drawing.Point(189, 224);
            this.cmbExCasterAuraState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbExCasterAuraState.MaxDropDownItems = 2;
            this.cmbExCasterAuraState.Name = "cmbExCasterAuraState";
            this.cmbExCasterAuraState.Size = new System.Drawing.Size(285, 28);
            this.cmbExCasterAuraState.TabIndex = 66;
            // 
            // numFacingCasterFlags
            // 
            this.numFacingCasterFlags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numFacingCasterFlags.Location = new System.Drawing.Point(189, 648);
            this.numFacingCasterFlags.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numFacingCasterFlags.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numFacingCasterFlags.Name = "numFacingCasterFlags";
            this.numFacingCasterFlags.Size = new System.Drawing.Size(286, 27);
            this.numFacingCasterFlags.TabIndex = 65;
            // 
            // label157
            // 
            this.label157.AutoSize = true;
            this.label157.Location = new System.Drawing.Point(45, 651);
            this.label157.Name = "label157";
            this.label157.Size = new System.Drawing.Size(134, 20);
            this.label157.TabIndex = 64;
            this.label157.Text = "Facing Caster Flags";
            // 
            // label156
            // 
            this.label156.AutoSize = true;
            this.label156.Location = new System.Drawing.Point(87, 495);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(91, 20);
            this.label156.TabIndex = 63;
            this.label156.Text = "Spell School";
            // 
            // listSpellSchool
            // 
            this.listSpellSchool.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listSpellSchool.FormattingEnabled = true;
            this.listSpellSchool.ItemHeight = 20;
            this.listSpellSchool.Location = new System.Drawing.Point(189, 495);
            this.listSpellSchool.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listSpellSchool.Name = "listSpellSchool";
            this.listSpellSchool.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listSpellSchool.Size = new System.Drawing.Size(285, 144);
            this.listSpellSchool.TabIndex = 62;
            // 
            // label143
            // 
            this.label143.AutoSize = true;
            this.label143.Location = new System.Drawing.Point(91, 460);
            this.label143.Name = "label143";
            this.label143.Size = new System.Drawing.Size(83, 20);
            this.label143.TabIndex = 61;
            this.label143.Text = "Spell Focus";
            // 
            // cmbSpellFocus
            // 
            this.cmbSpellFocus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSpellFocus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpellFocus.Location = new System.Drawing.Point(189, 456);
            this.cmbSpellFocus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSpellFocus.MaxDropDownItems = 2;
            this.cmbSpellFocus.Name = "cmbSpellFocus";
            this.cmbSpellFocus.Size = new System.Drawing.Size(285, 28);
            this.cmbSpellFocus.TabIndex = 60;
            // 
            // label139
            // 
            this.label139.AutoSize = true;
            this.label139.Location = new System.Drawing.Point(58, 189);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(123, 20);
            this.label139.TabIndex = 59;
            this.label139.Text = "Target Aura State";
            // 
            // cmbTargetAuraState
            // 
            this.cmbTargetAuraState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTargetAuraState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTargetAuraState.Location = new System.Drawing.Point(189, 185);
            this.cmbTargetAuraState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTargetAuraState.MaxDropDownItems = 2;
            this.cmbTargetAuraState.Name = "cmbTargetAuraState";
            this.cmbTargetAuraState.Size = new System.Drawing.Size(285, 28);
            this.cmbTargetAuraState.TabIndex = 58;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(57, 151);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(123, 20);
            this.label72.TabIndex = 57;
            this.label72.Text = "Caster Aura State";
            // 
            // cmbCasterAuraState
            // 
            this.cmbCasterAuraState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCasterAuraState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCasterAuraState.Location = new System.Drawing.Point(189, 147);
            this.cmbCasterAuraState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCasterAuraState.MaxDropDownItems = 2;
            this.cmbCasterAuraState.Name = "cmbCasterAuraState";
            this.cmbCasterAuraState.Size = new System.Drawing.Size(285, 28);
            this.cmbCasterAuraState.TabIndex = 56;
            // 
            // numMaxLevel
            // 
            this.numMaxLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numMaxLevel.Location = new System.Drawing.Point(189, 108);
            this.numMaxLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numMaxLevel.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numMaxLevel.Name = "numMaxLevel";
            this.numMaxLevel.Size = new System.Drawing.Size(286, 27);
            this.numMaxLevel.TabIndex = 48;
            // 
            // numBaseLevel
            // 
            this.numBaseLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBaseLevel.Location = new System.Drawing.Point(189, 69);
            this.numBaseLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numBaseLevel.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numBaseLevel.Name = "numBaseLevel";
            this.numBaseLevel.Size = new System.Drawing.Size(286, 27);
            this.numBaseLevel.TabIndex = 47;
            // 
            // numSpellLevel
            // 
            this.numSpellLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numSpellLevel.Location = new System.Drawing.Point(189, 31);
            this.numSpellLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numSpellLevel.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numSpellLevel.Name = "numSpellLevel";
            this.numSpellLevel.Size = new System.Drawing.Size(286, 27);
            this.numSpellLevel.TabIndex = 46;
            // 
            // label134
            // 
            this.label134.AutoSize = true;
            this.label134.Location = new System.Drawing.Point(99, 111);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(75, 20);
            this.label134.TabIndex = 45;
            this.label134.Text = "Max Level";
            // 
            // label133
            // 
            this.label133.AutoSize = true;
            this.label133.Location = new System.Drawing.Point(98, 72);
            this.label133.Name = "label133";
            this.label133.Size = new System.Drawing.Size(78, 20);
            this.label133.TabIndex = 43;
            this.label133.Text = "Base Level";
            // 
            // label132
            // 
            this.label132.AutoSize = true;
            this.label132.Location = new System.Drawing.Point(97, 33);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(80, 20);
            this.label132.TabIndex = 41;
            this.label132.Text = "Spell Level";
            // 
            // tabProcInfo
            // 
            this.tabProcInfo.Controls.Add(this.mlcmbPPM);
            this.tabProcInfo.Controls.Add(this.lblPPM);
            this.tabProcInfo.Controls.Add(this.label67);
            this.tabProcInfo.Controls.Add(this.numProcCharges);
            this.tabProcInfo.Controls.Add(this.label68);
            this.tabProcInfo.Controls.Add(this.numProcCooldown);
            this.tabProcInfo.Controls.Add(this.label66);
            this.tabProcInfo.Controls.Add(this.numProcChance);
            this.tabProcInfo.Controls.Add(this.listProcTargets);
            this.tabProcInfo.Controls.Add(this.label65);
            this.tabProcInfo.Controls.Add(this.listProcFlags2);
            this.tabProcInfo.Controls.Add(this.label64);
            this.tabProcInfo.Controls.Add(this.listProcFlags);
            this.tabProcInfo.Controls.Add(this.label63);
            this.tabProcInfo.Location = new System.Drawing.Point(4, 29);
            this.tabProcInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabProcInfo.Name = "tabProcInfo";
            this.tabProcInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabProcInfo.Size = new System.Drawing.Size(1134, 874);
            this.tabProcInfo.TabIndex = 3;
            this.tabProcInfo.Text = "Proc Info";
            this.tabProcInfo.UseVisualStyleBackColor = true;
            // 
            // mlcmbPPM
            // 
            this.mlcmbPPM.DisplayMember = "name";
            this.mlcmbPPM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mlcmbPPM.FormattingEnabled = true;
            this.mlcmbPPM.ListItemDisplayMember = "display";
            this.mlcmbPPM.Location = new System.Drawing.Point(751, 164);
            this.mlcmbPPM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mlcmbPPM.Name = "mlcmbPPM";
            this.mlcmbPPM.Size = new System.Drawing.Size(143, 28);
            this.mlcmbPPM.TabIndex = 18;
            this.mlcmbPPM.ValueMember = "id";
            // 
            // lblPPM
            // 
            this.lblPPM.AutoSize = true;
            this.lblPPM.Location = new System.Drawing.Point(633, 168);
            this.lblPPM.Name = "lblPPM";
            this.lblPPM.Size = new System.Drawing.Size(118, 20);
            this.lblPPM.TabIndex = 17;
            this.lblPPM.Text = "Procs Per Minute";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(656, 244);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(95, 20);
            this.label67.TabIndex = 16;
            this.label67.Text = "Proc Charges";
            // 
            // numProcCharges
            // 
            this.numProcCharges.Location = new System.Drawing.Point(751, 241);
            this.numProcCharges.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numProcCharges.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numProcCharges.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numProcCharges.Name = "numProcCharges";
            this.numProcCharges.Size = new System.Drawing.Size(144, 27);
            this.numProcCharges.TabIndex = 15;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(643, 205);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(110, 20);
            this.label68.TabIndex = 14;
            this.label68.Text = "Proc Cooldown";
            // 
            // numProcCooldown
            // 
            this.numProcCooldown.Location = new System.Drawing.Point(751, 203);
            this.numProcCooldown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numProcCooldown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numProcCooldown.Name = "numProcCooldown";
            this.numProcCooldown.Size = new System.Drawing.Size(144, 27);
            this.numProcCooldown.TabIndex = 13;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(661, 128);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(90, 20);
            this.label66.TabIndex = 10;
            this.label66.Text = "Proc Chance";
            // 
            // numProcChance
            // 
            this.numProcChance.Location = new System.Drawing.Point(751, 125);
            this.numProcChance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numProcChance.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numProcChance.Name = "numProcChance";
            this.numProcChance.Size = new System.Drawing.Size(144, 27);
            this.numProcChance.TabIndex = 9;
            // 
            // listProcTargets
            // 
            this.listProcTargets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listProcTargets.FormattingEnabled = true;
            this.listProcTargets.ItemHeight = 20;
            this.listProcTargets.Location = new System.Drawing.Point(7, 32);
            this.listProcTargets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listProcTargets.Name = "listProcTargets";
            this.listProcTargets.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listProcTargets.Size = new System.Drawing.Size(292, 824);
            this.listProcTargets.TabIndex = 8;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(7, 8);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(56, 20);
            this.label65.TabIndex = 7;
            this.label65.Text = "Targets";
            // 
            // listProcFlags2
            // 
            this.listProcFlags2.FormattingEnabled = true;
            this.listProcFlags2.ItemHeight = 20;
            this.listProcFlags2.Location = new System.Drawing.Point(603, 32);
            this.listProcFlags2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listProcFlags2.Name = "listProcFlags2";
            this.listProcFlags2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listProcFlags2.Size = new System.Drawing.Size(292, 84);
            this.listProcFlags2.TabIndex = 6;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(603, 8);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(88, 20);
            this.label64.TabIndex = 5;
            this.label64.Text = "Proc Flags 2";
            // 
            // listProcFlags
            // 
            this.listProcFlags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listProcFlags.FormattingEnabled = true;
            this.listProcFlags.ItemHeight = 20;
            this.listProcFlags.Location = new System.Drawing.Point(305, 32);
            this.listProcFlags.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listProcFlags.Name = "listProcFlags";
            this.listProcFlags.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listProcFlags.Size = new System.Drawing.Size(292, 824);
            this.listProcFlags.TabIndex = 4;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(305, 8);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(76, 20);
            this.label63.TabIndex = 3;
            this.label63.Text = "Proc Flags";
            // 
            // tabSpellEffects
            // 
            this.tabSpellEffects.Controls.Add(this.btnAddEffect);
            this.tabSpellEffects.Controls.Add(this.tabsSpellEffects);
            this.tabSpellEffects.Location = new System.Drawing.Point(4, 29);
            this.tabSpellEffects.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabSpellEffects.Name = "tabSpellEffects";
            this.tabSpellEffects.Size = new System.Drawing.Size(1134, 874);
            this.tabSpellEffects.TabIndex = 4;
            this.tabSpellEffects.Text = "Spell Effects";
            this.tabSpellEffects.UseVisualStyleBackColor = true;
            // 
            // btnAddEffect
            // 
            this.btnAddEffect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEffect.Location = new System.Drawing.Point(1031, 11);
            this.btnAddEffect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddEffect.Name = "btnAddEffect";
            this.btnAddEffect.Size = new System.Drawing.Size(86, 31);
            this.btnAddEffect.TabIndex = 0;
            this.btnAddEffect.Text = "Add Effect";
            this.btnAddEffect.UseVisualStyleBackColor = true;
            this.btnAddEffect.Click += new System.EventHandler(this.btnAddEffect_Click);
            // 
            // tabsSpellEffects
            // 
            this.tabsSpellEffects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabsSpellEffects.Controls.Add(this.tabEffect);
            this.tabsSpellEffects.Location = new System.Drawing.Point(3, 49);
            this.tabsSpellEffects.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabsSpellEffects.Name = "tabsSpellEffects";
            this.tabsSpellEffects.SelectedIndex = 0;
            this.tabsSpellEffects.Size = new System.Drawing.Size(1128, 816);
            this.tabsSpellEffects.TabIndex = 0;
            // 
            // tabEffect
            // 
            this.tabEffect.Controls.Add(this.txtBP);
            this.tabEffect.Controls.Add(this.label212);
            this.tabEffect.Controls.Add(this.numEffTableID);
            this.tabEffect.Controls.Add(this.numericUpDown22);
            this.tabEffect.Controls.Add(this.label211);
            this.tabEffect.Controls.Add(this.label83);
            this.tabEffect.Controls.Add(this.numericUpDown7);
            this.tabEffect.Controls.Add(this.label82);
            this.tabEffect.Controls.Add(this.numericUpDown6);
            this.tabEffect.Controls.Add(this.label81);
            this.tabEffect.Controls.Add(this.numericUpDown5);
            this.tabEffect.Controls.Add(this.label80);
            this.tabEffect.Controls.Add(this.numericUpDown4);
            this.tabEffect.Controls.Add(this.label79);
            this.tabEffect.Controls.Add(this.numericUpDown3);
            this.tabEffect.Controls.Add(this.label78);
            this.tabEffect.Controls.Add(this.numericUpDown2);
            this.tabEffect.Controls.Add(this.label77);
            this.tabEffect.Controls.Add(this.numericUpDown1);
            this.tabEffect.Controls.Add(this.label76);
            this.tabEffect.Controls.Add(this.numChainTargets);
            this.tabEffect.Controls.Add(this.txtResourceCoefficient);
            this.tabEffect.Controls.Add(this.label62);
            this.tabEffect.Controls.Add(this.txtScalingCoefficient);
            this.tabEffect.Controls.Add(this.label61);
            this.tabEffect.Controls.Add(this.label60);
            this.tabEffect.Controls.Add(this.numScalingClass);
            this.tabEffect.Controls.Add(this.txtPositionFacing);
            this.tabEffect.Controls.Add(this.label59);
            this.tabEffect.Controls.Add(this.txtBonusCoefficient);
            this.tabEffect.Controls.Add(this.label57);
            this.tabEffect.Controls.Add(this.txtBonusCoefficientFromAP);
            this.tabEffect.Controls.Add(this.label58);
            this.tabEffect.Controls.Add(this.txtChainAmplitude);
            this.tabEffect.Controls.Add(this.label56);
            this.tabEffect.Controls.Add(this.txtAmplitude);
            this.tabEffect.Controls.Add(this.label55);
            this.tabEffect.Controls.Add(this.txtPointsPerResource);
            this.tabEffect.Controls.Add(this.label54);
            this.tabEffect.Controls.Add(this.label53);
            this.tabEffect.Controls.Add(this.numAuraDuration);
            this.tabEffect.Controls.Add(this.cmbApplyAura);
            this.tabEffect.Controls.Add(this.label52);
            this.tabEffect.Controls.Add(this.cmbRadiusMax);
            this.tabEffect.Controls.Add(this.label51);
            this.tabEffect.Controls.Add(this.cmbRadiusMin);
            this.tabEffect.Controls.Add(this.label50);
            this.tabEffect.Controls.Add(this.cmbTargetB);
            this.tabEffect.Controls.Add(this.label49);
            this.tabEffect.Controls.Add(this.cmbTargetA);
            this.tabEffect.Controls.Add(this.label48);
            this.tabEffect.Controls.Add(this.cmbEffMechanic);
            this.tabEffect.Controls.Add(this.label47);
            this.tabEffect.Controls.Add(this.txtRealPoints);
            this.tabEffect.Controls.Add(this.txtVariance);
            this.tabEffect.Controls.Add(this.label46);
            this.tabEffect.Controls.Add(this.lblDS);
            this.tabEffect.Controls.Add(this.lblBP);
            this.tabEffect.Controls.Add(this.cmbSpellEffect);
            this.tabEffect.Controls.Add(this.lblSpellEffect);
            this.tabEffect.Location = new System.Drawing.Point(4, 29);
            this.tabEffect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabEffect.Name = "tabEffect";
            this.tabEffect.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabEffect.Size = new System.Drawing.Size(1120, 783);
            this.tabEffect.TabIndex = 0;
            this.tabEffect.Text = "Effect 1";
            this.tabEffect.UseVisualStyleBackColor = true;
            // 
            // txtBP
            // 
            this.txtBP.Location = new System.Drawing.Point(184, 85);
            this.txtBP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBP.Name = "txtBP";
            this.txtBP.Size = new System.Drawing.Size(199, 27);
            this.txtBP.TabIndex = 64;
            this.txtBP.Tag = "BasePoints";
            this.txtBP.Text = "0";
            // 
            // label212
            // 
            this.label212.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label212.AutoSize = true;
            this.label212.Location = new System.Drawing.Point(601, 745);
            this.label212.Name = "label212";
            this.label212.Size = new System.Drawing.Size(105, 20);
            this.label212.TabIndex = 63;
            this.label212.Text = "Effect Table ID";
            // 
            // numEffTableID
            // 
            this.numEffTableID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numEffTableID.Location = new System.Drawing.Point(713, 743);
            this.numEffTableID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numEffTableID.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numEffTableID.Name = "numEffTableID";
            this.numEffTableID.Size = new System.Drawing.Size(200, 27);
            this.numEffTableID.TabIndex = 62;
            this.numEffTableID.Tag = "EffTableID";
            // 
            // numericUpDown22
            // 
            this.numericUpDown22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown22.Enabled = false;
            this.numericUpDown22.Location = new System.Drawing.Point(713, 163);
            this.numericUpDown22.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown22.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numericUpDown22.Name = "numericUpDown22";
            this.numericUpDown22.Size = new System.Drawing.Size(200, 27);
            this.numericUpDown22.TabIndex = 61;
            this.numericUpDown22.Tag = "EffItemType";
            // 
            // label211
            // 
            this.label211.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label211.AutoSize = true;
            this.label211.Location = new System.Drawing.Point(627, 167);
            this.label211.Name = "label211";
            this.label211.Size = new System.Drawing.Size(74, 20);
            this.label211.TabIndex = 60;
            this.label211.Text = "Item Type";
            // 
            // label83
            // 
            this.label83.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(609, 324);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(92, 20);
            this.label83.TabIndex = 57;
            this.label83.Text = "Class Mask 4";
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown7.Location = new System.Drawing.Point(713, 321);
            this.numericUpDown7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown7.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(200, 27);
            this.numericUpDown7.TabIndex = 56;
            this.numericUpDown7.Tag = "ClassMask4";
            // 
            // label82
            // 
            this.label82.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(609, 285);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(92, 20);
            this.label82.TabIndex = 55;
            this.label82.Text = "Class Mask 3";
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown6.Location = new System.Drawing.Point(713, 283);
            this.numericUpDown6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(200, 27);
            this.numericUpDown6.TabIndex = 54;
            this.numericUpDown6.Tag = "ClassMask3";
            // 
            // label81
            // 
            this.label81.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(609, 247);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(92, 20);
            this.label81.TabIndex = 53;
            this.label81.Text = "Class Mask 2";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown5.Location = new System.Drawing.Point(713, 244);
            this.numericUpDown5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(200, 27);
            this.numericUpDown5.TabIndex = 52;
            this.numericUpDown5.Tag = "ClassMask2";
            // 
            // label80
            // 
            this.label80.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(609, 208);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(92, 20);
            this.label80.TabIndex = 51;
            this.label80.Text = "Class Mask 1";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown4.Location = new System.Drawing.Point(713, 205);
            this.numericUpDown4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(200, 27);
            this.numericUpDown4.TabIndex = 50;
            this.numericUpDown4.Tag = "ClassMask1";
            // 
            // label79
            // 
            this.label79.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(609, 127);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(92, 20);
            this.label79.TabIndex = 49;
            this.label79.Text = "Misc Value B";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown3.Location = new System.Drawing.Point(713, 124);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(200, 27);
            this.numericUpDown3.TabIndex = 48;
            this.numericUpDown3.Tag = "MiscValueB";
            // 
            // label78
            // 
            this.label78.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(609, 88);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(93, 20);
            this.label78.TabIndex = 47;
            this.label78.Text = "Misc Value A";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown2.Location = new System.Drawing.Point(713, 85);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(200, 27);
            this.numericUpDown2.TabIndex = 46;
            this.numericUpDown2.Tag = "MiscValueA";
            // 
            // label77
            // 
            this.label77.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(613, 49);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(93, 20);
            this.label77.TabIndex = 45;
            this.label77.Text = "Trigger Spell";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(713, 47);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(200, 27);
            this.numericUpDown1.TabIndex = 44;
            this.numericUpDown1.Tag = "TriggerSpell";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(88, 745);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(97, 20);
            this.label76.TabIndex = 43;
            this.label76.Text = "Chain Targets";
            // 
            // numChainTargets
            // 
            this.numChainTargets.Location = new System.Drawing.Point(184, 743);
            this.numChainTargets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numChainTargets.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numChainTargets.Name = "numChainTargets";
            this.numChainTargets.Size = new System.Drawing.Size(200, 27);
            this.numChainTargets.TabIndex = 42;
            this.numChainTargets.Tag = "ChainTargets";
            // 
            // txtResourceCoefficient
            // 
            this.txtResourceCoefficient.Location = new System.Drawing.Point(184, 395);
            this.txtResourceCoefficient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResourceCoefficient.Name = "txtResourceCoefficient";
            this.txtResourceCoefficient.Size = new System.Drawing.Size(199, 27);
            this.txtResourceCoefficient.TabIndex = 41;
            this.txtResourceCoefficient.Tag = "ResourceCoefficient";
            this.txtResourceCoefficient.Text = "0";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(45, 399);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(145, 20);
            this.label62.TabIndex = 40;
            this.label62.Text = "Resource Coefficient";
            // 
            // txtScalingCoefficient
            // 
            this.txtScalingCoefficient.Location = new System.Drawing.Point(184, 356);
            this.txtScalingCoefficient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtScalingCoefficient.Name = "txtScalingCoefficient";
            this.txtScalingCoefficient.Size = new System.Drawing.Size(199, 27);
            this.txtScalingCoefficient.TabIndex = 39;
            this.txtScalingCoefficient.Tag = "ScalingCoefficient";
            this.txtScalingCoefficient.Text = "0";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(56, 360);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(133, 20);
            this.label61.TabIndex = 38;
            this.label61.Text = "Scaling Coefficient";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(91, 320);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(94, 20);
            this.label60.TabIndex = 37;
            this.label60.Text = "Scaling Class";
            // 
            // numScalingClass
            // 
            this.numScalingClass.Location = new System.Drawing.Point(184, 317);
            this.numScalingClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numScalingClass.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numScalingClass.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numScalingClass.Name = "numScalingClass";
            this.numScalingClass.Size = new System.Drawing.Size(200, 27);
            this.numScalingClass.TabIndex = 36;
            this.numScalingClass.Tag = "ScalingClass";
            // 
            // txtPositionFacing
            // 
            this.txtPositionFacing.Location = new System.Drawing.Point(184, 588);
            this.txtPositionFacing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPositionFacing.Name = "txtPositionFacing";
            this.txtPositionFacing.Size = new System.Drawing.Size(199, 27);
            this.txtPositionFacing.TabIndex = 35;
            this.txtPositionFacing.Tag = "PositionFacing";
            this.txtPositionFacing.Text = "0";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(77, 592);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(107, 20);
            this.label59.TabIndex = 34;
            this.label59.Text = "Position Facing";
            // 
            // txtBonusCoefficient
            // 
            this.txtBonusCoefficient.Location = new System.Drawing.Point(184, 240);
            this.txtBonusCoefficient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBonusCoefficient.Name = "txtBonusCoefficient";
            this.txtBonusCoefficient.Size = new System.Drawing.Size(199, 27);
            this.txtBonusCoefficient.TabIndex = 33;
            this.txtBonusCoefficient.Tag = "BonusCoefficient";
            this.txtBonusCoefficient.Text = "0";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(62, 244);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(125, 20);
            this.label57.TabIndex = 32;
            this.label57.Text = "Bonus Coefficient";
            // 
            // txtBonusCoefficientFromAP
            // 
            this.txtBonusCoefficientFromAP.Location = new System.Drawing.Point(184, 279);
            this.txtBonusCoefficientFromAP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBonusCoefficientFromAP.Name = "txtBonusCoefficientFromAP";
            this.txtBonusCoefficientFromAP.Size = new System.Drawing.Size(199, 27);
            this.txtBonusCoefficientFromAP.TabIndex = 31;
            this.txtBonusCoefficientFromAP.Tag = "BonusCoefficientFromAP";
            this.txtBonusCoefficientFromAP.Text = "0";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(6, 283);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(185, 20);
            this.label58.TabIndex = 30;
            this.label58.Text = "Bonus Coefficient From AP";
            // 
            // txtChainAmplitude
            // 
            this.txtChainAmplitude.Location = new System.Drawing.Point(184, 704);
            this.txtChainAmplitude.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtChainAmplitude.Name = "txtChainAmplitude";
            this.txtChainAmplitude.Size = new System.Drawing.Size(199, 27);
            this.txtChainAmplitude.TabIndex = 29;
            this.txtChainAmplitude.Tag = "ChainAmplitude";
            this.txtChainAmplitude.Text = "0";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(66, 708);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(120, 20);
            this.label56.TabIndex = 28;
            this.label56.Text = "Chain Amplitude";
            // 
            // txtAmplitude
            // 
            this.txtAmplitude.Location = new System.Drawing.Point(184, 665);
            this.txtAmplitude.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmplitude.Name = "txtAmplitude";
            this.txtAmplitude.Size = new System.Drawing.Size(199, 27);
            this.txtAmplitude.TabIndex = 27;
            this.txtAmplitude.Tag = "Amplitude";
            this.txtAmplitude.Text = "0";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(105, 669);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(79, 20);
            this.label55.TabIndex = 26;
            this.label55.Text = "Amplitude";
            // 
            // txtPointsPerResource
            // 
            this.txtPointsPerResource.Location = new System.Drawing.Point(184, 163);
            this.txtPointsPerResource.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPointsPerResource.Name = "txtPointsPerResource";
            this.txtPointsPerResource.Size = new System.Drawing.Size(199, 27);
            this.txtPointsPerResource.TabIndex = 25;
            this.txtPointsPerResource.Tag = "PointsPerResource";
            this.txtPointsPerResource.Text = "0";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(50, 167);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(136, 20);
            this.label54.TabIndex = 24;
            this.label54.Text = "Points Per Resource";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(83, 629);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(104, 20);
            this.label53.TabIndex = 23;
            this.label53.Text = "Aura Tick Rate";
            // 
            // numAuraDuration
            // 
            this.numAuraDuration.Location = new System.Drawing.Point(184, 627);
            this.numAuraDuration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numAuraDuration.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numAuraDuration.Name = "numAuraDuration";
            this.numAuraDuration.Size = new System.Drawing.Size(200, 27);
            this.numAuraDuration.TabIndex = 22;
            this.numAuraDuration.Tag = "AuraTickRate";
            // 
            // cmbApplyAura
            // 
            this.cmbApplyAura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApplyAura.FormattingEnabled = true;
            this.cmbApplyAura.Location = new System.Drawing.Point(184, 47);
            this.cmbApplyAura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbApplyAura.Name = "cmbApplyAura";
            this.cmbApplyAura.Size = new System.Drawing.Size(399, 28);
            this.cmbApplyAura.TabIndex = 21;
            this.cmbApplyAura.Tag = "ApplyAura";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(102, 51);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(83, 20);
            this.label52.TabIndex = 20;
            this.label52.Text = "Apply Aura";
            // 
            // cmbRadiusMax
            // 
            this.cmbRadiusMax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRadiusMax.FormattingEnabled = true;
            this.cmbRadiusMax.Location = new System.Drawing.Point(184, 549);
            this.cmbRadiusMax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbRadiusMax.Name = "cmbRadiusMax";
            this.cmbRadiusMax.Size = new System.Drawing.Size(199, 28);
            this.cmbRadiusMax.TabIndex = 19;
            this.cmbRadiusMax.Tag = "RadiusMax";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(99, 553);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(85, 20);
            this.label51.TabIndex = 18;
            this.label51.Text = "Radius Max";
            // 
            // cmbRadiusMin
            // 
            this.cmbRadiusMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRadiusMin.FormattingEnabled = true;
            this.cmbRadiusMin.Location = new System.Drawing.Point(184, 511);
            this.cmbRadiusMin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbRadiusMin.Name = "cmbRadiusMin";
            this.cmbRadiusMin.Size = new System.Drawing.Size(199, 28);
            this.cmbRadiusMin.TabIndex = 17;
            this.cmbRadiusMin.Tag = "RadiusMin";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(102, 515);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(82, 20);
            this.label50.TabIndex = 16;
            this.label50.Text = "Radius Min";
            // 
            // cmbTargetB
            // 
            this.cmbTargetB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTargetB.FormattingEnabled = true;
            this.cmbTargetB.Location = new System.Drawing.Point(184, 472);
            this.cmbTargetB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTargetB.Name = "cmbTargetB";
            this.cmbTargetB.Size = new System.Drawing.Size(399, 28);
            this.cmbTargetB.TabIndex = 15;
            this.cmbTargetB.Tag = "TargetB";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(120, 476);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(63, 20);
            this.label49.TabIndex = 14;
            this.label49.Text = "Target B";
            // 
            // cmbTargetA
            // 
            this.cmbTargetA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTargetA.FormattingEnabled = true;
            this.cmbTargetA.Location = new System.Drawing.Point(184, 433);
            this.cmbTargetA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTargetA.Name = "cmbTargetA";
            this.cmbTargetA.Size = new System.Drawing.Size(399, 28);
            this.cmbTargetA.TabIndex = 13;
            this.cmbTargetA.Tag = "TargetA";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(120, 437);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(64, 20);
            this.label48.TabIndex = 12;
            this.label48.Text = "Target A";
            // 
            // cmbEffMechanic
            // 
            this.cmbEffMechanic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEffMechanic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEffMechanic.FormattingEnabled = true;
            this.cmbEffMechanic.Location = new System.Drawing.Point(713, 8);
            this.cmbEffMechanic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEffMechanic.Name = "cmbEffMechanic";
            this.cmbEffMechanic.Size = new System.Drawing.Size(397, 28);
            this.cmbEffMechanic.TabIndex = 11;
            this.cmbEffMechanic.Tag = "EffMechanic";
            // 
            // label47
            // 
            this.label47.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(626, 12);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(72, 20);
            this.label47.TabIndex = 10;
            this.label47.Text = "Mechanic";
            // 
            // txtRealPoints
            // 
            this.txtRealPoints.Location = new System.Drawing.Point(184, 124);
            this.txtRealPoints.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRealPoints.Name = "txtRealPoints";
            this.txtRealPoints.Size = new System.Drawing.Size(199, 27);
            this.txtRealPoints.TabIndex = 9;
            this.txtRealPoints.Tag = "RealPoints";
            this.txtRealPoints.Text = "0";
            // 
            // txtVariance
            // 
            this.txtVariance.Location = new System.Drawing.Point(184, 201);
            this.txtVariance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVariance.Name = "txtVariance";
            this.txtVariance.Size = new System.Drawing.Size(199, 27);
            this.txtVariance.TabIndex = 8;
            this.txtVariance.Tag = "Variance";
            this.txtVariance.Text = "0";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(74, 128);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(110, 20);
            this.label46.TabIndex = 7;
            this.label46.Text = "Points Per Level";
            // 
            // lblDS
            // 
            this.lblDS.AutoSize = true;
            this.lblDS.Location = new System.Drawing.Point(119, 205);
            this.lblDS.Name = "lblDS";
            this.lblDS.Size = new System.Drawing.Size(65, 20);
            this.lblDS.TabIndex = 5;
            this.lblDS.Text = "Variance";
            // 
            // lblBP
            // 
            this.lblBP.AutoSize = true;
            this.lblBP.Location = new System.Drawing.Point(101, 88);
            this.lblBP.Name = "lblBP";
            this.lblBP.Size = new System.Drawing.Size(83, 20);
            this.lblBP.TabIndex = 3;
            this.lblBP.Text = "Base Points";
            // 
            // cmbSpellEffect
            // 
            this.cmbSpellEffect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpellEffect.FormattingEnabled = true;
            this.cmbSpellEffect.Location = new System.Drawing.Point(184, 8);
            this.cmbSpellEffect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSpellEffect.Name = "cmbSpellEffect";
            this.cmbSpellEffect.Size = new System.Drawing.Size(399, 28);
            this.cmbSpellEffect.TabIndex = 1;
            this.cmbSpellEffect.Tag = "SpellEffect";
            // 
            // lblSpellEffect
            // 
            this.lblSpellEffect.AutoSize = true;
            this.lblSpellEffect.Location = new System.Drawing.Point(103, 12);
            this.lblSpellEffect.Name = "lblSpellEffect";
            this.lblSpellEffect.Size = new System.Drawing.Size(84, 20);
            this.lblSpellEffect.TabIndex = 0;
            this.lblSpellEffect.Text = "Spell Effect";
            // 
            // tabAttributes
            // 
            this.tabAttributes.AutoScroll = true;
            this.tabAttributes.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.tabAttributes.Controls.Add(this.listAttr14);
            this.tabAttributes.Controls.Add(this.label16);
            this.tabAttributes.Controls.Add(this.listAttr13);
            this.tabAttributes.Controls.Add(this.label15);
            this.tabAttributes.Controls.Add(this.listAttr12);
            this.tabAttributes.Controls.Add(this.label14);
            this.tabAttributes.Controls.Add(this.listAttr11);
            this.tabAttributes.Controls.Add(this.label13);
            this.tabAttributes.Controls.Add(this.listAttr10);
            this.tabAttributes.Controls.Add(this.label12);
            this.tabAttributes.Controls.Add(this.listAttr9);
            this.tabAttributes.Controls.Add(this.label11);
            this.tabAttributes.Controls.Add(this.listAttr8);
            this.tabAttributes.Controls.Add(this.label10);
            this.tabAttributes.Controls.Add(this.listAttr7);
            this.tabAttributes.Controls.Add(this.label9);
            this.tabAttributes.Controls.Add(this.listAttr6);
            this.tabAttributes.Controls.Add(this.label8);
            this.tabAttributes.Controls.Add(this.listAttr5);
            this.tabAttributes.Controls.Add(this.label7);
            this.tabAttributes.Controls.Add(this.listAttr4);
            this.tabAttributes.Controls.Add(this.label6);
            this.tabAttributes.Controls.Add(this.listAttr3);
            this.tabAttributes.Controls.Add(this.label5);
            this.tabAttributes.Controls.Add(this.listAttr2);
            this.tabAttributes.Controls.Add(this.label4);
            this.tabAttributes.Controls.Add(this.listAttr1);
            this.tabAttributes.Controls.Add(this.label3);
            this.tabAttributes.Controls.Add(this.listAttr0);
            this.tabAttributes.Controls.Add(this.label2);
            this.tabAttributes.Location = new System.Drawing.Point(4, 29);
            this.tabAttributes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabAttributes.Name = "tabAttributes";
            this.tabAttributes.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabAttributes.Size = new System.Drawing.Size(1134, 874);
            this.tabAttributes.TabIndex = 1;
            this.tabAttributes.Text = "Attributes";
            this.tabAttributes.UseVisualStyleBackColor = true;
            // 
            // listAttr14
            // 
            this.listAttr14.FormattingEnabled = true;
            this.listAttr14.ItemHeight = 20;
            this.listAttr14.Location = new System.Drawing.Point(747, 2757);
            this.listAttr14.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listAttr14.Name = "listAttr14";
            this.listAttr14.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listAttr14.Size = new System.Drawing.Size(361, 644);
            this.listAttr14.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(747, 2733);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 20);
            this.label16.TabIndex = 29;
            this.label16.Text = "AttributesEx14";
            // 
            // listAttr13
            // 
            this.listAttr13.FormattingEnabled = true;
            this.listAttr13.ItemHeight = 20;
            this.listAttr13.Location = new System.Drawing.Point(339, 2757);
            this.listAttr13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listAttr13.Name = "listAttr13";
            this.listAttr13.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listAttr13.Size = new System.Drawing.Size(361, 644);
            this.listAttr13.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(339, 2733);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 20);
            this.label15.TabIndex = 27;
            this.label15.Text = "AttributesEx13";
            // 
            // listAttr12
            // 
            this.listAttr12.FormattingEnabled = true;
            this.listAttr12.ItemHeight = 20;
            this.listAttr12.Location = new System.Drawing.Point(9, 2757);
            this.listAttr12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listAttr12.Name = "listAttr12";
            this.listAttr12.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listAttr12.Size = new System.Drawing.Size(361, 644);
            this.listAttr12.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 2733);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 20);
            this.label14.TabIndex = 25;
            this.label14.Text = "AttributesEx12";
            // 
            // listAttr11
            // 
            this.listAttr11.FormattingEnabled = true;
            this.listAttr11.ItemHeight = 20;
            this.listAttr11.Location = new System.Drawing.Point(747, 2077);
            this.listAttr11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listAttr11.Name = "listAttr11";
            this.listAttr11.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listAttr11.Size = new System.Drawing.Size(361, 644);
            this.listAttr11.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(747, 2053);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "AttributesEx11";
            // 
            // listAttr10
            // 
            this.listAttr10.FormattingEnabled = true;
            this.listAttr10.ItemHeight = 20;
            this.listAttr10.Location = new System.Drawing.Point(375, 2077);
            this.listAttr10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listAttr10.Name = "listAttr10";
            this.listAttr10.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listAttr10.Size = new System.Drawing.Size(361, 644);
            this.listAttr10.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(375, 2053);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "AttributesEx10";
            // 
            // listAttr9
            // 
            this.listAttr9.FormattingEnabled = true;
            this.listAttr9.ItemHeight = 20;
            this.listAttr9.Location = new System.Drawing.Point(9, 2077);
            this.listAttr9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listAttr9.Name = "listAttr9";
            this.listAttr9.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listAttr9.Size = new System.Drawing.Size(361, 644);
            this.listAttr9.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 2053);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "AttributesEx9";
            // 
            // listAttr8
            // 
            this.listAttr8.FormattingEnabled = true;
            this.listAttr8.ItemHeight = 20;
            this.listAttr8.Location = new System.Drawing.Point(747, 1397);
            this.listAttr8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listAttr8.Name = "listAttr8";
            this.listAttr8.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listAttr8.Size = new System.Drawing.Size(361, 644);
            this.listAttr8.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(747, 1373);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "AttributesEx8";
            // 
            // listAttr7
            // 
            this.listAttr7.FormattingEnabled = true;
            this.listAttr7.ItemHeight = 20;
            this.listAttr7.Location = new System.Drawing.Point(375, 1397);
            this.listAttr7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listAttr7.Name = "listAttr7";
            this.listAttr7.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listAttr7.Size = new System.Drawing.Size(361, 644);
            this.listAttr7.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(375, 1373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "AttributesEx7";
            // 
            // listAttr6
            // 
            this.listAttr6.FormattingEnabled = true;
            this.listAttr6.ItemHeight = 20;
            this.listAttr6.Location = new System.Drawing.Point(9, 1397);
            this.listAttr6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listAttr6.Name = "listAttr6";
            this.listAttr6.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listAttr6.Size = new System.Drawing.Size(361, 644);
            this.listAttr6.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 1373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "AttributesEx6";
            // 
            // listAttr5
            // 
            this.listAttr5.FormattingEnabled = true;
            this.listAttr5.ItemHeight = 20;
            this.listAttr5.Location = new System.Drawing.Point(747, 717);
            this.listAttr5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listAttr5.Name = "listAttr5";
            this.listAttr5.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listAttr5.Size = new System.Drawing.Size(361, 644);
            this.listAttr5.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(747, 693);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "AttributesEx5";
            // 
            // listAttr4
            // 
            this.listAttr4.FormattingEnabled = true;
            this.listAttr4.ItemHeight = 20;
            this.listAttr4.Location = new System.Drawing.Point(375, 717);
            this.listAttr4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listAttr4.Name = "listAttr4";
            this.listAttr4.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listAttr4.Size = new System.Drawing.Size(361, 644);
            this.listAttr4.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 693);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "AttributesEx4";
            // 
            // listAttr3
            // 
            this.listAttr3.FormattingEnabled = true;
            this.listAttr3.ItemHeight = 20;
            this.listAttr3.Location = new System.Drawing.Point(9, 717);
            this.listAttr3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listAttr3.Name = "listAttr3";
            this.listAttr3.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listAttr3.Size = new System.Drawing.Size(361, 644);
            this.listAttr3.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 693);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "AttributesEx3";
            // 
            // listAttr2
            // 
            this.listAttr2.FormattingEnabled = true;
            this.listAttr2.ItemHeight = 20;
            this.listAttr2.Location = new System.Drawing.Point(741, 37);
            this.listAttr2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listAttr2.Name = "listAttr2";
            this.listAttr2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listAttr2.Size = new System.Drawing.Size(361, 644);
            this.listAttr2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(741, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "AttributesEx2";
            // 
            // listAttr1
            // 
            this.listAttr1.FormattingEnabled = true;
            this.listAttr1.ItemHeight = 20;
            this.listAttr1.Location = new System.Drawing.Point(375, 37);
            this.listAttr1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listAttr1.Name = "listAttr1";
            this.listAttr1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listAttr1.Size = new System.Drawing.Size(361, 644);
            this.listAttr1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "AttributesEx";
            // 
            // listAttr0
            // 
            this.listAttr0.FormattingEnabled = true;
            this.listAttr0.ItemHeight = 20;
            this.listAttr0.Location = new System.Drawing.Point(9, 37);
            this.listAttr0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listAttr0.Name = "listAttr0";
            this.listAttr0.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listAttr0.Size = new System.Drawing.Size(361, 644);
            this.listAttr0.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Attributes";
            // 
            // tabFlags
            // 
            this.tabFlags.Controls.Add(this.listChannelInterruptFlags2);
            this.tabFlags.Controls.Add(this.label198);
            this.tabFlags.Controls.Add(this.listChannelInterruptFlags);
            this.tabFlags.Controls.Add(this.label199);
            this.tabFlags.Controls.Add(this.listAuraInterruptFlags2);
            this.tabFlags.Controls.Add(this.label160);
            this.tabFlags.Controls.Add(this.listAuraInterruptFlags);
            this.tabFlags.Controls.Add(this.label159);
            this.tabFlags.Controls.Add(this.listInterruptFlags);
            this.tabFlags.Controls.Add(this.label158);
            this.tabFlags.Location = new System.Drawing.Point(4, 29);
            this.tabFlags.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabFlags.Name = "tabFlags";
            this.tabFlags.Size = new System.Drawing.Size(1134, 874);
            this.tabFlags.TabIndex = 5;
            this.tabFlags.Text = "Flags";
            this.tabFlags.UseVisualStyleBackColor = true;
            // 
            // listChannelInterruptFlags2
            // 
            this.listChannelInterruptFlags2.FormattingEnabled = true;
            this.listChannelInterruptFlags2.ItemHeight = 20;
            this.listChannelInterruptFlags2.Location = new System.Drawing.Point(687, 37);
            this.listChannelInterruptFlags2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listChannelInterruptFlags2.Name = "listChannelInterruptFlags2";
            this.listChannelInterruptFlags2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listChannelInterruptFlags2.Size = new System.Drawing.Size(220, 464);
            this.listChannelInterruptFlags2.TabIndex = 16;
            // 
            // label198
            // 
            this.label198.AutoSize = true;
            this.label198.Location = new System.Drawing.Point(687, 13);
            this.label198.Name = "label198";
            this.label198.Size = new System.Drawing.Size(173, 20);
            this.label198.TabIndex = 15;
            this.label198.Text = "Channel Interrupt Flags 2";
            // 
            // listChannelInterruptFlags
            // 
            this.listChannelInterruptFlags.FormattingEnabled = true;
            this.listChannelInterruptFlags.ItemHeight = 20;
            this.listChannelInterruptFlags.Location = new System.Drawing.Point(461, 37);
            this.listChannelInterruptFlags.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listChannelInterruptFlags.Name = "listChannelInterruptFlags";
            this.listChannelInterruptFlags.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listChannelInterruptFlags.Size = new System.Drawing.Size(220, 684);
            this.listChannelInterruptFlags.TabIndex = 14;
            // 
            // label199
            // 
            this.label199.AutoSize = true;
            this.label199.Location = new System.Drawing.Point(461, 13);
            this.label199.Name = "label199";
            this.label199.Size = new System.Drawing.Size(161, 20);
            this.label199.TabIndex = 13;
            this.label199.Text = "Channel Interrupt Flags";
            // 
            // listAuraInterruptFlags2
            // 
            this.listAuraInterruptFlags2.FormattingEnabled = true;
            this.listAuraInterruptFlags2.ItemHeight = 20;
            this.listAuraInterruptFlags2.Location = new System.Drawing.Point(235, 37);
            this.listAuraInterruptFlags2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listAuraInterruptFlags2.Name = "listAuraInterruptFlags2";
            this.listAuraInterruptFlags2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listAuraInterruptFlags2.Size = new System.Drawing.Size(220, 464);
            this.listAuraInterruptFlags2.TabIndex = 8;
            // 
            // label160
            // 
            this.label160.AutoSize = true;
            this.label160.Location = new System.Drawing.Point(235, 13);
            this.label160.Name = "label160";
            this.label160.Size = new System.Drawing.Size(151, 20);
            this.label160.TabIndex = 7;
            this.label160.Text = "Aura Interrupt Flags 2";
            // 
            // listAuraInterruptFlags
            // 
            this.listAuraInterruptFlags.FormattingEnabled = true;
            this.listAuraInterruptFlags.ItemHeight = 20;
            this.listAuraInterruptFlags.Location = new System.Drawing.Point(9, 37);
            this.listAuraInterruptFlags.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listAuraInterruptFlags.Name = "listAuraInterruptFlags";
            this.listAuraInterruptFlags.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listAuraInterruptFlags.Size = new System.Drawing.Size(220, 684);
            this.listAuraInterruptFlags.TabIndex = 6;
            // 
            // label159
            // 
            this.label159.AutoSize = true;
            this.label159.Location = new System.Drawing.Point(9, 13);
            this.label159.Name = "label159";
            this.label159.Size = new System.Drawing.Size(139, 20);
            this.label159.TabIndex = 5;
            this.label159.Text = "Aura Interrupt Flags";
            // 
            // listInterruptFlags
            // 
            this.listInterruptFlags.FormattingEnabled = true;
            this.listInterruptFlags.ItemHeight = 20;
            this.listInterruptFlags.Location = new System.Drawing.Point(913, 37);
            this.listInterruptFlags.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listInterruptFlags.Name = "listInterruptFlags";
            this.listInterruptFlags.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listInterruptFlags.Size = new System.Drawing.Size(218, 244);
            this.listInterruptFlags.TabIndex = 4;
            // 
            // label158
            // 
            this.label158.AutoSize = true;
            this.label158.Location = new System.Drawing.Point(913, 13);
            this.label158.Name = "label158";
            this.label158.Size = new System.Drawing.Size(104, 20);
            this.label158.TabIndex = 3;
            this.label158.Text = "Interrupt Flags";
            // 
            // tabFlags2
            // 
            this.tabFlags2.Controls.Add(this.listExStances);
            this.tabFlags2.Controls.Add(this.label162);
            this.tabFlags2.Controls.Add(this.listStances);
            this.tabFlags2.Controls.Add(this.label201);
            this.tabFlags2.Location = new System.Drawing.Point(4, 29);
            this.tabFlags2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabFlags2.Name = "tabFlags2";
            this.tabFlags2.Size = new System.Drawing.Size(1134, 874);
            this.tabFlags2.TabIndex = 8;
            this.tabFlags2.Text = "Flags 2";
            this.tabFlags2.UseVisualStyleBackColor = true;
            // 
            // listExStances
            // 
            this.listExStances.FormattingEnabled = true;
            this.listExStances.ItemHeight = 20;
            this.listExStances.Location = new System.Drawing.Point(296, 37);
            this.listExStances.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listExStances.Name = "listExStances";
            this.listExStances.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listExStances.Size = new System.Drawing.Size(239, 824);
            this.listExStances.TabIndex = 16;
            // 
            // label162
            // 
            this.label162.AutoSize = true;
            this.label162.Location = new System.Drawing.Point(296, 13);
            this.label162.Name = "label162";
            this.label162.Size = new System.Drawing.Size(114, 20);
            this.label162.TabIndex = 15;
            this.label162.Text = "Exclude Stances";
            // 
            // listStances
            // 
            this.listStances.FormattingEnabled = true;
            this.listStances.ItemHeight = 20;
            this.listStances.Location = new System.Drawing.Point(9, 37);
            this.listStances.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listStances.Name = "listStances";
            this.listStances.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listStances.Size = new System.Drawing.Size(239, 824);
            this.listStances.TabIndex = 14;
            // 
            // label201
            // 
            this.label201.AutoSize = true;
            this.label201.Location = new System.Drawing.Point(9, 13);
            this.label201.Name = "label201";
            this.label201.Size = new System.Drawing.Size(59, 20);
            this.label201.TabIndex = 13;
            this.label201.Text = "Stances";
            // 
            // tabItems
            // 
            this.tabItems.Controls.Add(this.groupBox7);
            this.tabItems.Controls.Add(this.groupBox6);
            this.tabItems.Controls.Add(this.groupBox5);
            this.tabItems.Controls.Add(this.groupBox4);
            this.tabItems.Location = new System.Drawing.Point(4, 29);
            this.tabItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabItems.Name = "tabItems";
            this.tabItems.Size = new System.Drawing.Size(1134, 874);
            this.tabItems.TabIndex = 7;
            this.tabItems.Text = "Items";
            this.tabItems.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.listEquippedItemSubClass);
            this.groupBox7.Controls.Add(this.label189);
            this.groupBox7.Controls.Add(this.listEquippedItemInvenType);
            this.groupBox7.Controls.Add(this.label188);
            this.groupBox7.Controls.Add(this.cmbEquippedItemClass);
            this.groupBox7.Controls.Add(this.label187);
            this.groupBox7.Location = new System.Drawing.Point(427, 4);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Size = new System.Drawing.Size(703, 869);
            this.groupBox7.TabIndex = 82;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Equipped";
            // 
            // listEquippedItemSubClass
            // 
            this.listEquippedItemSubClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listEquippedItemSubClass.FormattingEnabled = true;
            this.listEquippedItemSubClass.ItemHeight = 20;
            this.listEquippedItemSubClass.Location = new System.Drawing.Point(361, 85);
            this.listEquippedItemSubClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listEquippedItemSubClass.Name = "listEquippedItemSubClass";
            this.listEquippedItemSubClass.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listEquippedItemSubClass.Size = new System.Drawing.Size(331, 764);
            this.listEquippedItemSubClass.TabIndex = 62;
            // 
            // label189
            // 
            this.label189.AutoSize = true;
            this.label189.Location = new System.Drawing.Point(361, 61);
            this.label189.Name = "label189";
            this.label189.Size = new System.Drawing.Size(169, 20);
            this.label189.TabIndex = 61;
            this.label189.Text = "Equipped Item SubClass";
            // 
            // listEquippedItemInvenType
            // 
            this.listEquippedItemInvenType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listEquippedItemInvenType.FormattingEnabled = true;
            this.listEquippedItemInvenType.ItemHeight = 20;
            this.listEquippedItemInvenType.Location = new System.Drawing.Point(7, 85);
            this.listEquippedItemInvenType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listEquippedItemInvenType.Name = "listEquippedItemInvenType";
            this.listEquippedItemInvenType.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listEquippedItemInvenType.Size = new System.Drawing.Size(331, 764);
            this.listEquippedItemInvenType.TabIndex = 60;
            // 
            // label188
            // 
            this.label188.AutoSize = true;
            this.label188.Location = new System.Drawing.Point(7, 61);
            this.label188.Name = "label188";
            this.label188.Size = new System.Drawing.Size(207, 20);
            this.label188.TabIndex = 59;
            this.label188.Text = "Equipped Item Inventory Type";
            // 
            // cmbEquippedItemClass
            // 
            this.cmbEquippedItemClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquippedItemClass.FormattingEnabled = true;
            this.cmbEquippedItemClass.Location = new System.Drawing.Point(157, 21);
            this.cmbEquippedItemClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEquippedItemClass.Name = "cmbEquippedItemClass";
            this.cmbEquippedItemClass.Size = new System.Drawing.Size(231, 28);
            this.cmbEquippedItemClass.TabIndex = 58;
            this.cmbEquippedItemClass.Tag = "SpellEffect";
            this.cmbEquippedItemClass.SelectedIndexChanged += new System.EventHandler(this.cmbEquippedItemClass_SelectedIndexChanged);
            // 
            // label187
            // 
            this.label187.AutoSize = true;
            this.label187.Location = new System.Drawing.Point(7, 27);
            this.label187.Name = "label187";
            this.label187.Size = new System.Drawing.Size(144, 20);
            this.label187.TabIndex = 2;
            this.label187.Text = "Equipped Item Class";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.cmbCurrencyType);
            this.groupBox6.Controls.Add(this.btnCurrencyDelete);
            this.groupBox6.Controls.Add(this.btnCurrencySave);
            this.groupBox6.Controls.Add(this.btnCurrencyCopy);
            this.groupBox6.Controls.Add(this.btnCurrencyNew);
            this.groupBox6.Controls.Add(this.label186);
            this.groupBox6.Controls.Add(this.numCurrencyCount);
            this.groupBox6.Controls.Add(this.label185);
            this.groupBox6.Controls.Add(this.numCurrencyId);
            this.groupBox6.Controls.Add(this.label184);
            this.groupBox6.Controls.Add(this.cmbSelectCurrency);
            this.groupBox6.Controls.Add(this.label183);
            this.groupBox6.Location = new System.Drawing.Point(3, 547);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(419, 223);
            this.groupBox6.TabIndex = 81;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Currency";
            // 
            // cmbCurrencyType
            // 
            this.cmbCurrencyType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCurrencyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrencyType.FormattingEnabled = true;
            this.cmbCurrencyType.Location = new System.Drawing.Point(79, 145);
            this.cmbCurrencyType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCurrencyType.Name = "cmbCurrencyType";
            this.cmbCurrencyType.Size = new System.Drawing.Size(329, 28);
            this.cmbCurrencyType.TabIndex = 70;
            this.cmbCurrencyType.Tag = "SpellEffect";
            // 
            // btnCurrencyDelete
            // 
            this.btnCurrencyDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCurrencyDelete.Location = new System.Drawing.Point(345, 184);
            this.btnCurrencyDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCurrencyDelete.Name = "btnCurrencyDelete";
            this.btnCurrencyDelete.Size = new System.Drawing.Size(61, 31);
            this.btnCurrencyDelete.TabIndex = 69;
            this.btnCurrencyDelete.Text = "Delete";
            this.btnCurrencyDelete.UseVisualStyleBackColor = true;
            this.btnCurrencyDelete.Click += new System.EventHandler(this.btnCurrencyDelete_Click);
            // 
            // btnCurrencySave
            // 
            this.btnCurrencySave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCurrencySave.Location = new System.Drawing.Point(285, 184);
            this.btnCurrencySave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCurrencySave.Name = "btnCurrencySave";
            this.btnCurrencySave.Size = new System.Drawing.Size(53, 31);
            this.btnCurrencySave.TabIndex = 68;
            this.btnCurrencySave.Text = "Save";
            this.btnCurrencySave.UseVisualStyleBackColor = true;
            this.btnCurrencySave.Click += new System.EventHandler(this.btnCurrencySave_Click);
            // 
            // btnCurrencyCopy
            // 
            this.btnCurrencyCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCurrencyCopy.Location = new System.Drawing.Point(226, 184);
            this.btnCurrencyCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCurrencyCopy.Name = "btnCurrencyCopy";
            this.btnCurrencyCopy.Size = new System.Drawing.Size(53, 31);
            this.btnCurrencyCopy.TabIndex = 67;
            this.btnCurrencyCopy.Text = "Copy";
            this.btnCurrencyCopy.UseVisualStyleBackColor = true;
            this.btnCurrencyCopy.Click += new System.EventHandler(this.btnCurrencyCopy_Click);
            // 
            // btnCurrencyNew
            // 
            this.btnCurrencyNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCurrencyNew.Location = new System.Drawing.Point(167, 184);
            this.btnCurrencyNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCurrencyNew.Name = "btnCurrencyNew";
            this.btnCurrencyNew.Size = new System.Drawing.Size(53, 31);
            this.btnCurrencyNew.TabIndex = 66;
            this.btnCurrencyNew.Text = "New";
            this.btnCurrencyNew.UseVisualStyleBackColor = true;
            this.btnCurrencyNew.Click += new System.EventHandler(this.btnCurrencyNew_Click);
            // 
            // label186
            // 
            this.label186.AutoSize = true;
            this.label186.Location = new System.Drawing.Point(33, 145);
            this.label186.Name = "label186";
            this.label186.Size = new System.Drawing.Size(40, 20);
            this.label186.TabIndex = 65;
            this.label186.Text = "Type";
            // 
            // numCurrencyCount
            // 
            this.numCurrencyCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numCurrencyCount.Location = new System.Drawing.Point(79, 107);
            this.numCurrencyCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numCurrencyCount.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numCurrencyCount.Name = "numCurrencyCount";
            this.numCurrencyCount.Size = new System.Drawing.Size(330, 27);
            this.numCurrencyCount.TabIndex = 62;
            this.numCurrencyCount.Tag = "MiscValueA";
            // 
            // label185
            // 
            this.label185.AutoSize = true;
            this.label185.Location = new System.Drawing.Point(25, 109);
            this.label185.Name = "label185";
            this.label185.Size = new System.Drawing.Size(48, 20);
            this.label185.TabIndex = 63;
            this.label185.Text = "Count";
            // 
            // numCurrencyId
            // 
            this.numCurrencyId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numCurrencyId.Location = new System.Drawing.Point(79, 68);
            this.numCurrencyId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numCurrencyId.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numCurrencyId.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numCurrencyId.Name = "numCurrencyId";
            this.numCurrencyId.Size = new System.Drawing.Size(330, 27);
            this.numCurrencyId.TabIndex = 60;
            this.numCurrencyId.Tag = "MiscValueA";
            // 
            // label184
            // 
            this.label184.AutoSize = true;
            this.label184.Location = new System.Drawing.Point(49, 68);
            this.label184.Name = "label184";
            this.label184.Size = new System.Drawing.Size(24, 20);
            this.label184.TabIndex = 61;
            this.label184.Text = "ID";
            // 
            // cmbSelectCurrency
            // 
            this.cmbSelectCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSelectCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectCurrency.FormattingEnabled = true;
            this.cmbSelectCurrency.Location = new System.Drawing.Point(79, 29);
            this.cmbSelectCurrency.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSelectCurrency.Name = "cmbSelectCurrency";
            this.cmbSelectCurrency.Size = new System.Drawing.Size(329, 28);
            this.cmbSelectCurrency.TabIndex = 59;
            this.cmbSelectCurrency.Tag = "SpellEffect";
            this.cmbSelectCurrency.SelectedIndexChanged += new System.EventHandler(this.cmbSelectCurrency_SelectedIndexChanged);
            // 
            // label183
            // 
            this.label183.AutoSize = true;
            this.label183.Location = new System.Drawing.Point(7, 32);
            this.label183.Name = "label183";
            this.label183.Size = new System.Drawing.Size(66, 20);
            this.label183.TabIndex = 58;
            this.label183.Text = "Currency";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.label181);
            this.groupBox5.Controls.Add(this.numReagentCount8);
            this.groupBox5.Controls.Add(this.label182);
            this.groupBox5.Controls.Add(this.numReagent8);
            this.groupBox5.Controls.Add(this.label179);
            this.groupBox5.Controls.Add(this.numReagentCount7);
            this.groupBox5.Controls.Add(this.label180);
            this.groupBox5.Controls.Add(this.numReagent7);
            this.groupBox5.Controls.Add(this.label177);
            this.groupBox5.Controls.Add(this.numReagentCount6);
            this.groupBox5.Controls.Add(this.label178);
            this.groupBox5.Controls.Add(this.numReagent6);
            this.groupBox5.Controls.Add(this.label175);
            this.groupBox5.Controls.Add(this.numReagentCount5);
            this.groupBox5.Controls.Add(this.label176);
            this.groupBox5.Controls.Add(this.numReagent5);
            this.groupBox5.Controls.Add(this.label173);
            this.groupBox5.Controls.Add(this.numReagentCount4);
            this.groupBox5.Controls.Add(this.label174);
            this.groupBox5.Controls.Add(this.numReagent4);
            this.groupBox5.Controls.Add(this.label171);
            this.groupBox5.Controls.Add(this.numReagentCount3);
            this.groupBox5.Controls.Add(this.label172);
            this.groupBox5.Controls.Add(this.numReagent3);
            this.groupBox5.Controls.Add(this.label169);
            this.groupBox5.Controls.Add(this.numReagentCount2);
            this.groupBox5.Controls.Add(this.label170);
            this.groupBox5.Controls.Add(this.numReagent2);
            this.groupBox5.Controls.Add(this.label168);
            this.groupBox5.Controls.Add(this.numReagentCount1);
            this.groupBox5.Controls.Add(this.label167);
            this.groupBox5.Controls.Add(this.numReagent1);
            this.groupBox5.Location = new System.Drawing.Point(3, 197);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(419, 341);
            this.groupBox5.TabIndex = 51;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Reagents";
            // 
            // label181
            // 
            this.label181.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label181.AutoSize = true;
            this.label181.Location = new System.Drawing.Point(267, 303);
            this.label181.Name = "label181";
            this.label181.Size = new System.Drawing.Size(48, 20);
            this.label181.TabIndex = 79;
            this.label181.Text = "Count";
            // 
            // numReagentCount8
            // 
            this.numReagentCount8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numReagentCount8.Location = new System.Drawing.Point(320, 300);
            this.numReagentCount8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numReagentCount8.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numReagentCount8.Name = "numReagentCount8";
            this.numReagentCount8.Size = new System.Drawing.Size(93, 27);
            this.numReagentCount8.TabIndex = 78;
            this.numReagentCount8.Tag = "MiscValueA";
            // 
            // label182
            // 
            this.label182.AutoSize = true;
            this.label182.Location = new System.Drawing.Point(6, 303);
            this.label182.Name = "label182";
            this.label182.Size = new System.Drawing.Size(76, 20);
            this.label182.TabIndex = 77;
            this.label182.Text = "Reagent 8";
            // 
            // numReagent8
            // 
            this.numReagent8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numReagent8.Location = new System.Drawing.Point(85, 300);
            this.numReagent8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numReagent8.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numReagent8.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numReagent8.Name = "numReagent8";
            this.numReagent8.Size = new System.Drawing.Size(174, 27);
            this.numReagent8.TabIndex = 76;
            this.numReagent8.Tag = "MiscValueA";
            // 
            // label179
            // 
            this.label179.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label179.AutoSize = true;
            this.label179.Location = new System.Drawing.Point(267, 264);
            this.label179.Name = "label179";
            this.label179.Size = new System.Drawing.Size(48, 20);
            this.label179.TabIndex = 75;
            this.label179.Text = "Count";
            // 
            // numReagentCount7
            // 
            this.numReagentCount7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numReagentCount7.Location = new System.Drawing.Point(320, 261);
            this.numReagentCount7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numReagentCount7.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numReagentCount7.Name = "numReagentCount7";
            this.numReagentCount7.Size = new System.Drawing.Size(93, 27);
            this.numReagentCount7.TabIndex = 74;
            this.numReagentCount7.Tag = "MiscValueA";
            // 
            // label180
            // 
            this.label180.AutoSize = true;
            this.label180.Location = new System.Drawing.Point(6, 264);
            this.label180.Name = "label180";
            this.label180.Size = new System.Drawing.Size(76, 20);
            this.label180.TabIndex = 73;
            this.label180.Text = "Reagent 7";
            // 
            // numReagent7
            // 
            this.numReagent7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numReagent7.Location = new System.Drawing.Point(85, 261);
            this.numReagent7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numReagent7.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numReagent7.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numReagent7.Name = "numReagent7";
            this.numReagent7.Size = new System.Drawing.Size(174, 27);
            this.numReagent7.TabIndex = 72;
            this.numReagent7.Tag = "MiscValueA";
            // 
            // label177
            // 
            this.label177.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label177.AutoSize = true;
            this.label177.Location = new System.Drawing.Point(267, 225);
            this.label177.Name = "label177";
            this.label177.Size = new System.Drawing.Size(48, 20);
            this.label177.TabIndex = 71;
            this.label177.Text = "Count";
            // 
            // numReagentCount6
            // 
            this.numReagentCount6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numReagentCount6.Location = new System.Drawing.Point(320, 223);
            this.numReagentCount6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numReagentCount6.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numReagentCount6.Name = "numReagentCount6";
            this.numReagentCount6.Size = new System.Drawing.Size(93, 27);
            this.numReagentCount6.TabIndex = 70;
            this.numReagentCount6.Tag = "MiscValueA";
            // 
            // label178
            // 
            this.label178.AutoSize = true;
            this.label178.Location = new System.Drawing.Point(6, 225);
            this.label178.Name = "label178";
            this.label178.Size = new System.Drawing.Size(76, 20);
            this.label178.TabIndex = 69;
            this.label178.Text = "Reagent 6";
            // 
            // numReagent6
            // 
            this.numReagent6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numReagent6.Location = new System.Drawing.Point(85, 223);
            this.numReagent6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numReagent6.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numReagent6.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numReagent6.Name = "numReagent6";
            this.numReagent6.Size = new System.Drawing.Size(174, 27);
            this.numReagent6.TabIndex = 68;
            this.numReagent6.Tag = "MiscValueA";
            // 
            // label175
            // 
            this.label175.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label175.AutoSize = true;
            this.label175.Location = new System.Drawing.Point(267, 187);
            this.label175.Name = "label175";
            this.label175.Size = new System.Drawing.Size(48, 20);
            this.label175.TabIndex = 67;
            this.label175.Text = "Count";
            // 
            // numReagentCount5
            // 
            this.numReagentCount5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numReagentCount5.Location = new System.Drawing.Point(320, 184);
            this.numReagentCount5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numReagentCount5.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numReagentCount5.Name = "numReagentCount5";
            this.numReagentCount5.Size = new System.Drawing.Size(93, 27);
            this.numReagentCount5.TabIndex = 66;
            this.numReagentCount5.Tag = "MiscValueA";
            // 
            // label176
            // 
            this.label176.AutoSize = true;
            this.label176.Location = new System.Drawing.Point(6, 187);
            this.label176.Name = "label176";
            this.label176.Size = new System.Drawing.Size(76, 20);
            this.label176.TabIndex = 65;
            this.label176.Text = "Reagent 5";
            // 
            // numReagent5
            // 
            this.numReagent5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numReagent5.Location = new System.Drawing.Point(85, 184);
            this.numReagent5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numReagent5.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numReagent5.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numReagent5.Name = "numReagent5";
            this.numReagent5.Size = new System.Drawing.Size(174, 27);
            this.numReagent5.TabIndex = 64;
            this.numReagent5.Tag = "MiscValueA";
            // 
            // label173
            // 
            this.label173.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label173.AutoSize = true;
            this.label173.Location = new System.Drawing.Point(267, 148);
            this.label173.Name = "label173";
            this.label173.Size = new System.Drawing.Size(48, 20);
            this.label173.TabIndex = 63;
            this.label173.Text = "Count";
            // 
            // numReagentCount4
            // 
            this.numReagentCount4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numReagentCount4.Location = new System.Drawing.Point(320, 145);
            this.numReagentCount4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numReagentCount4.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numReagentCount4.Name = "numReagentCount4";
            this.numReagentCount4.Size = new System.Drawing.Size(93, 27);
            this.numReagentCount4.TabIndex = 62;
            this.numReagentCount4.Tag = "MiscValueA";
            // 
            // label174
            // 
            this.label174.AutoSize = true;
            this.label174.Location = new System.Drawing.Point(6, 148);
            this.label174.Name = "label174";
            this.label174.Size = new System.Drawing.Size(76, 20);
            this.label174.TabIndex = 61;
            this.label174.Text = "Reagent 4";
            // 
            // numReagent4
            // 
            this.numReagent4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numReagent4.Location = new System.Drawing.Point(85, 145);
            this.numReagent4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numReagent4.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numReagent4.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numReagent4.Name = "numReagent4";
            this.numReagent4.Size = new System.Drawing.Size(174, 27);
            this.numReagent4.TabIndex = 60;
            this.numReagent4.Tag = "MiscValueA";
            // 
            // label171
            // 
            this.label171.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label171.AutoSize = true;
            this.label171.Location = new System.Drawing.Point(267, 109);
            this.label171.Name = "label171";
            this.label171.Size = new System.Drawing.Size(48, 20);
            this.label171.TabIndex = 59;
            this.label171.Text = "Count";
            // 
            // numReagentCount3
            // 
            this.numReagentCount3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numReagentCount3.Location = new System.Drawing.Point(320, 107);
            this.numReagentCount3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numReagentCount3.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numReagentCount3.Name = "numReagentCount3";
            this.numReagentCount3.Size = new System.Drawing.Size(93, 27);
            this.numReagentCount3.TabIndex = 58;
            this.numReagentCount3.Tag = "MiscValueA";
            // 
            // label172
            // 
            this.label172.AutoSize = true;
            this.label172.Location = new System.Drawing.Point(6, 109);
            this.label172.Name = "label172";
            this.label172.Size = new System.Drawing.Size(76, 20);
            this.label172.TabIndex = 57;
            this.label172.Text = "Reagent 3";
            // 
            // numReagent3
            // 
            this.numReagent3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numReagent3.Location = new System.Drawing.Point(85, 107);
            this.numReagent3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numReagent3.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numReagent3.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numReagent3.Name = "numReagent3";
            this.numReagent3.Size = new System.Drawing.Size(174, 27);
            this.numReagent3.TabIndex = 56;
            this.numReagent3.Tag = "MiscValueA";
            // 
            // label169
            // 
            this.label169.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label169.AutoSize = true;
            this.label169.Location = new System.Drawing.Point(267, 71);
            this.label169.Name = "label169";
            this.label169.Size = new System.Drawing.Size(48, 20);
            this.label169.TabIndex = 55;
            this.label169.Text = "Count";
            // 
            // numReagentCount2
            // 
            this.numReagentCount2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numReagentCount2.Location = new System.Drawing.Point(320, 68);
            this.numReagentCount2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numReagentCount2.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numReagentCount2.Name = "numReagentCount2";
            this.numReagentCount2.Size = new System.Drawing.Size(93, 27);
            this.numReagentCount2.TabIndex = 54;
            this.numReagentCount2.Tag = "MiscValueA";
            // 
            // label170
            // 
            this.label170.AutoSize = true;
            this.label170.Location = new System.Drawing.Point(6, 71);
            this.label170.Name = "label170";
            this.label170.Size = new System.Drawing.Size(76, 20);
            this.label170.TabIndex = 53;
            this.label170.Text = "Reagent 2";
            // 
            // numReagent2
            // 
            this.numReagent2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numReagent2.Location = new System.Drawing.Point(85, 68);
            this.numReagent2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numReagent2.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numReagent2.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numReagent2.Name = "numReagent2";
            this.numReagent2.Size = new System.Drawing.Size(174, 27);
            this.numReagent2.TabIndex = 52;
            this.numReagent2.Tag = "MiscValueA";
            // 
            // label168
            // 
            this.label168.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label168.AutoSize = true;
            this.label168.Location = new System.Drawing.Point(267, 32);
            this.label168.Name = "label168";
            this.label168.Size = new System.Drawing.Size(48, 20);
            this.label168.TabIndex = 51;
            this.label168.Text = "Count";
            // 
            // numReagentCount1
            // 
            this.numReagentCount1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numReagentCount1.Location = new System.Drawing.Point(320, 29);
            this.numReagentCount1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numReagentCount1.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numReagentCount1.Name = "numReagentCount1";
            this.numReagentCount1.Size = new System.Drawing.Size(93, 27);
            this.numReagentCount1.TabIndex = 50;
            this.numReagentCount1.Tag = "MiscValueA";
            // 
            // label167
            // 
            this.label167.AutoSize = true;
            this.label167.Location = new System.Drawing.Point(6, 32);
            this.label167.Name = "label167";
            this.label167.Size = new System.Drawing.Size(76, 20);
            this.label167.TabIndex = 49;
            this.label167.Text = "Reagent 1";
            // 
            // numReagent1
            // 
            this.numReagent1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numReagent1.Location = new System.Drawing.Point(85, 29);
            this.numReagent1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numReagent1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numReagent1.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numReagent1.Name = "numReagent1";
            this.numReagent1.Size = new System.Drawing.Size(174, 27);
            this.numReagent1.TabIndex = 48;
            this.numReagent1.Tag = "MiscValueA";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.cmbTotemCategory2);
            this.groupBox4.Controls.Add(this.cmbTotemCategory1);
            this.groupBox4.Controls.Add(this.label166);
            this.groupBox4.Controls.Add(this.label165);
            this.groupBox4.Controls.Add(this.numTotem2);
            this.groupBox4.Controls.Add(this.label164);
            this.groupBox4.Controls.Add(this.numTotem1);
            this.groupBox4.Controls.Add(this.label163);
            this.groupBox4.Location = new System.Drawing.Point(3, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(419, 185);
            this.groupBox4.TabIndex = 50;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Totems";
            // 
            // cmbTotemCategory2
            // 
            this.cmbTotemCategory2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTotemCategory2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTotemCategory2.FormattingEnabled = true;
            this.cmbTotemCategory2.Location = new System.Drawing.Point(133, 136);
            this.cmbTotemCategory2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTotemCategory2.Name = "cmbTotemCategory2";
            this.cmbTotemCategory2.Size = new System.Drawing.Size(281, 28);
            this.cmbTotemCategory2.TabIndex = 57;
            this.cmbTotemCategory2.Tag = "SpellEffect";
            // 
            // cmbTotemCategory1
            // 
            this.cmbTotemCategory1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTotemCategory1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTotemCategory1.FormattingEnabled = true;
            this.cmbTotemCategory1.Location = new System.Drawing.Point(133, 100);
            this.cmbTotemCategory1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTotemCategory1.Name = "cmbTotemCategory1";
            this.cmbTotemCategory1.Size = new System.Drawing.Size(281, 28);
            this.cmbTotemCategory1.TabIndex = 56;
            this.cmbTotemCategory1.Tag = "SpellEffect";
            // 
            // label166
            // 
            this.label166.AutoSize = true;
            this.label166.Location = new System.Drawing.Point(7, 141);
            this.label166.Name = "label166";
            this.label166.Size = new System.Drawing.Size(127, 20);
            this.label166.TabIndex = 55;
            this.label166.Text = "Totem Category 2";
            // 
            // label165
            // 
            this.label165.AutoSize = true;
            this.label165.Location = new System.Drawing.Point(7, 103);
            this.label165.Name = "label165";
            this.label165.Size = new System.Drawing.Size(127, 20);
            this.label165.TabIndex = 53;
            this.label165.Text = "Totem Category 1";
            // 
            // numTotem2
            // 
            this.numTotem2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numTotem2.Location = new System.Drawing.Point(133, 61);
            this.numTotem2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numTotem2.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numTotem2.Name = "numTotem2";
            this.numTotem2.Size = new System.Drawing.Size(281, 27);
            this.numTotem2.TabIndex = 50;
            this.numTotem2.Tag = "MiscValueA";
            // 
            // label164
            // 
            this.label164.AutoSize = true;
            this.label164.Location = new System.Drawing.Point(65, 64);
            this.label164.Name = "label164";
            this.label164.Size = new System.Drawing.Size(63, 20);
            this.label164.TabIndex = 51;
            this.label164.Text = "Totem 2";
            // 
            // numTotem1
            // 
            this.numTotem1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numTotem1.Location = new System.Drawing.Point(133, 23);
            this.numTotem1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numTotem1.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numTotem1.Name = "numTotem1";
            this.numTotem1.Size = new System.Drawing.Size(281, 27);
            this.numTotem1.TabIndex = 48;
            this.numTotem1.Tag = "MiscValueA";
            // 
            // label163
            // 
            this.label163.AutoSize = true;
            this.label163.Location = new System.Drawing.Point(65, 25);
            this.label163.Name = "label163";
            this.label163.Size = new System.Drawing.Size(63, 20);
            this.label163.TabIndex = 49;
            this.label163.Text = "Totem 1";
            // 
            // tabIcon
            // 
            this.tabIcon.Controls.Add(this.lblIconPageCount);
            this.tabIcon.Controls.Add(this.label87);
            this.tabIcon.Controls.Add(this.numIconPage);
            this.tabIcon.Controls.Add(this.btnIconLast);
            this.tabIcon.Controls.Add(this.btnIconNext);
            this.tabIcon.Controls.Add(this.btnIconPrevious);
            this.tabIcon.Controls.Add(this.btnIconFirst);
            this.tabIcon.Controls.Add(this.txtIconSearch);
            this.tabIcon.Controls.Add(this.lblSelIcon);
            this.tabIcon.Controls.Add(this.lblActiveIcon);
            this.tabIcon.Controls.Add(this.lblCurIcon);
            this.tabIcon.Controls.Add(this.btnActiveIconUndo);
            this.tabIcon.Controls.Add(this.btnActiveIconChange);
            this.tabIcon.Controls.Add(this.btnCurIconUndo);
            this.tabIcon.Controls.Add(this.btnCurIconChange);
            this.tabIcon.Controls.Add(this.picSelectedIcon);
            this.tabIcon.Controls.Add(this.picActiveIcon);
            this.tabIcon.Controls.Add(this.picCurIcon);
            this.tabIcon.Controls.Add(this.label86);
            this.tabIcon.Controls.Add(this.label85);
            this.tabIcon.Controls.Add(this.label84);
            this.tabIcon.Controls.Add(this.lvIcons);
            this.tabIcon.Location = new System.Drawing.Point(4, 29);
            this.tabIcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabIcon.Name = "tabIcon";
            this.tabIcon.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabIcon.Size = new System.Drawing.Size(1134, 874);
            this.tabIcon.TabIndex = 2;
            this.tabIcon.Text = "Icon";
            this.tabIcon.UseVisualStyleBackColor = true;
            // 
            // lblIconPageCount
            // 
            this.lblIconPageCount.AutoSize = true;
            this.lblIconPageCount.Location = new System.Drawing.Point(127, 63);
            this.lblIconPageCount.Name = "lblIconPageCount";
            this.lblIconPageCount.Size = new System.Drawing.Size(17, 20);
            this.lblIconPageCount.TabIndex = 21;
            this.lblIconPageCount.Text = "0";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(106, 63);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(15, 20);
            this.label87.TabIndex = 20;
            this.label87.Text = "/";
            // 
            // numIconPage
            // 
            this.numIconPage.Location = new System.Drawing.Point(8, 60);
            this.numIconPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numIconPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIconPage.Name = "numIconPage";
            this.numIconPage.Size = new System.Drawing.Size(91, 27);
            this.numIconPage.TabIndex = 19;
            this.numIconPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnIconLast
            // 
            this.btnIconLast.Location = new System.Drawing.Point(162, 99);
            this.btnIconLast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIconLast.Name = "btnIconLast";
            this.btnIconLast.Size = new System.Drawing.Size(39, 31);
            this.btnIconLast.TabIndex = 18;
            this.btnIconLast.Text = ">>";
            this.btnIconLast.UseVisualStyleBackColor = true;
            this.btnIconLast.Click += new System.EventHandler(this.btnIconLast_Click);
            // 
            // btnIconNext
            // 
            this.btnIconNext.Location = new System.Drawing.Point(117, 99);
            this.btnIconNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIconNext.Name = "btnIconNext";
            this.btnIconNext.Size = new System.Drawing.Size(39, 31);
            this.btnIconNext.TabIndex = 17;
            this.btnIconNext.Text = ">";
            this.btnIconNext.UseVisualStyleBackColor = true;
            this.btnIconNext.Click += new System.EventHandler(this.btnIconNext_Click);
            // 
            // btnIconPrevious
            // 
            this.btnIconPrevious.Location = new System.Drawing.Point(71, 99);
            this.btnIconPrevious.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIconPrevious.Name = "btnIconPrevious";
            this.btnIconPrevious.Size = new System.Drawing.Size(39, 31);
            this.btnIconPrevious.TabIndex = 16;
            this.btnIconPrevious.Text = "<";
            this.btnIconPrevious.UseVisualStyleBackColor = true;
            this.btnIconPrevious.Click += new System.EventHandler(this.btnIconPrevious_Click);
            // 
            // btnIconFirst
            // 
            this.btnIconFirst.Location = new System.Drawing.Point(25, 99);
            this.btnIconFirst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIconFirst.Name = "btnIconFirst";
            this.btnIconFirst.Size = new System.Drawing.Size(39, 31);
            this.btnIconFirst.TabIndex = 15;
            this.btnIconFirst.Text = "<<";
            this.btnIconFirst.UseVisualStyleBackColor = true;
            this.btnIconFirst.Click += new System.EventHandler(this.btnIconFirst_Click);
            // 
            // txtIconSearch
            // 
            this.txtIconSearch.Location = new System.Drawing.Point(7, 17);
            this.txtIconSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIconSearch.Name = "txtIconSearch";
            this.txtIconSearch.PlaceholderText = "Search by name...";
            this.txtIconSearch.Size = new System.Drawing.Size(220, 27);
            this.txtIconSearch.TabIndex = 14;
            // 
            // lblSelIcon
            // 
            this.lblSelIcon.AutoSize = true;
            this.lblSelIcon.Location = new System.Drawing.Point(963, 4);
            this.lblSelIcon.Name = "lblSelIcon";
            this.lblSelIcon.Size = new System.Drawing.Size(0, 20);
            this.lblSelIcon.TabIndex = 13;
            this.lblSelIcon.Visible = false;
            // 
            // lblActiveIcon
            // 
            this.lblActiveIcon.AutoSize = true;
            this.lblActiveIcon.Location = new System.Drawing.Point(522, 4);
            this.lblActiveIcon.Name = "lblActiveIcon";
            this.lblActiveIcon.Size = new System.Drawing.Size(0, 20);
            this.lblActiveIcon.TabIndex = 12;
            // 
            // lblCurIcon
            // 
            this.lblCurIcon.AutoSize = true;
            this.lblCurIcon.Location = new System.Drawing.Point(234, 4);
            this.lblCurIcon.Name = "lblCurIcon";
            this.lblCurIcon.Size = new System.Drawing.Size(0, 20);
            this.lblCurIcon.TabIndex = 11;
            // 
            // btnActiveIconUndo
            // 
            this.btnActiveIconUndo.Location = new System.Drawing.Point(522, 87);
            this.btnActiveIconUndo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActiveIconUndo.Name = "btnActiveIconUndo";
            this.btnActiveIconUndo.Size = new System.Drawing.Size(86, 31);
            this.btnActiveIconUndo.TabIndex = 10;
            this.btnActiveIconUndo.Text = "Undo";
            this.btnActiveIconUndo.UseVisualStyleBackColor = true;
            this.btnActiveIconUndo.Click += new System.EventHandler(this.btnActiveIconUndo_Click);
            // 
            // btnActiveIconChange
            // 
            this.btnActiveIconChange.Location = new System.Drawing.Point(522, 48);
            this.btnActiveIconChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActiveIconChange.Name = "btnActiveIconChange";
            this.btnActiveIconChange.Size = new System.Drawing.Size(86, 31);
            this.btnActiveIconChange.TabIndex = 9;
            this.btnActiveIconChange.Text = "Change";
            this.btnActiveIconChange.UseVisualStyleBackColor = true;
            this.btnActiveIconChange.Click += new System.EventHandler(this.btnActiveIconChange_Click);
            // 
            // btnCurIconUndo
            // 
            this.btnCurIconUndo.Location = new System.Drawing.Point(234, 87);
            this.btnCurIconUndo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCurIconUndo.Name = "btnCurIconUndo";
            this.btnCurIconUndo.Size = new System.Drawing.Size(86, 31);
            this.btnCurIconUndo.TabIndex = 8;
            this.btnCurIconUndo.Text = "Undo";
            this.btnCurIconUndo.UseVisualStyleBackColor = true;
            this.btnCurIconUndo.Click += new System.EventHandler(this.btnCurIconUndo_Click);
            // 
            // btnCurIconChange
            // 
            this.btnCurIconChange.Location = new System.Drawing.Point(234, 48);
            this.btnCurIconChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCurIconChange.Name = "btnCurIconChange";
            this.btnCurIconChange.Size = new System.Drawing.Size(86, 31);
            this.btnCurIconChange.TabIndex = 7;
            this.btnCurIconChange.Text = "Change";
            this.btnCurIconChange.UseVisualStyleBackColor = true;
            this.btnCurIconChange.Click += new System.EventHandler(this.btnCurIconChange_Click);
            // 
            // picSelectedIcon
            // 
            this.picSelectedIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSelectedIcon.Location = new System.Drawing.Point(894, 35);
            this.picSelectedIcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picSelectedIcon.Name = "picSelectedIcon";
            this.picSelectedIcon.Size = new System.Drawing.Size(101, 100);
            this.picSelectedIcon.TabIndex = 6;
            this.picSelectedIcon.TabStop = false;
            // 
            // picActiveIcon
            // 
            this.picActiveIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picActiveIcon.Location = new System.Drawing.Point(615, 35);
            this.picActiveIcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picActiveIcon.Name = "picActiveIcon";
            this.picActiveIcon.Size = new System.Drawing.Size(101, 100);
            this.picActiveIcon.TabIndex = 5;
            this.picActiveIcon.TabStop = false;
            // 
            // picCurIcon
            // 
            this.picCurIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCurIcon.Location = new System.Drawing.Point(325, 35);
            this.picCurIcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picCurIcon.Name = "picCurIcon";
            this.picCurIcon.Size = new System.Drawing.Size(101, 100);
            this.picCurIcon.TabIndex = 4;
            this.picCurIcon.TabStop = false;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(799, 24);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(98, 20);
            this.label86.TabIndex = 3;
            this.label86.Text = "Selected Icon";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(483, 24);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(134, 20);
            this.label85.TabIndex = 2;
            this.label85.Text = "Current Active Icon";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(234, 24);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(89, 20);
            this.label84.TabIndex = 1;
            this.label84.Text = "Current Icon";
            // 
            // lvIcons
            // 
            this.lvIcons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvIcons.Location = new System.Drawing.Point(7, 149);
            this.lvIcons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvIcons.MultiSelect = false;
            this.lvIcons.Name = "lvIcons";
            this.lvIcons.Size = new System.Drawing.Size(1124, 721);
            this.lvIcons.TabIndex = 0;
            this.lvIcons.TileSize = new System.Drawing.Size(40, 40);
            this.lvIcons.UseCompatibleStateImageBehavior = false;
            this.lvIcons.SelectedIndexChanged += new System.EventHandler(this.lvIcons_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(1361, 17);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 31);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Location = new System.Drawing.Point(1248, 16);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(107, 31);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // cmbIndexing
            // 
            this.cmbIndexing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIndexing.Items.AddRange(new object[] {
            "Range by ID",
            "Range by Index"});
            this.cmbIndexing.Location = new System.Drawing.Point(105, 139);
            this.cmbIndexing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbIndexing.MaxDropDownItems = 2;
            this.cmbIndexing.Name = "cmbIndexing";
            this.cmbIndexing.Size = new System.Drawing.Size(122, 28);
            this.cmbIndexing.TabIndex = 14;
            // 
            // lblCurrentSpellName
            // 
            this.lblCurrentSpellName.AutoSize = true;
            this.lblCurrentSpellName.Location = new System.Drawing.Point(330, 20);
            this.lblCurrentSpellName.Name = "lblCurrentSpellName";
            this.lblCurrentSpellName.Size = new System.Drawing.Size(0, 20);
            this.lblCurrentSpellName.TabIndex = 15;
            // 
            // numNewSpellID
            // 
            this.numNewSpellID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numNewSpellID.Location = new System.Drawing.Point(1104, 19);
            this.numNewSpellID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numNewSpellID.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numNewSpellID.Name = "numNewSpellID";
            this.numNewSpellID.Size = new System.Drawing.Size(126, 27);
            this.numNewSpellID.TabIndex = 26;
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(1003, 20);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(95, 20);
            this.label30.TabIndex = 27;
            this.label30.Text = "New Spell ID";
            // 
            // numIdSearch
            // 
            this.numIdSearch.Location = new System.Drawing.Point(90, 21);
            this.numIdSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numIdSearch.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numIdSearch.Name = "numIdSearch";
            this.numIdSearch.Size = new System.Drawing.Size(229, 27);
            this.numIdSearch.TabIndex = 44;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(14, 25);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(78, 20);
            this.label75.TabIndex = 45;
            this.label75.Text = "Specific Id";
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(888, 15);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(107, 31);
            this.btnCopy.TabIndex = 48;
            this.btnCopy.Text = "Copy Current";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnDeleteSpell
            // 
            this.btnDeleteSpell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteSpell.Location = new System.Drawing.Point(774, 15);
            this.btnDeleteSpell.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteSpell.Name = "btnDeleteSpell";
            this.btnDeleteSpell.Size = new System.Drawing.Size(107, 31);
            this.btnDeleteSpell.TabIndex = 49;
            this.btnDeleteSpell.Text = "Delete Current";
            this.btnDeleteSpell.UseVisualStyleBackColor = true;
            this.btnDeleteSpell.Click += new System.EventHandler(this.btnDeleteSpell_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 977);
            this.Controls.Add(this.btnDeleteSpell);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label75);
            this.Controls.Add(this.numIdSearch);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.numNewSpellID);
            this.Controls.Add(this.lblCurrentSpellName);
            this.Controls.Add(this.cmbIndexing);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabsSpellInfo);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numCurentMax);
            this.Controls.Add(this.numCurentMin);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.listSpells);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Spell Editor";
            ((System.ComponentModel.ISupportInitialize)(this.numCurentMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurentMax)).EndInit();
            this.tabsSpellInfo.ResumeLayout(false);
            this.tabBasicInfo.ResumeLayout(false);
            this.groupSpellInfo.ResumeLayout(false);
            this.groupSpellInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spellIdChanger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numModalNextSpell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStackAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFamilyFlags4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFamilyFlags3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFamilyFlags2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFamilyFlags1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabsPowerConfig.ResumeLayout(false);
            this.tabPower1.ResumeLayout(false);
            this.tabPower1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTypeMask)).EndInit();
            this.tabPower2.ResumeLayout(false);
            this.tabPower2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown20)).EndInit();
            this.tabPower3.ResumeLayout(false);
            this.tabPower3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOptionalCost3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown27)).EndInit();
            this.tabPower4.ResumeLayout(false);
            this.tabPower4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOptionalCost4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown34)).EndInit();
            this.groupCooldown.ResumeLayout(false);
            this.groupCooldown.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartCooldownTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChargeCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartRecCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCatUsesPerWeek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCatId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCatChargeCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCatCharges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCatCooldown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCooldown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCategory)).EndInit();
            this.tabBasicInfo2.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScalesFromItemLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxScalingLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinScalingLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShowFutureSpellPlayerConditionID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numContentTuningID)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxTargetLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxTargets)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitCaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayerCaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayerViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVisualPriority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVisualActiveIconId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVisualIconId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpellVisualId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVisualId)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRequiredAreaId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExTargetAura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExCasterAura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetAura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCasterAura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFacingCasterFlags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpellLevel)).EndInit();
            this.tabProcInfo.ResumeLayout(false);
            this.tabProcInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProcCharges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProcCooldown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProcChance)).EndInit();
            this.tabSpellEffects.ResumeLayout(false);
            this.tabsSpellEffects.ResumeLayout(false);
            this.tabEffect.ResumeLayout(false);
            this.tabEffect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEffTableID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChainTargets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScalingClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAuraDuration)).EndInit();
            this.tabAttributes.ResumeLayout(false);
            this.tabAttributes.PerformLayout();
            this.tabFlags.ResumeLayout(false);
            this.tabFlags.PerformLayout();
            this.tabFlags2.ResumeLayout(false);
            this.tabFlags2.PerformLayout();
            this.tabItems.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrencyCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrencyId)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numReagentCount8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReagent8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReagentCount7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReagent7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReagentCount6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReagent6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReagentCount5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReagent5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReagentCount4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReagent4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReagentCount3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReagent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReagentCount2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReagent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReagentCount1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReagent1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotem1)).EndInit();
            this.tabIcon.ResumeLayout(false);
            this.tabIcon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIconPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picActiveIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCurIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNewSpellID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listSpells;
        private Button btnFirst;
        private Button btnPrevious;
        private Button btnLast;
        private Button btnNext;
        private NumericUpDown numCurentMin;
        private NumericUpDown numCurentMax;
        private Label label1;
        private TextBox txtSearch;
        private TabControl tabsSpellInfo;
        private TabPage tabBasicInfo;
        private TabPage tabAttributes;
        private Button btnSave;
        private Button btnNew;
        private ComboBox cmbIndexing;
        private Label label2;
        private ListBox listAttr0;
        private ListBox listAttr2;
        private Label label4;
        private ListBox listAttr1;
        private Label label3;
        private ListBox listAttr3;
        private Label label5;
        private ListBox listAttr5;
        private Label label7;
        private ListBox listAttr4;
        private Label label6;
        private ListBox listAttr8;
        private Label label10;
        private ListBox listAttr7;
        private Label label9;
        private ListBox listAttr6;
        private Label label8;
        private ListBox listAttr14;
        private Label label16;
        private ListBox listAttr13;
        private Label label15;
        private ListBox listAttr12;
        private Label label14;
        private ListBox listAttr11;
        private Label label13;
        private ListBox listAttr10;
        private Label label12;
        private ListBox listAttr9;
        private Label label11;
        private TextBox txtSpellName;
        private Label label17;
        private TextBox txtAuraDesc;
        private Label label19;
        private TextBox txtSpellDesc;
        private Label label18;
        private TextBox txtSpellNameSubtext;
        private Label label20;
        private TabPage tabIcon;
        private ListView lvIcons;
        private Label lblCurrentSpellName;
        private GroupBox groupCooldown;
        private GroupBox groupSpellInfo;
        private Label label23;
        private Label label22;
        private Label label21;
        private NumericUpDown numCatCooldown;
        private NumericUpDown numCooldown;
        private NumericUpDown numCategory;
        private Label label24;
        private Button btnSaveCategory;
        private NumericUpDown numCatChargeCD;
        private Label label26;
        private NumericUpDown numCatCharges;
        private Label label25;
        private Label label27;
        private TextBox txtCatName;
        private NumericUpDown numCatId;
        private Label label28;
        private NumericUpDown numCatUsesPerWeek;
        private Label label29;
        private NumericUpDown numNewSpellID;
        private Label label30;
        private NumericUpDown numTypeMask;
        private Label label31;
        private Label label32;
        private ListBox listCatFlags;
        private NumericUpDown numStartRecCat;
        private Label label33;
        private ComboBox cmb;
        private ComboBox cmbDispelType;
        private ComboBox cmbMechanic;
        private ComboBox cmbPowerType1;
        private ComboBox cmbDamageType;
        private Label label37;
        private Label label36;
        private Label label35;
        private Label label34;
        private Label label38;
        private NumericUpDown numChargeCat;
        private Label label39;
        private NumericUpDown numFamilyFlags1;
        private Label label41;
        private Label label40;
        private ComboBox cmbSpellFamily;
        private NumericUpDown numFamilyFlags4;
        private Label label44;
        private NumericUpDown numFamilyFlags3;
        private Label label43;
        private NumericUpDown numFamilyFlags2;
        private Label label42;
        private Label label45;
        private ComboBox cmbDifficultyId;
        private TabPage tabProcInfo;
        private TabPage tabSpellEffects;
        private TabControl tabsSpellEffects;
        private TabPage tabEffect;
        private Button btnAddEffect;
        private Label lblBP;
        private ComboBox cmbSpellEffect;
        private Label lblSpellEffect;
        private Label label46;
        private TextBox txtRealPoints;
        private ComboBox cmbEffMechanic;
        private Label label47;
        private ComboBox cmbTargetA;
        private Label label48;
        private ComboBox cmbcmbTargetA;
        private Label label49;
        private ComboBox cmbTargetB;
        private ComboBox cmbRadiusMin;
        private Label label50;
        private ComboBox cmbRadiusMax;
        private Label label51;
        private ComboBox cmbApplyAura;
        private Label label52;
        private Label label53;
        private NumericUpDown numAuraDuration;
        private TextBox txtPointsPerResource;
        private Label label54;
        private TextBox txtVariance;
        private Label lblDS;
        private TextBox txtAmplitude;
        private Label label55;
        private TextBox txtChainAmplitude;
        private Label label56;
        private TextBox txtBonusCoefficient;
        private Label label57;
        private TextBox txtBonusCoefficientFromAP;
        private Label label58;
        private TextBox txtPositionFacing;
        private Label label59;
        private Label label60;
        private NumericUpDown numScalingClass;
        private TextBox txtScalingCoefficient;
        private Label label61;
        private TextBox txtResourceCoefficient;
        private Label label62;
        private ListBox listProcTargets;
        private Label label65;
        private ListBox listProcFlags2;
        private Label label64;
        private ListBox listProcFlags;
        private Label label63;
        private Label label66;
        private NumericUpDown numProcChance;
        private Label label68;
        private NumericUpDown numProcCooldown;
        private Label label69;
        private NumericUpDown numStackAmount;
        private Label label67;
        private NumericUpDown numProcCharges;
        private Label lblPPM;
        private Label label71;
        private Label label73;
        private ComboBox cmbCastTime;
        private Label label74;
        private MultiLineComboBox mlcmbDuration;
        private MultiLineComboBox mlcmbRange;
        private NumericUpDown numIdSearch;
        private Label label75;
        private Label label76;
        private NumericUpDown numChainTargets;
        private Label label77;
        private NumericUpDown numericUpDown1;
        private Label label79;
        private NumericUpDown numericUpDown3;
        private Label label78;
        private NumericUpDown numericUpDown2;
        private Label label83;
        private NumericUpDown numericUpDown7;
        private Label label82;
        private NumericUpDown numericUpDown6;
        private Label label81;
        private NumericUpDown numericUpDown5;
        private Label label80;
        private NumericUpDown numericUpDown4;
        private TabPage tabFlags;
        private Label label84;
        private Button btnActiveIconUndo;
        private Button btnActiveIconChange;
        private Button btnCurIconUndo;
        private Button btnCurIconChange;
        private PictureBox picSelectedIcon;
        private PictureBox picActiveIcon;
        private PictureBox picCurIcon;
        private Label label86;
        private Label label85;
        private Label lblActiveIcon;
        private Label lblCurIcon;
        private Label lblSelIcon;
        private TextBox txtIconSearch;
        private Button btnIconLast;
        private Button btnIconNext;
        private Button btnIconPrevious;
        private Button btnIconFirst;
        private Label lblIconPageCount;
        private Label label87;
        private NumericUpDown numIconPage;
        private GroupBox groupBox1;
        private TabControl tabsPowerConfig;
        private TabPage tabPower1;
        private TabPage tabPower2;
        private TabPage tabPower3;
        private TabPage tabPower4;
        private NumericUpDown numericUpDown9;
        private Label label89;
        private NumericUpDown numericUpDown8;
        private Label label88;
        private NumericUpDown numericUpDown11;
        private Label label91;
        private NumericUpDown numericUpDown10;
        private Label label90;
        private TextBox txtPwrCostMaxPct1;
        private Label label93;
        private TextBox txtPwrCost1;
        private Label label92;
        private NumericUpDown numericUpDown13;
        private Label label96;
        private NumericUpDown numericUpDown12;
        private Label label95;
        private TextBox txtPwrCostPerSec1;
        private Label label94;
        private NumericUpDown numericUpDown14;
        private Label label97;
        private NumericUpDown numericUpDown15;
        private Label label98;
        private TextBox txtPwrCostPerSec2;
        private Label label99;
        private TextBox txtPwrCostMaxPct2;
        private Label label100;
        private TextBox txtPwrCost2;
        private Label label101;
        private NumericUpDown numericUpDown16;
        private Label label102;
        private NumericUpDown numericUpDown17;
        private Label label103;
        private Label label104;
        private NumericUpDown numericUpDown18;
        private NumericUpDown numericUpDown19;
        private ComboBox cmbPowerType2;
        private NumericUpDown numericUpDown20;
        private NumericUpDown numericUpDown21;
        private Label label108;
        private NumericUpDown numOptionalCost3;
        private Label label109;
        private TextBox txtPwrCostPerSec3;
        private Label label110;
        private TextBox txtPwrCostMaxPct3;
        private Label label111;
        private TextBox txtPwrCost3;
        private Label label112;
        private NumericUpDown numericUpDown23;
        private Label label113;
        private NumericUpDown numericUpDown24;
        private Label label114;
        private Label label115;
        private NumericUpDown numericUpDown25;
        private NumericUpDown numericUpDown26;
        private ComboBox cmbPowerType3;
        private NumericUpDown numericUpDown27;
        private NumericUpDown numericUpDown28;
        private Label label119;
        private NumericUpDown numOptionalCost4;
        private Label label120;
        private TextBox txtPwrCostPerSec4;
        private Label label121;
        private TextBox txtPwrCostMaxPct4;
        private Label label122;
        private TextBox txtPwrCost4;
        private Label label123;
        private NumericUpDown numericUpDown30;
        private Label label124;
        private NumericUpDown numericUpDown31;
        private Label label125;
        private Label label126;
        private NumericUpDown numericUpDown32;
        private NumericUpDown numericUpDown33;
        private ComboBox cmbPowerType4;
        private NumericUpDown numericUpDown34;
        private Button btnCopy;
        private TabPage tabBasicInfo2;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Label label132;
        private NumericUpDown numMaxTargets;
        private Label label136;
        private NumericUpDown numMaxTargetLevel;
        private Label label135;
        private NumericUpDown numMaxLevel;
        private NumericUpDown numBaseLevel;
        private NumericUpDown numSpellLevel;
        private Label label134;
        private Label label133;
        private Label label138;
        private ComboBox cmbPreventionType;
        private Label label105;
        private Label label106;
        private Label label107;
        private Label label116;
        private Label label117;
        private Label label118;
        private Label label127;
        private Label label128;
        private Label label129;
        private TextBox txtSpeed;
        private Label label137;
        private Label label139;
        private ComboBox cmbTargetAuraState;
        private Label label72;
        private ComboBox cmbCasterAuraState;
        private ComboBox cmbVisualDifficulty;
        private Label label142;
        private NumericUpDown numVisualId;
        private Label label141;
        private ComboBox cmbSelectVisual;
        private Label label140;
        private Label label143;
        private ComboBox cmbSpellFocus;
        private Button btnVisualSave;
        private Button btnVisualCopy;
        private Button btnVisualNew;
        private NumericUpDown numSpellVisualId;
        private Label label144;
        private NumericUpDown numVisualActiveIconId;
        private Label label146;
        private NumericUpDown numVisualIconId;
        private Label label145;
        private TextBox txtVisualProbability;
        private Label label147;
        private NumericUpDown numVisualPriority;
        private Label label148;
        private NumericUpDown numPlayerViewer;
        private Label label149;
        private Label label150;
        private Label label151;
        private Label label152;
        private NumericUpDown numUnitViewer;
        private Label label153;
        private NumericUpDown numPlayerCaster;
        private Label label154;
        private NumericUpDown numUnitCaster;
        private Label label155;
        private Label label156;
        private ListBox listSpellSchool;
        private NumericUpDown numFacingCasterFlags;
        private Label label157;
        private ListBox listInterruptFlags;
        private Label label158;
        private ListBox listAuraInterruptFlags2;
        private Label label160;
        private ListBox listAuraInterruptFlags;
        private Label label159;
        private TabPage tabItems;
        private GroupBox groupBox4;
        private Label label166;
        private Label label165;
        private NumericUpDown numTotem2;
        private Label label164;
        private NumericUpDown numTotem1;
        private Label label163;
        private GroupBox groupBox5;
        private Label label181;
        private NumericUpDown numReagentCount8;
        private Label label182;
        private NumericUpDown numReagent8;
        private Label label179;
        private NumericUpDown numReagentCount7;
        private Label label180;
        private NumericUpDown numReagent7;
        private Label label177;
        private NumericUpDown numReagentCount6;
        private Label label178;
        private NumericUpDown numReagent6;
        private Label label175;
        private NumericUpDown numReagentCount5;
        private Label label176;
        private NumericUpDown numReagent5;
        private Label label173;
        private NumericUpDown numReagentCount4;
        private Label label174;
        private NumericUpDown numReagent4;
        private Label label171;
        private NumericUpDown numReagentCount3;
        private Label label172;
        private NumericUpDown numReagent3;
        private Label label169;
        private NumericUpDown numReagentCount2;
        private Label label170;
        private NumericUpDown numReagent2;
        private Label label168;
        private NumericUpDown numReagentCount1;
        private Label label167;
        private NumericUpDown numReagent1;
        private ComboBox cmbTotemCategory2;
        private ComboBox cmbTotemCategory1;
        private ComboBox cmbSelectCurrency;
        private Label label183;
        private Button btnVisualDelete;
        private GroupBox groupBox6;
        private Button btnCurrencyDelete;
        private Button btnCurrencySave;
        private Button btnCurrencyCopy;
        private Button btnCurrencyNew;
        private Label label186;
        private NumericUpDown numCurrencyCount;
        private Label label185;
        private NumericUpDown numCurrencyId;
        private Label label184;
        private ComboBox cmbCurrencyType;
        private GroupBox groupBox7;
        private ComboBox cmbEquippedItemClass;
        private Label label187;
        private ListBox listEquippedItemSubClass;
        private Label label189;
        private ListBox listEquippedItemInvenType;
        private Label label188;
        private NumericUpDown numExTargetAura;
        private Label label195;
        private NumericUpDown numExCasterAura;
        private Label label194;
        private NumericUpDown numTargetAura;
        private Label label193;
        private NumericUpDown numCasterAura;
        private Label label192;
        private Label label190;
        private ComboBox cmbExTargetAuraState;
        private Label label191;
        private ComboBox cmbExCasterAuraState;
        private NumericUpDown numRequiredAreaId;
        private Label label196;
        private NumericUpDown numModalNextSpell;
        private Label label197;
        private ListBox listChannelInterruptFlags2;
        private Label label198;
        private ListBox listChannelInterruptFlags;
        private Label label199;
        private TextBox txtLabels;
        private Label label200;
        private TabPage tabFlags2;
        private ListBox listExStances;
        private Label label162;
        private ListBox listStances;
        private Label label201;
        private GroupBox groupBox8;
        private ListBox listTargetCreatureType;
        private Label label161;
        private TextBox txtWidth;
        private Label label202;
        private TextBox txtConeAngle;
        private Label label203;
        private TextBox txtLaunchDelay;
        private Label label204;
        private NumericUpDown numStartCooldownTime;
        private Label label205;
        private GroupBox groupBox9;
        private NumericUpDown numContentTuningID;
        private Label label206;
        private NumericUpDown numShowFutureSpellPlayerConditionID;
        private Label label207;
        private NumericUpDown numScalesFromItemLevel;
        private Label label210;
        private NumericUpDown numMaxScalingLevel;
        private Label label209;
        private NumericUpDown numMinScalingLevel;
        private Label label208;
        private Label label211;
        private NumericUpDown numericUpDown22;
        private Label label212;
        private NumericUpDown numEffTableID;
        private MultiLineComboBox mlcmbEditCat;
        private Button btnDeleteSpell;
        private MultiLineComboBox mlcmbPPM;
        private NumericUpDown spellIdChanger;
        private TextBox txtBP;
    }
}