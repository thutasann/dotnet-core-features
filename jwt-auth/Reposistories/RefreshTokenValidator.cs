using System.IdentityModel.Tokens.Jwt;
using System.Text;
using jwt_auth.Interfaces;
using Microsoft.IdentityModel.Tokens;

namespace jwt_auth.Reposistories
{
    public class RefreshTokenValidator : IRefreshTokenValidator
    {
        public bool Validate(string refreshToken)
        {
            TokenValidationParameters validationParameters = new()
            {
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("2SsdtaC3NbTD6PPHCorHBuAJPBlvFtUsVoDRHUNhhc1WNf5oyK39")),
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
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}