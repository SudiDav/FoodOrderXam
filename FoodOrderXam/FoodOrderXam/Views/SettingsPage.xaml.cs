using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodOrderXam.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodOrderXam.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private async void ButtonCategories_Clicked(object sender, EventArgs e)
        {
            var addCategoriesData = new AddCategoryData();
            await addCategoriesData.AddCategoriesAsync();
        }

        private async void ButtonProducts_Clicked(object sender, EventArgs e)
        {
            var addPoductsData = new AddFoodItemData();
            await addPoductsData.AddFoodItemAsync();
        }
    }
}