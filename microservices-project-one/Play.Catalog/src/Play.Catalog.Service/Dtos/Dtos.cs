using System.ComponentModel.DataAnnotations;

namespace Play.Catalog.Service.Dtos
{
    /// <summary>
    /// ItemDto Record
    /// </summary>
    public record ItemDto(Guid Id, string Name, string Description, decimal Price, DateTimeOffset CreatedDate);

    /// <summary>
    /// CreateItem Dto Record
    /// </summary>
    public record CreateItemDto([Required] string Name, string Description, [Range(0, 1000)] decimal Price);


    /// <summary>
    /// UpdateItem Dto Record
    /// </summary>
    public record UpdateItemDto([Required] string Name, string Description, [Range(0, 1000)] decimal Price);
}