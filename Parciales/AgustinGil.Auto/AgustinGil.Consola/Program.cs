using AgustinGil.Dominio;

List<Vehiculo> vehiculos = new List<Vehiculo>();
vehiculos.Add(new Auto("ABC111", 4, 1999, "Azul"));
vehiculos.Add(new Auto("ABC123", 4, 1999, "Verde"));
vehiculos.Add(new Auto("ABC143", 4, 1999, "Rojo"));

Vehiculo BusquedaLinq = ListaVehiculo.BuscarPatenteLINQ(vehiculos, "ABC111");
Vehiculo BusquedaIT = ListaVehiculo.BuscarPatenteIterativa(vehiculos, "ABC123");
Console.WriteLine("Busqueda LINQ: ");
Console.WriteLine(BusquedaLinq);
Console.WriteLine("Busqueda Iterativa: ");
Console.WriteLine(BusquedaIT);