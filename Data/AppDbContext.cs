using Microsoft.EntityFrameworkCore;
using TaskManagerApi.Models;

namespace TaskManagerApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; } // ileride ekleyeceğimiz model
        public DbSet<TaskItem> Tasks { get; set; } // ileride eklenecek
    }
}
