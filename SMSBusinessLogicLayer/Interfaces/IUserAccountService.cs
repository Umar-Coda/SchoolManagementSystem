
namespace SMSBusinessLogicLayer.Interfaces {
    public interface IUserAccountService {
        public void CreateAccount(User userAccount);
        public int GetUserId(string username);
        public HashSet<string> GetUsernames();
        public void Refresh();
    }
}
