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
        public static InventoryItemDto AsDto(this InventoryItem item)
        {
            return new InventoryItemDto(item.CatalogItemId, item.Quantity, item.AcquiredDate);
        }
    }
}