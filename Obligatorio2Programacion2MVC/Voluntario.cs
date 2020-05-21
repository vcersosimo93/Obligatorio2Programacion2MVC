using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio2Programacion2MVC
{
    class Voluntario
    {
        private string nombre;
        private string cedula;
        private int telefono;
        private DateTime fechaDeNacimiento;

        public string Nombre
        {
            get { return nombre; }
        }

        public string Cedula
        {
            get { return cedula; }
        }


        public Voluntario(string nombre, string cedula, int telefono, DateTime fechaDeNacimiento)
        {
            this.nombre = nombre;
            this.cedula = cedula;
            this.telefono = telefono;
            this.fechaDeNacimiento = fechaDeNacimiento;
        }



        #region Metodos

        public bool existeNombre(string nombre)
        {
            bool exito = false;
            if (nombre.Length > 1)
            {
                exito = true;
            }
            return exito;
        }


       


        public bool existeFechaVoluntario(DateTime fecha)
        {
            DateTime f = new DateTime();
            bool exito = false;
            if (fecha != f)
            {
                exito = true;
            }
            return exito;
        }





        #endregion

    }
}


