using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgustinGil.Dominio
{
    public class ListaVehiculo
    {
        public static Vehiculo BuscarPatenteLINQ(List<Vehiculo> vehiculos, string patente)
        {
            return vehiculos.Where(v => v.Patente == patente).FirstOrDefault();
        }

        public static Vehiculo BuscarPatenteIterativa(List<Vehiculo> vehiculos, string patente)
        {
            foreach (var vehiculo in vehiculos)
            {
                if (vehiculo.Patente == patente)
                {
                    return vehiculo;
                }
            }
            return null;
        }
    }
}
