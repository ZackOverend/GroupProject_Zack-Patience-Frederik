using System;
namespace RecipeFinder.BusinessLogic
{
    public class DietRecipe : Recipe
    {

        private bool _isVegetarian;

        private bool _isVegan;

        private bool _isDairyFree;

        public bool IsVegetarian
        {
            get
            {
                return _isVegetarian;
            }
        }
        public bool IsVegan
        {
            get
            {
                return _isVegan;
            }
        }

        public bool IsDairyFree
        {
            get
            {
                return _isDairyFree;
            }
        }


        public DietRecipe(int recipeId, string recipeDesc, string recipeName, string recipeImage, bool isVegetarian, bool isVegan, bool isDairyFree)
            : base(recipeId, recipeDesc, recipeName, recipeImage)
        {
            _isVegetarian = isVegetarian;
            _isVegan = isVegan;
            _isDairyFree = isDairyFree;
        }
    }
}

