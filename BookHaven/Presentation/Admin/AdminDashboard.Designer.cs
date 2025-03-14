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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
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
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menupicbox).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(35, 40, 45);
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
            Menu.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Menu.ForeColor = Color.White;
            Menu.Location = new Point(85, 31);
            Menu.Name = "Menu";
            Menu.Size = new Size(77, 32);
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
            btndashboard.ForeColor = Color.White;
            btndashboard.Image = (Image)resources.GetObject("btndashboard.Image");
            btndashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btndashboard.Location = new Point(0, 3);
            btndashboard.Name = "btndashboard";
            btndashboard.Padding = new Padding(30, 0, 0, 0);
            btndashboard.Size = new Size(252, 53);
            btndashboard.TabIndex = 3;
            btndashboard.Text = "                     Book Management";
            btndashboard.TextAlign = ContentAlignment.MiddleLeft;
            btndashboard.UseVisualStyleBackColor = false;
            btndashboard.Click += btndashboard_Click;
            // 
            // btnusers
            // 
            btnusers.FlatAppearance.BorderSize = 0;
            btnusers.FlatStyle = FlatStyle.Flat;
            btnusers.ForeColor = Color.White;
            btnusers.Image = (Image)resources.GetObject("btnusers.Image");
            btnusers.ImageAlign = ContentAlignment.MiddleLeft;
            btnusers.Location = new Point(3, 171);
            btnusers.Name = "btnusers";
            btnusers.Padding = new Padding(30, 0, 0, 0);
            btnusers.Size = new Size(252, 53);
            btnusers.TabIndex = 4;
            btnusers.Text = "                     Users Management";
            btnusers.TextAlign = ContentAlignment.MiddleLeft;
            btnusers.UseVisualStyleBackColor = false;
            btnusers.Click += btnusers_Click;
            // 
            // btncustomers
            // 
            btncustomers.FlatAppearance.BorderSize = 0;
            btncustomers.FlatStyle = FlatStyle.Flat;
            btncustomers.ForeColor = Color.White;
            btncustomers.Image = (Image)resources.GetObject("btncustomers.Image");
            btncustomers.ImageAlign = ContentAlignment.MiddleLeft;
            btncustomers.Location = new Point(3, 230);
            btncustomers.Name = "btncustomers";
            btncustomers.Padding = new Padding(30, 0, 0, 0);
            btncustomers.Size = new Size(252, 53);
            btncustomers.TabIndex = 4;
            btncustomers.Text = "                     Customers";
            btncustomers.TextAlign = ContentAlignment.MiddleLeft;
            btncustomers.UseVisualStyleBackColor = false;
            btncustomers.Click += btncustomers_Click;
            // 
            // btnsalestransaction
            // 
            btnsalestransaction.FlatAppearance.BorderSize = 0;
            btnsalestransaction.FlatStyle = FlatStyle.Flat;
            btnsalestransaction.ForeColor = Color.White;
            btnsalestransaction.Image = (Image)resources.GetObject("btnsalestransaction.Image");
            btnsalestransaction.ImageAlign = ContentAlignment.MiddleLeft;
            btnsalestransaction.Location = new Point(3, 289);
            btnsalestransaction.Name = "btnsalestransaction";
            btnsalestransaction.Padding = new Padding(30, 0, 0, 0);
            btnsalestransaction.Size = new Size(252, 53);
            btnsalestransaction.TabIndex = 4;
            btnsalestransaction.Text = "                     Sales Transaction";
            btnsalestransaction.TextAlign = ContentAlignment.MiddleLeft;
            btnsalestransaction.UseVisualStyleBackColor = false;
            btnsalestransaction.Click += btnsalestransaction_Click;
            // 
            // btnordermanagement
            // 
            btnordermanagement.FlatAppearance.BorderSize = 0;
            btnordermanagement.FlatStyle = FlatStyle.Flat;
            btnordermanagement.ForeColor = Color.White;
            btnordermanagement.Image = (Image)resources.GetObject("btnordermanagement.Image");
            btnordermanagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnordermanagement.Location = new Point(3, 348);
            btnordermanagement.Name = "btnordermanagement";
            btnordermanagement.Padding = new Padding(30, 0, 0, 0);
            btnordermanagement.Size = new Size(252, 53);
            btnordermanagement.TabIndex = 4;
            btnordermanagement.Text = "                     Order Management";
            btnordermanagement.TextAlign = ContentAlignment.MiddleLeft;
            btnordermanagement.UseVisualStyleBackColor = false;
            btnordermanagement.Click += btnordermanagement_Click;
            // 
            // btnsuppliers
            // 
            btnsuppliers.FlatAppearance.BorderSize = 0;
            btnsuppliers.FlatStyle = FlatStyle.Flat;
            btnsuppliers.ForeColor = Color.White;
            btnsuppliers.Image = (Image)resources.GetObject("btnsuppliers.Image");
            btnsuppliers.ImageAlign = ContentAlignment.MiddleLeft;
            btnsuppliers.Location = new Point(3, 407);
            btnsuppliers.Name = "btnsuppliers";
            btnsuppliers.Padding = new Padding(30, 0, 0, 0);
            btnsuppliers.Size = new Size(252, 53);
            btnsuppliers.TabIndex = 4;
            btnsuppliers.Text = "                    Suppliers Management";
            btnsuppliers.TextAlign = ContentAlignment.MiddleLeft;
            btnsuppliers.UseVisualStyleBackColor = false;
            btnsuppliers.Click += btnsuppliers_Click;
            // 
            // btnorderrequest
            // 
            btnorderrequest.FlatAppearance.BorderSize = 0;
            btnorderrequest.FlatStyle = FlatStyle.Flat;
            btnorderrequest.ForeColor = Color.White;
            btnorderrequest.Image = (Image)resources.GetObject("btnorderrequest.Image");
            btnorderrequest.ImageAlign = ContentAlignment.MiddleLeft;
            btnorderrequest.Location = new Point(3, 466);
            btnorderrequest.Name = "btnorderrequest";
            btnorderrequest.Padding = new Padding(30, 0, 0, 0);
            btnorderrequest.Size = new Size(252, 53);
            btnorderrequest.TabIndex = 5;
            btnorderrequest.Text = "                     Order Request";
            btnorderrequest.TextAlign = ContentAlignment.MiddleLeft;
            btnorderrequest.UseVisualStyleBackColor = false;
            btnorderrequest.Click += btnorderrequest_Click;
            // 
            // btnreporting
            // 
            btnreporting.FlatAppearance.BorderSize = 0;
            btnreporting.FlatStyle = FlatStyle.Flat;
            btnreporting.ForeColor = Color.White;
            btnreporting.Image = (Image)resources.GetObject("btnreporting.Image");
            btnreporting.ImageAlign = ContentAlignment.MiddleLeft;
            btnreporting.Location = new Point(3, 525);
            btnreporting.Name = "btnreporting";
            btnreporting.Padding = new Padding(30, 0, 0, 0);
            btnreporting.Size = new Size(252, 53);
            btnreporting.TabIndex = 6;
            btnreporting.Text = "                     Reporting and Analytics";
            btnreporting.TextAlign = ContentAlignment.MiddleLeft;
            btnreporting.UseVisualStyleBackColor = false;
            btnreporting.Click += btnreporting_Click;
            // 
            // btnlogout
            // 
            btnlogout.FlatAppearance.BorderSize = 0;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.ForeColor = Color.White;
            btnlogout.Image = (Image)resources.GetObject("btnlogout.Image");
            btnlogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnlogout.Location = new Point(3, 584);
            btnlogout.Name = "btnlogout";
            btnlogout.Padding = new Padding(30, 0, 0, 0);
            btnlogout.Size = new Size(252, 53);
            btnlogout.TabIndex = 7;
            btnlogout.Text = "                     Logout";
            btnlogout.TextAlign = ContentAlignment.MiddleLeft;
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click;
            // 
            // sidebartimer
            // 
            sidebartimer.Tick += sidebarTimer_Tick;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
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
    }
}