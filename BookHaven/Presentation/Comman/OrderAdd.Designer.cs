namespace BookHaven.Presentation.Comman
{
    partial class OrderAdd
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
            lblname = new Label();
            label1 = new Label();
            cmbsearchphone = new ComboBox();
            cmbsearchbook = new ComboBox();
            label2 = new Label();
            btnaddcustomer = new Button();
            dtgcustomerdeatils = new DataGridView();
            dtgsearchbook = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            txtbookqunity = new TextBox();
            txtbookprice = new TextBox();
            label5 = new Label();
            label6 = new Label();
            lblsubtotal = new Label();
            chkdiliverydetails = new CheckedListBox();
            txtaddress = new TextBox();
            label7 = new Label();
            btnorder = new Button();
            btnmanageorder = new Button();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgcustomerdeatils).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgsearchbook).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblname);
            panel1.ForeColor = SystemColors.Highlight;
            panel1.Location = new Point(0, 1);
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
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblname.ForeColor = Color.White;
            lblname.ImageAlign = ContentAlignment.BottomCenter;
            lblname.Location = new Point(442, 17);
            lblname.Name = "lblname";
            lblname.Size = new Size(174, 37);
            lblname.TabIndex = 0;
            lblname.Text = "Add Order";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(195, 94);
            label1.Name = "label1";
            label1.Size = new Size(169, 16);
            label1.TabIndex = 1;
            label1.Text = "Search Customer Phone :";
            // 
            // cmbsearchphone
            // 
            cmbsearchphone.FormattingEnabled = true;
            cmbsearchphone.Location = new Point(393, 92);
            cmbsearchphone.Name = "cmbsearchphone";
            cmbsearchphone.Size = new Size(338, 23);
            cmbsearchphone.TabIndex = 2;
            cmbsearchphone.SelectedIndexChanged += cmbsearchphone_SelectedIndexChanged;
            // 
            // cmbsearchbook
            // 
            cmbsearchbook.FormattingEnabled = true;
            cmbsearchbook.Location = new Point(393, 269);
            cmbsearchbook.Name = "cmbsearchbook";
            cmbsearchbook.Size = new Size(338, 23);
            cmbsearchbook.TabIndex = 3;
            cmbsearchbook.SelectedIndexChanged += cmbsearchbook_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(195, 276);
            label2.Name = "label2";
            label2.Size = new Size(96, 16);
            label2.TabIndex = 4;
            label2.Text = "Search Book :";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnaddcustomer
            // 
            btnaddcustomer.BackColor = SystemColors.ActiveCaption;
            btnaddcustomer.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnaddcustomer.Location = new Point(814, 86);
            btnaddcustomer.Name = "btnaddcustomer";
            btnaddcustomer.Size = new Size(110, 44);
            btnaddcustomer.TabIndex = 5;
            btnaddcustomer.Text = "Add Customer";
            btnaddcustomer.UseVisualStyleBackColor = false;
            btnaddcustomer.Click += btnaddcustomer_Click;
            // 
            // dtgcustomerdeatils
            // 
            dtgcustomerdeatils.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgcustomerdeatils.Location = new Point(195, 135);
            dtgcustomerdeatils.Name = "dtgcustomerdeatils";
            dtgcustomerdeatils.Size = new Size(536, 102);
            dtgcustomerdeatils.TabIndex = 6;
            dtgcustomerdeatils.CellContentClick += dtgcustomerdeatils_CellContentClick;
            // 
            // dtgsearchbook
            // 
            dtgsearchbook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgsearchbook.Location = new Point(195, 311);
            dtgsearchbook.Name = "dtgsearchbook";
            dtgsearchbook.Size = new Size(536, 105);
            dtgsearchbook.TabIndex = 7;
            dtgsearchbook.CellContentClick += dtgsearchbook_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(393, 471);
            label3.Name = "label3";
            label3.Size = new Size(141, 24);
            label3.TabIndex = 8;
            label3.Text = "Order Details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(48, 532);
            label4.Name = "label4";
            label4.Size = new Size(96, 16);
            label4.TabIndex = 9;
            label4.Text = "Book Quntity :";
            // 
            // txtbookqunity
            // 
            txtbookqunity.Location = new Point(150, 530);
            txtbookqunity.Name = "txtbookqunity";
            txtbookqunity.Size = new Size(242, 23);
            txtbookqunity.TabIndex = 10;
            txtbookqunity.TextChanged += txtbookqunity_TextChanged;
            // 
            // txtbookprice
            // 
            txtbookprice.Location = new Point(540, 535);
            txtbookprice.Name = "txtbookprice";
            txtbookprice.Size = new Size(242, 23);
            txtbookprice.TabIndex = 12;
            txtbookprice.TextChanged += txtbookprice_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(450, 538);
            label5.Name = "label5";
            label5.Size = new Size(84, 16);
            label5.TabIndex = 11;
            label5.Text = "Book Price :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(808, 535);
            label6.Name = "label6";
            label6.Size = new Size(75, 16);
            label6.TabIndex = 13;
            label6.Text = "Sub Total :";
            // 
            // lblsubtotal
            // 
            lblsubtotal.AutoSize = true;
            lblsubtotal.Location = new Point(889, 535);
            lblsubtotal.Name = "lblsubtotal";
            lblsubtotal.Size = new Size(31, 15);
            lblsubtotal.TabIndex = 14;
            lblsubtotal.Text = "$700";
            // 
            // chkdiliverydetails
            // 
            chkdiliverydetails.FormattingEnabled = true;
            chkdiliverydetails.Items.AddRange(new object[] { "PickUp", "Dilivery" });
            chkdiliverydetails.Location = new Point(150, 587);
            chkdiliverydetails.Name = "chkdiliverydetails";
            chkdiliverydetails.Size = new Size(242, 40);
            chkdiliverydetails.TabIndex = 15;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(540, 593);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(242, 23);
            txtaddress.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(457, 601);
            label7.Name = "label7";
            label7.Size = new Size(65, 16);
            label7.TabIndex = 16;
            label7.Text = "Address :";
            // 
            // btnorder
            // 
            btnorder.BackColor = SystemColors.Highlight;
            btnorder.FlatStyle = FlatStyle.Flat;
            btnorder.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnorder.ForeColor = Color.White;
            btnorder.Location = new Point(195, 677);
            btnorder.Name = "btnorder";
            btnorder.Size = new Size(100, 40);
            btnorder.TabIndex = 18;
            btnorder.Text = "Order";
            btnorder.UseVisualStyleBackColor = false;
            btnorder.Click += btnorder_Click;
            // 
            // btnmanageorder
            // 
            btnmanageorder.BackColor = SystemColors.GradientActiveCaption;
            btnmanageorder.FlatStyle = FlatStyle.Flat;
            btnmanageorder.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmanageorder.Location = new Point(619, 677);
            btnmanageorder.Name = "btnmanageorder";
            btnmanageorder.Size = new Size(112, 40);
            btnmanageorder.TabIndex = 19;
            btnmanageorder.Text = "Manage Order";
            btnmanageorder.UseVisualStyleBackColor = false;
            btnmanageorder.Click += btnmanageorder_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(48, 595);
            label8.Name = "label8";
            label8.Size = new Size(85, 16);
            label8.TabIndex = 20;
            label8.Text = "Order Type :";
            // 
            // OrderAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1008, 729);
            Controls.Add(label8);
            Controls.Add(btnmanageorder);
            Controls.Add(btnorder);
            Controls.Add(txtaddress);
            Controls.Add(label7);
            Controls.Add(chkdiliverydetails);
            Controls.Add(lblsubtotal);
            Controls.Add(label6);
            Controls.Add(txtbookprice);
            Controls.Add(label5);
            Controls.Add(txtbookqunity);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dtgsearchbook);
            Controls.Add(dtgcustomerdeatils);
            Controls.Add(btnaddcustomer);
            Controls.Add(label2);
            Controls.Add(cmbsearchbook);
            Controls.Add(cmbsearchphone);
            Controls.Add(label1);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            Name = "OrderAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderAdd";
            Load += OrderAdd_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgcustomerdeatils).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgsearchbook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblname;
        private Label label1;
        private ComboBox cmbsearchphone;
        private ComboBox cmbsearchbook;
        private Label label2;
        private Button btnaddcustomer;
        private DataGridView dtgcustomerdeatils;
        private DataGridView dtgsearchbook;
        private Label label3;
        private Label label4;
        private TextBox txtbookqunity;
        private TextBox txtbookprice;
        private Label label5;
        private Label label6;
        private Label lblsubtotal;
        private CheckedListBox chkdiliverydetails;
        private TextBox txtaddress;
        private Label label7;
        private Button btnorder;
        private Button btnmanageorder;
        private Label label8;
        private PictureBox pictureBox1;
    }
}