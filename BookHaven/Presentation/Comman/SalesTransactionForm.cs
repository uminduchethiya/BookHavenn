using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHaven.Business.Services;
using BookHaven.Data.Models;
using BookHaven.Data.Repositories.BookManagementRepository;
using BookHaven.Data.Repositories.CustomerManagementRepository;
using BookHaven.Data.Repositories.SalesTransactionRepository;
using BookHaven.Presentation.Admin;

namespace BookHaven.Presentation.Comman
{
    public partial class SalesTransactionForm : Form
    {
        private readonly BookRepository _bookRepository;
        private readonly CustomerRepository _customerRepository;
        private readonly SalesTransactionRepository _salesTransactionRepository;
        private readonly SalesTransactionService _salesTransactionService;

        private Customer selectedCustomer;

        public SalesTransactionForm()
        {
            InitializeComponent();
            _bookRepository = new BookRepository();
            _customerRepository = new CustomerRepository();
            _salesTransactionRepository = new SalesTransactionRepository();
            _salesTransactionService = new SalesTransactionService();
        }

        private void btnGenarateBill_Click(object sender, EventArgs e)
        {
            var salesData = new List<DataGridViewRow>();

            // Add all rows in DataGridView to the salesData list
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Ensure the row is not empty before adding
                if (row.Cells["BookId"].Value != null)
                {
                    salesData.Add(row);
                }
            }

            // Parse the discount from the label (handle parsing failure)
            decimal discount = decimal.TryParse(lblDiscountedAmount.Text, out decimal d) ? d : 0;

