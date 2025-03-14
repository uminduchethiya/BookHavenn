namespace BookHaven.Presentation.Staff
{
    partial class SalesReportDaily
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
            dgvDailySales = new DataGridView();
            btnExport = new Button();
            btnBack = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvDailySales).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(382, 18);
            label1.Name = "label1";
            label1.Size = new Size(300, 37);
            label1.TabIndex = 0;
            label1.Text = "Daily Sales Report";
            // 
            // dgvDailySales
            // 
            dgvDailySales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDailySales.Location = new Point(99, 106);
            dgvDailySales.Name = "dgvDailySales";
            dgvDailySales.Size = new Size(838, 497);
            dgvDailySales.TabIndex = 1;
            // 
            // btnExport
            // 
            btnExport.BackColor = SystemColors.MenuHighlight;
            btnExport.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.Location = new Point(451, 645);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(130, 42);
            btnExport.TabIndex = 2;
            btnExport.Text = "Export To Excel";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Visible = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(61, 629);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(170, 23);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back To Dashboard";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Visible = false;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
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
            // 
            // SalesReportDaily
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Controls.Add(btnExport);
            Controls.Add(dgvDailySales);
            Name = "SalesReportDaily";
            Text = "SalesReportDaily";
            Load += SalesReportDaily_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDailySales).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dgvDailySales;
        private Button btnExport;
        private Button btnBack;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}