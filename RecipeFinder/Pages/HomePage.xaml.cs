using RecipeFinder.BusinessLogic;

namespace RecipeFinder.Pages;

public partial class HomePage : ContentPage
{
    private User _selectedUser;
    public User SelectedUser { get { return _selectedUser; } }



    public HomePage(User selectedUser)
    {

        _selectedUser = selectedUser;
        InitializeComponent();
        BindingContext = this;



    }

    void GoBackBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PopAsync();
    }



    void FavoritesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        UserFavouritesPage userFavouritesPage = new UserFavouritesPage(_selectedUser);
        Navigation.PushAsync(userFavouritesPage);
    }

    void RecipesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        RecipeManagerPage recipeManagerPage = new RecipeManagerPage(_selectedUser);
        Navigation.PushAsync(recipeManagerPage);
    }
}
