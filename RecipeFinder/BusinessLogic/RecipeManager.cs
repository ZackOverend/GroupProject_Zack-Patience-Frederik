using System;
namespace RecipeFinder.BusinessLogic
{
    public class RecipeManager
    {
        private List<Recipe> _recipeList = new List<Recipe>();
        public List<Recipe> RecipeList { get { return _recipeList; } }

        public RecipeManager()
        {
            _recipeList.Add(new Recipe("Spaghetti Carbonara", "Classic Italian comfort food, this creamy pasta dish features eggs, cheese, pancetta, and black pepper for a quick and satisfying meal.", "shrimpscampi.png", "- 8 oz spaghetti \n - 3 large eggs \n - 4 oz pancetta or bacon \n - 1 cup Pecorino Romano cheese \n - Freshly ground black pepper \n\n\n 1.	Cook spaghetti according to package instructions.Reserve some pasta water.\n 2.	In a bowl, whisk eggs, grated Pecorino Romano, and black pepper. \n 3.	In a skillet, cook pancetta until crispy. Remove from heat.\n 4.	Mix cooked pasta with egg mixture, adding a bit of pasta water to create a creamy sauce. \n 5.	Toss in cooked pancetta and serve with additional cheese and black pepper."));
            _recipeList.Add(new Recipe("r1", "r2", "r3", "r4"));
            _recipeList.Add(new Recipe("r1", "r2", "r3", "r4"));
            _recipeList.Add(new Recipe("r1", "r2", "r3", "r4"));
            _recipeList.Add(new Recipe("r1", "r2", "r3", "r4"));
            _recipeList.Add(new Recipe("r1", "r2", "r3", "r4"));
            _recipeList.Add(new Recipe("r1", "r2", "r3", "r4"));
            _recipeList.Add(new DietRecipe("d1", "d2", "d3", "d4", false, false, false));



        }


    }
}

