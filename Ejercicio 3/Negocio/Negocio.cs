using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using solucion.datos;

namespace solucion.negocio
{
    public class VehiculoNegocio
    {
        private VehiculoDatos datos = new VehiculoDatos();

        public Vehiculo BuscarVehiculo(string patente)
        {
            if (string.IsNullOrWhiteSpace(patente))
            {
                throw new Exception("La patente no puede estar vacía.");
            }

            if (patente.Length < 6)
            {
                throw new Exception("La patente debe tener al menos 6 caracteres.");
            }

            return datos.BuscarVehiculo(patente);
        }
    }
}
