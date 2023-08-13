using System;
namespace RecipeFinder.BusinessLogic
{
    public class DietRecipe : Recipe
    {

        private bool _isVegetarian;

        private bool _isVegan;

        public bool IsVegetarian
        {
            get
            {
                return _isVegetarian;
            }
            set
            {
                _isVegetarian = value;
            }
        }
        public bool IsVegan
        {
            get
            {
                return _isVegan;
            }
            set
            {
                _isVegan = value;
            }
        }


        //public DietRecipe(string recipeDesc, string recipeName, string recipeImage, string recipeInstructions, bool isVegetarian, bool isVegan, bool isDairyFree)
        //    : base(recipeDesc, recipeName, recipeImage, recipeInstructions)
        //{
        //    _isVegetarian = isVegetarian;
        //    _isVegan = isVegan;
        //    _isDairyFree = isDairyFree;
        //}
    }
}

