namespace MyFitnessManagment
{
    partial class OnlyManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnlyManager));
            panel1 = new Panel();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            CrossBtn = new PictureBox();
            label3 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CrossBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(CrossBtn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(445, 242);
            panel1.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(145, 127);
            label2.Name = "label2";
            label2.Size = new Size(40, 16);
            label2.TabIndex = 32;
            label2.Text = "Code";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mongolian Baiti", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(42, 86);
            label5.Name = "label5";
            label5.Size = new Size(374, 20);
            label5.TabIndex = 31;
            label5.Text = "Please tap the financial code to continue ! ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(147, 70);
            label4.Name = "label4";
            label4.Size = new Size(144, 16);
            label4.TabIndex = 30;
            label4.Text = "Are you Financial?";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(284, 145);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // CrossBtn
            // 
            CrossBtn.Image = (Image)resources.GetObject("CrossBtn.Image");
            CrossBtn.Location = new Point(418, 3);
            CrossBtn.Name = "CrossBtn";
            CrossBtn.Size = new Size(22, 20);
            CrossBtn.SizeMode = PictureBoxSizeMode.Zoom;
            CrossBtn.TabIndex = 28;
            CrossBtn.TabStop = false;
            CrossBtn.Click += CrossBtn_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mongolian Baiti", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(160, 32);
            label3.Name = "label3";
            label3.Size = new Size(131, 29);
            label3.TabIndex = 27;
            label3.Text = "Welcome ";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(147, 188);
            button1.Name = "button1";
            button1.Padding = new Padding(2, 0, 2, 0);
            button1.Size = new Size(159, 33);
            button1.TabIndex = 26;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(147, 144);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(159, 23);
            textBox2.TabIndex = 25;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(654, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(89, 19);
            label1.Name = "label1";
            label1.Size = new Size(0, 16);
            label1.TabIndex = 18;
            // 
            // OnlyManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(447, 245);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OnlyManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OnlyManager";
            Load += OnlyManager_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)CrossBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox2;
        private PictureBox CrossBtn;
        private Label label3;
        private Button button1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}