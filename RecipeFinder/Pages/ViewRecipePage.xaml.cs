using RecipeFinder.BusinessLogic;
namespace RecipeFinder.Pages;

public partial class ViewRecipePage : ContentPage
{
    private User _passedUser;
    private Recipe _passedRecipe;

    public User PassedUser { get { return _passedUser; } }
    public Recipe PassedRecipe { get { return _passedRecipe; } }


    public ViewRecipePage(User passedUser, Recipe passedRecipe)
    {
        InitializeComponent();
        _passedUser = passedUser;
        _passedRecipe = passedRecipe;
        BindingContext = this;
    }

    void AddToFavourites_Clicked(System.Object sender, System.EventArgs e)
    {
        //Adding selected recipe to the list of favourites
        PassedUser.UserFavourites.AddFavourite(PassedRecipe);

        Navigation.PopAsync();
    }

    void GoBackBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PopAsync();
    }
}

