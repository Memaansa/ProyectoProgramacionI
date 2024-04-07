using CapaDatos.Base_de_Datos;
using CapaNegocios.Acciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba_Proyecto_Programación.Controllers
{
    public class SeguridadController : Controller
    {
        public AccionSeguridad accionSeguridad = new AccionSeguridad();

        // GET: Seguridad
        public ActionResult Login()
        {

            return View();
        }

        public ActionResult btnIniciarSesion(string usuario = "", string clave = "")
        {
            string vista = string.Empty;

            if (accionSeguridad.AuthenticationUser(usuario, clave))
            {
                vista = accionSeguridad.GetProfileUser(usuario);
            }
            else
            {
                vista = "Login";
            }

            return View("_UsuarioFuncional");

        }

        public ActionResult _UsuarioFuncional() 
        { 
            
            return View(); 
        }

        public ActionResult _UsuarioTecnico()
        {

            return View();
        }

        public ActionResult _UsuarioAdmi()
        {
            return View();
        }
    }

}