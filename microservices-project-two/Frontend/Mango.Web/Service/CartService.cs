using Mango.Web.Models;
using Mango.Web.Service.IService;

namespace Mango.Web.Service
{
    public class CartService : ICartService
    {
        private readonly IBaseService _baseService;

        public CartService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public Task<ResponseDto> ApplyCouponAsync(CartDto cartDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto> EmailCart(CartDto cartDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto> GetCartByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto> RemoveFromCartAsync(int cartDetailsId)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto> UpsertCartAsync(CartDto cartDto)
        {
            throw new NotImplementedException();
        }
    }
}