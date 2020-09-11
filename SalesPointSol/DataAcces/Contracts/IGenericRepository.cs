using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Contracts
{
    /// <summary>
    /// En este Repositorio agregamos las funcionalidades basicas 
    /// Para un Crud, es lo hicimos de manera generiva para que 
    /// podamos reutilizar el codigo y refactorizar 
    /// </summary>
    /// <typeparam name="Entity"></typeparam>
    public interface IGenericRepository<Entity> where Entity : class
    {
        int Add(Entity entity);
        int Edit(Entity entity);
        int Remove(Guid ID);
        IEnumerable<Entity> GetAll();
    }
}
