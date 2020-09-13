using DataAcces.Contracts;
using DataAcces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Repository
{
    public class UserRespository : MasterRepository, IUserRepository
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;


    //    UserID INT NOT NULL IDENTITY(1,1),
    //UserName nvarchar(128) not null,
    //Password nvarchar(128) not null,
    //Email nvarchar(128)


        public UserRespository()
        {
            selectAll = "SELECT *FROM User";
            insert = "INSERT INTO Users (UserName, Password, Email) VALUES ('Good', 'Salespointdev123...', 'good@salespoint.com.mx'), ('Admin', 'Salespointdev123...', 'admin@salespoint.com.mx'), ('Vendor', 'Salespointdev123...', 'vendor@salespoint.com.mx');";
        }

        public int Add(User entity)
        {
            
        }

        public int Edit(User entity)
        {
             
        }

        public IEnumerable<User> GetAll()
        {
            
        }

        public int Remove(Guid ID)
        {
             
        }
    }
}
