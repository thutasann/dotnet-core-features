using System.ComponentModel.DataAnnotations;

namespace jwt_auth.Dto
{
    public class LoginRequest
    {
        [Required]
        public required string UserName { get; set; }

        [Required]
        public required string Password { get; set; }
    }
}