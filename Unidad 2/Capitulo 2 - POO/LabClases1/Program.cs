using System;
using Clases;

namespace LabClases1
{
    internal class Program
    {
        Clases.A a = new A();
        Clases.B b = new B();

        static void Main(string[] args)
        {
            Program p = new Program();
            p.a.MonstarNombre();
            p.b.MonstarNombre();
            p.a.M1();
            p.a.M2();
            p.a.M3();
            p.b.M4();
        }
    }
}

