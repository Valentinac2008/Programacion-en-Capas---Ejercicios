using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucion.negocio
{
    public class Vehiculo
    {
        public string Patente { get; set; }
        public string Modelo { get; set; }
        public bool TieneDeuda { get; set; }

        public Vehiculo(string patente, string modelo, bool tieneDeuda)
        {
            Patente = patente;
            Modelo = modelo;
            TieneDeuda = tieneDeuda;
        }
    }
}
