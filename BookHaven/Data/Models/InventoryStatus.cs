using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Data.Models
{
    public class InventoryStatus
    {
        public string? BookTitle { get; set; }
        public int StockQuantity { get; set; }
    }
}
