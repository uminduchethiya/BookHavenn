namespace BookHaven.Presentation.Comman
{
    partial class OrderManage
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
            cmbsearchorder = new ComboBox();
            btnaddneworder = new Button();
            btnaddnewcustomer = new Button();
            dtgorder = new DataGridView();
            btndelete = new Button();
            btnupdate = new Button();
            cmborderstatus = new ComboBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgorder).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 69);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.left_arrow_10117838;
            pictureBox1.Location = new Point(10, 16);
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
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(403, 16);
            label1.Name = "label1";
            label1.Size = new Size(232, 37);
            label1.TabIndex = 0;
            label1.Text = "Manage Order";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 117);
            label2.Name = "label2";
            label2.Size = new Size(116, 16);
            label2.TabIndex = 1;
            label2.Text = "Order Id Search :";
            // 
            // cmbsearchorder
            // 
            cmbsearchorder.FormattingEnabled = true;
            cmbsearchorder.Location = new Point(206, 115);
            cmbsearchorder.Name = "cmbsearchorder";
            cmbsearchorder.Size = new Size(205, 23);
            cmbsearchorder.TabIndex = 2;
            cmbsearchorder.SelectedIndexChanged += cmbsearchorder_SelectedIndexChanged;
            // 
            // btnaddneworder
            // 
            btnaddneworder.BackColor = SystemColors.ActiveCaption;
            btnaddneworder.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnaddneworder.Location = new Point(667, 105);
            btnaddneworder.Name = "btnaddneworder";
            btnaddneworder.Size = new Size(133, 40);
            btnaddneworder.TabIndex = 3;
            btnaddneworder.Text = "Add New Order";
            btnaddneworder.UseVisualStyleBackColor = false;
            btnaddneworder.Click += btnaddneworder_Click;
            // 
            // btnaddnewcustomer
            // 
            btnaddnewcustomer.BackColor = SystemColors.ActiveCaption;
            btnaddnewcustomer.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnaddnewcustomer.Location = new Point(833, 105);
            btnaddnewcustomer.Name = "btnaddnewcustomer";
            btnaddnewcustomer.Size = new Size(138, 40);
            btnaddnewcustomer.TabIndex = 4;
            btnaddnewcustomer.Text = "Add New Customer";
            btnaddnewcustomer.UseVisualStyleBackColor = false;
            btnaddnewcustomer.Click += btnaddnewcustomer_Click;
            // 
            // dtgorder
            // 
            dtgorder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgorder.Location = new Point(56, 208);
            dtgorder.Name = "dtgorder";
            dtgorder.Size = new Size(915, 219);
            dtgorder.TabIndex = 5;
            dtgorder.CellContentClick += dtgorder_CellContentClick;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.Red;
            btndelete.FlatStyle = FlatStyle.Flat;
            btndelete.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.ForeColor = Color.White;
            btndelete.Location = new Point(604, 609);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(100, 40);
            btndelete.TabIndex = 6;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = SystemColors.MenuHighlight;
            btnupdate.FlatStyle = FlatStyle.Flat;
            btnupdate.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdate.ForeColor = Color.White;
            btnupdate.Location = new Point(332, 609);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(100, 40);
            btnupdate.TabIndex = 7;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // cmborderstatus
            // 
            cmborderstatus.FormattingEnabled = true;
            cmborderstatus.Items.AddRange(new object[] { "Pending", "Completed", "Canceled" });
            cmborderstatus.Location = new Point(160, 495);
            cmborderstatus.Name = "cmborderstatus";
            cmborderstatus.Size = new Size(205, 23);
            cmborderstatus.TabIndex = 8;
            cmborderstatus.SelectedIndexChanged += cmborderstatus_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 497);
            label3.Name = "label3";
            label3.Size = new Size(98, 16);
            label3.TabIndex = 9;
            label3.Text = "Order Status  :";
            // 
            // OrderManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(label3);
            Controls.Add(cmborderstatus);
            Controls.Add(btnupdate);
            Controls.Add(btndelete);
            Controls.Add(dtgorder);
            Controls.Add(btnaddnewcustomer);
            Controls.Add(btnaddneworder);
            Controls.Add(cmbsearchorder);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "OrderManage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderManage";
            Load += OrderManage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgorder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private ComboBox cmbsearchorder;
        private Button btnaddneworder;
        private Button btnaddnewcustomer;
        private DataGridView dtgorder;
        private Button btndelete;
        private Button btnupdate;
        private ComboBox cmborderstatus;
        private Label label3;
        private PictureBox pictureBox1;
    }
}