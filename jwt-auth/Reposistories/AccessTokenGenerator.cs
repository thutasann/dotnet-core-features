using System.Security.Claims;
using jwt_auth.Interfaces;
using jwt_auth.Models;

namespace jwt_auth.Reposistories
{
    public class AccessTokenGenerator : IAccessTokenGenerator
    {
        private readonly TokenGenerator _tokenGenerator;

        public AccessTokenGenerator(TokenGenerator tokenGenerator)
        {
            _tokenGenerator = tokenGenerator;
        }

        public string GenerateToken(User user)
        {
            List<Claim> claims = new()
            {
                new("id", user.Id.ToString()),
                new(ClaimTypes.Email, user.Email),
                new(ClaimTypes.Name, user.UserName)
            };

            return _tokenGenerator.GenerateToken(
                "2SsdtaC3NbTD6PPHCorHBuAJPBlvFtUsVoDRHUNhhc1WNf5oyK39",
                "http://localhost:5054/",
                "http://localhost:5054/",
                30,
                claims
            );
        }
    }
}