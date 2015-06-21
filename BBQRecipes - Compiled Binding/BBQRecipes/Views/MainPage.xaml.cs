using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using HowToBBQ.ViewModels;
using HowToBBQ.Models;
using Newtonsoft.Json;

namespace HowToBBQ.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
            DataContextChanged += (s, e) => ViewModel = DataContext as MainViewModel;
        }

        // strongly-typed view models enable x:bind
        public MainViewModel ViewModel { get; set; }

        private void Item_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var recipe = ((sender as Grid).DataContext) as BBQRecipe;
            string jsonString = JsonConvert.SerializeObject(recipe);
            (this.DataContext as MainViewModel).GotoRecipe(jsonString);

        }
    }
}
