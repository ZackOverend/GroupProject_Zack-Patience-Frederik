//Author: Patience Gleaves
//StudentID:991711719
//This class creates the information needed for our recipes to be added to reipes.csv and subsequently the recipe list.


using System;
namespace RecipeFinder.BusinessLogic
{
    public class Recipe
    {
        //Since recipes are hardcoded, no need for error handeling at this stage.

        private string _recipeName;
        private string _recipeDesc;
        private string _recipeImage;
        private string _recipeInstructions;

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

       

        // Due to csvhelper, there is no need for a class constructor. The serialization and deserialization is handled by the csv helper package.

        //public Recipe(string rname, string recipeDesc, string recipeImage, string recipeInstructions)
        //{

        //    RecipeName = rname;
        //    RecipeDesc = recipeDesc;
        //    RecipeImage = recipeImage;
        //    RecipeInstructions = recipeInstructions;
        //}


    }
}

