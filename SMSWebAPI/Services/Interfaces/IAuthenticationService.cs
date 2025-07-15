using SMSWebAPI.Models.DTOs;

namespace SMSWebAPI.Services.Interfaces {
    public interface IAuthenticationService {
        public LoginDTO Validate(string username, string password);
    }
}
