using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgustinGil.Dominio
{
    public class Auto: Vehiculo
    {
        public string Color { get; set; }
        public Auto(string patente, int ruedas, int modelo, string color):base(patente,ruedas,modelo)
        {
            this.Color = color;
        }

        public override string ToString()
        {
            return $"Patente: {Patente} Ruedas: {Ruedas} Modelo: {Modelo} Color: {Color}";
        }

    }
}
