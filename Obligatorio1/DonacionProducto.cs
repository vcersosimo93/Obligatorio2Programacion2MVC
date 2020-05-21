using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    class DonacionProducto: Donacion
    {
        private List<ProductoCantidad> productosCantidades = new List<ProductoCantidad>();

        

        public DonacionProducto(List<ProductoCantidad> productosCantidades, DateTime fechaDonacion, int codigoDonacion) : // agregue la lista de producto cantidad
            base(fechaDonacion, codigoDonacion)
        {
            //productosCantidades.Add(new ProductoCantidad(tipoDeProducto, cantidad));
            this.productosCantidades = productosCantidades;
        }


        
        /*public void AgregarProductoCantidad(Producto tipoDeProducto, int cantidad)
        {
            if(tipoDeProducto!=null && cantidad > 0)
            {
                ProductoCantidad productoCantidad = BuscarProductoCantidad(tipoDeProducto);
                if (productoCantidad != null)
                {
                    productoCantidad.ModificarCantidad(cantidad);
                }
                else
                {
                    this.productosCantidades.Add(new ProductoCantidad(tipoDeProducto, cantidad));
                }
            }
        }*/



        private ProductoCantidad BuscarProductoCantidad(Producto tipoDeProducto)
        {
            ProductoCantidad productoCantidad = null;
            int i = 0;

            while (i < productosCantidades.Count && productoCantidad==null)
            {
                if (productosCantidades[i].TipoDeProducto.Equals(tipoDeProducto))
                {
                    productoCantidad = productosCantidades[i];
                }
                i++;
            }
            return productoCantidad;

        }


        public override void ValeDonacion(double valorDonacion) // modifiqué, ojo en astah
        {
            double vale=0;

            /*if (valorDonacion < 1000)
            {
                vale = 0 * valorDonacion;         NO ES NECESARIO al vale cuando es menor a 1000 darle el valor 0 ya que esta dado cuando se inicializa - lo modifiqué

            }*/

            if (valorDonacion > 1000)
            {
                if (valorDonacion < 2000)
                {
                    vale = 0.1 * valorDonacion;
                }
                else
                {
                    vale = 0.12 * valorDonacion;
                }
                AgregarVale(vale);
            }

            //return vale;
        }

    

    }
}
