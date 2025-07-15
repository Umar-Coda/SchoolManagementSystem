
namespace SchoolManagementSystemDesktop {
    public class LoginController {
        private readonly IAuthenticationService _authenticationService;

        public LoginController(IAuthenticationService authenticationService) {
            _authenticationService = authenticationService;
        }

        public LoginResult Login(string username, string password) {
            var loginDTO = _authenticationService.Validate(username, password);

            if (!loginDTO.IsUserAuthenticated) {
                return new LoginResult {
                    Success = false,
                    Message = "Login unsuccessful"
                };
            }

            return new LoginResult {
                Success = true,
                Message = "Login successful"
            };
        }
    }
}
