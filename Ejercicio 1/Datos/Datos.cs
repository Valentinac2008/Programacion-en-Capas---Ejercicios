using solucion.negocio;

namespace Datos
{
    public class ProductoDatos
    {
        private List<Producto> productos = new List<Producto>()
        {
            new Producto("PROD-101", "Teclado", 15000),
            new Producto("PROD-102", "Mouse", 8000),
            new Producto("PROD-103", "Monitor", 120000)
        };

        public Producto BuscarProducto(string codigo)
        {
            return productos.FirstOrDefault(p => p.Codigo == codigo);
        }
    }
}
