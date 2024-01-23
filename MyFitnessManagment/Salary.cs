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
    public partial class Salary : Form
    {

        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Documents\MyFitnessDB.mdf;Integrated Security=True;Connect Timeout=30";

        public Salary()
        {
            InitializeComponent();
            DisplaySalary();
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
                            // Store the empId in the variable
                            label7.Text = reader["empId"].ToString();
                            label12.Text = reader["empName"].ToString();
                            label13.Text = reader["empPhone"].ToString();
                            label14.Text = reader["empAct"].ToString();

                            label12.Visible = true;
                            label13.Visible = true;
                            label14.Visible = true;
                            hirDate.Visible = true;
                            textBox2.Visible = true;
                            button1.Visible = true;
                            label6.Visible = true;
                            label2.Visible = true;
                            label5.Visible = true;
                            label8.Visible = true;
                            label4.Visible = true;


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
        private void CrossBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Stop all execution

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void dateEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Fetchemp();
        }

        private void memName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void hirDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            label12.Text = string.Empty;
            label13.Text = string.Empty;
            label14.Text = string.Empty;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(hirDate.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        // Use the stored empId and empName in the insert query
                        string insertQuery = "INSERT INTO SALARY (EmployeeID, EmployeeName, SalaryAmount, Date) VALUES (@empId, @empName, @salaryAmount, @date)";
                        SqlCommand insertCmd = new SqlCommand(insertQuery, con);

                        // Use the empId and empName obtained during data fetch
                        insertCmd.Parameters.AddWithValue("@empId", Convert.ToInt32(label7.Text));
                        insertCmd.Parameters.AddWithValue("@empName", label12.Text);

                        insertCmd.Parameters.AddWithValue("@salaryAmount", textBox2.Text);
                        insertCmd.Parameters.AddWithValue("@date", hirDate.Text);

                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show("Payment Record inserted successfully!");
                        DisplaySalary();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }



        private void DisplaySalary()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT EmployeeName , SalaryAmount , Date FROM SALARY ";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                    var ds = new DataSet();
                    sda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];

                    // Set the column header text
                    dataGridView1.Columns[0].HeaderText = "Employee Name";
                    dataGridView1.Columns[1].HeaderText = "Payed Salary";
                    dataGridView1.Columns[2].HeaderText = "Payment Date";
                    


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
