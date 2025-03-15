namespace BookHaven.Presentation.Comman
{
    partial class ReportDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnSalesReport = new Button();
            btnBestBooksSelling = new Button();
            btnInventoryStatus = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(381, 17);
            label1.Name = "label1";
            label1.Size = new Size(323, 37);
            label1.TabIndex = 0;
            label1.Text = "Report Management";
            label1.Click += label1_Click;
            // 
            // btnSalesReport
            // 
            btnSalesReport.BackColor = SystemColors.ActiveCaption;
            btnSalesReport.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalesReport.Location = new Point(259, 166);
            btnSalesReport.Name = "btnSalesReport";
            btnSalesReport.Size = new Size(549, 100);
            btnSalesReport.TabIndex = 1;
            btnSalesReport.Text = "Sales Summery";
            btnSalesReport.UseVisualStyleBackColor = false;
            btnSalesReport.Click += btnSalesReport_Click;
            // 
            // btnBestBooksSelling
            // 
            btnBestBooksSelling.BackColor = SystemColors.Highlight;
            btnBestBooksSelling.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBestBooksSelling.Location = new Point(259, 314);
            btnBestBooksSelling.Name = "btnBestBooksSelling";
            btnBestBooksSelling.Size = new Size(549, 100);
            btnBestBooksSelling.TabIndex = 2;
            btnBestBooksSelling.Text = "Best Books Selling";
            btnBestBooksSelling.UseVisualStyleBackColor = false;
            btnBestBooksSelling.Click += btnBestBooksSelling_Click;
            // 
            // btnInventoryStatus
            // 
            btnInventoryStatus.BackColor = SystemColors.MenuHighlight;
            btnInventoryStatus.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventoryStatus.Location = new Point(259, 474);
            btnInventoryStatus.Name = "btnInventoryStatus";
            btnInventoryStatus.Size = new Size(549, 100);
            btnInventoryStatus.TabIndex = 3;
            btnInventoryStatus.Text = "Inventory Status";
            btnInventoryStatus.UseVisualStyleBackColor = false;
            btnInventoryStatus.Click += btnInventoryStatus_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 69);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.left_arrow_10117838;
            pictureBox1.Location = new Point(12, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ReportDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(panel1);
            Controls.Add(btnInventoryStatus);
            Controls.Add(btnBestBooksSelling);
            Controls.Add(btnSalesReport);
            Name = "ReportDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReportDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnSalesReport;
        private Button btnBestBooksSelling;
        private Button btnInventoryStatus;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}