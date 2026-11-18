namespace Juan_Week07_Week08
{
    partial class Login
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
            lblUsername = new Label();
            lblPassword = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            btnLogin = new Button();
            btnSigup = new Button();
            lblWelcome = new Label();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(222, 134);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(225, 176);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(288, 126);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(215, 23);
            tbUsername.TabIndex = 2;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(288, 168);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(215, 23);
            tbPassword.TabIndex = 3;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(308, 218);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnSigup
            // 
            btnSigup.Location = new Point(408, 218);
            btnSigup.Name = "btnSigup";
            btnSigup.Size = new Size(75, 23);
            btnSigup.TabIndex = 5;
            btnSigup.Text = "Signup";
            btnSigup.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(339, 74);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(110, 20);
            lblWelcome.TabIndex = 6;
            lblWelcome.Text = "Welcome Back!";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblWelcome);
            Controls.Add(btnSigup);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button btnLogin;
        private Button btnSigup;
        private Label lblWelcome;
    }
}