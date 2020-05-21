using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    class Sistema
    {
        // cambio 20/5/2020 11:35
        // cambio 21/5/2020

        // se crean listas de tipo de que cada una de las clases.

        private List<CentroRecepcion> centrosRecepcion = new List<CentroRecepcion>();
        private List<Voluntario> voluntarios= new List<Voluntario>();
        private List<Donacion> donaciones = new List<Donacion>();
        private List<Producto> productos = new List<Producto>();


        #region Fechas
        // se crean fechas para luego ser empleadas en la carga de datos.

        DateTime FechaNacimiento1 = new DateTime(1993, 7, 26);
        DateTime FechaNacimiento2 = new DateTime(1999, 1, 1);
        DateTime FechaNacimiento3 = new DateTime(1996, 10, 24);
        DateTime FechaNacimiento4 = new DateTime(1946, 1, 17);
        DateTime FechaNacimiento5 = new DateTime(1998, 7, 17);
        DateTime FechaNacimiento6 = new DateTime(2004, 7, 17);
        DateTime FechaNacimiento7 = new DateTime(1994, 9, 27);
        DateTime FechaNacimiento8 = new DateTime(1996, 6, 21);
        DateTime FechaNacimiento9 = new DateTime(1986, 1, 8);
        DateTime FechaNacimiento10 = new DateTime(1984, 5, 26);


        DateTime FechaDonacion1 = new DateTime(2020, 4, 20);
        DateTime FechaDonacion2 = new DateTime(2020, 4, 12);
        DateTime FechaDonacion3 = new DateTime(2020, 4, 11);
        DateTime FechaDonacion4 = new DateTime(2020, 4, 16);
        DateTime FechaDonacion5 = new DateTime(2020, 4, 9);
        DateTime FechaDonacion6 = new DateTime(2020, 4, 3);

        #endregion

        #region Carga de Datos

        public void CargaDeDatos() {
            
                //Carga de Centros de Recepcion
            
                this.AltaCentroRecepcion("Centro Palermo", "Durazno 1402");
                this.AltaCentroRecepcion("Centro Cordon", "Soriano 1472");
                this.AltaCentroRecepcion("Centro Pocitos", "Juan Maria Perez 2880");
                this.AltaCentroRecepcion("Centro Ciudad Vieja", "Cerrito 301");
                this.AltaCentroRecepcion("Centro Malvin", "Candelaria 1639");
            
                //Carga de Productos

                this.AltaProducto("Agua Salus con Gas", 2.5, 52, "bebida");
                this.AltaProducto("Agua Salus con Gas", 2.5, 52, "bebida");
                this.AltaProducto("Fideos al huevo ADRIA moña chica", 0.5, 61, "alimento no perecedero");
                this.AltaProducto("Fideos Spaghetti BARILLA N°5", 0.5, 88, "alimento no perecedero");
                this.AltaProducto("Carne picada Premium", 0.5, 173, "alimento fresco");
                this.AltaProducto("Carne picada Especial", 0.5, 135, "alimento fresco");
                this.AltaProducto("Lavandina Agua Jane", 2, 107, "producto de limpieza");
                this.AltaProducto("Jabón en Barra Bull Dog", 0.2, 49, "producto de limpieza");
                this.AltaProducto("Desodorante Rexona Bamboo", 0.15, 143, "producto de higiene");
                this.AltaProducto("Desodorante DOVE Regular Aerosol", 0.1, 172, "producto de higiene");

                //Carga de Voluntarios
                
                this.AltaVoluntario("Vicente Cersosimo", "4538725-9", 099588970, FechaNacimiento1);
                this.AltaVoluntario("Mateo Laguna", "2931091-3", 099674992, FechaNacimiento2);
                this.AltaVoluntario("Juana Fernández", "1528324-9", 098243546, FechaNacimiento3);
                this.AltaVoluntario("Jorge Luis Vega", "6212527-4", 098243546, FechaNacimiento4);
                this.AltaVoluntario("Maria Juarez", "5234040-8", 098243546, FechaNacimiento5);
                this.AltaVoluntario("Alfredo Morales", "c", 098243546, FechaNacimiento6);
                this.AltaVoluntario("Ramon Vazquez", "1854654-3", 098243546, FechaNacimiento7);
                this.AltaVoluntario("Romina Iglesias", "5124957-0", 098243546, FechaNacimiento8);
                this.AltaVoluntario("Luciano Yandre", "5574173-2", 098243546, FechaNacimiento9);
                this.AltaVoluntario("Maria Ibañez", "1482452-7", 098243546, FechaNacimiento10);
            
                //Carga de Donaciones de tipo Economicas

                
                this.AltaDonacionEconomica(FechaDonacion1, 1, 1000, "Centro Palermo");
                this.AltaDonacionEconomica(FechaDonacion2, 2, 3000, "Centro Cordon");
            
                //Carga de Donaciones de tipo Productos
                
                this.AltaDonacionProducto(productos[0], 1, FechaDonacion3, 3, "Agua Salus con Gas", "Centro Palermo");
                this.AltaDonacionProducto(productos[1], 2, FechaDonacion4, 4, "Agua Salus con Gas", "Centro Cordon");
                this.AltaDonacionProducto(productos[3], 3, FechaDonacion5, 5, "Fideos al huevo ADRIA moña chica", "Centro Pocitos");
                this.AltaDonacionProducto(productos[4], 4, FechaDonacion6, 6, "Fideos Spaghetti BARILLA N°5", "Centro Ciudad Vieja");
            
                //Carga de voluntarios en cada centro
                
                this.AgregarVoluntarioCentro("4538725-9", "Centro Palermo");
                this.AgregarVoluntarioCentro("2931091-3", "Centro Cordon");
                this.AgregarVoluntarioCentro("1528324-9", "Centro Pocitos");
            
        }
        #endregion

        #region Altas

        //se piden ciertos parametros necesarios para verificar y a su vez poder crear un nuevo producto no existe en el sistema aun.

        public string AltaProducto(string nombre, double peso, int precio, string tipo)
        {
            //se verifica que los paremtros no esten vacios 

            string mensaje = "El producto no se dio de alta";
            if(nombre != "" && peso>0 && precio>0 && tipo != "")
            {
                //se implementa el metodo BuscarProducto segun el nombre y de esta manera se chequea que este producto no exista ya en el sistema.

                if (!BuscarProducto(nombre))
                {
                    //en caso de que la respuesta de este metodo sea false, osea que no exista previamente, se creara un producto de tipo Producto con los parametros
                    //pedidos desde un inicio y se agregaran a la lista de productos.

                    Producto producto = new Producto(nombre, peso, precio, tipo);
                    productos.Add(producto);
                    mensaje = "El producto fue dado de alta";
                }
                else
                {
                    mensaje = "El producto ya existe";
                }
                
            }
            return mensaje;
        }

        //se piden ciertos parametros necesarios para verificar y a su vez poder crear un voluntario que no existe en el sistema aun.

        public string AltaVoluntario(string nombre, string cedula, int telefono, DateTime fechaDeNacimiento)
        {
            string mensaje = "El Voluntario no fue dado de alta";

            //se verifica que los paremtros no esten vacios 

            if (nombre != "" && cedula != "" && telefono > 0 && fechaDeNacimiento <= DateTime.Now &&
                fechaDeNacimiento > DateTime.MinValue)
            {

                if (!BuscarVoluntario(cedula))
                {
                    //en caso de que la respuesta de este metodo sea false, osea que no exista previamente, se creara un nuevo voluntario de tipo Voluntario con los parametros
                    //pedidos desde un inicio y se agregaran a la lista de voluntarios.

                    Voluntario voluntario = new Voluntario(nombre, cedula, telefono, fechaDeNacimiento);
                    voluntarios.Add(voluntario);
                    mensaje = "El Voluntario no fue dado de alta";

                }
                else
                {
                    mensaje = "El Voluntario ya existe";

                }
            }
            return mensaje;
        }


        //se piden ciertos parametros necesarios para verificar y a su vez poder crear un centro de recepcion que no existe en el sistema aun.

        public string AltaCentroRecepcion(string nombre, string direccion)
        {
            string mensaje = "El Centro de Recepcion no fue dado de alta";

            //se verifica que los paremtros no esten vacios 

            if (nombre != "" && direccion != "")
            {
                if (!BuscarCentroRecepcion(nombre))
                {
                    //en caso de que la respuesta de este metodo sea false, osea que no exista previamente, se creara un nuevo centro de recepcion de tipo centroRecepcion con los parametros
                    //pedidos desde un inicio y se agregaran a la lista de centrosRecepcion.

                    CentroRecepcion Centro = new CentroRecepcion(nombre, direccion);
                    centrosRecepcion.Add(Centro);
                    mensaje = "El Centro de Recepcion fue dado de alta";

                }
            }
            else
            {
                mensaje = "El Centro de Recepcion no fue dado de alta";

            }
            return mensaje;

        }
        //se piden ciertos parametros necesarios para poder verificar que esta donacion no exista previamente en el sistema y a la vez poder crear esta donacion de tipo economica.

        public string AltaDonacionEconomica(DateTime fehcaDonacion, int codigoDonacion, double monto, string nombreCentro)
        {
            string mensaje = "La Donacion no fue dada de alta";

            //se verifica que los paremtros no esten vacios

            if (codigoDonacion>0 && monto>0 && nombreCentro!="")
            {
                //se crea una nueva donacion economica de tipo Donacion en donde se va a utilizar el metodo de BuscarDonacion para
                //verificar que esta donacion no exista previamente.

                Donacion doneco = BuscarDonacion(codigoDonacion);

                //se crea una objeto de tipo CentroRecepcion en donde se va a utilizar el metodo de BuscarCentroExistente para
                //verificar que este centro exista y se pueda agregar a dicho centro la donacion de tipo economico.

                CentroRecepcion centro = BuscarCentroExistente(nombreCentro);
                if (doneco==null)
                {
                    //en caso de que la donacion no existiera aun en sistema, esta donacion sera creada y se agregara a la lista donaciones de la clase Donacion  
                    // y a su vez a la lista Donaciones dentro de la clase CentroRecepcion.

                    doneco = new DonacionEconomica(fehcaDonacion, codigoDonacion, monto);
                    this.donaciones.Add(doneco);
                    centro.Donaciones.Add(doneco);
                    mensaje = "La Donacion Economica fue dada de alta";

                }
            }
            else
            {
                mensaje = "La Donacion Economica no fue dado de alta";

            }
            return mensaje;

        }

        //se piden ciertos parametros necesarios para poder verificar que esta donacion no exista previamente en el sistema y a la vez poder crear esta donacion de tipo producto.

        public string AltaDonacionProducto(Producto tipoDeProducto, int cantidad,DateTime fechaDonacion, int codigoDonacion, string nombreProducto, string nombreCentro)
        {
            string mensaje = "La Donacion no fue dada de alta";

            //se verifica que los paremtros no esten vacios

            if (codigoDonacion>0 && nombreProducto!="" && nombreCentro!="")
            {
                //se crea un objeto de tipo Producto en el cual se utilizara el metodo BuscarProductoExistente para verificar si este producto
                // ya esta dado alta en el sistema o no.
                
                Producto producto = BuscarProductoExistente(nombreProducto);

                //se crea una nueva donacion producto de tipo Donacion en donde se va a utilizar el metodo de BuscarDonacion para
                //verificar que esta donacion no exista previamente.

                Donacion donacion = BuscarDonacion(codigoDonacion);

                //se crea una objeto de tipo CentroRecepcion en donde se va a utilizar el metodo de BuscarCentroExistente para
                //verificar que este centro exista y se pueda agregar a dicho centro la donacion de tipo producto.

                CentroRecepcion centro = BuscarCentroExistente(nombreCentro);
                if (donacion == null && producto!=null)
                {
                    //en caso de que la donacion aun no existiera y el producto ya habia sido dado de alta 
                    // se agregara dicha donacion de tipo producto a la lista de donaciones dentro de la clase Donacion.
                    //a su vez esta donacion sera agregada a la lista Donaciones dentro de la clase CentroRecepcion.

                    donacion = new DonacionProducto(tipoDeProducto, cantidad, fechaDonacion, codigoDonacion);
                    this.donaciones.Add(donacion);
                    centro.Donaciones.Add(donacion);
                    mensaje = "La Donacion Producto fue dada de alta";
                    
                }
            }
            else
            {
                mensaje = "La Donacion Producto no fue dado de alta";

            }
            return mensaje;

        }
        
        //se piden ciertos parametros necesarios para poder verificar que esta donacion no exista previamente en el sistema y a la vez poder crear esta donacion de tipo producto.

        public string AgregarVoluntarioCentro(string cedula, string nombreCentro)
        {
            string mensaje = "El voluntario no fue agregado a centro de recepcion";
            if (cedula != "" && nombreCentro != "")
            {
                //se verifica que los paremtros no esten vacios

                CentroRecepcion centro = BuscarCentroExistente(nombreCentro);

                //se crea una objeto de tipo CentroRecepcion en donde se va a utilizar el metodo de BuscarCentroExistente para
                //verificar que este centro exista y se pueda agregar a dicho centro el voluntario.

                Voluntario voluntario = BuscarVoluntarioExistente(cedula);

                //se crea una objeto de tipo Voluntario en donde se va a utilizar el metodo de BuscarVoluntarioExistente para
                //verificar que este voluntario exista y se pueda agregar al centro de recepcion elegido.

                if (voluntario != null && centro != null)
                {
                    //en caso de que el voluntario y el centro de recepcion exista
                    // se agregara dicho voluntario a la lista de Voluntarios dentro de la clase CentroRecepcion.
                   
                    centro.Voluntarios.Add(voluntario);
                    mensaje = "El voluntario fue agregado a centro de recepcion";
                }
                else
                {
                    mensaje = "El voluntario no fue agregado a centro de recepcion";
                }
            }

            return mensaje;

        }

        

        #endregion

        #region MetodosBuscar

        // se crea este metodo para verificar si un producto ya existe o no.
        //se le pasa como parametro el nombre de este producto y verifica dentro de la lista de productos si existe o no.
        //devuelve un objeto de tipo Producto.

        private Producto BuscarProductoExistente(string nombre)
        {
            Producto producto = null;
            int i = 0;
            while (i < productos.Count && producto == null)
            {
                if (productos[i].Nombre == nombre)
                {
                    producto = productos[i];
                }
                i++;
            }
            return producto;
        }

        //se crea este metodo para verificar si existe un voluntario o no.
        //se le pasa como parametro la cedula que es dato unico que tiene cada persona 
        //devuelve un booleano

        private bool BuscarVoluntario(string cedula)
        {
            bool encotreVoluntario = false;
            int i = 0;
            while (i < voluntarios.Count && !encotreVoluntario)
            {
                if (voluntarios[i].Cedula.Equals(cedula))
                {
                    encotreVoluntario = true;
                }
                i++;
            }
            return encotreVoluntario;

        }

        // se crea este metodo para verificar si un producto ya existe o no.
        //se le pasa como parametro el nombre de este producto y verifica dentro de la lista de productos si existe o no.
        //devuelve un booleano

        private bool BuscarProducto(string nombre)
        {
            bool encotreProducto = false;
            int i = 0;
            while (i < productos.Count && !encotreProducto)
            {
                if (productos[i].Nombre.Equals(nombre))
                {
                    encotreProducto = true;
                }
                i++;
            }
            return encotreProducto;

        }

        // se crea este metodo para verificar si un centro de recepcion ya existe o no.
        //se le pasa como parametro el nombre y verifica dentro de la lista de centrosRecepcion si existe o no.
        //devuelve un booleano

        private bool BuscarCentroRecepcion(string nombre)
        {
            bool encotreCentro = false;
            int i = 0;
            while (i < centrosRecepcion.Count && !encotreCentro)
            {
                if (centrosRecepcion[i].Nombre.Equals(nombre))
                {
                    encotreCentro = true;
                }
                i++;
            }
            return encotreCentro;

        }

        // se crea este metodo para verificar si una donacion ya existe o no.
        //se le pasa como parametro el codigo que es unico y verifica dentro de la lista de donaciones si existe o no.
        //devuelve un objeto de tipo Donacion.

        private Donacion BuscarDonacion(int codigoDonacion)
        {

            Donacion don = null;
            int i = 0;
            while (i < donaciones.Count && don==null)
            {
                if (donaciones[i].CodigoDonacion.Equals(codigoDonacion))
                {
                    don = donaciones[i];
                }
                i++;
            }
            return don;

        }

        // se crea este metodo para verificar si un centro de recepcion ya existe o no.
        //se le pasa como parametro el nombre del centro y verifica dentro de la lista de centrosRecepcion si existe o no.
        //devuelve un objeto de tipo CentroRecepcion.

        private CentroRecepcion BuscarCentroExistente(string nombreCentro)
        {
            CentroRecepcion centro = null;
            int i = 0;
            while (i < centrosRecepcion.Count && centro == null)
            {
                if (centrosRecepcion[i].Nombre == nombreCentro)
                {
                    centro = centrosRecepcion[i];
                }
                i++;
            }
            return centro;

        }

        ///se crea este metodo para verificar si existe un voluntario o no.
        //se le pasa como parametro la cedula que es un dato unico que tiene cada persona 
        //devuelve un objeto de tipo Voluntario.

        private Voluntario BuscarVoluntarioExistente(string cedula)
        {
            Voluntario voluntario = null;
            int i = 0;
            while (i < voluntarios.Count && voluntario == null)
            {
                if (voluntarios[i].Cedula == cedula)
                {
                    voluntario = voluntarios[i];
                }
                i++;
            }
            return voluntario;

        }


        #endregion
        
        #region Listas

        //La lista muestra los productos existentes en el sistema.
        //se crea una variable de tipo Producto la cual recorrera la lista de productos y retornara a una 
        //variable de tipo string el resultado para luego ser mostrado.

        public string MostrarListaDeProductos()
        {
            string lista = "";
            
            foreach(Producto n in productos)
            {
                lista += n.Nombre + " " + n.Tipo + " " + n.Precio + "\n";
            }
            return lista;
        }

        //La lista muestra los voluntarios existentes  que tiene un centro de repcion especifico.
        //se crea una variable de tipo CentroRecepcion y se busca si existe o no, 
        //Luego se crea una variable de tipo Voluntario que reccora la lista de Voluntarios dentro de mi clase CentroRecepcion 
        //Se crea una variable de tipo string la cual va agregando todos los voluntarios que esten inscriptos dentro del centro especificado        


        public string MostrarListaVoluntarios(string NombreCentro)
        {
            string lista = "";
            CentroRecepcion centro = BuscarCentroExistente(NombreCentro);
            
                
                    foreach(Voluntario x in centro.Voluntarios)
                    {
                        lista += x.Nombre+"\n";
                    }
                
            
            return lista;
        }

        //La lista muestra la cantidad de donaciones existentes en el sistema en una fecha dada.
        //se crea una variable de tipo CentroRecepcion la cual recorrera la lista de Donaciones dentro de la clase CentroRecepcion
        //y retornara a una variable de tipo string el resultado para luego ser mostrado.
        
        public string MostrarListaDonaciones(DateTime fecha)
        {
            
            string concatenacion = "";
            
            foreach (CentroRecepcion x in centrosRecepcion)
            {
                int contador = 0;
                int i = 0;
                while (i < x.Donaciones.Count )
                {
                    
                   
                        contador++;
                    
                    
                }
                concatenacion += x.Nombre +" "+ contador + "\n";
                
            }


            return concatenacion;
        }

        #endregion


        #region Validaciones

        public bool tipoProducto(string producto)
        {
            producto = producto.ToLower();

            bool mensaje = false;
            if (producto == "bebida" || producto == "alimento no perecedero" || producto == "alimento fresco" || producto == "producto de limpieza" || producto == "producto de higiene")
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
            }
            return mensaje;
        }

        public bool existeNombreProducto(string nombreProducto)
        {
            bool mensaje = false;
            if (nombreProducto != "")
            {
                mensaje = true;
            }
            return mensaje;
        }



        public bool existeCentro(string nombreCentro)
        {
            
            bool mensaje = false;
            // debe ser un for();
            int i = 0;
            while (i < centrosRecepcion.Count)
            {
                if (centrosRecepcion[i].Nombre == nombreCentro)
                {
                    mensaje = true;
                }
                
                i++;
            }
            return mensaje;
            
        }


        public bool existeFechaDonacion(DateTime fecha)
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
