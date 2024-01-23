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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyFitnessManagment
{
    public partial class Member : Form
    {

        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Documents\MyFitnessDB.mdf;Integrated Security=True;Connect Timeout=30";

        public Member()
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
                    string currentDate = DateTime.Now.ToString("dd/MM/yyyy");
                    string query = "SELECT memName AS 'Member Name', memPhone AS 'Member Phone', memAge AS 'Member Age', memGend AS 'Member Genre', memAct AS 'Member Activity', dateStart AS 'Member Start Date', dateEnd AS 'Member End Date' FROM MTBL";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                    var ds = new DataSet();
                    sda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];

                    // Set the column header text
                    dataGridView1.Columns[0].HeaderText = "Name";
                    dataGridView1.Columns[1].HeaderText = "Phone";
                    dataGridView1.Columns[2].HeaderText = "Age";
                    dataGridView1.Columns[3].HeaderText = "Genre";
                    dataGridView1.Columns[4].HeaderText = "Activity";
                    dataGridView1.Columns[5].HeaderText = "Start Date";
                    dataGridView1.Columns[6].HeaderText = "End Date";

                    // Customize cell formatting to display the "Member End Date" in red if it matches the current date
                    dataGridView1.CellFormatting += (sender, e) =>
                    {
                        if (e.ColumnIndex == 7 && e.Value != null && Convert.ToDateTime(e.Value) < DateTime.Now)
                        {
                            e.CellStyle.ForeColor = Color.Red;
                        }
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void Member_Load(object sender, EventArgs e)
        {

        }



        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(memName.Text) || string.IsNullOrWhiteSpace(memPhone.Text) || string.IsNullOrWhiteSpace(memAge.Text) || string.IsNullOrWhiteSpace(memGend.Text) || string.IsNullOrWhiteSpace(memAct.Text) || dateStart.Value == null || dateEnd.Value == null)
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "INSERT INTO MTBL (memName, memPhone, memAge, memGend, memAct, dateStart, dateEnd, dateStopSubs, dateEnablSubs) VALUES (@val1, @val2, @val3, @val4, @val5, @val6, @val7, @val8, @val9)";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@val1", memName.Text);
                        cmd.Parameters.AddWithValue("@val2", memPhone.Text);
                        cmd.Parameters.AddWithValue("@val3", memAge.Text);
                        cmd.Parameters.AddWithValue("@val4", memGend.Text);
                        cmd.Parameters.AddWithValue("@val5", memAct.Text);
                        cmd.Parameters.AddWithValue("@val6", dateStart.Value.Date); // Assuming dateStart is a DateTimePicker
                        cmd.Parameters.AddWithValue("@val7", dateEnd.Value.Date);   // Assuming dateEnd is a DateTimePicker
                        cmd.Parameters.AddWithValue("@val8", "none");
                        cmd.Parameters.AddWithValue("@val9", "none");

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record inserted successfully!");
                        DisplayMem();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                memName.Text = row.Cells["Member Name"].Value.ToString();
                memPhone.Text = row.Cells["Member Phone"].Value.ToString();
                memAge.Text = row.Cells["Member Age"].Value.ToString();
                memGend.Text = row.Cells["Member Genre"].Value.ToString();
                memAct.Text = row.Cells["Member Activity"].Value.ToString();
                dateStart.Text = row.Cells["Member Start Date"].Value.ToString();
                dateEnd.Text = row.Cells["Member End Date"].Value.ToString();

            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            memName.Text = "";
            memPhone.Text = "";
            memAge.Text = "";
            memGend.Text = "";
            memAct.Text = "";


        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Stop all execution

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if ( string.IsNullOrWhiteSpace(memName.Text) || string.IsNullOrWhiteSpace(memPhone.Text) || string.IsNullOrWhiteSpace(memAge.Text) || string.IsNullOrWhiteSpace(memGend.Text) || string.IsNullOrWhiteSpace(memAct.Text) || string.IsNullOrWhiteSpace(dateStart.Text) || string.IsNullOrWhiteSpace(dateEnd.Text))
                {
                    MessageBox.Show("Please fill in all the fields.");
                }
                else
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        string selectedmemName = dataGridView1.SelectedRows[0].Cells["Member Name"].Value.ToString();
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();
                            string query = "UPDATE MTBL SET memName = @val2, memPhone = @val3, memAge = @val4, memGend = @val5, memAct = @val6, dateStart = @val7, dateEnd = @val8 WHERE memName = @val1";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@val1", selectedmemName);
                            cmd.Parameters.AddWithValue("@val2", memName.Text);
                            cmd.Parameters.AddWithValue("@val3", memPhone.Text);
                            cmd.Parameters.AddWithValue("@val4", memAge.Text);
                            cmd.Parameters.AddWithValue("@val5", memGend.Text);
                            cmd.Parameters.AddWithValue("@val6", memAct.Text);  
                            cmd.Parameters.AddWithValue("@val7", dateStart.Value.Date); 
                            cmd.Parameters.AddWithValue("@val8", dateEnd.Value.Date);


                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Member updated successfully!");
                                DisplayMem();
                            }
                            else
                            {
                                MessageBox.Show("No records were updated. Please check the provided Member ID.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a row to update.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void memId_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string selectedMemId = dataGridView1.SelectedRows[0].Cells["Member Name"].Value.ToString();
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "DELETE FROM MTBL WHERE memName = @memName";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@memName", selectedMemId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record deleted successfully!");
                        DisplayMem();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.");
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
    }
}


