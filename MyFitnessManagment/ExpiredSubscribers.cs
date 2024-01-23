using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFitnessManagment
{
    public partial class ExpiredSubscribers : Form
    {

        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Documents\MyFitnessDB.mdf;Integrated Security=True;Connect Timeout=30";
        private object empId;
        public ExpiredSubscribers()
        {
            InitializeComponent();
            DisplayMem();
        }


        private void DisplayMem()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string currentDate = DateTime.Now.ToString("yyyy-MM-dd");  // Use the format 'yyyy-MM-dd' for SQL Server

                    // Add a WHERE clause to filter members based on dateEnd
                    string query = $"SELECT memName AS 'Member Name', memPhone AS 'Member Phone', memAct AS 'Member Activity', dateStart AS 'Member Start Date', dateEnd AS 'Member End Date' FROM MTBL WHERE CONVERT(date, dateEnd, 103) <= '{currentDate}'";

                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                    var ds = new DataSet();
                    sda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];

                    // Set the column header text
                    dataGridView1.Columns[0].HeaderText = "Name";
                    dataGridView1.Columns[1].HeaderText = "Phone";
                    dataGridView1.Columns[2].HeaderText = "Activity";
                    dataGridView1.Columns[3].HeaderText = "Start Date";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }





        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Stop all execution

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }
}



