
namespace Personal_budget_management_tool
{
    internal class Report
    {
         public List<Income> Incomes { get; }
        public List<Expense> Expenses { get; }
        public double Savings { get; }
        private double incomeTotal;
        private double expenseTotal;
        private double savingsTotal;
         

        public Report(List<Income> incomes, List<Expense> expenses, double savings)
        {
            Incomes = incomes;
            Expenses = expenses;
            Savings = savings;
        }

        public double IncomeTotal
        {
            get { return Incomes.Sum(i => i.Amount); }
        }

        public double ExpenseTotal
        {
            get { return Expenses.Sum(e => e.Amount); }
        }

        public double SavingsTotal
        {
            get { return Savings; }
        }

       
    }
}
