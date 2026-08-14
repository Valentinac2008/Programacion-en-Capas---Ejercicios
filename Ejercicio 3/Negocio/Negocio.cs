using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

        namespace Negocio
    {
        public class ProductoNegocio
        {
            private ProductoDatos datos = new ProductoDatos();

            public Producto BuscarProducto(string codigo)
            {
                if (string.IsNullOrWhiteSpace(codigo))
                {
                    throw new Exception("El código no puede estar vacío.");
                }

                if (!codigo.StartsWith("PROD-"))
                {
                    throw new Exception("El código debe comenzar con 'PROD-'.");
                }

                return datos.BuscarProducto(codigo);
            }
        }
    }

