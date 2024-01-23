using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFitnessManagment
{
    public partial class Subscribs : Form
    {

        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Documents\MyFitnessDB.mdf;Integrated Security=True;Connect Timeout=30";

        public Subscribs()
        {
            InitializeComponent();
        }


        private void Fetchemp()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM MTBL WHERE memName LIKE '%' + @memName + '%'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@memName", memName.Text);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            label12.Text = reader["memName"].ToString();
                            label13.Text = reader["memPhone"].ToString();
                            label14.Text = reader["memAct"].ToString();
                            dateStart.Text = reader["dateStart"].ToString();
                            dateEnd.Text = reader["dateEnd"].ToString();
                            dateStop.Text = reader["dateStopSubs"].ToString();
                            dateEnb.Text = reader["dateEnablSubs"].ToString();

                            label12.Visible = true;
                            label13.Visible = true;
                            label14.Visible = true;
                            dateStart.Visible = true;
                            dateEnd.Visible = true;

                            dateStop.Visible = true;
                            dateEnb.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Member with the specified name does not exist.");
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }




        private void pictureBox3_Click(object sender, EventArgs e)
        {

            label11.Text = string.Empty;
            label12.Text = string.Empty;
            label13.Text = string.Empty;
            label14.Text = string.Empty;
            dateStart.Visible = false;
            dateEnd.Visible = false;
            dateStop.Visible = false;
            dateEnb.Visible = false;


        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Stop all execution

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Fetchemp();
        }


        private void stopdate_Click(object sender, EventArgs e)
        {
            DateTime dateStopSubs = DateTime.Now;

            dateStop.Text = dateStopSubs.ToString(); // For label15 

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "UPDATE MTBL SET dateStopSubs = @dateStopSubs WHERE memName = @memName";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@dateStopSubs", dateStopSubs.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@memName", memName.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Subscription stopped successfully!");
                        Fetchemp();
                    }
                    else
                    {
                        MessageBox.Show("No records were updated. Please check the provided Member Name.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dateEnablSubs = DateTime.Now;
            // You can then use the dateStartSubs as needed, such as setting it to a label
            // For example:
            dateEnb.Text = dateEnablSubs.ToString(); // Assuming label15 is where you want to display the date

            // Or you can use it to update the database as well
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "UPDATE MTBL SET dateEnablSubs = @dateStartSubs WHERE memName = @memName";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@dateStartSubs", dateEnablSubs.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@memName", memName.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Subscription enabled successfully!");
                        Fetchemp();
                    }
                    else
                    {
                        MessageBox.Show("No records were updated. Please check the provided Member Name.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateEnd.Value; // Assuming dateTimePicker1 is the control for selecting the new date

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "UPDATE MTBL SET dateEnd = @selectedDate, dateStopSubs = @none, dateEnablSubs = @none WHERE memName = @memName";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@selectedDate", selectedDate.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@none", "none");
                    cmd.Parameters.AddWithValue("@memName", memName.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("End date updated successfully!");
                        Fetchemp();
                    }
                    else
                    {
                        MessageBox.Show("No records were updated. Please check the provided Member Name.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void dateEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateEnd_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void dateStart_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Subscribs_Load(object sender, EventArgs e)
        {

        }

        private void memName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateStop_Click(object sender, EventArgs e)
        {

        }

        private void dateEnb_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }
    }
}
