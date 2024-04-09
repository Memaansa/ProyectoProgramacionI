using CapaModelo.V_Modelos;
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
        public VM_Operaciones Oper = new VM_Operaciones();


        // GET: Mantenimiento
        public ActionResult MantenimientoIndex()
        {           
            Oper._TblOperaciones = Mantenimiento.ListaOperacionSistema();

            return View(Oper);
        }

        public ActionResult MantenimientoTablas()
        {
            Oper._TblOperaciones = Mantenimiento.ListaOperacionSistema();

            return View(Oper);
        }

        public string GuardarOperacion(string descripcion, string ruta)
        {
            return Mantenimiento.GuardarOperacionSistema(descripcion, ruta);
        }
    }
}