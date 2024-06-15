namespace Personal_budget_management_tool.Forms
{
    public partial class ReportsForm : Form
    {
        private Label lblFilter;
        private ComboBox cmbFilter;
        private Button btnSort;
        private DataGridView dgvReport;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MenuStrip menuStrip = new MenuStrip();
            menuStrip.Dock = DockStyle.Top;
            lblFilter = new Label();
            cmbFilter = new ComboBox();
            btnSort = new Button();
            dgvReport = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            //
            // menuStrip
            //
            ToolStripMenuItem fileMenuItem = new ToolStripMenuItem("File");
            fileMenuItem.DropDownItems.Add("New", null, NewMenuItem_Click);
            fileMenuItem.DropDownItems.Add("Open data file", null, OpenDataFileMenuItem_Click);
            fileMenuItem.DropDownItems.Add("Save data file", null, SaveDataFileMenuItem_Click);
            fileMenuItem.DropDownItems.Add("Exit", null, ExitMenuItem_Click);
            // 
            // lblFilter
            // 
            lblFilter = new Label();
            lblFilter.Location = new Point(10, 10);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(100, 23);
            lblFilter.TabIndex = 0;
            lblFilter.Text = "Filter:";
            // 
            // cmbFilter
            // 
            cmbFilter = new ComboBox();
            cmbFilter.Items.AddRange(new object[] { "Incomes", "Expenses", "SavingsGoal" });
            cmbFilter.Location = new Point(10, 40);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(200, 33);
            cmbFilter.TabIndex = 1;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // btnSort
            // 
            btnSort = new Button();
            btnSort.Location = new Point(0, 0);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(75, 23);
            btnSort.TabIndex = 0;
            // 
            // dgvReport
            // 
            dgvReport = new DataGridView();
            //dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.ColumnHeadersHeight = 34;
            dgvReport.Location = new Point(10, 80);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 62;
            dgvReport.Size = new Size(1423, 573);
            dgvReport.TabIndex = 3;
            // 
            // ReportsForm
            // 
            menuStrip.Items.Add(fileMenuItem);
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1517, 665);
            Controls.Add(menuStrip);
            Controls.Add(lblFilter);
            Controls.Add(cmbFilter);
            Controls.Add(dgvReport);
            Name = "ReportsForm";
            Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}