using System.ComponentModel.DataAnnotations;

namespace Mango.Services.ProductAPI.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public required string Name { get; set; }
        [Range(1, 1000)]
        public double Price { get; set; }
        public required string Description { get; set; }
        public required string CategoryName { get; set; }
        public required string ImageUrl { get; set; }
    }
}