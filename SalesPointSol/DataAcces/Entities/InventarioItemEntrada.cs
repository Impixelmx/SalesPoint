using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entities
{
    public class InventarioItemEntrada
    {
        public Guid IdEntrada { get; set; }
        public int ArticuloItemEntrada { get; set; }
        public int EntradaItemEntrada { get; set; }
        public decimal PrecioCompraItemEntrada { get; set; }
        public decimal SaldoInventarioEntrada { get; set; }
        public decimal CantidadItemEntrada { get; set; }
    }
}
