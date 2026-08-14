using Negocio;

namespace Presentacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehiculoNegocio negocio = new VehiculoNegocio();

            Console.Write("Ingrese la patente del vehículo: ");
            string patente = Console.ReadLine();

            try
            {
                Vehiculo vehiculo = negocio.BuscarVehiculo(patente);

                if (vehiculo != null)
                {
                    Console.WriteLine();
                    Console.WriteLine("Vehículo encontrado:");
                    Console.WriteLine("Modelo: " + vehiculo.Modelo);

                    if (vehiculo.TieneDeuda)
                    {
                        Console.WriteLine("Deudas pendientes: Sí");
                    }
                    else
                    {
                        Console.WriteLine("Deudas pendientes: No");
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("No se encontró ningún vehículo con esa patente.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}