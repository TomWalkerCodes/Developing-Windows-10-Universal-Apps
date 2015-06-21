using HowToBBQ.ViewModels;
using Windows.UI.Xaml.Controls;


namespace HowToBBQ.Views
{
    public sealed partial class RecipePage : Page
    {
        public RecipePage()
        {
            this.InitializeComponent();
            NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
            DataContextChanged += (s, e) => ViewModel = DataContext as RecipeViewModel;
        }

        // strongly-typed view models enable x:bind
        public RecipeViewModel ViewModel { get; set; }

    }
}
