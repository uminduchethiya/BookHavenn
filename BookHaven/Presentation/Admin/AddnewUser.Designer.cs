namespace BookHaven.Presentation.Admin
{
    partial class AddnewUser
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
            label8 = new Label();
            cmbgender = new ComboBox();
            label7 = new Label();
            txtaddress = new TextBox();
            label6 = new Label();
            txtidnum = new TextBox();
            label5 = new Label();
            txtphone = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtfirstname = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnadd = new Button();
            btnclear = new Button();
            txtname = new TextBox();
            txtemail = new TextBox();
            label9 = new Label();
            cmbuserrole = new ComboBox();
            label10 = new Label();
            dobpicker = new DateTimePicker();
            button1 = new Button();
            label11 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(355, 483);
            label8.Name = "label8";
            label8.Size = new Size(47, 16);
            label8.TabIndex = 39;
            label8.Text = "DOB  :";
            // 
            // cmbgender
            // 
            cmbgender.FormattingEnabled = true;
            cmbgender.Items.AddRange(new object[] { "Male", "Female" });
            cmbgender.Location = new Point(712, 389);
            cmbgender.Name = "cmbgender";
            cmbgender.Size = new Size(284, 23);
            cmbgender.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(556, 391);
            label7.Name = "label7";
            label7.Size = new Size(66, 16);
            label7.TabIndex = 37;
            label7.Text = "Gender  :";
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(182, 313);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(284, 23);
            txtaddress.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(26, 320);
            label6.Name = "label6";
            label6.Size = new Size(69, 16);
            label6.TabIndex = 35;
            label6.Text = "Address  :";
            // 
            // txtidnum
            // 
            txtidnum.Location = new Point(712, 306);
            txtidnum.Name = "txtidnum";
            txtidnum.Size = new Size(284, 23);
            txtidnum.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(556, 313);
            label5.Name = "label5";
            label5.Size = new Size(120, 16);
            label5.TabIndex = 33;
            label5.Text = "Identity Number  :";
            // 
            // txtphone
            // 
            txtphone.Location = new Point(712, 242);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(284, 23);
            txtphone.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(556, 244);
            label4.Name = "label4";
            label4.Size = new Size(114, 16);
            label4.TabIndex = 31;
            label4.Text = "Phone Number  :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(556, 166);
            label3.Name = "label3";
            label3.Size = new Size(86, 16);
            label3.TabIndex = 29;
            label3.Text = "Last Name  :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 171);
            label2.Name = "label2";
            label2.Size = new Size(87, 16);
            label2.TabIndex = 27;
            label2.Text = "First Name  :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(414, 16);
            label1.Name = "label1";
            label1.Size = new Size(232, 37);
            label1.TabIndex = 0;
            label1.Text = "Add New User";
            label1.Click += label1_Click;
            // 
            // txtfirstname
            // 
            txtfirstname.Location = new Point(182, 164);
            txtfirstname.Name = "txtfirstname";
            txtfirstname.Size = new Size(284, 23);
            txtfirstname.TabIndex = 28;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 69);
            panel1.TabIndex = 21;
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
            // btnadd
            // 
            btnadd.BackColor = SystemColors.MenuHighlight;
            btnadd.FlatStyle = FlatStyle.Flat;
            btnadd.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnadd.ForeColor = Color.White;
            btnadd.Location = new Point(447, 649);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(100, 48);
            btnadd.TabIndex = 24;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click_1;
            // 
            // btnclear
            // 
            btnclear.BackColor = SystemColors.ActiveBorder;
            btnclear.FlatStyle = FlatStyle.Flat;
            btnclear.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclear.ForeColor = Color.Black;
            btnclear.Location = new Point(665, 649);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(100, 48);
            btnclear.TabIndex = 26;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // txtname
            // 
            txtname.Location = new Point(712, 159);
            txtname.Name = "txtname";
            txtname.Size = new Size(284, 23);
            txtname.TabIndex = 41;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(182, 242);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(284, 23);
            txtemail.TabIndex = 44;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(26, 244);
            label9.Name = "label9";
            label9.Size = new Size(55, 16);
            label9.TabIndex = 43;
            label9.Text = "Email  :";
            // 
            // cmbuserrole
            // 
            cmbuserrole.FormattingEnabled = true;
            cmbuserrole.Items.AddRange(new object[] { "Male", "Female" });
            cmbuserrole.Location = new Point(182, 384);
            cmbuserrole.Name = "cmbuserrole";
            cmbuserrole.Size = new Size(284, 23);
            cmbuserrole.TabIndex = 46;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(26, 389);
            label10.Name = "label10";
            label10.Size = new Size(48, 16);
            label10.TabIndex = 45;
            label10.Text = "Role  :";
            // 
            // dobpicker
            // 
            dobpicker.Location = new Point(447, 478);
            dobpicker.Name = "dobpicker";
            dobpicker.Size = new Size(200, 23);
            dobpicker.TabIndex = 47;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(241, 649);
            button1.Name = "button1";
            button1.Size = new Size(100, 48);
            button1.TabIndex = 48;
            button1.Text = "User Manage Page";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(448, 102);
            label11.Name = "label11";
            label11.Size = new Size(130, 24);
            label11.TabIndex = 49;
            label11.Text = "User Details";
            // 
            // AddnewUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(label11);
            Controls.Add(button1);
            Controls.Add(dobpicker);
            Controls.Add(cmbuserrole);
            Controls.Add(label10);
            Controls.Add(txtemail);
            Controls.Add(label9);
            Controls.Add(txtname);
            Controls.Add(label8);
            Controls.Add(cmbgender);
            Controls.Add(label7);
            Controls.Add(txtaddress);
            Controls.Add(label6);
            Controls.Add(txtidnum);
            Controls.Add(label5);
            Controls.Add(txtphone);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnclear);
            Controls.Add(btnadd);
            Controls.Add(txtfirstname);
            Controls.Add(panel1);
            Name = "AddnewUser";
            Text = "AddnewUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label8;
        private ComboBox cmbgender;
        private Label label7;
        private TextBox txtaddress;
        private Label label6;
        private TextBox txtidnum;
        private Label label5;
        private TextBox txtphone;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtfirstname;
        private Panel panel1;
        private Button btnadd;
        private Button btnclear;
        private TextBox txtname;
        private TextBox txtemail;
        private Label label9;
        private ComboBox cmbuserrole;
        private Label label10;
        private DateTimePicker dobpicker;
        private Button button1;
        private Label label11;
        private PictureBox pictureBox1;
    }
}