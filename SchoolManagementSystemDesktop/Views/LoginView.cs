using SchoolManagementSystemDesktop.ViewModels;
using SchoolManagementSystemDesktop.Views.Dashboards;

namespace SchoolManagementSystemDesktop.Views {
    public partial class LoginView : Form {
        private readonly LoginViewModel _loginViewModel;
        private readonly LoginController _loginController;
        private readonly AdminView _adminView;

        public LoginView(LoginController loginController, AdminView adminView) {
            InitializeComponent();

            _adminView = adminView;
            _loginController = loginController;
            _loginViewModel = new LoginViewModel();

            txtUsername.DataBindings.Add("Text", _loginViewModel,
                nameof(_loginViewModel.Username), false, DataSourceUpdateMode.OnPropertyChanged);
            txtPassword.DataBindings.Add("Text", _loginViewModel,
                nameof(_loginViewModel.Password), false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void loginBtn_Click(object sender, EventArgs e) {
            var loginResult = _loginController.Login(_loginViewModel.Username, _loginViewModel.Password);

            if (!loginResult.Success)
                MessageBox.Show(loginResult.Message);
            else {
                MessageBox.Show(loginResult.Message);
                _adminView.Show();
                Hide();
            }
        }
    }
}
