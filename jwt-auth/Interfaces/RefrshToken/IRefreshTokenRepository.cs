using jwt_auth.Models;

namespace jwt_auth.Interfaces
{
    public interface IRefreshTokenRepository
    {
        Task<RefreshToken?> GetByToken(string token);
        Task Create(RefreshToken refreshToken);
        Task Delete(Guid id);

        /// <summary>
        /// Delete All RefreshTokens related to that UserId when Logout
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task DeleteAll(Guid userId);
    }
}