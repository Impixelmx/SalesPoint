using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entities
{
    public class Audit
    {
        public Audit()
        {
            FechaCreacion = DateTimeHelper.GetDateTimeMexicoCity();
            FechaModificacion = FechaCreacion;
        }

        public bool Estatus { get; set; }
        [StringLength(256)]
        public string UsuarioCreacion { get; set; }
        [StringLength(256)]
        public string UsuarioModificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string AdicionalesJson { get; set; }
        [NotMapped]
        public string StatusMessage { get; set; }
    }
}
