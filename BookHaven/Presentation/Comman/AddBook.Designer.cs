namespace BookHaven.Presentation.Comman
{
    partial class AddBook
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtIsbn = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            cmbCategory = new ComboBox();
            panel1 = new Panel();
            label8 = new Label();
            btnInventoryManagement = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(477, 18);
            label1.Name = "label1";
            label1.Size = new Size(165, 37);
            label1.TabIndex = 0;
            label1.Text = "Add Book";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 147);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(471, 147);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(471, 204);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 3;
            label4.Text = "ISBN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 209);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 4;
            label5.Text = "Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(471, 276);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 5;
            label6.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(13, 276);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 6;
            label7.Text = "Stock";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(86, 144);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(309, 23);
            txtTitle.TabIndex = 7;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(596, 144);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(309, 23);
            txtAuthor.TabIndex = 8;
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(596, 201);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(309, 23);
            txtIsbn.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(596, 273);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(309, 23);
            txtPrice.TabIndex = 11;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(86, 273);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(309, 23);
            txtStock.TabIndex = 12;
            txtStock.TextChanged += txtStock_TextChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.MenuHighlight;
            btnSave.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(383, 416);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 40);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(562, 416);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Clear";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Fiction", "Non-Fiction", "Science Fiction", "Fantasy", "Mystery", "Thriller", "Romance", "Horror", "Historical", "Biography", "Self-Help", "Philosophy", "Psychology", "Health & Wellness", "Business", "Finance", "Technology", "Education", "Science", "Mathematics", "Poetry", "Drama", "Religion & Spirituality", "Travel", "Cookbooks", "Art & Photography", "Comics & Graphic Novels", "Children’s Books", "Young Adult", "Sports & Outdoors" });
            cmbCategory.Location = new Point(86, 206);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(309, 23);
            cmbCategory.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(cmbCategory);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(txtTitle);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtAuthor);
            panel1.Controls.Add(txtIsbn);
            panel1.Controls.Add(txtStock);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(31, 159);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 548);
            panel1.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(396, 37);
            label8.Name = "label8";
            label8.Size = new Size(137, 24);
            label8.TabIndex = 16;
            label8.Text = "Book Details";
            // 
            // btnInventoryManagement
            // 
            btnInventoryManagement.BackColor = SystemColors.ActiveCaption;
            btnInventoryManagement.Location = new Point(851, 85);
            btnInventoryManagement.Name = "btnInventoryManagement";
            btnInventoryManagement.Size = new Size(128, 44);
            btnInventoryManagement.TabIndex = 0;
            btnInventoryManagement.Text = " Inventory Management";
            btnInventoryManagement.UseVisualStyleBackColor = false;
            btnInventoryManagement.Click += btnInventoryManagement_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1009, 69);
            panel2.TabIndex = 18;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.left_arrow_10117838;
            pictureBox2.Location = new Point(10, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(btnInventoryManagement);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "AddBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBook";
            Load += AddBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtIsbn;
        private TextBox txtPrice;
        private TextBox txtStock;
        private Button btnSave;
        private Button btnCancel;
        private ComboBox cmbCategory;
        private Panel panel1;
        private Button btnInventoryManagement;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label8;
    }
}