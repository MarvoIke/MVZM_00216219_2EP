using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparcial.Modelo
{
    public class Inventario
    {
        public string idArticulo { get; }
        public string producto { get; }
        public string descripcion { get; }
        public string precio { get; }
        public string stock { get; }

        public Inventario(string pIdArticulo, string pProducto, string pDescripcion, string pPrecio, string pStock)
        {
            this.idArticulo = pIdArticulo;
            this.producto = pProducto;
            this.descripcion = pDescripcion;
            this.precio = pPrecio;
            this.stock = pStock;
        }
    }
}
