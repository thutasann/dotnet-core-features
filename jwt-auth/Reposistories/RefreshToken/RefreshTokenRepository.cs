using jwt_auth.Data;
using jwt_auth.Interfaces;
using jwt_auth.Models;
using Microsoft.EntityFrameworkCore;

namespace jwt_auth.Reposistories
{
    /// <summary>
    /// RefreshToken Repository For Saving Retrieving RefrshToken to Database
    /// </summary>
    public class RefreshTokenRepository : IRefreshTokenRepository
    {
        private readonly DataContext _context;

        public RefreshTokenRepository(DataContext context)
        {
            _context = context;
        }

        public async Task Create(RefreshToken refreshToken)
        {
            refreshToken.Id = new Guid();
            await _context.RefreshTokens.AddAsync(refreshToken);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            await _context.RefreshTokens.Where(r => r.Id == id).ExecuteDeleteAsync();
        }

        public async Task<RefreshToken?> GetByToken(string token)
        {
            RefreshToken? refreshToken = await _context.RefreshTokens.FirstOrDefaultAsync(r => r.Token == token);
            return refreshToken;
        }
    }
}
