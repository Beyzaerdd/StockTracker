using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracker.Shared.DTOs.StockDTOs
{
    public class WarehouseAccountDTO
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal IncomingAmount { get; set; }
        public decimal OutgoingAmount { get; set; }
        public decimal NetAmount => IncomingAmount - OutgoingAmount;
    }

}
