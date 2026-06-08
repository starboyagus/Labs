namespace AgustinGil.Dominio
{
    public class Celular : Dispositivo
    {
        public string Modelo { get; set; }

        public Celular(string nroSerie, string marca, int anioFabricacion, string modelo):base(nroSerie, marca, anioFabricacion)
        {
            this.Modelo = modelo;
        }
        public override string ToString()
        {
            return $"Serie: {NroSerie} Marca: {Marca} Fabricación: {AnioFabricacion} Modelo: {Modelo}";
        }
    }
}
