namespace Play.Catalog.Service.Dtos
{
    /// <summary>
    /// ItemDto Record
    /// </summary>
    public record ItemDto(Guid Id, string Name, string Description, decimal Price, DateTimeOffset CreatedDate);

    /// <summary>
    /// CreateItem Dto Record
    /// </summary>
    public record CreateItemDto(string Name, string Description, decimal Price);


    /// <summary>
    /// UpdateItem Dto Record
    /// </summary>
    public record UpdateItemDto(string Name, string Description, decimal Price);
}