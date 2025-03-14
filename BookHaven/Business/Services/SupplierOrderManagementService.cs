using BookHaven.Business.Interfaces;
using BookHaven.Data.Models;
using BookHaven.Data.Repositories.SupplierOrderManagementRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Business.Services
{
    public class SupplierOrderManagementService : ISupplierOrderManagementService
    {
        private readonly ISupplierOrderManagementRepository _supplierOrderRepository;

        public SupplierOrderManagementService()
        {
            _supplierOrderRepository = new SupplierOrderManagementRepository();
        }

        public List<Supplier> GetAllSuppliers()
        {
            return _supplierOrderRepository.GetAllSuppliers();
        }

        public List<Book> GetLowStockBooks()
        {
            return _supplierOrderRepository.GetLowStockBooks();
        }
        // Method to save the SupplierOrder
        // Method to save the SupplierOrder
        public void SaveSupplierOrder(SupplierOrder order)
        {
            // Call the repository method to save the order
            _supplierOrderRepository.SaveSupplierOrder(order);
        }

        public List<SupplierOrder> GetSupplierOrdersWithDetails()
        {
            return _supplierOrderRepository.GetSupplierOrdersWithDetails();
        }

        

        public void UpdateBookStock(int bookId, int quantity)
        {
            _supplierOrderRepository.UpdateBookStock(bookId, quantity);
        }
        public void UpdateOrderStatus(int orderID, string status)
        {
            _supplierOrderRepository.UpdateOrderStatus(orderID, status);
        }




    }
}
