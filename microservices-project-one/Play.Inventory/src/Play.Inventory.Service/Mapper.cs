using Play.Catalog.Service.Dtos;
using Play.Inventory.Service.Entities;

namespace Play.Inventory.Service
{
    public static class Mapper
    {
        /// <summary>
        /// Inventory Item DTO Mapper
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static InventoryItemDto AsDto(this InventoryItem item, string name, string Description)
        {
            return new InventoryItemDto(item.CatalogItemId, name, Description, item.Quantity, item.AcquiredDate);
        }
    }
}