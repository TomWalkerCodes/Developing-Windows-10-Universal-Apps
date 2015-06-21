﻿#pragma checksum "C:\Developing Windows 10 Universal Apps\Demos\xaml_xamluibasics\CS\AppUIBasics\ControlPages\ListBoxPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A72A47158ECC6D4A5E152EEC588DA4FE"
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
    partial class ListBoxPage : 
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
                  
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
                {
                    if (value == null && targetNullValue != null)
                    {
                        value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                    }
                    obj.ItemsSource = value;
                }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_FontFamily(global::Windows.UI.Xaml.Controls.TextBlock obj, global::Windows.UI.Xaml.Media.FontFamily value, string targetNullValue)
                {
                    if (value == null && targetNullValue != null)
                    {
                        value = (global::Windows.UI.Xaml.Media.FontFamily) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.FontFamily), targetNullValue);
                    }
                    obj.FontFamily = value;
                }
        };

        private class ListBoxPage_obj1_Bindings : 
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IListBoxPage_Bindings
        {
            private global::AppUIBasics.ControlPages.ListBoxPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = -2;
            private const int DATA_CHANGED = -1;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ListBox obj4;
            private global::Windows.UI.Xaml.Controls.TextBlock obj5;

            private ListBoxPage_obj1_BindingsTracking bindingsTracking;

            public ListBoxPage_obj1_Bindings()
            {
                this.bindingsTracking = new ListBoxPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 4:
                        this.obj4 = (global::Windows.UI.Xaml.Controls.ListBox)target;
                        break;
                    case 5:
                        this.obj5 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::AppUIBasics.ControlPages.ListBoxPage data = args.NewValue as global::AppUIBasics.ControlPages.ListBoxPage;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::AppUIBasics.ControlPages.ListBoxPage was expected.");
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

            // IListBoxPage_Bindings

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

            // ListBoxPage_obj1_Bindings

            public void SetDataRoot(global::AppUIBasics.ControlPages.ListBoxPage newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::AppUIBasics.ControlPages.ListBoxPage obj, int phase)
            {
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == 0)
                    {
                        this.Update_Fonts(obj.Fonts, phase);
                    }
                    if (phase == NOT_PHASED || phase == DATA_CHANGED || phase == 0)
                    {
                        this.Update_ListBox2(obj.ListBox2, phase);
                    }
                }
            }
            private void Update_Fonts(global::System.Collections.Generic.List<global::System.Tuple<global::System.String, global::Windows.UI.Xaml.Media.FontFamily>> obj, int phase)
            {
                if (phase == NOT_PHASED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj4, obj, null);
                }
            }
            private void Update_ListBox2(global::Windows.UI.Xaml.Controls.ListBox obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ListBox2(obj);
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == DATA_CHANGED || phase == 0)
                    {
                        this.Update_ListBox2_SelectedValue(obj.SelectedValue, phase);
                    }
                }
            }
            private void Update_ListBox2_SelectedValue(global::System.Object obj, int phase)
            {
                if (phase == NOT_PHASED || phase == DATA_CHANGED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_FontFamily(this.obj5, (global::Windows.UI.Xaml.Media.FontFamily)((global::Windows.UI.Xaml.Data.IValueConverter)global::Windows.UI.Xaml.Application.Current.Resources["valueToFontFamilyConverter"]).Convert(obj, typeof(global::Windows.UI.Xaml.Media.FontFamily), null, null), null);
                }
            }

            private class ListBoxPage_obj1_BindingsTracking
            {
                global::System.WeakReference<ListBoxPage_obj1_Bindings> WeakRefToBindingObj; 

                public ListBoxPage_obj1_BindingsTracking(ListBoxPage_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<ListBoxPage_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ListBox2(null);
                }

                public void DependencyPropertyChanged_ListBox2_SelectedValue(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    ListBoxPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::Windows.UI.Xaml.Controls.ListBox obj = sender as global::Windows.UI.Xaml.Controls.ListBox;
        if (obj != null)
        {
            bindings.Update_ListBox2_SelectedValue(obj.SelectedValue, DATA_CHANGED);
        }
                    }
                    else
                    {
                        ReleaseAllListeners();
                    }
                }
                private global::Windows.UI.Xaml.Controls.ListBox cache_ListBox2 = null;
                private long tokenDPC_ListBox2_SelectedValue = 0;
                public void UpdateChildListeners_ListBox2(global::Windows.UI.Xaml.Controls.ListBox obj)
                {
                    if (obj != cache_ListBox2)
                    {
                        if (cache_ListBox2 != null)
                        {
                            cache_ListBox2.UnregisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.ListBox.SelectedValueProperty, tokenDPC_ListBox2_SelectedValue);
                            cache_ListBox2 = null;
                        }
                        if (obj != null)
                        {
                            tokenDPC_ListBox2_SelectedValue = obj.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.ListBox.SelectedValueProperty, DependencyPropertyChanged_ListBox2_SelectedValue);
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
                    this.ListBox2 = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    #line 51 "..\..\..\ControlPages\ListBoxPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.ListBox2).Loaded += this.ListBox2_Loaded;
                    #line default
                }
                break;
            case 5:
                {
                    this.Control2Output = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.ListBox1 = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    #line 26 "..\..\..\ControlPages\ListBoxPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.ListBox1).SelectionChanged += this.ColorListBox_SelectionChanged;
                    #line default
                }
                break;
            case 7:
                {
                    this.Control1Output = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
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
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    ListBoxPage_obj1_Bindings bindings = new ListBoxPage_obj1_Bindings();
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

