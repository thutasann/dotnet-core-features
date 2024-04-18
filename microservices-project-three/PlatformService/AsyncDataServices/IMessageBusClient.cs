using PlatformService.Dtos;

namespace PlatformService.AsyncDataServices
{
    /// <summary>
    /// Async MessageBusClient (RabbitMQ)
    /// </summary>
    public interface IMessageBusClient
    {
        /// <summary>
        /// Publish New Platform
        /// </summary>
        /// <param name="platformPublishedDto"></param>
        void PublishNewPlatform(PlatformPublishedDto platformPublishedDto);
    }
}