using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entities
{
   public class Talla
    {
        public Guid IdTenant { get; set; }
        public Guid IdArticulo { get; set; }
        public string TallaNombre { get; set; }
        public string TallaAbreviatura { get; set; }
        public string TallaEstado { get; set; }
        public string TallaObservacion { get; set; }

    }
}
