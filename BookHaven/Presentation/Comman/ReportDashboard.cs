using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHaven.Presentation.Admin;

namespace BookHaven.Presentation.Comman
{
    public partial class ReportDashboard : Form
    {
        public ReportDashboard()
        {
            InitializeComponent();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            SalesReportView salesReportDaily = new SalesReportView();
            salesReportDaily.ShowDialog();
            this.Close();

        }

        private void btnBestBooksSelling_Click(object sender, EventArgs e)
        {
            MostBooksSaleView mostBooksSaleView = new MostBooksSaleView();
            mostBooksSaleView.ShowDialog();
            this.Close();
        }

        private void btnInventoryStatus_Click(object sender, EventArgs e)
        {
            BookInventoryViewForm bookInventoryViewForm = new BookInventoryViewForm();
            bookInventoryViewForm.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();  // To show the AdminDashboard form
            this.Hide();  // Optionally hide the current form

        }
    }
}
