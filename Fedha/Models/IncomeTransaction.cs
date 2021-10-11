using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fedha.Models
{
   public class IncomeTransaction
    {
        public int Id { get; set; }
        public string TransactionCode { get; set; }
        public string PaymentFrom { get; set; }
        public string Description { get; set; }
        [BsonRef("accounts")]
        public Account Account { get; set; }

        [BsonRef("income_categories")]
        public IncomeCategory Category { get; set; }
        public double Amount { get; set; } 

        public DateTime Date { get; set; }

    }
}
