namespace Personal_budget_management_tool
{
    internal class SavingsGoal
    {
        private double goalAmount;
        private double savings;
        private DateTime desiredTimeframe;

        public double GoalAmount
        {
            get { return goalAmount; }
            set { goalAmount = value; }
        }

        public double Savings
        {
            get { return savings; }
            set { savings = value; }
        }

        public DateTime DesiredTimeframe
        {
            get { return desiredTimeframe; }
            set { desiredTimeframe = value; }
        }
    }
}