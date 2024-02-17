using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Play.Catalog.Contracts;
using Play.Catalog.Service.Dtos;
using Play.Catalog.Service.Entities;
using Play.Common.Interfaces;

namespace Play.Catalog.Service.Controllers
{
    [Route("items")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IRepository<Item> _itemsRepository;
        private readonly ILogger<ItemsController> _logger;
        private readonly IPublishEndpoint _publishEndpoint;

        public ItemsController(IRepository<Item> itemsRepository, ILogger<ItemsController> logger, IPublishEndpoint publishEndpoint)
        {
            _itemsRepository = itemsRepository;
            _logger = logger;
            _publishEndpoint = publishEndpoint;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyCollection<Item>>> Get()
        {
            // if (requestCounter <= 2)
            // {
            //     _logger.LogInformation($"Request {requestCounter} Delaying..");
            //     await Task.Delay(TimeSpan.FromSeconds(3)); // retries testing purpose
            // }

            // if (requestCounter <= 4)
            // {
            //     _logger.LogInformation($"Request {requestCounter} 500 (Internal Server Error)..");
            //     return StatusCode(500); // retries testing purpose
            // }

            var items = (await _itemsRepository.GetAllAsync()).Select(s => s.AsDto());
            return Ok(items);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingleItem([FromRoute] Guid id)
        {
            _logger.LogInformation("itemId => " + id);
            var item = await _itemsRepository.GetAsync(id);
            if (item == null)
            {
                return NotFound("Item Not Found");
            }
            return Ok(item.AsDto());
        }

        [HttpPost]
        public async Task<ActionResult<ItemDto>> Create([FromForm] CreateItemDto createItemDto)
        {
            var item = new Item
            {
                Id = new Guid(),
                Name = createItemDto.Name,
                Description = createItemDto.Description,
                Price = createItemDto.Price,
                CreatedAt = DateTimeOffset.UtcNow
            };

            await _itemsRepository.CreateAsync(item);
            await _publishEndpoint.Publish(new CatalogItemCreated(item.Id, item.Name, item.Description));

            return CreatedAtAction(nameof(GetSingleItem), new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put([FromRoute] Guid id, [FromForm] UpdateItemDto updateItemDto)
        {
            _logger.LogInformation("itemId => ", id);
            var existingItem = await _itemsRepository.GetAsync(id);

            if (existingItem == null)
            {
                return NotFound("Item Not Found");
            }

            existingItem.Name = updateItemDto.Name;
            existingItem.Description = updateItemDto.Description;
            existingItem.Price = updateItemDto.Price;

            await _itemsRepository.UpdateAsync(existingItem);

            await _publishEndpoint.Publish(new CatalogItemUpdated(existingItem.Id, existingItem.Name, existingItem.Description));

            return Ok("Item Updated successfully!");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var existingItem = await _itemsRepository.GetAsync(id);

            if (existingItem == null)
            {
                return NotFound();
            }

            await _itemsRepository.RemoveAsync(existingItem.Id);

            await _publishEndpoint.Publish(new CatalogItemDeleted(id));

            return Ok("Item Deleted");
        }
    }
}