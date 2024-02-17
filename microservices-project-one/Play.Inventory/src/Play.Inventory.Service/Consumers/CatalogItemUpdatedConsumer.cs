using MassTransit;
using Play.Catalog.Contracts;
using Play.Common.Interfaces;
using Play.Inventory.Service.Entities;

namespace Play.Inventory.Service.Consumers
{
    /// <summary>
    /// Catalog Item Updated <b>Consumer</b>
    /// </summary>
    public class CatalogItemUpdatedConsumer : IConsumer<CatalogItemUpdated>
    {
        private readonly IRepository<CatalogItem> _repository;
        private readonly ILogger<CatalogItemUpdatedConsumer> _logger;

        public CatalogItemUpdatedConsumer(IRepository<CatalogItem> repository, ILogger<CatalogItemUpdatedConsumer> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task Consume(ConsumeContext<CatalogItemUpdated> context)
        {
            var message = context.Message;
            var item = await _repository.GetAsync(message.ItemId);

            if (item == null)
            {
                _logger.LogWarning("Item Created Consume");
                item = new CatalogItem
                {
                    Id = message.ItemId,
                    Name = message.Name,
                    Description = message.Description
                };

                await _repository.CreateAsync(item);
            }
            else
            {
                _logger.LogWarning("Item Updated Consume");
                item.Name = message.Name;
                item.Description = message.Description;
                await _repository.UpdateAsync(item);
            }

        }
    }
}