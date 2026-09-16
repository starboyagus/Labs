using Fiorini.Dominio;

namespace Fiorini.Datos.Repositorios
{
    public interface IAlquilerRepositorio
    {
        Task<List<Alquiler>> ObtenerTodosAsync();
        Task<List<Alquiler>> ObtenerPorEstadoAsync(string estado);
        Task<Alquiler?> ObtenerPorIdAsync(int id);
        Task<Alquiler> AgregarAsync(Alquiler alquiler);
        Task ActualizarAsync(Alquiler alquiler);
    }
}
