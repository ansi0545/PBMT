namespace Personal_budget_management_tool.Managers
{
    internal class UserManager
    {
        private List<User> Users { get; set; } = new List<User>();
        private DataManager dataManager;

        public UserManager(DataManager dataManager)
        {
            this.dataManager = dataManager ?? throw new ArgumentNullException(nameof(dataManager));
            LoadUsers();
        }

        public void LoadUsers()
        {
            Users = dataManager.Users;
        }

        public void SaveUsers()
        {
            dataManager.Users = Users;
        }


        public User RegisterUser(string username, string password)
        {
            if (GetUser(username) != null)
            {
                throw new Exception($"User with username {username} already exists.");
            }
            User newUser = new User(username, password);
            Users.Add(newUser);
            try
            {
                SaveUsers();
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while saving data: {ex.Message}");
            }
            return newUser;
        }

        public bool ValidateUser(string username, string password)
        {
            User user = GetUser(username);
            if (user != null && user.CheckPassword(password))
            {
                Console.WriteLine($"User with username {username} was validated successfully.");
                return true;
            }
            else
            {
                Console.WriteLine($"Failed to validate user with username {username}.");
                return false;
            }
        }

        public User GetUser(string username)
        {
            User user = Users.FirstOrDefault(u => u.Username == username);
            if (user != null)
            {
                Console.WriteLine($"User with username {username} was found.");
            }
            else
            {
                Console.WriteLine($"User with username {username} was not found.");
            }
            return user;
        }

        public User LoginUser(string username, string password)
        {
            User user = GetUser(username);
            if (user != null && user.CheckPassword(password + user.Salt))
            {
                return user;
            }
            return null;
        }
    }
}
