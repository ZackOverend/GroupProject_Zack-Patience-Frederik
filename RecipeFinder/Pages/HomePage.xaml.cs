//Author: Patience Gleaves
//StudentID:991711719
//Displays options for the selected user, and allows navigation to RecipeManagerPage, UserFavouritesPage, and previous page (UserPage).

using RecipeFinder.BusinessLogic;

namespace RecipeFinder.Pages;

public partial class HomePage : ContentPage
{
    //Selected user receives information from UserPage based on the user that was selected.

    private User _selectedUser;
    //creates a property to allow xaml to retreive the selected user's name and use it in the greeting.
    public User SelectedUser { get { return _selectedUser; } }



    public HomePage(User selectedUser)
    {

        _selectedUser = selectedUser;
        InitializeComponent();
        //setting up binding context
        BindingContext = this;



    }

    void GoBackBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        //Takes you back to the previous page (userpage)
        Navigation.PopAsync();
    }



    void FavoritesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        //passes along the selected user to the user favourites page.

        UserFavouritesPage userFavouritesPage = new UserFavouritesPage(_selectedUser);
        Navigation.PushAsync(userFavouritesPage);
    }

    void RecipesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        //passes along the selected user to the recipe manager page.

        RecipeManagerPage recipeManagerPage = new RecipeManagerPage(_selectedUser);
        Navigation.PushAsync(recipeManagerPage);
    }
}
