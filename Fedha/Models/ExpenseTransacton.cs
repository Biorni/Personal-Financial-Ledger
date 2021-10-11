using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fedha.Models
{
   public class ExpenseTransacton
    {
        public int Id { get; set; }
        public string TransactionCode { get; set; }
        public string PaymentTo { get; set; }
        public string Description { get; set; }

        [BsonRef("accounts")]
        public Account Account { get; set; }

        [BsonRef("expense_categories")]
        public ExpenseCategory Category { get; set; }
        public double Amount { get; set; }
        public double TransactonCost{ get; set; }

        public DateTime Date { get; set; }

        public double GetAmount()
        {
            return this.Amount + this.TransactonCost;
        }
    }
}
