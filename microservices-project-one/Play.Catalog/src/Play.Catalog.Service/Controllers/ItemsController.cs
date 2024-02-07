using Microsoft.AspNetCore.Mvc;
using Play.Catalog.Service.Dtos;

namespace Play.Catalog.Service.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        /// <summary>
        /// In-Memory Items (For now)
        /// </summary>
        public static readonly List<ItemDto> items = new()
        {
            new ItemDto(Guid.NewGuid(), "Potion", "Restore a small amount of HP", 5, DateTimeOffset.UtcNow),
            new ItemDto(Guid.NewGuid(), "Antitode", "Cure Poision", 7, DateTimeOffset.UtcNow),
            new ItemDto(Guid.NewGuid(), "Bonze sword", "Deals a small amount of damange", 5, DateTimeOffset.UtcNow)
        };

        [HttpGet]
        public IEnumerable<ItemDto> Get()
        {
            return items;
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            var item = items.Where(item => item.Id == id).FirstOrDefault();
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        public ActionResult<ItemDto> Create([FromForm] CreateItemDto createItemDto)
        {
            var item = new ItemDto(Guid.NewGuid(), createItemDto.Name, createItemDto.Description, createItemDto.Price, DateTimeOffset.UtcNow);

            if (item == null)
            {
                return BadRequest("Please enter all information");
            }

            items.Add(item);

            return CreatedAtAction(nameof(GetById), new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] Guid id, [FromForm] UpdateItemDto updateItemDto)
        {
            var existingItem = items.Where(item => item.Id == id).FirstOrDefault();

            if (existingItem == null)
            {
                return NotFound("Item Not Found");
            }

            var updatedItem = existingItem with
            {
                Name = updateItemDto.Name,
                Description = updateItemDto.Description,
                Price = updateItemDto.Price,
            };

            var index = items.FindIndex(item => item.Id == id);
            items[index] = updatedItem;

            return Ok("Item Updated successfully!");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var index = items.FindIndex(item => item.Id == id);

            if (index < 0)
            {
                return NotFound("Item Not Found");
            }

            items.RemoveAt(index);
            return Ok("Item Deleted");
        }
    }
}