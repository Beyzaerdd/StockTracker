using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracker.Entity.Concrete
{
    public class Stock
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public void DeductStock(int amount)
        {
            Quantity -= amount;
        }

        public void Restock(int amount)
        {
            Quantity += amount;
        }
    }
}
