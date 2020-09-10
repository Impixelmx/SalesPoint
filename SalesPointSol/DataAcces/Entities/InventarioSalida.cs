using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entities
{
    public class InventarioSalida
    {
        public Guid IdInventarioSalida { get; set; }
        public DateTime FechaSalida { get; set; }
        public Guid IdClienteSal { get; set; }
        public int TramsaccionSalida { get; set; }
        public int EntradaSalida { get; set; }
    }
}
