using Microsoft.EntityFrameworkCore;

namespace YggdrasilCore.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
    }
}
