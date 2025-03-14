namespace BookHaven.Presentation.Comman
{
    partial class AddCustomer
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
            txtPhoneNumber = new TextBox();
            btnCancel = new Button();
            cmbGender = new ComboBox();
            btnSave = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtFirstName = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtZipCode = new TextBox();
            label7 = new Label();
            txtCity = new TextBox();
            txtAddress = new TextBox();
            txtLastName = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblFirstName = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnBacktoCustomerManagement = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtPhoneNumber);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(cmbGender);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtZipCode);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtCity);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblFirstName);
            panel1.Location = new Point(38, 169);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 548);
            panel1.TabIndex = 35;
            panel1.Paint += panel1_Paint;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(597, 95);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(309, 23);
            txtPhoneNumber.TabIndex = 42;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(564, 438);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(101, 51);
            btnCancel.TabIndex = 32;
            btnCancel.Text = "Clear";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(597, 156);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(309, 23);
            cmbGender.TabIndex = 41;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.MenuHighlight;
            btnSave.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(279, 438);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(108, 51);
            btnSave.TabIndex = 31;
            btnSave.Text = "Add Customer";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(140, 153);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(309, 23);
            dateTimePicker1.TabIndex = 40;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(140, 42);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(309, 23);
            txtFirstName.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(491, 233);
            label10.Name = "label10";
            label10.Size = new Size(34, 15);
            label10.TabIndex = 39;
            label10.Text = "City :";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(32, 225);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 38;
            label9.Text = "Address :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(491, 161);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 37;
            label8.Text = "Gender :";
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(140, 294);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(309, 23);
            txtZipCode.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(32, 294);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 25;
            label7.Text = "Zip Code :";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(596, 225);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(309, 23);
            txtCity.TabIndex = 35;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(140, 225);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(309, 23);
            txtAddress.TabIndex = 34;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(596, 39);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(309, 23);
            txtLastName.TabIndex = 27;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(32, 161);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 24;
            label6.Text = "Date Of Birth :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(140, 92);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(309, 23);
            txtEmail.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(485, 103);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 23;
            label5.Text = "Phone Number :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 95);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 22;
            label4.Text = "Email :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(485, 42);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 21;
            label3.Text = "LastName :";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(32, 42);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(70, 15);
            lblFirstName.TabIndex = 20;
            lblFirstName.Text = "FirstName :";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1008, 70);
            panel2.TabIndex = 36;
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
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(433, 16);
            label1.Name = "label1";
            label1.Size = new Size(207, 37);
            label1.TabIndex = 0;
            label1.Text = "Add Customer";
            // 
            // btnBacktoCustomerManagement
            // 
            btnBacktoCustomerManagement.BackColor = SystemColors.ActiveCaption;
            btnBacktoCustomerManagement.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBacktoCustomerManagement.ForeColor = Color.Black;
            btnBacktoCustomerManagement.Location = new Point(876, 100);
            btnBacktoCustomerManagement.Name = "btnBacktoCustomerManagement";
            btnBacktoCustomerManagement.Size = new Size(110, 44);
            btnBacktoCustomerManagement.TabIndex = 19;
            btnBacktoCustomerManagement.Text = "Customer Management";
            btnBacktoCustomerManagement.UseVisualStyleBackColor = false;
            btnBacktoCustomerManagement.Click += btnBacktoCustomerManagement_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(437, 108);
            label2.Name = "label2";
            label2.Size = new Size(183, 24);
            label2.TabIndex = 37;
            label2.Text = "Customer Details";
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(label2);
            Controls.Add(btnBacktoCustomerManagement);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "AddCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCustomer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtZipCode;
        private Label label7;
        private TextBox txtCity;
        private TextBox txtAddress;
        private TextBox txtLastName;
        private Label label6;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtStock;
        private Label label4;
        private TextBox txtPrice;
        private Label label3;
        private Label lblFirstName;
        private Button btnBacktoCustomerManagement;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtFirstName;
        private ComboBox cmbGender;
        private DateTimePicker dateTimePicker1;
        private TextBox txtPhoneNumber;
        private PictureBox pictureBox1;
        private Label label2;
    }
}