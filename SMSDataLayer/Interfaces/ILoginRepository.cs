
namespace SMSDataLayer.Interfaces {
    public interface ILoginRepository {
        public bool Authenticate(string username, string password);
        public User GetAuthenticatedUser(string username, string passwordHash);
    }
}
