﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-UOK2EOK\\SQLEXPRESS;Initial Catalog=QLThuVien;Persist Security" +
            " Info=True;User ID=sa;Password=qaz12345;TrustServerCertificate=True")]
        public string QLThuVienConnectionString {
            get {
                return ((string)(this["QLThuVienConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-UOK2EOK\\SQLEXPRESS;Initial Catalog=QLThuVien;Persist Security" +
            " Info=True;User ID=sa;Password=qaz12345;Encrypt=True;TrustServerCertificate=True" +
            "")]
        public string QLThuVienConnectionString1 {
            get {
                return ((string)(this["QLThuVienConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=./;Initial Catalog=QLThuVien;Persist Security Info=True;User ID=sa;Pa" +
            "ssword=123456;TrustServerCertificate=True")]
        public string QLThuVienConnectionString2 {
            get {
                return ((string)(this["QLThuVienConnectionString2"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=atho-intlaptop\\SQLEXPRESS;Initial Catalog=QLThuVien;Persist Security " +
            "Info=True;User ID=sa;Password=qaz12345;Encrypt=True;TrustServerCertificate=True")]
        public string QLThuVienConnectionString3 {
            get {
                return ((string)(this["QLThuVienConnectionString3"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=ADMINISTRATOR;Initial Catalog=QLThuVien;Persist Security Info=True;Us" +
            "er ID=sa;Password=123456")]
        public string QLThuVienConnectionString4 {
            get {
                return ((string)(this["QLThuVienConnectionString4"]));
            }
        }
    }
}
