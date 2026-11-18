namespace Juan_Week07_Week08
{
    partial class Signup
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbRegUsername = new TextBox();
            tbRegPassword = new TextBox();
            btnRegister = new Button();
            label4 = new Label();
            label5 = new Label();
            tbRegEmail = new TextBox();
            tbRegFullname = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 204);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 245);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(310, 79);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 2;
            label3.Text = "Register a User";
            // 
            // tbRegUsername
            // 
            tbRegUsername.Location = new Point(270, 196);
            tbRegUsername.Name = "tbRegUsername";
            tbRegUsername.Size = new Size(185, 23);
            tbRegUsername.TabIndex = 3;
            // 
            // tbRegPassword
            // 
            tbRegPassword.Location = new Point(270, 237);
            tbRegPassword.Name = "tbRegPassword";
            tbRegPassword.Size = new Size(185, 23);
            tbRegPassword.TabIndex = 4;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(325, 278);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(215, 166);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "Email";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(195, 127);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 7;
            label5.Text = "Fullname";
            // 
            // tbRegEmail
            // 
            tbRegEmail.Location = new Point(270, 158);
            tbRegEmail.Name = "tbRegEmail";
            tbRegEmail.Size = new Size(185, 23);
            tbRegEmail.TabIndex = 8;
            // 
            // tbRegFullname
            // 
            tbRegFullname.Location = new Point(270, 119);
            tbRegFullname.Name = "tbRegFullname";
            tbRegFullname.Size = new Size(185, 23);
            tbRegFullname.TabIndex = 9;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbRegFullname);
            Controls.Add(tbRegEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnRegister);
            Controls.Add(tbRegPassword);
            Controls.Add(tbRegUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Signup";
            Text = "Signup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbRegUsername;
        private TextBox tbRegPassword;
        private Button btnRegister;
        private Label label4;
        private Label label5;
        private TextBox tbRegEmail;
        private TextBox tbRegFullname;
    }
}