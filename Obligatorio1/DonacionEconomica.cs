using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    class DonacionEconomica : Donacion
    {
        private double monto;

        public double Monto
        {
            get { return monto; }
        }



        public DonacionEconomica(DateTime fechaDaonacion, int codigoDonacion, double monto):
            base(fechaDaonacion,codigoDonacion)
        {
            this.monto = monto;
            ValeDonacion(monto);  // agregue
        }


        


        public override void ValeDonacion(double montoDonado)
        {
            double vale;

            if (montoDonado < 1000)
            {
                vale = 0.05 * montoDonado;

            }else if(montoDonado>=1000 && montoDonado < 2000)
            {
                vale = 0.08 * montoDonado;
            }
            else
            {
                vale = 0.1 * montoDonado;
            }
            AgregarVale(vale);   // agrego el monto del vale al atributo vale
            //return vale;
        }

    }
}
