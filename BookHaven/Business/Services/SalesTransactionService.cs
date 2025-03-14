using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Business.Interfaces;
using BookHaven.Data.Repositories.BookManagementRepository;
using BookHaven.Data.Repositories.CustomerManagementRepository;
using BookHaven.Data.Repositories.SalesTransactionRepository;
using BookHaven.Data.Models;
using System.Net.Mail;
using System.Net;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace BookHaven.Business.Services
{
    public class SalesTransactionService : ISalesTransactionService
    {
        private readonly ISalesTransactionRepository _salesRepository;
        private readonly IBookRepository _bookRepository;
        private readonly ICustomerRepository _customerRepository;

        public SalesTransactionService(ISalesTransactionRepository salesRepository, IBookRepository bookRepository, ICustomerRepository customerRepository)
        {
            _salesRepository = salesRepository;
            _bookRepository = bookRepository;
            _customerRepository = customerRepository;
        }

        public SalesTransactionService()
        {
            _salesRepository = new SalesTransactionRepository();
            _bookRepository = new BookRepository();
            _customerRepository = new CustomerRepository();
        }

        public string GenerateBill(List<DataGridViewRow> salesData, decimal discount, Customer customer)
        {
            string billFilePath = @"C:\Users\Umindu\Documents\Bills\GeneratedBill.pdf"; // Path for saving the bill PDF

            // Create a new PDF document
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();

            // Create XGraphics object to draw on the page
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Create a font
            XFont font = new XFont("Verdana", 12);

            // Write title and customer info
            gfx.DrawString("Sales Transaction Bill", font, XBrushes.Black, new XRect(0, 20, page.Width, page.Height), XStringFormats.TopCenter);
            gfx.DrawString("Customer Name: " + customer.FirstName + " " + customer.LastName, font, XBrushes.Black, 20, 50);
            gfx.DrawString("Customer Email: " + customer.Email, font, XBrushes.Black, 20, 70);
            gfx.DrawString("Date: " + DateTime.Now.ToString("MM/dd/yyyy"), font, XBrushes.Black, 20, 90);

            // Add table header
            gfx.DrawString("Book Title", font, XBrushes.Black, 20, 120);
            gfx.DrawString("Price", font, XBrushes.Black, 200, 120);
            gfx.DrawString("Quantity", font, XBrushes.Black, 300, 120);
            gfx.DrawString("Subtotal", font, XBrushes.Black, 400, 120);

            // Write each book and subtotal to the document
            decimal totalAmount = 0;
            int yPosition = 140;

            foreach (var row in salesData)
            {
                Console.Write(salesData);
                string bookTitle = row.Cells["Title"].Value.ToString();
                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                decimal subtotal = price * quantity;

                gfx.DrawString(bookTitle, font, XBrushes.Black, 20, yPosition);
                gfx.DrawString(price.ToString("C"), font, XBrushes.Black, 200, yPosition);
                gfx.DrawString(quantity.ToString(), font, XBrushes.Black, 300, yPosition);
                gfx.DrawString(subtotal.ToString("C"), font, XBrushes.Black, 400, yPosition);

                totalAmount += subtotal;
                yPosition += 20;
            }

            // Apply discount and calculate final amount
            decimal discountAmount = (discount / 100) * totalAmount;
            decimal finalAmount = totalAmount - discountAmount;

            gfx.DrawString($"Total Amount: {totalAmount:C}", font, XBrushes.Black, 20, yPosition + 20);
            gfx.DrawString($"Discount: {discountAmount:C}", font, XBrushes.Black, 20, yPosition + 40);
            gfx.DrawString($"Final Amount: {finalAmount:C}", font, XBrushes.Black, 20, yPosition + 60);

            // Save the PDF to the file
            document.Save(billFilePath);

            return billFilePath;
        }
        

        public void SendBillEmail(string customerEmail, string billFilePath)
        {
            try
            {
                var fromAddress = new MailAddress("uminduchethiya@gmail.com", "BookHaven");
                var toAddress = new MailAddress(customerEmail);  // Recipient email
                const string subject = "Your Sales Transaction Bill";
                const string body = "Please find attached your sales transaction bill.";

                using (var smtp = new SmtpClient("smtp.gmail.com"))
                {
                    smtp.Credentials = new NetworkCredential("uminduchethiya@gmail.com", "bcgjguscujhvknor");  // Your email and password
                    smtp.EnableSsl = true;
                    smtp.Port = 587;  // SMTP port for Gmail

                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        // Attach the generated bill PDF
                        message.Attachments.Add(new Attachment(billFilePath));

                        smtp.Send(message);  // Send the email
                    }
                }

                Console.WriteLine("Bill sent successfully to customer.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending email: {ex.Message}");
            }
        
        }

        public void ReduceStock(List<DataGridViewRow> salesData)
        {
            foreach (var row in salesData)
            {
                int bookId = Convert.ToInt32(row.Cells["BookId"].Value);
                int quantitySold = Convert.ToInt32(row.Cells["Quantity"].Value);

                // Update the stock in the Books table (assuming UpdateBookStock method is in the repository)
                _bookRepository.UpdateStock(bookId, quantitySold);
            }
        }

        public void InsertTransactionRecord(Customer customer, List<DataGridViewRow> salesData, decimal totalAmount, decimal discount)
        {
            decimal discountAmount = (discount / 100) * totalAmount;
            decimal finalAmount = totalAmount - discountAmount;

            // Create a new transaction record in CustomerTransactions table
            var transaction = new CustomerTransactions
            {
                CustomerId = customer.CustomerId,
                TotalAmount = totalAmount,
                DiscountAmount = discountAmount,
                FinalAmount = finalAmount,
                Date = DateTime.Now,
            };

            // Insert the transaction record and get the generated CustomerTransactionId
            var customerTransactionId = _salesRepository.InsertTransactionRecord(transaction);

            // Now that we have the CustomerTransactionId, we can use it in the details table
            foreach (var row in salesData)
            {
                string bookTitle = row.Cells["Title"].Value.ToString();
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                decimal subtotal = quantity * price;

                // Create the SalesTransactionDetails object
                var transactionDetail = new SalesTransactionDetails
                {
                    CustomerTransactionId = customerTransactionId,  // Use the generated CustomerTransactionId
                    BookId = Convert.ToInt32(row.Cells["BookId"].Value),  // Assuming the BookId is present in the DataGridView
                    BookTitle = bookTitle,
                    Quantity = quantity,
                    Price = price,
                    Subtotal = subtotal,
                    CreatedAt = DateTime.Now  // Set the CreatedAt timestamp
                };

                Console.WriteLine(transactionDetail.CustomerTransactionId);

                // Insert the transaction details into SalesTransactionDetails table
                _salesRepository.InsertTransactionDetail(transactionDetail);
            }
        }



    }
}
