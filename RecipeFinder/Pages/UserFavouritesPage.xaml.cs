// Author: Zack

// This page allows the user to view their favourites, and remove them if need be

namespace RecipeFinder.Pages;
using RecipeFinder.BusinessLogic;

public partial class UserFavouritesPage : ContentPage
{

    // Creates a property for PassedUser for the databinding
    // Recieved from the constructor
    private User _passedUser;
    public User PassedUser { get { return _passedUser; } }

    // Retrieves the selected favourite recipe
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

    // Recieves the passedUser from HomePage
    public UserFavouritesPage(User passedUser)
    {
        // Passed user depends on what user is selected and whose account is in use
        InitializeComponent();
        _passedUser = passedUser;
        BindingContext = this;
    }


    // Allows user to remove their favourites, depending on which favourite is selected
    void RemoveFavouriteBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        PassedUser.UserFavourites.RemoveFavorite(_selectedFavourite);
        Navigation.PopAsync();
    }

    // Navigates back to HomePage
    void BackBtnFavourites_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PopAsync();
    }



}
