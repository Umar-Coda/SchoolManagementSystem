namespace SchoolManagementSystemDesktop.Views {
    partial class LoginView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            LoginTitle = new Label();
            horizontalLine = new Panel();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            horizontalLine1 = new Panel();
            loginBtn = new Button();
            SuspendLayout();
            // 
            // LoginTitle
            // 
            LoginTitle.AutoSize = true;
            LoginTitle.BackColor = Color.White;
            LoginTitle.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginTitle.ForeColor = Color.DeepSkyBlue;
            LoginTitle.Location = new Point(300, 112);
            LoginTitle.Margin = new Padding(4, 0, 4, 0);
            LoginTitle.Name = "LoginTitle";
            LoginTitle.Size = new Size(603, 54);
            LoginTitle.TabIndex = 0;
            LoginTitle.Text = "CODE NO JUTSU ACADEMY";
            // 
            // horizontalLine
            // 
            horizontalLine.BackColor = Color.DeepSkyBlue;
            horizontalLine.Location = new Point(419, 257);
            horizontalLine.Margin = new Padding(4, 5, 4, 5);
            horizontalLine.Name = "horizontalLine";
            horizontalLine.Size = new Size(337, 8);
            horizontalLine.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(419, 207);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "username";
            txtUsername.Size = new Size(336, 40);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.DeepSkyBlue;
            txtPassword.Location = new Point(419, 305);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "password";
            txtPassword.Size = new Size(336, 40);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // horizontalLine1
            // 
            horizontalLine1.BackColor = Color.DeepSkyBlue;
            horizontalLine1.Location = new Point(419, 355);
            horizontalLine1.Margin = new Padding(4, 5, 4, 5);
            horizontalLine1.Name = "horizontalLine1";
            horizontalLine1.Size = new Size(337, 8);
            horizontalLine1.TabIndex = 4;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.DeepSkyBlue;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(419, 400);
            loginBtn.Margin = new Padding(4, 5, 4, 5);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(337, 77);
            loginBtn.TabIndex = 6;
            loginBtn.Text = "Sign In";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(1189, 542);
            Controls.Add(loginBtn);
            Controls.Add(horizontalLine1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(horizontalLine);
            Controls.Add(LoginTitle);
            Margin = new Padding(4, 5, 4, 5);
            Name = "LoginView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "LoginView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoginTitle;
        private Panel horizontalLine;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Panel horizontalLine1;
        private Button loginBtn;
    }
}