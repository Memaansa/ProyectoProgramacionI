using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Mvc;

namespace Prueba_Proyecto_Programación.Controllers
{
    public class MantenimientoController : Controller

        public AccionMantenimientos mantenimientos = new AccionMantenimientos();
    {
        // GET: Mantenimiento
        public ActionResult MantenimientoIndex()
        {
            List<mEstatus> lista_estados = new List<mEstatus>();
            lista_estados = mantenimientos.ListarEstados();


            return View(lista_estados);
        }       
    }
}