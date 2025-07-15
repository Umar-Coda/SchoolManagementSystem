namespace SMSWebAPI.Models.LoginModels;
public class LoginResponse {
    public bool IsUserAuthenticated { get; set; }
    public int UserId { get; set; }
    public string RoleName { get; set; } = string.Empty;
    public string? Message { get; set; }
}

