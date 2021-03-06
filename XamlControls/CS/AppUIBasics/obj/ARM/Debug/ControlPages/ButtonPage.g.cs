﻿#pragma checksum "C:\Developing Windows 10 Universal Apps\Demos\xaml_xamluibasics\CS\AppUIBasics\ControlPages\ButtonPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3C8FF895DABC7BA5EF37D833427C9821"
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
    partial class ButtonPage : 
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
                  
            public static void Set_Windows_UI_Xaml_Controls_Control_IsEnabled(global::Windows.UI.Xaml.Controls.Control obj, global::System.Boolean value)
                {
                    obj.IsEnabled = value;
                }
        };

        private class ButtonPage_obj1_Bindings : 
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IButtonPage_Bindings
        {
            private global::AppUIBasics.ControlPages.ButtonPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = -2;
            private const int DATA_CHANGED = -1;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Button obj15;

            private ButtonPage_obj1_BindingsTracking bindingsTracking;

            public ButtonPage_obj1_Bindings()
            {
                this.bindingsTracking = new ButtonPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 15:
                        this.obj15 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::AppUIBasics.ControlPages.ButtonPage data = args.NewValue as global::AppUIBasics.ControlPages.ButtonPage;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::AppUIBasics.ControlPages.ButtonPage was expected.");
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

            // IButtonPage_Bindings

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

            // ButtonPage_obj1_Bindings

            public void SetDataRoot(global::AppUIBasics.ControlPages.ButtonPage newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::AppUIBasics.ControlPages.ButtonPage obj, int phase)
            {
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == DATA_CHANGED || phase == 0)
                    {
                        this.Update_DisableButton1(obj.DisableButton1, phase);
                    }
                }
            }
            private void Update_DisableButton1(global::Windows.UI.Xaml.Controls.CheckBox obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_DisableButton1(obj);
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == DATA_CHANGED || phase == 0)
                    {
                        this.Update_DisableButton1_IsChecked(obj.IsChecked, phase);
                    }
                }
            }
            private void Update_DisableButton1_IsChecked(global::System.Nullable<global::System.Boolean> obj, int phase)
            {
                if (phase == NOT_PHASED || phase == DATA_CHANGED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj15, (global::System.Boolean)((global::Windows.UI.Xaml.Data.IValueConverter)global::Windows.UI.Xaml.Application.Current.Resources["negationConverter"]).Convert(obj, typeof(global::System.Boolean), null, null));
                }
            }

            private class ButtonPage_obj1_BindingsTracking
            {
                global::System.WeakReference<ButtonPage_obj1_Bindings> WeakRefToBindingObj; 

                public ButtonPage_obj1_BindingsTracking(ButtonPage_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<ButtonPage_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_DisableButton1(null);
                }

                public void DependencyPropertyChanged_DisableButton1_IsChecked(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    ButtonPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::Windows.UI.Xaml.Controls.CheckBox obj = sender as global::Windows.UI.Xaml.Controls.CheckBox;
        if (obj != null)
        {
            bindings.Update_DisableButton1_IsChecked(obj.IsChecked, DATA_CHANGED);
        }
                    }
                    else
                    {
                        ReleaseAllListeners();
                    }
                }
                private global::Windows.UI.Xaml.Controls.CheckBox cache_DisableButton1 = null;
                private long tokenDPC_DisableButton1_IsChecked = 0;
                public void UpdateChildListeners_DisableButton1(global::Windows.UI.Xaml.Controls.CheckBox obj)
                {
                    if (obj != cache_DisableButton1)
                    {
                        if (cache_DisableButton1 != null)
                        {
                            cache_DisableButton1.UnregisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.CheckBox.IsCheckedProperty, tokenDPC_DisableButton1_IsChecked);
                            cache_DisableButton1 = null;
                        }
                        if (obj != null)
                        {
                            tokenDPC_DisableButton1_IsChecked = obj.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.CheckBox.IsCheckedProperty, DependencyPropertyChanged_DisableButton1_IsChecked);
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
                    this.LeftColumn = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3:
                {
                    this.RightColumn = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 4:
                {
                    this.Example3 = (global::AppUIBasics.ControlPages.ControlExample)(target);
                }
                break;
            case 5:
                {
                    this.Example4 = (global::AppUIBasics.ControlPages.ControlExample)(target);
                }
                break;
            case 6:
                {
                    this.Button4 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 164 "..\..\..\ControlPages\ButtonPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Button4).Click += this.Button_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.Control4Output = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.Button3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 147 "..\..\..\ControlPages\ButtonPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Button3).Click += this.Button_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.Control3Output = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.Example1 = (global::AppUIBasics.ControlPages.ControlExample)(target);
                }
                break;
            case 11:
                {
                    this.Example2 = (global::AppUIBasics.ControlPages.ControlExample)(target);
                }
                break;
            case 12:
                {
                    this.Button2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 125 "..\..\..\ControlPages\ButtonPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Button2).Click += this.Button_Click;
                    #line default
                }
                break;
            case 13:
                {
                    this.Control2Output = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    this.DisableButton1 = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 15:
                {
                    this.Button1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 111 "..\..\..\ControlPages\ButtonPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Button1).Click += this.Button_Click;
                    #line default
                }
                break;
            case 16:
                {
                    this.Control1Output = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17:
                {
                    this.WideLayout = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 18:
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
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    ButtonPage_obj1_Bindings bindings = new ButtonPage_obj1_Bindings();
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

