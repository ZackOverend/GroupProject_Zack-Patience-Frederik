namespace RecipeFinder.Pages;
using RecipeFinder.BusinessLogic;

public partial class UserFavouritesPage : ContentPage
{
    
    private User _passedUser;

    public User PassedUser { get { return _passedUser; } }

    private Recipe _selectedFavourite;

    public Recipe SelectedFavourite
    {
        get
        {
            return _selectedFavourite;
        }
        set
        {
            if (_selectedFavourite == value)
                return;
            _selectedFavourite = value;
            OnPropertyChanged();
        }
    }
    public UserFavouritesPage(User passedUser)
    {
        InitializeComponent();
        _passedUser = passedUser;
        BindingContext = this;
    }



    void RemoveFavouriteBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        PassedUser.UserFavourites.RemoveFavorite(_selectedFavourite);
        Navigation.PopAsync();
    }

    void BackBtnFavourites_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PopAsync();
    }



}
