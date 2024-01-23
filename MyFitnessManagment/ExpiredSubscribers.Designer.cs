namespace MyFitnessManagment
{
    partial class ExpiredSubscribers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpiredSubscribers));
            label1 = new Label();
            label1dzdz = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            pictureBox2 = new PictureBox();
            CrossBtn = new PictureBox();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CrossBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(99, 88);
            label1.Name = "label1";
            label1.Size = new Size(432, 22);
            label1.TabIndex = 55;
            label1.Text = "List of members whose subscriptions are expired.";
            // 
            // label1dzdz
            // 
            label1dzdz.AutoSize = true;
            label1dzdz.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1dzdz.ForeColor = Color.Black;
            label1dzdz.Location = new Point(85, 42);
            label1dzdz.Name = "label1dzdz";
            label1dzdz.Size = new Size(207, 26);
            label1dzdz.TabIndex = 5;
            label1dzdz.Text = "Expired subscribers";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(393, 100);
            label3.Name = "label3";
            label3.Size = new Size(0, 22);
            label3.TabIndex = 57;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(CrossBtn);
            panel1.Controls.Add(label1dzdz);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(953, 75);
            panel1.TabIndex = 54;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Montserrat", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(128, 26);
            label9.Name = "label9";
            label9.Size = new Size(33, 12);
            label9.TabIndex = 12;
            label9.Text = "Home";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(85, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // CrossBtn
            // 
            CrossBtn.Image = (Image)resources.GetObject("CrossBtn.Image");
            CrossBtn.Location = new Point(930, 3);
            CrossBtn.Name = "CrossBtn";
            CrossBtn.Size = new Size(22, 20);
            CrossBtn.SizeMode = PictureBoxSizeMode.Zoom;
            CrossBtn.TabIndex = 9;
            CrossBtn.TabStop = false;
            CrossBtn.Click += CrossBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(205, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(541, 309);
            dataGridView1.TabIndex = 58;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ExpiredSubscribers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(952, 453);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ExpiredSubscribers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExpiredSubscribers";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)CrossBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label1dzdz;
        private Label label3;
        private Panel panel1;
        private PictureBox CrossBtn;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label label9;
        private PictureBox pictureBox2;
    }
}