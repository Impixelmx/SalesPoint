using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entities
{
    public class Ingreso
    {
        public Guid IdIngreso { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int TipoComprobante { get; set; }
        public string Serie { get; set; }
        public string Correlativo { get; set; }
        public int Iva { get; set; }


        //LLaves foraneas

        public Guid IdProveedor { get; set; }
        public Guid IdEmpleado { get; set; }

    }
}
