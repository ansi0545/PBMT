namespace Personal_budget_management_tool
{
    internal class Income
    {
        private DateTime date;
        private double amount;
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

        public static bool IsPositiveNumber(double number)
        {
            if (number > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please enter a valid positive number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
    }
}