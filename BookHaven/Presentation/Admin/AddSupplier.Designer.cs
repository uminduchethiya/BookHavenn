namespace BookHaven.Presentation.Admin
{
    partial class AddSupplier
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
            dtgsupplier = new DataGridView();
            label2 = new Label();
            txtsuppliername = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtsupplierphonenumber = new TextBox();
            label5 = new Label();
            txtsupplieremail = new TextBox();
            label6 = new Label();
            txtsupplieraddress = new TextBox();
            btnaddsupplier = new Button();
            btnupdatesupplier = new Button();
            btndelete = new Button();
            btnclear = new Button();
            cmbsupplier = new ComboBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgsupplier).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 1);
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
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(378, 17);
            label1.Name = "label1";
            label1.Size = new Size(274, 37);
            label1.TabIndex = 0;
            label1.Text = "Manage Supplier";
            // 
            // dtgsupplier
            // 
            dtgsupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgsupplier.Location = new Point(203, 132);
            dtgsupplier.Name = "dtgsupplier";
            dtgsupplier.Size = new Size(645, 227);
            dtgsupplier.TabIndex = 1;
            dtgsupplier.CellContentClick += dtgsupplier_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(472, 382);
            label2.Name = "label2";
            label2.Size = new Size(140, 24);
            label2.TabIndex = 2;
            label2.Text = "Add Supplier";
            // 
            // txtsuppliername
            // 
            txtsuppliername.Location = new Point(282, 444);
            txtsuppliername.Name = "txtsuppliername";
            txtsuppliername.Size = new Size(219, 23);
            txtsuppliername.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(166, 449);
            label3.Name = "label3";
            label3.Size = new Size(110, 16);
            label3.TabIndex = 4;
            label3.Text = "Supplier Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(572, 447);
            label4.Name = "label4";
            label4.Size = new Size(164, 16);
            label4.TabIndex = 6;
            label4.Text = "Supplier PhoneNumber :";
            // 
            // txtsupplierphonenumber
            // 
            txtsupplierphonenumber.Location = new Point(773, 445);
            txtsupplierphonenumber.Name = "txtsupplierphonenumber";
            txtsupplierphonenumber.Size = new Size(219, 23);
            txtsupplierphonenumber.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(166, 508);
            label5.Name = "label5";
            label5.Size = new Size(109, 16);
            label5.TabIndex = 8;
            label5.Text = "Supplier Email :";
            // 
            // txtsupplieremail
            // 
            txtsupplieremail.Location = new Point(282, 501);
            txtsupplieremail.Name = "txtsupplieremail";
            txtsupplieremail.Size = new Size(219, 23);
            txtsupplieremail.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(572, 504);
            label6.Name = "label6";
            label6.Size = new Size(163, 16);
            label6.TabIndex = 10;
            label6.Text = "Supplier Address           :";
            // 
            // txtsupplieraddress
            // 
            txtsupplieraddress.Location = new Point(773, 501);
            txtsupplieraddress.Name = "txtsupplieraddress";
            txtsupplieraddress.Size = new Size(219, 23);
            txtsupplieraddress.TabIndex = 9;
            // 
            // btnaddsupplier
            // 
            btnaddsupplier.BackColor = SystemColors.ActiveCaption;
            btnaddsupplier.FlatStyle = FlatStyle.Flat;
            btnaddsupplier.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnaddsupplier.ForeColor = Color.Black;
            btnaddsupplier.Location = new Point(179, 635);
            btnaddsupplier.Name = "btnaddsupplier";
            btnaddsupplier.Size = new Size(100, 40);
            btnaddsupplier.TabIndex = 11;
            btnaddsupplier.Text = "Add Supplier";
            btnaddsupplier.UseVisualStyleBackColor = false;
            btnaddsupplier.Click += btnaddsupplier_Click;
            // 
            // btnupdatesupplier
            // 
            btnupdatesupplier.BackColor = SystemColors.MenuHighlight;
            btnupdatesupplier.FlatStyle = FlatStyle.Flat;
            btnupdatesupplier.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdatesupplier.ForeColor = Color.White;
            btnupdatesupplier.Location = new Point(401, 635);
            btnupdatesupplier.Name = "btnupdatesupplier";
            btnupdatesupplier.Size = new Size(100, 40);
            btnupdatesupplier.TabIndex = 12;
            btnupdatesupplier.Text = "Update Supplier";
            btnupdatesupplier.UseVisualStyleBackColor = false;
            btnupdatesupplier.Click += btnupdatesupplier_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.Red;
            btndelete.FlatStyle = FlatStyle.Flat;
            btndelete.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.ForeColor = Color.White;
            btndelete.Location = new Point(585, 635);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(100, 40);
            btndelete.TabIndex = 13;
            btndelete.Text = "Delete Supplier";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // btnclear
            // 
            btnclear.BackColor = SystemColors.ActiveBorder;
            btnclear.FlatStyle = FlatStyle.Flat;
            btnclear.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclear.Location = new Point(774, 635);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(100, 40);
            btnclear.TabIndex = 14;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // cmbsupplier
            // 
            cmbsupplier.FormattingEnabled = true;
            cmbsupplier.Location = new Point(424, 91);
            cmbsupplier.Name = "cmbsupplier";
            cmbsupplier.Size = new Size(261, 23);
            cmbsupplier.TabIndex = 15;
            cmbsupplier.SelectedIndexChanged += cmbsupplier_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(282, 93);
            label7.Name = "label7";
            label7.Size = new Size(118, 16);
            label7.TabIndex = 16;
            label7.Text = "Search Supplier :";
            // 
            // AddSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(label7);
            Controls.Add(cmbsupplier);
            Controls.Add(btnclear);
            Controls.Add(btndelete);
            Controls.Add(btnupdatesupplier);
            Controls.Add(btnaddsupplier);
            Controls.Add(label6);
            Controls.Add(txtsupplieraddress);
            Controls.Add(label5);
            Controls.Add(txtsupplieremail);
            Controls.Add(label4);
            Controls.Add(txtsupplierphonenumber);
            Controls.Add(label3);
            Controls.Add(txtsuppliername);
            Controls.Add(label2);
            Controls.Add(dtgsupplier);
            Controls.Add(panel1);
            Name = "AddSupplier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddSupplier";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgsupplier).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dtgsupplier;
        private Label label2;
        private TextBox txtsuppliername;
        private Label label3;
        private Label label4;
        private TextBox txtsupplierphonenumber;
        private Label label5;
        private TextBox txtsupplieremail;
        private Label label6;
        private TextBox txtsupplieraddress;
        private Button btnaddsupplier;
        private Button btnupdatesupplier;
        private Button btndelete;
        private Button btnclear;
        private ComboBox cmbsupplier;
        private Label label7;
        private PictureBox pictureBox1;
    }
}