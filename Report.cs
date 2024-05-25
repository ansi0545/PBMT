using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_budget_management_tool
{
    internal class Report
    {
        private double incomeTotal;
        private double expenseTotal;
        private double savingsTotal;

        public double GetIncomeTotal() { return incomeTotal; }
        public double GetExpenseTotal() { return expenseTotal; }
        public double GetSavingsTotal() { return savingsTotal; }
    }
}
