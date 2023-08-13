namespace RecipeFinder.Pages;
using RecipeFinder.BusinessLogic;

public partial class UserPage : ContentPage
{
    //Frederik

    //Landing page showing the users available to take into the recipe menus.
    
    UserManager _userManager = new UserManager();

    public UserManager UserManager { get { return _userManager; } }
    private User _selectedUser;

    //property set up for selected user to return which user is selected in the listview
    public User SelectedUser
    {
        get
        {
            return _selectedUser;
        }
        set
        {
            if (_selectedUser == value)
                return;
            _selectedUser = value;
            OnPropertyChanged();
        }

        
    }


    //hardcoding 3 instances of user as a base for the application, with more being able to be added
    //setting up bindingcontext for the listview
    public UserPage()
    {
        InitializeComponent();
        _userManager.AddUser("Frederik", "frederik@dahlhansen.com", "416-200-0204");
        _userManager.AddUser("Zackary", "zackary@overend.com", "905-515-1185");
        _userManager.AddUser("Patience", "patience@gleaves.com", "905-515-1100");

        BindingContext = this;

    }
    //takes us to EditUserPage
    void EditUsersButton_Clicked(System.Object sender, System.EventArgs e)
    {
        UserEditPage userEditPage = new UserEditPage(UserManager);
        Navigation.PushAsync(userEditPage);
    }
    //method to override current list and replace it with the updated one.
    protected override void OnAppearing()
    {
        base.OnAppearing();
        UserListView.ItemsSource = null;
        UserListView.ItemsSource = UserManager.UserList;
    }
    //Button to take us to our main page once a user is selected
    void ContinueButton_Clicked(System.Object sender, System.EventArgs e)
    {
        HomePage homePage = new HomePage(_selectedUser);
        Navigation.PushAsync(homePage);


    }
}
