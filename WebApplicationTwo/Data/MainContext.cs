using Microsoft.EntityFrameworkCore;
using WebApplicationTwo.Entities;

namespace WebApplicationTwo.Data
{
    public class MainContext : DbContext
    {
        public DbSet<Arbol> Arboles { get; set; }    
        public DbSet<Region> Regiones { get; set; }

        public MainContext(DbContextOptions<MainContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<WebApplicationTwo.Entities.Region> Region { get; set; }
    }
}
