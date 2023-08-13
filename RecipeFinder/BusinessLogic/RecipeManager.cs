using System;
using CsvHelper;
using CsvHelper.Configuration;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Linq;

namespace RecipeFinder.BusinessLogic
{
    public class RecipeManager
    {
        private List<Recipe> _recipeList = new List<Recipe>();
        public List<Recipe> RecipeList { get { return _recipeList; } }

        public RecipeManager()
        {

            AddRecipe(new Recipe
            {
                RecipeName = "Spaghetti Carbonara",
                RecipeDesc = "Classic Italian comfort food, this creamy pasta dish features eggs, cheese, pancetta, and black pepper for a quick and satisfying meal.",
                RecipeImage = "spaghetticarbonara.png",
                RecipeInstructions = "Ingredients:\n  - 8 oz spaghetti\n   - 3 large eggs\n   - 4 oz pancetta or bacon\n   - 1 cup Pecorino Romano cheese\n   - Freshly ground black pepper\n\nInstructions:\n1.\tCook spaghetti according to package instructions. Reserve some pasta water.\n2.\tIn a bowl, whisk eggs, grated Pecorino Romano, and black pepper.\n3.\tIn a skillet, cook pancetta until crispy. Remove from heat.\n4.\tMix cooked pasta with egg mixture, adding a bit of pasta water to create a creamy sauce.\n5.\tToss in cooked pancetta and serve with additional cheese and black pepper.\n",
            });
            AddRecipe(new Recipe
            {
                RecipeName = "Chicken Tikka Masala",
                RecipeDesc = "Tender chicken pieces marinated in aromatic spices, grilled, and then simmered in a rich tomato-based sauce, perfect with steamed rice or naan.",
                RecipeImage = "chickentikkamasala.png",
                RecipeInstructions = "Ingredients:\n   - 1 lb chicken breasts\n   - 1/2 cup yogurt\n   - 1 tsp cumin\n   - 1 tsp coriander\n   - 1/2 tsp turmeric\n   - 1 tsp garam masala\n   - 1/2 tsp paprika\n   - 1 cup tomato sauce\n   - 1/2 cup heavy cream\n\nInstructions:\n1.\tMarinate chicken in yogurt, spices, and a bit of oil for at least 30 minutes.\n2.\tGrill or cook chicken until done, then cut into pieces.\n3.\tIn a saucepan, heat oil, add spices, and sauté for a minute.\n4.\tAdd tomato sauce, cream, and cooked chicken. Simmer for 10-15 minutes.\n5.\tServe with rice or naan.\n"
            });

            AddRecipe(new DietRecipe
            {
                RecipeName = "Caprese Salad",
                RecipeDesc = "A refreshing and simple appetizer made with fresh tomatoes, mozzarella, basil leaves, drizzled with balsamic glaze, capturing the flavors of summer.",
                RecipeImage = "capresesalad.png",
                RecipeInstructions = "Ingredients:\n   - 2 large tomatoes\n   - 8 oz fresh mozzarella cheese\n   - Handful of fresh basil leaves\n   - Balsamic glaze\n   - Salt and pepper\n\nInstructions:\n1.\tSlice tomatoes and mozzarella into rounds.\n2.\tArrange tomato and mozzarella slices on a plate, alternating.\n3.\tTuck fresh basil leaves between slices.\n4.\tDrizzle with balsamic glaze, olive oil, and sprinkle with salt and pepper.\n\n",
                IsVegetarian = true,
                IsVegan = false
            });

            AddRecipe(new Recipe
            {
                RecipeName = "Beef Stir-Fry",
                RecipeDesc = "Quick and versatile, this dish features thinly sliced beef sautéed with colorful vegetables in a savory soy-based sauce, served over steamed rice.",
                RecipeImage = "beefstirfry.png",
                RecipeInstructions = "Ingredients:\n   - 1/2 lb thinly sliced beef\n   - 2 cups assorted vegetables\n   - 3 tbsp soy sauce\n   - 2 cloves garlic\n   - 1 tsp grated ginger\n   - 1 tbsp sesame oil\n\nInstructions:\n1.\tHeat oil in a skillet. Add garlic and ginger, then stir-fry beef until browned.\n2.\tRemove beef and add vegetables. Stir-fry until tender-crisp.\n3.\tMix soy sauce and a bit of water, add to skillet along with beef.\n4.\tToss everything together and serve over cooked rice.\n\n"
            });

            AddRecipe(new DietRecipe
            {
                RecipeName = "Chocolate Chip Cookies",
                RecipeDesc = "Homemade cookies with a crispy edge and chewy center, loaded with chocolate chips for a sweet treat that's hard to resist.",
                RecipeImage = "chocolatechipcookies.png",
                RecipeInstructions = "Ingredients:\n   - 2 1/4 cups all-purpose flour\n   - 1 cup unsalted butter\n   - 3/4 cup brown sugar\n   - 3/4 cup white sugar\n   - 2 cups chocolate chips\n\nInstructions:\n1.\tCream butter and sugars until light. Add eggs and vanilla.\n2.\tMix in flour, baking soda, and salt. Stir in chocolate chips.\n3.\tDrop spoonfuls of dough onto a baking sheet.\n4.\tBake in a preheated oven at 375°F (190°C) for about 10-12 minutes.\n",
                IsVegetarian = true,
                IsVegan = true
            });
       

            AddRecipe(new DietRecipe
            {
                RecipeName = "Vegetable Curry",
                RecipeDesc = "A hearty and flavorful vegan dish, combining various vegetables and aromatic spices in a coconut milk or tomato-based sauce, best served with rice or bread.",
                RecipeImage = "vegetablecurry.png",
                RecipeInstructions = "Ingredients:\n   - Assorted vegetables (potatoes, carrots, peas, etc.)\n   - 1 onion\n   - 2 cloves garlic\n   - 1 can coconut milk or 1 cup tomato sauce\n   - Curry spices (1 tsp turmeric, 1 tsp cumin, 1 tsp coriander, 1 tsp garam masala)\n\nInstructions:\n1.\tSauté onion and garlic in oil until soft.\n2.\tAdd curry spices and cook briefly.\n3.\tAdd vegetables and cook until tender.\n4.\tPour in coconut milk or tomato sauce. Simmer until flavors meld.\n5.\tServe over rice or with bread.\n",
                IsVegetarian = true,
                IsVegan = true
            }) ;

            AddRecipe(new Recipe
            {
                RecipeName = "Homestyle Chili",
                RecipeDesc = "A comforting one-pot meal, featuring ground meat, beans, tomatoes, and chili spices, perfect for warming up on a cold day.",
                RecipeImage = "homestylechili.png",
                RecipeInstructions = "Ingredients:\n   - 1 lb ground beef\n   - 1 can kidney beans (15 oz)\n   - 1 can diced tomatoes (14 oz)\n   - 2 tbsp chili powder\n   - 1 tsp cumin\n   - 1 onion\n   - 2 cloves garlic\n\nInstructions:\n1.\tIn a pot, brown ground beef with chopped onion and garlic.\n2.\tAdd chili powder, cumin, and diced tomatoes.\n3.\tPour in beef broth and simmer for 20-30 minutes.\n4.\tStir in drained kidney beans and heat through.\n\n"
            });

            AddRecipe(new DietRecipe
            {
                RecipeName = "Ratatouille",
                RecipeDesc = "A French vegetable stew made with eggplant, zucchini, bell peppers, and tomatoes, simmered with herbs for a hearty and aromatic dish.",
                RecipeImage = "ratatouille.png",
                RecipeInstructions = "Ingredients:\n    - 1 eggplant\n    - 2 zucchinis\n    - 1 red bell pepper\n    - 1 yellow bell pepper\n    - 2 tomatoes\n    - Fresh herbs (thyme, basil)\n\nInstructions:\n1.\tSlice eggplant, zucchini, and bell peppers.\n2.\tLayer sliced vegetables in a baking dish.\n3.\tTop with diced tomatoes, garlic, and herbs.\n4.\tBake at 375°F (190°C) for about 45 minutes.\n\n",
                IsVegetarian = true,
                IsVegan = true
            });

            AddRecipe(new DietRecipe
            {
                RecipeName = "Blueberry Pancakes",
                RecipeDesc = "Fluffy pancakes studded with fresh blueberries, served with maple syrup for a delightful breakfast treat.",
                RecipeImage = "blueberrypancakes.png",
                RecipeInstructions = "Ingredients:\n    - Pancake mix or ingredients (enough for 8-10 pancakes)\n    - 1 cup blueberries\n    - 2 eggs\n    - 1 cup milk\n    - 2 tbsp butter\n\nInstructions:\n1.\tPrepare pancake batter according to package instructions.\n2.\tGently fold in blueberries.\n3.\tCook pancakes on a griddle until bubbles form, then flip and cook until golden.\n\n",
                IsVegetarian = true,
                IsVegan = false
            });

            // Save recipes to file
            SaveRecipesToFile("recipes.csv");

            // Load recipes from file
            LoadRecipesFromFile("recipes.csv");



            // Get loaded recipes
        }

