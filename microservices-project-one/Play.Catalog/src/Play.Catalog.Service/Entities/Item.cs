using Play.Common.Interfaces;

namespace Play.Catalog.Service.Entities
{
    public class Item : IEntity
    {
        public required Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public decimal Price { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}