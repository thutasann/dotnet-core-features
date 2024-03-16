using AutoMapper;
using Mango.Services.ShoppingCartAPI.Data;
using Mango.Services.ShoppingCartAPI.Dtos;
using Mango.Services.ShoppingCartAPI.Model;
using Mango.Services.ShoppingCartAPI.Services.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.ShoppingCartAPI.Controllers
{
    [Route("api/cart")]
    [ApiController]
    public class ShoppingCartAPIController : ControllerBase
    {
        private readonly ResponseDto _response;
        private readonly IMapper _mapper;
        private readonly AppDbContext _db;
        private readonly IProductService _productService;
        private readonly ICouponService _couponService;

        public ShoppingCartAPIController(AppDbContext db, IMapper mapper, IProductService productService, ICouponService couponService)
        {
            _db = db;
            _response = new ResponseDto();
            _mapper = mapper;
            _productService = productService;
            _couponService = couponService;
        }

        [HttpGet("GetCart/{userId}")]
        public async Task<ResponseDto> GetCart([FromRoute] string userId)
        {
            try
            {
                CartDto cart = new()
                {
                    CartHeader = _mapper.Map<CartHeaderDto>(_db.CartHeaders.First(c => c.UserId == userId))
                };
                cart.CartDetails = _mapper.Map<IEnumerable<CartDetailsDto>>(_db.CartDetails.Where(c => c.CartHeaderId == cart.CartHeader.CartHeaderId));

                IEnumerable<ProductDto> products = await _productService.GetProducts();

                foreach (var item in cart.CartDetails)
                {
                    item.Product = products.FirstOrDefault(p => p.ProductId == item.ProductId)!;
                    cart.CartHeader.CartTotal += item.Count * item.Product.Price;
                }

                // apply coupon if any
                if (!string.IsNullOrEmpty(cart.CartHeader.CouponCode))
                {
                    CouponDto couponDto = await _couponService.GetCoupon(cart.CartHeader.CouponCode);
                    if (couponDto != null && cart.CartHeader.CartTotal > couponDto.MinAmount)
                    {
                        cart.CartHeader.CartTotal -= couponDto.DiscountAmount;
                        cart.CartHeader.Discount = couponDto.DiscountAmount;
                    }
                }

                _response.Data = cart;

            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPost("CartUpsert")]
        public async Task<ResponseDto> CartUpsert([FromBody] CartDto cartDto)
        {
            try
            {
                var cartHeadersFromDb = await _db.CartHeaders.AsNoTracking().FirstOrDefaultAsync(u => u.UserId == cartDto.CartHeader.UserId);
                if (cartHeadersFromDb == null)
                {
                    // create header and details
                    CartHeader cartHeader = _mapper.Map<CartHeader>(cartDto.CartHeader);
                    await _db.CartHeaders.AddAsync(cartHeader);
                    await _db.SaveChangesAsync();

                    cartDto.CartDetails!.First().CartHeaderId = cartHeader.CartHeaderId;
                    await _db.CartDetails.AddAsync(_mapper.Map<CartDetails>(cartDto.CartDetails!.First()));
                    await _db.SaveChangesAsync();
                }
                else
                {
                    // if header is not null
                    // check if details has same product
                    var cartDetailsFromDb = await _db.CartDetails.AsNoTracking().FirstOrDefaultAsync(u => u.ProductId == cartDto.CartDetails!.First().ProductId && u.CartHeaderId == cartHeadersFromDb.CartHeaderId);

                    if (cartDetailsFromDb == null)
                    {
                        // create cart details
                        cartDto.CartDetails!.First().CartHeaderId = cartHeadersFromDb.CartHeaderId;
                        await _db.CartDetails.AddAsync(_mapper.Map<CartDetails>(cartDto.CartDetails!.First()));
                        await _db.SaveChangesAsync();
                    }
                    else
                    {
                        // update count in cart details
                        cartDto.CartDetails!.First().Count += cartDetailsFromDb.Count;
                        cartDto.CartDetails!.First().CartHeaderId = cartDetailsFromDb.CartHeaderId;
                        cartDto.CartDetails!.First().CartDetailsId = cartDetailsFromDb.CartDetailsId;
                        _db.CartDetails.Update(_mapper.Map<CartDetails>(cartDto.CartDetails!.First()));
                        await _db.SaveChangesAsync();
                    }
                }
                _response.Data = cartDto;
            }
            catch (Exception ex)
            {
                _response.Message = ex.Message.ToString();
                _response.IsSuccess = false;
            }
            return _response;
        }

        [HttpPost("RemoveCart")]
        public async Task<ResponseDto> RemoveCart([FromBody] int cartDetailsId)
        {
            try
            {
                CartDetails? cartDetails = await _db.CartDetails.FirstOrDefaultAsync(c => c.CartDetailsId == cartDetailsId);

                int totalCountOfCartItem = _db.CartDetails.Where(u => u.CartHeaderId == cartDetails!.CartHeaderId).Count();

                _db.CartDetails.Remove(cartDetails!);

                if (totalCountOfCartItem == 1)
                {
                    var cartHeaderToRemove = await _db.CartHeaders.FirstOrDefaultAsync(c => c.CartHeaderId == cartDetails!.CartHeaderId);

                    _db.CartHeaders.Remove(cartHeaderToRemove!);
                }

                await _db.SaveChangesAsync();

                _response.Data = true;
            }
            catch (Exception ex)
            {
                _response.Message = ex.Message.ToString();
                _response.IsSuccess = false;
            }
            return _response;
        }

        [HttpPost("ApplyCoupon")]
        public async Task<object> ApplyCoupon([FromBody] CartDto cartDto)
        {
            try
            {
                var cartFromDB = await _db.CartHeaders.FirstAsync(c => c.UserId == cartDto.CartHeader.UserId);
                cartFromDB.CouponCode = cartDto.CartHeader.CouponCode;
                _db.CartHeaders.Update(cartFromDB);
                await _db.SaveChangesAsync();
                _response.Data = true;
            }
            catch (Exception ex)
            {
                _response.Message = ex.Message.ToString();
                _response.IsSuccess = false;
            }
            return _response;
        }

        [HttpPost("RemoveCoupon")]
        public async Task<object> RemoveCoupon([FromBody] CartDto cartDto)
        {
            try
            {
                var cartFromDb = await _db.CartHeaders.FirstAsync(c => c.UserId == cartDto.CartHeader.UserId);
                cartFromDb.CouponCode = "";
                await _db.SaveChangesAsync();
                _response.Data = true;
            }
            catch (Exception ex)
            {
                _response.Message = ex.Message.ToString();
                _response.IsSuccess = false;
            }
            return _response;
        }

    }
}