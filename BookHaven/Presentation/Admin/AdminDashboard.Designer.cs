namespace BookHaven.Presentation.Admin
{
    partial class AdminDashboard
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
            components = new System.ComponentModel.Container();
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            Menu = new Label();
            menupicbox = new PictureBox();
            panel2 = new Panel();
            btndashboard = new Button();
            btnusers = new Button();
            btncustomers = new Button();
            btnsalestransaction = new Button();
            btnordermanagement = new Button();
            btnsuppliers = new Button();
            btnorderrequest = new Button();
            btnreporting = new Button();
            btnlogout = new Button();
            sidebartimer = new System.Windows.Forms.Timer(components);
            panel3 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            panel5 = new Panel();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            panel6 = new Panel();
            label7 = new Label();
            pictureBox4 = new PictureBox();
            label8 = new Label();
            panel7 = new Panel();
            label9 = new Label();
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menupicbox).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = SystemColors.ActiveCaption;
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(btnusers);
            sidebar.Controls.Add(btncustomers);
            sidebar.Controls.Add(btnsalestransaction);
            sidebar.Controls.Add(btnordermanagement);
            sidebar.Controls.Add(btnsuppliers);
            sidebar.Controls.Add(btnorderrequest);
            sidebar.Controls.Add(btnreporting);
            sidebar.Controls.Add(btnlogout);
            sidebar.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(258, 729);
            sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(Menu);
            panel1.Controls.Add(menupicbox);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 100);
            panel1.TabIndex = 1;
            // 
            // Menu
            // 
            Menu.AutoSize = true;
            Menu.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Menu.ForeColor = Color.White;
            Menu.Location = new Point(85, 31);
            Menu.Name = "Menu";
            Menu.Size = new Size(77, 29);
            Menu.TabIndex = 1;
            Menu.Text = "Menu";
            // 
            // menupicbox
            // 
            menupicbox.Image = Properties.Resources.menu1;
            menupicbox.Location = new Point(23, 27);
            menupicbox.Name = "menupicbox";
            menupicbox.Size = new Size(36, 39);
            menupicbox.SizeMode = PictureBoxSizeMode.Zoom;
            menupicbox.TabIndex = 1;
            menupicbox.TabStop = false;
            menupicbox.Click += menupicbox_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btndashboard);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(3, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(255, 56);
            panel2.TabIndex = 2;
            // 
            // btndashboard
            // 
            btndashboard.FlatAppearance.BorderSize = 0;
            btndashboard.FlatStyle = FlatStyle.Flat;
            btndashboard.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndashboard.ForeColor = Color.White;
            btndashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btndashboard.Location = new Point(0, 3);
            btndashboard.Name = "btndashboard";
            btndashboard.Padding = new Padding(30, 0, 0, 0);
            btndashboard.Size = new Size(252, 53);
            btndashboard.TabIndex = 3;
            btndashboard.Text = " Book Management";
            btndashboard.TextAlign = ContentAlignment.MiddleLeft;
            btndashboard.UseVisualStyleBackColor = false;
            btndashboard.Click += btndashboard_Click;
            // 
            // btnusers
            // 
            btnusers.FlatAppearance.BorderSize = 0;
            btnusers.FlatStyle = FlatStyle.Flat;
            btnusers.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnusers.ForeColor = Color.White;
            btnusers.ImageAlign = ContentAlignment.MiddleLeft;
            btnusers.Location = new Point(3, 171);
            btnusers.Name = "btnusers";
            btnusers.Padding = new Padding(30, 0, 0, 0);
            btnusers.Size = new Size(252, 53);
            btnusers.TabIndex = 4;
            btnusers.Text = "Users Management";
            btnusers.TextAlign = ContentAlignment.MiddleLeft;
            btnusers.UseVisualStyleBackColor = false;
            btnusers.Click += btnusers_Click;
            // 
            // btncustomers
            // 
            btncustomers.FlatAppearance.BorderSize = 0;
            btncustomers.FlatStyle = FlatStyle.Flat;
            btncustomers.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncustomers.ForeColor = Color.White;
            btncustomers.ImageAlign = ContentAlignment.MiddleLeft;
            btncustomers.Location = new Point(3, 230);
            btncustomers.Name = "btncustomers";
            btncustomers.Padding = new Padding(30, 0, 0, 0);
            btncustomers.Size = new Size(252, 53);
            btncustomers.TabIndex = 4;
            btncustomers.Text = "Customers Management";
            btncustomers.TextAlign = ContentAlignment.MiddleLeft;
            btncustomers.UseVisualStyleBackColor = false;
            btncustomers.Click += btncustomers_Click;
            // 
            // btnsalestransaction
            // 
            btnsalestransaction.FlatAppearance.BorderSize = 0;
            btnsalestransaction.FlatStyle = FlatStyle.Flat;
            btnsalestransaction.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsalestransaction.ForeColor = Color.White;
            btnsalestransaction.ImageAlign = ContentAlignment.MiddleLeft;
            btnsalestransaction.Location = new Point(3, 289);
            btnsalestransaction.Name = "btnsalestransaction";
            btnsalestransaction.Padding = new Padding(30, 0, 0, 0);
            btnsalestransaction.Size = new Size(252, 53);
            btnsalestransaction.TabIndex = 4;
            btnsalestransaction.Text = "Sales Transaction";
            btnsalestransaction.TextAlign = ContentAlignment.MiddleLeft;
            btnsalestransaction.UseVisualStyleBackColor = false;
            btnsalestransaction.Click += btnsalestransaction_Click;
            // 
            // btnordermanagement
            // 
            btnordermanagement.FlatAppearance.BorderSize = 0;
            btnordermanagement.FlatStyle = FlatStyle.Flat;
            btnordermanagement.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnordermanagement.ForeColor = Color.White;
            btnordermanagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnordermanagement.Location = new Point(3, 348);
            btnordermanagement.Name = "btnordermanagement";
            btnordermanagement.Padding = new Padding(30, 0, 0, 0);
            btnordermanagement.Size = new Size(252, 53);
            btnordermanagement.TabIndex = 4;
            btnordermanagement.Text = "Order Management";
            btnordermanagement.TextAlign = ContentAlignment.MiddleLeft;
            btnordermanagement.UseVisualStyleBackColor = false;
            btnordermanagement.Click += btnordermanagement_Click;
            // 
            // btnsuppliers
            // 
            btnsuppliers.FlatAppearance.BorderSize = 0;
            btnsuppliers.FlatStyle = FlatStyle.Flat;
            btnsuppliers.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsuppliers.ForeColor = Color.White;
            btnsuppliers.ImageAlign = ContentAlignment.MiddleLeft;
            btnsuppliers.Location = new Point(3, 407);
            btnsuppliers.Name = "btnsuppliers";
            btnsuppliers.Padding = new Padding(30, 0, 0, 0);
            btnsuppliers.Size = new Size(252, 53);
            btnsuppliers.TabIndex = 4;
            btnsuppliers.Text = "Suppliers Management";
            btnsuppliers.TextAlign = ContentAlignment.MiddleLeft;
            btnsuppliers.UseVisualStyleBackColor = false;
            btnsuppliers.Click += btnsuppliers_Click;
            // 
            // btnorderrequest
            // 
            btnorderrequest.FlatAppearance.BorderSize = 0;
            btnorderrequest.FlatStyle = FlatStyle.Flat;
            btnorderrequest.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnorderrequest.ForeColor = Color.White;
            btnorderrequest.ImageAlign = ContentAlignment.MiddleLeft;
            btnorderrequest.Location = new Point(3, 466);
            btnorderrequest.Name = "btnorderrequest";
            btnorderrequest.Padding = new Padding(30, 0, 0, 0);
            btnorderrequest.Size = new Size(252, 53);
            btnorderrequest.TabIndex = 5;
            btnorderrequest.Text = "Order Request";
            btnorderrequest.TextAlign = ContentAlignment.MiddleLeft;
            btnorderrequest.UseVisualStyleBackColor = false;
            btnorderrequest.Click += btnorderrequest_Click;
            // 
            // btnreporting
            // 
            btnreporting.FlatAppearance.BorderSize = 0;
            btnreporting.FlatStyle = FlatStyle.Flat;
            btnreporting.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnreporting.ForeColor = Color.White;
            btnreporting.ImageAlign = ContentAlignment.MiddleLeft;
            btnreporting.Location = new Point(3, 525);
            btnreporting.Name = "btnreporting";
            btnreporting.Padding = new Padding(30, 0, 0, 0);
            btnreporting.Size = new Size(252, 53);
            btnreporting.TabIndex = 6;
            btnreporting.Text = "Reporting and Analytics";
            btnreporting.TextAlign = ContentAlignment.MiddleLeft;
            btnreporting.UseVisualStyleBackColor = false;
            btnreporting.Click += btnreporting_Click;
            // 
            // btnlogout
            // 
            btnlogout.FlatAppearance.BorderSize = 0;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogout.ForeColor = Color.White;
            btnlogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnlogout.Location = new Point(3, 584);
            btnlogout.Name = "btnlogout";
            btnlogout.Padding = new Padding(30, 0, 0, 0);
            btnlogout.Size = new Size(252, 53);
            btnlogout.TabIndex = 7;
            btnlogout.Text = "Logout";
            btnlogout.TextAlign = ContentAlignment.MiddleLeft;
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click;
            // 
            // sidebartimer
            // 
            sidebartimer.Tick += sidebarTimer_Tick;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(284, 197);
            panel3.Name = "panel3";
            panel3.Size = new Size(274, 196);
            panel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(114, 152);
            label2.Name = "label2";
            label2.Size = new Size(39, 29);
            label2.TabIndex = 2;
            label2.Text = "10";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_svgrepo_com;
            pictureBox1.Location = new Point(78, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 24);
            label1.Name = "label1";
            label1.Size = new Size(141, 29);
            label1.TabIndex = 0;
            label1.Text = "Total Users";
            // 
            // panel4
            // 
            panel4.Controls.Add(label3);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(701, 197);
            panel4.Name = "panel4";
            panel4.Size = new Size(274, 196);
            panel4.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(127, 137);
            label3.Name = "label3";
            label3.Size = new Size(26, 29);
            label3.TabIndex = 2;
            label3.Text = "7";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.target_audience_svgrepo_com;
            pictureBox2.Location = new Point(78, 56);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 66);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(43, 24);
            label4.Name = "label4";
            label4.Size = new Size(200, 29);
            label4.TabIndex = 0;
            label4.Text = "Total Customers";
            // 
            // panel5
            // 
            panel5.Controls.Add(label5);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(284, 443);
            panel5.Name = "panel5";
            panel5.Size = new Size(274, 196);
            panel5.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(127, 137);
            label5.Name = "label5";
            label5.Size = new Size(26, 29);
            label5.TabIndex = 2;
            label5.Text = "5";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.shipped_svgrepo_com;
            pictureBox3.Location = new Point(78, 56);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(120, 66);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(67, 24);
            label6.Name = "label6";
            label6.Size = new Size(153, 29);
            label6.TabIndex = 0;
            label6.Text = "Total Orders";
            // 
            // panel6
            // 
            panel6.Controls.Add(label7);
            panel6.Controls.Add(pictureBox4);
            panel6.Controls.Add(label8);
            panel6.Location = new Point(701, 443);
            panel6.Name = "panel6";
            panel6.Size = new Size(274, 196);
            panel6.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(127, 137);
            label7.Name = "label7";
            label7.Size = new Size(39, 29);
            label7.TabIndex = 2;
            label7.Text = "13";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.orders_order_svgrepo_com;
            pictureBox4.Location = new Point(78, 56);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(120, 66);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(43, 24);
            label8.Name = "label8";
            label8.Size = new Size(186, 29);
            label8.TabIndex = 0;
            label8.Text = "Total Suppliers";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ActiveCaption;
            panel7.Controls.Add(label9);
            panel7.ForeColor = SystemColors.ControlLightLight;
            panel7.Location = new Point(256, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(752, 110);
            panel7.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(258, 34);
            label9.Name = "label9";
            label9.Size = new Size(291, 37);
            label9.TabIndex = 0;
            label9.Text = "Admin Dashboard";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(sidebar);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menupicbox).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private Panel panel2;
        private Button btndashboard;
        private Button btnusers;
        private Button btncustomers;
        private Button btnsalestransaction;
        private Button btnordermanagement;
        private Button btnsuppliers;
        private Button btnorderrequest;
        private Button btnreporting;
        private PictureBox menupicbox;
        private Label Menu;
        private System.Windows.Forms.Timer sidebartimer;
        private Button btnlogout;
        private Panel panel3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel4;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label4;
        private Panel panel5;
        private Label label5;
        private PictureBox pictureBox3;
        private Label label6;
        private Panel panel6;
        private Label label7;
        private PictureBox pictureBox4;
        private Label label8;
        private Panel panel7;
        private Label label9;
    }
}