using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystemDesktop.UserControls {
    public partial class LoginControl : UserControl {
        public string Username => txtUsername.Text;
        public string Password => txtPassword.Text;

        public event EventHandler LoginClicked;
        public LoginControl() {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e) {
            MessageBox.Show("Login clicked!", "Info");
        }
        private void loginButton_Click(object sender, EventArgs e) {
            LoginClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
