using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entities
{
    public class DetalleVenta
    {
        public Guid IdDetalleVenta { get; set; }
        public int Cantidad { get; set; }

        [Display(Name = "Precio Venta")]
        [Required(ErrorMessage = "Importe es requerido")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Importe debe ser mayor a cero")]
        public decimal PrecioVenta { get; set; }

        [Display(Name = "Descuento")]
        [Required(ErrorMessage = "Importe es requerido")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Importe debe ser mayor a cero")]
        public decimal Descuento { get; set; }


        //LLaves Foraneas
        public Guid IdVenta { get; set; }
        public Guid IdDetalleIngreso { get; set; }
    }
}
