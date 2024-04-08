using CapaNegocios.Acciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Mvc;

namespace Prueba_Proyecto_Programación.Controllers
{
    public class MantenimientoController : Controller
    {
        public AcciónMantenimiento Mantenimiento = new AcciónMantenimiento();



        // GET: Mantenimiento
        public ActionResult Mantenimientoindex()
        {
            return View();
        }

        public string GuardarOperacion(string descripcion, string ruta)
        {
            return Mantenimiento.GuardarOperacionSistema(descripcion, ruta);
        }
    }
}