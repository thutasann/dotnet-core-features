namespace Mango.Services.ShoppingCartAPI.Dtos
{
    public class CartDetailsDto
    {
        public int CartDetailsId { get; set; }
        public int CartHeaderId { get; set; }
        public required CartHeaderDto CartHeader { get; set; }
        public int ProductId { get; set; }
        public required ProductDto Product { get; set; }
        public int Count { get; set; }
    }
}