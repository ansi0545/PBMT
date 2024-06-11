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

        internal string GetFinancialSummary()
        {
            double totalExpenses = expenses.Sum(expense => expense.Amount);
            double totalIncome = incomes.Sum(income => income.Amount);
            double total = totalIncome - totalExpenses;
            SavingsGoal savingsGoal = GetSavingsGoalForCurrentUser();
            double balance = GetBalanceForCurrentUser();
            double difference = savingsGoal != null ? balance - savingsGoal.GoalAmount : 0;
            string savingsGoalText = savingsGoal != null ? $"Savings Goal: {savingsGoal.GoalAmount}, Balance: {balance}, Difference: {difference}" : "No savings goal set";
            
            return $"Total Income: {totalIncome}, Total Expense: {totalExpenses}, Balance: {total}, {savingsGoalText}";
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

        internal void SetSavingsGoalForCurrentUser(double goalAmount, DateTime desiredTimeframe)
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

        internal double GetBalanceForCurrentUser()
        {
            if (CurrentUser == null)
            {
                Console.WriteLine("CurrentUser is null");
                return 0;
            }

            double totalIncome = CurrentUser.Incomes?.Sum(income => income.Amount) ?? 0;
            double totalExpenses = CurrentUser.Expenses?.Sum(expense => expense.Amount) ?? 0;

            if (CurrentUser.Incomes == null)
            {
                Console.WriteLine("CurrentUser.Incomes is null");
            }

            if (CurrentUser.Expenses == null)
            {
                Console.WriteLine("CurrentUser.Expenses is null");
            }

            Console.WriteLine($"totalIncome: {totalIncome}, totalExpenses: {totalExpenses}");

            return totalIncome - totalExpenses;
        }

        internal SavingsGoal GetSavingsGoalForCurrentUser()
        {
            if (CurrentUser == null)
            {
                // Log an error or throw an exception if appropriate
                return null;
            }

            return CurrentUser.SavingsGoal;
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
