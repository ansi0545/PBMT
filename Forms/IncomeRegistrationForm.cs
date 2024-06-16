using Personal_budget_management_tool.HelperMethods;
using Personal_budget_management_tool.Managers;

namespace Personal_budget_management_tool.Forms
{
    public partial class IncomeRegistrationForm : Form
    {
        private BudgetManager budgetApp;
        private List<Income> incomes = new List<Income>();
        private MainForm mainForm;
        public IncomeRegistrationForm(BudgetManager budgetApp, MainForm mainForm)
        {
            InitializeComponent();
            this.budgetApp = budgetApp;
            this.mainForm = mainForm;

            string summary = budgetApp.GetFinancialSummary();
            mainForm.UpdateFinancialSummary(summary);

        }

        // public IncomeRegistrationForm(BudgetManager budgetManager, MainForm mainForm) : this(budgetManager)
        // {
        //     this.mainForm = mainForm;
        // }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string amountText = txtAmount.Text;
            string description = txtDescription.Text;

            // Validate the amount
            if (!ErrorHandling.IsPositiveNumber(amountText, out double amount))
            {
                return;
            }

            // Validate the description
            if (!ErrorHandling.IsValidDescription(description))
            {
                return;
            }

            // Create a new Income object
            Income newIncome = new Income
            {
                Date = dtpDate.Value,
                Amount = amount,
                Description = description
            };

            // Add the new income to the BudgetManager
            budgetApp.AddIncome(newIncome);

            // Update the financial summary in MainForm
            string summary = budgetApp.GetFinancialSummary(); // Replace this with your actual method to get the summary
            mainForm.UpdateFinancialSummary(summary);

            // Clear the form
            dtpDate.Value = DateTime.Now;
            txtAmount.Clear();
            txtDescription.Clear();
        }

        private void IncomeRegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
