using AutoMapper;
using Mango.Services.CouponAPI.Data;
using Mango.Services.CouponAPI.Dto;
using Mango.Services.CouponAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.CouponAPI.Controllers
{
    [ApiController]
    [Route("api/coupon")]
    public class CouponAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        private readonly ILogger<CouponAPIController> _logger;
        private readonly ResponseDto<object> _response;
        private readonly IMapper _mapper;

        public CouponAPIController(AppDbContext db, ILogger<CouponAPIController> logger, IMapper mapper)
        {
            _db = db;
            _logger = logger;
            _response = new ResponseDto<object>();
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<ResponseDto<IEnumerable<CouponDto>>>> GetAllCoupons()
        {
            try
            {
                IEnumerable<Coupon> coupons = await _db.Coupons.ToListAsync();
                _response.Data = _mapper.Map<IEnumerable<CouponDto>>(coupons);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
                _logger.LogError("Exception in Get All Coupons ", ex.Message);
            }

            return Ok(_response);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ResponseDto<CouponDto>>> GetCoupon([FromRoute] int id)
        {
            try
            {
                Coupon? coupon = await _db.Coupons.FirstOrDefaultAsync(u => u.CouponId == id);

                if (coupon == null)
                {
                    return NotFound(_response.Message = "Coupon Not Found");
                }
                return Ok(_response.Data = _mapper.Map<CouponDto>(coupon));
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
                _logger.LogError("Exception in Get All Coupons ", ex.Message);
            }

            return Ok(_response);
        }

        [HttpGet("GetByCode/{code}")]
        public async Task<ActionResult<ResponseDto<CouponDto>>> GetCouponByCode([FromRoute] string code)
        {
            try
            {
                Coupon? coupon = await _db.Coupons.FirstOrDefaultAsync(c => c.CouponCode.ToLower() == code.ToLower());
                if (coupon == null)
                {
                    return NotFound(_response.Message = "Coupon Not Found");
                }
                return Ok(_response.Data = _mapper.Map<CouponDto>(coupon));
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return Ok(_response);
        }

        [HttpPost]
        public async Task<ActionResult<ResponseDto<CouponDto>>> CreateCoupon([FromBody] CouponDto couponDto)
        {
            try
            {
                Coupon coupon = _mapper.Map<Coupon>(couponDto);
                await _db.Coupons.AddAsync(coupon);
                await _db.SaveChangesAsync();
                _response.Data = _mapper.Map<CouponDto>(coupon);
                _response.Message = "Coupon Created successfully";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return Ok(_response);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<ResponseDto<CouponDto>>> UpdateCoupon([FromRoute] int id, [FromBody] CouponDto couponDto)
        {
            try
            {
                var existingCoupon = await _db.Coupons.FirstOrDefaultAsync(c => c.CouponId == id);

                if (existingCoupon == null)
                {
                    _response.Message = "Coupon not found";
                    return NotFound();
                }

                existingCoupon.CouponCode = couponDto.CouponCode;
                existingCoupon.DiscountAmount = couponDto.DiscountAmount;
                existingCoupon.MinAmount = couponDto.MinAmount;

                await _db.SaveChangesAsync();

                _response.Data = _mapper.Map<CouponDto>(existingCoupon);
                _response.Message = "Coupon Updated successfully";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return Ok(_response);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteCoupon([FromRoute] int id)
        {
            try
            {
                Coupon? coupon = await _db.Coupons.FirstOrDefaultAsync(c => c.CouponId == id);

                if (coupon == null)
                {
                    return NotFound("Coupon Not found");
                }

                _db.Coupons.Remove(coupon);
                await _db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogInformation("Coupon Delete Exception ", ex.Message);
            }
            return Ok("Coupon Deleted");
        }
    }

}