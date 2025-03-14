using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.Models;

namespace BookHaven.Data.Repositories.SalesTransactionRepository
{
    public interface ISalesTransactionRepository
    {
        int InsertTransactionRecord(CustomerTransactions transaction);

        void InsertTransactionDetail(SalesTransactionDetails transactionDetail);
    }
}
