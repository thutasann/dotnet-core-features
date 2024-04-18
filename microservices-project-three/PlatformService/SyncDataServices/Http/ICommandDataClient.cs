using PlatformService.Dtos;

namespace PlatformService.SyncDataServices.Http
{
    /// <summary>
    /// Sync HTTP Client
    /// </summary>
    public interface ICommandDataClient
    {
        Task SendPlatformToCommand(PlatformReadDto platformReadDto);
    }
}