using Mango.Services.ShoppingCartAPI.Dtos;

namespace Mango.Services.ShoppingCartAPI.Services.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}