using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.Models;

namespace BookHaven.Data.Repositories.ReportManagementRepository
{
    public interface IreportManagementRepository
    {
        Task<List<SalesSummery>> FetchSalesSummary(DateTime startDate, DateTime endDate);
        Task<List<Book>> FetchBestSellingBooks();
        Task<List<InventoryStatus>> FetchInventoryStatus();

        Task<List<SalesSummery>> GetSalesSummaryByCurrentDate();
    }
}
