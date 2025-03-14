namespace BookHaven.Presentation
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            imageList1 = new ImageList(components);
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            txtemail = new TextBox();
            txtpassword = new TextBox();
            label5 = new Label();
            btnlogin = new Button();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-4, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 70);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-7, -20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(146, 19);
            label1.Name = "label1";
            label1.Size = new Size(0, 29);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(74, 128);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(307, 96);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(227, 155);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(319, 209);
            label3.Name = "label3";
            label3.Size = new Size(204, 22);
            label3.TabIndex = 4;
            label3.Text = "Login To BookHaven";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(222, 293);
            label4.Name = "label4";
            label4.Size = new Size(51, 16);
            label4.TabIndex = 5;
            label4.Text = "Email :";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(222, 326);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(363, 23);
            txtemail.TabIndex = 6;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(222, 398);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(363, 23);
            txtpassword.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(222, 365);
            label5.Name = "label5";
            label5.Size = new Size(76, 16);
            label5.TabIndex = 7;
            label5.Text = "Password :";
            // 
            // btnlogin
            // 
            btnlogin.BackColor = SystemColors.MenuHighlight;
            btnlogin.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = SystemColors.ButtonFace;
            btnlogin.Location = new Point(222, 474);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(363, 36);
            btnlogin.TabIndex = 9;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.MenuHighlight;
            label6.Location = new Point(336, 439);
            label6.Name = "label6";
            label6.Size = new Size(125, 16);
            label6.TabIndex = 10;
            label6.Text = "Forgot Password ?";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 561);
            Controls.Add(label6);
            Controls.Add(btnlogin);
            Controls.Add(txtpassword);
            Controls.Add(label5);
            Controls.Add(txtemail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private TextBox txtemail;
        private TextBox txtpassword;
        private Label label5;
        private Button btnlogin;
        private Label label6;
    }
}