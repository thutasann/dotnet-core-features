namespace Play.Catalog.Service.Dtos
{
    /// <summary>
    /// Grant Items Dto
    /// </summary>
    public record GrantItemsDto(Guid UserId, Guid CatalogItemId, int Quantity);

    /// <summary>
    /// Inventory Item Dto
    /// </summary>
    public record InventoryItemDto(Guid CatalogItemId, int Quantity, DateTimeOffset AcquiredDate);
}