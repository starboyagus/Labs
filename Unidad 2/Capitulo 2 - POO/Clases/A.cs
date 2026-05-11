using System;

namespace Clases
{
    public class A
    {
        public string NombreInstancia { get; set; }

        public A()
        {
            NombreInstancia = "Instancia sin Nombre";
        }

        public A(string nombre)
        {
            NombreInstancia = nombre;
        }

        public void MonstarNombre()
        {
            Console.WriteLine($"Nombe de la instancia es: {NombreInstancia}");
        }

        public void M1()
        {
            Console.WriteLine("Metodo M1");
        }
        public void M2()
        {
            Console.WriteLine("Metodo M2");
        }
        public void M3()
        {
            Console.WriteLine("Metodo M3");
        }
    }
}
