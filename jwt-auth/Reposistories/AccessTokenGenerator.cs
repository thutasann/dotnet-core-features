using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using jwt_auth.Interfaces;
using jwt_auth.Models;
using Microsoft.IdentityModel.Tokens;

namespace jwt_auth.Reposistories
{
    public class AccessTokenGenerator : IAccessTokenGenerator
    {
        static readonly SecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("2SsdtaC3NbTD6PPHCorHBuAJPBlvFtUsVoDRHUNhhc1WNf5oyK39"));
        readonly SigningCredentials credentials = new(key, SecurityAlgorithms.HmacSha256);

        public string GenerateToken(User user)
        {
            List<Claim> claims = new()
            {
                new("id", user.Id.ToString()),
                new(ClaimTypes.Email, user.Email),
                new(ClaimTypes.Name, user.UserName)
            };

            JwtSecurityToken token = new(
                "http://localhost:5054/",
                "http://localhost:5054/",
                claims,
                DateTime.UtcNow,
                DateTime.UtcNow.AddMinutes(30),
                credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}