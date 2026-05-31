using Celular.Dominio;
using System.ComponentModel;

internal class Program

{
    public static void Main(string[] args)
    {
        List<Dispositivo> lista = new List<Dispositivo>();
        lista.Add(new Celular.Dominio.Celular("C12347NET", "Samsung", 2020, "S20"));
        lista.Add(new Celular.Dominio.Celular("C12346NET", "Apple", 2021, "iPhone 12"));
        lista.Add(new Celular.Dominio.Celular("C12345NET", "Samsung", 2025, "Galaxy S25"));

        var NroSerieLINQ = Celular.Dominio.ListaDispositivo.BuscarNroSerieLINQ(lista, "C12345NET");
        var NROSerieIt = Celular.Dominio.ListaDispositivo.BuscarNroSerieIterativa(lista, "C12346NET");

        Console.WriteLine("Resultado de la búsqueda con LINQ:");
        Console.WriteLine(NroSerieLINQ.ToString());
        Console.WriteLine("Resultado de la búsqueda iterativa:");
        Console.WriteLine(NROSerieIt.ToString());
    }
}