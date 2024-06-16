using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;
using Personal_budget_management_tool.Managers;

namespace Personal_budget_management_tool
{
    public class User
    {
        // [JsonInclude]
        public string Username { get; private set; }

        // [JsonInclude]
        public string Password { get; private set; }

        [JsonInclude]
        public string Salt { get; private set; }

        internal List<Income> Incomes { get; private set; }

        internal List<Expense> Expenses { get; private set; }

        internal SavingsGoal SavingsGoal { get; set; }

        internal double Savings { get; set; }

        public User()
        {
            Incomes = new List<Income>();
            Expenses = new List<Expense>();
        }
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
            double Savings = 0;
        }

        /// <summary>
        /// Generates a random salt value.
        /// </summary>
        /// <returns>A string representation of the generated salt value.</returns>
        private string GenerateSalt()
        {
            byte[] bytes = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(bytes);
            }
            return Convert.ToBase64String(bytes);
        }

        /// <summary>
        /// Checks if the provided password matches the stored password for the user.
        /// </summary>
        /// <param name="inputPassword">The password to be checked.</param>
        /// <returns>True if the provided password matches the stored password, otherwise false.</returns>
        public bool CheckPassword(string inputPassword)
        {
            return Password == ComputeHash(inputPassword + Salt);
        }

        /// <summary>
        /// Computes the SHA256 hash of the input string.
        /// </summary>
        /// <param name="input">The input string to compute the hash for.</param>
        /// <returns>The computed hash as a string.</returns>
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
