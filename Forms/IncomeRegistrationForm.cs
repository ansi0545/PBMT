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
