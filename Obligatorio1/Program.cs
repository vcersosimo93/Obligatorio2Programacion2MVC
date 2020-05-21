using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    class Program
    {
        private static Sistema administradora = new Sistema();

        static void Main(string[] args)
        {
           
            administradora.CargaDeDatos();
            

            int opcion = -1;
            while (opcion != 5)
            {
                MostrarMenuPrincipal();
                Console.WriteLine("Ingrese una opcion");
                int.TryParse(Console.ReadLine(), out opcion);
                if (opcion > 0)
                {
                    VerificarOpcionPrincipal(opcion);
                }
                else
                {
                    Console.WriteLine("Por favor escribir un numero del 1 al 5, gracias");
                }
                
            }

        }


        private static void MostrarMenuPrincipal()
        {
            Console.WriteLine("1-Lista de Productos");
            Console.WriteLine("2-Lista de Voluntarios para centro de recepcion");
            Console.WriteLine("3-Lista de Donaciones segun fecha y centro de recepcion");
            Console.WriteLine("4-Dar de alta un nuevo producto");
            Console.WriteLine("5-Salir");

        }
        private static void VerificarOpcionPrincipal(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    MostarListaDeProductos();
                    break;

                    case 2:
                    MostrarListaVoluntariosPorCentro();
                        break;

                    case 3:
                    MostraListaDeDonaciones();
                        break;
                    case 4:
                    AltaDeProducto();
                        break;
                    

            }
        }


        private static void MostarListaDeProductos()
        {
            if (administradora.MostrarListaDeProductos() != null)
            {
                Console.WriteLine("Lista de productos: " + "\n");
                Console.WriteLine(administradora.MostrarListaDeProductos() + "\n");
            }
            else
            {
                Console.WriteLine("En este momento no tenemos almacenado ningun producto");
            }
            
        }


        private static void MostrarListaVoluntariosPorCentro()
        {
            Console.WriteLine("Escriba el nombre del Centro de Recepcion al que le gustaria ver los voluntarios habilitados ");
            string nombreCentro = Console.ReadLine();
            if(nombreCentro != "")
            {
                if (administradora.existeCentro(nombreCentro))
                {

                    if (administradora.MostrarListaVoluntarios(nombreCentro) != "")
                    {
                        Console.WriteLine("Los usuarios habilitados para el centro " + nombreCentro + " son:" + "\n");
                        Console.WriteLine(administradora.MostrarListaVoluntarios(nombreCentro) + "\n");

                    }
                    else
                    {
                        Console.WriteLine("El centro " + nombreCentro + " no contiene voluntarios" + "\n");
                    }

                }
                else
                {
                    Console.WriteLine("El centro seleccionado no existe" + "\n");
                }
                
            }
            else
            {
                Console.WriteLine("Por favor escribir un centro valido, gracias" + "\n");
            }
                
            
        }


        private static void MostraListaDeDonaciones()
        {
            Console.WriteLine("Para que fecha quiere ver la lista de donaciones por cada Centro de Recepcion? ");
            Console.WriteLine("La fecha debe ser escrita de la siguiente manera: yyyy/mm/dd");
            DateTime.TryParse(Console.ReadLine(), out DateTime fechaListaDonaciones);
            if (administradora.existeFechaDonacion(fechaListaDonaciones) == true)
            {
                if (fechaListaDonaciones <= DateTime.Now)
                {
                    if (administradora.MostrarListaDonaciones(fechaListaDonaciones) != null)
                    {
                        Console.WriteLine("La lista de Donaciones en cada centro que corresponde con la fecha " + fechaListaDonaciones + " es:" + "\n");
                        Console.WriteLine(administradora.MostrarListaDonaciones(fechaListaDonaciones));
                    }
                }
                else
                {
                    Console.WriteLine("Por favor escribir una fecha menor o igual a la del dia de hoy" + "\n");
                }
                
            }
            else
            {
                Console.WriteLine("fecha invalida la fecha debe ser escrita de la siguiente forma: yyyy/mm/dd");
            }
            
        }
        

        private static void AltaDeProducto()
        {
            Console.WriteLine("Escriba el nombre del producto que quiere dar de alta ");
            string nombreNuevoProducto = Console.ReadLine();
            Console.WriteLine("Escriba el peso del producto que quiere dar de alta ");
            double pesoNuevoProducto;
            double.TryParse(Console.ReadLine(), out pesoNuevoProducto);
            Console.WriteLine("Escriba el precio del producto que quiere dar de alta ");
            int precioNuevoProducto;
            int.TryParse(Console.ReadLine(), out precioNuevoProducto);
            Console.WriteLine("Escriba el tipo de producto que quiere dar de alta ");
            string tipoNuevoProducto = Console.ReadLine();
            

            if (administradora.existeNombreProducto(nombreNuevoProducto) == true)
            {
                if (administradora.pesoProducto(pesoNuevoProducto) == true)
                {
                    if (administradora.tipoProducto(tipoNuevoProducto) == true)
                    {
                        if (administradora.AltaProducto(nombreNuevoProducto, pesoNuevoProducto, precioNuevoProducto, tipoNuevoProducto) == "El producto fue dado de alta")
                        {
                            Console.WriteLine("El producto fue dado de alta");
                        }
                        else
                        {
                            Console.WriteLine("El producto ya existe");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Tipo de producto incorrecto los tipos de productos validos son: bebida, alimento no perecedero, alimento fresco, producto de limpieza, producto de higiene");
                    }
                    
                }
                else
                {
                    Console.WriteLine("El peso no puede ser menor a cero");
                }
                
            }
            else
            {
                Console.WriteLine("No escribio un nombre para el producto");
            }

            
        }

        

    }
}
