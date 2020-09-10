using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entities
{
    public class UnidadMedida
    {
        public Guid IdUnidadMedida { get; set; }
        public string UMNombre { get; set; }
        public string UMabreviatura { get; set; }
        public string UMUnidad { get; set; }
        public string UMEstado { get; set; }
        public string UMObservacion { get; set; }

    }
}
