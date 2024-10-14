using Microsoft.EntityFrameworkCore;
using YggdrasilCore.Models;

namespace YggdrasilCore.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Role> Roles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Admin", Description = "Administrator" },
                new Role { Id = 2, Name = "GM", Description   = "Game Master"},
                new Role { Id = 3, Name = "Player", Description = "Player" }
            );
        }
    }
}
