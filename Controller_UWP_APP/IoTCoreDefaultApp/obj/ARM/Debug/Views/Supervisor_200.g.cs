﻿#pragma checksum "D:\Upwork History\2017\01\RPI-ForkLift\Backup\20170128\IoTCoreDefaultApp\Views\Supervisor_200.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BF29DBCAB2F1F32EF4FECDCC33F42ED6"
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
    partial class Supervisor_200 : 
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
                    this.StatusTxt = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.NotifyTxt = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.ResetButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 80 "..\..\..\Views\Supervisor_200.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ResetButton).Click += this.ResetButton_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.LogoffButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 81 "..\..\..\Views\Supervisor_200.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.LogoffButton).Click += this.LogoffButton_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.ResetCnt = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.CurrentTime = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.ShutdownButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 9:
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

