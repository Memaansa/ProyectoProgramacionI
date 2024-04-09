using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo.Modelos
{
    public class mEstatus
    {
        public int _idEstatus { get; set; }
        public string _descripctionEstatus { get; set; }
        public string _modifyBy { get; set; }
        public string _createBy { get; set; }
        public string _cancelBy { get; set;}
        public DateTime _fecCreate { get; set; }
        public DateTime _fecModify { get; set; }
        public DateTime _fecCancel { get; set;}
        

        public mEstatus()
        {

        }
    }
}
