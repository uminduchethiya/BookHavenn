using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.Models;
using Microsoft.Data.SqlClient;

namespace BookHaven.Data.Repositories.CustomerManagementRepository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly string _connectionString;
        public CustomerRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["BookHavenDB"]?.ConnectionString;

            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new Exception("Connection string 'BookHavenDB' not found in App.config.");
            }
        }

        public Customer AddCustomer(Customer customer)
        {
            Customer addedCustomer = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = @"INSERT INTO Customer (FirstName, LastName, Email, PhoneNumber, DateOfBirth, Gender, Address, City, ZipCode,IsDeleted,CreatedAt,UpdatedAt)
                                     VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @DateOfBirth, @Gender, @Address, @City, @ZipCode,@IsDeleted,@CreatedAt,@UpdatedAt)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", customer.LastName);
                        cmd.Parameters.AddWithValue("@Email", customer.Email);
                        cmd.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
                        cmd.Parameters.AddWithValue("@DateOfBirth", customer.DateOfBirth);
                        cmd.Parameters.AddWithValue("@Gender", customer.Gender);
                        cmd.Parameters.AddWithValue("@Address", customer.Address);
                        cmd.Parameters.AddWithValue("@City", customer.City);
                        cmd.Parameters.AddWithValue("@ZipCode", customer.ZipCode);
                        cmd.Parameters.AddWithValue("@IsDeleted", false);
                        cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                        cmd.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);

                        conn.Open();
                        var result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            addedCustomer = customer;
                            addedCustomer.CustomerId = Convert.ToInt32(result);
                            if (!string.IsNullOrEmpty(customer.Email))
                            {
                                SendEmail(customer.Email); // Send email to the customer
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                throw new Exception("An error occurred while adding the customer to the database.", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
                throw new Exception("An unexpected error occurred while customer the book.", ex);
            }

            return addedCustomer;
        }

        public bool DeleteCustomer(int customerId)
        {
            bool isDeleted = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = @"UPDATE Customer SET IsDeleted = 1 WHERE CustomerId = @CustomerId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);
                        cmd.Parameters.AddWithValue("@CustomerId", customerId);
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        isDeleted = rowsAffected > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                throw new Exception("An error occurred while deleting the customer from the database.", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
                throw new Exception("An unexpected error occurred while deleting the customer.", ex);
            }
            return isDeleted;
        }



        public bool EditCustomer(Customer customer)
        {
            bool isUpdated = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = @"UPDATE Customer
                             SET FirstName = @FirstName,
                                 LastName = @LastName,
                                 Email = @Email,
                                 PhoneNumber = @PhoneNumber,
                                 DateOfBirth = @DateOfBirth,
                                 Gender = @Gender,
                                 Address = @Address,
                                 City = @City,
                                 ZipCode = @ZipCode,
                                 IsDeleted = @IsDeleted,
                                 UpdatedAt = @UpdatedAt
                             WHERE CustomerId = @CustomerId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", customer.LastName);
                        cmd.Parameters.AddWithValue("@Email", customer.Email);
                        cmd.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
                        cmd.Parameters.AddWithValue("@DateOfBirth", customer.DateOfBirth);
                        cmd.Parameters.AddWithValue("@Gender", customer.Gender);
                        cmd.Parameters.AddWithValue("@Address", customer.Address);
                        cmd.Parameters.AddWithValue("@City", customer.City);
                        cmd.Parameters.AddWithValue("@ZipCode", customer.ZipCode);
                        cmd.Parameters.AddWithValue("@IsDeleted", customer.IsDeleted); // Ensure you handle IsDeleted properly
                        cmd.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);
                        cmd.Parameters.AddWithValue("@CustomerId", customer.CustomerId);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            isUpdated = true;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                throw new Exception("An error occurred while updating the customer information in the database.", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
                throw new Exception("An unexpected error occurred while updating the customer information.", ex);
            }

            return isUpdated;

     }

    public List<Customer> GetAllCustomers(string searchparam)
        {
            List<Customer> customers = new List<Customer>();

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    // SQL query to fetch customers with search functionality
                    string query = @"
                SELECT CustomerId, FirstName, LastName, Email, PhoneNumber, DateOfBirth, Gender, Address, City, ZipCode
                FROM Customer
                WHERE IsDeleted = 0 
                AND (FirstName LIKE @SearchParam OR LastName LIKE @SearchParam OR Email LIKE @SearchParam);";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Set the value of the @SearchParam parameter
                        cmd.Parameters.AddWithValue("@SearchParam", "%" + searchparam + "%");

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Mapping data from the database to the Customer model
                                Customer customer = new Customer
                                {
                                    CustomerId = reader.GetInt32(reader.GetOrdinal("CustomerId")),
                                    FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                                    LastName = reader.GetString(reader.GetOrdinal("LastName")),
                                    Email = reader.GetString(reader.GetOrdinal("Email")),
                                    PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber")),
                                    DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                                    Gender = reader.GetString(reader.GetOrdinal("Gender")),
                                    Address = reader.GetString(reader.GetOrdinal("Address")),
                                    City = reader.GetString(reader.GetOrdinal("City")),
                                    ZipCode = reader.GetString(reader.GetOrdinal("ZipCode"))
                                };
                                customers.Add(customer);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                throw new Exception("An error occurred while fetching the customers from the database.", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
                throw new Exception("An unexpected error occurred while fetching the customers.", ex);
            }

            return customers;
        }

        private void SendEmail(string recipientEmail)
        {
            try
            {
                string senderEmail = "uminduchethiya@gmail.com"; // Change to your email
                string senderPassword = "bcgjguscujhvknor"; // Change to your email password
                string smtpServer = "smtp.gmail.com"; // Change to your SMTP server
                int smtpPort = 587; // Change to the correct SMTP port

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(senderEmail);
                    mail.To.Add(recipientEmail);
                    mail.Subject = "Congratulation";
                    mail.Body = $"Dear Customer, You are successfully Added to the Book Heaven !";
                    mail.IsBodyHtml = false;

                    using (SmtpClient smtp = new SmtpClient(smtpServer, smtpPort))
                    {
                        smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending email: {ex.Message}");
            }
        }
    }
}
