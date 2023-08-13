// Author: Zack

// View Recipe Page is responsible for displaying the information from the selected recipe on the previous page
// This page provides an image, along with all needed information
using RecipeFinder.BusinessLogic;
namespace RecipeFinder.Pages;

public partial class ViewRecipePage : ContentPage
{

    // Recieved from the constructor
    private User _passedUser;
    private Recipe _passedRecipe;

    public User PassedUser { get { return _passedUser; } }
    public Recipe PassedRecipe { get { return _passedRecipe; } }

    // Constructor recieves information from the RecipeManager Page
    public ViewRecipePage(User passedUser, Recipe passedRecipe)
    {
        InitializeComponent();
        _passedUser = passedUser;
        _passedRecipe = passedRecipe;

        BindingContext = this;
    }

    // Adds the passed revipe to the favourites left
    void AddToFavourites_Clicked(System.Object sender, System.EventArgs e)
    {
        //Adding selected recipe to the list of favourites
        PassedUser.UserFavourites.AddFavourite(PassedRecipe);

        Navigation.PopAsync();
    }

    // Goes back to the 
    void GoBackBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PopAsync();
    }
}

