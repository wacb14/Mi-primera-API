using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class GeneralContext : DbContext
    {
        public GeneralContext(DbContextOptions<GeneralContext> options) : base(options)
        {
        }
        public DbSet<User> User { get; set; } = null;
        public DbSet<User> Person { get; set; } = null;
        public DbSet<User> City { get; set; } = null;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
            .HasOne(b => b.User)
            .WithOne(i=>i.Person);
            // .HasForeignKey<Person>(b=>b.UserFK);

            modelBuilder.Entity<Person>()
            .HasOne(b=>b.City)
            .WithMany(b=>b.People);
            // .HasForeignKey(b=>b.CityFK);
        }
    }
}