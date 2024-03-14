namespace Mango.Services.ShoppingCartAPI.Dtos
{
    /// <summary>
    /// CouponDTO
    /// </summary>
    public class CouponDto
    {
        public int CouponId { get; set; }
        public required string CouponCode { get; set; }
        public double DiscountAmount { get; set; }
        public int MinAmount { get; set; }
    }
}