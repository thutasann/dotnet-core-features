using System.Reflection.Metadata.Ecma335;
using jwt_auth.Interfaces;
using jwt_auth.Models;

namespace jwt_auth.Reposistories
{
    public class InMemoryUserRepositories : IUserRepository
    {
        private readonly List<User> _users = new();

        public Task<User> Create(User user)
        {
            user.Id = Guid.NewGuid();
            _users.Add(user);
            return Task.FromResult(user);
        }

        public Task<User> GetByEmail(string email)
        {
            return Task.FromResult(_users.FirstOrDefault(u => u.Email == email)!);
        }

        public Task<User> GetByUserName(string username)
        {
            return Task.FromResult(_users.FirstOrDefault(u => u.UserName == username)!);
        }

        public List<User> GetUsers()
        {
            return _users.ToList();
        }
    }
}