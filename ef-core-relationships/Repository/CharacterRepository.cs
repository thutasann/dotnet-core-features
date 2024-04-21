using ef_core_relationships.Data;
using ef_core_relationships.Interfaces;
using ef_core_relationships.Models;
using Microsoft.EntityFrameworkCore;

namespace ef_core_relationships.Repository
{
    public class CharacterRepository : ICharacterRepo
    {
        private readonly DataContext _context;

        public CharacterRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Character> CreateCharacterAsync(Character character)
        {
            await _context.Characters.AddAsync(character);
            await _context.SaveChangesAsync();
            return character;
        }

        public async Task<List<Character>> GetAllCharactersAsync()
        {
            return await _context.Characters.ToListAsync();
        }

        public async Task<List<Character>> GetCharactersByUserIdAsync(int userId)
        {
            var characters = await _context.Characters
                .Where(c => c.UserId == userId)
                .Include(c => c.Weapon)
                .ToListAsync();
            return characters;
        }
    }

}