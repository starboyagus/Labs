namespace Fiorini.Dominio
{
    /// <summary>
    /// Valores posibles para el atributo Estado de un Alquiler.
    /// </summary>
    public static class EstadoAlquiler
    {
        public const string Activo = "Activo";
        public const string Finalizado = "Finalizado";

        public static readonly string[] Todos = { Activo, Finalizado };
    }
}
