using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracker.Entity.Concrete
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; } 
        public string Phone { get; set; }
        public string Email { get; set; } 
        public string Position { get; set; } 
        public decimal Salary { get; set; } 
        public DateTime HireDate { get; set; } 
        public bool IsActive { get; set; } = true; 

    
        public  ICollection<Rental> Rentals { get; set; } = new List<Rental>(); 
        public  ICollection<Payment> Payments { get; set; } = new List<Payment>(); 
    }
}
