﻿#pragma checksum "C:\Developing Windows 10 Universal Apps\Demos\xaml_xamluibasics\CS\AppUIBasics\ControlPages\VariableSizedWrapGridPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "801F9434D4F0713F5C05F0687F5A674A"
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
    partial class VariableSizedWrapGridPage : 
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
                    this.ExampleAccessories = (global::AppUIBasics.ControlPages.ControlExample)(target);
                }
                break;
            case 3:
                {
                    this.OrientationGroup = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 4:
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element4 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 46 "..\..\..\ControlPages\VariableSizedWrapGridPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element4).Checked += this.RadioButton_Checked;
                    #line default
                }
                break;
            case 5:
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element5 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 47 "..\..\..\ControlPages\VariableSizedWrapGridPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element5).Checked += this.RadioButton_Checked;
                    #line default
                }
                break;
            case 6:
                {
                    this.Control1 = (global::Windows.UI.Xaml.Controls.VariableSizedWrapGrid)(target);
                }
                break;
            case 7:
                {
                    this.OrientationLabel = (global::Windows.UI.Xaml.Documents.Run)(target);
                }
                break;
            case 8:
                {
                    this.WideLayout = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 9:
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

