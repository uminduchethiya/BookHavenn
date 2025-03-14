using BookHaven.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Data.Repositories.SupplierOrderManagementRepository
{
    public interface ISupplierOrderManagementRepository
    {
        List<Supplier> GetAllSuppliers();
        List<Book> GetLowStockBooks();
        void SaveSupplierOrder(SupplierOrder order); // Method for saving SupplierOrder
                                                     // Add this method to retrieve supplier orders with details
        List<SupplierOrder> GetSupplierOrdersWithDetails();
        // Add this method
        void UpdateBookStock(int bookId, int quantity);

        void UpdateOrderStatus(int orderID, string status);
    }
}
