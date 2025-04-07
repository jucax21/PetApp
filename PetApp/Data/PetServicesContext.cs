using Microsoft.EntityFrameworkCore;
using PetApp.Models;

namespace PetApp.Data
{
    public class PetServicesContext : DbContext
    {
        public PetServicesContext(DbContextOptions<PetServicesContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Producto> Productos { get; set; }

    }
}
