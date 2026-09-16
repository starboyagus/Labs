using System.Net.Http.Json;
using Fiorini.Dominio;

namespace Fiorini.Negocio
{
    /// <summary>
    /// Capa de negocio del cliente: consume los servicios de la API Rest de Alquileres.
    /// </summary>
    public class AlquilerNegocio
    {
        private const string Ruta = "alquileres";

        public async Task<List<Alquiler>> ObtenerTodosAsync()
        {
            var alquileres = await Conexion.Cliente.GetFromJsonAsync<List<Alquiler>>(Ruta);
            return alquileres ?? new List<Alquiler>();
        }

        public async Task<List<Alquiler>> ObtenerPorEstadoAsync(string estado)
        {
            var alquileres = await Conexion.Cliente.GetFromJsonAsync<List<Alquiler>>($"{Ruta}/estado/{estado}");
            return alquileres ?? new List<Alquiler>();
        }

        public async Task<Alquiler> AgregarAsync(Alquiler alquiler)
        {
            var respuesta = await Conexion.Cliente.PostAsJsonAsync(Ruta, alquiler);
            await VerificarRespuestaAsync(respuesta);

            var creado = await respuesta.Content.ReadFromJsonAsync<Alquiler>();
            return creado ?? alquiler;
        }

        public async Task<Alquiler> FinalizarAsync(int id)
        {
            var respuesta = await Conexion.Cliente.PutAsync($"{Ruta}/{id}/finalizar", null);
            await VerificarRespuestaAsync(respuesta);

            var finalizado = await respuesta.Content.ReadFromJsonAsync<Alquiler>();
            return finalizado!;
        }

        /// <summary>
        /// Si la API respondió con error, lee los mensajes devueltos y lanza una excepción
        /// para que la capa de presentación los muestre al usuario.
        /// </summary>
        private static async Task VerificarRespuestaAsync(HttpResponseMessage respuesta)
        {
            if (respuesta.IsSuccessStatusCode)
                return;

            if (respuesta.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                var errores = await respuesta.Content.ReadFromJsonAsync<List<string>>();
                if (errores is { Count: > 0 })
                    throw new InvalidOperationException(string.Join(Environment.NewLine, errores));
            }

            if (respuesta.StatusCode == System.Net.HttpStatusCode.NotFound)
                throw new InvalidOperationException("No se encontró el alquiler solicitado.");

            throw new InvalidOperationException($"El servicio respondió con el código {(int)respuesta.StatusCode} ({respuesta.ReasonPhrase}).");
        }
    }
}
