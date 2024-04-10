using AutoMapper;
using CommandsService.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
    [ApiController]
    [Route("api/c/platforms")]
    public class PlatformsController : ControllerBase
    {
        private static int inboundCount = 0;
        private readonly ICommandRepo _commandRepo;
        private readonly IMapper _mapper;

        public PlatformsController(ICommandRepo commandRepo, IMapper mapper)
        {
            _commandRepo = commandRepo;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult TestInboundConnection()
        {
            inboundCount++;
            Console.WriteLine($"==> Inbound POST # Command Service , count => {inboundCount}");
            return Ok("Inbound test of from Platforms Controller");
        }
    }
}