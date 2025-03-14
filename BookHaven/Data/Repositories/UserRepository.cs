using BookHaven.Data.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly string _connectionString;

        public UserRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["BookHavenDB"]?.ConnectionString;

            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new Exception("Connection string 'BookHavenDB' not found in App.config.");
            }
        }

        public UserModel GetUserByEmailAndPassword(string email, string password)
        {
            UserModel user = null;

            // Hash the input password before querying
            byte[] hashedPasswordBytes = HashPassword(password);
            string hashedPassword = BitConverter.ToString(hashedPasswordBytes).Replace("-", ""); // Convert to Hex String

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT FirstName, LastName, Email, Phone, RoleID, IsDeleted, CreatedAt, Id, Address " +
                               "FROM Users WHERE Email = @Email AND Password = @Password AND IsDeleted = 0";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new UserModel
                            {
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Email = reader["Email"].ToString(),
                                RoleID = Convert.ToInt32(reader["RoleID"]),
                                Phone = reader["Phone"].ToString(),
                                CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
                            };
                        }
                    }
                }
            }
            return user;
        }

        // Method to hash the password using SHA-256
        private byte[] HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
