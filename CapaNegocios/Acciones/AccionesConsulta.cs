using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos.Base_de_Datos;
using System.ComponentModel;


namespace CapaNegocios.Acciones
{
    public class AccionesConsulta : AccionesBases
    {
   

        public List<TM_Clientes> listarClientes(Db_GoldDataContext db_GoldDataContext) 
        {
            return db_GoldDataContext.TM_Clientes.ToList();
        }

        public List<TM_ServicioAhorros> listarAhorros(Db_GoldDataContext db_GoldDataContext)
        {
            return db_GoldDataContext.TM_ServicioAhorros.ToList();
        }

        public List<TM_ServicioCredito> listarCredito(Db_GoldDataContext db_GoldDataContext)
        {
            return db_GoldDataContext.TM_ServicioCredito.ToList();
        }

        public List<TM_ServicioCorriente> listarCorriente(Db_GoldDataContext db_GoldDataContext)
        {
            return db_GoldDataContext.TM_ServicioCorriente.ToList();
        }

        public List<TM_Prestamos> listarPrestamos(Db_GoldDataContext db_GoldDataContext)
        {
            return db_GoldDataContext.TM_Prestamos.ToList();
        }

        public List<TD_CuentaCorriente> listarCuentaCorriente(Db_GoldDataContext db_GoldDataContext)
        {  
            return db_GoldDataContext.TD_CuentaCorriente.ToList();
        }

        public List<TD_CuentaAhorros> listarCuentaAhorros(Db_GoldDataContext db_GoldDataContext)
        {
            return db_GoldDataContext.TD_CuentaAhorros.ToList();
        }

        public List<TD_CuentaCredito> listarCuentaCredito(Db_GoldDataContext db_GoldDataContext)
        {
            return db_GoldDataContext.TD_CuentaCredito.ToList();
        }


 

    }
 }
