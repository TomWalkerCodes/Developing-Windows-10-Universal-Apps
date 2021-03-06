﻿#pragma checksum "C:\Developing Windows 10 Universal Apps\Demos\xaml_xamluibasics\CS\AppUIBasics\ControlPages\FlyoutPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "ED77ED9461E545B3C6AEA0B473CC501F"
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
    partial class FlyoutPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            static bool shouldUpdate(int expectedPhase, int currentPhase)
            {
                return (currentPhase == -1 || currentPhase == expectedPhase);
            }
                  
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
                {
                    if (value == null && targetNullValue != null)
                    {
                            value = targetNullValue;
                    }
                    obj.Text = value;
                }
        };

        private class FlyoutPage_obj1_Bindings : 
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IFlyoutPage_Bindings
        {
            private global::AppUIBasics.ControlPages.FlyoutPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = -2;
            private const int DATA_CHANGED = -1;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj6;

            private FlyoutPage_obj1_BindingsTracking bindingsTracking;

            public FlyoutPage_obj1_Bindings()
            {
                this.bindingsTracking = new FlyoutPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 6:
                        this.obj6 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::AppUIBasics.ControlPages.FlyoutPage data = args.NewValue as global::AppUIBasics.ControlPages.FlyoutPage;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::AppUIBasics.ControlPages.FlyoutPage was expected.");
                 }
                 this.SetDataRoot(data);
                 this.Update();
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                return nextPhase;
            }

            public void ResetTemplate()
            {
                this.bindingsTracking.ReleaseAllListeners();
            }

            // IFlyoutPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
            }

            // FlyoutPage_obj1_Bindings

            public void SetDataRoot(global::AppUIBasics.ControlPages.FlyoutPage newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::AppUIBasics.ControlPages.FlyoutPage obj, int phase)
            {
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == DATA_CHANGED || phase == 0)
                    {
                        this.Update_MyTextBox(obj.MyTextBox, phase);
                    }
                }
            }
            private void Update_MyTextBox(global::Windows.UI.Xaml.Controls.TextBox obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_MyTextBox(obj);
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == DATA_CHANGED || phase == 0)
                    {
                        this.Update_MyTextBox_Text(obj.Text, phase);
                    }
                }
            }
            private void Update_MyTextBox_Text(global::System.String obj, int phase)
            {
                if (phase == NOT_PHASED || phase == DATA_CHANGED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj6, obj, null);
                }
            }

            private class FlyoutPage_obj1_BindingsTracking
            {
                global::System.WeakReference<FlyoutPage_obj1_Bindings> WeakRefToBindingObj; 

                public FlyoutPage_obj1_BindingsTracking(FlyoutPage_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<FlyoutPage_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_MyTextBox(null);
                }

                public void DependencyPropertyChanged_MyTextBox_Text(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    FlyoutPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::Windows.UI.Xaml.Controls.TextBox obj = sender as global::Windows.UI.Xaml.Controls.TextBox;
        if (obj != null)
        {
            bindings.Update_MyTextBox_Text(obj.Text, DATA_CHANGED);
        }
                    }
                    else
                    {
                        ReleaseAllListeners();
                    }
                }
                private global::Windows.UI.Xaml.Controls.TextBox cache_MyTextBox = null;
                private long tokenDPC_MyTextBox_Text = 0;
                public void UpdateChildListeners_MyTextBox(global::Windows.UI.Xaml.Controls.TextBox obj)
                {
                    if (obj != cache_MyTextBox)
                    {
                        if (cache_MyTextBox != null)
                        {
                            cache_MyTextBox.UnregisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.TextBox.TextProperty, tokenDPC_MyTextBox_Text);
                            cache_MyTextBox = null;
                        }
                        if (obj != null)
                        {
                            tokenDPC_MyTextBox_Text = obj.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.TextBox.TextProperty, DependencyPropertyChanged_MyTextBox_Text);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
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
                    this.Example3 = (global::AppUIBasics.ControlPages.ControlExample)(target);
                }
                break;
            case 5:
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element5 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 86 "..\..\..\ControlPages\FlyoutPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element5).Tapped += this.Element_Tapped;
                    #line default
                }
                break;
            case 6:
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element6 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 61 "..\..\..\ControlPages\FlyoutPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element6).Tapped += this.Element_Tapped;
                    #line default
                }
                break;
            case 7:
                {
                    this.MyTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8:
                {
                    this.Control1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 9:
                {
                    global::Windows.UI.Xaml.Controls.Button element9 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 37 "..\..\..\ControlPages\FlyoutPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element9).Click += this.DeleteConfirmation_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.WideLayout = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 11:
                {
                    this.Below768Layout = (global::Windows.UI.Xaml.VisualState)(target);
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
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    FlyoutPage_obj1_Bindings bindings = new FlyoutPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);                
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

