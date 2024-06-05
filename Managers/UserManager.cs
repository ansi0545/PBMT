using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_budget_management_tool.Managers
{
    internal class UserManager
    {
        //private List<User> Users { get; set; }
        private List<User> Users { get; set; } = new List<User>();
        private DataManager dataManager;


        public UserManager(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        
        public void LoadUsers()
        {
            dataManager.FilePath = "path/to/your/file.json";
            Users = dataManager.LoadData();
        }

        public void SaveUsers()
        {
            dataManager.SaveData(Users);
        }

        public User RegisterUser(string username, string password)
        {
            User newUser = new User(username, password);
            Users.Add(newUser);
            SaveUsers();
            return newUser;
        }

        public User LoginUser(string username, string password)
        {
            foreach (User user in Users)
            {
                if (user.Username == username && user.CheckPassword(password))
                {
                    return user;
                }
            }
            return null;
        }

    }
}
