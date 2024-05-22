namespace Personal_budget_management_tool.Forms
{
    partial class SavingsGoalsForm
    {
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
            lblAmount = new Label();
            txtAmount = new TextBox();
            lblTimeframe = new Label();
            txtTimeframe = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblAmount
            // 
            lblAmount.Location = new Point(10, 10);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(100, 23);
            lblAmount.TabIndex = 0;
            lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(10, 36);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(200, 31);
            txtAmount.TabIndex = 1;
            // 
            // lblTimeframe
            // 
            lblTimeframe.Location = new Point(10, 69);
            lblTimeframe.Name = "lblTimeframe";
            lblTimeframe.Size = new Size(100, 23);
            lblTimeframe.TabIndex = 2;
            lblTimeframe.Text = "Timeframe:";
            // 
            // txtTimeframe
            // 
            txtTimeframe.Location = new Point(10, 95);
            txtTimeframe.Name = "txtTimeframe";
            txtTimeframe.Size = new Size(200, 31);
            txtTimeframe.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(10, 141);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(200, 40);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            // 
            // SavingsGoalsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAmount);
            Controls.Add(txtAmount);
            Controls.Add(lblTimeframe);
            Controls.Add(txtTimeframe);
            Controls.Add(btnSave);
            Name = "SavingsGoalsForm";
            Text = "Savings Goals";
            ResumeLayout(false);
            PerformLayout();
        }
    }

        #endregion
    }