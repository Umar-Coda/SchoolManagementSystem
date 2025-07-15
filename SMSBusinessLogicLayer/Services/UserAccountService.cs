

namespace SMSBusinessLogicLayer.Services {
    /// <summary>
    /// Responsiblity --> Manages user accounts (create account)
    /// </summary>
    public class UserAccountService : IUserAccountService {
        private readonly IRepositoryFactory _repoFactory;
        private readonly IUserRepository _userRepo;

        private HashSet<string> _usernames;

        public UserAccountService(IRepositoryFactory repoFactory) {
            _repoFactory = repoFactory;
            _userRepo = _repoFactory.GetUserRepository();

            _usernames = _userRepo.GetUsernames();
        }

        public void CreateAccount(User userAccount) {
            string passwordHash = PasswordHasher.HashPassword(userAccount.PasswordHash);

            var user = new User {
                Username = userAccount.Username,
                PasswordHash = passwordHash,
                CreatedAt = userAccount.CreatedAt,
                RoleId = userAccount.RoleId
            };

            _userRepo.Add(user);
        }

        public int GetUserId(string username)
            => _userRepo.GetUserIdByUsername(username);

        public HashSet<string> GetUsernames() => _usernames;

        public void Refresh() {
            _usernames = _userRepo.GetUsernames();
        }
    }
}
