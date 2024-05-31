using System.Security.Cryptography;
using System.Text;

namespace Personal_budget_management_tool
{
    public class User
    {
        private string salt;

        private string username;
        private string password;
        private BudgetApp budget;
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
        public BudgetApp Budget
        {
            get { return budget; }
            set { budget = value; }
        }

        internal List<Income> Incomes { get; set; }
        internal List<Expense> Expenses { get; set; } = new List<Expense>();

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

        public void Register(string username, string password, BudgetApp budgetApp)
        {

            Username = username;
            Salt = GenerateSalt();
            Password = ComputeHash(password + Salt);
            Budget = budgetApp;

            // Add the new user to the list of users in the BudgetApp
            budgetApp.Users.Add(this);
        }

        private string GenerateSalt()
        {
            byte[] bytes = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(bytes);
            }
            return BitConverter.ToString(bytes).Replace("-", "").ToLower();
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
            Budget = new BudgetApp();
        }
    }
}