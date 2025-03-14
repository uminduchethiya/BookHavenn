using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.Models;
using Microsoft.Data.SqlClient;

namespace BookHaven.Data.Repositories.SalesTransactionRepository
{
    public class SalesTransactionRepository : ISalesTransactionRepository
    {
        private readonly string _connectionString;

        public SalesTransactionRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["BookHavenDB"]?.ConnectionString ?? throw new InvalidOperationException("Connection string 'BookHavenDB' not found.");
        }

        public void InsertTransactionDetail(SalesTransactionDetails transactionDetail)
        {
            try
            {
                Console.WriteLine(transactionDetail.CustomerTransactionId);
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = @"
                INSERT INTO SalesTransactionDetails (CustomerTransactionId, BookId, BookTitle, Quantity, Price, Subtotal)
                VALUES (@CustomerTransactionId, @BookId, @BookTitle, @Quantity, @Price, @Subtotal)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerTransactionId", transactionDetail.CustomerTransactionId);
                        cmd.Parameters.AddWithValue("@BookId", transactionDetail.BookId);
                        cmd.Parameters.AddWithValue("@BookTitle", transactionDetail.BookTitle);
                        cmd.Parameters.AddWithValue("@Quantity", transactionDetail.Quantity);
                        cmd.Parameters.AddWithValue("@Price", transactionDetail.Price);
                        cmd.Parameters.AddWithValue("@Subtotal", transactionDetail.Subtotal);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inserting transaction details: {ex.Message}");
                throw;
            }
        }

        public int InsertTransactionRecord(CustomerTransactions transaction)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = @"INSERT INTO CustomerTransactions (CustomerId, TotalAmount, DiscountAmount, FinalAmount, Date)
                                     VALUES (@CustomerId, @TotalAmount, @DiscountAmount, @FinalAmount, @Date);
                                     SELECT SCOPE_IDENTITY();";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerId", transaction.CustomerId);
                        cmd.Parameters.AddWithValue("@TotalAmount", transaction.TotalAmount);
                        cmd.Parameters.AddWithValue("@DiscountAmount", transaction.DiscountAmount);
                        cmd.Parameters.AddWithValue("@FinalAmount", transaction.FinalAmount);
                        cmd.Parameters.AddWithValue("@Date", transaction.Date);

                        conn.Open();
                        var result = cmd.ExecuteScalar();
                        return Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inserting transaction record: {ex.Message}");
                throw;
            }
        }
    }
}
