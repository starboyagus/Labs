namespace Fiorini.Dominio
{
    public class Alquiler
    {
        public int Id { get; set; }
        public string Inquilino { get; set; } = string.Empty;
        public decimal MontoAlquiler { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; } = EstadoAlquiler.Activo;

        /// <summary>
        /// Aplica las reglas de validación del negocio y devuelve la lista de errores encontrados.
        /// Si la lista está vacía, el Alquiler es válido.
        /// </summary>
        public List<string> Validar()
        {
            var errores = new List<string>();

            if (string.IsNullOrWhiteSpace(Inquilino))
                errores.Add("El campo Inquilino es obligatorio.");

            if (MontoAlquiler < 0 || MontoAlquiler > 1_000_000)
                errores.Add("El campo MontoAlquiler debe estar comprendido entre 0 y 1.000.000.");

            if (FechaInicio >= FechaFin)
                errores.Add("La FechaInicio debe ser inferior a la FechaFin.");

            return errores;
        }

        public bool EsValido() => Validar().Count == 0;
    }
}
