﻿#pragma checksum "C:\Developing Windows 10 Universal Apps\Demos\xaml_xamluibasics\CS\AppUIBasics\ControlPages\RepeatButtonPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "97B4440F3A86F802A4189365367D8474"
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
    partial class RepeatButtonPage : 
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

        private class RepeatButtonPage_obj1_Bindings : 
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IRepeatButtonPage_Bindings
        {
            private global::AppUIBasics.ControlPages.RepeatButtonPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = -2;
            private const int DATA_CHANGED = -1;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Primitives.RepeatButton obj3;

            private RepeatButtonPage_obj1_BindingsTracking bindingsTracking;

            public RepeatButtonPage_obj1_Bindings()
            {
                this.bindingsTracking = new RepeatButtonPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3:
                        this.obj3 = (global::Windows.UI.Xaml.Controls.Primitives.RepeatButton)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::AppUIBasics.ControlPages.RepeatButtonPage data = args.NewValue as global::AppUIBasics.ControlPages.RepeatButtonPage;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::AppUIBasics.ControlPages.RepeatButtonPage was expected.");
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

            // IRepeatButtonPage_Bindings

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

            // RepeatButtonPage_obj1_Bindings

            public void SetDataRoot(global::AppUIBasics.ControlPages.RepeatButtonPage newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::AppUIBasics.ControlPages.RepeatButtonPage obj, int phase)
            {
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == DATA_CHANGED || phase == 0)
                    {
                        this.Update_DisableControl1(obj.DisableControl1, phase);
                    }
                }
            }
            private void Update_DisableControl1(global::Windows.UI.Xaml.Controls.CheckBox obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_DisableControl1(obj);
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == DATA_CHANGED || phase == 0)
                    {
                        this.Update_DisableControl1_IsChecked(obj.IsChecked, phase);
                    }
                }
            }
            private void Update_DisableControl1_IsChecked(global::System.Nullable<global::System.Boolean> obj, int phase)
            {
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == DATA_CHANGED || phase == 0)
                    {
                        this.Update_DisableControl1_IsChecked_Value(obj.Value, phase);
                    }
                }
            }
            private void Update_DisableControl1_IsChecked_Value(global::System.Boolean obj, int phase)
            {
                if (phase == NOT_PHASED || phase == DATA_CHANGED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj3, (global::System.Boolean)((global::Windows.UI.Xaml.Data.IValueConverter)global::Windows.UI.Xaml.Application.Current.Resources["negationConverter"]).Convert(obj, typeof(global::System.Boolean), null, null));
                }
            }

            private class RepeatButtonPage_obj1_BindingsTracking
            {
                global::System.WeakReference<RepeatButtonPage_obj1_Bindings> WeakRefToBindingObj; 

                public RepeatButtonPage_obj1_BindingsTracking(RepeatButtonPage_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<RepeatButtonPage_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_DisableControl1(null);
                }

                public void DependencyPropertyChanged_DisableControl1_IsChecked(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    RepeatButtonPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::Windows.UI.Xaml.Controls.CheckBox obj = sender as global::Windows.UI.Xaml.Controls.CheckBox;
        if (obj != null)
        {
            bindings.Update_DisableControl1_IsChecked(obj.IsChecked, DATA_CHANGED);
        }
                    }
                    else
                    {
                        ReleaseAllListeners();
                    }
                }
                private global::Windows.UI.Xaml.Controls.CheckBox cache_DisableControl1 = null;
                private long tokenDPC_DisableControl1_IsChecked = 0;
                public void UpdateChildListeners_DisableControl1(global::Windows.UI.Xaml.Controls.CheckBox obj)
                {
                    if (obj != cache_DisableControl1)
                    {
                        if (cache_DisableControl1 != null)
                        {
                            cache_DisableControl1.UnregisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.CheckBox.IsCheckedProperty, tokenDPC_DisableControl1_IsChecked);
                            cache_DisableControl1 = null;
                        }
                        if (obj != null)
                        {
                            tokenDPC_DisableControl1_IsChecked = obj.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.CheckBox.IsCheckedProperty, DependencyPropertyChanged_DisableControl1_IsChecked);
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
                    this.DisableControl1 = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 3:
                {
                    this.Control1 = (global::Windows.UI.Xaml.Controls.Primitives.RepeatButton)(target);
                    #line 24 "..\..\..\ControlPages\RepeatButtonPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Primitives.RepeatButton)this.Control1).Click += this.RepeatButton_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.Control1Output = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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
                    RepeatButtonPage_obj1_Bindings bindings = new RepeatButtonPage_obj1_Bindings();
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

