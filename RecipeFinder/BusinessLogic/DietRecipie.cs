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


        public DietRecipe(string recipeDesc, string recipeName, string recipeImage, string recipeInstructions, bool isVegetarian, bool isVegan, bool isDairyFree)
            : base(recipeDesc, recipeName, recipeImage, recipeInstructions)
        {
            _isVegetarian = isVegetarian;
            _isVegan = isVegan;
            _isDairyFree = isDairyFree;
        }
    }
}

