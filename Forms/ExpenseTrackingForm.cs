using Personal_budget_management_tool.HelperMethods;
using Personal_budget_management_tool.Managers;

namespace Personal_budget_management_tool.Forms
{
    public partial class ExpenseTrackingForm : Form
    {
        private BudgetManager budgetApp;
        private MainForm mainForm;
        public ExpenseTrackingForm(BudgetManager budgetApp, MainForm mainForm)
        {
            InitializeComponent();
            this.budgetApp = budgetApp;
            string summary = budgetApp.GetFinancialSummary();
            this.mainForm = mainForm;
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

            if (cmbCategory.SelectedItem == null)
            {
                ErrorHandling.ShowErrorMessage("Please select a category.");
                return;
            }
            
            Expense newExpense = new Expense
            {
                Date = dtpDate.Value,
                Amount = amount,
                Description = description,
                Category = (Category)cmbCategory.SelectedItem
            };
           
            budgetApp.AddExpense(newExpense);

            string summary = budgetApp.GetFinancialSummary();
            mainForm.UpdateFinancialSummary(summary);

            dtpDate.Value = DateTime.Now;
            txtAmount.Clear();
            txtDescription.Clear();
            cmbCategory.SelectedIndex = -1;
        }

        private void ExpenseTrackingForm_Load(object sender, EventArgs e)
        {

            foreach (var category in Enum.GetValues(typeof(Category)))
            {
                cmbCategory.Items.Add(category);
            }
        }
    }
}