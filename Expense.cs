
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
