using System;
namespace RecipeFinder.BusinessLogic;

	public class UserManager
	{
        private int _userId = 1000;

        private List<User> _userList = new List<User>();

        public List<User> UserList { get { return _userList; } }

        private FavouritesManager _userFavourites;
        public FavouritesManager UserFavourites { get { return _userFavourites; } }

    public UserManager()
        {

        }

        public void AddUser(string name, string email, string phoneNumber)
        {
        // Increment the user Id
        _userId++;

        // Create an instance of Favourites Manager
        FavouritesManager userFavourites = new FavouritesManager();
        RecipeManager recipeManager = new RecipeManager();

        User user = new User(_userId, name, email, phoneNumber, userFavourites, recipeManager);

        _userList.Add(user);
    }

        public void RemoveUser(User selectedUser)
        {
            List<User> tempList = new List<User>(_userList);

            foreach (User u in tempList)
            {
                if (u == selectedUser)
                    _userList.Remove(selectedUser);
            }
    }
}

