namespace MyFitnessManagment
{
    partial class Member
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DeleteBtn = new Button();
            UpdateBtn = new Button();
            AddBtn = new Button();
            dateEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label8 = new Label();
            memGend = new ComboBox();
            label7 = new Label();
            memAct = new ComboBox();
            label5 = new Label();
            memAge = new TextBox();
            label3 = new Label();
            memPhone = new TextBox();
            label4 = new Label();
            memName = new TextBox();
            label9 = new Label();
            CrossBtn = new PictureBox();
            pictureBox2 = new PictureBox();
            label1dzdz = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            dateStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label6 = new Label();
            ResetBtn = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)CrossBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Black;
            DeleteBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteBtn.ForeColor = SystemColors.ControlLightLight;
            DeleteBtn.Location = new Point(148, 384);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Padding = new Padding(2, 0, 2, 0);
            DeleteBtn.Size = new Size(104, 33);
            DeleteBtn.TabIndex = 43;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.Black;
            UpdateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateBtn.ForeColor = SystemColors.ControlLightLight;
            UpdateBtn.Location = new Point(146, 345);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Padding = new Padding(2, 0, 2, 0);
            UpdateBtn.Size = new Size(106, 33);
            UpdateBtn.TabIndex = 42;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Black;
            AddBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddBtn.ForeColor = SystemColors.ControlLightLight;
            AddBtn.Location = new Point(35, 345);
            AddBtn.Name = "AddBtn";
            AddBtn.Padding = new Padding(2, 0, 2, 0);
            AddBtn.Size = new Size(105, 33);
            AddBtn.TabIndex = 41;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // dateEnd
            // 
            dateEnd.Checked = true;
            dateEnd.CustomizableEdges = customizableEdges1;
            dateEnd.FillColor = Color.LightGray;
            dateEnd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateEnd.Format = DateTimePickerFormat.Short;
            dateEnd.Location = new Point(146, 296);
            dateEnd.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dateEnd.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dateEnd.Name = "dateEnd";
            dateEnd.ShadowDecoration.CustomizableEdges = customizableEdges2;
            dateEnd.Size = new Size(118, 23);
            dateEnd.TabIndex = 40;
            dateEnd.Value = new DateTime(2023, 10, 16, 21, 5, 14, 851);
            dateEnd.ValueChanged += dateEnd_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(148, 275);
            label8.Name = "label8";
            label8.Size = new Size(69, 18);
            label8.TabIndex = 39;
            label8.Text = "end date";
            // 
            // memGend
            // 
            memGend.FormattingEnabled = true;
            memGend.Items.AddRange(new object[] { "Male", "Female" });
            memGend.Location = new Point(14, 230);
            memGend.Name = "memGend";
            memGend.Size = new Size(118, 23);
            memGend.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(14, 209);
            label7.Name = "label7";
            label7.Size = new Size(62, 18);
            label7.TabIndex = 37;
            label7.Text = " Gender";
            // 
            // memAct
            // 
            memAct.FormattingEnabled = true;
            memAct.Items.AddRange(new object[] { "Fitness", "Taekwendo", "MMA", "Boxe", "Aerobique", "Yoga", "Gymnastique ", "Zumba " });
            memAct.Location = new Point(147, 230);
            memAct.Name = "memAct";
            memAct.Size = new Size(117, 23);
            memAct.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(148, 209);
            label5.Name = "label5";
            label5.Size = new Size(62, 18);
            label5.TabIndex = 35;
            label5.Text = "Activity";
            // 
            // memAge
            // 
            memAge.Location = new Point(146, 179);
            memAge.Name = "memAge";
            memAge.Size = new Size(118, 23);
            memAge.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(146, 158);
            label3.Name = "label3";
            label3.Size = new Size(96, 18);
            label3.TabIndex = 33;
            label3.Text = "Member Age";
            // 
            // memPhone
            // 
            memPhone.Location = new Point(14, 179);
            memPhone.Name = "memPhone";
            memPhone.Size = new Size(118, 23);
            memPhone.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(14, 158);
            label4.Name = "label4";
            label4.Size = new Size(53, 18);
            label4.TabIndex = 31;
            label4.Text = "Phone";
            // 
            // memName
            // 
            memName.Location = new Point(13, 121);
            memName.Name = "memName";
            memName.Size = new Size(251, 23);
            memName.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Montserrat", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(109, 17);
            label9.Name = "label9";
            label9.Size = new Size(33, 12);
            label9.TabIndex = 10;
            label9.Text = "Home";
            label9.Click += label9_Click;
            // 
            // CrossBtn
            // 
            CrossBtn.Image = (Image)resources.GetObject("CrossBtn.Image");
            CrossBtn.Location = new Point(929, 3);
            CrossBtn.Name = "CrossBtn";
            CrossBtn.Size = new Size(22, 20);
            CrossBtn.SizeMode = PictureBoxSizeMode.Zoom;
            CrossBtn.TabIndex = 9;
            CrossBtn.TabStop = false;
            CrossBtn.Click += CrossBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(87, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(22, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1dzdz
            // 
            label1dzdz.AutoSize = true;
            label1dzdz.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1dzdz.ForeColor = Color.Black;
            label1dzdz.Location = new Point(85, 42);
            label1dzdz.Name = "label1dzdz";
            label1dzdz.Size = new Size(180, 26);
            label1dzdz.TabIndex = 5;
            label1dzdz.Text = "Manage Member";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(13, 100);
            label2.Name = "label2";
            label2.Size = new Size(139, 18);
            label2.TabIndex = 29;
            label2.Text = "Member Full Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(CrossBtn);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1dzdz);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(954, 75);
            panel1.TabIndex = 26;
            // 
            // dateStart
            // 
            dateStart.Checked = true;
            dateStart.CustomizableEdges = customizableEdges3;
            dateStart.FillColor = Color.LightGray;
            dateStart.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateStart.Format = DateTimePickerFormat.Short;
            dateStart.Location = new Point(11, 296);
            dateStart.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dateStart.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dateStart.Name = "dateStart";
            dateStart.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dateStart.Size = new Size(121, 23);
            dateStart.TabIndex = 46;
            dateStart.Value = new DateTime(2023, 10, 16, 21, 5, 14, 851);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(13, 275);
            label6.Name = "label6";
            label6.Size = new Size(77, 18);
            label6.TabIndex = 45;
            label6.Text = "Start date";
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.Black;
            ResetBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ResetBtn.ForeColor = SystemColors.ControlLightLight;
            ResetBtn.Location = new Point(35, 384);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Padding = new Padding(2, 0, 2, 0);
            ResetBtn.Size = new Size(105, 33);
            ResetBtn.TabIndex = 47;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(286, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(654, 309);
            dataGridView1.TabIndex = 48;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Member
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(952, 454);
            Controls.Add(dataGridView1);
            Controls.Add(ResetBtn);
            Controls.Add(dateStart);
            Controls.Add(label6);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(AddBtn);
            Controls.Add(dateEnd);
            Controls.Add(label8);
            Controls.Add(memGend);
            Controls.Add(label7);
            Controls.Add(memAct);
            Controls.Add(label5);
            Controls.Add(memAge);
            Controls.Add(label3);
            Controls.Add(memPhone);
            Controls.Add(label4);
            Controls.Add(memName);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Member";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member";
            Load += Member_Load;
            ((System.ComponentModel.ISupportInitialize)CrossBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button DeleteBtn;
        private Button UpdateBtn;
        private Button AddBtn;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateEnd;
        private Label label8;
        private ComboBox memGend;
        private Label label7;
        private ComboBox memAct;
        private Label label5;
        private TextBox memAge;
        private Label label3;
        private TextBox memPhone;
        private Label label4;
        private TextBox memName;
        private Label label9;
        private PictureBox CrossBtn;
        private PictureBox pictureBox2;
        private Label label1dzdz;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateStart;
        private Label label6;
        private Button ResetBtn;
        private DataGridView dataGridView1;
    }
}