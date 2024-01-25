using System.IdentityModel.Tokens.Jwt;
using jwt_auth.Interfaces;
using Microsoft.IdentityModel.Tokens;

namespace jwt_auth.Reposistories
{
    public class RefreshTokenValidator : IRefreshTokenValidator
    {
        public bool Validate(string refreshToken)
        {
            TokenValidationParameters? validationParameters = null;
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