namespace BookHaven.Data.Models
{
    public class Order
    {
        public int OrderId { get; set; }  // Primary key, auto-incremented
        public int CustomerId { get; set; }  // Foreign key referencing Customer
        public int BookId { get; set; }  // Foreign key referencing Book
        public int Quantity { get; set; }  // Quantity of books ordered
        public decimal Price { get; set; }  // Price of a single book
        public string Status { get; set; }  // Order status (e.g., "Pending", "Shipped")
        public string DeliveryType { get; set; }  
        public DateTime OrderDate { get; set; }  // Date the order was placed
        public decimal Subtotal { get; set; }  // Total price before any taxes or discounts

        // Navigation properties (optional if you're using an ORM like Entity Framework)
        public Customer Customer { get; set; }  // Navigation to Customer
        public Book Book { get; set; }  // Navigation to Book
    }
}
