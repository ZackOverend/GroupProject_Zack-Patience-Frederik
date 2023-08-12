using System;
namespace RecipeFinder.BusinessLogic
{
    public class Recipe
    {

        private string _recipeDesc;
        private string _recipeName;
        private string _recipeImage;
        private string _recipeInstructions;

        public string RecipeDesc
        {
            get
            {
                return _recipeDesc;
            }
            set
            {
                _recipeDesc = value;
            }
        }
        public string RecipeName
        {
            get
            {
                return _recipeName;
            }
            set
            {
                _recipeName = value;
            }
        }
        public string RecipeImage
        {
            get
            {
                return _recipeImage;
            }
            set
            {
                _recipeImage = value;
            }
        }
        public string RecipeInstructions
        {
            get
            {
                return _recipeInstructions;
            }
            set
            {
                _recipeInstructions = value;
            }
        }





        public Recipe(string recipeName, string recipeDesc, string recipeImage, string recipeInstructions)
        {

            RecipeName = recipeName;
            RecipeDesc = recipeDesc;
            RecipeImage = recipeImage;
            RecipeInstructions = recipeInstructions;
        }


    }
}

