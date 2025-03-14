using BookHaven.Business.Interfaces;
using BookHaven.Data.Models;
using BookHaven.Presentation.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHaven.Presentation.Comman
{
    public partial class OrderManage : Form
    {
        private readonly IOrderManagementService _orderService;
        private int? _selectedOrderId;  // Store the selected order ID for updating
        public OrderManage(IOrderManagementService orderService)
        {
            InitializeComponent();
            _orderService = orderService;
            InitializeDataGridViews();
            LoadOrderIds();
            cmbsearchorder.KeyDown += Cmbsearchorder_KeyDown;  // Attach the event handler here
        }
        private void LoadOrderIds()
        {
            cmbsearchorder.Items.Clear();
            List<Order> orders = _orderService.GetAllOrders();  // Fetch all orders

            if (orders != null && orders.Count > 0)
            {
                foreach (var order in orders)
                {
                    cmbsearchorder.Items.Add(order.OrderId);  // Populate combobox
                }
            }
        }



        private void InitializeDataGridViews()
        {
            dtgorder.Columns.Clear();
            dtgorder.AutoGenerateColumns = false;

            dtgorder.Columns.Add("OrderId", "Order ID");
            dtgorder.Columns.Add("CustomerId", "Customer ID");
            dtgorder.Columns.Add("BookId", "Book ID");
            dtgorder.Columns.Add("Quantity", "Quantity");
            dtgorder.Columns.Add("Price", "Price");
            dtgorder.Columns.Add("Subtotal", "Subtotal");
            dtgorder.Columns.Add("DeliveryType", "Delivery Type");
            dtgorder.Columns.Add("Status", "Status");
            dtgorder.Columns.Add("OrderDate", "Order Date");
        }

        private void cmbsearchorder_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Check if the Order ID is valid
            if (string.IsNullOrEmpty(cmbsearchorder.Text))
            {
                MessageBox.Show("Please enter a valid Order ID.");
                return;
            }

            if (int.TryParse(cmbsearchorder.Text, out int orderId))
            {
                Order selectedOrder = _orderService.GetOrderById(orderId);

                if (selectedOrder != null)
                {
                    // Display order details
                    dtgorder.Rows.Clear();
                    dtgorder.Rows.Add(
                        selectedOrder.OrderId,
                        selectedOrder.CustomerId,
                        selectedOrder.BookId,
                        selectedOrder.Quantity,
                        selectedOrder.Price,
                        selectedOrder.Subtotal,
                        selectedOrder.DeliveryType,
                        selectedOrder.Status,
                        selectedOrder.OrderDate
                    );

                    // Store the selected order's ID
                    _selectedOrderId = selectedOrder.OrderId;

                    // Populate the ComboBox with available statuses
                    cmborderstatus.Items.Clear();
                    cmborderstatus.Items.Add("Pending");
                    cmborderstatus.Items.Add("Completed");
                    cmborderstatus.Items.Add("Canceled");

                    // Set the current status in the ComboBox
                    cmborderstatus.SelectedItem = selectedOrder.Status;
                }
                else
                {
                    MessageBox.Show("Order not found.");
                }
            }
            else
            {
                MessageBox.Show("Invalid Order ID.");
            }

        }

        private void Cmbsearchorder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbsearchorder_SelectedIndexChanged(sender, e);  // Call the method when Enter is pressed
            }
        }
        private void dtgorder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var orderId = dtgorder.Rows[e.RowIndex].Cells["OrderId"].Value;
                if (orderId != null && int.TryParse(orderId.ToString(), out int selectedOrderId))
                {
                    Order selectedOrder = _orderService.GetOrderById(selectedOrderId);
                    if (selectedOrder != null)
                    {
                        MessageBox.Show($"Order Details:\nOrder ID: {selectedOrder.OrderId}\nCustomer ID: {selectedOrder.CustomerId}");
                    }
                }
            }
        }

        private void cmborderstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (_selectedOrderId == null)
            {
                MessageBox.Show("Please select an order to update.");
                return;
            }

            var selectedStatus = cmborderstatus.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedStatus))
            {
                MessageBox.Show("Please select a valid status.");
                return;
            }

            Order selectedOrder = _orderService.GetOrderById((int)_selectedOrderId);
            if (selectedOrder != null)
            {
                // Check if the new status is "Completed"
                bool isCompleted = selectedStatus == "Completed";

                // Update the status
                selectedOrder.Status = selectedStatus;

                // Call the service to update the order in the database
                bool updateSuccess = _orderService.UpdateOrderStatus(selectedOrder);

                if (updateSuccess)
                {
                    if (isCompleted)
                    {
                        // Reduce stock quantity
                        bool stockUpdated = _orderService.UpdateBookStock(selectedOrder.BookId, selectedOrder.Quantity);
                        if (!stockUpdated)
                        {
                            MessageBox.Show("Warning: Unable to reduce stock quantity.");
                        }
                    }

                    MessageBox.Show("Order status updated successfully.");
                    LoadOrderIds();  // Reload order IDs
                    cmbsearchorder.SelectedIndex = -1;
                    dtgorder.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Failed to update the order status.");
                }
            }
            else
            {
                MessageBox.Show("Order not found.");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();  // To show the AdminDashboard form
            this.Hide();  // Optionally hide the current form
        }

        private void OrderManage_Load(object sender, EventArgs e)
        {

        }

        private void btnaddnewcustomer_Click(object sender, EventArgs e)
        {

            AddCustomer addCustomerForm = new AddCustomer();
            this.Hide();
            addCustomerForm.Show();
        }

        private void btnaddneworder_Click(object sender, EventArgs e)
        {
            OrderAdd orderAdd = new OrderAdd();
            orderAdd.Show();
            this.Hide();
        }
    }

}
