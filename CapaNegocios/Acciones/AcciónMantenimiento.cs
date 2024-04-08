using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Base_de_Datos;
using CapaModelo.Modelos;

namespace CapaNegocios.Acciones
{
    public class AcciónMantenimiento : AccionesBases
    {
        public string GuardarOperacionSistema(string name, string url)
        {
            //mensaje de retorno

            string msg;

            try
            {
                //bloque de codigo para llamar las operaciones del sistema
                TM_OperacionSistema register = new TM_OperacionSistema()
                {
                    DescripcionOperacion = name,
                    enlace_OperacionSistema = url,
                    fecCreacion = DateTime.Now,
                    usuarioCreacion = Environment.UserName,
                    flagActivo = true
                };

                msg = "La informacion fue registrada correctamente";

                dbGold.TM_OperacionSistemas.InsertOnSubmit(register);
                dbGold.SubmitChanges(); //commit
                
            }
            catch (Exception e)
            {
                msg = $"Hubo un problema en la operacion{e.Message}";
            }

            return msg;

        }



    }


}

