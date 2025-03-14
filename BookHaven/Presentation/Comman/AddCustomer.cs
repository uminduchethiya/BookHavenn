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

namespace BookHaven.Presentation.Comman
{
    public partial class AddCustomer : Form
    {
        private readonly CustomerRepository _customerRepository;
        public AddCustomer()
        {
            InitializeComponent();
            _customerRepository = new CustomerRepository();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Phone Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNumber.Focus();
                return;
            }

            if (cmbGender.SelectedItem == null)
            {
                MessageBox.Show("Gender is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGender.Focus();
                return;
            }

            Customer customer = new Customer
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhoneNumber.Text,
                DateOfBirth = dateTimePicker1.Value,
                Gender = cmbGender.SelectedItem.ToString(),
                Address = txtAddress.Text,
                City = txtCity.Text,
                ZipCode = txtZipCode.Text,
                IsDeleted = false,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            var addedCustomer = _customerRepository.AddCustomer(customer);
            if (addedCustomer != null)
            {
                MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearForm();
            }
            else
            {
                MessageBox.Show("Failed to add customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return mailAddress.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearForm();
        }
        private void clearForm()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            cmbGender.SelectedItem = null;
            txtAddress.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtZipCode.Text = string.Empty;
        }

        private void btnBacktoCustomerManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerManagementViewForm customerManagement = new CustomerManagementViewForm();
            customerManagement.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();  // To show the AdminDashboard form
            this.Hide();  // Optionally hide the current form
        }
    }
}
