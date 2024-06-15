﻿namespace Personal_budget_management_tool.Forms
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
            lblFilter = new Label();
            cmbFilter = new ComboBox();
            btnSort = new Button();
            dgvReport = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // lblFilter
            // 
            lblFilter.Location = new Point(10, 10);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(100, 23);
            lblFilter.TabIndex = 0;
            lblFilter.Text = "Filter:";
            // 
            // cmbFilter
            // 
            cmbFilter.Items.AddRange(new object[] { "Incomes", "Expenses", "SavingsGoal" });
            cmbFilter.Location = new Point(10, 40);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(200, 33);
            cmbFilter.TabIndex = 1;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(0, 0);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(75, 23);
            btnSort.TabIndex = 0;
            // 
            // dgvReport
            // 
            dgvReport.ColumnHeadersHeight = 34;
            dgvReport.Location = new Point(10, 80);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 62;
            dgvReport.Size = new Size(1423, 573);
            dgvReport.TabIndex = 3;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1517, 665);
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