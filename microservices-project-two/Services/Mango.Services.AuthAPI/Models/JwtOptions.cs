namespace Mango.Services.AuthAPI.Models
{
    /// <summary>
    /// JWT Options
    /// </summary>
    public class JwtOptions
    {
        public string Issuer { get; set; } = string.Empty;
        public string Audience { get; set; } = string.Empty;
        public string Secret { get; set; } = string.Empty;
    }
}