namespace BookHaven.Presentation.Comman
{
    partial class MostBooksSaleView
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
            btnExport = new Button();
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
            label1.ForeColor = Color.White;
            label1.Location = new Point(403, 20);
            label1.Name = "label1";
            label1.Size = new Size(273, 37);
            label1.TabIndex = 0;
            label1.Text = "Most Sale Books";
            // 
            // btnGenarate
            // 
            btnGenarate.BackColor = SystemColors.ActiveCaption;
            btnGenarate.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenarate.Location = new Point(831, 75);
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
            dataGridView1.Location = new Point(71, 127);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(861, 475);
            dataGridView1.TabIndex = 2;
            // 
            // btnExport
            // 
            btnExport.BackColor = SystemColors.MenuHighlight;
            btnExport.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.Location = new Point(449, 622);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(114, 49);
            btnExport.TabIndex = 3;
            btnExport.Text = "Export To Excel";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 70);
            panel1.TabIndex = 4;
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
            // MostBooksSaleView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(panel1);
            Controls.Add(btnExport);
            Controls.Add(dataGridView1);
            Controls.Add(btnGenarate);
            Name = "MostBooksSaleView";
            Text = "MostBooksSaleView";
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
        private Button btnExport;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}