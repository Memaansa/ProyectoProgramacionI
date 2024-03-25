using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos.Base_de_Datos;
using System.ComponentModel;
using CapaNegocios.Acciones;


namespace CapaNegocios.Acciones
{
    public class AccionesConsulta : AccionesBases
    {
        #region Listados Genericos

        public List<TM_Clientes> listarClientes() 
        {
            return dbGold.TM_Clientes.ToList();
        }

        public List<TM_ServicioAhorros> listarAhorros()
        {
            return dbGold.TM_ServicioAhorros.ToList();
        }

        public List<TM_ServicioCredito> listarCredito()
        {
            return dbGold.TM_ServicioCreditos.ToList();
        }

        public List<TM_ServicioCorriente> listarCorriente()
        {
            return dbGold.TM_ServicioCorrientes.ToList();
        }

        public List<TM_Prestamos> listarPrestamos()
        {
            return dbGold.TM_Prestamos.ToList();
        }

        public List<TD_CuentaCorriente> listarCuentaCorriente()
        {  
            return dbGold.TD_CuentaCorrientes.ToList();
        }

        public List<TD_CuentaAhorros> listarCuentaAhorros()
        {
            return dbGold.TD_CuentaAhorros.ToList();
        }

        public List<TD_CuentaCredito> listarCuentaCredito()
        {
            return dbGold.TD_CuentaCreditos.ToList();
        }
        public List<TD_CuentaPrestamo> listarCuentaPrestamo()
        {
            return dbGold.TD_CuentaPrestamos.ToList();
        }

        public List<TD_Transacciones> listarTransacciones()
        {
            return dbGold.TD_Transacciones.ToList();
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
