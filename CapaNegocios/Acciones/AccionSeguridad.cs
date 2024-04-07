using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Base_de_Datos;

namespace CapaNegocios.Acciones
{
    public class AccionSeguridad : AccionesBases
    {
        ///auth
        ///
        public bool AuthenticationUser(string username, string clave)
        {
            bool _access = false;

            try {
                var validate = dbGold.TM_Usuario.
                    FirstOrDefault(x=>x.userName == clave & x.PasswordUser == username);

                _access = (validate != null) ? true : false;
                  
                return _access;

            }
            catch {
                return false;
            }
        }
        
        public string GetProfileUser(string username)
        {
            string perfil = String.Empty;

            try
            {
                perfil = dbGold.VW_Usuarios.FirstOrDefault(x => x.NombreUsuario == username).PerfilUsuario;
            }
            catch 
            {
                return String.Empty;
            }

            return perfil;
        }
    }
}
