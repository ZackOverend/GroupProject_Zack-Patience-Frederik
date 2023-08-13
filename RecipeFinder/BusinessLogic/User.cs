using System;
namespace RecipeFinder.BusinessLogic;

//Frederik

//Class used as foundation for adding a user as well as setting up their recipe and favourites list, so each person has their individual list.

public class User
{

    private int _userId;
    private string _name;
    private string _email;
    private string _phoneNumber;
    private FavouritesManager _userFavourites = new FavouritesManager();
    private RecipeManager _recipeManager = new RecipeManager();

    public FavouritesManager UserFavourites { get { return _userFavourites; } }
    public RecipeManager RecipeManager { get { return _recipeManager; } }

    //setting up properties
    public int UserId
    {
        get
        {
            return _userId;
        }
        set
        {
            _userId = value;
        }
    }
    //no empty strings
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception("Cannot leave empty string");
            _name = value;
        }
    }
    //making sure all emails contain an @ sign
    public string Email
    {
        get
        {
            return _email;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception("Cannot leave empty string");
            if (value.Contains("@"))
                _email = value;
            else
                throw new Exception("must be in email format");

        }
    }
    //no empty strings
    public string PhoneNumber
    {
        get
        {
            return _phoneNumber;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception("Cannot leave empty string");
            _phoneNumber = value;
        }
    }


    //setting up parameters for user

    public User(int userId, string name, string email, string phoneNumber, FavouritesManager userFavourites, RecipeManager recipeManager)
    {
        _userId = userId;
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
        _userFavourites = userFavourites;
        _recipeManager = recipeManager;
    }
    //method used to return all user information in a neat way, used for presenting the data using databinding in UserPage
    public string GetText()
    {
        return $"ID: {UserId}       Name: {Name} \nEmail: {Email}      Phone Number {PhoneNumber}"; ;
    }

    public string UserText
    {
        get { return GetText(); }
    }

    

}

