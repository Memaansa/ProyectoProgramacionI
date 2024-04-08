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
        public List<mEstatus> ListarEstados()
        {
            var fuentes = Db_GoldDataContext.TM_Status.ToList();

            foreach (var item fuentes)
            {
                mEstatus modelos = new mEstatus();

                modelos._descriptionEstaus = item.DescriptionStatus;
                modelos._fecCreate = item.DateCreate.Value;
                modelos._createBy = item.CreateBy;

                Lista.Add(modelos);
            }
            return Lista;
        }

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

