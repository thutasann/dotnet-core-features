using jwt_auth.Models;

namespace jwt_auth.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetById(Guid userId);
        Task<User?> GetByEmail(string email);
        Task<User?> GetByUserName(string username);
        Task<User> Create(User user);
        Task<List<User>> GetUsers();
    }
}