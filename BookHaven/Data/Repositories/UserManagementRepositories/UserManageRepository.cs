using BookHaven.Data.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace BookHaven.Data.Repositories
{
    internal class UserManageRepository : IUserManageRepository
    {
        private readonly string _connectionString;

        public UserManageRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["BookHavenDB"]?.ConnectionString;

            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new Exception("Connection string 'BookHavenDB' not found in App.config.");
            }
        }

        public void AddUser(UserModel user)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO Users (RegistrationNumber, FirstName, LastName, Email, Password, Address, 
                                 Phone, RoleID, Idnumber, Gender, Dob, IsDeleted, CreatedAt) 
                                 VALUES (@RegNo, @FName, @LName, @Email, @Password, @Address, 
                                 @Phone, @RoleID, @Idnumber, @Gender, @Dob, @IsDeleted, @CreatedAt)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RegNo", user.RegistrationNumber);
                cmd.Parameters.AddWithValue("@FName", user.FirstName);
                cmd.Parameters.AddWithValue("@LName", user.LastName);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Address", user.Address);
                cmd.Parameters.AddWithValue("@Phone", user.Phone);
                cmd.Parameters.AddWithValue("@RoleID", user.RoleID);
                cmd.Parameters.AddWithValue("@Idnumber", user.Idnumber);
                cmd.Parameters.AddWithValue("@Gender", user.Gender);
                cmd.Parameters.AddWithValue("@Dob", user.Dob);
                cmd.Parameters.AddWithValue("@IsDeleted", user.IsDeleted);
                cmd.Parameters.AddWithValue("@CreatedAt", user.CreatedAt);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public List<KeyValuePair<int, string>> GetUserRoles()
        {
            List<KeyValuePair<int, string>> roles = new List<KeyValuePair<int, string>>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT RoleID, RoleName FROM UserRole";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    roles.Add(new KeyValuePair<int, string>(reader.GetInt32(0), reader.GetString(1)));
                }
                conn.Close();
            }

            return roles;
        }

        public List<UserModel> GetAllUsers()
        {
            List<UserModel> users = new List<UserModel>();

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE IsDeleted = 0", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                users.Add(new UserModel
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    FirstName = reader["FirstName"].ToString(),
                                    LastName = reader["LastName"].ToString(),
                                    Address = reader["Address"].ToString(),
                                    Phone = reader["Phone"].ToString(),
                                    Idnumber = reader["Idnumber"].ToString(), // Added Idnumber
                                    Gender = reader["Gender"].ToString(), // Added Gender
                                    Dob = Convert.ToDateTime(reader["Dob"]) // Added Date of Birth (Dob)
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching users: " + ex.Message);
            }

            return users;
        }

        public void UpdateUser(UserModel user)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"UPDATE Users 
                         SET FirstName = @FirstName, 
                             LastName = @LastName, 
                             Phone = @Phone, 
                             IdNumber = @IdNumber, 
                             Gender = @Gender, 
                             Dob = @Dob 
                         WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", user.Id);
                cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                cmd.Parameters.AddWithValue("@LastName", user.LastName);
                cmd.Parameters.AddWithValue("@Phone", user.Phone);
                cmd.Parameters.AddWithValue("@IdNumber", user.Idnumber); // Ensure correct column name
                cmd.Parameters.AddWithValue("@Gender", user.Gender);
                cmd.Parameters.AddWithValue("@Dob", user.Dob);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void DeleteUser(int userId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Users SET IsDeleted = 1 WHERE Id = @Id AND IsDeleted = 0"; // Mark the user as deleted
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", userId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting user: " + ex.Message);
                throw;
            }
        }


    }
}
