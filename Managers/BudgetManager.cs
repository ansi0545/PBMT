namespace Personal_budget_management_tool.Managers
{
    public class BudgetManager
    {
        private UserManager userManager;
        private User currentUser;
        private DataManager dataManager;
        private List<Expense> expenses;

        public BudgetManager(DataManager dataManager)
        {
            this.dataManager = dataManager;
            this.expenses = new List<Expense>();
        }

        internal BudgetManager()
        {
            this.expenses = new List<Expense>();
        }

        internal void AddExpense(Expense expense)
        {
            expenses.Add(expense);
        }

        internal User CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }

        public DataManager DataManager
        {
            get { return dataManager; }
            set { dataManager = value; }
        }

        public void SetSavingsGoalForCurrentUser(double goalAmount, DateTime desiredTimeframe)
        {
            if (CurrentUser != null)
            {
                CurrentUser.SavingsGoal = new SavingsGoal
                {
                    GoalAmount = goalAmount,
                    DesiredTimeframe = desiredTimeframe
                };
            }
        }

        internal Report GenerateReport()
        {
            return new Report(CurrentUser.Incomes, CurrentUser.Expenses, CurrentUser.SavingsGoal?.GoalAmount ?? 0);
        }

        // Add the GetCurrentUser method
        internal User GetCurrentUser()
        {
            return currentUser;
        }
    }
}
