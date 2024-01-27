using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using jwt_auth.Middleware;

namespace jwt_auth.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    [CustomResponseFormat]
    public class HomeController : ControllerBase
    {
        [HttpGet("/home")]
        [Authorize]
        public IActionResult Index()
        {
            return Ok("Authenticated");
        }
    }
}