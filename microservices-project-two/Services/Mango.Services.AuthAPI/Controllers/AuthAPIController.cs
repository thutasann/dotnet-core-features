using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.AuthAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthAPIController : ControllerBase
    {
        private readonly ILogger<AuthAPIController> _logger;

        public AuthAPIController(ILogger<AuthAPIController> logger)
        {
            _logger = logger;
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register()
        {
            return Ok();
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login()
        {
            return Ok();
        }
    }
}