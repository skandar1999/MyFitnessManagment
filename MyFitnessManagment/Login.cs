using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace MyFitnessManagment
{
    public partial class Login : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Documents\MyFitnessDB.mdf;Integrated Security=True;Connect Timeout=30";

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM [USER] WHERE Username=@Username AND Password=@Password";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        Home h = new Home();
                        h.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password", "Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Stop all execution
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

            using (ConfirmResetPassword onlyManagerForm = new ConfirmResetPassword())
            {
                onlyManagerForm.ShowDialog();
            }
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

