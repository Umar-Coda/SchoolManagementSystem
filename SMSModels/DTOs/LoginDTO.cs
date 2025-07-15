
namespace SMSModels.DTOs {
    public class LoginDTO {
        public int UserId { get; set; }
        public string? RoleName { get; set; }
        public bool IsUserAuthenticated { get; set; }
    }
}
