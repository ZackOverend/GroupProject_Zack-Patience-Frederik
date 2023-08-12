namespace RecipeFinder.Pages;
using RecipeFinder.BusinessLogic;
public partial class AddUserPage : ContentPage
{

    private UserManager _passedUserManager;

    public AddUserPage(UserManager passedUserManager)
    {
        InitializeComponent();
        _passedUserManager = passedUserManager;
    }

    void AddUserButton_Clicked(System.Object sender, System.EventArgs e)
    {
        string name = NameEntry.Text;
        string email = EmailEntry.Text;
        string phoneNumber = PhoneNumberEntry.Text;

        _passedUserManager.AddUser(name, email, phoneNumber);

        Navigation.PopAsync();

    }

    void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PopAsync();
    }

}
