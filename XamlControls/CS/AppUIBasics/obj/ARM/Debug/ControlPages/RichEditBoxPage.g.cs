﻿#pragma checksum "C:\Developing Windows 10 Universal Apps\Demos\xaml_xamluibasics\CS\AppUIBasics\ControlPages\RichEditBoxPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5CF7954E9E216D11D6B6B5767EAE6A48"
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
    partial class RichEditBoxPage : 
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
                    this.openFileButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 28 "..\..\..\ControlPages\RichEditBoxPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.openFileButton).Click += this.OpenButton_Click;
                    #line default
                }
                break;
            case 2:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element2 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 29 "..\..\..\ControlPages\RichEditBoxPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element2).Click += this.SaveButton_Click;
                    #line default
                }
                break;
            case 3:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element3 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 31 "..\..\..\ControlPages\RichEditBoxPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element3).Click += this.BoldButton_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.italicButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 32 "..\..\..\ControlPages\RichEditBoxPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.italicButton).Click += this.ItalicButton_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.fontColorButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 6:
                {
                    this.editor = (global::Windows.UI.Xaml.Controls.RichEditBox)(target);
                }
                break;
            case 7:
                {
                    this.black = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 52 "..\..\..\ControlPages\RichEditBoxPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.black).Click += this.ColorButton_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.gray = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 57 "..\..\..\ControlPages\RichEditBoxPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.gray).Click += this.ColorButton_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.greenyellow = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 62 "..\..\..\ControlPages\RichEditBoxPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.greenyellow).Click += this.ColorButton_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.green = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 67 "..\..\..\ControlPages\RichEditBoxPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.green).Click += this.ColorButton_Click;
                    #line default
                }
                break;
            case 11:
                {
                    this.blue = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 72 "..\..\..\ControlPages\RichEditBoxPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.blue).Click += this.ColorButton_Click;
                    #line default
                }
                break;
            case 12:
                {
                    this.red = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 77 "..\..\..\ControlPages\RichEditBoxPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.red).Click += this.ColorButton_Click;
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
