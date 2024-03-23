using PlatformService.Models;

namespace PlatformService.Repositories.Interfaces
{
    public interface IPlatformRepo
    {
        Task<bool> SaveChanges();
        Task<IEnumerable<Platform>> GetAllPlatformsAsync();
        Task<Platform> GetPlatformByIdAsync();
        void CreatePlatform(Platform platform);
    }
}