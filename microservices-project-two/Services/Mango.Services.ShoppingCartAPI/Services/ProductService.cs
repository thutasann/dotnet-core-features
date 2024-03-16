using System.Text.Json.Serialization;
using Mango.Services.ShoppingCartAPI.Dtos;
using Mango.Services.ShoppingCartAPI.Services.IService;
using Microsoft.AspNetCore.Authentication;
using Newtonsoft.Json;

namespace Mango.Services.ShoppingCartAPI.Services
{
    public class ProductService : IProductService
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public ProductService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            var client = _httpClientFactory.CreateClient("Product");
            var response = await client.GetAsync($"/api/product");
            var apiContent = await response.Content.ReadAsStringAsync();
            var resp = JsonConvert.DeserializeObject<ResponseDto>(apiContent);
            if (resp != null && resp.IsSuccess)
            {
                return JsonConvert.DeserializeObject<IEnumerable<ProductDto>>(Convert.ToString(resp.Data)!)!;
            }
            return new List<ProductDto>();
        }
    }
}