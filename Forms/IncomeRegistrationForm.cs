using Personal_budget_management_tool.HelperMethods;

namespace Personal_budget_management_tool.Forms
{
    public partial class IncomeRegistrationForm : Form
    {
        private BudgetManager budgetApp;
        private List<Income> incomes = new List<Income>();
        public IncomeRegistrationForm(BudgetManager budgetApp)
        {
            InitializeComponent();
            this.budgetApp = budgetApp;
        }
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

            incomes.Add(income);
        }

        private void IncomeRegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
