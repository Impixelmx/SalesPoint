using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entities
{
    public class Profesion
    {
        public Guid IdTenant { get; set; }
        public Guid IdPersona { get; set; }
        public Guid IdEmpleado { get; set; }
        public Guid IdProfesion { get; set; }
        public string ProfesionNombre { get; set; }
        public string ProfesionAbreviatura { get; set; }
        public string ProfesionEstado { get; set; }
        public string ProfesionObservacion { get; set; }

    }
}
