using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Lab1 { 
    public class UniversidadContext : DbContext 
    {

        public UniversidadContext()
        {
            this.Database.EnsureCreated();
        }

        // Propiedad que representa la coleccion alumnos en la BD.
        public DbSet<Alumno> Alumnos { get; set; }

        // Configuracion del proveedor en la base de datos SQL server
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Universidad;Integrated Security=true");
            //optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        }
    }

}
