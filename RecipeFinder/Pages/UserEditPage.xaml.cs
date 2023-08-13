namespace RecipeFinder.Pages;
using RecipeFinder.BusinessLogic;
public partial class UserEditPage : ContentPage
{
    //Frederik

    //Hub for adding and deleting a user. User picks button to navigate menus and instances of the new pages are created, upon removal/addition, the list is updated

    private UserManager _passedUserManager;

    public UserManager PassedUserManager { get { return _passedUserManager; } }

    private User _selectedUser;

    //setting up property for selected user and using OnPropertyChanged() to denote which item is selected in the listview
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
    //setting up bindingcontext
    public UserEditPage(UserManager passedUserManager)
    {
        InitializeComponent();
        _passedUserManager = passedUserManager;
        BindingContext = this;
    }
    //navigation buttons
    void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PopAsync();
    }

    void RemoveUserButton_Clicked(System.Object sender, System.EventArgs e)
    {
        _passedUserManager.RemoveUser(_selectedUser);

        Navigation.PopAsync();
    }
    //method used to override the current listview and replace it with the new information
    protected override void OnAppearing()
    {
        base.OnAppearing();
        UserEditListView.ItemsSource = null;
        UserEditListView.ItemsSource = PassedUserManager.UserList;
    }
    //creates instance of AddUserPage
    void AddUserButton_Clicked(System.Object sender, System.EventArgs e)
    {
        AddUserPage addUserPage = new AddUserPage(_passedUserManager);
        Navigation.PushAsync(addUserPage);
    }
}
