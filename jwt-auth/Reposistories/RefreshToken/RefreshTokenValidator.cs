using System.IdentityModel.Tokens.Jwt;
using System.Text;
using jwt_auth.Interfaces;
using Microsoft.IdentityModel.Tokens;

namespace jwt_auth.Reposistories
{
    public class RefreshTokenValidator : IRefreshTokenValidator
    {
        private readonly ILogger<RefreshTokenValidator> _logger;


        public RefreshTokenValidator(ILogger<RefreshTokenValidator> logger)
        {
            _logger = logger;
        }

        public bool Validate(string refreshToken)
        {
            TokenValidationParameters validationParameters = new()
            {
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("3y7XS2AHicSOs2uUJCxwlHWqTJNExW3UDUjMeXi96uLEso1YV4RazqQubpFBdx0zZGtdxBelKURhh0WXxPR0mEJQHk_0U9HeYtqcMManhoP3X2Ge8jgxh6k4C_Gd4UPTc6lkx0Ca5eRE16ciFQ6wmYDnaXC8NbngGqartHccAxE")),
                ValidIssuer = "http://localhost:5054/",
                ValidAudience = "http://localhost:5054/",
                ValidateIssuerSigningKey = true,
                ValidateIssuer = true,
                ValidateAudience = true,
                ClockSkew = TimeSpan.Zero
            };

            JwtSecurityTokenHandler tokenHandler = new();

            try
            {
                tokenHandler.ValidateToken(refreshToken, validationParameters, out SecurityToken validatedToken);
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError("RefreshToken validate error => ", e.Message);
                return false;
            }
        }
    }
}