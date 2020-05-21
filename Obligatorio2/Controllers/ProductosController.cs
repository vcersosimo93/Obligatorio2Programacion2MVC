using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Obligatorio2Programacion2MVC;

namespace Obligatorio2.Controllers
{
    public class ProductosController : Controller
    {
        private static Administradora administradora = new Administradora();

        // GET: Productos
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AltaProductos(string nombre, double ? peso, int ? precio, string tipo)
        {
            if(nombre !="" && (double)peso>0 && (int)precio>0 && tipo != "")
            {

            }
        }

        
        
    }
}