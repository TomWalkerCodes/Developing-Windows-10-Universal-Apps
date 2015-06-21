﻿#pragma checksum "C:\Developing Windows 10 Universal Apps\Demos\BBQRecipes - Compiled Binding\BBQRecipes\Views\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FA872BF0824784F7B336B143B1393337"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HowToBBQ.Views
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
                  
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
                {
                    if (value == null && targetNullValue != null)
                    {
                        value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                    }
                    obj.ItemsSource = value;
                }
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
                {
                    if (value == null && targetNullValue != null)
                    {
                        value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                    }
                    obj.Source = value;
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

        private class MainPage_obj4_Bindings : 
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::HowToBBQ.Models.BBQRecipe dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = -2;
            private const int DATA_CHANGED = -1;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Image obj5;
            private global::Windows.UI.Xaml.Controls.TextBlock obj6;

            public MainPage_obj4_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 5:
                        this.obj5 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 6:
                        this.obj6 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::HowToBBQ.Models.BBQRecipe data = args.NewValue as global::HowToBBQ.Models.BBQRecipe;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::HowToBBQ.Models.BBQRecipe was expected.");
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

            public void SetDataRoot(global::HowToBBQ.Models.BBQRecipe newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::HowToBBQ.Models.BBQRecipe obj, int phase)
            {
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == 0)
                    {
                        this.Update_ImageSource(obj.ImageSource, phase);
                        this.Update_Name(obj.Name, phase);
                    }
                }
            }
            private void Update_ImageSource(global::System.String obj, int phase)
            {
                if (phase == NOT_PHASED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj5, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
            private void Update_Name(global::System.String obj, int phase)
            {
                if (phase == NOT_PHASED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj6, obj, null);
                }
            }
        }

        private class MainPage_obj1_Bindings : 
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::HowToBBQ.Views.MainPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = -2;
            private const int DATA_CHANGED = -1;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.GridView obj3;

            public MainPage_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3:
                        this.obj3 = (global::Windows.UI.Xaml.Controls.GridView)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::HowToBBQ.Views.MainPage data = args.NewValue as global::HowToBBQ.Views.MainPage;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::HowToBBQ.Views.MainPage was expected.");
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

            // MainPage_obj1_Bindings

            public void SetDataRoot(global::HowToBBQ.Views.MainPage newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::HowToBBQ.Views.MainPage obj, int phase)
            {
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::HowToBBQ.ViewModels.MainViewModel obj, int phase)
            {
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == 0)
                    {
                        this.Update_ViewModel_Recipes(obj.Recipes, phase);
                    }
                }
            }
            private void Update_ViewModel_Recipes(global::System.Collections.ObjectModel.ObservableCollection<global::HowToBBQ.Models.BBQRecipe> obj, int phase)
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
            case 2:
                {
                    this.pageTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.RecipesGridView = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 4:
                {
                    global::Windows.UI.Xaml.Controls.Grid element4 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 39 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)element4).Tapped += this.Item_Tapped;
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
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MainPage_obj1_Bindings bindings = new MainPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);                
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            case 4:
                {
                    global::Windows.UI.Xaml.Controls.Grid element4 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    MainPage_obj4_Bindings bindings = new MainPage_obj4_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::HowToBBQ.Models.BBQRecipe) element4.DataContext);                
                      element4.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element4, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}
