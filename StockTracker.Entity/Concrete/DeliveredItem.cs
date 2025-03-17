using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracker.Entity.Concrete
{
    public class DeliveredItem
    {
        public int Id { get; set; }
        public int RentalItemId { get; set; }
        public  RentalItem RentalItem { get; set; }
        public int Quantity { get; set; } 
        public DateTime DeliveredDate { get; set; }
        public int RentalId { get; set; }
    }
}
