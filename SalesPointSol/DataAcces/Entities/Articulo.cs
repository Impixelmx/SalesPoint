using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entities
{
    public class Articulo
    {
        public Guid IdArticulo { get; set; }
        public Guid IdTenant { get; set; }
        public Guid IdGrupoArticulos { get; set; }
        public string Foto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double PrecioCoste { get; set; }
        public string PrecioVenta { get; set; }             
        public int UnidadesVenta { get; set; }         
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Categoria { get; set; }
        public string UnidadMedida { get; set; }
        public string Activo { get; set; }  
        public string Clave { get; set; }
        public bool EsVendible { get; set; }
        public bool EsComprable { get; set; }
        public bool EsInventariable { get; set; }
        public string Ubicacion { get; set; }
        public string TiempodeVida { get; set; }


    }
}
