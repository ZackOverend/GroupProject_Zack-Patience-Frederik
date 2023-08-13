namespace RecipeFinder.Pages;
using RecipeFinder.BusinessLogic;
public partial class AddUserPage : ContentPage
{
    //Frederik

    //AddUserPage has multiple entries needed from user to create a new user. Upon clicking the button, user is taken back to EditUserPage
    //and the list is updated to reflect the new user



    //passed instance of UserManager for databinding
    //stored from the constructor
    private UserManager _passedUserManager;

    public AddUserPage(UserManager passedUserManager)
    {
        InitializeComponent();
        _passedUserManager = passedUserManager;
    }
    //takes the xaml entries as the 3 parameters needed and creates an Object
    void AddUserButton_Clicked(System.Object sender, System.EventArgs e)
    {
        string name = NameEntry.Text;
        string email = EmailEntry.Text;
        string phoneNumber = PhoneNumberEntry.Text;

        _passedUserManager.AddUser(name, email, phoneNumber);

        Navigation.PopAsync();

    }
    //back button
    void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PopAsync();
    }

}
