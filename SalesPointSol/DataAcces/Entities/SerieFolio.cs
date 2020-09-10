using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entities
{
    public class SerieFolio
    {
        public Guid IdSerieFolio { get; set; }
        public Guid IdTenant { get; set; }
        public string Serie { get; set; }
        public long FolioInicial { get; set; }
        public long SiguienteFolio { get; set; }
        public int TipoDocumentoEnum { get; set; } 
        public bool Activo { get; set; } 

    }
}
