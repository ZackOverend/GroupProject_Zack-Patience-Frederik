namespace RecipeFinder.Pages;
using RecipeFinder.BusinessLogic;
public partial class UserPage : ContentPage
{

    UserManager _userManager = new UserManager();

    public UserManager UserManager { get { return _userManager; } }




    public UserPage()
    {
        InitializeComponent();
        _userManager.AddUser("Frederik", "frederik@dahlhansen.com", "416-200-0204");
        _userManager.AddUser("Zackary", "zackary@overend.com", "905-515-1185");
        _userManager.AddUser("Patience", "patience@gleaves.com", "905-515-1100");

        BindingContext = this;

    }



    void EditUsersButton_Clicked(System.Object sender, System.EventArgs e)
    {
        UserEditPage usereditpage = new UserEditPage(UserManager);
        Navigation.PushAsync(usereditpage);
    }

    void ContinueButton_Clicked(System.Object sender, System.EventArgs e)
    {
        RecipeManagerPage recipeManagerPage = new RecipeManagerPage();
        Navigation.PushAsync(recipeManagerPage);
    }
}