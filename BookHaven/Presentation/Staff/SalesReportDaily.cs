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

namespace BookHaven.Presentation.Staff
{
    public partial class SalesReportDaily : Form
    {
        private readonly IReportManagementService _reportManagementService;
        public SalesReportDaily()
        {
            InitializeComponent();
            _reportManagementService = new ReportManagementService(new ReportManagementRepository());
        }

        private async void SalesReportDaily_Load(object sender, EventArgs e)
        {
            {
                // Fetch the daily sales data
                var dailySalesReport = await _reportManagementService.GetSalesSummaryByCurrentDate();

                // Check if any data is returned
                if (dailySalesReport != null && dailySalesReport.Count > 0)
                {
                    // Bind the data to the DataGridView
                    dgvDailySales.DataSource = dailySalesReport;
                }
                else
                {
                    MessageBox.Show("No sales data found for today.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Create an Excel file and export the data from the DataGridView
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
            saveFileDialog.FileName = "Daily_Sales_Report.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Export the DataGridView to Excel
                ExportDataGridViewToExcel(dgvDailySales, saveFileDialog.FileName);

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
            SalesClerkDashboard salesClerkDashboard = new SalesClerkDashboard();
            salesClerkDashboard.ShowDialog();
            this.Close();
        }
    }
}
