﻿#pragma checksum "C:\Developing Windows 10 Universal Apps\Demos\xaml_xamluibasics\CS\AppUIBasics\ControlPages\CheckBoxPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3153331D9E1A5DDCC589E024FD3B45CD"
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
    partial class CheckBoxPage : 
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
                    this.Example1 = (global::AppUIBasics.ControlPages.ControlExample)(target);
                }
                break;
            case 2:
                {
                    this.Example2 = (global::AppUIBasics.ControlPages.ControlExample)(target);
                }
                break;
            case 3:
                {
                    this.Example3 = (global::AppUIBasics.ControlPages.ControlExample)(target);
                }
                break;
            case 4:
                {
                    this.OptionsAllCheckBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 56 "..\..\..\ControlPages\CheckBoxPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.OptionsAllCheckBox).Checked += this.SelectAll_Checked;
                    #line 56 "..\..\..\ControlPages\CheckBoxPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.OptionsAllCheckBox).Unchecked += this.SelectAll_Unchecked;
                    #line 56 "..\..\..\ControlPages\CheckBoxPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.OptionsAllCheckBox).Indeterminate += this.SelectAll_Indeterminate;
                    #line default
                }
                break;
            case 5:
                {
                    this.Option1CheckBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 57 "..\..\..\ControlPages\CheckBoxPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.Option1CheckBox).Checked += this.Option_Checked;
                    #line 57 "..\..\..\ControlPages\CheckBoxPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.Option1CheckBox).Unchecked += this.Option_Unchecked;
                    #line default
                }
                break;
            case 6:
                {
                    this.Option2CheckBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 58 "..\..\..\ControlPages\CheckBoxPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.Option2CheckBox).Checked += this.Option_Checked;
                    #line 58 "..\..\..\ControlPages\CheckBoxPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.Option2CheckBox).Unchecked += this.Option_Unchecked;
                    #line default
                }
                break;
            case 7:
                {
                    this.Option3CheckBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 59 "..\..\..\ControlPages\CheckBoxPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.Option3CheckBox).Checked += this.Option_Checked;
                    #line 59 "..\..\..\ControlPages\CheckBoxPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.Option3CheckBox).Unchecked += this.Option_Unchecked;
                    #line default
                }
                break;
            case 8:
                {
                    global::Windows.UI.Xaml.Controls.CheckBox element8 = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 41 "..\..\..\ControlPages\CheckBoxPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)element8).Indeterminate += this.Control2_Indeterminate;
                    #line 41 "..\..\..\ControlPages\CheckBoxPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)element8).Checked += this.Control2_Checked;
                    #line 41 "..\..\..\ControlPages\CheckBoxPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)element8).Unchecked += this.Control2_Unchecked;
                    #line default
                }
                break;
            case 9:
                {
                    this.Control2Output = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    global::Windows.UI.Xaml.Controls.CheckBox element10 = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 26 "..\..\..\ControlPages\CheckBoxPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)element10).Checked += this.Control1_Checked;
                    #line 26 "..\..\..\ControlPages\CheckBoxPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)element10).Unchecked += this.Control1_Unchecked;
                    #line default
                }
                break;
            case 11:
                {
                    this.Control1Output = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.WideLayout = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 13:
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
