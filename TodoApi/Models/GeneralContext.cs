using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class GeneralContext : DbContext
    {
        public GeneralContext(DbContextOptions<GeneralContext> options) : base(options)
        {

        }
        public DbSet<User> User { get; set; } = null;
    }
}