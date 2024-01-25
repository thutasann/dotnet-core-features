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
                "2SsdtaC3NbTD6PPHCorHBuAJPBlvFtUsVoDRHUNhhc1WNf5o12312fa9",
                "http://localhost:5054/",
                "http://localhost:5054/",
                131400
            );
        }
    }
}