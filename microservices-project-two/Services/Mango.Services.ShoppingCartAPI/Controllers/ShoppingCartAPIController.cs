using AutoMapper;
using Mango.Services.ShoppingCartAPI.Data;
using Mango.Services.ShoppingCartAPI.Dtos;
using Mango.Services.ShoppingCartAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mysqlx.Resultset;

namespace Mango.Services.ShoppingCartAPI.Controllers
{
    [Route("api/cart")]
    [ApiController]
    public class ShoppingCartAPIController : ControllerBase
    {
        private ResponseDto _response;
        private IMapper _mapper;
        private readonly AppDbContext _db;

        public ShoppingCartAPIController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _response = new ResponseDto();
            _mapper = mapper;
        }

        [HttpPost("CartUpsert")]
        public async Task<ResponseDto> CartUpsert([FromBody] CartDto cartDto)
        {
            try
            {
                var cartHeadersFromDb = await _db.CartHeaders.FirstOrDefaultAsync(u => u.UserId == cartDto.CartHeader.UserId);
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
                    var cartDetailsFromDb = await _db.CartDetails.FirstOrDefaultAsync(u => u.ProductId == cartDto.CartDetails!.First().ProductId && u.CartHeaderId == cartHeadersFromDb.CartHeaderId);

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
                        cartDto.CartDetails!.First().CartHeaderId += cartDetailsFromDb.CartHeaderId;
                        cartDto.CartDetails!.First().CartDetailsId += cartDetailsFromDb.CartDetailsId;
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
    }
}