using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracker.Entity.Concrete
{
    public  class WarehouseAccount //Depo harcamaları
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public List<IncomingTransaction> IncomingTransactions { get; set; } = new List<IncomingTransaction>();

        // Giden tutarlar
        public List<OutgoingTransaction> OutgoingTransactions { get; set; } = new List<OutgoingTransaction>();

        // Net kazanç hesabı
        public decimal NetProfit => IncomingTransactions.Sum(i => i.Amount) - OutgoingTransactions.Sum(o => o.Amount);
    
    }
}
