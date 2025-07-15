using SchoolManagementSystemDesktop.Views.Dashboards;

namespace SchoolManagementSystemDesktop.Controllers;
public class AuthController {
    private readonly ILoginView _view;
    private readonly IAuthenticationService _authService;

    public AuthController(ILoginView view, IAuthenticationService authService) {
        _view = view;
        _authService = authService;

        _view.LoginClicked += OnLoginClicked;
    }

    private void OnLoginClicked(object sender, EventArgs e) {
        var response = _authService.Validate(_view.Username, _view.Password);
        if (!response.IsUserAuthenticated) {
            _view.ShowMessage("Login failed");
            return;
        }

        _view.CloseForm();

        Form dashboard = response.RoleName switch {
            "Administrator" => new AdminDashboard(),
            //"Coordinator" => new CoordinatorDashboard(),
            //"Teacher" => new TeacherDashboard(),
            //"Student" => new StudentDashboard(),
            _ => null
        };

        if (dashboard != null) {
            dashboard.ShowDialog();
        }
    }
}

