using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracker.Entity.Concrete
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public double SquareMeters { get; set; } 
        public decimal Price { get; set; } 
        public decimal UnitRentalPrice { get; set; } 
        public string Description { get; set; } 

        // İlişkiler
        public  ICollection<RentalItem> RentalItems { get; set; } = new List<RentalItem>();
        public  Stock Stock { get; set; } 
    }
}
