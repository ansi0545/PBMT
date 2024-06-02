namespace Personal_budget_management_tool.Forms
{
    partial class ExpenseTrackingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCategory;


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
            dtpDate = new DateTimePicker();
            txtAmount = new TextBox();
            txtDescription = new TextBox();
            btnSave = new Button();
            cmbCategory = new ComboBox();
            SuspendLayout();
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(260, 12);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(361, 31);
            dtpDate.TabIndex = 0;
            //
            // lblAmount
            //
            lblAmount = new Label();
            lblAmount.Location = new Point(130, 71);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(120, 31);
            lblAmount.Text = "Amount:";
            //
            //lblCategory
            //
            lblCategory = new Label();
            lblCategory.Location = new Point(130, 208);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(120, 31);
            lblCategory.Text = "Category:";
            //
            //lblDescription
            //
            lblDescription = new Label();
            lblDescription.Location = new Point(130, 134);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(120, 31);
            lblDescription.Text = "Description:";
            //
            // lblDate
            //
            lblDate = new Label();
            lblDate.Location = new Point(130, 12);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(120, 31);
            lblDate.Text = "Date:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(260, 71);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(361, 31);
            txtAmount.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(260, 134);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(361, 31);
            txtDescription.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(260, 287);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(361, 50);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.Location = new Point(260, 208);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(361, 33);
            cmbCategory.TabIndex = 3;
            // 
            // ExpenseTrackingForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpDate);
            Controls.Add(txtAmount);
            Controls.Add(txtDescription);
            Controls.Add(cmbCategory);
            Controls.Add(btnSave);
            Controls.Add(lblDate);
            Controls.Add(lblAmount);
            Controls.Add(lblDescription);
            Controls.Add(lblCategory);
            Name = "ExpenseTrackingForm";
            Text = "ExpenseTrackingForm";
            Load += ExpenseTrackingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}