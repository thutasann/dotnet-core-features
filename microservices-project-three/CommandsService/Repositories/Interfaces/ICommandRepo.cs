using CommandsService.Models;

namespace CommandsService.Repositories.Interfaces
{
    public interface ICommandRepo
    {
        bool SaveChanges();
        IEnumerable<Platform> GetAllPlatforms();
        void CreatePlatform(Platform platform);
        bool PlatformExists(int platformId);

        IEnumerable<Command> GetCommandsForPlatform(int platformId);
        Command? GetCommand(int platformId, int commandId);
        void CreateCommand(int platformId, Command command);
        bool EnternalPlatformExists(int externalPlatformId);
    }
}