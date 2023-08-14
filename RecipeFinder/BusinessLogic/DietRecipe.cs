//Author: Patience Gleaves
//StudentID:991711719
//Creates boolean field variables to denote whether a recipe is a part of a specific dietary requirement i.e. Vegetarian and Vegan.

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

        // Due to csvhelper, there is no need for a class constructor. The serialization and deserialization is handled by the csv helper package.

        //public DietRecipe(string recipeDesc, string recipeName, string recipeImage, string recipeInstructions, bool isVegetarian, bool isVegan, bool isDairyFree)
        //    : base(recipeDesc, recipeName, recipeImage, recipeInstructions)
        //{
        //    _isVegetarian = isVegetarian;
        //    _isVegan = isVegan;
        //    _isDairyFree = isDairyFree;
        //}
    }
}

