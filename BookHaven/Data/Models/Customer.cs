using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Data.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }        
        public string? FirstName { get; set; }        
        public string? LastName { get; set; }        
        public string? Email { get; set; }          
        public string? PhoneNumber { get; set; }     
        public DateTime? DateOfBirth { get; set; }   
        public string? Gender { get; set; }           
        public string? Address { get; set; }        
        public string? City { get; set; }                 
        public string ZipCode { get; set; }           
        public DateTime CreatedAt { get; set; }      
        public DateTime? UpdatedAt { get; set; }    
        public bool IsDeleted { get; set; }      
    }
}
