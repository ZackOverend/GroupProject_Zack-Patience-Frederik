using System;
namespace RecipeFinder.BusinessLogic;

	public class UserManager
	{
        private int _userId = 1000;

        private List<User> _userList = new List<User>();

        public List<User> UserList { get { return _userList; } }


        public UserManager()
        {

        }

        public void AddUser(string name, string email, string phoneNumber)
        {
            _userId++;
            User user = new User(_userId, name, email, phoneNumber);

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

