using MassTransit;
using Play.Catalog.Contracts;
using Play.Common.Interfaces;
using Play.Inventory.Service.Entities;

namespace Play.Inventory.Service.Consumers
{
    /// <summary>
    /// Catalog Item Created <b>Consumer</b>
    /// </summary>
    public class CatalogItemCreatedConsumer : IConsumer<CatalogItemCreated>
    {
        private readonly IRepository<CatalogItem> _repository;
        private readonly ILogger<CatalogItemCreatedConsumer> _logger;

        public CatalogItemCreatedConsumer(IRepository<CatalogItem> repository, ILogger<CatalogItemCreatedConsumer> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task Consume(ConsumeContext<CatalogItemCreated> context)
        {
            var message = context.Message;
            var item = await _repository.GetAsync(message.ItemId);
            if (item != null)
            {
                _logger.LogWarning("Item not Found");
                return;
            }

            item = new CatalogItem
            {
                Id = message.ItemId,
                Name = message.Name,
                Description = message.Description
            };

            await _repository.CreateAsync(item);
        }
    }
}