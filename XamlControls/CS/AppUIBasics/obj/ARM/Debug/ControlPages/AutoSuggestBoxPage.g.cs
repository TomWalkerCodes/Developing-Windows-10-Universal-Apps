﻿#pragma checksum "C:\Developing Windows 10 Universal Apps\Demos\xaml_xamluibasics\CS\AppUIBasics\ControlPages\AutoSuggestBoxPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "251CB3B7C2593D989B55D2412200C4CE"
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
    partial class AutoSuggestBoxPage : 
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
                    this.pageRoot = (global::Windows.UI.Xaml.Controls.Page)(target);
                }
                break;
            case 2:
                {
                    this.Example1 = (global::AppUIBasics.ControlPages.ControlExample)(target);
                }
                break;
            case 3:
                {
                    this.Example2 = (global::AppUIBasics.ControlPages.ControlExample)(target);
                }
                break;
            case 4:
                {
                    this.Control2 = (global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target);
                    #line 37 "..\..\..\ControlPages\AutoSuggestBoxPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.Control2).TextChanged += this.Control2_TextChanged;
                    #line 39 "..\..\..\ControlPages\AutoSuggestBoxPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.Control2).QuerySubmitted += this.Control2_QuerySubmitted;
                    #line 40 "..\..\..\ControlPages\AutoSuggestBoxPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.Control2).SuggestionChosen += this.Control2_SuggestionChosen;
                    #line default
                }
                break;
            case 5:
                {
                    this.ControlDetails = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 6:
                {
                    this.ControlImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 7:
                {
                    this.ControlTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.ControlSubtitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.Control1 = (global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target);
                    #line 14 "..\..\..\ControlPages\AutoSuggestBoxPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.Control1).TextChanged += this.AutoSuggestBox_TextChanged;
                    #line 15 "..\..\..\ControlPages\AutoSuggestBoxPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.Control1).SuggestionChosen += this.AutoSuggestBox_SuggestionChosen;
                    #line default
                }
                break;
            case 10:
                {
                    this.SuggestionOutput = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.WideLayout = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 12:
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

