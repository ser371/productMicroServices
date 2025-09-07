using Microsoft.EntityFrameworkCore;
using PlatformServices.models;

namespace PlatformServices.Data

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Platform> Platforms { get; set; }
        
    }
}
