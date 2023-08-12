using System;
namespace RecipeFinder.BusinessLogic
{
    public class FavouritesManager
    {
        List<Recipe> _favouritesList = new List<Recipe>();



        public List<Recipe> FavouritesList
        {
            get
            {
                return _favouritesList;
            }
        }


        public FavouritesManager()
        {

        }

        public void AddFavourite(Recipe recipe)
        {
            _favouritesList.Add(recipe);
            Console.WriteLine($"Adding Recipe: {recipe.RecipeName}");
        }

        public void RemoveFavorite(Recipe selectedRecipe)
        {
            List<Recipe> tempList = new List<Recipe>(_favouritesList);

            foreach (Recipe r in tempList)
            {
                if (r == selectedRecipe)
                    _favouritesList.Remove(selectedRecipe);
            }
        }
    }
}

