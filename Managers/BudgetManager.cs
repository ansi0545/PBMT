namespace Personal_budget_management_tool.Managers
{
    public class BudgetManager
    {
        private UserManager userManager;
        private User currentUser;
        private DataManager dataManager;
        private List<Expense> expenses;
        private List<Income> incomes;

        public BudgetManager(DataManager dataManager)
        {
            this.dataManager = dataManager;
            this.expenses = new List<Expense>();
            this.incomes = new List<Income>();
        }

        internal BudgetManager()
        {
            this.expenses = new List<Expense>();
        }

        internal void AddExpense(Expense expense)
        {
            expenses.Add(expense);
        }

        internal void AddIncome(Income income)
        {
            incomes.Add(income);
        }

        public string GetFinancialSummary()
        {
            
            double totalExpenses = expenses.Sum(expense => expense.Amount);
            double totalIncome = incomes.Sum(income => income.Amount);
            double total = totalIncome - totalExpenses;
            
            return $"Total Income: {totalIncome}, Total Expense: {totalExpenses}, Balance: {total}";
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

        public object Incomes { get; internal set; }
        public object Expenses { get; internal set; }

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
