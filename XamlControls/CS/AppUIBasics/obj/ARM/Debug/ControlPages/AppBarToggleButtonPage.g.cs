﻿#pragma checksum "C:\Developing Windows 10 Universal Apps\Demos\xaml_xamluibasics\CS\AppUIBasics\ControlPages\AppBarToggleButtonPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "55895BE1D6B4282CC0DDC4A5AFA2E05B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppUIBasics.ControlPages
{
    partial class AppBarToggleButtonPage : 
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
                    this.LeftColumn = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 2:
                {
                    this.RightColumn = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3:
                {
                    this.Example3 = (global::AppUIBasics.ControlPages.ControlExample)(target);
                }
                break;
            case 4:
                {
                    this.Example4 = (global::AppUIBasics.ControlPages.ControlExample)(target);
                }
                break;
            case 5:
                {
                    this.Button4 = (global::Windows.UI.Xaml.Controls.AppBarToggleButton)(target);
                    #line 92 "..\..\..\ControlPages\AppBarToggleButtonPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarToggleButton)this.Button4).Click += this.AppBarButton_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.Control4Output = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.Button3 = (global::Windows.UI.Xaml.Controls.AppBarToggleButton)(target);
                    #line 67 "..\..\..\ControlPages\AppBarToggleButtonPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarToggleButton)this.Button3).Click += this.AppBarButton_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.Control3Output = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.Example1 = (global::AppUIBasics.ControlPages.ControlExample)(target);
                }
                break;
            case 10:
                {
                    this.Example2 = (global::AppUIBasics.ControlPages.ControlExample)(target);
                }
                break;
            case 11:
                {
                    this.Button2 = (global::Windows.UI.Xaml.Controls.AppBarToggleButton)(target);
                    #line 42 "..\..\..\ControlPages\AppBarToggleButtonPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarToggleButton)this.Button2).Click += this.AppBarButton_Click;
                    #line default
                }
                break;
            case 12:
                {
                    this.Control2Output = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.Button1 = (global::Windows.UI.Xaml.Controls.AppBarToggleButton)(target);
                    #line 27 "..\..\..\ControlPages\AppBarToggleButtonPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarToggleButton)this.Button1).Click += this.AppBarButton_Click;
                    #line default
                }
                break;
            case 14:
                {
                    this.Control1Output = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15:
                {
                    this.WideLayout = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 16:
                {
                    this.NarrowLayout = (global::Windows.UI.Xaml.VisualState)(target);
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
