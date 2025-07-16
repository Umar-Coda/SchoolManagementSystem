

namespace SMSWebAPI.Repos.UserRepo {
    public class UserRepository : BaseRepository<User>, IUserRepository {
        public UserRepository(SchoolContext context) : base(context) { }

        public string CheckUsername(string username) {
            return _dbSet.FirstOrDefault(
                user => user.Username == username)?.Username!;
        }

        public User? FindUsernameAndPassword(string username, string password) {
            return _dbSet.FirstOrDefault(
                user => user.Username == username && user.PasswordHash == password);
        }

        public int GetUserIdByUsername(string username) {
            return _dbSet
                .Where(user => user.Username == username)
                .Select(user => user.UserId)
                .FirstOrDefault();
        }

        public void UpdateUser(User user, User newUser) {
            _context.Entry(user).CurrentValues.SetValues(newUser);
            _context.SaveChanges();
        }

        public HashSet<string> GetUsernames() {
            var data = new HashSet<string>();
            data = _dbSet.Select(user => user.Username).ToHashSet();
            return data;
        }
    }
}
