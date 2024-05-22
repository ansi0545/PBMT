using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_budget_management_tool
{

    public partial class SavingsGoalsForm : Form
    {
        private Label lblAmount;
        private TextBox txtAmount;
        private Label lblTimeframe;
        private TextBox txtTimeframe;
        private Button btnSave;

        public SavingsGoalsForm()
        {
            InitializeComponent();

        }




        void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Click += btnSave_Click;
        }
    }
}