using Microsoft.AspNetCore.Mvc;
using Play.Catalog.Service.Dtos;
using Play.Common.Interfaces;
using Play.Inventory.Service.Entities;
using Play.Inventory.Service.Middlewares;

namespace Play.Inventory.Service.Controllers
{
    [Route("items")]
    [ApiController]
    [CustomResponseFormat]
    public class ItemsController : ControllerBase
    {
        private readonly IRepository<InventoryItem> _itemsRepository;

        public ItemsController(IRepository<InventoryItem> itemsRepository)
        {
            _itemsRepository = itemsRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<InventoryItemDto>>> GetAsync(Guid userId)
        {
            if (userId == Guid.Empty)
            {
                return BadRequest("Invalid User Id");
            }

            var items = (await _itemsRepository.GetAllAsync(item => item.UserId == userId)).Select(s => s.AsDto());

            return Ok(items);
        }

        [HttpPost]
        // f5cd0e87-5b2e-4c1a-a901-9b6d53c70b1d (sample user id)
        public async Task<ActionResult> PostAsync([FromForm] GrantItemsDto grantItemsDto)
        {
            var inventoryItem = await _itemsRepository.GetAsync(item => item.UserId == grantItemsDto.UserId && item.CatalogItemId == grantItemsDto.CatalogItemId);

            if (inventoryItem == null)
            {
                inventoryItem = new InventoryItem
                {
                    UserId = grantItemsDto.UserId,
                    CatalogItemId = grantItemsDto.CatalogItemId,
                    Quantity = grantItemsDto.Quantity,
                    AcquiredDate = DateTimeOffset.UtcNow,
                };
                await _itemsRepository.CreateAsync(inventoryItem);
            }
            else
            {
                inventoryItem.Quantity += grantItemsDto.Quantity;
                await _itemsRepository.UpdateAsync(inventoryItem);
            }

            return Ok(inventoryItem == null ? "Item Created" : "Item Updated");
        }
    }
}