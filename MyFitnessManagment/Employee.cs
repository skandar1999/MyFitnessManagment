using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyFitnessManagment
{
    public partial class Employee : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Documents\MyFitnessDB.mdf;Integrated Security=True;Connect Timeout=30";

        public Employee()
        {
            InitializeComponent();
            DisplayEmp();
        }

        private void DisplayEmp()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT empName AS 'Employee Name', empAdd AS 'Employee Address', empPhone AS 'Employee Phone' ,  empGend AS 'Employee Genre' , empAct AS 'Employee Activity',  hirDate AS 'Employee Hiring Date'  FROM ETBL";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                    var ds = new DataSet();
                    sda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];

                    // Set the column header text
                    dataGridView1.Columns[0].HeaderText = "Employee Name";
                    dataGridView1.Columns[1].HeaderText = "Employee Address";
                    dataGridView1.Columns[2].HeaderText = "Employee Phone";
                    dataGridView1.Columns[3].HeaderText = "Employee Genre";
                    dataGridView1.Columns[4].HeaderText = "Employee Activity";
                    dataGridView1.Columns[5].HeaderText = "Hiring Date";


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string selectedEmpName = dataGridView1.SelectedRows[0].Cells["Employee Name"].Value.ToString();
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "DELETE FROM ETBL WHERE empName = @empName";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@empName", selectedEmpName);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record deleted successfully!");
                        DisplayEmp();
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





        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                empName.Text = row.Cells["Employee Name"].Value.ToString();
                empAdd.Text = row.Cells["Employee Address"].Value.ToString();
                empPhone.Text = row.Cells["Employee Phone"].Value.ToString();
                empGend.Text = row.Cells["Employee Genre"].Value.ToString();
                empAct.Text = row.Cells["Employee Activity"].Value.ToString();
                hirDate.Text = row.Cells["Employee Hiring Date"].Value.ToString();

            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(empName.Text) || string.IsNullOrWhiteSpace(empAdd.Text) || string.IsNullOrWhiteSpace(empPhone.Text) || string.IsNullOrWhiteSpace(empAct.Text) || string.IsNullOrWhiteSpace(empGend.Text) || string.IsNullOrWhiteSpace(hirDate.Text))
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "INSERT INTO ETBL ( empName, empAdd, empPhone, empAct, empGend, hirDate) VALUES (@val1, @val2, @val3, @val4, @val5, @val6)";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@val1", empName.Text);
                        cmd.Parameters.AddWithValue("@val2", empAdd.Text);
                        cmd.Parameters.AddWithValue("@val3", empPhone.Text);
                        cmd.Parameters.AddWithValue("@val4", empAct.Text);
                        cmd.Parameters.AddWithValue("@val5", empGend.Text);
                        cmd.Parameters.AddWithValue("@val6", hirDate.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record inserted successfully!");
                        DisplayEmp();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(empName.Text) || string.IsNullOrWhiteSpace(empAdd.Text) || string.IsNullOrWhiteSpace(empPhone.Text) || string.IsNullOrWhiteSpace(empAct.Text) || string.IsNullOrWhiteSpace(empGend.Text) || string.IsNullOrWhiteSpace(hirDate.Text))
                {
                    MessageBox.Show("Please fill in all the fields.");
                }
                else
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        string selectedEmpName = dataGridView1.SelectedRows[0].Cells["Employee Name"].Value.ToString();
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();
                            string query = "UPDATE ETBL SET empName = @val2, empAdd = @val3, empPhone = @val4, empAct = @val5, empGend = @val6, hirDate = @val7 WHERE empName = @val1";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@val1", selectedEmpName);
                            cmd.Parameters.AddWithValue("@val2", empName.Text);
                            cmd.Parameters.AddWithValue("@val3", empAdd.Text);
                            cmd.Parameters.AddWithValue("@val4", empPhone.Text);
                            cmd.Parameters.AddWithValue("@val5", empAct.Text);
                            cmd.Parameters.AddWithValue("@val6", empGend.Text);
                            cmd.Parameters.AddWithValue("@val7", hirDate.Text);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record updated successfully!");
                                DisplayEmp();
                            }
                            else
                            {
                                MessageBox.Show("No records were updated. Please check the provided Employee ID.");
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



        private void ResetBtn_Click(object sender, EventArgs e)
        {
            empName.Text = "";
            empAdd.Text = "";
            empPhone.Text = "";
            empGend.Text = "";
            empAct.Text = "";
            hirDate.Text = "";

        }

        private void empGend_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void empId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        
       


    }
}
