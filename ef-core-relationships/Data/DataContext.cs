using ef_core_relationships.Models;
using Microsoft.EntityFrameworkCore;

namespace ef_core_relationships.Data
{
    /// <summary>
    /// Data Context
    /// </summary>
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
    }
}