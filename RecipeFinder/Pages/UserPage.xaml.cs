namespace RecipeFinder.Pages;
using RecipeFinder.BusinessLogic;

public partial class UserPage : ContentPage
{

    UserManager _userManager = new UserManager();

    public UserManager UserManager { get { return _userManager; } }
    private User _selectedUser;


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
        UserEditPage userEditPage = new UserEditPage(UserManager);
        Navigation.PushAsync(userEditPage);
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        UserListView.ItemsSource = null;
        UserListView.ItemsSource = UserManager.UserList;
    }

    void ContinueButton_Clicked(System.Object sender, System.EventArgs e)
    {
        HomePage homePage = new HomePage(_selectedUser);
        Navigation.PushAsync(homePage);


    }
}
