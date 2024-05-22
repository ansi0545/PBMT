namespace Personal_budget_management_tool.Forms
{
    partial class IncomeRegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSave;

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
            SuspendLayout();
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(10, 12);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(361, 31);
            dtpDate.TabIndex = 0;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(10, 49);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(361, 31);
            txtAmount.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(10, 86);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(361, 31);
            txtDescription.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(10, 132);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(361, 50);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // IncomeRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpDate);
            Controls.Add(txtAmount);
            Controls.Add(txtDescription);
            Controls.Add(btnSave);
            Name = "IncomeRegistrationForm";
            Text = "IncomeRegistrationForm";
            Load += IncomeRegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }

    #endregion
}
