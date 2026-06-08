namespace AgustinGil.Dominio
{
    public class ListaDispositivo
    {
        public static Dispositivo BuscarNroSerieLINQ(List<Dispositivo> dispositivos, string nroSerie)
        {
            return dispositivos.FirstOrDefault(d => d.NroSerie == nroSerie);

        }

        public static Dispositivo BuscarNroSerieIterativa(List<Dispositivo> dispositivos, string nroSerie){
            foreach (var item in dispositivos)
            {
                if (item.NroSerie == nroSerie)
                {
                    return item;
                }
            }
            return null;
            
        }
    }
}