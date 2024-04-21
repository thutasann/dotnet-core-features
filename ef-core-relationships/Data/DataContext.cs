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

    }
}