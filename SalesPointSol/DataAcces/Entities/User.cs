using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entities
{
    public class User
    {
        [MaxLength(50)] 
        public Guid IdUser { get; set; }

        public Guid IdTenant { get; set; }

        [Required(ErrorMessage = "User Name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "E-Mail")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [StringLength(256)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password")]
        public string ConfirmPassword { get; set; }     
        public bool AccessFailedCount { get; set; }
        public string  ConcurrencyStamp { get; set; }      
        public bool EmailConfirmed { get; set; }
        public bool LockoutEnabled { get; set; }
        public bool LockoutEnd { get; set; }
        public string NormalizedEmail { get; set; }
        public string NormalizedUserName { get; set; }
        public string PasswordHash { get; set; }

        
      

       
    }
}
