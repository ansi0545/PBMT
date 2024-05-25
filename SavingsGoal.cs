using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_budget_management_tool
{
    internal class SavingsGoal
    {
        private double goalAmount;
        private DateTime desiredTimeframe;

        public double GetGoalAmount() { return goalAmount; }
        public void SetGoalAmount(double value) { goalAmount = value; }

        public DateTime GetDesiredTimeframe() { return desiredTimeframe; }
        public void SetDesiredTimeframe(DateTime value) { desiredTimeframe = value; }
    }
}
