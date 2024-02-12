using Microsoft.AspNetCore.Mvc;
using Play.Catalog.Service.Dtos;
using Play.Catalog.Service.Entities;
using Play.Catalog.Service.Middlewares;
using Play.Common.Interfaces;

namespace Play.Catalog.Service.Controllers
{
    [Route("items")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IRepository<Item> _itemsRepository;
        private readonly ILogger<ItemsController> _logger;

        public ItemsController(IRepository<Item> itemsRepository, ILogger<ItemsController> logger)
        {
            _itemsRepository = itemsRepository;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyCollection<Item>>> Get()
        {
            _logger.LogInformation("Retrieving Catalog Items");
            var items = await _itemsRepository.GetAllAsync();
            var itemDto = items.Select(s => s.AsDto());
            return Ok(itemDto);
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

            return Ok("Item Deleted");
        }
    }
}