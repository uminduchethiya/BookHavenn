using BookHaven.Business.Interfaces;
using BookHaven.Business.Services;
using BookHaven.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHaven.Presentation.Admin
{
    public partial class AddSupplier : Form
    {
        private readonly ISupplierManagementService _supplierService;
        private int _selectedSupplierID = -1;
        public AddSupplier()
        {
            InitializeComponent();
            _supplierService = new SupplierManagementService();
            LoadSuppliers();
            cmbsupplier.KeyDown += cmbsupplier_KeyDown;  // Attach KeyDown event
            dtgsupplier.CellClick += dtgsupplier_CellContentClick; // Attach event for clicking DataGridView row
        }
        private void LoadSuppliers()
        {
            cmbsupplier.Items.Clear();

            // Load only active suppliers
            var activeSuppliers = _supplierService.GetActiveSuppliers();
            dtgsupplier.DataSource = activeSuppliers;  // Load active suppliers in DataGridView

            // Add active suppliers to combo box
            foreach (var supplier in activeSuppliers)
            {
                cmbsupplier.Items.Add(supplier.SupplierName);
            }
        }
        private void cmbsupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchSupplier();
            }
        }

        private void btnaddsupplier_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtsuppliername.Text) ||
                    string.IsNullOrWhiteSpace(txtsupplierphonenumber.Text) ||
                    string.IsNullOrWhiteSpace(txtsupplieremail.Text) ||
                    string.IsNullOrWhiteSpace(txtsupplieraddress.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Supplier supplier = new Supplier
                {
                    SupplierName = txtsuppliername.Text,
                    PhoneNumber = txtsupplierphonenumber.Text,
                    Email = txtsupplieremail.Text,
                    Address = txtsupplieraddress.Text,
                    Status = "Active" // Default status
                };

                _supplierService.AddSupplier(supplier);

                MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Reload the ComboBox and DataGridView to show the newly added supplier
                LoadSuppliers();


                // Clear input fields after adding
                txtsuppliername.Clear();
                txtsupplierphonenumber.Clear();
                txtsupplieremail.Clear();
                txtsupplieraddress.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cmbsupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchSupplier();

        }
        private void SearchSupplier()
        {
            string searchText = cmbsupplier.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchText)) return;

            // Get all suppliers and filter based on the search text
            var suppliers = _supplierService.GetAllSuppliers()
                                             .Where(s => s.SupplierName.StartsWith(searchText, StringComparison.OrdinalIgnoreCase))
                                             .ToList();

            // Check if any suppliers match the search text
            if (suppliers.Any())
            {
                dtgsupplier.DataSource = suppliers;
            }
            else
            {
                dtgsupplier.DataSource = new List<Supplier>();  // Show empty grid if no matches
            }
        }


        private void dtgsupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgsupplier.Rows[e.RowIndex];
                _selectedSupplierID = Convert.ToInt32(row.Cells["SupplierID"].Value);
                txtsuppliername.Text = row.Cells["SupplierName"].Value.ToString();
                txtsupplierphonenumber.Text = row.Cells["PhoneNumber"].Value.ToString();
                txtsupplieremail.Text = row.Cells["Email"].Value.ToString();
                txtsupplieraddress.Text = row.Cells["Address"].Value.ToString();
            }
        }

        private void btnupdatesupplier_Click(object sender, EventArgs e)
        {
            if (_selectedSupplierID == -1) return;

            Supplier supplier = new Supplier
            {
                SupplierID = _selectedSupplierID,
                SupplierName = txtsuppliername.Text,
                PhoneNumber = txtsupplierphonenumber.Text,
                Email = txtsupplieremail.Text,
                Address = txtsupplieraddress.Text,
                Status = "Active"
            };

            _supplierService.UpdateSupplier(supplier);
            MessageBox.Show("Supplier updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadSuppliers();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtsuppliername.Clear();
            txtsupplierphonenumber.Clear();
            txtsupplieremail.Clear();
            txtsupplieraddress.Clear();
            _selectedSupplierID = -1;  // Reset selected ID
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (_selectedSupplierID == -1)
            {
                MessageBox.Show("Please select a supplier to deactivate.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _supplierService.DeactivateSupplier(_selectedSupplierID);
            MessageBox.Show("Supplier deactivated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadActiveSuppliers(); // Refresh DataGridView to hide deactivated suppliers
        }

        private void LoadActiveSuppliers()
        {
            dtgsupplier.DataSource = _supplierService.GetActiveSuppliers();  // Fetch only active suppliers
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();  // To show the AdminDashboard form
            this.Hide();  // Optionally hide the current form
        }
    }
}
    
