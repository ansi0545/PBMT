
namespace Personal_budget_management_tool
{
    public class BudgetManager
    {
        private User currentUser;
        private DataManager dataManager;


        internal Report GenerateReport()
        {
            // Assuming User class has properties Incomes, Expenses, and a SavingsGoal with a GoalAmount property
            return new Report(CurrentUser.Incomes, CurrentUser.Expenses, CurrentUser.SavingsGoal.GoalAmount);
        }

        public User CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }

        public DataManager DataManager
        {
            get { return dataManager; }
            set { dataManager = value; }
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

        public void SetSavingsGoalForCurrentUser(double goalAmount, DateTime desiredTimeframe)
        {
            CurrentUser.SavingsGoal = new SavingsGoal
            {
                GoalAmount = goalAmount,
                DesiredTimeframe = desiredTimeframe
            };
        }

        public List<User> Users { get; set; } = new List<User>();

        internal Report GenerateReportForGoal()
        {
            // Assuming User class has properties Incomes, Expenses, and a SavingsGoal with a GoalAmount property
            return new Report(CurrentUser.Incomes, CurrentUser.Expenses, CurrentUser.SavingsGoal.GoalAmount);
        }

        internal Report GenerateReportForSavings()
        {
            // Assuming User class has properties Incomes, Expenses, and Savings which are List<double>
            return new Report(CurrentUser.Incomes, CurrentUser.Expenses, CurrentUser.SavingsGoal.Savings);
        }
        internal void AddIncome(Income income)
        {
            CurrentUser.Incomes.Add(income);
        }

        internal void AddExpense(Expense expense)
        {
            CurrentUser.Expenses.Add(expense);
        }

        public bool LoginUser(string username, string password)
        {
            // Check if a user with the provided username exists
            foreach (User user in Users)
            {
                if (user.Username == username && user.Password == password)
                {
                    // If such a user is found, set the CurrentUser to that user
                    CurrentUser = user;
                    return true;
                }
            }

            // If no user is found, throw an exception
            return false;
        }

        public User GetCurrentUser()
        {
            return CurrentUser;
        }

        // private void StartApp() { /*...*/ }
        // private void LoginUser(string username) { /*...*/ }
        // private void LogoutUser() { /*...*/ }
        // private void AddIncome(double amount) { /*...*/ }
        // private void SetSavingsGoal(double goal) { /*...*/ }
    }
}