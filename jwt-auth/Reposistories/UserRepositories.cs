using jwt_auth.Interfaces;
using jwt_auth.Models;

namespace jwt_auth.Reposistories
{
    public class UserRepository : IUserRepository
    {
        public Task<User> Create(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByUserName(string username)
        {
            throw new NotImplementedException();
        }
    }
}