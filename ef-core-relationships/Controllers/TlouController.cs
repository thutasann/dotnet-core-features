using ef_core_relationships.Data;
using ef_core_relationships.Dto;
using ef_core_relationships.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ef_core_relationships.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TlouController : ControllerBase
    {
        private readonly DataContext _context;

        public TlouController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("characters")]
        public async Task<ActionResult<List<Character>>> GetAllCharacters()
        {
            var result = await _context.Characters.Include(c => c.Backpack).Include(c => c.Weapons).ToListAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Character>>> CreateChracter(CharacterCreateDto request)
        {
            var newCharacter = new Character
            {
                Name = request.Name,
            };

            var newBackpack = new Backpack
            {
                Description = request.Backpack.Description,
                Character = newCharacter
            };

            var weapons = request.Weapons
                            .Select(w => new Weapon { Name = w.Name, Character = newCharacter })
                            .ToList();

            newCharacter.Backpack = newBackpack;
            newCharacter.Weapons = weapons;

            await _context.Characters.AddAsync(newCharacter);
            await _context.SaveChangesAsync();

            var response = await _context.Characters
                                .Include(c => c.Backpack)
                                .Include(c => c.Weapons)
                                .ToListAsync();
            return Ok(response);
        }

    }
}