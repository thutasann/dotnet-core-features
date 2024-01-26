namespace jwt_auth.Models
{
    public class RefreshToken
    {
        public Guid Id { get; set; }
        public required string Token { get; set; }
        public Guid UserId { get; set; }
    }
}