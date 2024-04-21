using ef_core_relationships.Data;
using ef_core_relationships.Dto;
using ef_core_relationships.Interfaces;
using ef_core_relationships.Models;
using Microsoft.EntityFrameworkCore;

namespace ef_core_relationships.Repository
{
    public class UserRepository : IUserRepo
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<User> CreateUserAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }
    }
}