using Negocio;

namespace Presentacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductoNegocio negocio = new ProductoNegocio();

            Console.Write("Ingrese el código del producto: ");
            string codigo = Console.ReadLine();

            try
            {
                Producto producto = negocio.BuscarProducto(codigo);

                if (producto != null)
                {
                    Console.WriteLine();
                    Console.WriteLine("Producto encontrado:");
                    Console.WriteLine("Nombre: " + producto.Nombre);
                    Console.WriteLine("Precio: $" + producto.Precio);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("No se encontró ningún producto con ese código.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}

