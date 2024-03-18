using Mango.Services.ShoppingCartAPI.Dtos;
using Mango.Services.ShoppingCartAPI.Services.IService;
using Newtonsoft.Json;

namespace Mango.Services.ShoppingCartAPI.Services
{
    public class CouponService : ICouponService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CouponService(IHttpClientFactory clientFactory)
        {
            _httpClientFactory = clientFactory;
        }

        public async Task<CouponDto> GetCoupon(string couponCode)
        {
            var client = _httpClientFactory.CreateClient("Coupon");
            var response = await client.GetAsync($"/api/coupon/GetByCode/{couponCode}");
            var apiContet = await response.Content.ReadAsStringAsync();
            Console.WriteLine("apiContet => " + apiContet);
            var resp = JsonConvert.DeserializeObject<ResponseDto>(apiContet);
            if (resp != null && resp.IsSuccess)
            {
                return JsonConvert.DeserializeObject<CouponDto>(Convert.ToString(resp.Data)!)!;
            }
            return new CouponDto();
        }
    }
}