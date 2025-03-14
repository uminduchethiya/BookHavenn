using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.Models;

namespace BookHaven.Business.Interfaces
{
    public interface ISalesTransactionService 
    {
        string GenerateBill(List<DataGridViewRow> salesData, decimal discount, Customer customer);
        void SendBillEmail(string customerEmail, string billFilePath);
        void ReduceStock(List<DataGridViewRow> salesData);
        void InsertTransactionRecord(Customer customer, List<DataGridViewRow> salesData, decimal totalAmount, decimal discount);
    }
}
