namespace BookHaven.Presentation.Comman
{
    partial class CustomerManagementViewForm
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
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            btnAddCustomer = new Button();
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            btnDelete = new Button();
            btnUpdate = new Button();
            cmbGender = new ComboBox();
            txtname = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtFirstName = new Label();
            txtZipcode = new TextBox();
            txtCity = new TextBox();
            txtPhoneNumber = new TextBox();
            txtLastName = new TextBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(2, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1008, 70);
            panel2.TabIndex = 9;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(326, 9);
            label1.Name = "label1";
            label1.Size = new Size(387, 45);
            label1.TabIndex = 0;
            label1.Text = "Customer Management";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(984, 228);
            dataGridView1.TabIndex = 10;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(751, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 23);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = SystemColors.ActiveCaption;
            btnAddCustomer.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddCustomer.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCustomer.Location = new Point(12, 76);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(133, 40);
            btnAddCustomer.TabIndex = 12;
            btnAddCustomer.Text = "Add New Customer";
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(cmbGender);
            panel1.Controls.Add(txtname);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(txtZipcode);
            panel1.Controls.Add(txtCity);
            panel1.Controls.Add(txtPhoneNumber);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtEmail);
            panel1.Location = new Point(12, 383);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 334);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(124, 120);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(248, 23);
            dateTimePicker1.TabIndex = 22;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(594, 272);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 38);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.MenuHighlight;
            btnUpdate.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(408, 272);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(85, 38);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(668, 118);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(248, 23);
            cmbGender.TabIndex = 19;
            // 
            // txtname
            // 
            txtname.Location = new Point(124, 28);
            txtname.Name = "txtname";
            txtname.Size = new Size(248, 23);
            txtname.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(554, 174);
            label10.Name = "label10";
            label10.Size = new Size(34, 15);
            label10.TabIndex = 17;
            label10.Text = "City :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(554, 121);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 16;
            label9.Text = "Gender :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(554, 77);
            label8.Name = "label8";
            label8.Size = new Size(97, 15);
            label8.TabIndex = 15;
            label8.Text = "Phone Number :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(554, 30);
            label7.Name = "label7";
            label7.Size = new Size(82, 16);
            label7.TabIndex = 14;
            label7.Text = "Last Name :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(32, 224);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 13;
            label6.Text = "Zip Code :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 174);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 12;
            label5.Text = "Address :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 126);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 11;
            label4.Text = "Date Of Birth :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 77);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 10;
            label3.Text = "Email :";
            // 
            // txtFirstName
            // 
            txtFirstName.AutoSize = true;
            txtFirstName.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(32, 31);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(74, 15);
            txtFirstName.TabIndex = 9;
            txtFirstName.Text = "First Name :";
            txtFirstName.Click += label2_Click;
            // 
            // txtZipcode
            // 
            txtZipcode.Location = new Point(124, 221);
            txtZipcode.Name = "txtZipcode";
            txtZipcode.Size = new Size(248, 23);
            txtZipcode.TabIndex = 8;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(668, 171);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(248, 23);
            txtCity.TabIndex = 7;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(668, 74);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(248, 23);
            txtPhoneNumber.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(668, 28);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(248, 23);
            txtLastName.TabIndex = 4;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(124, 171);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(248, 23);
            txtAddress.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(124, 74);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(248, 23);
            txtEmail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(628, 96);
            label2.Name = "label2";
            label2.Size = new Size(116, 16);
            label2.TabIndex = 23;
            label2.Text = "Search Customer";
            // 
            // CustomerManagementViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnAddCustomer);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Name = "CustomerManagementViewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerManagementViewForm";
            Load += CustomerManagementViewForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button btnAddCustomer;
        private Panel panel1;
        private Label txtFirstName;
        private TextBox txtZipcode;
        private TextBox txtCity;
        private TextBox txtPhoneNumber;
        private TextBox txtLastName;
        private TextBox txtAddress;
        private TextBox TxtBirthday;
        private TextBox txtEmail;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtname;
        private Button btnDelete;
        private Button btnUpdate;
        private ComboBox cmbGender;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
        private Label label2;
    }
}