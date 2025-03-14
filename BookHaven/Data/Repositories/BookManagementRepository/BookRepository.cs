using System;
using System.Configuration;
using BookHaven.Data.Models;
using Microsoft.Data.SqlClient;

namespace BookHaven.Data.Repositories.BookManagementRepository
{
    public class BookRepository : IBookRepository
    {
        private readonly string _connectionString;

        public BookRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["BookHavenDB"]?.ConnectionString;

            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new Exception("Connection string 'BookHavenDB' not found in App.config.");
            }
        }

        public Book AddBook(Book book)
        {
            Book addedBook = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = @"
                        INSERT INTO Book (Title, Author, ISBN, Price, StockQuantity, Genere,IsDeleted ,CreatedAt, UpdatedAt) 
                        VALUES (@Title, @Author, @ISBN, @Price, @Stock, @Category,@IsDeleted, @CreatedAt, @UpdatedAt);
                        SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", book.Title);
                        cmd.Parameters.AddWithValue("@Author", book.Author);
                        cmd.Parameters.AddWithValue("@ISBN", book.ISBN);
                        cmd.Parameters.AddWithValue("@Price", book.Price);
                        cmd.Parameters.AddWithValue("@Stock", book.StockQuantity);
                        cmd.Parameters.AddWithValue("@Category", book.Genre);
                        cmd.Parameters.AddWithValue("@IsDeleted", false);
                        cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                        cmd.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);

                        conn.Open();
                        var result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            addedBook = book;
                            addedBook.BookId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                throw new Exception("An error occurred while adding the book to the database.", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
                throw new Exception("An unexpected error occurred while adding the book.", ex);
            }

            return addedBook;
        }
        public List<Book> GetAllBooks(string searchparm)
        {
            List<Book> books = new List<Book>();
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = @"
                    SELECT * FROM Book WHERE IsDeleted = 0 AND (Title LIKE @SearchTerm OR Author LIKE @SearchTerm OR ISBN LIKE @SearchTerm);";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Set the value of the @SearchTerm parameter
                        cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchparm + "%");

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Book book = new Book
                                {
                                    BookId = reader.GetInt32(reader.GetOrdinal("BookId")),
                                    Title = reader.GetString(reader.GetOrdinal("Title")),
                                    Author = reader.GetString(reader.GetOrdinal("Author")),
                                    ISBN = reader.GetString(reader.GetOrdinal("ISBN")),
                                    Price = reader.GetDecimal(reader.GetOrdinal("Price")),
                                    StockQuantity = reader.GetInt32(reader.GetOrdinal("StockQuantity")),
                                    Genre = reader.GetString(reader.GetOrdinal("Genere"))  // Fixed typo from "Genere" to "Genre"
                                };
                                books.Add(book);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                throw new Exception("An error occurred while fetching the books from the database.", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
                throw new Exception("An unexpected error occurred while fetching the books.", ex);
            }
            return books;
        }
        public bool EditBook(Book book)
        {
            bool isEdited = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = @"
                        UPDATE Book 
                        SET Title = @Title, Author = @Author, ISBN = @ISBN, Price = @Price, StockQuantity = @Stock, Genere = @Category, UpdatedAt = @UpdatedAt
                        WHERE BookId = @BookId;";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", book.Title);
                        cmd.Parameters.AddWithValue("@Author", book.Author);
                        cmd.Parameters.AddWithValue("@ISBN", book.ISBN);
                        cmd.Parameters.AddWithValue("@Price", book.Price);
                        cmd.Parameters.AddWithValue("@Stock", book.StockQuantity);
                        cmd.Parameters.AddWithValue("@Category", book.Genre);
                        cmd.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);
                        cmd.Parameters.AddWithValue("@BookId", book.BookId);
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        isEdited = rowsAffected > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                throw new Exception("An error occurred while updating the book in the database.", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
                throw new Exception("An unexpected error occurred while updating the book.", ex);
            }
            return isEdited;
        }
        public bool DeleteBook(int bookId)
        {
            bool isDeleted = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = @"
                        UPDATE Book 
                        SET IsDeleted = 1, UpdatedAt = @UpdatedAt
                        WHERE BookId = @BookId;";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);
                        cmd.Parameters.AddWithValue("@BookId", bookId);
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        isDeleted = rowsAffected > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                throw new Exception("An error occurred while deleting the book from the database.", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
                throw new Exception("An unexpected error occurred while deleting the book.", ex);
            }
            return isDeleted;
        }

        public bool UpdateStock(int bookId, int quantity)
        {
            bool isUpdated = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = @"
                        UPDATE Book 
                        SET StockQuantity = @Stock, UpdatedAt = @UpdatedAt
                        WHERE BookId = @BookId;";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Stock", quantity);
                        cmd.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);
                        cmd.Parameters.AddWithValue("@BookId", bookId);
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        isUpdated = rowsAffected > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                throw new Exception("An error occurred while updating the stock quantity in the database.", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
                throw new Exception("An unexpected error occurred while updating the stock quantity.", ex);
            }
            return isUpdated;
        }
    }
}
