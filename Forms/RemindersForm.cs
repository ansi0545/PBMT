namespace Personal_budget_management_tool.Forms
{
    public partial class RemindersForm : Form
    {
        private BudgetManager budgetApp;
        public RemindersForm(BudgetManager budgetApp)
        {
            InitializeComponent();
            this.budgetApp = budgetApp;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save the reminder here
        }
    }
}
