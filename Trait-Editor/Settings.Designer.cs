﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Trait_Editor {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.4.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("hotfixes")]
        public string HotfixDatabaseName {
            get {
                return ((string)(this["HotfixDatabaseName"]));
            }
            set {
                this["HotfixDatabaseName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("127.0.0.1")]
        public string HotfixDatabaseHost {
            get {
                return ((string)(this["HotfixDatabaseHost"]));
            }
            set {
                this["HotfixDatabaseHost"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3306")]
        public string HotfixDatabasePort {
            get {
                return ((string)(this["HotfixDatabasePort"]));
            }
            set {
                this["HotfixDatabasePort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("root")]
        public string HotfixDatabaseUser {
            get {
                return ((string)(this["HotfixDatabaseUser"]));
            }
            set {
                this["HotfixDatabaseUser"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("root")]
        public string HotfixDatabasePassword {
            get {
                return ((string)(this["HotfixDatabasePassword"]));
            }
            set {
                this["HotfixDatabasePassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{FullTraitEditorPath}")]
        public string DB2ParentDir {
            get {
                return ((string)(this["DB2ParentDir"]));
            }
            set {
                this["DB2ParentDir"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2147483647")]
        public string BuildNumber {
            get {
                return ((string)(this["BuildNumber"]));
            }
            set {
                this["BuildNumber"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{FullTraitEditorPath}")]
        public string IconDir {
            get {
                return ((string)(this["IconDir"]));
            }
            set {
                this["IconDir"] = value;
            }
        }
    }
}
