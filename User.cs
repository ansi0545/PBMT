

namespace Personal_budget_management_tool
{
    internal class User
    {
        private string username;
        private string password;
        private BudgetApp budget;

        public string GetUsername() { return username; }
        public void SetUsername(string value) { username = value; }

        public string GetPassword() { return password; }
        public void SetPassword(string value) { password = value; }

        public BudgetApp GetBudget() { return budget; }
        public void SetBudget(BudgetApp value) { budget = value; }

        internal void Login() { /*...*/ }
        internal void Logout() { /*...*/ }
        internal void Register(string username, string password) { /*...*/ }
    }
}
