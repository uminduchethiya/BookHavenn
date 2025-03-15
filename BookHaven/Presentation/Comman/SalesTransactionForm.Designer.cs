namespace BookHaven.Presentation.Comman
{
    partial class SalesTransactionForm
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            BookId = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            btnAddCustomer = new Button();
            label4 = new Label();
            lblTotalAmount = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            lblDiscountedAmount = new Label();
            btnDelete = new Button();
            btnClear = new Button();
            btnGenarateBill = new Button();
            label7 = new Label();
            cmbsearchcustomers = new ComboBox();
            showamout = new Label();
            lblFinalAamount = new Label();
            cmbSearchBooks = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            lblName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 147);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 1;
            label1.Text = "Search Book";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, -2);
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
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(386, 17);
            label2.Name = "label2";
            label2.Size = new Size(310, 37);
            label2.TabIndex = 5;
            label2.Text = "Sales Transactions";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(517, 145);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 5;
            label3.Text = "Search Customer";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BookId, Title, Price, Quantity, Subtotal });
            dataGridView1.Location = new Point(43, 180);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(543, 449);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // BookId
            // 
            BookId.HeaderText = "BookId";
            BookId.Name = "BookId";
            // 
            // Title
            // 
            Title.HeaderText = "BookTitle";
            Title.Name = "Title";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = SystemColors.ActiveCaption;
            btnAddCustomer.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddCustomer.Location = new Point(832, 77);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(124, 46);
            btnAddCustomer.TabIndex = 8;
            btnAddCustomer.Text = "Add New Customer";
            btnAddCustomer.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(670, 425);
            label4.Name = "label4";
            label4.Size = new Size(93, 17);
            label4.TabIndex = 9;
            label4.Text = "Total Amount";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.ForeColor = SystemColors.ActiveCaptionText;
            lblTotalAmount.Location = new Point(832, 421);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(114, 21);
            lblTotalAmount.TabIndex = 10;
            lblTotalAmount.Text = "Total Amount";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(669, 461);
            label6.Name = "label6";
            label6.Size = new Size(94, 17);
            label6.TabIndex = 11;
            label6.Text = "Discount Rate";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "5", "10", "15" });
            comboBox1.Location = new Point(805, 460);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(670, 498);
            label5.Name = "label5";
            label5.Size = new Size(132, 17);
            label5.TabIndex = 13;
            label5.Text = "Discounted Amount";
            // 
            // lblDiscountedAmount
            // 
            lblDiscountedAmount.AutoSize = true;
            lblDiscountedAmount.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiscountedAmount.ForeColor = Color.Black;
            lblDiscountedAmount.Location = new Point(832, 498);
            lblDiscountedAmount.Name = "lblDiscountedAmount";
            lblDiscountedAmount.Size = new Size(117, 17);
            lblDiscountedAmount.TabIndex = 14;
            lblDiscountedAmount.Text = "Discount Amount";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(647, 598);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(856, 598);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 32);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnGenarateBill
            // 
            btnGenarateBill.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenarateBill.Location = new Point(741, 598);
            btnGenarateBill.Name = "btnGenarateBill";
            btnGenarateBill.Size = new Size(100, 32);
            btnGenarateBill.TabIndex = 17;
            btnGenarateBill.Text = "Genarate Bill";
            btnGenarateBill.UseVisualStyleBackColor = true;
            btnGenarateBill.Click += btnGenarateBill_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(932, 463);
            label7.Name = "label7";
            label7.Size = new Size(17, 15);
            label7.TabIndex = 18;
            label7.Text = "%";
            // 
            // cmbsearchcustomers
            // 
            cmbsearchcustomers.FormattingEnabled = true;
            cmbsearchcustomers.Location = new Point(647, 139);
            cmbsearchcustomers.Name = "cmbsearchcustomers";
            cmbsearchcustomers.Size = new Size(309, 23);
            cmbsearchcustomers.TabIndex = 20;
            cmbsearchcustomers.SelectedIndexChanged += cmbsearchcustomers_SelectedIndexChanged;
            cmbsearchcustomers.TextChanged += cmbsearchcustomers_TextChanged;
            // 
            // showamout
            // 
            showamout.AutoSize = true;
            showamout.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showamout.Location = new Point(670, 542);
            showamout.Name = "showamout";
            showamout.Size = new Size(132, 17);
            showamout.TabIndex = 21;
            showamout.Text = "Discounted Amount";
            // 
            // lblFinalAamount
            // 
            lblFinalAamount.AutoSize = true;
            lblFinalAamount.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFinalAamount.ForeColor = SystemColors.ActiveCaptionText;
            lblFinalAamount.Location = new Point(857, 542);
            lblFinalAamount.Name = "lblFinalAamount";
            lblFinalAamount.Size = new Size(92, 17);
            lblFinalAamount.TabIndex = 22;
            lblFinalAamount.Text = "Final Amount";
            // 
            // cmbSearchBooks
            // 
            cmbSearchBooks.FormattingEnabled = true;
            cmbSearchBooks.Location = new Point(156, 137);
            cmbSearchBooks.Name = "cmbSearchBooks";
            cmbSearchBooks.Size = new Size(300, 23);
            cmbSearchBooks.TabIndex = 23;
            cmbSearchBooks.SelectedIndexChanged += cmbSearchBooks_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(47, 23);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 24;
            label8.Text = "Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(50, 66);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 25;
            label9.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(47, 109);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 26;
            label10.Text = "Phone";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(143, 23);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 15);
            lblName.TabIndex = 27;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(143, 66);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(0, 15);
            lblEmail.TabIndex = 28;
            lblEmail.Click += label12_Click;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(143, 109);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(0, 15);
            lblPhone.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(lblName);
            panel2.Controls.Add(lblEmail);
            panel2.Controls.Add(lblPhone);
            panel2.Location = new Point(647, 180);
            panel2.Name = "panel2";
            panel2.Size = new Size(309, 160);
            panel2.TabIndex = 30;
            // 
            // SalesTransactionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(cmbSearchBooks);
            Controls.Add(lblFinalAamount);
            Controls.Add(showamout);
            Controls.Add(cmbsearchcustomers);
            Controls.Add(label7);
            Controls.Add(btnGenarateBill);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(lblDiscountedAmount);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(lblTotalAmount);
            Controls.Add(label4);
            Controls.Add(btnAddCustomer);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MaximizeBox = false;
            Name = "SalesTransactionForm";
            Text = "SalesTransactionForm";
            Load += SalesTransactionForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private Button btnAddCustomer;
        private Label label4;
        private Label lblTotalAmount;
        private Label label6;
        private ComboBox comboBox1;
        private Label label5;
        private Label lblDiscountedAmount;
        private Button btnDelete;
        private Button btnClear;
        private Button btnGenarateBill;
        private Label label7;
        private ComboBox cmbsearchcustomers;
        private Label showamout;
        private Label lblFinalAamount;
        private ComboBox cmbSearchBooks;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label lblName;
        private Label lblEmail;
        private Label lblPhone;
        private Panel panel2;
        private DataGridViewTextBoxColumn BookId;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Subtotal;
        private PictureBox pictureBox1;
    }
}
