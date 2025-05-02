namespace KeuanganWarkop
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(297, 201);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(189, 27);
            txtPassword.TabIndex = 0;
            txtPassword.Text = "Password";
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(297, 151);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(189, 27);
            txtUsername.TabIndex = 0;
            txtUsername.Text = "Username";
            txtUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(313, 272);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(158, 42);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnLogin;
    }
}
