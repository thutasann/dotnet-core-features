using MassTransit;
using Play.Catalog.Contracts;
using Play.Common.Interfaces;
using Play.Inventory.Service.Entities;

namespace Play.Inventory.Service.Consumers
{
    /// <summary>
    /// Catalog Item Deleted <b>Consumer</b>
    /// </summary>
    public class CatalogItemDeletedConsumer : IConsumer<CatalogItemDeleted>
    {
        private readonly IRepository<CatalogItem> _repository;
        private readonly ILogger<CatalogItemDeleted> _logger;

        public CatalogItemDeletedConsumer(IRepository<CatalogItem> repository, ILogger<CatalogItemDeleted> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task Consume(ConsumeContext<CatalogItemDeleted> context)
        {
            var message = context.Message;
            var item = await _repository.GetAsync(message.ItemId);
            if (item == null)
            {
                _logger.LogWarning("Item not Found");
                return;
            }
            await _repository.RemoveAsync(message.ItemId);
        }
    }
}