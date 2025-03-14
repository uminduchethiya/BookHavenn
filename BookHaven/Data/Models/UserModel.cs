using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Data.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string RegistrationNumber { get; set; }  
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; } 
        public string Phone { get; set; }
        public int RoleID { get; set; }
        public string Idnumber { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }  
        public bool IsDeleted { get; set; }  
        public DateTime CreatedAt { get; set; }
    }

}
