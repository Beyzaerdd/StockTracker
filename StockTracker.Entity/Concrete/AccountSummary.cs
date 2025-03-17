using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracker.Entity.Concrete
{
    public  class AccountSummary
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal TotalIncome { get; set; } // Toplam gelir
        public decimal TotalExpense { get; set; } // Toplam gider
        public decimal NetProfit => TotalIncome - TotalExpense; // Net kazanç
    }
}
