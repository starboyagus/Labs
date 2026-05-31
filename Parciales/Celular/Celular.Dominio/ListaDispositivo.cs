namespace Celular.Dominio { 
    public class ListaDispositivo
{
    public static Dispositivo BuscarNroSerieLINQ(List<Dispositivo> lista, string numserie)
    {
        var MiDispositivo = (from d in lista where d.NroSerie == numserie.ToString() select d).FirstOrDefault();


        return MiDispositivo;

        }

    public static Dispositivo BuscarNroSerieIterativa(List<Dispositivo> lista, string numserie)
    {
        foreach (var d in lista)
        {
            if (d.NroSerie == numserie)
            {
                return d;
            }
        }
        return null;
    }
}

}



