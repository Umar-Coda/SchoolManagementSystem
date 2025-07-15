using SMSWebAPI.Repos.UserRepo;

namespace SMSWebAPI.Repos.LoginRepo {
    public class LoginRepository : ILoginRepository {
        private readonly IUserRepository _userRepo;

        public LoginRepository(IUserRepository userRepo) {
            _userRepo = userRepo;
        }

        public bool Authenticate(string username, string password)
            => _userRepo.FindUsernameAndPassword(username, password) != null;

        public User GetAuthenticatedUser(string username, string passwordHash)
            => _userRepo.FindUsernameAndPassword(username, passwordHash);
    }
}
