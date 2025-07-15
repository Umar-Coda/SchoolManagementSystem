namespace SMSBusinessLogicLayer.Interfaces {
    public interface IAuthenticationService {
        public LoginDTO Validate(string username, string password);
    }
}
