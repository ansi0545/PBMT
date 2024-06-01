

namespace Personal_budget_management_tool.Forms
{
    public partial class ReportsForm : Form
    {
        private BudgetApp budgetApp;
        public ReportsForm(BudgetApp budgetApp)
        {
            InitializeComponent();
            this.budgetApp = budgetApp;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            // Implement the logic for sorting the data in the DataGridView here
        }
    }
}
