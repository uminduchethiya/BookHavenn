using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.Models;

namespace BookHaven.Business.Interfaces
{
    public interface IReportManagementService
    {
        Task<List<SalesSummery>> GetSalesSummary(DateTime startDate, DateTime endDate);
        Task<List<Book>> GetBestSellingBooks();
        Task<List<InventoryStatus>> GetInventoryStatus();

        Task<List<SalesSummery>> GetSalesSummaryByCurrentDate();
    }
}
