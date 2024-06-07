using System.Security.Cryptography;
using System.Text;
using Personal_budget_management_tool.Managers;

namespace Personal_budget_management_tool
{
    internal class User
    {
        private string salt;
        private string username;
        private string password;
        private BudgetManager budget;

        public User(string username, string password)
        {
            this.username = username;
            this.salt = GenerateSalt();
            this.password = ComputeHash(password + this.salt);
            this.budget = new BudgetManager(new DataManager { FilePath = Application.StartupPath + "\\Budget.txt" });
            this.Incomes = new List<Income>();
            this.Expenses = new List<Expense>();
        }

        public string Username
        {
            get { return username; }
            private set { username = value; }
        }

        public string Password
        {
            get { return password; }
            private set { password = value; }
        }

        public string Salt
        {
            get { return salt; }
            private set { salt = value; }
        }

        public List<Income> Incomes { get; private set; }
        public List<Expense> Expenses { get; private set; }
        public SavingsGoal SavingsGoal { get; set; }

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
            return this.Password == ComputeHash(inputPassword + this.salt);
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
    }
}
