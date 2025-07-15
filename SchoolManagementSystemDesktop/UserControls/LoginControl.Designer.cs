namespace SchoolManagementSystemDesktop.UserControls {
    partial class LoginControl {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Size = new Size(300, 300);
            this.BackColor = Color.FromArgb(50, 50, 80);

            lblTitle = new Label {
                Text = "Login",
                Font = new Font("Poppins", 18F, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(140, 20)
            };

            lblUsername = new Label {
                Text = "Username",
                Font = new Font("Poppins", 10F),
                ForeColor = Color.White,
                Location = new Point(30, 70),
                AutoSize = true
            };

            txtUsername = new TextBox {
                Location = new Point(30, 95),
                Size = new Size(240, 30),
                BackColor = Color.FromArgb(70, 70, 100),
                ForeColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            lblPassword = new Label {
                Text = "Password",
                Font = new Font("Poppins", 10F),
                ForeColor = Color.White,
                Location = new Point(30, 140),
                AutoSize = true
            };

            txtPassword = new TextBox {
                Location = new Point(30, 165),
                Size = new Size(240, 30),
                UseSystemPasswordChar = true,
                BackColor = Color.FromArgb(70, 70, 100),
                ForeColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            btnLogin = new Button {
                Text = "Sign In",
                Location = new Point(30, 215),
                Size = new Size(240, 35),
                BackColor = Color.FromArgb(108, 99, 255),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Click += BtnLogin_Click;

            this.Controls.Add(lblTitle);
            this.Controls.Add(lblUsername);
            this.Controls.Add(txtUsername);
            this.Controls.Add(lblPassword);
            this.Controls.Add(txtPassword);
            this.Controls.Add(btnLogin);

            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        }

        private Label lblTitle;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblUsername;
        private Label lblPassword;
        #endregion
    }
}
