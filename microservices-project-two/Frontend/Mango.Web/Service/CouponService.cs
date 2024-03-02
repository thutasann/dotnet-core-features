using Mango.Web.Models;
using Mango.Web.Service.IService;

namespace Mango.Web.Service
{
    public class CouponService : ICouponService
    {

        private readonly IBaseService _baseService;

        public CouponService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public Task<ResponseDto> CreateCouponAsync(CouponDto couponDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto> DeleteCouponAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto> GetAllCouponsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto> GetCouponAsync(string couponCode)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto> GetCouponByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> UpdateCouponAsync(CouponDto couponDto)
        {
            throw new NotImplementedException();
        }
    }
}