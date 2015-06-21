using HowToBBQ.Models;
using System;
using Windows.ApplicationModel;
using Windows.UI.Xaml.Navigation;
using Newtonsoft.Json;


namespace HowToBBQ.ViewModels
{
    public class RecipeViewModel : Mvvm.ViewModelBase
    {
        private string prefix = @"/Images/";

        private BBQRecipe _recipe;

        public BBQRecipe Recipe
        {

            get { return _recipe; }
            set
            {
                _recipe = value;
                RaisePropertyChanged("Recipe");
            }
        } 
        
        public RecipeViewModel()
        {
            _recipe = new BBQRecipe();
            if (!IsDataLoaded)
            {
                LoadData();
            }
        }


        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        private void LoadData()
        {
            if (DesignMode.DesignModeEnabled)
            {

                _recipe.Id = 1;
                _recipe.Name = "Dry Glazed Pork Tenderloin";
                _recipe.ShortDesc = "";
                _recipe.Ingredients = string.Concat("3 light brown sugar, packed", Environment.NewLine,
                                                 "3 clove garlic, minced", Environment.NewLine,
                                                 "1 tbsp finely grated orange zest", Environment.NewLine,
                                                 "3 tbsp paprika", Environment.NewLine,
                                                 "1 tbsp sesame seeds", Environment.NewLine,
                                                 "1 tbsp ground ginger", Environment.NewLine,
                                                 "1 tbsp ground coriander", Environment.NewLine,
                                                 "2 tsp fine salt", Environment.NewLine,
                                                 "2 tsp ground black pepper", Environment.NewLine,
                                                 "1 tsp cream of tartar", Environment.NewLine,
                                                 "3 1 lb. pork tenderloins");
                _recipe.Directions = string.Concat("1. For dry glaze, stir brown sugar, garlic and orange zest to blend. In a separate bowl, stir remaining ingredients, then add to brown sugar mixture. Set aside until ready to use.", Environment.NewLine,
                                              "2. Clean pork tenderloin of any connective tissue. Preheat grill to medium and clean well. Rub tenderloins completely with dry glaze and immediately place on grill. Grill, uncovered, for about 8 minutes on each side until an internal temperature of 165°F is reached, rotating tenderloins 90° on each side. Let pork sit for a moment before slicing and serving."
                                              );
                _recipe.Serves = 10;
                _recipe.PrepTime = 0;
                _recipe.TotalTime = 0;
                _recipe.ImageSource = prefix + "DryGlazedPorkTenderloin.jpg";
            }

        }

        public string SaveData()
        {
            string result = string.Empty;

            try
            {

                BBQRecipe existingRecipe = null;

                if (existingRecipe != null)
                {
                }
                else
                {
                    App.dbRecipes.Add(_recipe);
                }
                result = "Success";
            }
            catch
            {
                result = "This recipe was not saved.";
            }

            return result;
        }

        public override void OnNavigatedTo(string parameter, NavigationMode mode, System.Collections.Generic.IDictionary<string, object> state)
        {
            Recipe = JsonConvert.DeserializeObject<BBQRecipe>(parameter);
   
        }

        public Mvvm.Command GoBackCommand
        {
            get { return new Mvvm.Command(() => { (App.Current as Common.BootStrapper).NavigationService.GoBack(); }); }
        }

        public int Id
        {
            get { return _recipe.Id; }
            set
            {
                _recipe.Id = value;
                RaisePropertyChanged("Name");
            }
        }


        public string Name 
        {
            get { return _recipe.Name; }
            set
            {
                _recipe.Name = value;
                RaisePropertyChanged("Name");
            }
        }

        public string ShortDesc 
        {
            get { return _recipe.ShortDesc; }
            set
            {
                _recipe.ShortDesc = value;
                RaisePropertyChanged("ShortDesc");
            }
        }

        public string Ingredients
        {
            get { return _recipe.Ingredients; }
            set
            {
                _recipe.Ingredients = value;
                RaisePropertyChanged("Ingredients");
            }
        }

        public string Directions
        {
            get { return _recipe.Directions; }
            set
            {
                _recipe.Directions = value;
                RaisePropertyChanged("Directions");
            }
        }

        public int PrepTime
        {
            get { return _recipe.PrepTime; }
            set
            {
                _recipe.PrepTime = value;
                RaisePropertyChanged("PrepTime");
            }
        }

        public int TotalTime
        {
            get { return _recipe.TotalTime; }
            set
            {
                _recipe.TotalTime = value;
                RaisePropertyChanged("TotalTime");
            }
        }

        public int Serves
        {
            get { return _recipe.Serves; }
            set
            {
                _recipe.Serves = value;
                RaisePropertyChanged("Serves");
            }
        }

        public string ImageSource
        {
            get { return _recipe.ImageSource;  }
            set
            {
                _recipe.ImageSource = value;
                RaisePropertyChanged("ImageSource");
            }
        }
    }
}
