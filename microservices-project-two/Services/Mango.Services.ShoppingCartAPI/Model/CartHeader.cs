using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mango.Services.ShoppingCartAPI.Model
{
    /// <summary>
    /// Shopping Cart Header
    /// </summary>
    public class CartHeader
    {
        [Key]
        public int CartHeaderId { get; set; }
        public string? UserId { get; set; }
        public string? CouponCode { get; set; }

        [NotMapped]
        public double Discount { get; set; }

        [NotMapped]
        public double CartTotal { get; set; }
    }
}