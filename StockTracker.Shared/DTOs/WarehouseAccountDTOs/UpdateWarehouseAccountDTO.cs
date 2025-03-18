using StockTracker.Shared.DTOs.WarehouseAccountDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracker.Shared.DTOs.StockDTOs
{
    public class UpdateWarehouseAccountDTO
    {
        public int Id { get; set; }
        public List<UpdateIncomingTransactionDTO> IncomingTransactions { get; set; }
        public List<UpdateOutgoingTransactionDTO> OutgoingTransactions { get; set; }
    }
}
