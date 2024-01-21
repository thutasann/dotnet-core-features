using System.ComponentModel.DataAnnotations;

namespace jwt_auth.Dto
{
    public class RegisterRequest
    {
        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        public required string UserName { get; set; }

        [Required]
        public required string Password { get; set; }

        [Required]
        public required string ConfirmPassword { get; set; }
    }
}