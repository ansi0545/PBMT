
namespace Personal_budget_management_tool
{
    public enum Category
    {
        Beauty,
        Clothing,
        Education,
        Entertainment,
        Groceries,
        Health,
        HealthInsurance,
        Hygiene,
        Insurance,
        Other,
        Petfood,
        Petinsurance,
        Presents,
        Rent,
        Training,
        Transportation,
        Utilities,
        Veterinarycosts

    }
    /// <summary>
    /// Represents an expense.
    /// </summary>
    internal class Expense
    {
        private Category category;
        private double amount;
        private DateTime date;
        private string description;

        /// <summary>
        /// Gets or sets the date of the expense.
        /// </summary>
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        /// <summary>
        /// Gets or sets the amount of the expense.
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
        /// Gets or sets the description of the expense.
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

        /// <summary>
        /// Gets or sets the category of the expense.
        /// </summary>
        public Category Category
        {
            get { return category; }
            set
            {
                category = value;
            }
        }
    }
}
