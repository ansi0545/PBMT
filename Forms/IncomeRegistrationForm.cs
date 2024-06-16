using Personal_budget_management_tool.HelperMethods;
using Personal_budget_management_tool.Managers;

namespace Personal_budget_management_tool.Forms
{
    public partial class IncomeRegistrationForm : Form
    {
        private BudgetManager budgetApp;
        private List<Income> incomes = new List<Income>();
        private MainForm mainForm;
        /// <summary>
        /// Represents a form for registering income in the budget application.
        /// </summary>
        /// <param name="budgetApp">The instance of the BudgetManager class.</param>
        /// <param name="mainForm">The instance of the MainForm class.</param>
        public IncomeRegistrationForm(BudgetManager budgetApp, MainForm mainForm)
        {
            InitializeComponent();
            this.budgetApp = budgetApp;
            this.mainForm = mainForm;
            string summary = budgetApp.GetFinancialSummary();
            mainForm.UpdateFinancialSummary(summary);

        }

        /// <summary>
        /// Event handler for the Save button click event.
        /// Saves the income details entered by the user and updates the financial summary.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            string amountText = txtAmount.Text;
            string description = txtDescription.Text;

            if (!ErrorHandling.IsPositiveNumber(amountText, out double amount))
            {
                return;
            }

            if (!ErrorHandling.IsValidDescription(description))
            {
                return;
            }

            Income newIncome = new Income
            {
                Date = dtpDate.Value,
                Amount = amount,
                Description = description
            };

            budgetApp.AddIncome(newIncome);


            string summary = budgetApp.GetFinancialSummary();
            mainForm.UpdateFinancialSummary(summary);

            dtpDate.Value = DateTime.Now;
            txtAmount.Clear();
            txtDescription.Clear();
        }

        private void IncomeRegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
