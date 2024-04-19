using CommandsService.Models;

namespace CommandsService.Repositories.Interfaces
{
    public interface ICommandRepo
    {
        bool SaveChanges();

        // --- Platforms
        IEnumerable<Platform> GetAllPlatforms();
        void CreatePlatform(Platform platform);
        bool PlatformExists(int platformId);
        bool ExternalPlatformExists(int externalPlatformId);

        // --- Commands
        IEnumerable<Command> GetCommandsForPlatform(int platformId);
        Command? GetCommand(int platformId, int commandId);
        void CreateCommand(int platformId, Command command);
        bool EnternalPlatformExists(int externalPlatformId);
    }
}