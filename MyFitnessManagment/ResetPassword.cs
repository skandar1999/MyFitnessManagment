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
    public partial class ResetPassword : Form
    {

        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Documents\MyFitnessDB.mdf;Integrated Security=True;Connect Timeout=30";

        public ResetPassword()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Stop all execution

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Login h = new Login();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currentPassword = textBox1.Text;
            string newPassword = textBox2.Text;
            string confirmNewPassword = textBox3.Text;
            string fixedUsername = "receptioniste"; // Fixed username

            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("New password and confirm password do not match.", "Error");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Verify the current password for the fixed username
                    string verifyQuery = "SELECT * FROM [USER] WHERE Username=@Username AND Password=@CurrentPassword";
                    SqlCommand verifyCmd = new SqlCommand(verifyQuery, con);
                    verifyCmd.Parameters.AddWithValue("@Username", fixedUsername);
                    verifyCmd.Parameters.AddWithValue("@CurrentPassword", currentPassword);

                    SqlDataAdapter verifySda = new SqlDataAdapter(verifyCmd);
                    DataTable verifyDt = new DataTable();
                    verifySda.Fill(verifyDt);

                    if (verifyDt.Rows.Count > 0)
                    {
                        // Update the user's password for the fixed username
                        string updateQuery = "UPDATE [USER] SET Password=@NewPassword WHERE Username=@Username";
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                        {
                            updateCmd.Parameters.AddWithValue("@NewPassword", newPassword);
                            updateCmd.Parameters.AddWithValue("@Username", fixedUsername);
                            updateCmd.ExecuteNonQuery();

                            MessageBox.Show("Password updated successfully.");
                            Login loginForm = new Login();
                            loginForm.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid current password.", "Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = true;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.UseSystemPasswordChar = true;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBox3.UseSystemPasswordChar = false;

        }
    }
}
    

