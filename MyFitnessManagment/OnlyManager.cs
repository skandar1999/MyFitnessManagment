using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFitnessManagment
{
    public partial class OnlyManager : Form
    {
        public OnlyManager()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void OnlyManager_Load(object sender, EventArgs e)
        {

        }

        private void CrossBtn_Click_1(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "1234")
            {
                Salary salaryForm = new Salary();
                salaryForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid code");
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;

        }
    }
}
