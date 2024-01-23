namespace MyFitnessManagment
{
    partial class splash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splash));
            pictureBox8 = new PictureBox();
            pictureBox6 = new PictureBox();
            panel16 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            label11 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel16.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(166, 98);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(187, 37);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 18;
            pictureBox8.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(179, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(163, 91);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 17;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // panel16
            // 
            panel16.BackColor = Color.FromArgb(224, 224, 224);
            panel16.Controls.Add(panel1);
            panel16.Location = new Point(46, 157);
            panel16.Name = "panel16";
            panel16.Size = new Size(427, 10);
            panel16.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(28, 10);
            panel1.TabIndex = 25;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(3, 220);
            label1.Name = "label1";
            label1.Size = new Size(211, 15);
            label1.TabIndex = 25;
            label1.Text = "Developped By Skandar And chawki";
            label1.Click += label1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Corbel", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(434, 220);
            label11.Name = "label11";
            label11.Size = new Size(78, 14);
            label11.TabIndex = 26;
            label11.Text = "Version: 0.0.1";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(242, 170);
            label2.Name = "label2";
            label2.Size = new Size(62, 14);
            label2.TabIndex = 27;
            label2.Text = "Loading...";
            // 
            // splash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(516, 244);
            Controls.Add(label2);
            Controls.Add(label11);
            Controls.Add(label1);
            Controls.Add(panel16);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel16.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox8;
        private PictureBox pictureBox6;
        private Panel panel16;
        private Label label1;
        private Panel panel1;
        private Label label11;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
    }
}