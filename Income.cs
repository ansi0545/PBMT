namespace Personal_budget_management_tool
{
    internal class Income
    {
        private DateTime date;
        private double amount;
        private string description;

        /// <summary>
        /// Gets or sets the date of the income.
        /// </summary>
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        /// <summary>
        /// Gets or sets the amount of income.
        /// </summary>
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

        /// <summary>
        /// Gets or sets the description of the income.
        /// </summary>
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