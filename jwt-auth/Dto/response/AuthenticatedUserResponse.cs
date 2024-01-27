namespace jwt_auth.Dto.response
{
    /// <summary>
    /// Authenticated User Response Format
    /// </summary>
    public class AuthenticatedUserResponse
    {
        public required string AccessToken { get; set; }
        public required string RefreshToken { get; set; }
    }
}