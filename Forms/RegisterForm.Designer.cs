namespace Personal_budget_management_tool.Forms
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label lblNewUsername;
        private Label lblNewPassword;
        private TextBox txtNewUsername;
        private TextBox txtNewPassword;
        private Button btnRegister;



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
            btnRegister = new Button();
            lblNewUsername = new Label();
            lblNewPassword = new Label();
            txtNewUsername = new TextBox();
            txtNewPassword = new TextBox();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(219, 300);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(137, 40);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.Click += btnRegister_Click;
            // 
            // lblNewUsername
            // 
            lblNewUsername.AutoSize = true;
            lblNewUsername.Location = new Point(32, 28);
            lblNewUsername.Name = "lblNewUsername";
            lblNewUsername.Size = new Size(131, 25);
            lblNewUsername.TabIndex = 8;
            lblNewUsername.Text = "New Username";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(32, 99);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(127, 25);
            lblNewPassword.TabIndex = 9;
            lblNewPassword.Text = "New Password";
            // 
            // txtNewUsername
            // 
            txtNewUsername.Location = new Point(219, 28);
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.Size = new Size(329, 31);
            txtNewUsername.TabIndex = 2;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(219, 99);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(329, 31);
            txtNewPassword.TabIndex = 3;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNewUsername);
            Controls.Add(txtNewPassword);
            Controls.Add(lblNewUsername);
            Controls.Add(lblNewPassword);
            Controls.Add(btnRegister);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion
    }
}