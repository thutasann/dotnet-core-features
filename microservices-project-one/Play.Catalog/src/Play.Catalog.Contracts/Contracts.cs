namespace Play.Catalog.Contracts
{
    /// <summary>
    /// Created Catalog Item for Publishing Messages
    /// </summary>
    /// <param name="ItemId"></param>
    /// <param name="Name"></param>
    /// <param name="Description"></param>
    public record CatalogItemCreated(Guid ItemId, string Name, string Description);

    /// <summary>
    /// Updated Catalog Item for Publishing Messages
    /// </summary>
    /// <param name="ItemId"></param>
    /// <param name="Name"></param>
    /// <param name="Description"></param>
    public record CatalogItemUpdated(Guid ItemId, string Name, string Description);

    /// <summary>
    /// Deleted Catalog Item for Publishing Messages
    /// </summary>
    /// <param name="ItemId"></param>
    public record CatalogItemDeleted(Guid ItemId);
}