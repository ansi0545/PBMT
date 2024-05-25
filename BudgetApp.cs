using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_budget_management_tool
{
    internal class BudgetApp
    {
        private User currentUser;
        private DataManager dataManager;

        public User GetCurrentUser() { return currentUser; }
        public void SetCurrentUser(User value) { currentUser = value; }

        public DataManager GetDataManager() { return dataManager; }
        public void SetDataManager(DataManager value) { dataManager = value; }

        internal void StartApp() { /*...*/ }
        internal void LoginUser(string username) { /*...*/ }
        internal void LogoutUser() { /*...*/ }
        internal void AddIncome(double amount) { /*...*/ }
        internal void AddExpense(Expense expense) { /*...*/ }
        internal void SetSavingsGoal(double goal) { /*...*/ }
        //internal Report GenerateReport() { /*...*/ }
    }
}
