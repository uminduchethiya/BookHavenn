using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.Models;
using Microsoft.Data.SqlClient;

namespace BookHaven.Data.Repositories.ReportManagementRepository
{
    public class ReportManagementRepository : IreportManagementRepository
    {
        private readonly string _connectionString;

        public ReportManagementRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["BookHavenDB"]?.ConnectionString ?? throw new InvalidOperationException("Connection string 'BookHavenDB' not found.");
        }

        public async Task<List<SalesSummery>> FetchSalesSummary(DateTime startDate, DateTime endDate)
        {
            var salesSummary = new List<SalesSummery>();

            string query = @"
                SELECT
                    ct.CustomerTransactionId,
                    ct.CustomerId,
                    c.FirstName + ' ' + c.LastName AS CustomerName,
                    SUM(s.Quantity * s.Price) AS TotalAmount,
                    ct.DiscountAmount,
                    ct.FinalAmount,
                    ct.Date AS TransactionDate
                FROM
                    CustomerTransactions ct
                INNER JOIN
                    SalesTransactionDetails s ON ct.CustomerTransactionId = s.CustomerTransactionId
                INNER JOIN
                    Book b ON s.BookId = b.BookId
                INNER JOIN
                    Customer c ON ct.CustomerId = c.CustomerId
                WHERE
                    ct.Date BETWEEN @StartDate AND @EndDate
                GROUP BY
                    ct.CustomerTransactionId, ct.CustomerId, c.FirstName, c.LastName, ct.DiscountAmount, ct.FinalAmount, ct.Date
                ORDER BY
                    ct.Date DESC";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);

                conn.Open();
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        salesSummary.Add(new SalesSummery
                        {
                            CustomerTransactionId = reader.GetInt32(reader.GetOrdinal("CustomerTransactionId")),
                            CustomerId = reader.GetInt32(reader.GetOrdinal("CustomerId")),
                            CustomerName = reader.GetString(reader.GetOrdinal("CustomerName")),
                            TotalAmount = reader.GetDecimal(reader.GetOrdinal("TotalAmount")),
                            DiscountAmount = reader.GetDecimal(reader.GetOrdinal("DiscountAmount")),
                            FinalAmount = reader.GetDecimal(reader.GetOrdinal("FinalAmount")),
                            TransactionDate = reader.GetDateTime(reader.GetOrdinal("TransactionDate"))
                        });
                    }
                }
            }

            return salesSummary;
        }

        // Fetch Best Selling Books without any date range
        public async Task<List<Book>> FetchBestSellingBooks()
        {
            var bestSellingBooks = new List<Book>();

            string query = @"
                SELECT 
                    b.BookId, 
                    b.Title, 
                    SUM(s.Quantity) AS TotalQuantitySold
                FROM 
                    SalesTransactionDetails s
                INNER JOIN 
                    Book b ON s.BookId = b.BookId
                GROUP BY 
                    b.BookId, b.Title
                ORDER BY 
                    TotalQuantitySold DESC";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        bestSellingBooks.Add(new Book
                        {
                            BookId = reader.GetInt32(reader.GetOrdinal("BookId")),
                            Title = reader.GetString(reader.GetOrdinal("Title"))
                        });
                    }
                }
            }

            return bestSellingBooks;
        }

        // Fetch Inventory Status (Current stock of all books)
        public async Task<List<InventoryStatus>> FetchInventoryStatus()
        {
            var inventoryStatus = new List<InventoryStatus>();

            string query = "SELECT Title, StockQuantity FROM Book WHERE IsDeleted = 0";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        inventoryStatus.Add(new InventoryStatus
                        {
                            BookTitle = reader.GetString(reader.GetOrdinal("Title")),
                            StockQuantity = reader.GetInt32(reader.GetOrdinal("StockQuantity"))
                        });
                    }
                }
            }

            return inventoryStatus;
        }

        public Task<List<SalesSummery>> GetSalesSummaryByCurrentDate()
        {
            var salesSummary = new List<SalesSummery>();

            string query = @"
                SELECT
                    ct.CustomerTransactionId,
                    ct.CustomerId,
                    c.FirstName + ' ' + c.LastName AS CustomerName,
                    SUM(s.Quantity * s.Price) AS TotalAmount,
                    ct.DiscountAmount,
                    ct.FinalAmount,
                    ct.Date AS TransactionDate
                FROM
                    CustomerTransactions ct
                INNER JOIN
                    SalesTransactionDetails s ON ct.CustomerTransactionId = s.CustomerTransactionId
                INNER JOIN
                    Book b ON s.BookId = b.BookId
                INNER JOIN
                    Customer c ON ct.CustomerId = c.CustomerId
                WHERE
                    ct.Date = @CurrentDate
                GROUP BY
                    ct.CustomerTransactionId, ct.CustomerId, c.FirstName, c.LastName, ct.DiscountAmount, ct.FinalAmount, ct.Date
                ORDER BY
                    ct.Date DESC";

            using (var conn = new SqlConnection(_connectionString))
                using (var cmd = new SqlCommand( query, conn))
            {
                cmd.Parameters.AddWithValue("@CurrentDate", DateTime.Now.Date);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        salesSummary.Add(new SalesSummery
                        {
                            CustomerTransactionId = reader.GetInt32(reader.GetOrdinal("CustomerTransactionId")),
                            CustomerId = reader.GetInt32(reader.GetOrdinal("CustomerId")),
                            CustomerName = reader.GetString(reader.GetOrdinal("CustomerName")),
                            TotalAmount = reader.GetDecimal(reader.GetOrdinal("TotalAmount")),
                            DiscountAmount = reader.GetDecimal(reader.GetOrdinal("DiscountAmount")),
                            FinalAmount = reader.GetDecimal(reader.GetOrdinal("FinalAmount")),
                            TransactionDate = reader.GetDateTime(reader.GetOrdinal("TransactionDate"))
                        });
                    }
                }
            }
            return Task.FromResult(salesSummary);
        }
    }
}
