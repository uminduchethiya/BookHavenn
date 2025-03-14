using BookHaven.Business.Interfaces;
using BookHaven.Business.Services;
using BookHaven.Data.Models;
using BookHaven.Data.Repositories.OrderManagementRepositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHaven.Presentation.Admin;

namespace BookHaven.Presentation.Comman
{
    public partial class OrderAdd : Form
    {
        private readonly IOrderManagementService _orderService;
        public OrderAdd()
        {
            InitializeComponent();
            _orderService = new OrderManagementService(new OrderManageRepositories());
            // Initialize DataGridView columns
            InitializeDataGridViews();
            LoadCustomers();
            LoadBooks();
        }
        private void InitializeDataGridViews()
        {
            // Initialize dtgcustomerdeatils DataGridView columns
            dtgcustomerdeatils.Columns.Clear();
            dtgcustomerdeatils.Columns.Add("CustomerId", "Customer ID");
            dtgcustomerdeatils.Columns.Add("FirstName", "First Name");
            dtgcustomerdeatils.Columns.Add("LastName", "Last Name");
            dtgcustomerdeatils.Columns.Add("Email", "Email");
            dtgcustomerdeatils.Columns.Add("Address", "Address");

            // Initialize dtgsearchbook DataGridView columns
            dtgsearchbook.Columns.Clear();
            dtgsearchbook.Columns.Add("BookId", "Book ID");
            dtgsearchbook.Columns.Add("Title", "Title");
            dtgsearchbook.Columns.Add("Author", "Author");
            dtgsearchbook.Columns.Add("Price", "Price");
            dtgsearchbook.Columns.Add("StockQuantity", "Stock Quantity");
        }

