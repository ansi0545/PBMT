using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_budget_management_tool
{
    internal class Expense
    {
        private string category;
        private double amount;
        private DateTime date;

        public string GetCategory() { return category; }
        public void SetCategory(string value) { category = value; }

        public double GetAmount() { return amount; }
        public void SetAmount(double value) { amount = value; }

        public DateTime GetDate() { return date; }
        public void SetDate(DateTime value) { date = value; }
    }
}
