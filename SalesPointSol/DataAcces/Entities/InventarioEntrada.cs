using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entities
{
    public class InventarioEntrada
    {
        public Guid IdInventarioEntrada { get; set; }
        public int ProveedorEntrada { get; set; }
        public string FacEntrada { get; set; }
        public DateTime FechaEntrada { get; set; }
        public int TransaccionEntrada { get; set; }
        public int SalidaEntada { get; set; }
    }
}
