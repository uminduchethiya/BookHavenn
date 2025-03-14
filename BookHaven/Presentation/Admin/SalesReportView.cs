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
using BookHaven.Presentation.Comman;
using OfficeOpenXml;

namespace BookHaven.Presentation.Admin
{
    public partial class SalesReportView : Form
    {
        private readonly IReportManagementService _reportManagementService;
        private readonly SalesTransactionService _salesTransactionService;


        public SalesReportView()
        {
            InitializeComponent();
            _reportManagementService = new ReportManagementService(new ReportManagementRepository());

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Open a SaveFileDialog to allow the user to choose the location and file name for the export
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xls;*.xlsx",
                FileName = "Sales_Report.xlsx"
            };

            // Show the dialog and check if the user selected a location
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Call the ExportDataGridViewToExcel method to export the data
                ExportDataGridViewToExcel(dataGridView1, saveFileDialog.FileName);

                // Show a message that the export was successful
                MessageBox.Show("Report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnGenarate_Click(object sender, EventArgs e)
        {
            // Get the selected start and end dates from the DateTimePickers
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            // Call the service to get the sales summary
            var salesSummary = await _reportManagementService.GetSalesSummary(startDate, endDate);

            // Check if data is returned
            if (salesSummary != null && salesSummary.Count > 0)
            {
                // Bind the data to the DataGridView
                dataGridView1.DataSource = salesSummary;
            }
            else
            {
                // If no data found, show a message
                MessageBox.Show("No sales data found for the selected date range.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            reportDashboard.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            ReportDashboard reportDashboard = new ReportDashboard();
            reportDashboard.Show();  // To show the AdminDashboard form
            this.Hide();  // Optionally hide the current form
        }
    }
}
