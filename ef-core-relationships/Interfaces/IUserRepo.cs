using ef_core_relationships.Models;

namespace ef_core_relationships.Interfaces
{
    public interface IUserRepo
    {
        Task<List<User>> GetAllUsersAsync();
        Task<User> CreateUserAsync(User user);
    }
}