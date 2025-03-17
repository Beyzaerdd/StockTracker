using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracker.Entity.Concrete
{
    public  class Rental
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; } 
        public decimal MonthlyPrice { get; set; }
        public decimal DailyPrice => MonthlyPrice / 30;
        public decimal TotalPrice => (EndDate.HasValue ? (decimal)(EndDate.Value - StartDate).TotalDays : 30) * DailyPrice;
        public bool IsCompleted { get; set; } = false;
        public bool IsOverdue => EndDate.HasValue && EndDate.Value < DateTime.Now;

        public ICollection<RentalItem> RentalItems { get; set; } = new List<RentalItem>();


  
    }
}
