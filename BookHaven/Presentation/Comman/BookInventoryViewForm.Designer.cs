namespace BookHaven.Presentation.Comman
{
    partial class BookInventoryViewForm
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
            dataGridView1 = new DataGridView();
            txtsearch = new TextBox();
            txtTitle = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            btnDelete = new Button();
            btnUpdate = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtIsbn = new TextBox();
            txtCategory = new TextBox();
            txtAuthor = new TextBox();
            btnAddBook = new Button();
            label8 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(303, 12);
            label1.Name = "label1";
            label1.Size = new Size(449, 37);
            label1.TabIndex = 0;
            label1.Text = "Book Inventory Management";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(103, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(742, 286);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(700, 138);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(262, 23);
            txtsearch.TabIndex = 2;
            txtsearch.TextChanged += txtsearch_TextChanged;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(142, 15);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(233, 23);
            txtTitle.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 23);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 4;
            label2.Text = "Title :";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtQuantity);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(txtIsbn);
            panel1.Controls.Add(txtCategory);
            panel1.Controls.Add(txtAuthor);
            panel1.Controls.Add(txtTitle);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(38, 471);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 246);
            panel1.TabIndex = 5;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(565, 193);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 40);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.MenuHighlight;
            btnUpdate.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(275, 193);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 40);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(479, 23);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 14;
            label7.Text = "Author :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(479, 76);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 13;
            label6.Text = "ISBN :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(479, 129);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 12;
            label5.Text = "Quantity :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(56, 129);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 11;
            label4.Text = "Price :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 71);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 10;
            label3.Text = "Category :";
            // 
            // txtQuantity
            // 
            txtQuantity.Enabled = false;
            txtQuantity.Location = new Point(565, 126);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(233, 23);
            txtQuantity.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(142, 126);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(233, 23);
            txtPrice.TabIndex = 8;
            // 
            // txtIsbn
            // 
            txtIsbn.Enabled = false;
            txtIsbn.Location = new Point(565, 68);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(233, 23);
            txtIsbn.TabIndex = 7;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(142, 68);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(233, 23);
            txtCategory.TabIndex = 6;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(565, 15);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(233, 23);
            txtAuthor.TabIndex = 5;
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = SystemColors.ActiveCaption;
            btnAddBook.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddBook.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddBook.Location = new Point(862, 76);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(100, 40);
            btnAddBook.TabIndex = 6;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(603, 141);
            label8.Name = "label8";
            label8.Size = new Size(88, 16);
            label8.TabIndex = 7;
            label8.Text = "Search Book";
            label8.Click += label8_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1008, 70);
            panel2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.left_arrow_10117838;
            pictureBox1.Location = new Point(17, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // BookInventoryViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(label8);
            Controls.Add(btnAddBook);
            Controls.Add(panel1);
            Controls.Add(txtsearch);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            MaximizeBox = false;
            Name = "BookInventoryViewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookInventoryViewForm";
            Load += BookInventoryViewForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtsearch;
        private TextBox txtTitle;
        private Label label2;
        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtIsbn;
        private TextBox txtCategory;
        private TextBox txtAuthor;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAddBook;
        private Label label8;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}