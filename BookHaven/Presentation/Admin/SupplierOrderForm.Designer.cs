namespace BookHaven.Presentation.Admin
{
    partial class SupplierOrderForm
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            cmbsupplier = new ComboBox();
            dtgsupplierorder = new DataGridView();
            btnplaceorder = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            txtnewstock = new TextBox();
            btnupdatestatus = new Button();
            dtgorderreq = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgsupplierorder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgorderreq).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 69);
            panel1.TabIndex = 0;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(370, 19);
            label1.Name = "label1";
            label1.Size = new Size(335, 29);
            label1.TabIndex = 0;
            label1.Text = "Supplier Order Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(257, 90);
            label2.Name = "label2";
            label2.Size = new Size(118, 16);
            label2.TabIndex = 1;
            label2.Text = "Search Supplier :";
            // 
            // cmbsupplier
            // 
            cmbsupplier.FormattingEnabled = true;
            cmbsupplier.Location = new Point(400, 88);
            cmbsupplier.Name = "cmbsupplier";
            cmbsupplier.Size = new Size(348, 23);
            cmbsupplier.TabIndex = 2;
            cmbsupplier.SelectedIndexChanged += cmbsupplier_SelectedIndexChanged;
            // 
            // dtgsupplierorder
            // 
            dtgsupplierorder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgsupplierorder.Location = new Point(228, 174);
            dtgsupplierorder.Name = "dtgsupplierorder";
            dtgsupplierorder.Size = new Size(552, 113);
            dtgsupplierorder.TabIndex = 3;
            dtgsupplierorder.CellContentClick += dtgsupplierorder_CellContentClick;
            // 
            // btnplaceorder
            // 
            btnplaceorder.BackColor = SystemColors.ActiveCaption;
            btnplaceorder.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnplaceorder.ForeColor = Color.Black;
            btnplaceorder.Location = new Point(642, 624);
            btnplaceorder.Name = "btnplaceorder";
            btnplaceorder.Size = new Size(100, 40);
            btnplaceorder.TabIndex = 4;
            btnplaceorder.Text = "Place Order";
            btnplaceorder.UseVisualStyleBackColor = false;
            btnplaceorder.Click += btnplaceorder_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Pending", "Approved", "Delivered", "Cancelled" });
            comboBox1.Location = new Point(228, 529);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(217, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(126, 532);
            label3.Name = "label3";
            label3.Size = new Size(94, 16);
            label3.TabIndex = 5;
            label3.Text = "Order Status :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(623, 532);
            label4.Name = "label4";
            label4.Size = new Size(82, 16);
            label4.TabIndex = 7;
            label4.Text = "New Stock :";
            // 
            // txtnewstock
            // 
            txtnewstock.Location = new Point(725, 528);
            txtnewstock.Name = "txtnewstock";
            txtnewstock.Size = new Size(197, 23);
            txtnewstock.TabIndex = 8;
            // 
            // btnupdatestatus
            // 
            btnupdatestatus.BackColor = SystemColors.MenuHighlight;
            btnupdatestatus.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdatestatus.ForeColor = Color.White;
            btnupdatestatus.Location = new Point(332, 624);
            btnupdatestatus.Name = "btnupdatestatus";
            btnupdatestatus.Size = new Size(100, 40);
            btnupdatestatus.TabIndex = 9;
            btnupdatestatus.Text = "Updata";
            btnupdatestatus.UseVisualStyleBackColor = false;
            btnupdatestatus.Click += btnupdatestatus_Click;
            // 
            // dtgorderreq
            // 
            dtgorderreq.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgorderreq.Location = new Point(228, 344);
            dtgorderreq.Name = "dtgorderreq";
            dtgorderreq.Size = new Size(552, 113);
            dtgorderreq.TabIndex = 10;
            dtgorderreq.CellContentClick += dtgorderreq_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(440, 140);
            label5.Name = "label5";
            label5.Size = new Size(135, 19);
            label5.TabIndex = 11;
            label5.Text = "Low Stock Book";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(440, 307);
            label6.Name = "label6";
            label6.Size = new Size(133, 19);
            label6.TabIndex = 12;
            label6.Text = "Supplier's Order";
            // 
            // SupplierOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 689);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dtgorderreq);
            Controls.Add(btnupdatestatus);
            Controls.Add(txtnewstock);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(btnplaceorder);
            Controls.Add(dtgsupplierorder);
            Controls.Add(cmbsupplier);
            Controls.Add(label2);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            Name = "SupplierOrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SupplierOrderForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgsupplierorder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgorderreq).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private ComboBox cmbsupplier;
        private DataGridView dtgsupplierorder;
        private Button btnplaceorder;
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private TextBox txtnewstock;
        private Button btnupdatestatus;
        private DataGridView dtgorderreq;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
    }
}