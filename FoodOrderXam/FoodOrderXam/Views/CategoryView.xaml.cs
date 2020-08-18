using FoodOrderXam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodOrderXam.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoryView : ContentPage
    {
        private Category _category;

        public CategoryView()
        {
            InitializeComponent();
        }

        public CategoryView(Category category)
        {
            _category = category;
        }

        private void ImageButton_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}