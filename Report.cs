
namespace Personal_budget_management_tool
{
    internal class Report
    {
        public List<Income> Incomes { get; }
        public List<Expense> Expenses { get; }
        public double Savings { get; }
        public double SavingsDifference { get; }
        public double GoalAmount { get; set; }


        /// <summary>
        /// Represents a financial report.
        /// </summary>
        /// <param name="incomes">The list of incomes.</param>
        /// <param name="expenses">The list of expenses.</param>
        /// <param name="savings">The amount of savings.</param>
        /// <param name="goalAmount">The goal amount.</param>
        public Report(List<Income> incomes, List<Expense> expenses, double savings, double goalAmount)
        {
            Incomes = incomes;
            Expenses = expenses;
            Savings = savings;
            GoalAmount = goalAmount;
            SavingsDifference = goalAmount - savings;
        }

    }
}
