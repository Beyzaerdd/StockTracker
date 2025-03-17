using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracker.Entity.Concrete
{
    public class Payment
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public  Customer Customer { get; set; }

        public int? AccountTransactionId { get; set; } 
        public  AccountTransaction AccountTransaction { get; set; }

        public decimal Amount { get; set; } 
        public DateTime PaymentDate { get; set; } 
        public int EmployeeId { get; set; } 
        public  Employee Employee { get; set; }
    }
}
