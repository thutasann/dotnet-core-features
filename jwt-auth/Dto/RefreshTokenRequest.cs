using System.ComponentModel.DataAnnotations;

namespace jwt_auth.Dto
{
    public class RefreshTokenRequest
    {
        [Required]
        public required string RefreshToken { get; set; }
    }
}