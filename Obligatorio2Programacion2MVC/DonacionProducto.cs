using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio2Programacion2MVC
{
    class DonacionProducto: Donacion
    {
        private List<ProductoCantidad> productosCantidades = new List<ProductoCantidad>();

        

        public DonacionProducto(Producto tipoDeProducto, int cantidad,DateTime fechaDonacion, int codigoDonacion) :
            base(fechaDonacion, codigoDonacion)
        {
            productosCantidades.Add(new ProductoCantidad(tipoDeProducto, cantidad));
        }


        
        public void AgregarProductoCantidad(Producto tipoDeProducto, int cantidad)
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
        }



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


        public double ValeDonacionProducto(double valorDonacion)
        {
            double vale=0;

            if (valorDonacion < 1000)
            {
                vale = 0 * valorDonacion;

            }
            else if (valorDonacion >= 1000 && valorDonacion<2000)
            {
                vale = 0.1 * valorDonacion;
            }
            else if(valorDonacion >= 2000)
            {
                vale = 0.12 * valorDonacion;
            }
            return vale;
        }

    

    }
}
