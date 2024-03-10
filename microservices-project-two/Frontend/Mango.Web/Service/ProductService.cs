using Mango.Web.Models;
using Mango.Web.Service.IService;

namespace Mango.Web.Service
{
    public class ProductService : IProductService
    {
        public Task<ResponseDto?> CreateProductAsync(ProductDto productDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> GetAllProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> UpdateProductAsync(ProductDto productDto)
        {
            throw new NotImplementedException();
        }
    }
}