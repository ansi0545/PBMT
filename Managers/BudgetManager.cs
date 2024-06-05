namespace Personal_budget_management_tool.Managers
{
    public class BudgetManager
    {
        private UserManager userManager;
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
        public void SetSavingsGoalForCurrentUser(double goalAmount, DateTime desiredTimeframe)
        {
            CurrentUser.SavingsGoal = new SavingsGoal
            {
                GoalAmount = goalAmount,
                DesiredTimeframe = desiredTimeframe
            };
        }

       

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

        public User GetCurrentUser()
        {
            return CurrentUser;
        }

    }
}