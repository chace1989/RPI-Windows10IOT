﻿#pragma checksum "D:\Upwork History\2017\01\RPI-ForkLift\Backup\20170128\IoTCoreDefaultApp\Views\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "015AEE9D84BCD53FCDAA28ED7BEFFC01"
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
    partial class MainPage : 
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
                    this.rootPage = (global::Windows.UI.Xaml.Controls.Page)(target);
                }
                break;
            case 2:
                {
                    this.NetworkInfoPanelTemplate = (global::Windows.UI.Xaml.Controls.ItemsPanelTemplate)(target);
                }
                break;
            case 3:
                {
                    this.NetworkInfoDataTemplate = (global::Windows.UI.Xaml.DataTemplate)(target);
                }
                break;
            case 4:
                {
                    this.HeaderRow = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 5:
                {
                    this.BoardName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.NavigetNextPage = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 7:
                {
                    this.CancelButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 179 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.CancelButton).Click += this.CancelButton_Clicked;
                    #line default
                }
                break;
            case 8:
                {
                    this.NextButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 180 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.NextButton).Click += this.NextButton_Clicked;
                    #line default
                }
                break;
            case 9:
                {
                    this.NavigetNextPageProgress = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 10:
                {
                    this.ConnectedDevices = (global::Windows.UI.Xaml.Controls.ItemsControl)(target);
                }
                break;
            case 11:
                {
                    this.DeviceName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.NetworkNameCaption = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.NetworkName1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    this.IPAddressCaption = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15:
                {
                    this.IPAddress1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16:
                {
                    this.OSVersionCaption = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17:
                {
                    this.OSVersion = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18:
                {
                    this.NetworkInfo = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 19:
                {
                    this.BoardImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 20:
                {
                    this.CurrentTime = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 21:
                {
                    this.SettingsButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 79 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SettingsButton).Click += this.SettingsButton_Clicked;
                    #line default
                }
                break;
            case 22:
                {
                    this.ShutdownButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 81 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ShutdownButton).Click += this.ShutdownButton_Clicked;
                    #line default
                }
                break;
            case 23:
                {
                    this.ShutdownDropdown = (global::Windows.UI.Xaml.Controls.Primitives.Popup)(target);
                    #line 83 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Primitives.Popup)this.ShutdownDropdown).Opened += this.ShutdownDropdown_Opened;
                    #line default
                }
                break;
            case 24:
                {
                    this.ShutdownListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 84 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.ShutdownListView).ItemClick += this.ShutdownListView_ItemClick;
                    #line default
                }
                break;
            case 25:
                {
                    this.RestartOption = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 26:
                {
                    this.ShutdownOption = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 27:
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

