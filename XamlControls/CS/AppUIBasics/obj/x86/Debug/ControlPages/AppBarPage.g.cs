﻿#pragma checksum "C:\Developing Windows 10 Universal Apps\Demos\xaml_xamluibasics\CS\AppUIBasics\ControlPages\AppBarPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A4F0A1A5F9836D7C6530908CB09E5650"
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
    partial class AppBarPage : 
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
                    this.topAppBar = (global::Windows.UI.Xaml.Controls.AppBar)(target);
                    #line 22 "..\..\..\ControlPages\AppBarPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBar)this.topAppBar).Opened += this.topAppBar_Opened;
                    #line default
                }
                break;
            case 2:
                {
                    this.AppBarContentPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3:
                {
                    global::Windows.UI.Xaml.Controls.Button element3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 39 "..\..\..\ControlPages\AppBarPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element3).Click += this.NavBarButton_Click;
                    #line default
                }
                break;
            case 4:
                {
                    global::Windows.UI.Xaml.Controls.Button element4 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 40 "..\..\..\ControlPages\AppBarPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element4).Click += this.NavBarButton_Click;
                    #line default
                }
                break;
            case 5:
                {
                    global::Windows.UI.Xaml.Controls.Button element5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 41 "..\..\..\ControlPages\AppBarPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element5).Click += this.NavBarButton_Click;
                    #line default
                }
                break;
            case 6:
                {
                    global::Windows.UI.Xaml.Controls.Button element6 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 42 "..\..\..\ControlPages\AppBarPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element6).Click += this.NavBarButton_Click;
                    #line default
                }
                break;
            case 7:
                {
                    global::Windows.UI.Xaml.Controls.Button element7 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 43 "..\..\..\ControlPages\AppBarPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element7).Click += this.NavBarButton_Click;
                    #line default
                }
                break;
            case 8:
                {
                    global::Windows.UI.Xaml.Controls.Button element8 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 44 "..\..\..\ControlPages\AppBarPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element8).Click += this.NavBarButton_Click;
                    #line default
                }
                break;
            case 9:
                {
                    global::Windows.UI.Xaml.Controls.Button element9 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 45 "..\..\..\ControlPages\AppBarPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element9).Click += this.NavBarButton_Click;
                    #line default
                }
                break;
            case 10:
                {
                    global::Windows.UI.Xaml.Controls.Button element10 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 46 "..\..\..\ControlPages\AppBarPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element10).Click += this.NavBarButton_Click;
                    #line default
                }
                break;
            case 11:
                {
                    this.Example1 = (global::AppUIBasics.ControlPages.ControlExample)(target);
                }
                break;
            case 12:
                {
                    global::Windows.UI.Xaml.Controls.Button element12 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 65 "..\..\..\ControlPages\AppBarPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element12).Click += this.AddButton_Click;
                    #line default
                }
                break;
            case 13:
                {
                    global::Windows.UI.Xaml.Controls.Button element13 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 66 "..\..\..\ControlPages\AppBarPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element13).Click += this.RemoveButton_Click;
                    #line default
                }
                break;
            case 14:
                {
                    global::Windows.UI.Xaml.Controls.Button element14 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 56 "..\..\..\ControlPages\AppBarPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element14).Click += this.OpenButton_Click;
                    #line default
                }
                break;
            case 15:
                {
                    global::Windows.UI.Xaml.Controls.Button element15 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 57 "..\..\..\ControlPages\AppBarPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element15).Click += this.CloseButton_Click;
                    #line default
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

