using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Business.Interfaces;
using BookHaven.Data.Models;
using BookHaven.Data.Repositories.BookManagementRepository;
using BookHaven.Data.Repositories.ReportManagementRepository;

namespace BookHaven.Business.Services
{
    public class ReportManagementService : IReportManagementService
    {
        private readonly IreportManagementRepository _reportRepository;

        public ReportManagementService(IreportManagementRepository reportRepository)
        {
            _reportRepository = reportRepository;
        }

        public async Task<List<SalesSummery>> GetSalesSummary(DateTime startDate, DateTime endDate)
        {
            return await _reportRepository.FetchSalesSummary(startDate, endDate);
        }

        public async Task<List<Book>> GetBestSellingBooks()
        {
            return await _reportRepository.FetchBestSellingBooks();
        }

        public async Task<List<InventoryStatus>> GetInventoryStatus()
        {
            return await _reportRepository.FetchInventoryStatus();
        }

        public async Task<List<SalesSummery>> GetSalesSummaryByCurrentDate()
        {
            return await _reportRepository.GetSalesSummaryByCurrentDate();
        }
    }
}
