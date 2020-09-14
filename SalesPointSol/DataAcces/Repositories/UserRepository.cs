using DataAcces.Contracts;
using DataAcces.Entities;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Repositories
{
    public class UserRepository
    {
        public class UserRespository : MasterRepository, IUserRepository
        {
            //Campos
            private string selectAll;
            private string insert;
            private string update;
            private string delete;

            //Propiedades Pero en este caso no existen ya que no son necesarias


            //Constructores
            public UserRespository()
            {
                selectAll = "SELECT *FROM User";
                insert = "INSERT INTO Users VALUES (@UserName, @Password, @Email)";
                update = "UPDATE User SET userName = @ UserName, password = @Password, email = @Email where userID = @IdUser ";
                delete = "DELETE FROM User WHERE IdPK = @IdUser";
            }

            //Metodos y Comportamientos
            public int Add(User entity)
            {
                parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("@UserName", entity.UserName));
                parameters.Add(new SqlParameter("@Password", entity.Password));
                parameters.Add(new SqlParameter("@Email", entity.Email));

                return ExecuteNonQuery(insert);


            }

            public int Edit(User entity)
            {
                parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("@IdUser", entity.IdUser));
                parameters.Add(new SqlParameter("@UserName", entity.UserName));
                parameters.Add(new SqlParameter("@Password", entity.Password));
                parameters.Add(new SqlParameter("@Email", entity.Email));

                return ExecuteNonQuery(update);

            }

            public IEnumerable<User> GetAll()
            {
                var tableResult = ExecuteReader(selectAll);
                var listUser = new List<User>();
                foreach (DataRow item in tableResult.Rows)
                {
                    listUser.Add(new User
                    {
                        IdUser = Convert.ToInt32(item[0]),
                        UserName = item[1].ToString(),
                        Password = item[2].ToString(),
                        Email = item[3].ToString(),
                    });
                }
                return listUser;
            }

            public int Remove(int IdUser)
            {
                parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("@IdUser", IdUser));

                return ExecuteNonQuery(delete);
            }
 
        }
    }
}
