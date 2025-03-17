using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracker.Entity.Concrete
{
    public class RemainingItem
    {
        public int Id { get; set; }
        public int RentalId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal DailyPrice { get; set; }
        public int OverdueDays => (DateTime.Now - Rental.StartDate).Days > 30 ? (DateTime.Now - Rental.StartDate).Days - 30 : 0;
        public decimal OverdueTotal => OverdueDays * DailyPrice * Quantity;
        public Rental Rental { get; set; }
    }
}
