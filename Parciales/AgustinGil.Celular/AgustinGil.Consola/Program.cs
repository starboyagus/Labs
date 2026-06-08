using AgustinGil.Dominio;


List<Dispositivo> dispositivos = new List<Dispositivo>();
dispositivos.Add(item: new Celular("C12346NET", "Samsung", 2020, "S20"));
dispositivos.Add(item: new Celular("C12345NET", "Samsung", 2025, "Galaxy S25"));
dispositivos.Add(item: new Celular("C12347NET", "Iphone", 2025, "Galaxy S25"));

Dispositivo dispLINQ = ListaDispositivo.BuscarNroSerieLINQ(dispositivos, "C12345NET");
Console.WriteLine("Dispositivo encontrado con LINQ:");
Console.WriteLine(dispLINQ);
Dispositivo dispIT = ListaDispositivo.BuscarNroSerieIterativa(dispositivos, "C12347NET");
Console.WriteLine("Dispositivo encontrado con Iterativa:");
Console.WriteLine(dispIT);

