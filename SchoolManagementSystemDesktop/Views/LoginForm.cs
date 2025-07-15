namespace SchoolManagementSystemDesktop.Views {
    public partial class LoginForm : Form, ILoginView {
        public LoginForm() {
            InitializeComponent();
            SetupUI();
        }

        public string Username => txtUsername.Text;
        public string Password => txtPassword.Text;
        public event EventHandler LoginClicked;

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private void SetupUI() {
            this.Text = "Login";
            this.Width = 400;
            this.Height = 300;
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblTitle = new Label() {
                Text = "Login",
                Font = new System.Drawing.Font("Segoe UI", 16),
                AutoSize = true,
                Top = 20,
                Left = 150
            };

            txtUsername = new TextBox() { PlaceholderText = "Username", Top = 80, Left = 80, Width = 220 };
            txtPassword = new TextBox() { PlaceholderText = "Password", Top = 120, Left = 80, Width = 220, UseSystemPasswordChar = true };
            btnLogin = new Button() { Text = "Login", Top = 170, Left = 80, Width = 220, Height = 50 };

            btnLogin.Click += (s, e) => LoginClicked?.Invoke(this, EventArgs.Empty);

            this.Controls.Add(lblTitle);
            this.Controls.Add(txtUsername);
            this.Controls.Add(txtPassword);
            this.Controls.Add(btnLogin);
        }
        public void CloseForm() {
            this.Hide();
        }

        public void ShowMessage(string message) {
            MessageBox.Show(message);
        }
    }
}
