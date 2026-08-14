using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucion.negocio
{
    public class alumno
    {
         public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Condicion { get; set; }

        public Alumno(int legajo, string nombre, string condicion)
        {
            Legajo = legajo;
            Nombre = nombre;
            Condicion = condicion;
        }
    }
}
