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
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblDescription;

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
            lblDate = new Label();
            lblAmount = new Label();
            lblDescription = new Label();
            SuspendLayout();
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDate.Location = new Point(192, 12);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(474, 30);
            dtpDate.TabIndex = 0;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(192, 49);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(474, 30);
            txtAmount.TabIndex = 1;
            txtAmount.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(192, 86);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(474, 31);
            txtDescription.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(252, 123);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(361, 50);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(50, 12);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(100, 31);
            lblDate.TabIndex = 4;
            lblDate.Text = "Date";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAmount.Location = new Point(50, 49);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(130, 22);
            lblAmount.TabIndex = 5;
            lblAmount.Text = "Add Amount";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(50, 86);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(142, 22);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description";
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
            Controls.Add(lblDate);
            Controls.Add(lblAmount);
            Controls.Add(lblDescription);
            Name = "IncomeRegistrationForm";
            Text = "IncomeRegistrationForm";
            Load += IncomeRegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }

    #endregion
}
