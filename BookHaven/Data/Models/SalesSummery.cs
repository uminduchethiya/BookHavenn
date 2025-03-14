using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Data.Models
{
    public class SalesSummery
    {
        public int CustomerTransactionId { get; set; }    // Unique ID for the transaction
        public int CustomerId { get; set; }                // Customer's ID who made the transaction
        public string? CustomerName { get; set; }           // Customer's full name
        public decimal TotalAmount { get; set; }           // Total amount of the transaction (before discount)
        public decimal DiscountAmount { get; set; }        // Discount amount applied to the transaction
        public decimal FinalAmount { get; set; }           // Final amount after discount
        public DateTime TransactionDate { get; set; }      // Date when the transaction was made
    }
}
