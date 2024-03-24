using PlatformService.Models;

namespace PlatformService.Repositories.Interfaces
{
    public interface IPlatformRepo
    {
        Task<bool> SaveChanges();
        Task<IEnumerable<Platform>> GetAllPlatformsAsync();
        Task<Platform?> GetPlatformByIdAsync(int id);
        Task CreatePlatformAsync(Platform platform);
    }
}