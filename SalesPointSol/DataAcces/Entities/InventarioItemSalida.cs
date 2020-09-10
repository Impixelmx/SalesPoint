using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entities
{
    public class InventarioItemSalida
    {
        public Guid IdSalidaInventario { get; set; }
        public int SalidaInventario { get; set; }
        public int ArtiuloSalidaInventario { get; set; }
        public decimal CantidadSalidaInventario { get; set; }
        public decimal PrecioSalidaInventario { get; set; }
        public decimal MedidaSalidaInventario { get; set; }

    }
}
