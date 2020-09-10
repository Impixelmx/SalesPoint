using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entities
{
    public class Tenant
    {
        public Guid IdTenant { get; set; }
        public string Logo { get; set; }
        public string Nombre { get; set; }
        public string Slogan { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Lenguage { get; set; }
        public string Tema { get; set; }

        public int Giro { get; set; }



        public string ConfiguracionLogoCompletada { get; set; }
        public string ConfiguracionLogoOmitida { get; set; }
        public string ConfiguracionDatosFiscalesCompletada { get; set; }
        public string ConfiguracionDatosFiscalesOmitida { get; set; }
        public string ConfiguracionCertificadosCompletada { get; set; }
        public string ConfiguracionCertificadosOmitida { get; set; }      
    }
}
