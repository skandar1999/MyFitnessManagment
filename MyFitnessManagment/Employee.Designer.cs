namespace MyFitnessManagment
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label9 = new Label();
            CrossBtn = new PictureBox();
            pictureBox2 = new PictureBox();
            label1dzdz = new Label();
            pictureBox1 = new PictureBox();
            empName = new TextBox();
            label2 = new Label();
            empPhone = new TextBox();
            label3 = new Label();
            empAdd = new TextBox();
            label4 = new Label();
            label5 = new Label();
            empAct = new ComboBox();
            empGend = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            hirDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            AddBtn = new Button();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            dataGridView1 = new DataGridView();
            ResetBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CrossBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(CrossBtn);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1dzdz);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(954, 75);
            panel1.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Montserrat", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(130, 27);
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
            CrossBtn.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(87, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 30);
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
            label1dzdz.Size = new Size(196, 26);
            label1dzdz.TabIndex = 5;
            label1dzdz.Text = "Manage Employee";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // empName
            // 
            empName.Location = new Point(10, 134);
            empName.Name = "empName";
            empName.Size = new Size(127, 23);
            empName.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(10, 113);
            label2.Name = "label2";
            label2.Size = new Size(122, 18);
            label2.TabIndex = 10;
            label2.Text = "Employee Name";
            // 
            // empPhone
            // 
            empPhone.Location = new Point(10, 191);
            empPhone.Name = "empPhone";
            empPhone.Size = new Size(133, 23);
            empPhone.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(10, 170);
            label3.Name = "label3";
            label3.Size = new Size(126, 18);
            label3.TabIndex = 14;
            label3.Text = "Employee Phone";
            // 
            // empAdd
            // 
            empAdd.Location = new Point(151, 134);
            empAdd.Name = "empAdd";
            empAdd.Size = new Size(137, 23);
            empAdd.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(151, 113);
            label4.Name = "label4";
            label4.Size = new Size(137, 18);
            label4.TabIndex = 12;
            label4.Text = "Employee Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(11, 230);
            label5.Name = "label5";
            label5.Size = new Size(135, 18);
            label5.TabIndex = 16;
            label5.Text = "Employee Activity";
            // 
            // empAct
            // 
            empAct.FormattingEnabled = true;
            empAct.Items.AddRange(new object[] { "Coach Fitness", "Coach Taekwendo", "Coach MMA", "Coach Boxe", "Coach Aerobique", "Coach Yoga", "cleaner", "Security" });
            empAct.Location = new Point(10, 251);
            empAct.Name = "empAct";
            empAct.Size = new Size(134, 23);
            empAct.TabIndex = 17;
            // 
            // empGend
            // 
            empGend.FormattingEnabled = true;
            empGend.Items.AddRange(new object[] { "Male", "Female" });
            empGend.Location = new Point(152, 191);
            empGend.Name = "empGend";
            empGend.Size = new Size(136, 23);
            empGend.TabIndex = 19;
            empGend.SelectedIndexChanged += empGend_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(152, 170);
            label7.Name = "label7";
            label7.Size = new Size(131, 18);
            label7.TabIndex = 18;
            label7.Text = "Employee Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(152, 230);
            label8.Name = "label8";
            label8.Size = new Size(84, 18);
            label8.TabIndex = 20;
            label8.Text = "hiring date";
            // 
            // hirDate
            // 
            hirDate.Checked = true;
            hirDate.CustomizableEdges = customizableEdges1;
            hirDate.FillColor = Color.Gainsboro;
            hirDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            hirDate.Format = DateTimePickerFormat.Short;
            hirDate.Location = new Point(150, 251);
            hirDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            hirDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            hirDate.Name = "hirDate";
            hirDate.ShadowDecoration.CustomizableEdges = customizableEdges2;
            hirDate.Size = new Size(138, 23);
            hirDate.TabIndex = 21;
            hirDate.Value = new DateTime(2023, 10, 16, 21, 5, 14, 851);
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Black;
            AddBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddBtn.ForeColor = SystemColors.ControlLightLight;
            AddBtn.Location = new Point(38, 325);
            AddBtn.Name = "AddBtn";
            AddBtn.Padding = new Padding(2, 0, 2, 0);
            AddBtn.Size = new Size(109, 33);
            AddBtn.TabIndex = 22;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.Black;
            UpdateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateBtn.ForeColor = SystemColors.ControlLightLight;
            UpdateBtn.Location = new Point(153, 325);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Padding = new Padding(2, 0, 2, 0);
            UpdateBtn.Size = new Size(108, 33);
            UpdateBtn.TabIndex = 23;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Black;
            DeleteBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteBtn.ForeColor = SystemColors.ControlLightLight;
            DeleteBtn.Location = new Point(154, 364);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Padding = new Padding(2, 0, 2, 0);
            DeleteBtn.Size = new Size(107, 33);
            DeleteBtn.TabIndex = 24;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(301, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(639, 309);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.Black;
            ResetBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ResetBtn.ForeColor = SystemColors.ControlLightLight;
            ResetBtn.Location = new Point(38, 364);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Padding = new Padding(2, 0, 2, 0);
            ResetBtn.Size = new Size(109, 33);
            ResetBtn.TabIndex = 26;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(952, 454);
            Controls.Add(ResetBtn);
            Controls.Add(dataGridView1);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(AddBtn);
            Controls.Add(hirDate);
            Controls.Add(label8);
            Controls.Add(empGend);
            Controls.Add(label7);
            Controls.Add(empAct);
            Controls.Add(label5);
            Controls.Add(empPhone);
            Controls.Add(label3);
            Controls.Add(empAdd);
            Controls.Add(label4);
            Controls.Add(empName);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CrossBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1dzdz;
        private PictureBox pictureBox1;
        private TextBox empName;
        private Label label2;
        private TextBox empPhone;
        private Label label3;
        private TextBox empAdd;
        private Label label4;
        private Label label5;
        private ComboBox empAct;
        private ComboBox empGend;
        private Label label7;
        private Label label8;
        private Guna.UI2.WinForms.Guna2DateTimePicker hirDate;
        private Button AddBtn;
        private PictureBox pictureBox2;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private PictureBox CrossBtn;
        private Label label9;
        private DataGridView dataGridView1;
        private Button ResetBtn;
    }
}