namespace Fiorini.Negocio
{
    /// <summary>
    /// Provee una única instancia de HttpClient (patrón Singleton) configurada
    /// con la URL base donde escucha la API Rest de Fiorini.Servicios.
    /// </summary>
    public static class Conexion
    {
        private const string UrlBase = "http://localhost:5100/";

        private static readonly Lazy<HttpClient> _cliente = new(() => new HttpClient
        {
            BaseAddress = new Uri(UrlBase)
        });

        public static HttpClient Cliente => _cliente.Value;
    }
}
