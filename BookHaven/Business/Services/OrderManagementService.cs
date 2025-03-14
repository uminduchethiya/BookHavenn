using BookHaven.Business.Interfaces;
using BookHaven.Data.Models;
using BookHaven.Data.Repositories.OrderManagementRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Presentation.Comman;

namespace BookHaven.Business.Services
{
    class OrderManagementService : IOrderManagementService
    {
        private readonly IOrderManageRepositories _orderRepo;
        public OrderManagementService(IOrderManageRepositories orderRepo)
        {
            _orderRepo = orderRepo;
        }

        public List<Customer> GetCustomerByPhone(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return _orderRepo.GetCustomers(); // Return all customers

            return _orderRepo.GetCustomers()
                             .Where(c => c.PhoneNumber.Contains(phoneNumber)) // Allows partial search
                             .ToList();
        }


        public List<Book> GetBookByTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                return _orderRepo.GetBooks();
            return _orderRepo.GetBooks()
                             .Where(b => b.Title.Contains(title)) // Allows partial search
                             .ToList();
        }

        // Implement the SaveOrder method
        public void SaveOrder(Order order)
        {
            _orderRepo.SaveOrder(order); // Call SaveOrder from repository
        }



        public List<Order> GetAllOrders()
        {
            return _orderRepo.GetAllOrders(); // Fetch all orders from repository
        }

        public Order GetOrderById(int orderId)
        {
            return _orderRepo.GetOrderById(orderId); // Fetch order by ID
        }
        public bool UpdateOrderStatus(Order order)
        {
            // Assuming the repository has an update method for order status
            return _orderRepo.UpdateOrderStatus(order);  // Call the repository method to update the status
        }

        public bool UpdateBookStock(int bookId, int quantity)
        {
            return _orderRepo.UpdateBookStock(bookId, quantity);
        }
    }
}
