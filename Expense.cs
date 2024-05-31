
namespace Personal_budget_management_tool
{
    internal class Expense
    {
        private string category;
        private double amount;
        private DateTime date;
        private string description;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public double Amount
        {
            get { return amount; }
            set
            {
                if (HelperMethods.ErrorHandling.IsPositiveNumber(value))
                {
                    amount = value;
                }
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (HelperMethods.ErrorHandling.IsValidDescription(value))
                {
                    description = value;
                }
            }
        }

        public string GetCategory() { return category; }
        public void SetCategory(string value) { category = value; }

        public double GetAmount() { return amount; }
        public void SetAmount(double value) { amount = value; }

        public DateTime GetDate() { return date; }
        public void SetDate(DateTime value) { date = value; }
    }
}
