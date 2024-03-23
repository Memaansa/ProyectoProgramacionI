using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Base_de_Datos;

namespace CapaModelo.Modelos
{
    public class ModelCategory
    {
        public int idCategory {  get; set; }

        public string _descriptionCategory { get; set; }

        public DateTime _dateRegister { get; set; }

        public bool _flag {  get; set; }

        public ModelCategory()
        {

        }

        public ModelCategory(int _idCategory,string _descriptionCategory,DateTime _dataRegister, bool _falg)
        {
            this.idCategory = _idCategory;
            this._descriptionCategory = _descriptionCategory;
            this._dateRegister = _dataRegister;
            this._flag = _falg;

         
        }
    }
}
