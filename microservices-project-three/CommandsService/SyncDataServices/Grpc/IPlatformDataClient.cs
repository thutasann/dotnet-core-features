using CommandsService.Models;

namespace CommandsService.SyncDataServices.Grpc
{
    /// <summary>
    /// Platform Data Client (gRPC)
    /// </summary>
    public interface IPlatformDataClient
    {
        IEnumerable<Platform>? ReturnAllPlatforms();
    }
}