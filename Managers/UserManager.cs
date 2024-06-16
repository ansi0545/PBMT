using System;
using System.Collections.Generic;
using System.Linq;

namespace Personal_budget_management_tool.Managers
{
    internal class UserManager
    {
        private List<User> Users { get; set; } = new List<User>();
        private DataManager dataManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserManager"/> class.
        /// </summary>
        /// <param name="dataManager">The data manager.</param>
        public UserManager(DataManager dataManager)
        {
            this.dataManager = dataManager ?? throw new ArgumentNullException(nameof(dataManager));
            LoadUsers();
        }

        /// <summary>
        /// Loads the users from the data manager.
        /// </summary>
        public void LoadUsers()
        {
            Users = dataManager.Users;
        }

        /// <summary>
        /// Saves the users to the data manager.
        /// </summary>
        public void SaveUsers()
        {
            dataManager.Users = Users;
        }

        /// <summary>
        /// Register a user in the system.
        /// </summary>
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

        /// <summary>
        /// Validates a user by checking if the provided username and password match the stored user credentials.
        /// </summary>
        /// <param name="username">The username of the user to validate.</param>
        /// <param name="password">The password of the user to validate.</param>
        /// <returns>True if the user is validated successfully, false otherwise.</returns>
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

        /// <summary>
        /// Gets a user in the system.
        /// </summary>
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

        /// <summary>
        /// Login a user in the system.
        /// </summary>
        public User LoginUser(string username, string password)
        {
            User user = GetUser(username);
            if (user != null && user.CheckPassword(password))
            {
                return user;
            }
            return null;
        }
    }
}
