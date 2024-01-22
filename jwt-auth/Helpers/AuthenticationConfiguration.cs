namespace jwt_auth.Helpers
{
    public class AuthenticationConfiguration
    {

        public required string AccessTokenSecret { get; set; }
        public int AccessTokenExpirationMinutes { get; set; }
        public required string Issuer { get; set; }
        public required string Audience { get; set; }

        public AuthenticationConfiguration(string AccessTokenSecret, int AccessTokenExpirationMinutes, string Issuer, string Audience)
        {
            this.AccessTokenSecret = AccessTokenSecret;
            this.AccessTokenExpirationMinutes = AccessTokenExpirationMinutes;
            this.Issuer = Issuer;
            this.Audience = Audience;
        }

        public AuthenticationConfiguration()
        {
        }
    }
}