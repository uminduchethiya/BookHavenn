using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Business.Interfaces;
using BookHaven.Data.Models;
using BookHaven.Data.Repositories.BookManagementRepository;
using BookHaven.Data.Repositories.CustomerManagementRepository;

namespace BookHaven.Business.Services
{
    public  class CustomerManagementService : ICustomerManagementService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerManagementService(ICustomerRepository customerRepository)
        {
            _customerRepository =customerRepository;
        }

        public Customer AddCustomer(Customer customer)
        {

            return _customerRepository.AddCustomer(customer);
        }
        public List<Customer> GetAllCustomers(string searchterm)
        {
            return _customerRepository.GetAllCustomers(searchterm);
        }
        public bool EditCustomer(Customer customer)
        {
            return _customerRepository.EditCustomer(customer);
        }
        public bool DeleteCustomer(int customerId)
        {
            return _customerRepository.DeleteCustomer(customerId);
        }
       
    }
}
