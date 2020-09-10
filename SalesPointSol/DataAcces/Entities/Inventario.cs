using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entities
{
    public class Inventario
    {
        public Guid IdInventario { get; set; }
        public Guid IdTenant { get; set; }
        public Guid IdArticulo { get; set; }
        public int CantidadInventario { get; set; }
    }
}
