namespace SMSWebAPI.Repos.UserRepo {
    public interface IUserRepository : IRepository<User> {
        public string CheckUsername(string username);
        public User FindUsernameAndPassword(string username, string password);
        public void UpdateUser(User user, User newUser);
        public int GetUserIdByUsername(string username);
        public HashSet<string> GetUsernames();
    }
}