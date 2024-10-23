using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSemana10B.Controllers
{
    public class EjemploController : Controller
    {
        // GET: Ejemplo
        public ActionResult Index()
        {
            return View();
        }

        public string Mensaje()
        {
            return "Hola a todos";
        }
        public string Mensaje2()
        {
            return "<h1>Hola a todos</h1>";
        }

    }
}