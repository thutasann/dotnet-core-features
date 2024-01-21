using jwt_auth.Middleware;
using jwt_auth.Dto;
using Microsoft.AspNetCore.Mvc;
using jwt_auth.Interfaces;
using jwt_auth.Models;

namespace jwt_auth.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    [CustomResponseFormat]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher _passwordHasher;

        public AuthenticationController(IUserRepository userRepository, IPasswordHasher passwordHasher)
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
        }

        [HttpGet("users")]
        public IActionResult GetAllUsers()
        {
            return Ok(_userRepository.GetUsers());
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest registerRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (registerRequest.Password != registerRequest.ConfirmPassword)
            {
                return BadRequest("Please confirm the password again");
            }

            User existingUserByEmail = await _userRepository.GetByEmail(registerRequest.Email);
            if (existingUserByEmail != null)
            {
                return Conflict("Already exists");
            }

            User existingUserByUserName = await _userRepository.GetByUserName(registerRequest.UserName);
            if (existingUserByUserName != null)
            {
                return Conflict("Already exists");
            }

            string passwordHash = _passwordHasher.HasPassword(registerRequest.Password);
            User registirationUser = new()
            {
                Email = registerRequest.Email,
                UserName = registerRequest.UserName,
                PasswordHash = passwordHash
            };

            await _userRepository.Create(registirationUser);
            return Ok(registirationUser);
        }
    }
}