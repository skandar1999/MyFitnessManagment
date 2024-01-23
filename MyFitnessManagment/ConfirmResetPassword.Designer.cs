namespace MyFitnessManagment
{
    partial class ConfirmResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmResetPassword));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            CrossBtn = new PictureBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CrossBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(29, 11);
            label1.Name = "label1";
            label1.Size = new Size(0, 16);
            label1.TabIndex = 18;
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
            // textBox2
            // 
            textBox2.Location = new Point(102, 129);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(159, 23);
            textBox2.TabIndex = 25;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(102, 173);
            button1.Name = "button1";
            button1.Padding = new Padding(2, 0, 2, 0);
            button1.Size = new Size(159, 33);
            button1.TabIndex = 26;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mongolian Baiti", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(146, 21);
            label3.Name = "label3";
            label3.Size = new Size(80, 29);
            label3.TabIndex = 27;
            label3.Text = "Hey !";
            label3.Click += label3_Click;
            // 
            // CrossBtn
            // 
            CrossBtn.Image = (Image)resources.GetObject("CrossBtn.Image");
            CrossBtn.Location = new Point(341, -1);
            CrossBtn.Name = "CrossBtn";
            CrossBtn.Size = new Size(22, 20);
            CrossBtn.SizeMode = PictureBoxSizeMode.Zoom;
            CrossBtn.TabIndex = 28;
            CrossBtn.TabStop = false;
            CrossBtn.Click += CrossBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(239, 130);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mongolian Baiti", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(56, 59);
            label5.Name = "label5";
            label5.Size = new Size(248, 18);
            label5.TabIndex = 31;
            label5.Text = "To navigate to reset password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(100, 112);
            label2.Name = "label2";
            label2.Size = new Size(33, 16);
            label2.TabIndex = 32;
            label2.Text = "Key";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(77, 82);
            label4.Name = "label4";
            label4.Size = new Size(203, 16);
            label4.TabIndex = 33;
            label4.Text = "please enter the secret key.";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(CrossBtn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 242);
            panel1.TabIndex = 26;
            // 
            // ConfirmResetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(364, 242);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConfirmResetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConfirmResetPassword";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CrossBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label3;
        private PictureBox CrossBtn;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label2;
        private Label label4;
        private Panel panel1;
    }
}