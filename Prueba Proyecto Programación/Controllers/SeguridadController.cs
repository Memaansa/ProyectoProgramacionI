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
            else {
                vista = "Login";
            }

            return View(vista);

        }

        public ActionResult UsuarioFuncional() 
        { 
            
            return View(); 
        }

        public ActionResult UsuarioTecnico()
        {

            return View();
        }
    }

}