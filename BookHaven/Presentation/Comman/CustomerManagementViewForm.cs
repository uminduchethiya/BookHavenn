using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHaven.Data.Models;
using BookHaven.Data.Repositories.BookManagementRepository;
using BookHaven.Data.Repositories.CustomerManagementRepository;
using BookHaven.Presentation.Admin;
using BookHaven.Utilities;

namespace BookHaven.Presentation.Comman
{
    public partial class CustomerManagementViewForm : Form
    {
        private readonly CustomerRepository _customerRepository;

        public CustomerManagementViewForm()
        {
            InitializeComponent();
            _customerRepository = new CustomerRepository();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerManagementViewForm_Load(object sender, EventArgs e)
        {
            LoadCustomers(string.Empty);
        }
        private void LoadCustomers(string searchparm)
        {
            try
            {
                var books = _customerRepository.GetAllCustomers(searchparm);
                dataGridView1.DataSource = books;

                dataGridView1.Columns["IsDeleted"].Visible = false;
                dataGridView1.Columns["CreatedAt"].Visible = false;
                dataGridView1.Columns["UpdatedAt"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Customers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the CustomerId (Primary Key) from the selected row
                int customerId = (int)selectedRow.Cells["CustomerId"].Value;

                // Validate required fields
                if (string.IsNullOrWhiteSpace(txtname.Text) ||
                    string.IsNullOrWhiteSpace(txtLastName.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
                    string.IsNullOrWhiteSpace(txtAddress.Text) ||
                    string.IsNullOrWhiteSpace(txtCity.Text) ||
                    string.IsNullOrWhiteSpace(txtZipcode.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate email format
                if (!IsValidEmail(txtEmail.Text))
                {
                    MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate phone number (for simplicity, checking for digits and length)
                if (!txtPhoneNumber.Text.All(char.IsDigit) || txtPhoneNumber.Text.Length != 10)
                {
                    MessageBox.Show("Please enter a valid phone number with 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate date of birth (ensure it's a valid date)
                DateTime dob;
                if (!DateTime.TryParse(dateTimePicker1.Text, out dob))
                {
                    MessageBox.Show("Please enter a valid Date of Birth.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create a Customer object with the updated data from the text boxes
                Customer updatedCustomer = new Customer
                {
                    CustomerId = customerId,
                    FirstName = txtname.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    DateOfBirth = dob,
                    Gender = cmbGender.Text,
                    Address = txtAddress.Text,
                    City = txtCity.Text,
                    ZipCode = txtZipcode.Text
                };


                var result = _customerRepository.EditCustomer(updatedCustomer);

                if (result)
                {
                    MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomers(textBox1.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Failed to update the customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text.Trim();
            LoadCustomers(searchTerm);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Set the values from the selected row to the respective textboxes
                txtname.Text = selectedRow.Cells["FirstName"].Value?.ToString() ?? string.Empty;
                txtLastName.Text = selectedRow.Cells["LastName"].Value?.ToString() ?? string.Empty;
                txtEmail.Text = selectedRow.Cells["Email"].Value?.ToString() ?? string.Empty;
                txtPhoneNumber.Text = selectedRow.Cells["PhoneNumber"].Value?.ToString() ?? string.Empty;
                dateTimePicker1.Text = selectedRow.Cells["DateOfBirth"].Value?.ToString() ?? string.Empty;
                cmbGender.Text = selectedRow.Cells["Gender"].Value?.ToString() ?? string.Empty;
                txtAddress.Text = selectedRow.Cells["Address"].Value?.ToString() ?? string.Empty;
                txtCity.Text = selectedRow.Cells["City"].Value?.ToString() ?? string.Empty;
                txtZipcode.Text = selectedRow.Cells["ZipCode"].Value?.ToString() ?? string.Empty;

            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if a user is logged in
            if (SessionManager.LoggedInUser == null)
            {
                MessageBox.Show("Please log in first!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Restrict users with RoleID 2 from deleting customers
            if (SessionManager.LoggedInUser.RoleID == 2)
            {
                MessageBox.Show("You do not have permission to delete customers!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int customerId = (int)selectedRow.Cells["CustomerId"].Value;

                var result = _customerRepository.DeleteCustomer(customerId);
                if (result)
                {
                    MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomers(textBox1.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Failed to delete the customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();  // To show the AdminDashboard form
            this.Hide();  // Optionally hide the current form
        }
    }
}
