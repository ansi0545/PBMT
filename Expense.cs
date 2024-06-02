
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
        Hygiene,
        Insurance,
        Other,
        Petfood,
        Petinsurance,
        Rent,
        Training,
        Transportation,
        Utilities
    }
    internal class Expense
    {
        private Category category;
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
