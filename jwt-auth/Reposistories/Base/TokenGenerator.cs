using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace jwt_auth.Reposistories
{

    /// <summary>
    /// Token Generator Class
    /// </summary>
    public class TokenGenerator
    {
        /// <summary>
        /// Token Generator Extract Method
        /// </summary>
        public string GenerateToken(string secretKey, string issuer, string audience, double expirationMinutes, IEnumerable<Claim>? claims = null)
        {
            SecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            SigningCredentials credentials = new(key, SecurityAlgorithms.HmacSha256);

            JwtSecurityToken token = new(
               issuer,
               audience,
               claims,
               DateTime.UtcNow,
               DateTime.UtcNow.AddMinutes(expirationMinutes),
               credentials
           );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}