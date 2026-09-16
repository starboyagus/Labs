using Fiorini.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Fiorini.Datos.Repositorios
{
    public class AlquilerRepositorio : IAlquilerRepositorio
    {
        private readonly AlquilerContext _context;

        public AlquilerRepositorio(AlquilerContext context)
        {
            _context = context;
        }

        public async Task<List<Alquiler>> ObtenerTodosAsync()
        {
            return await _context.Alquileres
                .OrderBy(a => a.Id)
                .ToListAsync();
        }

        public async Task<List<Alquiler>> ObtenerPorEstadoAsync(string estado)
        {
            return await _context.Alquileres
                .Where(a => a.Estado == estado)
                .OrderBy(a => a.Id)
                .ToListAsync();
        }

        public async Task<Alquiler?> ObtenerPorIdAsync(int id)
        {
            return await _context.Alquileres.FindAsync(id);
        }

        public async Task<Alquiler> AgregarAsync(Alquiler alquiler)
        {
            _context.Alquileres.Add(alquiler);
            await _context.SaveChangesAsync();
            return alquiler;
        }

        public async Task ActualizarAsync(Alquiler alquiler)
        {
            _context.Alquileres.Update(alquiler);
            await _context.SaveChangesAsync();
        }
    }
}
