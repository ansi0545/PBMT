// BudgetApp.cs
namespace Personal_budget_management_tool
{
   public class BudgetApp
    {
        private User currentUser;
        private DataManager dataManager;

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

        private void StartApp() { /*...*/ }
        private void LoginUser(string username) { /*...*/ }
        private void LogoutUser() { /*...*/ }
        private void AddIncome(double amount) { /*...*/ }
        private void AddExpense(Expense expense) { /*...*/ }
        private void SetSavingsGoal(double goal) { /*...*/ }
        //private Report GenerateReport() { /*...*/ }
    }
}