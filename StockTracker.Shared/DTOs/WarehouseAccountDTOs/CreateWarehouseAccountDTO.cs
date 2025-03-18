using StockTracker.Shared.DTOs.WarehouseAccountDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracker.Shared.DTOs.StockDTOs
{
    public class CreateWarehouseAccountDTO
    {
        public DateTime TransactionDate { get; set; }
        public List<CreateIncomingTransactionDTO> IncomingTransactions { get; set; }
        public List<CreateOutgoingTransactionDTO> OutgoingTransactions { get; set; }
    }
}
