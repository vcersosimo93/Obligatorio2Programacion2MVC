using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio2Programacion2MVC
{
    class CentroRecepcion
    {
        private string nombre;
        private List<Voluntario> voluntarios = new List<Voluntario>();
        private string direccion;
        private List<Donacion> donaciones = new List<Donacion>();
        

        public List<Voluntario> Voluntarios
        {
            get { return voluntarios; }
        }

        public List<Donacion> Donaciones
        {
            get { return donaciones; }
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public string Direccion
        {
            get { return direccion; }
        }

        public CentroRecepcion(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            
        }


        

    }
}

