using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mango.Services.ShoppingCartAPI.Dtos;

namespace Mango.Services.ShoppingCartAPI.Model
{
    /// <summary>
    /// Shopping Cart Details
    /// </summary>
    public class CartDetails
    {
        [Key]
        public int CartDetailsId { get; set; }
        public int CartHeaderId { get; set; }
        [ForeignKey("CartHeaderId")]
        public required CartHeader CartHeader { get; set; }
        public int ProductId { get; set; }
        [NotMapped]
        public required ProductDto Product { get; set; }
        public int Count { get; set; }
    }
}