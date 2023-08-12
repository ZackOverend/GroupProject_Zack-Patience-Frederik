namespace RecipeFinder.Pages;
using RecipeFinder.BusinessLogic;
public partial class UserEditPage : ContentPage
{
    private UserManager _passedUserManager;

    public UserManager PassedUserManager { get { return _passedUserManager; } }

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

    public UserEditPage(UserManager passedUserManager)
    {
        InitializeComponent();
        _passedUserManager = passedUserManager;
        BindingContext = this;
    }

    void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PopAsync();
    }

    void RemoveUserButton_Clicked(System.Object sender, System.EventArgs e)
    {
        _passedUserManager.RemoveUser(_selectedUser);

        Navigation.PopAsync();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        UserEditListView.ItemsSource = null;
        UserEditListView.ItemsSource = PassedUserManager.UserList;
    }
    void AddUserButton_Clicked(System.Object sender, System.EventArgs e)
    {
        AddUserPage addUserPage = new AddUserPage(_passedUserManager);
        Navigation.PushAsync(addUserPage);
    }
}
