using AutoMapper;
using Mango.Services.CouponAPI.Data;
using Mango.Services.CouponAPI.Dto;
using Mango.Services.CouponAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.CouponAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
                return Ok(_response.Data = _mapper.Map<IEnumerable<CouponDto>>(coupons));
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

    }

}