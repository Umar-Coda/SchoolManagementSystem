using SMSWebAPI.Models.DTOs;
using SMSWebAPI.Repos.LoginRepo;
using SMSWebAPI.Repos.RoleRepo;
using SMSWebAPI.Repos.UserRepo;
using SMSWebAPI.Services.Interfaces;

namespace SMSWebAPI.Services {
    public class AuthenticationService : IAuthenticationService {
        private readonly ILoginRepository _loginRepo;
        private readonly IRoleRepository _roleRepo;

        public AuthenticationService(ILoginRepository loginRepo, IRoleRepository roleRepo) {
            _loginRepo = loginRepo;
            _roleRepo = roleRepo;
        }

        public LoginDTO Validate(string username, string password) {
            //string passwordHash = PasswordHasher.HashPassword(password);
            string passwordHash = password;

            bool isAuthenticated = _loginRepo.Authenticate(username, passwordHash);

            if (!isAuthenticated)
                return new LoginDTO { IsUserAuthenticated = false };

            var user = _loginRepo.GetAuthenticatedUser(username, passwordHash);

            return new LoginDTO {
                UserId = user.UserId,
                RoleName = _roleRepo.GetRoleName(user.UserId),
                IsUserAuthenticated = true
            };
        }
    }
}
