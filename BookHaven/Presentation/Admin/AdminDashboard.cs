using BookHaven.Business.Interfaces;
using BookHaven.Business.Services;
using BookHaven.Data.Repositories;
using BookHaven.Presentation.Comman;
using BookHaven.Utilities;
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
    public partial class AdminDashboard : Form
    {
        private readonly IUserService _userService;
        private int sidebarExpandedWidth = 250; // Full size
        private int sidebarCollapsedWidth = 80; // Minimized size
        private bool isSidebarExpanded = true; // Track sidebar state

        public AdminDashboard()
        {
            _userService = new UserService(new UserManageRepository()); // Fixed Repository Reference
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            AddBook addbook = new AddBook();
            this.Hide();
            addbook.Show();

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            int stepSize = 30; // Increase speed by changing the step size

            if (isSidebarExpanded)
            {
                // Collapse Sidebar Faster
                if (sidebar.Width > sidebarCollapsedWidth)
                {
                    sidebar.Width -= stepSize; // ✅ Faster collapse
                }
                else
                {
                    sidebartimer.Stop();
                    isSidebarExpanded = false;
                }
            }
            else
            {
                // Expand Sidebar Faster
                if (sidebar.Width < sidebarExpandedWidth)
                {
                    sidebar.Width += stepSize; // ✅ Faster expand
                }
                else
                {
                    sidebartimer.Stop();
                    isSidebarExpanded = true;
                }
            }
        }

        private void menupicbox_Click(object sender, EventArgs e)
        {
            sidebartimer.Start(); // ✅ Correct timer reference
        }

        private void btnusers_Click(object sender, EventArgs e)
        {
            if (SessionManager.LoggedInUser == null)
            {
                MessageBox.Show("Please log in first!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SessionManager.LoggedInUser.RoleID == 2)
            {
                MessageBox.Show("You have no permission to access this feature!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AddnewUser addnewUserForm = new AddnewUser();
                this.Hide();
                addnewUserForm.Show();
            }

        }

        private void btnsuppliers_Click(object sender, EventArgs e)
        {
            // Check if the user is logged in
            if (SessionManager.LoggedInUser == null)
            {
                MessageBox.Show("Please log in first!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the user has RoleID 2 (restricted access)
            if (SessionManager.LoggedInUser.RoleID == 2)
            {
                MessageBox.Show("You do not have permission to access this feature!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create an instance of the AddSupplier form
            AddSupplier addSupplierForm = new AddSupplier();

            // Hide the AdminDashboard form
            this.Hide();

            // Show the AddSupplier form
            addSupplierForm.Show();
        }

        private void btnorderrequest_Click(object sender, EventArgs e)
        {
            // Create an instance of ISupplierOrderManagementService
            ISupplierOrderManagementService supplierOrderService = new SupplierOrderManagementService();

            // Create an instance of SupplierOrderForm and pass the service
            SupplierOrderForm supplierOrderForm = new SupplierOrderForm(supplierOrderService);


            // Hide the AdminDashboard form
            this.Hide();


            // Show the SupplierOrderForm (non-blocking, new window)
            supplierOrderForm.Show();
        }

        private void btnordermanagement_Click(object sender, EventArgs e)
        {
            // Create an instance of the OrderAdd form
            OrderAdd orderAddForm = new OrderAdd();
            // Hide the AdminDashboard form
            this.Hide();

            // Show the OrderAdd form (non-blocking, new window)
            orderAddForm.Show();
        }

        private void btncustomers_Click(object sender, EventArgs e)
        {

            AddCustomer addCustomerForm = new AddCustomer();

            this.Hide();
            addCustomerForm.Show();
        }

        private void btnsalestransaction_Click(object sender, EventArgs e)
        {
            SalesTransactionForm salesTransActionForm = new SalesTransactionForm();

            this.Hide();
            salesTransActionForm.Show();
        }

        private void btnreporting_Click(object sender, EventArgs e)
        {
            ReportDashboard reportDashboard = new ReportDashboard();

            this.Hide();
            reportDashboard.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            LoginForm  loginForm = new LoginForm();

            this.Hide();
            loginForm.Show();
        }
    }
}
