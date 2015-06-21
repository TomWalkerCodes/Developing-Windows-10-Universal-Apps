﻿#pragma checksum "C:\Developing Windows 10 Universal Apps\Demos\xaml_xamluibasics\CS\AppUIBasics\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AC906B93B8D71AD9A74338EC70E05D01"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppUIBasics
{
    partial class MainPage : 
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
            public static void Set_Windows_UI_Xaml_Automation_AutomationProperties_Name(global::Windows.UI.Xaml.FrameworkElement obj, global::System.String value, string targetNullValue)
                {
                    if (value == null && targetNullValue != null)
                    {
                            value = targetNullValue;
                    }
                    global::Windows.UI.Xaml.Automation.AutomationProperties.SetName(obj, value);
                }
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
                {
                    if (value == null && targetNullValue != null)
                    {
                        value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                    }
                    obj.Source = value;
                }
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
                {
                    if (value == null && targetNullValue != null)
                    {
                        value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                    }
                    obj.ItemsSource = value;
                }
        };

        private class MainPage_obj4_Bindings : 
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::AppUIBasics.Data.ControlInfoDataItem dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = -2;
            private const int DATA_CHANGED = -1;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj5;
            private global::Windows.UI.Xaml.Controls.TextBlock obj6;
            private global::Windows.UI.Xaml.Controls.Image obj7;

            public MainPage_obj4_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 5:
                        this.obj5 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 6:
                        this.obj6 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 7:
                        this.obj7 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::AppUIBasics.Data.ControlInfoDataItem data = args.NewValue as global::AppUIBasics.Data.ControlInfoDataItem;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::AppUIBasics.Data.ControlInfoDataItem was expected.");
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
            }

            // IMainPage_Bindings

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
            }

            // MainPage_obj4_Bindings

            public void SetDataRoot(global::AppUIBasics.Data.ControlInfoDataItem newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::AppUIBasics.Data.ControlInfoDataItem obj, int phase)
            {
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == 0)
                    {
                        this.Update_Title(obj.Title, phase);
                        this.Update_Subtitle(obj.Subtitle, phase);
                        this.Update_ImagePath(obj.ImagePath, phase);
                    }
                }
            }
            private void Update_Title(global::System.String obj, int phase)
            {
                if (phase == NOT_PHASED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj5, obj, null);
                    XamlBindingSetters.Set_Windows_UI_Xaml_Automation_AutomationProperties_Name(this.obj7, obj, null);
                }
            }
            private void Update_Subtitle(global::System.String obj, int phase)
            {
                if (phase == NOT_PHASED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj6, obj, null);
                }
            }
            private void Update_ImagePath(global::System.String obj, int phase)
            {
                if (phase == NOT_PHASED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj7, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
        }

        private class MainPage_obj8_Bindings : 
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::AppUIBasics.Data.ControlInfoDataGroup dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = -2;
            private const int DATA_CHANGED = -1;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj9;
            private global::Windows.UI.Xaml.Controls.Image obj10;
            private global::Windows.UI.Xaml.Controls.TextBlock obj11;
            private global::Windows.UI.Xaml.Controls.TextBlock obj12;

            public MainPage_obj8_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 9:
                        this.obj9 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 10:
                        this.obj10 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 11:
                        this.obj11 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 12:
                        this.obj12 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::AppUIBasics.Data.ControlInfoDataGroup data = args.NewValue as global::AppUIBasics.Data.ControlInfoDataGroup;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::AppUIBasics.Data.ControlInfoDataGroup was expected.");
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
            }

            // IMainPage_Bindings

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
            }

            // MainPage_obj8_Bindings

            public void SetDataRoot(global::AppUIBasics.Data.ControlInfoDataGroup newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::AppUIBasics.Data.ControlInfoDataGroup obj, int phase)
            {
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == 0)
                    {
                        this.Update_Description(obj.Description, phase);
                        this.Update_ImagePath(obj.ImagePath, phase);
                        this.Update_Title(obj.Title, phase);
                        this.Update_Subtitle(obj.Subtitle, phase);
                    }
                }
            }
            private void Update_Description(global::System.String obj, int phase)
            {
                if (phase == NOT_PHASED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj9, obj, null);
                }
            }
            private void Update_ImagePath(global::System.String obj, int phase)
            {
                if (phase == NOT_PHASED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj10, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
            private void Update_Title(global::System.String obj, int phase)
            {
                if (phase == NOT_PHASED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Automation_AutomationProperties_Name(this.obj10, obj, null);
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj11, obj, null);
                }
            }
            private void Update_Subtitle(global::System.String obj, int phase)
            {
                if (phase == NOT_PHASED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj12, obj, null);
                }
            }
        }

        private class MainPage_obj15_Bindings : 
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::AppUIBasics.MainPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = -2;
            private const int DATA_CHANGED = -1;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj15;

            private MainPage_obj15_BindingsTracking bindingsTracking;

            public MainPage_obj15_Bindings()
            {
                this.bindingsTracking = new MainPage_obj15_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 15:
                        this.obj15 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.GridView)target);
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::AppUIBasics.MainPage data = args.NewValue as global::AppUIBasics.MainPage;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::AppUIBasics.MainPage was expected.");
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

            // IMainPage_Bindings

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

            // MainPage_obj15_Bindings

            public void SetDataRoot(global::AppUIBasics.MainPage newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::AppUIBasics.MainPage obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == DATA_CHANGED || phase == 0)
                    {
                        this.Update_Items(obj.Items, phase);
                    }
                }
            }
            private void Update_Items(global::System.Collections.Generic.List<global::AppUIBasics.Data.ControlInfoDataItem> obj, int phase)
            {
                if (phase == NOT_PHASED || phase == DATA_CHANGED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj15.Target as global::Windows.UI.Xaml.Controls.GridView, obj, null);
                }
            }

            private class MainPage_obj15_BindingsTracking
            {
                global::System.WeakReference<MainPage_obj15_Bindings> WeakRefToBindingObj; 

                public MainPage_obj15_BindingsTracking(MainPage_obj15_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<MainPage_obj15_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void PropertyChanged_(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainPage_obj15_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::AppUIBasics.MainPage obj = sender as global::AppUIBasics.MainPage;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                                    if (obj != null)
                                    {
                                            bindings.Update_Items(obj.Items, DATA_CHANGED);
                                    }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Items" :
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Items(obj.Items, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                    else
                    {
                        ReleaseAllListeners();
                    }
                }
                public void UpdateChildListeners_(global::AppUIBasics.MainPage obj)
                {
                    MainPage_obj15_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        if (bindings.dataRoot != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)bindings.dataRoot).PropertyChanged -= PropertyChanged_;
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_;
                        }
                    }
                }
            }
        }

        private class MainPage_obj16_Bindings : 
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::AppUIBasics.MainPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = -2;
            private const int DATA_CHANGED = -1;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj16;

            private MainPage_obj16_BindingsTracking bindingsTracking;

            public MainPage_obj16_Bindings()
            {
                this.bindingsTracking = new MainPage_obj16_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 16:
                        this.obj16 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.GridView)target);
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::AppUIBasics.MainPage data = args.NewValue as global::AppUIBasics.MainPage;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::AppUIBasics.MainPage was expected.");
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

            // IMainPage_Bindings

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

            // MainPage_obj16_Bindings

            public void SetDataRoot(global::AppUIBasics.MainPage newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::AppUIBasics.MainPage obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == DATA_CHANGED || phase == 0)
                    {
                        this.Update_Groups(obj.Groups, phase);
                    }
                }
            }
            private void Update_Groups(global::System.Collections.Generic.IEnumerable<global::AppUIBasics.Data.ControlInfoDataGroup> obj, int phase)
            {
                if (phase == NOT_PHASED || phase == DATA_CHANGED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj16.Target as global::Windows.UI.Xaml.Controls.GridView, obj, null);
                }
            }

            private class MainPage_obj16_BindingsTracking
            {
                global::System.WeakReference<MainPage_obj16_Bindings> WeakRefToBindingObj; 

                public MainPage_obj16_BindingsTracking(MainPage_obj16_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<MainPage_obj16_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void PropertyChanged_(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainPage_obj16_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::AppUIBasics.MainPage obj = sender as global::AppUIBasics.MainPage;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                                    if (obj != null)
                                    {
                                            bindings.Update_Groups(obj.Groups, DATA_CHANGED);
                                    }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Groups" :
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Groups(obj.Groups, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                    else
                    {
                        ReleaseAllListeners();
                    }
                }
                public void UpdateChildListeners_(global::AppUIBasics.MainPage obj)
                {
                    MainPage_obj16_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        if (bindings.dataRoot != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)bindings.dataRoot).PropertyChanged -= PropertyChanged_;
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_;
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
            case 1:
                {
                    this.pageRoot = (global::Windows.UI.Xaml.Controls.Page)(target);
                    #line 23 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Page)this.pageRoot).SizeChanged += this.pageRoot_SizeChanged;
                    #line default
                }
                break;
            case 2:
                {
                    this.bottomAppBar = (global::Windows.UI.Xaml.Controls.CommandBar)(target);
                }
                break;
            case 3:
                {
                    this.searchButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 27 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.searchButton).Click += this.SearchButton_Click;
                    #line default
                }
                break;
            case 13:
                {
                    global::Windows.UI.Xaml.Controls.Hub element13 = (global::Windows.UI.Xaml.Controls.Hub)(target);
                    #line 78 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Hub)element13).SectionHeaderClick += this.Hub_SectionHeaderClick;
                    #line default
                }
                break;
            case 14:
                {
                    this.GroupsHubSection = (global::Windows.UI.Xaml.Controls.HubSection)(target);
                }
                break;
            case 15:
                {
                    global::Windows.UI.Xaml.Controls.GridView element15 = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    #line 153 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.GridView)element15).ItemClick += this.ItemView_ItemClick;
                    #line default
                }
                break;
            case 16:
                {
                    global::Windows.UI.Xaml.Controls.GridView element16 = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    #line 120 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.GridView)element16).ItemClick += this.GroupView_ItemClick;
                    #line default
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
            case 4:
                {
                    global::Windows.UI.Xaml.Controls.Grid element4 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    MainPage_obj4_Bindings bindings = new MainPage_obj4_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::AppUIBasics.Data.ControlInfoDataItem) element4.DataContext);                
                      element4.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element4, bindings);
                }
                break;
            case 8:
                {
                    global::Windows.UI.Xaml.Controls.Grid element8 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    MainPage_obj8_Bindings bindings = new MainPage_obj8_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::AppUIBasics.Data.ControlInfoDataGroup) element8.DataContext);                
                      element8.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element8, bindings);
                }
                break;
            case 15:
                {
                    global::Windows.UI.Xaml.Controls.GridView element15 = (global::Windows.UI.Xaml.Controls.GridView)target;
                    MainPage_obj15_Bindings bindings = new MainPage_obj15_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::AppUIBasics.MainPage) element15.DataContext);                
                      element15.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element15, bindings);
                }
                break;
            case 16:
                {
                    global::Windows.UI.Xaml.Controls.GridView element16 = (global::Windows.UI.Xaml.Controls.GridView)target;
                    MainPage_obj16_Bindings bindings = new MainPage_obj16_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::AppUIBasics.MainPage) element16.DataContext);                
                      element16.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element16, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}
