using Auto.Dominio;

internal class Program
{
    public static void Main(string[] args)
    {
        List<Auto.Dominio.Vehiculo> lista = new List<Auto.Dominio.Vehiculo>();
        lista.Add(new Auto.Dominio.Auto("ABC134", 4, 1999, "Azul"));
        lista.Add(new Auto.Dominio.Auto("ABC123", 4, 1999, "Rojo"));
        lista.Add(new Auto.Dominio.Auto("ABC111", 4, 2018, "Chocado"));

        var PatenteLINQ = Auto.Dominio.ListaVehiculo.BuscarPatenteLinq(lista, "ABC111");
        var PatenteINT = Auto.Dominio.ListaVehiculo.BuscarPatenteIterativo(lista, "ABC111");

        Console.WriteLine("Busqueda LINQ");
        Console.WriteLine(PatenteLINQ.ToString());
        Console.WriteLine("Patente Iterativo");
        Console.WriteLine(PatenteINT.ToString());
    }
}