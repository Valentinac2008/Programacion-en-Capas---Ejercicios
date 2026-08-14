using solucion.datos;

namespace solucion.negocio
{
    public class AlumnoNegocio
    {
        private AlumnoDatos datos = new AlumnoDatos();

        public Alumno BuscarAlumno(int legajo)
        {
            if (legajo <= 0)
            {
                throw new Exception("El legajo debe ser mayor a cero.");
            }

            return datos.BuscarAlumno(legajo);
        }
    }
}
