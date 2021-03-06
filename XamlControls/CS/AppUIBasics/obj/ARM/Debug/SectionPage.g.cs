﻿#pragma checksum "C:\Developing Windows 10 Universal Apps\Demos\xaml_xamluibasics\CS\AppUIBasics\SectionPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "03DB5F91BA67912F9695AA60F0E72493"
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
    partial class SectionPage : 
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
                  
            public static void Set_AppUIBasics_PageHeader_Title(global::AppUIBasics.PageHeader obj, global::System.Object value, string targetNullValue)
                {
                    if (value == null && targetNullValue != null)
                    {
                        value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                    }
                    obj.Title = value;
                }
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
                {
                    if (value == null && targetNullValue != null)
                    {
                        value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                    }
                    obj.ItemsSource = value;
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
        };

        private class SectionPage_obj4_Bindings : 
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ISectionPage_Bindings
        {
            private global::AppUIBasics.Data.ControlInfoDataItem dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = -2;
            private const int DATA_CHANGED = -1;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj5;
            private global::Windows.UI.Xaml.Controls.TextBlock obj6;
            private global::Windows.UI.Xaml.Controls.Image obj7;

            public SectionPage_obj4_Bindings()
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

            // ISectionPage_Bindings

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

            // SectionPage_obj4_Bindings

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

        private class SectionPage_obj1_Bindings : 
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ISectionPage_Bindings
        {
            private global::AppUIBasics.SectionPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = -2;
            private const int DATA_CHANGED = -1;

            // Fields for each control that has bindings.
            private global::AppUIBasics.PageHeader obj2;
            private global::Windows.UI.Xaml.Controls.GridView obj3;

            public SectionPage_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::AppUIBasics.PageHeader)target;
                        break;
                    case 3:
                        this.obj3 = (global::Windows.UI.Xaml.Controls.GridView)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::AppUIBasics.SectionPage data = args.NewValue as global::AppUIBasics.SectionPage;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::AppUIBasics.SectionPage was expected.");
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

            // ISectionPage_Bindings

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

            // SectionPage_obj1_Bindings

            public void SetDataRoot(global::AppUIBasics.SectionPage newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::AppUIBasics.SectionPage obj, int phase)
            {
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == 0)
                    {
                        this.Update_Group(obj.Group, phase);
                    }
                }
            }
            private void Update_Group(global::AppUIBasics.Data.ControlInfoDataGroup obj, int phase)
            {
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == 0)
                    {
                        this.Update_Group_Title(obj.Title, phase);
                        this.Update_Group_Items(obj.Items, phase);
                    }
                }
            }
            private void Update_Group_Title(global::System.String obj, int phase)
            {
                if (phase == NOT_PHASED || phase == 0)
                {
                    XamlBindingSetters.Set_AppUIBasics_PageHeader_Title(this.obj2, obj, null);
                }
            }
            private void Update_Group_Items(global::System.Collections.ObjectModel.ObservableCollection<global::AppUIBasics.Data.ControlInfoDataItem> obj, int phase)
            {
                if (phase == NOT_PHASED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj3, obj, null);
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
                }
                break;
            case 3:
                {
                    this.itemGridView = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    #line 55 "..\..\..\SectionPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.GridView)this.itemGridView).ItemClick += this.ItemView_ItemClick;
                    #line default
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
                    SectionPage_obj1_Bindings bindings = new SectionPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);                
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            case 4:
                {
                    global::Windows.UI.Xaml.Controls.Grid element4 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    SectionPage_obj4_Bindings bindings = new SectionPage_obj4_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::AppUIBasics.Data.ControlInfoDataItem) element4.DataContext);                
                      element4.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element4, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

