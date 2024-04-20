using ef_core_relationships.Data;
using ef_core_relationships.Dto;
using ef_core_relationships.Interfaces;
using ef_core_relationships.Mapper;
using Microsoft.AspNetCore.Mvc;

namespace ef_core_relationships.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _userRepo;

        public UserController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userRepo.GetAllUsersAsync();
            return Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> AddUser([FromForm] UserCreateDto userCreateDto)
        {
            var userModel = userCreateDto.ToUserFromCreateDTO();
            await _userRepo.CreateUserAsync(userModel);
            return Ok(userModel);
        }
    }
}