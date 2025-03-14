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
using BookHaven.Presentation.Admin;

namespace BookHaven.Presentation.Comman
{
    public partial class AddBook : Form
    {
        private readonly BookRepository _bookRepository;
        public AddBook()
        {
            InitializeComponent();
            _bookRepository = new BookRepository();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                var book = new Book
                {
                    Title = txtTitle.Text,
                    Author = txtAuthor.Text,
                    ISBN = txtIsbn.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    StockQuantity = int.Parse(txtStock.Text),
                    Genre = cmbCategory.SelectedItem.ToString()
                };

                try
                {
                    var addedBook = _bookRepository.AddBook(book);

                    if (addedBook != null)
                    {
                        MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add the book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                MessageBox.Show("Please enter the book title.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtAuthor.Text))
            {
                MessageBox.Show("Please enter the author's name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtIsbn.Text))
            {
                MessageBox.Show("Please enter the ISBN.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out _))
            {
                MessageBox.Show("Please enter a valid price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtStock.Text, out _))
            {
                MessageBox.Show("Please enter a valid stock quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a genre.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void ClearForm()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            txtIsbn.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            cmbCategory.SelectedItem = null;
        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }

        private void btnInventoryManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookInventoryViewForm inventoryManagement = new BookInventoryViewForm();
            inventoryManagement.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();  // To show the AdminDashboard form
            this.Hide();  // Optionally hide the current form
        }
    }
}
