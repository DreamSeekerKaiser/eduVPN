﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eduVPN.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.5.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// Cache of sequenced JSON responses
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Cache of sequenced JSON responses")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<JSONResponseDictionary/>")]
        public global::eduVPN.Xml.JSONResponseDictionary ResponseCache {
            get {
                return ((global::eduVPN.Xml.JSONResponseDictionary)(this["ResponseCache"]));
            }
            set {
                this["ResponseCache"] = value;
            }
        }
        
        /// <summary>
        /// Secure Internet settings
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Secure Internet settings")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<InstanceSourceSettings/>")]
        public global::eduVPN.Xml.InstanceSourceSettings SecureInternetInstanceSourceSettings {
            get {
                return ((global::eduVPN.Xml.InstanceSourceSettings)(this["SecureInternetInstanceSourceSettings"]));
            }
            set {
                this["SecureInternetInstanceSourceSettings"] = value;
            }
        }
        
        /// <summary>
        /// Secure Internet settings
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Secure Internet settings")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<InstanceSourceSettings/>")]
        public global::eduVPN.Xml.InstanceSourceSettings InstituteAccessInstanceSourceSettings {
            get {
                return ((global::eduVPN.Xml.InstanceSourceSettings)(this["InstituteAccessInstanceSourceSettings"]));
            }
            set {
                this["InstituteAccessInstanceSourceSettings"] = value;
            }
        }
        
        /// <summary>
        /// The last product version user was prompted to update to
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("The last product version user was prompted to update to")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SelfUpdateLastVersion {
            get {
                return ((string)(this["SelfUpdateLastVersion"]));
            }
            set {
                this["SelfUpdateLastVersion"] = value;
            }
        }
        
        /// <summary>
        /// The last time user was prompted to update at
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("The last time user was prompted to update at")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.DateTime SelfUpdateLastReminder {
            get {
                return ((global::System.DateTime)(this["SelfUpdateLastReminder"]));
            }
            set {
                this["SelfUpdateLastReminder"] = value;
            }
        }
        
        /// <summary>
        /// Which OpenVPN interactive service instance (named pipe) client should use to manipulate openvpn.exe process:
        /// - &quot;openvpn$eduVPN\service&quot; - Use OpenVPN installation bundled with eduVPN Client (default).
        /// - &quot;openvpn\service - Use original OpenVPN installation.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute(@"Which OpenVPN interactive service instance (named pipe) client should use to manipulate openvpn.exe process:
 - ""openvpn$eduVPN\service"" - Use OpenVPN installation bundled with eduVPN Client (default).
 - ""openvpn\service - Use original OpenVPN installation.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("openvpn$eduVPN\\service")]
        public string OpenVPNInteractiveServiceNamedPipe {
            get {
                return ((string)(this["OpenVPNInteractiveServiceNamedPipe"]));
            }
        }
        
        /// <summary>
        /// The client profile management mode is described in detail here: https://github.com/Amebis/eduVPN/blob/master/doc/ConnectingProfileSelectMode.md
        ///
        /// Note: It is recommended to delete client user settings in %LOCALAPPDATA%\SURF
        /// when the mode is changed.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("The client profile management mode is described in detail here: https://github.co" +
            "m/Amebis/eduVPN/blob/master/doc/ConnectingProfileSelectMode.md\r\n\r\n Note: It is r" +
            "ecommended to delete client user settings in %LOCALAPPDATA%\\SURF\r\n when the mode" +
            " is changed.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int ConnectingProfileSelectMode {
            get {
                return ((int)(this["ConnectingProfileSelectMode"]));
            }
        }
        
        /// <summary>
        /// Which TAP interface to use when connecting.
        /// Leave &quot;00000000-0000-0000-0000-000000000000&quot; for auto-selection by openvpn.exe.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Which TAP interface to use when connecting.\r\n Leave \"00000000-0000-0000-0000-0000" +
            "00000000\" for auto-selection by openvpn.exe.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00000000-0000-0000-0000-000000000000")]
        public global::System.Guid OpenVPNInterfaceID {
            get {
                return ((global::System.Guid)(this["OpenVPNInterfaceID"]));
            }
            set {
                this["OpenVPNInterfaceID"] = value;
            }
        }
        
        /// <summary>
        /// Always connect using TCP.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Always connect using TCP.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool OpenVPNForceTCP {
            get {
                return ((bool)(this["OpenVPNForceTCP"]));
            }
            set {
                this["OpenVPNForceTCP"] = value;
            }
        }
        
        /// <summary>
        /// Access token cache
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Access token cache")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<AccessTokenDictionary/>")]
        public global::eduVPN.Xml.AccessTokenDictionary AccessTokenCache {
            get {
                return ((global::eduVPN.Xml.AccessTokenDictionary)(this["AccessTokenCache"]));
            }
            set {
                this["AccessTokenCache"] = value;
            }
        }
        
        /// <summary>
        /// Instance-specific user settings
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Instance-specific user settings")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<InstanceSettingsDictionary/>")]
        public global::eduVPN.Xml.InstanceSettingsDictionary InstanceSettings {
            get {
                return ((global::eduVPN.Xml.InstanceSettingsDictionary)(this["InstanceSettings"]));
            }
            set {
                this["InstanceSettings"] = value;
            }
        }
        
        /// <summary>
        /// A flag to trigger setting upgrade from the previous version
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("A flag to trigger setting upgrade from the previous version")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int SettingsVersion {
            get {
                return ((int)(this["SettingsVersion"]));
            }
            set {
                this["SettingsVersion"] = value;
            }
        }
    }
}
