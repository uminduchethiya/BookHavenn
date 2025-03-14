using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Data.Models
{
    public class SupplierOrder
    {
        public int SupplierOrderID { get; set; } // Primary Key, Auto Increment
        public int SupplierID { get; set; } // Foreign Key to Supplier table
        public int BookID { get; set; } // Foreign Key to Book table
        public int Quantity { get; set; } // Quantity of the order
        public DateTime OrderDate { get; set; } // Order Date
        public string Status { get; set; } // Order Status (e.g., Pending, Completed)
        public Supplier Supplier { get; set; } // Reference to Supplier entity
        public Book Book { get; set; } // Reference to Book entity
    }
}
