﻿#pragma checksum "C:\Developing Windows 10 Universal Apps\Demos\xaml_xamluibasics\CS\AppUIBasics\ControlPages\SemanticZoomPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CF2C85723290735AC24AC50D29A72AA3"
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
    partial class SemanticZoomPage : 
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
                  
            public static void Set_Windows_UI_Xaml_Data_CollectionViewSource_Source(global::Windows.UI.Xaml.Data.CollectionViewSource obj, global::System.Object value, string targetNullValue)
                {
                    if (value == null && targetNullValue != null)
                    {
                        value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
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
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
                {
                    if (value == null && targetNullValue != null)
                    {
                            value = targetNullValue;
                    }
                    obj.Text = value;
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

        private class SemanticZoomPage_obj3_Bindings : 
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ISemanticZoomPage_Bindings
        {
            private global::Windows.UI.Xaml.Data.ICollectionViewGroup dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = -2;
            private const int DATA_CHANGED = -1;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj3;

            public SemanticZoomPage_obj3_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3:
                        this.obj3 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.TextBlock)target);
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::Windows.UI.Xaml.Data.ICollectionViewGroup data = args.NewValue as global::Windows.UI.Xaml.Data.ICollectionViewGroup;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::Windows.UI.Xaml.Data.ICollectionViewGroup was expected.");
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

            // ISemanticZoomPage_Bindings

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

            // SemanticZoomPage_obj3_Bindings

            public void SetDataRoot(global::Windows.UI.Xaml.Data.ICollectionViewGroup newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Windows.UI.Xaml.Data.ICollectionViewGroup obj, int phase)
            {
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == 0)
                    {
                        this.Update_Group(obj.Group, phase);
                    }
                }
            }
            private void Update_Group(global::System.Object obj, int phase)
            {
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == 0)
                    {
                        this.Update_Group__data_ControlInfoDataGroup_Title_(((global::AppUIBasics.Data.ControlInfoDataGroup)(obj)).Title, phase);
                    }
                }
            }
            private void Update_Group__data_ControlInfoDataGroup_Title_(global::System.String obj, int phase)
            {
                if (phase == NOT_PHASED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj3.Target as global::Windows.UI.Xaml.Controls.TextBlock, obj, null);
                }
            }
        }

        private class SemanticZoomPage_obj4_Bindings : 
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ISemanticZoomPage_Bindings
        {
            private global::AppUIBasics.Data.ControlInfoDataGroup dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = -2;
            private const int DATA_CHANGED = -1;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj4;

            public SemanticZoomPage_obj4_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 4:
                        this.obj4 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.TextBlock)target);
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

            // ISemanticZoomPage_Bindings

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

            // SemanticZoomPage_obj4_Bindings

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
                        this.Update_Title(obj.Title, phase);
                    }
                }
            }
            private void Update_Title(global::System.String obj, int phase)
            {
                if (phase == NOT_PHASED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj4.Target as global::Windows.UI.Xaml.Controls.TextBlock, obj, null);
                }
            }
        }

        private class SemanticZoomPage_obj5_Bindings : 
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ISemanticZoomPage_Bindings
        {
            private global::AppUIBasics.Data.ControlInfoDataItem dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = -2;
            private const int DATA_CHANGED = -1;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Image obj6;
            private global::Windows.UI.Xaml.Controls.TextBlock obj7;
            private global::Windows.UI.Xaml.Controls.TextBlock obj8;

            public SemanticZoomPage_obj5_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 6:
                        this.obj6 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 7:
                        this.obj7 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 8:
                        this.obj8 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
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

            // ISemanticZoomPage_Bindings

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

            // SemanticZoomPage_obj5_Bindings

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
                        this.Update_ImagePath(obj.ImagePath, phase);
                        this.Update_Title(obj.Title, phase);
                        this.Update_Subtitle(obj.Subtitle, phase);
                    }
                }
            }
            private void Update_ImagePath(global::System.String obj, int phase)
            {
                if (phase == NOT_PHASED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj6, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
            private void Update_Title(global::System.String obj, int phase)
            {
                if (phase == NOT_PHASED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj7, obj, null);
                }
            }
            private void Update_Subtitle(global::System.String obj, int phase)
            {
                if (phase == NOT_PHASED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj8, obj, null);
                }
            }
        }

        private class SemanticZoomPage_obj1_Bindings : 
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ISemanticZoomPage_Bindings
        {
            private global::AppUIBasics.ControlPages.SemanticZoomPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = -2;
            private const int DATA_CHANGED = -1;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Data.CollectionViewSource obj2;
            private global::Windows.UI.Xaml.Controls.GridView obj10;
            private global::Windows.UI.Xaml.Controls.ListView obj11;

            public SemanticZoomPage_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::Windows.UI.Xaml.Data.CollectionViewSource)target;
                        break;
                    case 10:
                        this.obj10 = (global::Windows.UI.Xaml.Controls.GridView)target;
                        break;
                    case 11:
                        this.obj11 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::AppUIBasics.ControlPages.SemanticZoomPage data = args.NewValue as global::AppUIBasics.ControlPages.SemanticZoomPage;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::AppUIBasics.ControlPages.SemanticZoomPage was expected.");
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

            // ISemanticZoomPage_Bindings

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

            // SemanticZoomPage_obj1_Bindings

            public void SetDataRoot(global::AppUIBasics.ControlPages.SemanticZoomPage newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::AppUIBasics.ControlPages.SemanticZoomPage obj, int phase)
            {
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == 0)
                    {
                        this.Update_Groups(obj.Groups, phase);
                        this.Update_cvsGroups(obj.cvsGroups, phase);
                    }
                }
            }
            private void Update_Groups(global::System.Collections.Generic.IEnumerable<global::AppUIBasics.Data.ControlInfoDataGroup> obj, int phase)
            {
                if (phase == NOT_PHASED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Data_CollectionViewSource_Source(this.obj2, obj, null);
                }
            }
            private void Update_cvsGroups(global::Windows.UI.Xaml.Data.CollectionViewSource obj, int phase)
            {
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == 0)
                    {
                        this.Update_cvsGroups_View(obj.View, phase);
                    }
                }
            }
            private void Update_cvsGroups_View(global::Windows.UI.Xaml.Data.ICollectionView obj, int phase)
            {
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == 0)
                    {
                        this.Update_cvsGroups_View_CollectionGroups(obj.CollectionGroups, phase);
                    }
                }
                if (phase == NOT_PHASED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj10, obj, null);
                }
            }
            private void Update_cvsGroups_View_CollectionGroups(global::Windows.Foundation.Collections.IObservableVector<global::System.Object> obj, int phase)
            {
                if (phase == NOT_PHASED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj11, obj, null);
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
                    this.cvsGroups = (global::Windows.UI.Xaml.Data.CollectionViewSource)(target);
                }
                break;
            case 9:
                {
                    this.Control1 = (global::Windows.UI.Xaml.Controls.SemanticZoom)(target);
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
                    SemanticZoomPage_obj1_Bindings bindings = new SemanticZoomPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);                
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            case 3:
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element3 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                    SemanticZoomPage_obj3_Bindings bindings = new SemanticZoomPage_obj3_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::Windows.UI.Xaml.Data.ICollectionViewGroup) element3.DataContext);                
                      element3.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element3, bindings);
                }
                break;
            case 4:
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element4 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                    SemanticZoomPage_obj4_Bindings bindings = new SemanticZoomPage_obj4_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::AppUIBasics.Data.ControlInfoDataGroup) element4.DataContext);                
                      element4.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element4, bindings);
                }
                break;
            case 5:
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element5 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                    SemanticZoomPage_obj5_Bindings bindings = new SemanticZoomPage_obj5_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::AppUIBasics.Data.ControlInfoDataItem) element5.DataContext);                
                      element5.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element5, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

