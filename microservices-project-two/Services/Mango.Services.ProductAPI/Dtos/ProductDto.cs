namespace Mango.Services.ProductAPI.Dtos
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public required string Name { get; set; }
        public double Price { get; set; }
        public required string Description { get; set; }
        public required string CategoryName { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageLocalPath { get; set; }
        public IFormFile? Image { get; set; }
    }
}