namespace Mango.Services.ShoppingCartAPI.Dtos
{
    public class CartDto
    {
        public required CartHeaderDto CartHeader { get; set; }
        public IEnumerable<CartDetailsDto>? CartDetails { get; set; }
    }
}