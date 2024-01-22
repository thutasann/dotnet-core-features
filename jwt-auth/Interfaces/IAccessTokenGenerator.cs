using jwt_auth.Models;

namespace jwt_auth.Interfaces
{
    public interface IAccessTokenGenerator
    {
        /// <summary>
        /// Generate JWT Token
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        string GenerateToken(User user);
    }
}