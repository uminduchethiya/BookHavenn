namespace BookHaven.Presentation.Admin
{
    partial class SalesReportView
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
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            btnGenarate = new Button();
            btnExport = new Button();
            btnBack = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(397, 18);
            label1.Name = "label1";
            label1.Size = new Size(231, 37);
            label1.TabIndex = 0;
            label1.Text = "Sales Reports";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(174, 154);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(488, 152);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(200, 23);
            dtpEndDate.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(89, 160);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "Start Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(406, 160);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "End Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(89, 116);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 5;
            label4.Text = "Select Date Range";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(52, 209);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(848, 451);
            dataGridView1.TabIndex = 6;
            // 
            // btnGenarate
            // 
            btnGenarate.BackColor = SystemColors.ActiveCaption;
            btnGenarate.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenarate.Location = new Point(799, 143);
            btnGenarate.Name = "btnGenarate";
            btnGenarate.Size = new Size(101, 48);
            btnGenarate.TabIndex = 7;
            btnGenarate.Text = "Genarate";
            btnGenarate.UseVisualStyleBackColor = false;
            btnGenarate.Click += btnGenarate_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = SystemColors.MenuHighlight;
            btnExport.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(775, 668);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(125, 50);
            btnExport.TabIndex = 8;
            btnExport.Text = "Export As Excel";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(267, 695);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(125, 23);
            btnBack.TabIndex = 9;
            btnBack.Text = "dd";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Visible = false;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 69);
            panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.left_arrow_10117838;
            pictureBox1.Location = new Point(13, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // SalesReportView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Controls.Add(btnExport);
            Controls.Add(btnGenarate);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Name = "SalesReportView";
            Text = "SalesReportView";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private Button btnGenarate;
        private Button btnExport;
        private Button btnBack;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}