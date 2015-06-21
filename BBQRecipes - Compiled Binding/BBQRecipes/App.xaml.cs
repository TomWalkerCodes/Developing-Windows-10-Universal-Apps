using System;
using System.Threading.Tasks;
using HowToBBQ.Common;
using Windows.ApplicationModel.Activation;
using System.Collections.ObjectModel;
using HowToBBQ.Models;

namespace HowToBBQ
{

    sealed partial class App : Common.BootStrapper
    {
        public static ObservableCollection<BBQRecipe> dbRecipes = null;
        public static bool IsDataLoaded = false;
        public App() : base()
        {
            this.InitializeComponent();
        }
     

        public override Task OnStartAsync(StartKind startKind, IActivatedEventArgs args)
        {
            this.NavigationService.Navigate(typeof(Views.MainPage));
            return Task.FromResult<object>(null);
        }
    }

}
