using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio2Programacion2MVC
{
    class Producto
    {
        private string nombre;
        private double peso;
        private int precio;
        private string tipo;
        private int id;
        private static int ultimoId=1;


        #region Properties
        public int Id
        {
            get { return id; }
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public double Peso
        {
            get { return peso; }
        }

        public int Precio
        {
            get { return precio; }
        }


        public string Tipo
        {
            get { return tipo; }
            set
            {
                if (value == "bebida" || value == "alimento no perecedero" || value == "alimento fresco" || value == "producto de limpieza" || value == "producto de higiene")
                {
                    tipo = value;
                }
                else
                {
                    tipo = "no existe ese tipo de producto";
                }
            }
        }
        #endregion

            
        public Producto(string nombre, double peso, int precio, string tipo)
        {
            this.nombre = nombre;
            this.peso = peso;
            this.precio = precio;
            this.tipo = tipo;
            this.id = Producto.ultimoId;
            Producto.ultimoId++;

        }




        public bool tipoProducto(string producto)
        {
            bool mensaje = false;
            if(producto == "bebida" || producto == "alimento no perecedero" || producto == "alimento fresco" || producto == "producto de limpieza" || producto == "producto de higiene")
            {
                mensaje = true;
            }
            return mensaje;
        }


        public bool pesoProducto(double peso)
        {
            bool mensaje = false;
            if (peso > 0)
            {
                mensaje = true;
            }return mensaje;
        }



        public bool existeNombreProducto(string nombreProducto)
        {
            bool mensaje = false;
            if (nombreProducto != "")
            {
                mensaje = true;
            }return mensaje;
        }
    }
}
