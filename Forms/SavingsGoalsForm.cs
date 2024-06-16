

using Personal_budget_management_tool.Managers;

namespace Personal_budget_management_tool.Forms
{

    public partial class SavingsGoalsForm : Form
    {
        private MainForm mainForm;

        private BudgetManager budgetManager;

        public SavingsGoalsForm(BudgetManager budgetManager, DataManager dataManager, MainForm mainForm)
        {
            InitializeComponent();
            this.budgetManager = budgetManager;
            this.mainForm = mainForm;
        }


        /// <summary>
        /// Event handler for the Save button click event.
        /// Saves the user's savings goal and updates the financial summary.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTimeframe.Text, out int days))
            {
                MessageBox.Show("Please enter a valid number of days.");
                return;
            }

            if (!double.TryParse(txtAmount.Text, out double goalAmount))
            {
                MessageBox.Show("Please enter a valid goal amount.");
                return;
            }

            DateTime desiredTimeframe = DateTime.Today.AddDays(days);
            budgetManager.SetSavingsGoalForCurrentUser(goalAmount, desiredTimeframe);
            UpdateFinancialSummary();
            mainForm.UpdateFinancialSummary(budgetManager.GetFinancialSummary());
        }

        /// <summary>
        /// Updates the financial summary label with information about the user's savings goal, balance, and difference.
        /// </summary>
        public void UpdateFinancialSummary()
        {
            SavingsGoal savingsGoal = budgetManager.GetSavingsGoalForCurrentUser();
            double balance = budgetManager.GetBalanceForCurrentUser();
            double difference = savingsGoal != null ? balance - savingsGoal.GoalAmount : 0;

            lblFinancialSummary.Text = savingsGoal != null
                ? $"Savings Goal: {savingsGoal.GoalAmount}, Balance: {balance}, Difference: {difference}"
                : "No savings goal set";
        }

    }
}
