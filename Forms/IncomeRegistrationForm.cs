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
            if (!ErrorHandling.IsPositiveNumber(txtAmount.Text, out double amount))
            {
                return;
            }

            var income = new Income
            {
                Date = dtpDate.Value,
                Amount = amount,
                Description = txtDescription.Text
            };
            budgetApp.AddIncome(income);

            string summary = budgetApp.GetFinancialSummary(); // Replace this with your actual method to get the summary
            mainForm.UpdateFinancialSummary(summary);

        }

        private void IncomeRegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
