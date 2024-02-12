namespace Play.Catalog.Service.Dtos
{
    /// <summary>
    /// Grant Items Dto
    /// </summary>
    public record GrantItemsDto(Guid UserId, Guid CatalogItemId, int Quantity);

    /// <summary>
    /// Inventory Item Dto
    /// </summary>
    public record InventoryItemDto(Guid CatalogItemId, string Name, string Description, int Quantity, DateTimeOffset AcquiredDate);

    /// <summary>
    /// Catalog Item Dto Record to Retrive from Catalog Service
    /// </summary>
    public record CatalogItemDto(Guid Id, string Name, string Description);
}