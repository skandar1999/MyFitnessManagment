using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyFitnessManagment
{
    public partial class View : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Documents\MyFitnessDB.mdf;Integrated Security=True;Connect Timeout=30";

        public View()
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
                    string query = "SELECT * FROM ETBL WHERE empName LIKE '%' + @empName + '%'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@empName", empName.Text);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            label12.Text = reader["empName"].ToString();
                            label13.Text = reader["empAdd"].ToString();
                            label14.Text = reader["empPhone"].ToString();
                            label15.Text = reader["empAct"].ToString();
                            label16.Text = reader["empGend"].ToString();
                            label17.Text = reader["hirDate"].ToString();

                            label12.Visible = true;
                            label13.Visible = true;
                            label14.Visible = true;
                            label15.Visible = true;
                            label16.Visible = true;
                            label17.Visible = true;


                        }
                    }
                    else
                    {
                        MessageBox.Show("Employee with the specified name does not exist.");
                    }

                    con.Close();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            // Implement Refresh button functionality
        }

        private void empName_TextChanged(object sender, EventArgs e)
        {
            // Add functionality if needed for text change in the employee name field
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Fetchemp();
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            empName.Text = string.Empty;
            label12.Text = string.Empty;
            label13.Text = string.Empty;
            label14.Text = string.Empty;
            label15.Text = string.Empty;
            label16.Text = string.Empty;
            label17.Text = string.Empty;
        }

        private void empName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
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
