using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entities
{
    public class Codigo
    {
        public Guid IdTenant { get; set; }
        public Guid IdCodigo { get; set; }
        public string CodigoCode { get; set; }
        public string CodigoAbreviatura { get; set; }
        public string CodigoTabla { get; set; }
        public string CodigoEstado { get; set; }
        public string CodigoObservacion { get; set; }

    }
}
