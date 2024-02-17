using Play.Common.Interfaces;

namespace Play.Inventory.Service.Entities
{
    /// <summary>
    /// Catalog Item Own Collection
    /// </summary>
    public class CatalogItem : IEntity
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
    }
}