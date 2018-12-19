using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace TwoListViews
{
    public class RecipeViewModel : INotifyPropertyChanged
    {
        Recipe theModel;
        public RecipeViewModel()
        {
            theModel = new Recipe
            {
                Directions = new List<string>
                {
                    "This","is","a","list","of", "directions"
                },
                Ingredients = new List<string> {
                    "This","is","a","list","of","ingredients"
                }
            };

            TheListSource = new ObservableCollection<string>(theModel.Directions);

            // Setting as true, even though the Directions are in the list, because it's about to be flipped
            canShowDirections = true;

            ShowIngredientsCommand = new Command(() =>
            {
                TheListSource = new ObservableCollection<string>(theModel.Ingredients);
                UpdateVisualState();
            },
            () => !canShowDirections);

            ShowDirectionsCommand = new Command(() =>
            {
                TheListSource = new ObservableCollection<string>(theModel.Directions);
                UpdateVisualState();
            },
            () => canShowDirections);

            // The canShowDirections gets flipped here
            UpdateVisualState();
        }

        ObservableCollection<string> thelistsource = new ObservableCollection<string>();
        public ObservableCollection<string> TheListSource
        {
            get => thelistsource;
            set
            {
                thelistsource = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TheListSource)));
            }
        }

        bool canShowDirections;

        public ICommand ShowIngredientsCommand { get; }
        public ICommand ShowDirectionsCommand { get; }

        void UpdateVisualState()
        {
            canShowDirections = !canShowDirections;
            ((Command)ShowIngredientsCommand).ChangeCanExecute();
            ((Command)ShowDirectionsCommand).ChangeCanExecute();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
