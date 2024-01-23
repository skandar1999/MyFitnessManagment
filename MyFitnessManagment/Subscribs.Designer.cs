namespace MyFitnessManagment
{
    partial class Subscribs
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subscribs));
            DeleteBtn = new Button();
            panel2 = new Panel();
            dateEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dateStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label10 = new Label();
            label17 = new Label();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            label14 = new Label();
            label2 = new Label();
            label13 = new Label();
            label5 = new Label();
            label12 = new Label();
            label8 = new Label();
            label11 = new Label();
            label3 = new Label();
            memName = new TextBox();
            panel1 = new Panel();
            label9 = new Label();
            pictureBox2 = new PictureBox();
            CrossBtn = new PictureBox();
            label1dzdz = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            stopdate = new Button();
            button2 = new Button();
            dateStop = new Label();
            dateEnb = new Label();
            button1 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CrossBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Black;
            DeleteBtn.BackgroundImageLayout = ImageLayout.None;
            DeleteBtn.Font = new Font("Segoe UI Historic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteBtn.ForeColor = SystemColors.ControlLightLight;
            DeleteBtn.Location = new Point(852, 100);
            DeleteBtn.Margin = new Padding(0);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(74, 28);
            DeleteBtn.TabIndex = 49;
            DeleteBtn.Text = "Search";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.UseWaitCursor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Snow;
            panel2.Controls.Add(dateEnd);
            panel2.Controls.Add(dateStart);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label11);
            panel2.Location = new Point(165, 148);
            panel2.Name = "panel2";
            panel2.Size = new Size(647, 218);
            panel2.TabIndex = 48;
            panel2.Paint += panel2_Paint;
            // 
            // dateEnd
            // 
            dateEnd.Checked = true;
            dateEnd.CustomizableEdges = customizableEdges1;
            dateEnd.FillColor = Color.Gainsboro;
            dateEnd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateEnd.Format = DateTimePickerFormat.Short;
            dateEnd.Location = new Point(322, 173);
            dateEnd.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dateEnd.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dateEnd.Name = "dateEnd";
            dateEnd.ShadowDecoration.CustomizableEdges = customizableEdges2;
            dateEnd.Size = new Size(126, 23);
            dateEnd.TabIndex = 51;
            dateEnd.Value = new DateTime(2023, 10, 16, 21, 5, 14, 851);
            dateEnd.Visible = false;
            dateEnd.ValueChanged += dateEnd_ValueChanged_1;
            // 
            // dateStart
            // 
            dateStart.Checked = true;
            dateStart.CustomizableEdges = customizableEdges3;
            dateStart.FillColor = Color.Gainsboro;
            dateStart.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateStart.Format = DateTimePickerFormat.Short;
            dateStart.Location = new Point(50, 173);
            dateStart.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dateStart.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dateStart.Name = "dateStart";
            dateStart.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dateStart.Size = new Size(126, 23);
            dateStart.TabIndex = 50;
            dateStart.Value = new DateTime(2023, 10, 16, 21, 5, 14, 851);
            dateStart.Visible = false;
            dateStart.ValueChanged += dateStart_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Montserrat", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(50, 22);
            label10.Name = "label10";
            label10.Size = new Size(108, 24);
            label10.TabIndex = 22;
            label10.Text = "Member Id";
            label10.Visible = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(319, 147);
            label17.Name = "label17";
            label17.Size = new Size(194, 22);
            label17.TabIndex = 41;
            label17.Text = "Subscription End date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(50, 48);
            label6.Name = "label6";
            label6.Size = new Size(143, 24);
            label6.TabIndex = 24;
            label6.Text = "Member Name";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(617, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 42;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(322, 97);
            label14.Name = "label14";
            label14.Size = new Size(147, 22);
            label14.TabIndex = 40;
            label14.Text = "Member Activity";
            label14.Visible = false;
            label14.Click += label14_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(50, 72);
            label2.Name = "label2";
            label2.Size = new Size(148, 24);
            label2.TabIndex = 28;
            label2.Text = "Member Phone";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(322, 72);
            label13.Name = "label13";
            label13.Size = new Size(138, 22);
            label13.TabIndex = 38;
            label13.Text = "Member Phone";
            label13.Visible = false;
            label13.Click += label13_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(50, 97);
            label5.Name = "label5";
            label5.Size = new Size(157, 24);
            label5.TabIndex = 30;
            label5.Text = "Member Activity";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(322, 48);
            label12.Name = "label12";
            label12.Size = new Size(134, 22);
            label12.TabIndex = 36;
            label12.Text = "Member Name";
            label12.Visible = false;
            label12.Click += label12_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Montserrat", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(50, 147);
            label8.Name = "label8";
            label8.Size = new Size(215, 24);
            label8.TabIndex = 34;
            label8.Text = "Subscription Start date";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(322, 22);
            label11.Name = "label11";
            label11.Size = new Size(100, 22);
            label11.TabIndex = 35;
            label11.Text = "Member Id";
            label11.Visible = false;
            label11.Click += label11_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(392, 100);
            label3.Name = "label3";
            label3.Size = new Size(0, 22);
            label3.TabIndex = 47;
            // 
            // memName
            // 
            memName.BackColor = Color.WhiteSmoke;
            memName.BorderStyle = BorderStyle.None;
            memName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            memName.Location = new Point(715, 107);
            memName.Name = "memName";
            memName.Size = new Size(139, 16);
            memName.TabIndex = 46;
            memName.TextChanged += memName_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(CrossBtn);
            panel1.Controls.Add(label1dzdz);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(953, 75);
            panel1.TabIndex = 44;
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
            label9.Click += label9_Click_1;
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
            // label1dzdz
            // 
            label1dzdz.AutoSize = true;
            label1dzdz.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1dzdz.ForeColor = Color.Black;
            label1dzdz.Location = new Point(85, 42);
            label1dzdz.Name = "label1dzdz";
            label1dzdz.Size = new Size(222, 26);
            label1dzdz.TabIndex = 5;
            label1dzdz.Text = "Subscription Manage";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(78, 100);
            label1.Name = "label1";
            label1.Size = new Size(635, 22);
            label1.TabIndex = 45;
            label1.Text = "Are you looking to stop a member's subscription? Please enter their full name.";
            // 
            // stopdate
            // 
            stopdate.BackColor = Color.DarkRed;
            stopdate.BackgroundImageLayout = ImageLayout.None;
            stopdate.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            stopdate.ForeColor = SystemColors.ControlLightLight;
            stopdate.Location = new Point(162, 378);
            stopdate.Margin = new Padding(0);
            stopdate.Name = "stopdate";
            stopdate.Size = new Size(190, 28);
            stopdate.TabIndex = 50;
            stopdate.Text = "Stop Subscription ";
            stopdate.UseVisualStyleBackColor = false;
            stopdate.UseWaitCursor = true;
            stopdate.Click += stopdate_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.OliveDrab;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(370, 378);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(193, 28);
            button2.TabIndex = 51;
            button2.Text = "Enable Subscription";
            button2.UseVisualStyleBackColor = false;
            button2.UseWaitCursor = true;
            button2.Click += button2_Click;
            // 
            // dateStop
            // 
            dateStop.AutoSize = true;
            dateStop.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateStop.ForeColor = Color.Black;
            dateStop.Location = new Point(167, 407);
            dateStop.Name = "dateStop";
            dateStop.Size = new Size(18, 22);
            dateStop.TabIndex = 49;
            dateStop.Text = "..";
            dateStop.Visible = false;
            dateStop.Click += dateStop_Click;
            // 
            // dateEnb
            // 
            dateEnb.AutoSize = true;
            dateEnb.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateEnb.ForeColor = Color.Black;
            dateEnb.Location = new Point(378, 407);
            dateEnb.Name = "dateEnb";
            dateEnb.Size = new Size(18, 22);
            dateEnb.TabIndex = 52;
            dateEnb.Text = "..";
            dateEnb.Visible = false;
            dateEnb.Click += dateEnb_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Segoe UI Historic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(693, 378);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(116, 28);
            button1.TabIndex = 53;
            button1.Text = "rearrange dates";
            button1.UseVisualStyleBackColor = false;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // Subscribs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(952, 453);
            Controls.Add(button1);
            Controls.Add(dateEnb);
            Controls.Add(dateStop);
            Controls.Add(button2);
            Controls.Add(stopdate);
            Controls.Add(DeleteBtn);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(memName);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Subscribs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "..";
            Load += Subscribs_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)CrossBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeleteBtn;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Label label10;
        private Label label17;
        private Label label6;
        private Label label14;
        private Label label2;
        private Label label13;
        private Label label5;
        private Label label12;
        private Label label8;
        private Label label11;
        private Label label3;
        private TextBox memName;
        private Panel panel1;
        private PictureBox CrossBtn;
        private Label label1dzdz;
        private PictureBox pictureBox1;
        private Label label1;
        private Button stopdate;
        private Button button2;
        private Label dateStop;
        private Label dateEnb;
        private Button button1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateStart;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateEnd;
        private Label label9;
        private PictureBox pictureBox2;
    }
}