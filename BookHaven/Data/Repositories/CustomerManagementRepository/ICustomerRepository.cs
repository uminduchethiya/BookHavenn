using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.Models;

namespace BookHaven.Data.Repositories.CustomerManagementRepository
{
    public interface ICustomerRepository
    {
        Customer AddCustomer(Customer customer);
        bool DeleteCustomer(int customerId);
        bool EditCustomer(Customer customer);
        List<Customer> GetAllCustomers(string searchparam);
    }
}
