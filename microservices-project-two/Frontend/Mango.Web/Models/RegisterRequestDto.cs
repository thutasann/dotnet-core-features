namespace Mango.Web.Models
{
    public class RegisterRequestDto
    {
        public required string Email { get; set; }
        public required string Name { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Password { get; set; }
        public string? Role { get; set; }
    }
}