using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DataAcces.Repositories
{
    /// <summary>
    //using System.Configuration;
    ///  como referencia 
    /// </summary>
    ///Esta clase no puede  ser instanciada pero si puede heredar

    public abstract class Repository
    {
        //agregamos una abtraccion a la conexion de base de datos
        private readonly string connectionString;
        public Repository() {
            connectionString = ConfigurationManager.ConnectionStrings["SalesPointContext"].ToString();
        }
        //Aqui Obtenemos la conexion este metodo es protegido ya que solo la usara esta clase y las clases aderidas a esta 
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
