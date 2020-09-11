using DataAcces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Contracts
{
    public interface IArticuloRepository : IGenericRepository<Articulo>
    {
        //Other Methods
        //IEnumerable<Articulo> GetByPrecio();
    }
}
