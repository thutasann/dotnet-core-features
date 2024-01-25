using jwt_auth.Middleware;
using jwt_auth.Dto;
using Microsoft.AspNetCore.Mvc;
using jwt_auth.Interfaces;
using jwt_auth.Models;
using jwt_auth.Dto.response;

namespace jwt_auth.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    [CustomResponseFormat]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IAccessTokenGenerator _accessTokenGenerator;
        private readonly IRefreshTokenGenerator _refreshTokenGenerator;

        public AuthenticationController(IUserRepository userRepository, IPasswordHasher passwordHasher, IAccessTokenGenerator accessTokenGenerator, IRefreshTokenGenerator refreshTokenGenerator)
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
            _accessTokenGenerator = accessTokenGenerator;
            _refreshTokenGenerator = refreshTokenGenerator;
        }

        [HttpGet("users")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userRepository.GetUsers();
            return Ok(users);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest registerRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequestModelState();
            }

            if (registerRequest.Password != registerRequest.ConfirmPassword)
            {
                return BadRequest(new ErrorResponse("Passwords do not match"));
            }

            User? existingUserByEmail = await _userRepository.GetByEmail(registerRequest.Email);
            if (existingUserByEmail != null)
            {
                return Conflict(new ErrorResponse("Email already exists"));
            }

            User? existingUserByUserName = await _userRepository.GetByUserName(registerRequest.UserName);
            if (existingUserByUserName != null)
            {
                return Conflict(new ErrorResponse("UserName already exists"));
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


        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequestModelState();
            }

            User? user = await _userRepository.GetByUserName(loginRequest.UserName);

            if (user == null)
            {
                return Unauthorized();
            }

            bool isVerifiedPsw = _passwordHasher.VerifyPassword(loginRequest.Password, user.PasswordHash);

            if (!isVerifiedPsw)
            {
                return Unauthorized();
            }

            string accessToken = _accessTokenGenerator.GenerateToken(user);
            string refreshToken = _refreshTokenGenerator.GenerateToken();

            return Ok(new AuthenticatedUserResponse()
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken
            });
        }

        [HttpPost("refresh")]
        public async Task<IActionResult> Refresh([FromBody] RefreshTokenRequest refreshRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequestModelState();
            }

            return Ok();
        }


        /// <summary>
        /// Bad Request Model Errors State
        /// </summary>
        /// <returns></returns>
        private IActionResult BadRequestModelState()
        {
            IEnumerable<string> errorMessages = ModelState.Values.SelectMany(v => v.Errors.Select(e => e.ErrorMessage));
            return BadRequest(new ErrorResponse(errorMessages));
        }
    }
}