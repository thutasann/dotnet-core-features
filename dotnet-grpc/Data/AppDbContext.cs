using dotnet_grpc.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_grpc.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<TodoItem> Todos { get; set; }
    }
}