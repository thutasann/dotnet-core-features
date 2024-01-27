using jwt_auth.Models;

namespace jwt_auth.Interfaces
{
    public interface IRefreshTokenRepository
    {
        Task<RefreshToken?> GetByToken(string token);
        Task Create(RefreshToken refreshToken);
    }
}