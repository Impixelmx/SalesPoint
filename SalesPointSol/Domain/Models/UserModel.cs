using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcces.Contracts;
using DataAcces.Entities;
using DataAcces.Repositories;
using Domain.ValueObjects;

namespace Domain.Models
{
    public class UserModel:IDisposable
    {
        private int idUser;
        private string userName;
        private string email;
        private string password;
        private DateTime birthday;
        private int age;
        private string language; 

        private IUserRepository userRepository;
        public EntityState State { private get; set; }

        //Propiedades/Modelo de vista/Validacciones de datos

        public int IdUser { get => idUser; set => idUser = value; }
        [Required(ErrorMessage = "Username is required")]
        [StringLength(16, ErrorMessage = "Must be between 3 and 16 characters", MinimumLength = 10)]
        public string UserName { get => userName; set => userName = value; }

        [Required(ErrorMessage = "Email is required")]
        [StringLength(16, ErrorMessage = "Must be between 5 and 50 characters", MinimumLength = 5)]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Must be a valid email")]
        public string Email { get => email; set => email = value; }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get => password; set => password = value; }
        public string Language { get => language; set => language = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public int Age { get => age; private set => age = value; }

        public UserModel()
        {
            userRepository = new UserRespository();
        }

        public string SaveChanges()
        {
            string message = null;

            try
            {
                var userDataModel = new User();
                userDataModel.IdUser = idUser;
                userDataModel.UserName = userName;
                userDataModel.Email = email;
                userDataModel.Password = password;
                userDataModel.Birthday = birthday;
                userDataModel.Language = language;

                switch (State)
                {
                    case EntityState.Added:
                        //Ejecutar Las Reglas Comerciales, es decir algunas validaciones / Calculos etc
                        userRepository.Add(userDataModel);
                        message ="Data has been saved correctly";
                        break;

                    case EntityState.Modified:
                        userRepository.Edit(userDataModel);
                        message = "Data has been Modify correctly";
                        break;

                    case EntityState.Deleted:
                        userRepository.Remove(IdUser);
                        message = "Data has been Deleted correctly";
                        break;
                }
            }
            catch (Exception ex)
            {
                //Vamos a validar si esta duplicado el dato  para esto creamos una instancia sql pasamos la variante a la exep.
                System.Data.SqlClient.SqlException sqlEx = ex as System.Data.SqlClient.SqlException;

                //Si el error es diferente a nullo y menos que 2627 entonces decimos que el registro esta duplicado
                if (sqlEx != null && sqlEx.Number == 2627)
                    message = "Duplicate record";
                else
                    message = ex.ToString();
                
                throw;
            }
            return message;
        }

        public List<UserModel> GetAll()
        {
            var userDataModel = userRepository.GetAll();

            var lstUsers= new List<UserModel>();

            foreach (User item in userDataModel)
            {
                var birthDate = item.Birthday;
                lstUsers.Add(new UserModel
                {
                    IdUser = item.IdUser,
                    userName = item.UserName,
                    email = item.Email,
                    password = item.Password,
                    birthday = item.Birthday,
                    language =item.Language,
                    age= CalculateAge(birthDate)
                });
            }
            return lstUsers;
        }

        private int CalculateAge (DateTime date)
        {
            DateTime dateNow = DateTime.Now;
            return dateNow.Year - date.Year;
        }

        public void Dispose()
        {
            
        }
    }
}


 