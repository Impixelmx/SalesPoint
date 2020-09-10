using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entities
{
    class Moneda
    {
        public Guid IdMoneda { get; set; }
        public string Sombolo { get; set; }
        public string MonedaISO { get; set; }
        public string NombreMoneda { get; set; }
        public string Descripcion { get; set; }
        public string IdTipoPais { get; set; }
        public string TipoCambio { get; set; }
        public string Activo { get; set; }


    }
}
