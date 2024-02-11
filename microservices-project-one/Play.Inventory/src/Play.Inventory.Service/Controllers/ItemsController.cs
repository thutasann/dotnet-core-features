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
        public async Task<ActionResult> PostAsync(GrantItemsDto grantItemsDto)
        {
            return Ok("Created TODO");
        }
    }
}