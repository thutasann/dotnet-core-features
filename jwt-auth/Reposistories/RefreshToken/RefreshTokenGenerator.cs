using jwt_auth.Interfaces;

namespace jwt_auth.Reposistories
{
    public class RefreshTokenGenerator : IRefreshTokenGenerator
    {
        private readonly TokenGenerator _tokenGenerator;

        public RefreshTokenGenerator(TokenGenerator tokenGenerator)
        {
            _tokenGenerator = tokenGenerator;
        }

        public string GenerateToken()
        {
            return _tokenGenerator.GenerateToken(
                "3y7XS2AHicSOs2uUJCxwlHWqTJNExW3UDUjMeXi96uLEso1YV4RazqQubpFBdx0zZGtdxBelKURhh0WXxPR0mEJQHk_0U9HeYtqcMManhoP3X2Ge8jgxh6k4C_Gd4UPTc6lkx0Ca5eRE16ciFQ6wmYDnaXC8NbngGqartHccAxE",
                "http://localhost:5054/",
                "http://localhost:5054/",
                131400
            );
        }
    }
}