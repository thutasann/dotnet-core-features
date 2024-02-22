using System.ComponentModel.DataAnnotations;

namespace Mango.Services.CouponAPI.Models
{
    /// <summary>
    /// Coupon Model
    /// </summary>
    public class Coupon
    {
        [Key]
        public int CouponId { get; set; }

        [Required]
        public required string CouponCode { get; set; }

        [Required]
        public double DiscountAmount { get; set; }

        public int MinAmount { get; set; }
    }
}