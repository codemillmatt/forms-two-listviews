using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TwoListViews
{
    public partial class MainPage : ContentPage
    {
        //Recipe newRecipe;

        public MainPage()
        {
            InitializeComponent();

            //newRecipe = new Recipe
            //{
            //    Directions = new List<string>
            //    {
            //        "This","is","a","list","of", "directions"
            //    },
            //    Ingredients = new List<string> {
            //        "This","is","a","list","of","ingredients"
            //    }
            //};

            //theList.ItemsSource = newRecipe.Directions;

            var vm = new RecipeViewModel();
            BindingContext = vm;

            //directionsButton.IsEnabled = false;
            //ingredientsButton.IsEnabled = true;
        }

        //protected void Ingredients_Clicked(object sender, EventArgs e)
        //{
        //    //theList.ItemsSource = newRecipe.Ingredients;

        //    directionsButton.IsEnabled = true;
        //    ingredientsButton.IsEnabled = false;
        //}

        //protected void Directions_Clicked(object sender, EventArgs e)
        //{
        //    //theList.ItemsSource = newRecipe.Directions;

        //    directionsButton.IsEnabled = false;
        //    ingredientsButton.IsEnabled = true;
        //}
    }
}
