using System;
namespace RecipeFinder.BusinessLogic
{
    public class Recipe
    { 
        private int _recipeId;
        private string _recipeDesc;
        private string _recipeName;
        private string _recipeImage;
        public int RecipeId { get { return _recipeId; } }

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


        public Recipe(int recipeId, string recipeDesc, string recipeName, string recipeImage)
        {
            _recipeId = recipeId;
            RecipeDesc = recipeDesc;
            RecipeName = recipeName;
            RecipeImage = recipeImage;

        }
    }
}

