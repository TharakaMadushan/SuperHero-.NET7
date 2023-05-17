using Microsoft.EntityFrameworkCore;
using SuperHero_.NET7.Models;

namespace SuperHero_.NET7.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
                
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=MADUSHAN;User ID=sa;Password=Admin1234;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
