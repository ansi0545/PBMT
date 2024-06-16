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

        /// <summary>
        /// Adds an expense to the budget manager.
        /// </summary>
        /// <param name="expense">The expense to add.</param>
        internal void AddExpense(Expense expense)
        {
            expenses.Add(expense);
            if (currentUser != null)
            {
                currentUser.Expenses.Add(expense);
            }
        }

        /// <summary>
        /// Adds an income to the budget manager.
        /// </summary>
        /// <param name="income">The income to be added.</param>
        internal void AddIncome(Income income)
        {
            incomes.Add(income);
            if (currentUser != null)
            {
                currentUser.Incomes.Add(income);
            }
        }

        /// <summary>
        /// Calculates the financial summary by calculating the total income, total expenses, balance, and savings goal information.
        /// </summary>
        /// <returns>A string containing the financial summary.</returns>
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

        /// <summary>
        /// Represents a user in the system.
        /// </summary>
        internal User CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }

        /// <summary>
        /// Gets or sets the data manager.
        /// </summary>
        public DataManager DataManager
        {
            get { return dataManager; }
            set { dataManager = value; }
        }

        public object Incomes { get; internal set; }
        public object Expenses { get; internal set; }

        /// <summary>
        /// Sets the savings goal for the current user.
        /// </summary>
        /// <param name="goalAmount">The amount of the savings goal.</param>
        /// <param name="desiredTimeframe">The desired timeframe to achieve the savings goal.</param>
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



        /// <summary>
        /// Calculates the balance for the current user by subtracting the total expenses from the total income.
        /// </summary>
        /// <returns>The balance for the current user.</returns>
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

        /// <summary>
        /// Gets the savings goal for the current user.
        /// </summary>
        /// <returns>The savings goal for the current user.</returns>
        internal SavingsGoal GetSavingsGoalForCurrentUser()
        {
            return CurrentUser?.SavingsGoal;
        }

        /// <summary>
        /// Represents a user in the system.
        /// </summary>
        internal User GetCurrentUser()
        {
            return currentUser;
        }
    }
}
