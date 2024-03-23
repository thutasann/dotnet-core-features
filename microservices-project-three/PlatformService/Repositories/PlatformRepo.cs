using PlatformService.Data;
using PlatformService.Models;
using PlatformService.Repositories.Interfaces;

namespace PlatformService.Repositories
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext _context;

        public PlatformRepo(AppDbContext context)
        {
            _context = context;
        }

        public void CreatePlatform(Platform platform)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Platform>> GetAllPlatformsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Platform> GetPlatformByIdAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveChanges()
        {
            return await _context.SaveChangesAsync() >= 0;
        }
    }
}