//Author: Patience Gleaves
//StudentID:991711719
//Allows the user to select a recipe from a listview and then go to the view recipe page, or go back to the previous page(homepage).

using RecipeFinder.BusinessLogic;
namespace RecipeFinder.Pages;

public partial class RecipeManagerPage : ContentPage
{
    //setting up field variables and properties to pass along information of both the selected user and the recipe they selected.
    private User _passedUser;

    public User PassedUser { get { return _passedUser; } }

    private Recipe _selectedRecipe;

    //Using the method OnPropertyChanged so that the listview understands which recipe has been selected and has been passed on to the view recipe page.
    public Recipe SelectedRecipe
    {
        get
        {
            return _selectedRecipe;
        }
        set
        {
            if (_selectedRecipe == value)
                return;
            _selectedRecipe = value;
            OnPropertyChanged();
        }
    }


    public RecipeManagerPage(User passedUser)
    {
        InitializeComponent();
        _passedUser = passedUser;
        //Setting up binding context.
        BindingContext = this;

    }

    void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        //Takes you back to the previous page (homepage)

        Navigation.PopAsync();
    }

    void ViewRecipeButton_Clicked(System.Object sender, System.EventArgs e)
    {
        //Creating an instance of View Recipe page and passing along the passed user as well as the recipe they selected in the listview. Then taking them to the view recipe page

        Console.WriteLine(SelectedRecipe);
        ViewRecipePage viewRecipePage = new ViewRecipePage(_passedUser, _selectedRecipe);
        Navigation.PushAsync(viewRecipePage);

    }

}