        public void AddRecipe(Recipe r)
        {
            _recipeList.Add(r);
        }

        public void RemoveRecipe(Recipe r)
        {
            _recipeList.Remove(r);
        }

        // Information gathered from non in-class materials!
        // https://joshclose.github.io/CsvHelper/
        // https://www.youtube.com/watch?v=IT8bT3NsaRg
        // 


        public void SaveRecipesToFile(string filePath)
        {
            // Creates a csv file to write recipes to
            using(var recipeWriter = new StreamWriter(filePath))
            {
                // Creates a new instance of the csv configurator
                // CultureInfo refers to the convention and style of the csv, where I have choesen "InvariantCulture"
                using (var recipeCsv = new CsvWriter(recipeWriter, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    // Retrieves information from _recipe list and writes it to the create csv file
                    recipeCsv.WriteRecords(_recipeList);
                }
            }
        }

        // This method will supply the _recipeList with csv information when called in the constructor
        public void LoadRecipesFromFile(string filePath)
        {
            //// Open stream reader to read the csv file
            //using (var recipeReader = new StreamReader(filePath))
            //{
            //    using (var recipeCsv = new CsvReader(recipeReader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            //    {
            //        _recipeList = recipeCsv.GetRecords<Recipe>().ToList();
            //    }
            //}

            try
            {
                using (var recipeReader = new StreamReader(filePath))
                {
                    using (var recipeCsv = new CsvReader(recipeReader, new CsvConfiguration(CultureInfo.InvariantCulture)))
                    {
                   
                        _recipeList = recipeCsv.GetRecords<Recipe>().ToList();
                    }
                }
            }
            catch (CsvHelper.TypeConversion.TypeConverterException ex)
            {
                // Handle the exception and examine ex.Message and ex.InnerException
                Console.WriteLine("TypeConverterException: " + ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner Exception: " + ex.InnerException.Message);
                }
                // Handle the exception further as needed
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                Console.WriteLine("Exception: " + ex.Message);
            }

        }



    }
}