            // Ensure a customer is selected
            if (selectedCustomer == null)
            {
                MessageBox.Show("Please select a customer first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate the total amount based on the salesData
            decimal totalAmount = 0;
            foreach (var row in salesData)
            {
                // Make sure that Subtotal is not null and is valid for calculation
                if (row.Cells["Subtotal"].Value != null)
                {
                    totalAmount += Convert.ToDecimal(row.Cells["Subtotal"].Value);
                }
            }

            try
            {
                // Generate the bill PDF
                string billFilePath = _salesTransactionService.GenerateBill(salesData, discount, selectedCustomer);

                // Send the generated bill via email to the customer
                _salesTransactionService.SendBillEmail(selectedCustomer.Email, billFilePath);

                // Reduce stock for the books sold in this transaction
                _salesTransactionService.ReduceStock(salesData);

                // Insert the transaction record into the database
                _salesTransactionService.InsertTransactionRecord(selectedCustomer, salesData, totalAmount, discount);

                // Inform the user that the transaction was successful
                MessageBox.Show("Transaction completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle any errors during the process
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SalesTransactionForm_Load(object sender, EventArgs e)
        {
            LoadAllBooks();
            LoadAllCustomers();

        }
        // Load all books into the ComboBox
        private void LoadAllBooks()
        {
            // Fetch all books from the database
            var allBooks = _bookRepository.GetAllBooks(string.Empty);  // Assuming you want to fetch all books without any search parameter

            // Set the ComboBox data source to the list of all books
            cmbSearchBooks.DataSource = allBooks;
            cmbSearchBooks.DisplayMember = "Title";  // Set the display member to book title
            cmbSearchBooks.ValueMember = "BookId";  // Set the value member to the BookId (for selection purposes)
        }
        private void LoadAllCustomers()
        {
            // Fetch all books from the database
            var allCustomers = _customerRepository.GetAllCustomers(string.Empty);  // Assuming you want to fetch all books without any search parameter

            // Set the ComboBox data source to the list of all books
            cmbsearchcustomers.DataSource = allCustomers;
            cmbsearchcustomers.DisplayMember = "Email";  // Set the display member to book title
            cmbsearchcustomers.ValueMember = "CustomerId";  // Set the value member to the BookId (for selection purposes)
        }
        private void cmbSearchBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearchBooks.SelectedItem != null)
            {
                var selectedBook = (Book)cmbSearchBooks.SelectedItem;

                // Check if the book is already in the DataGridView to avoid duplicates
                bool bookExists = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["BookId"].Value != null && (int)row.Cells["BookId"].Value == selectedBook.BookId)
                    {
                        bookExists = true;
                        break;
                    }
                }

                if (!bookExists)
                {
                    // Add the selected book to the DataGridView
                    dataGridView1.Rows.Add(selectedBook.BookId, selectedBook.Title, selectedBook.Price, 1, selectedBook.Price);

                    // Recalculate the total after adding the book
                    RecalculateTotal();
                }
                else
                {
                    //MessageBox.Show("This book is already in the cart.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void cmbSearchBooks_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = cmbSearchBooks.Text; // Get the text entered by the user in the ComboBox

            // Filter the books based on the search term
            var filteredBooks = _bookRepository.GetAllBooks(searchTerm);  // Use the same method, but search within the loaded books

            // Update ComboBox with the filtered books
            cmbSearchBooks.DataSource = filteredBooks;
            cmbSearchBooks.DisplayMember = "Title";  // Set the display member to book title
            cmbSearchBooks.ValueMember = "BookId";  // Set the value member to the BookId (for selection purposes)
        }
        private void RecalculateTotal()
        {
            decimal totalAmount = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Ensure Subtotal is not null and valid for calculation
                if (row.Cells["Subtotal"].Value != null)
                {
                    totalAmount += Convert.ToDecimal(row.Cells["Subtotal"].Value);
                }
            }

            lblTotalAmount.Text = totalAmount.ToString("C");

            // Apply discount if there is one
            decimal discount = 0;

            // Try to parse the discount percentage, use 0 if the input is invalid
            if (!decimal.TryParse(comboBox1.Text, out discount))
            {
                discount = 0;
            }

            decimal discountAmount = (discount / 100) * totalAmount;
            decimal finalAmount = totalAmount - discountAmount;

            lblDiscountedAmount.Text = discountAmount.ToString("C");
            lblFinalAamount.Text = finalAmount.ToString("C");
        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the column being accessed is 'Quantity' by name, not by index
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Quantity")
            {
                int quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value);
                decimal price = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["Price"].Value);
                decimal subtotal = quantity * price;

                // Update the subtotal column (ensure it's available in your DataGridView)
                dataGridView1.Rows[e.RowIndex].Cells["Subtotal"].Value = subtotal;

                // Recalculate the total amount after quantity change
                RecalculateTotal();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Ensure that a row is selected before trying to delete
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Remove the selected row from the DataGridView
                dataGridView1.Rows.Remove(selectedRow);

                // Recalculate the total after deletion
                RecalculateTotal();
            }
            else
            {
                MessageBox.Show("Please select a book to delete.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void cmbsearchcustomers_TextChanged(object sender, EventArgs e)
        {
            // Get the search term from the text box (txtSearchCustomer)
            string searchTerm = cmbsearchcustomers.Text;

            // Call GetAllCustomers with the search term
            var customers = _customerRepository.GetAllCustomers(searchTerm);

            // Set the data source for the ComboBox
            cmbsearchcustomers.DataSource = customers;
            cmbsearchcustomers.DisplayMember = "Email";  // Display the email in the ComboBox
            cmbsearchcustomers.ValueMember = "CustomerId";  // Value member for backend reference
        }

        private void cmbsearchcustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ensure a customer is selected
            if (cmbsearchcustomers.SelectedItem != null)
            {
                // Cast the selected item to a Customer
                selectedCustomer = (Customer)cmbsearchcustomers.SelectedItem;

                // Populate the labels with the selected customer's information
                lblEmail.Text = selectedCustomer.Email;
                lblName.Text = selectedCustomer.FirstName + " " + selectedCustomer.LastName;
                lblPhone.Text = selectedCustomer.PhoneNumber;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            lblTotalAmount.Text = "0.00";
            lblDiscountedAmount.Text = "0.00";
            lblFinalAamount.Text = "0.00";
            selectedCustomer = null;
            lblEmail.Text = string.Empty;
            lblName.Text = string.Empty;
            lblPhone.Text = string.Empty;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();  // To show the AdminDashboard form
            this.Hide();  // Optionally hide the current form

        }
    }
}
