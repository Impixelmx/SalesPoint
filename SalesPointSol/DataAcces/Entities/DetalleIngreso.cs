using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entities
{
    public class DetalleIngreso
    {
        public Guid IdDetalleIngreso { get; set; }
      

        [Display(Name = "Precio Compra")]
        [Required(ErrorMessage = "Importe es requerido")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Importe debe ser mayor a cero")]
        public decimal PrecioCompra { get; set; }

        [Display(Name = "Precio Venta")]
        [Required(ErrorMessage = "Importe es requerido")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Importe debe ser mayor a cero")]
        public decimal PrecioVenta { get; set; }

        [Display(Name = "Stock Inicial")] 
        public decimal StockInicial { get; set; }

        [Display(Name = "Stock Final")]
        public decimal StockFinal { get; set; }

        [Display(Name = "Fecha Produccion")]
        public decimal FechaProduccion { get; set; }

        [Display(Name = "Fecha Vencimiento")]
        public decimal FechaVencimiento { get; set; }

        //LLaves Foraneas
        public Guid IdArticulo { get; set; }
        public Guid IdIngreso { get; set; }



    }
}
