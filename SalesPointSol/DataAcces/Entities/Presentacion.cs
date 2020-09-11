using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entities
{
    public class Presentacion
    {

        public Guid IdPresentacion { get; set; }
        public Guid IdArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
