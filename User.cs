using System.Security.Cryptography;
using System.Text;

namespace Personal_budget_management_tool
{
    public class User
    {
        private string salt;

        private string username;
        private string password;
        private BudgetManager budget;
        internal SavingsGoal SavingsGoal { get; set; }


        public string Salt
        {
            get { return salt; }
            set { salt = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public BudgetManager Budget
        {
            get { return budget; }
            set { budget = value; }
        }

        internal List<Income> Incomes { get; set; }
        internal List<Expense> Expenses { get; set; } = new List<Expense>();

        // Added constructor
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
            this.budget = new BudgetManager();
        }

        public bool Login(string inputUsername, string inputPassword)
        {
            if (inputUsername == Username && ComputeHash(inputPassword + Salt) == Password)
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

        public void Register(string username, string password, BudgetManager budgetManager)
        {
            Username = username;
            Salt = GenerateSalt();
            Password = ComputeHash(password + Salt);
            Budget = budgetManager ?? new BudgetManager();

            // Add the new user to the list of users in the BudgetManager
            if (budgetManager != null)
            {
                budgetManager.Users.Add(this);
            }
        }

        private string GenerateSalt()
        {
            byte[] bytes = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(bytes);
            }
            return Convert.ToBase64String(bytes);
        }
        public bool CheckPassword(string inputPassword)
        {
            return this.Password == ComputeHash(inputPassword + this.Salt);
        }
        
        private string ComputeHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
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
            Budget = new BudgetManager();
        }
    }
}