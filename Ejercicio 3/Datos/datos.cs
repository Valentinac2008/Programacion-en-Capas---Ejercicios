using solucion.negocio;

namespace Datos
{
    public class VehiculoDatos
    {
        private List<Vehiculo> vehiculos = new List<Vehiculo>()
        {
            new Vehiculo("AA123CD", "Toyota Corolla", false),
            new Vehiculo("AB456EF", "Ford Focus", true),
            new Vehiculo("AC789GH", "Volkswagen Golf", false)
        };

        public Vehiculo BuscarVehiculo(string patente)
        {
            return vehiculos.FirstOrDefault(v => v.Patente == patente);
        }
    }
}
