namespace jwt_auth.Dto.response
{
    public class AuthenticatedUserResponse
    {
        public required string AccessToken { get; set; }
        public required string RefreshToken { get; set; }
    }
}