using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlatformService.Dtos;
using PlatformService.Models;
using PlatformService.Repositories.Interfaces;

namespace PlatformService.Controllers
{
    [ApiController]
    [Route("api/platform")]
    public class PlatformsController : ControllerBase
    {
        private readonly IPlatformRepo _platformRepo;
        private readonly IMapper _mapper;

        public PlatformsController(IPlatformRepo platformRepo, IMapper mapper)
        {
            _platformRepo = platformRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlatformReadDto>>> GetPlatforms()
        {
            var platforms = await _platformRepo.GetAllPlatformsAsync();
            return Ok(_mapper.Map<IEnumerable<PlatformReadDto>>(platforms));
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<PlatformReadDto>> GetPlatformById([FromRoute] int id)
        {
            var platform = await _platformRepo.GetPlatformByIdAsync(id);

            if (platform == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<PlatformReadDto>(platform));
        }

        [HttpPost]
        public async Task<ActionResult<PlatformReadDto>> CreatePlatform([FromForm] PlatformCreateDto platformCreateDto)
        {
            var platformModel = _mapper.Map<Platform>(platformCreateDto);
            await _platformRepo.CreatePlatformAsync(platformModel);
            await _platformRepo.SaveChangesAsync();

            var platformReadDto = _mapper.Map<PlatformReadDto>(platformModel);
            return CreatedAtAction(nameof(GetPlatformById), new { Id = platformReadDto.Id }, platformReadDto);
        }
    }
}