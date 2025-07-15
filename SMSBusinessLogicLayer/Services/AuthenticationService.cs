
namespace SMSBusinessLogicLayer.Services {
    /// <summary>
    /// Responsiblity --> Validate users upon login.
    /// </summary>
    public class AuthenticationService : IAuthenticationService {
        private readonly IRepositoryFactory _repoFactory;

        public AuthenticationService(IRepositoryFactory repoFactory) {
            _repoFactory = repoFactory;
        }

        public LoginDTO Validate(string username, string password) {
            var loginRepo = _repoFactory.GetLoginRepository();
            var roleRepo = _repoFactory.GetRoleRepository();

            //string passwordHash = PasswordHasher.HashPassword(password);
            string passwordHash = password;

            bool isAuthenticated = loginRepo.Authenticate(username, passwordHash);
            
            if (!isAuthenticated)
                return new LoginDTO { IsUserAuthenticated = false };

            var user = loginRepo.GetAuthenticatedUser(username, passwordHash);

            return new LoginDTO {
                UserId = user.UserId,
                RoleName = roleRepo.GetRoleName(user.UserId),
                IsUserAuthenticated = true
            };
        }
    }
}
