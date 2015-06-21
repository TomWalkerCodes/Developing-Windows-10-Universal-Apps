﻿#pragma checksum "C:\Developing Windows 10 Universal Apps\Demos\xaml_xamluibasics\CS\AppUIBasics\ControlPages\CalendarViewPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0C1CBE40A81B6623FCAE44A4F15D8D64"
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
    partial class CalendarViewPage : 
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
                  
            public static void Set_Windows_UI_Xaml_Documents_Run_Text(global::Windows.UI.Xaml.Documents.Run obj, global::System.String value, string targetNullValue)
                {
                    if (value == null && targetNullValue != null)
                    {
                            value = targetNullValue;
                    }
                    obj.Text = value;
                }
            public static void Set_Windows_UI_Xaml_Controls_CalendarView_IsOutOfScopeEnabled(global::Windows.UI.Xaml.Controls.CalendarView obj, global::System.Boolean value)
                {
                    obj.IsOutOfScopeEnabled = value;
                }
            public static void Set_Windows_UI_Xaml_Controls_CalendarView_IsGroupLabelVisible(global::Windows.UI.Xaml.Controls.CalendarView obj, global::System.Boolean value)
                {
                    obj.IsGroupLabelVisible = value;
                }
            public static void Set_Windows_UI_Xaml_Controls_CalendarView_CalendarIdentifier(global::Windows.UI.Xaml.Controls.CalendarView obj, global::System.String value, string targetNullValue)
                {
                    if (value == null && targetNullValue != null)
                    {
                            value = targetNullValue;
                    }
                    obj.CalendarIdentifier = value;
                }
        };

        private class CalendarViewPage_obj1_Bindings : 
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ICalendarViewPage_Bindings
        {
            private global::AppUIBasics.ControlPages.CalendarViewPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = -2;
            private const int DATA_CHANGED = -1;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Documents.Run obj10;
            private global::Windows.UI.Xaml.Documents.Run obj11;
            private global::Windows.UI.Xaml.Documents.Run obj12;
            private global::Windows.UI.Xaml.Documents.Run obj13;
            private global::Windows.UI.Xaml.Documents.Run obj14;
            private global::Windows.UI.Xaml.Controls.CalendarView obj15;

            private CalendarViewPage_obj1_BindingsTracking bindingsTracking;

            public CalendarViewPage_obj1_Bindings()
            {
                this.bindingsTracking = new CalendarViewPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 10:
                        this.obj10 = (global::Windows.UI.Xaml.Documents.Run)target;
                        break;
                    case 11:
                        this.obj11 = (global::Windows.UI.Xaml.Documents.Run)target;
                        break;
                    case 12:
                        this.obj12 = (global::Windows.UI.Xaml.Documents.Run)target;
                        break;
                    case 13:
                        this.obj13 = (global::Windows.UI.Xaml.Documents.Run)target;
                        break;
                    case 14:
                        this.obj14 = (global::Windows.UI.Xaml.Documents.Run)target;
                        break;
                    case 15:
                        this.obj15 = (global::Windows.UI.Xaml.Controls.CalendarView)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::AppUIBasics.ControlPages.CalendarViewPage data = args.NewValue as global::AppUIBasics.ControlPages.CalendarViewPage;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::AppUIBasics.ControlPages.CalendarViewPage was expected.");
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

            // ICalendarViewPage_Bindings

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

            // CalendarViewPage_obj1_Bindings

            public void SetDataRoot(global::AppUIBasics.ControlPages.CalendarViewPage newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::AppUIBasics.ControlPages.CalendarViewPage obj, int phase)
            {
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == DATA_CHANGED || phase == 0)
                    {
                        this.Update_Control1(obj.Control1, phase);
                        this.Update_isOutOfScopeEnabled(obj.isOutOfScopeEnabled, phase);
                        this.Update_selectionMode(obj.selectionMode, phase);
                        this.Update_isGroupLabelVisible(obj.isGroupLabelVisible, phase);
                        this.Update_calendarIdentifier(obj.calendarIdentifier, phase);
                    }
                }
            }
            private void Update_Control1(global::Windows.UI.Xaml.Controls.CalendarView obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_Control1(obj);
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == DATA_CHANGED || phase == 0)
                    {
                        this.Update_Control1_CalendarIdentifier(obj.CalendarIdentifier, phase);
                        this.Update_Control1_Language(obj.Language, phase);
                    }
                }
            }
            private void Update_Control1_CalendarIdentifier(global::System.String obj, int phase)
            {
                if (phase == NOT_PHASED || phase == DATA_CHANGED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Documents_Run_Text(this.obj10, obj, null);
                }
            }
            private void Update_isOutOfScopeEnabled(global::Windows.UI.Xaml.Controls.CheckBox obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_isOutOfScopeEnabled(obj);
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == DATA_CHANGED || phase == 0)
                    {
                        this.Update_isOutOfScopeEnabled_IsChecked(obj.IsChecked, phase);
                    }
                }
            }
            private void Update_isOutOfScopeEnabled_IsChecked(global::System.Nullable<global::System.Boolean> obj, int phase)
            {
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == DATA_CHANGED || phase == 0)
                    {
                        this.Update_isOutOfScopeEnabled_IsChecked_Value(obj.Value, phase);
                    }
                }
            }
            private void Update_isOutOfScopeEnabled_IsChecked_Value(global::System.Boolean obj, int phase)
            {
                if (phase == NOT_PHASED || phase == DATA_CHANGED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Documents_Run_Text(this.obj11, obj.ToString(), null);
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_CalendarView_IsOutOfScopeEnabled(this.obj15, obj);
                }
            }
            private void Update_Control1_Language(global::System.String obj, int phase)
            {
                if (phase == NOT_PHASED || phase == DATA_CHANGED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Documents_Run_Text(this.obj12, obj, null);
                }
            }
            private void Update_selectionMode(global::Windows.UI.Xaml.Controls.ComboBox obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_selectionMode(obj);
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == DATA_CHANGED || phase == 0)
                    {
                        this.Update_selectionMode_SelectedValue(obj.SelectedValue, phase);
                    }
                }
            }
            private void Update_selectionMode_SelectedValue(global::System.Object obj, int phase)
            {
                if (phase == NOT_PHASED || phase == DATA_CHANGED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Documents_Run_Text(this.obj13, obj != null ? obj.ToString() : null, null);
                }
            }
            private void Update_isGroupLabelVisible(global::Windows.UI.Xaml.Controls.CheckBox obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_isGroupLabelVisible(obj);
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == DATA_CHANGED || phase == 0)
                    {
                        this.Update_isGroupLabelVisible_IsChecked(obj.IsChecked, phase);
                    }
                }
            }
            private void Update_isGroupLabelVisible_IsChecked(global::System.Nullable<global::System.Boolean> obj, int phase)
            {
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == DATA_CHANGED || phase == 0)
                    {
                        this.Update_isGroupLabelVisible_IsChecked_Value(obj.Value, phase);
                    }
                }
            }
            private void Update_isGroupLabelVisible_IsChecked_Value(global::System.Boolean obj, int phase)
            {
                if (phase == NOT_PHASED || phase == DATA_CHANGED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Documents_Run_Text(this.obj14, obj.ToString(), null);
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_CalendarView_IsGroupLabelVisible(this.obj15, obj);
                }
            }
            private void Update_calendarIdentifier(global::Windows.UI.Xaml.Controls.ComboBox obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_calendarIdentifier(obj);
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == DATA_CHANGED || phase == 0)
                    {
                        this.Update_calendarIdentifier_SelectedValue(obj.SelectedValue, phase);
                    }
                }
            }
            private void Update_calendarIdentifier_SelectedValue(global::System.Object obj, int phase)
            {
                if (phase == NOT_PHASED || phase == DATA_CHANGED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_CalendarView_CalendarIdentifier(this.obj15, obj != null ? obj.ToString() : null, null);
                }
            }

            private class CalendarViewPage_obj1_BindingsTracking
            {
                global::System.WeakReference<CalendarViewPage_obj1_Bindings> WeakRefToBindingObj; 

                public CalendarViewPage_obj1_BindingsTracking(CalendarViewPage_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<CalendarViewPage_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_Control1(null);
                    UpdateChildListeners_isOutOfScopeEnabled(null);
                    UpdateChildListeners_selectionMode(null);
                    UpdateChildListeners_isGroupLabelVisible(null);
                    UpdateChildListeners_calendarIdentifier(null);
                }

                public void DependencyPropertyChanged_Control1_CalendarIdentifier(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    CalendarViewPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::Windows.UI.Xaml.Controls.CalendarView obj = sender as global::Windows.UI.Xaml.Controls.CalendarView;
        if (obj != null)
        {
            bindings.Update_Control1_CalendarIdentifier(obj.CalendarIdentifier, DATA_CHANGED);
        }
                    }
                    else
                    {
                        ReleaseAllListeners();
                    }
                }
                public void DependencyPropertyChanged_Control1_Language(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    CalendarViewPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::Windows.UI.Xaml.Controls.CalendarView obj = sender as global::Windows.UI.Xaml.Controls.CalendarView;
        if (obj != null)
        {
            bindings.Update_Control1_Language(obj.Language, DATA_CHANGED);
        }
                    }
                    else
                    {
                        ReleaseAllListeners();
                    }
                }
                private global::Windows.UI.Xaml.Controls.CalendarView cache_Control1 = null;
                private long tokenDPC_Control1_CalendarIdentifier = 0;
                private long tokenDPC_Control1_Language = 0;
                public void UpdateChildListeners_Control1(global::Windows.UI.Xaml.Controls.CalendarView obj)
                {
                    if (obj != cache_Control1)
                    {
                        if (cache_Control1 != null)
                        {
                            cache_Control1.UnregisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.CalendarView.CalendarIdentifierProperty, tokenDPC_Control1_CalendarIdentifier);
                            cache_Control1.UnregisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.CalendarView.LanguageProperty, tokenDPC_Control1_Language);
                            cache_Control1 = null;
                        }
                        if (obj != null)
                        {
                            tokenDPC_Control1_CalendarIdentifier = obj.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.CalendarView.CalendarIdentifierProperty, DependencyPropertyChanged_Control1_CalendarIdentifier);
                            tokenDPC_Control1_Language = obj.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.CalendarView.LanguageProperty, DependencyPropertyChanged_Control1_Language);
                        }
                    }
                }
                public void DependencyPropertyChanged_isOutOfScopeEnabled_IsChecked(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    CalendarViewPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::Windows.UI.Xaml.Controls.CheckBox obj = sender as global::Windows.UI.Xaml.Controls.CheckBox;
        if (obj != null)
        {
            bindings.Update_isOutOfScopeEnabled_IsChecked(obj.IsChecked, DATA_CHANGED);
        }
                    }
                    else
                    {
                        ReleaseAllListeners();
                    }
                }
                private global::Windows.UI.Xaml.Controls.CheckBox cache_isOutOfScopeEnabled = null;
                private long tokenDPC_isOutOfScopeEnabled_IsChecked = 0;
                public void UpdateChildListeners_isOutOfScopeEnabled(global::Windows.UI.Xaml.Controls.CheckBox obj)
                {
                    if (obj != cache_isOutOfScopeEnabled)
                    {
                        if (cache_isOutOfScopeEnabled != null)
                        {
                            cache_isOutOfScopeEnabled.UnregisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.CheckBox.IsCheckedProperty, tokenDPC_isOutOfScopeEnabled_IsChecked);
                            cache_isOutOfScopeEnabled = null;
                        }
                        if (obj != null)
                        {
                            tokenDPC_isOutOfScopeEnabled_IsChecked = obj.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.CheckBox.IsCheckedProperty, DependencyPropertyChanged_isOutOfScopeEnabled_IsChecked);
                        }
                    }
                }
                public void DependencyPropertyChanged_selectionMode_SelectedValue(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    CalendarViewPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::Windows.UI.Xaml.Controls.ComboBox obj = sender as global::Windows.UI.Xaml.Controls.ComboBox;
        if (obj != null)
        {
            bindings.Update_selectionMode_SelectedValue(obj.SelectedValue, DATA_CHANGED);
        }
                    }
                    else
                    {
                        ReleaseAllListeners();
                    }
                }
                private global::Windows.UI.Xaml.Controls.ComboBox cache_selectionMode = null;
                private long tokenDPC_selectionMode_SelectedValue = 0;
                public void UpdateChildListeners_selectionMode(global::Windows.UI.Xaml.Controls.ComboBox obj)
                {
                    if (obj != cache_selectionMode)
                    {
                        if (cache_selectionMode != null)
                        {
                            cache_selectionMode.UnregisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.ComboBox.SelectedValueProperty, tokenDPC_selectionMode_SelectedValue);
                            cache_selectionMode = null;
                        }
                        if (obj != null)
                        {
                            tokenDPC_selectionMode_SelectedValue = obj.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.ComboBox.SelectedValueProperty, DependencyPropertyChanged_selectionMode_SelectedValue);
                        }
                    }
                }
                public void DependencyPropertyChanged_isGroupLabelVisible_IsChecked(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    CalendarViewPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::Windows.UI.Xaml.Controls.CheckBox obj = sender as global::Windows.UI.Xaml.Controls.CheckBox;
        if (obj != null)
        {
            bindings.Update_isGroupLabelVisible_IsChecked(obj.IsChecked, DATA_CHANGED);
        }
                    }
                    else
                    {
                        ReleaseAllListeners();
                    }
                }
                private global::Windows.UI.Xaml.Controls.CheckBox cache_isGroupLabelVisible = null;
                private long tokenDPC_isGroupLabelVisible_IsChecked = 0;
                public void UpdateChildListeners_isGroupLabelVisible(global::Windows.UI.Xaml.Controls.CheckBox obj)
                {
                    if (obj != cache_isGroupLabelVisible)
                    {
                        if (cache_isGroupLabelVisible != null)
                        {
                            cache_isGroupLabelVisible.UnregisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.CheckBox.IsCheckedProperty, tokenDPC_isGroupLabelVisible_IsChecked);
                            cache_isGroupLabelVisible = null;
                        }
                        if (obj != null)
                        {
                            tokenDPC_isGroupLabelVisible_IsChecked = obj.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.CheckBox.IsCheckedProperty, DependencyPropertyChanged_isGroupLabelVisible_IsChecked);
                        }
                    }
                }
                public void DependencyPropertyChanged_calendarIdentifier_SelectedValue(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    CalendarViewPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::Windows.UI.Xaml.Controls.ComboBox obj = sender as global::Windows.UI.Xaml.Controls.ComboBox;
        if (obj != null)
        {
            bindings.Update_calendarIdentifier_SelectedValue(obj.SelectedValue, DATA_CHANGED);
        }
                    }
                    else
                    {
                        ReleaseAllListeners();
                    }
                }
                private global::Windows.UI.Xaml.Controls.ComboBox cache_calendarIdentifier = null;
                private long tokenDPC_calendarIdentifier_SelectedValue = 0;
                public void UpdateChildListeners_calendarIdentifier(global::Windows.UI.Xaml.Controls.ComboBox obj)
                {
                    if (obj != cache_calendarIdentifier)
                    {
                        if (cache_calendarIdentifier != null)
                        {
                            cache_calendarIdentifier.UnregisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.ComboBox.SelectedValueProperty, tokenDPC_calendarIdentifier_SelectedValue);
                            cache_calendarIdentifier = null;
                        }
                        if (obj != null)
                        {
                            tokenDPC_calendarIdentifier_SelectedValue = obj.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.ComboBox.SelectedValueProperty, DependencyPropertyChanged_calendarIdentifier_SelectedValue);
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
                    this.ExampleAccessories = (global::AppUIBasics.ControlPages.ControlExample)(target);
                }
                break;
            case 4:
                {
                    this.calendarIdentifier = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 5:
                {
                    this.language = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6:
                {
                    this.setLanguage = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 32 "..\..\..\ControlPages\CalendarViewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.setLanguage).Click += this.setLanguage_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.isGroupLabelVisible = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 8:
                {
                    this.isOutOfScopeEnabled = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 9:
                {
                    this.selectionMode = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 23 "..\..\..\ControlPages\CalendarViewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.selectionMode).SelectionChanged += this.SelectionMode_SelectionChanged;
                    #line default
                }
                break;
            case 15:
                {
                    this.Control1 = (global::Windows.UI.Xaml.Controls.CalendarView)(target);
                }
                break;
            case 16:
                {
                    this.WideLayout = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 17:
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
                    CalendarViewPage_obj1_Bindings bindings = new CalendarViewPage_obj1_Bindings();
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
