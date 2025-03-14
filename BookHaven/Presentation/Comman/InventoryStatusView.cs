using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHaven.Business.Interfaces;
using BookHaven.Business.Services;
using BookHaven.Data.Repositories.ReportManagementRepository;
using BookHaven.Presentation.Admin;
using OfficeOpenXml;

namespace BookHaven.Presentation.Comman
{
    public partial class InventoryStatusView : Form
    {
        private readonly IReportManagementService _reportManagementService;
        public InventoryStatusView()
        {
            InitializeComponent();
            _reportManagementService = new ReportManagementService(new ReportManagementRepository());
        }

        private async void btnGenarate_Click(object sender, EventArgs e)
        {
            // Call the service to get the inventory status
            var inventoryStatus = await _reportManagementService.GetInventoryStatus();

            // Check if data is returned
            if (inventoryStatus != null && inventoryStatus.Count > 0)
            {
                // Bind the data to the DataGridView
                dataGridView1.DataSource = inventoryStatus;
            }
            else
            {
                MessageBox.Show("No data found for inventory status.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            // Create an Excel file and export the data from the DataGridView
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
            saveFileDialog.FileName = "Inventory_Status_Report.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Export the DataGridView to Excel
                ExportDataGridViewToExcel(dataGridView1, saveFileDialog.FileName);

                // Show a confirmation message
                MessageBox.Show("Report successfully exported!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ExportDataGridViewToExcel(DataGridView dataGridView, string filePath)
        {
            // Set the license context
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            // Initialize the ExcelPackage to create the Excel file
            using (var package = new ExcelPackage())
            {
                // Add a worksheet to the ExcelPackage
                var worksheet = package.Workbook.Worksheets.Add("SalesReport");

                // Add headers
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dataGridView.Columns[i].HeaderText;
                }

                // Add data
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dataGridView.Rows[i].Cells[j].Value;
                    }
                }

                // Save the file
                var file = new FileInfo(filePath);
                package.SaveAs(file);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ReportDashboard reportDashboard = new ReportDashboard();
            reportDashboard.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            ReportDashboard reportDashboard = new ReportDashboard();
            reportDashboard.Show();  // To show the AdminDashboard form
            this.Hide();  // Optionally hide the current form
        }
    }
}
