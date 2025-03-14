using BookHaven.Data.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Data.Repositories.SupplierManagementRepository
{
    class SupplierManageRepository : ISupplierManageRepositories
    {
        private readonly string _connectionString;

        public SupplierManageRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["BookHavenDB"]?.ConnectionString;

            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new Exception("Connection string 'BookHavenDB' not found in App.config.");
            }
        }
        public void AddSupplier(Supplier supplier)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Supplier (SupplierName, PhoneNumber, Email, Address, Status) VALUES (@name, @phone, @email, @address, @status)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", supplier.SupplierName);
                    cmd.Parameters.AddWithValue("@phone", supplier.PhoneNumber);
                    cmd.Parameters.AddWithValue("@email", supplier.Email);
                    cmd.Parameters.AddWithValue("@address", supplier.Address);
                    cmd.Parameters.AddWithValue("@status", supplier.Status);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateSupplier(Supplier supplier)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Supplier SET SupplierName = @name, PhoneNumber = @phone, Email = @email, Address = @address, Status = @status WHERE SupplierID = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", supplier.SupplierID);
                    cmd.Parameters.AddWithValue("@name", supplier.SupplierName);
                    cmd.Parameters.AddWithValue("@phone", supplier.PhoneNumber);
                    cmd.Parameters.AddWithValue("@email", supplier.Email);
                    cmd.Parameters.AddWithValue("@address", supplier.Address);
                    cmd.Parameters.AddWithValue("@status", supplier.Status);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Supplier> GetAllSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Supplier";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            suppliers.Add(new Supplier
                            {
                                SupplierID = Convert.ToInt32(reader["SupplierID"]),
                                SupplierName = reader["SupplierName"].ToString(),
                                PhoneNumber = reader["PhoneNumber"].ToString(),
                                Email = reader["Email"].ToString(),
                                Address = reader["Address"].ToString(),
                                Status = reader["Status"].ToString()
                            });
                        }
                    }
                }
            }
            return suppliers;
        }

        public Supplier GetSupplierByName(string supplierName)
        {
            Supplier supplier = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Supplier WHERE SupplierName = @name";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", supplierName);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            supplier = new Supplier
                            {
                                SupplierID = Convert.ToInt32(reader["SupplierID"]),
                                SupplierName = reader["SupplierName"].ToString(),
                                PhoneNumber = reader["PhoneNumber"].ToString(),
                                Email = reader["Email"].ToString(),
                                Address = reader["Address"].ToString(),
                                Status = reader["Status"].ToString()
                            };
                        }
                    }
                }
            }
            return supplier;
        }

        // Implement DeactivateSupplier
        public void DeactivateSupplier(int supplierId)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "UPDATE Supplier SET Status='Deactive' WHERE SupplierID=@id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", supplierId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Implement GetActiveSuppliers
        public List<Supplier> GetActiveSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Supplier WHERE Status='Active'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        suppliers.Add(new Supplier
                        {
                            SupplierID = Convert.ToInt32(reader["SupplierID"]),
                            SupplierName = reader["SupplierName"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Email = reader["Email"].ToString(),
                            Address = reader["Address"].ToString(),
                            Status = reader["Status"].ToString()
                        });
                    }
                }
            }
            return suppliers;
        }
    }
}
