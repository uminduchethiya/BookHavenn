namespace BookHaven.Presentation.Comman
{
    partial class InventoryStatusView
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
            btnGenarate = new Button();
            dataGridView1 = new DataGridView();
            btnexport = new Button();
            btnBack = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(423, 19);
            label1.Name = "label1";
            label1.Size = new Size(265, 37);
            label1.TabIndex = 0;
            label1.Text = "Inventory Status";
            label1.TextAlign = ContentAlignment.BottomLeft;
            label1.Click += label1_Click;
            // 
            // btnGenarate
            // 
            btnGenarate.BackColor = SystemColors.ActiveCaption;
            btnGenarate.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenarate.ForeColor = SystemColors.ControlText;
            btnGenarate.Location = new Point(779, 88);
            btnGenarate.Name = "btnGenarate";
            btnGenarate.Size = new Size(101, 48);
            btnGenarate.TabIndex = 1;
            btnGenarate.Text = "Genarate";
            btnGenarate.UseVisualStyleBackColor = false;
            btnGenarate.Click += btnGenarate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(58, 164);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(822, 471);
            dataGridView1.TabIndex = 2;
            // 
            // btnexport
            // 
            btnexport.BackColor = SystemColors.MenuHighlight;
            btnexport.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnexport.Location = new Point(424, 661);
            btnexport.Name = "btnexport";
            btnexport.Size = new Size(111, 47);
            btnexport.TabIndex = 3;
            btnexport.Text = "Export To Excel";
            btnexport.UseVisualStyleBackColor = false;
            btnexport.Click += btnexport_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(187, 673);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(138, 23);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back To Dashboard";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Visible = false;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 70);
            panel1.TabIndex = 5;
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
            // InventoryStatusView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Controls.Add(btnexport);
            Controls.Add(dataGridView1);
            Controls.Add(btnGenarate);
            Name = "InventoryStatusView";
            Text = "InventoryStatusView";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnGenarate;
        private DataGridView dataGridView1;
        private Button btnexport;
        private Button btnBack;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}