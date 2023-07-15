using Microsoft.EntityFrameworkCore;
using WebinarCrudGalaxy.Entities;

namespace WebinarCrudGalaxy.DataAccess
{
    public class GalaxyDbContext : DbContext
    {
        public GalaxyDbContext(DbContextOptions<GalaxyDbContext> options)
        :base(options)
        {
            
        }


        public DbSet<Cliente> Clientes { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>()
                .HasData(new List<Cliente>()
                {
                    new() { Id = 1, Nombres = "Erick", Apellidos = "Velasco", Email = "erick@gmail.com" },
                    new() { Id = 2, Nombres = "Adam", Apellidos = "Velasco", Email = "adam@gmail.com" },
                    new() { Id = 3, Nombres = "Patrick", Apellidos = "Velasco", Email = "patrick@gmail.com" },
                });
        }
    }
}