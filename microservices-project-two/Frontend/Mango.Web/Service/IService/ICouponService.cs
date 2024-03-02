using Mango.Web.Models;

namespace Mango.Web.Service.IService
{
    public interface ICouponService
    {
        Task<ResponseDto<CouponDto>?> GetCouponAsync(string couponCode);
        Task<ResponseDto<IEnumerable<CouponDto>>?> GetAllCouponsAsync();
        Task<ResponseDto<CouponDto>?> GetCouponByIdAsync(int id);
        Task<ResponseDto<CouponDto>> CreateCouponAsync(CouponDto couponDto);
        Task<ResponseDto<CouponDto>?> UpdateCouponAsync(CouponDto couponDto);
        Task<ResponseDto<object>> DeleteCouponAsync(int id);
    }
}