        private void LoadCustomers()
        {
            try
            {
                List<Customer> customers = _orderService.GetCustomerByPhone("");

                if (customers != null && customers.Count > 0)
                {
                    cmbsearchphone.DataSource = customers;
                    cmbsearchphone.DisplayMember = "PhoneNumber"; // Ensure PhoneNumber exists in Customer model
                    cmbsearchphone.ValueMember = "CustomerId"; // Ensure CustomerId exists
                }
                else
                {
                    cmbsearchphone.DataSource = null;
                    MessageBox.Show("No customers found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBooks()
        {
            List<Book> books = _orderService.GetBookByTitle("");
            cmbsearchbook.DataSource = books;
            cmbsearchbook.DisplayMember = "Title";
            cmbsearchbook.ValueMember = "BookId";
        }
        private void cmbsearchphone_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ensure there's a valid item selected
            if (cmbsearchphone.SelectedItem != null)
            {
                // Cast the selected item to Customer object
                Customer selectedCustomer = cmbsearchphone.SelectedItem as Customer;

                if (selectedCustomer != null)
                {
                    // Clear existing data in the grid view before adding new data
                    dtgcustomerdeatils.Rows.Clear();

                    // Add the selected customer details to the DataGridView
                    dtgcustomerdeatils.Rows.Add(
                        selectedCustomer.CustomerId,
                        selectedCustomer.FirstName,
                        selectedCustomer.LastName,
                        selectedCustomer.Email,
                        selectedCustomer.Address
                    );
                }
            }

        }

        private void cmbsearchbook_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ensure there's a valid item selected
            // Ensure there's a valid item selected
            if (cmbsearchbook.SelectedItem != null)
            {
                // Cast the selected item to a Book object
                Book selectedBook = cmbsearchbook.SelectedItem as Book;

                if (selectedBook != null)
                {
                    // Clear the DataGridView before adding the new row
                    dtgsearchbook.Rows.Clear();

                    // Add the selected book's details to the DataGridView
                    dtgsearchbook.Rows.Add(
                        selectedBook.BookId,
                        selectedBook.Title,
                        selectedBook.Author,
                        selectedBook.Genre,
                        selectedBook.Price,
                        selectedBook.StockQuantity
                    );
                }
                else
                {
                    MessageBox.Show("Selected book not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void dtgcustomerdeatils_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Optionally, retrieve the CustomerId or other data from the clicked row
                var customerId = dtgcustomerdeatils.Rows[e.RowIndex].Cells[0].Value;
                // Perform any actions needed when a row is clicked, such as opening a customer details form
            }
        }

        private void dtgsearchbook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Get the BookId from the selected row (assuming it's in the first column)
                var bookId = dtgsearchbook.Rows[e.RowIndex].Cells[0].Value;

                // Use the bookId to fetch the book details (you can query your repository or service)
                OrderManageRepositories repository = new OrderManageRepositories();
                Book selectedBook = repository.GetBooks().FirstOrDefault(b => b.BookId == (int)bookId);

                if (selectedBook != null)
                {
                    // Optionally, you can open a form or display the details in another control, e.g., a separate details panel.
                    // For example:
                    MessageBox.Show($"Title: {selectedBook.Title}\nAuthor: {selectedBook.Author}\nGenre: {selectedBook.Genre}\nPrice: {selectedBook.Price}",
                                    "Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Book not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OrderAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            if (cmbsearchphone.SelectedItem != null && cmbsearchbook.SelectedItem != null)
            {
                Customer selectedCustomer = cmbsearchphone.SelectedItem as Customer;
                Book selectedBook = cmbsearchbook.SelectedItem as Book;

                int quantity = int.Parse(txtbookqunity.Text);
                decimal price = decimal.Parse(txtbookprice.Text);
                decimal subtotal = quantity * price;
                string deliveryType = GetDeliveryType();

                if (quantity > selectedBook.StockQuantity)
                {
                    MessageBox.Show($"Quantity exceeds available stock. Only {selectedBook.StockQuantity} books are available.",
                                    "Quantity Not Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var order = new Order
                {
                    CustomerId = selectedCustomer.CustomerId,
                    BookId = selectedBook.BookId,
                    Quantity = quantity,
                    Price = price,
                    Subtotal = subtotal,
                    Status = "Pending",
                    DeliveryType = deliveryType,
                    OrderDate = DateTime.Now
                };

                try
                {
                    _orderService.SaveOrder(order);
                    MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Send confirmation email
                    SendOrderConfirmationEmail(selectedCustomer.Email, order);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error placing order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a customer and a book.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string GetDeliveryType()
        {
            List<string> selectedDeliveryTypes = new List<string>();

            foreach (var item in chkdiliverydetails.CheckedItems)
            {
                selectedDeliveryTypes.Add(item.ToString());
            }

            return string.Join(", ", selectedDeliveryTypes); // Combine selected delivery types into a string
        }

        // Save order to database
        private void SaveOrderToDatabase(Order order)
        {
            // Call the SaveOrder method to save the order to the database
            _orderService.SaveOrder(order);
        }
        // Subtotal Calculation
        private void txtBookQuantity_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtbookqunity.Text, out int quantity) && decimal.TryParse(txtbookprice.Text, out decimal price))
            {
                decimal subtotal = quantity * price;
                lblsubtotal.Text = $"Subtotal: {subtotal:C}";
            }
            else
            {
                lblsubtotal.Text = "Invalid quantity or price.";
            }
        }

        private void UpdateSubtotal()
        {
            if (int.TryParse(txtbookqunity.Text, out int quantity) && decimal.TryParse(txtbookprice.Text, out decimal price))
            {
                decimal subtotal = quantity * price;
                lblsubtotal.Text = $" {subtotal:C}";
            }
            else
            {
                lblsubtotal.Text = "Invalid quantity or price.";
            }
        }

        private void txtbookqunity_TextChanged(object sender, EventArgs e)
        {
            UpdateSubtotal();
        }

        private void txtbookprice_TextChanged(object sender, EventArgs e)
        {
            UpdateSubtotal();
        }

        private void SendOrderConfirmationEmail(string recipientEmail, Order order)
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
                    mail.Subject = $"Order Confirmation - Order ID: {order.OrderId}";
                    mail.Body =
                                $"Thank you for your order! Below are the details:\n\n" +
                                $"Order ID: {order.OrderId}\n" +
                                $"Book Title: {_orderService.GetBookByTitle("").FirstOrDefault(b => b.BookId == order.BookId)?.Title}\n" +
                                $"Quantity: {order.Quantity}\n" +
                                $"Total Price: {order.Subtotal:C}\n" +
                                $"Delivery Type: {order.DeliveryType}\n\n" +
                                $"Your order is currently pending. We will notify you once it is shipped.\n\n" +
                                $"Best Regards,\nBookHaven Team";

                    mail.IsBodyHtml = false;

                    using (SmtpClient smtp = new SmtpClient(smtpServer, smtpPort))
                    {
                        smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }

                MessageBox.Show("Order confirmation email sent successfully!", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnmanageorder_Click(object sender, EventArgs e)
        {
            // Create an instance of the OrderManageRepositories
            IOrderManageRepositories orderRepo = new OrderManageRepositories();

            // Initialize service with the repository
            IOrderManagementService orderService = new OrderManagementService(orderRepo);

            // Create an instance of OrderManage form and pass the service
            OrderManage orderManageForm = new OrderManage(orderService);
            this.Hide();
            // Show the OrderManage form (non-blocking, new window)
            orderManageForm.Show();
        }

        private void btnaddcustomer_Click(object sender, EventArgs e)
        {

            AddCustomer addCustomerForm = new AddCustomer();
            this.Hide();
            addCustomerForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();  // To show the AdminDashboard form
            this.Hide();  // Optionally hide the current form
        }
    }

}
