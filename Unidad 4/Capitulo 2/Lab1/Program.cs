using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido al sistema de gestion de alumnos de la universidad");
            Console.WriteLine("=================================================");
            Console.WriteLine("--- 1. CREAR ALUMNO ---");
            Console.WriteLine("\n--- 2. LEER ALUMNO ---");
            //LeerAlumno
            Console.WriteLine("\n--- 3. ACTUALIZAR ALUMNO ---");
            //ActualizarAlumno
            Console.WriteLine("\n--- 4. ELIMINAR ALUMNO ---");
            Console.WriteLine("\n--- Eliga una opcion del menu ---");
            var _op = Console.ReadLine();

            if (_op == "1")
            {
                CrearAlumno();
            }
            else if (_op == "2")
            {
                LeerAlumno();
            }
            else if (_op == "3")
            {
                ActualizarAlumno();
            }
            else if (_op == "4")
            {
                EliminarAlumno();
            }
            else
            {
                Console.WriteLine("chau");
            }
        }

        public static void CrearAlumno()
        {
            using (var context = new UniversidadContext())
            {
                var nuevoAlumno = new Alumno
                {
                    Nombre = "Juan",
                    Apellido = "Perez",
                    Legajo = 12345,
                    Direccion = "Calle 123",
                    Activo = true
                };

                context.Alumnos.Add(nuevoAlumno);
                context.SaveChanges();

                Console.WriteLine($"Alumno '{nuevoAlumno.Nombre}' creado con éxito. ID: {nuevoAlumno.Id}");

            }
        }

        public static void LeerAlumno()
        {
            using (var context = new UniversidadContext())
            {
                // Buscamos el primer alumno que coincida con el nombre
                var alumno = context.Alumnos.FirstOrDefault(a => a.Nombre == "Juan");

                if (alumno != null)
                {
                    Console.WriteLine($"Alumno encontrado -> ID: {alumno.Id}, Nombre: {alumno.Nombre}, Apellido: {alumno.Apellido}, Legajo: {alumno.Legajo}, Direccion: {alumno.Direccion}");
                }
                else
                {
                    Console.WriteLine("Alumno no encontrado.");
                }
            }
        }

        public static void ActualizarAlumno()
        {
            using (var context = new UniversidadContext())
            {
                var alumno = context.Alumnos.FirstOrDefault(a => a.Nombre == "Juan");

                if (alumno != null)
                {
                    alumno.Nombre = "Juan Perez Editado";

                    context.SaveChanges();
                    Console.WriteLine("Los datos del alumno han sido actualizados.");
                }
                else
                {
                    Console.WriteLine("No se encontró el alumno para actualizar.");
                }
            }
        }

        public static void EliminarAlumno()
        {
            using (var context = new UniversidadContext())
            {
                var alumno = context.Alumnos.FirstOrDefault(a => a.Nombre == "Juan Perez Editado");

                if (alumno != null)
                {
                    alumno.Activo = false;
                    context.SaveChanges();
                    Console.WriteLine("Alumno eliminado correctamente de la base de datos.");
                }
                else
                {
                    Console.WriteLine("No se encontró el alumno para eliminar.");
                }
            }
        }
    }
}