using System;
namespace RecipeFinder.BusinessLogic;

public class User
{
    private int _userId;
    private string _name;
    private string _email;
    private string _phoneNumber;

    public int UserId
    {
        get
        {
            return _userId;
        }
    }

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

    public User(int userId, string name, string email, string phoneNumber)
    {
        _userId = userId;
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
    }

    public string GetText()
    {
        return $"ID: {UserId}       Name: {Name} \nEmail: {Email}      Phone Number {PhoneNumber}"; ;
    }

    public string UserText
    {
        get { return GetText(); }
    }
}


