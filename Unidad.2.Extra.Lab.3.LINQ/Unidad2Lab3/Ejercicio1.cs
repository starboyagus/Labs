using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace Ej1Unidad2Lab3
{
    internal class Ejercicio1
    {
        class Ciudad
        {
            public string Nombre { get; set; }
            public int CodigoPostal { get; set; }
        }

        class Empleado
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public decimal Sueldo { get; set; }
        }
        static void Main(string[] args)
        {


            //string[] provincias = { "Buenos Aires", "Catamarca", "Chaco", "Chubut", "Cordoba", "Corrientes", "Entre Rios", "Formosa", "Jujuy", "La Pampa", "La Rioja", "Mendoza", "Misiones", "Neuquen", "Rio Negro", "Salta", "San Juan", "San Luis", "Santa Cruz", "Santa Fe", "Santiago del Estero", "Tierra del Fuego", "Tucuman" };
            //var resultado = provincias.Where(p => p.StartsWith("T") || p.StartsWith("S"));
            //foreach ( var p in resultado )
            //{
            //    Console.WriteLine(p);
            //}


            //List<int> numeros = new List<int>();
            //for (int i = 1; i <= 15; i++)
            //{
            //    Console.Write("Ingrese un numero: ");
            //    int num = int.Parse(Console.ReadLine());
            //    numeros.Add(num);
            //}
            //var resultado2 = numeros.Where(n => n > 20);
            //foreach (var r in resultado2)
            //{
            //    Console.WriteLine(r);
            //}

            /*ArrayList Ciudades = new ArrayList();
            Ciudades.Add(new Ciudad { Nombre = "Buenos Aires", CodigoPostal = 1000 });
            Ciudades.Add(new Ciudad { Nombre = "Santa Fe", CodigoPostal = 321 });
            Ciudades.Add(new Ciudad { Nombre = "San Juan", CodigoPostal = 5325 });
            Ciudades.Add(new Ciudad { Nombre = "Rosario", CodigoPostal = 2000 });
            Ciudades.Add(new Ciudad { Nombre = "Mendoza", CodigoPostal = 235 });
            Ciudades.Add(new Ciudad { Nombre = "Cordoba", CodigoPostal = 345 });
            Ciudades.Add(new Ciudad { Nombre = "La Pampa", CodigoPostal = 456 });
            Ciudades.Add(new Ciudad { Nombre = "Salta", CodigoPostal = 765 });
            Ciudades.Add(new Ciudad { Nombre = "La Plata", CodigoPostal = 457 });
            Ciudades.Add(new Ciudad { Nombre = "Nuñez", CodigoPostal = 543 });

            Console.WriteLine("Ingrse una expresion de 3 caracteres: ");
            var exp =   Console.ReadLine();
            var resultado3 = Ciudades.Cast<Ciudad>().Where(c => c.Nombre.Contains(exp) );
            foreach (var c in resultado3)
            {
                Console.WriteLine($"Ciudad: {c.Nombre}, Codigo Postal: {c.CodigoPostal}");
            }*/




            List<Empleado> empleados = new List<Empleado>();
            string continuar = "s";

            // Alta de Empleado
            while (continuar.ToLower() == "s")
            {
                Empleado emp = new Empleado();

                Console.Write("Ingrese el nombre del empleado: ");
                emp.Nombre = Console.ReadLine();

                Console.Write("Ingrese la edad del empleado: ");
                emp.Edad = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el sueldo del empleado: ");
                emp.Sueldo = decimal.Parse(Console.ReadLine());

                empleados.Add(emp);

                Console.Write("¿Desea ingresar otro empleado? (s/n): ");
                continuar = Console.ReadLine();
            }

            // Orden Ascendiente
            var ascendente = empleados.OrderBy(e => e.Sueldo);
            Console.WriteLine("\nEmpleados ordenados por sueldo (ascendente):");
            foreach (var emp in ascendente)
            {
                Console.WriteLine($"Nombre: {emp.Nombre}, Edad: {emp.Edad}, Sueldo: {emp.Sueldo}");
            } 

            // Orden Descendiente
            var descendiente = empleados.OrderByDescending(e => e.Sueldo);
            Console.WriteLine("\nEmpleados ordenados por sueldo (descendente):");
            foreach (var emp in descendiente)
            {
                Console.WriteLine($"Nombre: {emp.Nombre}, Edad: {emp.Edad}, Sueldo: {emp.Sueldo}");
            }   

















        }


    }
}
