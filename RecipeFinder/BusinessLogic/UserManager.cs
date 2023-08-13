using System;
namespace RecipeFinder.BusinessLogic;

    //Frederik

    //UserManager contains methods to add and remove users, as well as sets up lists for listview


	public class UserManager
	{
        private int _userId = 1000;

        private List<User> _userList = new List<User>();

        public List<User> UserList { get { return _userList; } }

        private FavouritesManager _userFavourites;
        public FavouritesManager UserFavourites { get { return _userFavourites; } }

        //Method to add user with parameters, as well as making sure the id is always incremented, creating unique id's
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
        //Creates method that cycles through each user and deletes if a matching one is found compared to the selected one. 
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

