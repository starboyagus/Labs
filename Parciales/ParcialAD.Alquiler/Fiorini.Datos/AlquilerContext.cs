using Fiorini.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Fiorini.Datos
{
    public class AlquilerContext : DbContext
    {
        public DbSet<Alquiler> Alquileres { get; set; }

        public AlquilerContext(DbContextOptions<AlquilerContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alquiler>(entidad =>
            {
                entidad.ToTable("Alquileres");
                entidad.HasKey(a => a.Id);
                entidad.Property(a => a.Id).ValueGeneratedOnAdd();
                entidad.Property(a => a.Inquilino).IsRequired().HasMaxLength(100);
                entidad.Property(a => a.MontoAlquiler).HasPrecision(18, 2);
                entidad.Property(a => a.Estado).IsRequired().HasMaxLength(20);
            });
        }
    }
}
