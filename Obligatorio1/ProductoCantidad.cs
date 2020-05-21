using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    class ProductoCantidad
    {
        private Producto tipoDeProducto;
        private int cantidad;

        public Producto TipoDeProducto
        {
            get { return tipoDeProducto; }
        }


        public ProductoCantidad(Producto tipoDeProducto, int cantidad)
        {
            this.tipoDeProducto = tipoDeProducto;
            this.cantidad = cantidad;
        }

        public void ModificarCantidad(int cantidadAAgregar)
        {
            this.cantidad = this.cantidad + cantidadAAgregar;
        }

    }
}
