using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.Dominio
{
    public class ListaVehiculo
    {
        public static Vehiculo BuscarPatenteLinq(List<Vehiculo> lista, string patente)
        {
            var MiVehiculo = (from v in lista where v.Patente == patente select v).FirstOrDefault();

            return MiVehiculo;
        }

        public static Vehiculo BuscarPatenteIterativo(List<Vehiculo> lista, string patente)
        {
            foreach (var item in lista)
            {
                if (item.Patente == patente)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
