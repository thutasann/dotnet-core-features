using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
    [ApiController]
    [Route("api/c/platforms")]
    public class PlatformsController : ControllerBase
    {
        public PlatformsController()
        {

        }

        [HttpPost]
        public IActionResult TestInboundConnection()
        {
            Console.WriteLine("==> Inbound POST # Command Service");
            return Ok("Inbound test of from Platforms Controller");
        }
    }
}