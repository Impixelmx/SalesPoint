using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entities
{
    public class Categoria
    {
        public Guid IdTenant { get; set; }
        public Guid IdCategoria { get; set; }
        public int CategoriaNombre { get; set; }
        public int CategoriaAbreviatura { get; set; }
        public int CategoriaEstado { get; set; }
        public int CategoriaObservacion { get; set; }
    }
}
