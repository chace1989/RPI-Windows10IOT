﻿#pragma checksum "D:\Upwork History\2017\01\RPI-ForkLift\Backup\20170128\IoTCoreDefaultApp\Views\SwitchTilt_320.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "16963AF59D9B164B006A15D401752672"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IoTCoreDefaultApp
{
    partial class SwitchTilt_320 : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.HeaderRow = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.Tilt_Toggle = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    #line 53 "..\..\..\Views\SwitchTilt_320.xaml"
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.Tilt_Toggle).Toggled += this.Tilt_Toggle_Toggled;
                    #line default
                }
                break;
            case 3:
                {
                    this.Back = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 54 "..\..\..\Views\SwitchTilt_320.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Back).Click += this.Back_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.CurrentTime = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.ShutdownButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 6:
                {
                    this.LogoImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

