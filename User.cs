namespace Personal_budget_management_tool
{
    public class User
    {
        private string username;
        private string password;
        private BudgetApp budget;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public BudgetApp Budget { get => budget; set => budget = value; }

        public bool Login(string inputUsername, string inputPassword)
        {
            if (inputUsername == Username && inputPassword == Password)
            {
                // The user is logged in.
                return true;
            }
            else
            {
                // The username or password is incorrect.
                return false;
            }
        }

        public void Logout()
        {
            // Reset user's information
            Username = null;
            Password = null;
            Budget = null;
        }

        public void Register(string username, string password)
        {
            Username = username;
            Password = password;
            Budget = new BudgetApp();
        }
    }
}