using ef_core_relationships.Data;
using ef_core_relationships.Dto;
using ef_core_relationships.Interfaces;
using ef_core_relationships.Mapper;
using ef_core_relationships.Models;
using Microsoft.AspNetCore.Mvc;

namespace ef_core_relationships.Controllers
{
    [ApiController]
    [Route("api/character")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterRepo _characterRepo;
        private readonly DataContext _context;

        public CharacterController(ICharacterRepo characterRepo, DataContext context)
        {
            _characterRepo = characterRepo;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetCharacters()
        {
            var characters = await _characterRepo.GetAllCharactersAsync();
            return Ok(characters);
        }

        [HttpGet("{userId:int}")]
        public async Task<IActionResult> GetCharactersByUserId([FromRoute] int userId)
        {
            var characters = await _characterRepo.GetCharactersByUserIdAsync(userId);
            return Ok(characters);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCharacter([FromForm] CharacterCreateDto characterCreateDto)
        {
            var user = await _context.Users.FindAsync(characterCreateDto.UserId);
            if (user == null)
                return NotFound();

            var characterModel = new Character
            {
                Name = characterCreateDto.Name,
                RpgClass = characterCreateDto.RpgClass,
                User = user,
            };

            await _characterRepo.CreateCharacterAsync(characterModel);
            return Ok(characterCreateDto);
        }
    }
}