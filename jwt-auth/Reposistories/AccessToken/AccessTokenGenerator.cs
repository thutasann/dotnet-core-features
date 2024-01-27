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
                "4y7XS2AHicSOs2uUJCxwlHWqTJNExW3UDUjMeXi96uLEso1YV4RazqQubpFBdx0zZGtdxBelKURhh0WXxPR0mEJQHk_0U9HeYtqcMManhoP3X2Ge8jgxh6k4C_Gd4UPTc6lkx0Ca5eRE16ciFQ6wmYDnaXC8NbngGqartHccAxE",
                "http://localhost:5054/",
                "http://localhost:5054/",
                30,
                claims
            );
        }
    }
}