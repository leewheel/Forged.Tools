﻿using Forged.Tools.Shared.DataStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forged.Tools.Shared.Traits.DB2Records
{
    public sealed class TraitDefinitionRecord
    {
        public LocalizedString OverrideName;
        public LocalizedString OverrideSubtext;
        public LocalizedString OverrideDescription;
        public uint Id;
        public uint SpellID;
        public int OverrideIcon;
        public uint OverridesSpellID;
        public uint VisibleSpellID;
    }
}