namespace Personal_budget_management_tool
{
    internal class SavingsGoal
    {
        private double goalAmount;
        private double savings;
        private DateTime desiredTimeframe;

        /// <summary>
        /// Gets or sets the goal amount.
        /// </summary>
        public double GoalAmount
        {
            get { return goalAmount; }
            set { goalAmount = value; }
        }

        /// <summary>
        /// Gets or sets the savings amount.
        /// </summary>
        public double Savings
        {
            get { return savings; }
            set { savings = value; }
        }

        /// <summary>
        /// Gets or sets the desired timeframe for the savings goal.
        /// </summary>
        public DateTime DesiredTimeframe
        {
            get { return desiredTimeframe; }
            set { desiredTimeframe = value; }
        }
    }
}