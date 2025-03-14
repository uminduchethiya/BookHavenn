using BookHaven.Data.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Data.Repositories.SupplierOrderManagementRepository
{
    public class SupplierOrderManagementRepository : ISupplierOrderManagementRepository
    {
        private readonly string _connectionString;

        public SupplierOrderManagementRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["BookHavenDB"]?.ConnectionString;

            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new Exception("Connection string 'BookHavenDB' not found in App.config.");
            }
        }


        public List<Supplier> GetAllSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT SupplierID, SupplierName FROM Supplier";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            suppliers.Add(new Supplier
                            {
                                SupplierID = reader.GetInt32(0),
                                SupplierName = reader.GetString(1)
                            });
                        }
                    }
                }
            }
            return suppliers;
        }


        public List<Book> GetLowStockBooks()
        {
            List<Book> books = new List<Book>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT BookId, Title, Author, StockQuantity, Price FROM Book WHERE StockQuantity < 20 AND IsDeleted = 0";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    books.Add(new Book
                    {
                        BookId = reader.GetInt32(0),
                        Title = reader.GetString(1),
                        Author = reader.GetString(2),
                        StockQuantity = reader.GetInt32(3),
                        Price = reader.GetDecimal(4)
                    });
                }
            }

            return books;
        }
        // Method to save a new SupplierOrder into the database
        public void SaveSupplierOrder(SupplierOrder order)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    // SQL query to insert SupplierOrder
                    string query = "INSERT INTO SupplierOrder (SupplierID, BookID, Quantity, OrderDate, Status) " +
                                   "VALUES (@SupplierID, @BookID, @Quantity, @OrderDate, @Status)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Adding parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@SupplierID", order.SupplierID);
                    cmd.Parameters.AddWithValue("@BookID", order.BookID);
                    cmd.Parameters.AddWithValue("@Quantity", order.Quantity);
                    cmd.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                    cmd.Parameters.AddWithValue("@Status", order.Status);

                    // Open connection and execute the query
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Log the error (optional)
                throw new Exception("Error saving SupplierOrder: " + ex.Message);
            }
        }

        public List<SupplierOrder> GetSupplierOrdersWithDetails()
        {
            List<SupplierOrder> orders = new List<SupplierOrder>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"SELECT so.SupplierOrderID, so.SupplierID, s.SupplierName, 
                                so.BookID, b.Title AS BookName, so.Quantity, 
                                so.OrderDate, so.Status
                         FROM SupplierOrder so
                         INNER JOIN Supplier s ON so.SupplierID = s.SupplierID
                         INNER JOIN Book b ON so.BookID = b.BookId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            orders.Add(new SupplierOrder
                            {
                                SupplierOrderID = reader.GetInt32(0),
                                SupplierID = reader.GetInt32(1),
                                Supplier = new Supplier { SupplierName = reader.GetString(2) },
                                BookID = reader.GetInt32(3),
                                Book = new Book { Title = reader.GetString(4) },
                                Quantity = reader.GetInt32(5),
                                OrderDate = reader.GetDateTime(6),
                                Status = reader.GetString(7)
                            });
                        }
                    }
                }
            }

            return orders;
        }
        public void UpdateBookStock(int bookID, int addedQuantity)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = @"
        UPDATE Book 
        SET StockQuantity = StockQuantity + @AddedQuantity 
        WHERE BookId = @BookID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AddedQuantity", addedQuantity);
                    cmd.Parameters.AddWithValue("@BookID", bookID);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public void UpdateOrderStatus(int orderID, string status)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "UPDATE SupplierOrder SET Status = @Status WHERE SupplierOrderID = @OrderID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@OrderID", orderID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public string GetSupplierEmail(int orderID)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"SELECT s.Email FROM SupplierOrder so
                         INNER JOIN Supplier s ON so.SupplierID = s.SupplierID
                         WHERE so.SupplierOrderID = @OrderID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderID", orderID);

                conn.Open();
                return cmd.ExecuteScalar()?.ToString();
            }
        }


    }
}
