// Author: Zack

// FavouritesManager class is responsible for creating a list of favourite recipes that the user can add to and remove from.
using System;
namespace RecipeFinder.BusinessLogic
{
    public class FavouritesManager
    {
        // Instantiates the favourites list that will be used to store favourite recipes
        private List<Recipe> _favouritesList = new List<Recipe>();
        public List<Recipe> FavouritesList
        {
            get
            {
                return _favouritesList;
            }
        }

        // Provides a method to add recipes to the list
        public void AddFavourite(Recipe recipe)
        {
            _favouritesList.Add(recipe);
        }

        // Provides a method to add recipes to the list
        public void RemoveFavorite(Recipe selectedRecipe)
        {
            // tempList creates a new list and populates it with information from favourites list
            List<Recipe> tempList = new List<Recipe>(_favouritesList);

            // Traverses through list and finds the selected recipe parameter, and removes it from the actual list
            foreach (Recipe r in tempList)
            {
                if (r == selectedRecipe)
                    _favouritesList.Remove(selectedRecipe);
            }
        }
    }
}

