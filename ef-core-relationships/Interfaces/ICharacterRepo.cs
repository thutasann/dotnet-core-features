using ef_core_relationships.Models;

namespace ef_core_relationships.Interfaces
{
    public interface ICharacterRepo
    {
        Task<List<Character>> GetAllCharactersAsync();
        Task<Character> CreateCharacterAsync(Character user);
        Task<List<Character>> GetCharactersByUserIdAsync(int userId);
    }
}