namespace SMSWebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase {
    private readonly IAuthenticationService _authService;

    public AuthController(IAuthenticationService authService) {
        _authService = authService;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request) {
        if (string.IsNullOrWhiteSpace(request.Username) || string.IsNullOrWhiteSpace(request.Password)) {
            return BadRequest(new LoginResponse {
                IsUserAuthenticated = false,
                Message = "Username and password are required."
            });
        }

        var result = _authService.Validate(request.Username, request.Password);

        if (!result.IsUserAuthenticated) {
            return Unauthorized(new LoginResponse {
                IsUserAuthenticated = false,
                Message = "Invalid credentials"
            });
        }

        return Ok(new LoginResponse {
            IsUserAuthenticated = true,
            UserId = result.UserId,
            RoleName = result.RoleName,
            Message = "Login successfull"
        });
    }
}
