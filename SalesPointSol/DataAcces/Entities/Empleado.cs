using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entities
{
    public class Empleado
    {
        public Guid IdEmpleado { get; set; }
        public Guid IdTenant { get; set; }
        public Guid IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Bloqueado { get; set; }
        public string MotivoBloqueo { get; set; }
        public string Activo { get; set; }
        public string Clave { get; set; }
        public string ClaveExterna { get; set; }
        public string Email { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string SitioWeb { get; set; }
        public string EsCliente { get; set; }
        public string EsProveedor { get; set; }
        public string IdContactoPrincipal { get; set; }
        public string NombreContacto { get; set; }
    }
}
