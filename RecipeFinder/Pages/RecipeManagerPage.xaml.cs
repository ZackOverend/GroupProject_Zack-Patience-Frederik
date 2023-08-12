using RecipeFinder.BusinessLogic;
namespace RecipeFinder.Pages;

public partial class RecipeManagerPage : ContentPage
{
    private User _passedUser;

    public User PassedUser { get { return _passedUser; } }

    private Recipe _selectedRecipe;

    public Recipe SelectedRecipe
    {
        get
        {
            return _selectedRecipe;
        }
        set
        {
            if (_selectedRecipe == value)
                return;
            _selectedRecipe = value;
            OnPropertyChanged();
        }
    }


    public RecipeManagerPage(User passedUser)
    {
        InitializeComponent();
        _passedUser = passedUser;

        BindingContext = this;

    }

    void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PopAsync();
    }

    void ViewRecipeButton_Clicked(System.Object sender, System.EventArgs e)
    {
        Console.WriteLine(SelectedRecipe);
        ViewRecipePage viewRecipePage = new ViewRecipePage(_passedUser, _selectedRecipe);
        Navigation.PushAsync(viewRecipePage);

    }

}