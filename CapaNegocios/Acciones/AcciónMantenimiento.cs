using System;
using System.Collections;
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
            var fuentes = dbGold.TM_Status.ToList();

            foreach (var item in fuentes)
            {
                mEstatus modelos = new mEstatus();

                modelos._descripctionEstatus = item.DescriptionStatus;
                modelos._fecCreate = item.DateCreate.Value;
                modelos._createBy = item.CreateBy;

                lista.Add(modelos);
            }
            return lista;
        }


        public List<TM_OperacionSistema> ListaOperacionSistema()
        {
            var lista = dbGold.TM_OperacionSistemas
                .Where(x=>x.flagActivo == true)
                .ToList();

            return lista == null ? new List<TM_OperacionSistema>() : lista;
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

