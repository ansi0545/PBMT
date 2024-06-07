using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;
using Personal_budget_management_tool.Managers;

namespace Personal_budget_management_tool
{
    public class User
    {
        [JsonInclude]
        public string Username { get; private set; }

        [JsonInclude]
        public string Password { get; private set; }

        [JsonInclude]
        public string Salt { get; private set; }

        [JsonIgnore]
        internal List<Income> Incomes { get; private set; }

        [JsonIgnore]
        internal List<Expense> Expenses { get; private set; }

        [JsonIgnore]
        internal SavingsGoal SavingsGoal { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Salt = GenerateSalt();
            Password = ComputeHash(password + Salt);
            Incomes = new List<Income>();
            Expenses = new List<Expense>();
        }

        [JsonConstructor]
        public User(string username, string password, string salt)
        {
            Username = username;
            Password = password;
            Salt = salt;
            Incomes = new List<Income>();
            Expenses = new List<Expense>();
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
            return Password == ComputeHash(inputPassword + Salt);
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
