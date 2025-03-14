using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Data.Models
{
    public class SalesTransactionDetails
    {
        public int SalesTransactionDetailId { get; set; }
        public int CustomerTransactionId { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public string BookTitle { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Subtotal { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
