using Play.Catalog.Service.Dtos;
using Play.Catalog.Service.Entities;

namespace Play.Catalog.Service
{
    public static class Extension
    {
        /// <summary>
        /// Item DTO Mapper Extension
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto(item.Id, item.Name, item.Description, item.Price, item.CreatedAt);
        }
    }
}