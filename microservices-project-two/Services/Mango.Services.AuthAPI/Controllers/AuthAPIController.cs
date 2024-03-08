using Mango.Services.AuthAPI.Dto;
using Mango.Services.AuthAPI.Service.IService;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.AuthAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthAPIController : ControllerBase
    {
        private readonly ILogger<AuthAPIController> _logger;
        private readonly IAuthService _authService;
        protected ResponseDto _response;

        public AuthAPIController(ILogger<AuthAPIController> logger, IAuthService authService)
        {
            _logger = logger;
            _authService = authService;
            _response = new();
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register([FromBody] RegisterationRequestDto model)
        {
            _logger.LogInformation("Register API Calling...");
            string? errorMessage = await _authService.Register(model);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                _response.IsSuccess = false;
                _response.Message = errorMessage;
                return BadRequest(_response);
            }
            _response.IsSuccess = true;
            _response.Message = "Register Successfully";
            return Ok(_response);
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] LoginRequestDto loginResponseDto)
        {
            var loginResponse = await _authService.Login(loginResponseDto);
            if (loginResponse.User == null)
            {
                _response.IsSuccess = false;
                _response.Message = "Username or password is incorrect";
                return BadRequest(_response);
            }
            _response.Data = loginResponse;
            return Ok(_response);
        }

        [HttpPost("AssignRole")]
        public async Task<ActionResult> AssignRole([FromBody] RegisterationRequestDto model)
        {
            var assignRoleSuccessful = await _authService.AssignRole(model.Email, model.Role!.ToUpper());
            if (!assignRoleSuccessful)
            {
                _response.IsSuccess = false;
                _response.Message = "Error encounter when assigning role";
                return BadRequest(_response);
            }
            return Ok(_response);
        }

        [HttpGet("Users")]
        public async Task<ActionResult> GetAllUsers()
        {
            var users = await _authService.GetAllUsers();
            if (users == null)
            {
                _response.IsSuccess = true;
                _response.Data = users;
                _response.Message = "No Users Found";
            }
            _response.Data = users;
            return Ok(_response);
        }

    }
}