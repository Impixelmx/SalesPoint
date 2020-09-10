
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entities
{
    public class Persona
    {

        [MaxLength(50)]
        public Guid IdPersona { get; set; }

        public Guid IdTenant { get; set; }

        #region Identificación 

        #region Foto

        public string UbicacionArchivoPagoAzure { get; set; }
        public string UbicacionArchivoInstruccionesAzure { get; set; }
        public string NombreArchivoInstruccionesAzure { get; set; }

        #endregion

        #region Datos Personales

        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Apellido Paterno")]
        public string ApellidoPaterno { get; set; }

        [Display(Name = "Apellido Materno")]
        public string ApellidoMaterno { get; set; }

        [Display(Name = "CURP")]
        public string CURP { get; set; }

        [Display(Name = "NSS")]
        public string NSS { get; set; }

        [Display(Name = "RFC")]
        public string RFC { get; set; }

        [Display(Name = "Direccion")]
        public string Direccion { get; set; }

        [Display(Name = "Estado civil")]
        public string EstadoCivil { get; set; }

        [Display(Name = "Nacionalidad")]
        public string Nacionalidad { get; set; }

        [Display(Name = "Fecha de nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Display(Name = "Edad")]
        public int Edad { get; set; }

        public string Calle { get; set; }
        public string NumeroExterior { get; set; }
        public string NumeroInterior { get; set; }
        public string ReferenciasDireccion { get; set; }
        public string Colonia { get; set; }
        public string Localidad { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string CodigoPostal { get; set; }
        public string RazonSocial { get; set; } 


#endregion

#region Caracteristicas Personales

[Display(Name = "Sangre")]
        public string Sangre { get; set; }

        [Display(Name = "Huella Digital")]
        public string Huella { get; set; }

        [Display(Name = "Creencias ")]
        public string Creencias { get; set; }

        [Display(Name = "Señales Particulares")]
        public string SeñalesParticulares { get; set; }

        #endregion

        #endregion

    }
}
