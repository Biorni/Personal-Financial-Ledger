using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fedha.Models
{
    public class WishlistTransaction
    {
        public int Id { get; set; }
        public string TransactionCode { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        [BsonRef("accounts")]
        public Account Account { get; set; }
       
        public double Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
