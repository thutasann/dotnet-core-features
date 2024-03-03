namespace Mango.Services.AuthAPI.Dto
{
    /// <summary>
    /// Login Response Dto
    /// </summary>
    public class LoginResponseDto
    {
        public UserDto? User { get; set; }
        public required string Token { get; set; }
    }
}