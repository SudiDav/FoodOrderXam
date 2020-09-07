using FoodOrderXam.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodOrderXam.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductDetailsView : ContentPage
    {
        public ProductDetailsView(FoodItem foodItem)
        {
            InitializeComponent();
        }
    }
}