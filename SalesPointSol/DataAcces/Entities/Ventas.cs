using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entities
{
    public class Ventas
    {
        public string IdVenta { get; set; }
        public Guid IdArticulo { get; set; }
        
        public DateTime FechaVenta { get; set; }
        public int TipoComprobante { get; set; }
        public string serie { get; set; }
        public string correlativo { get; set; }
        public decimal  Iva { get; set; }

        //LLaves foraneas
        public Guid IdCliente { get; set; }
        public Guid IdEmpleado { get; set; }

    }
}
