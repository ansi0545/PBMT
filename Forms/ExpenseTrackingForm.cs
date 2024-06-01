using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_budget_management_tool.Forms
{
    public partial class ExpenseTrackingForm : Form
    {
        private BudgetApp budgetApp;
        public ExpenseTrackingForm(BudgetApp budgetApp)
        {
            InitializeComponent();
            this.budgetApp = budgetApp;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Add your save logic here
        }

        private void ExpenseTrackingForm_Load(object sender, EventArgs e)
        {
            // Add your form load logic here
        }
    }
}
