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
    internal class AccionesConsulta : AccionesBases
    {
   
        #region Listados Genericos

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

        public List<TD_CuentaPrestamo> listarCuentaPrestamo(Db_GoldDataContext db_GoldDataContext)
        {
            return db_GoldDataContext.TD_CuentaPrestamo.ToList();
        }
          
        public List<TD_Transacciones> listarTransacciones(Db_GoldDataContext db_GoldDataContext)
        {
            return db_GoldDataContext.TD_Transacciones.ToList();
        }
        
        
      
        #endregion
            
        #region Filtros Relacionales

        public List<TD_CuentaAhorros> listAhorrosCliente(int id, Db_GoldDataContext db_GoldDataContext) 
        {
            return db_GoldDataContext.TD_CuentaAhorros.Where(x => x.numerocuenta == id).ToList();
        }
        #endregion
    }
}
