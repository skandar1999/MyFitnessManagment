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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyFitnessManagment
{
    public partial class Home : Form
    {

        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Documents\MyFitnessDB.mdf;Integrated Security=True;Connect Timeout=30";

        public Home()
        {
            InitializeComponent();
        }

        private void label1dzdz_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Employee employeeForm = new Employee();
            employeeForm.Show();
            this.Hide();
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            View viewForm = new View();
            viewForm.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Member memberForm = new Member();
            memberForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Subscribs SubscribsForm = new Subscribs();
            SubscribsForm.Show();
            this.Hide();
        }



        private void pictureBox4_Click(object sender, EventArgs e)
        {
            using (OnlyManager onlyManagerForm = new OnlyManager())
            {
                onlyManagerForm.ShowDialog();
            }
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            L.Show();
            this.Hide();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            ExpiredSubscribers ExpiredSubscribsForm = new ExpiredSubscribers();
            ExpiredSubscribsForm.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            Login L = new Login();
            L.Show();
            this.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
        private void DisplayFitnessMemberCount()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "SELECT COUNT(*) FROM MTBL WHERE memAct = 'Fitness'";
                    SqlCommand cmd = new SqlCommand(query, con);

                    // ExecuteScalar is used to retrieve a single value (the count in this case)
                    int fitnessMemberCount = Convert.ToInt32(cmd.ExecuteScalar());

                    // Display the count in the label
                    fitnessCountLabel.Text = fitnessMemberCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void DisplayBoxeMemberCount()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "SELECT COUNT(*) FROM MTBL WHERE memAct = 'Boxe'";
                    SqlCommand cmd = new SqlCommand(query, con);

                    // ExecuteScalar is used to retrieve a single value (the count in this case)
                    int fitnessMemberCount = Convert.ToInt32(cmd.ExecuteScalar());

                    // Display the count in the label
                    BoxeCountLabel.Text = fitnessMemberCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void DisplayMMAMemberCount()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "SELECT COUNT(*) FROM MTBL WHERE memAct = 'MMA'";
                    SqlCommand cmd = new SqlCommand(query, con);

                    // ExecuteScalar is used to retrieve a single value (the count in this case)
                    int fitnessMemberCount = Convert.ToInt32(cmd.ExecuteScalar());

                    // Display the count in the label
                    MMACountLabel.Text = fitnessMemberCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void DisplayAerobiqueMemberCount()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "SELECT COUNT(*) FROM MTBL WHERE memAct = 'Aerobique'";
                    SqlCommand cmd = new SqlCommand(query, con);

                    // ExecuteScalar is used to retrieve a single value (the count in this case)
                    int fitnessMemberCount = Convert.ToInt32(cmd.ExecuteScalar());

                    // Display the count in the label
                    aerolabel.Text = fitnessMemberCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void DisplayTaekwendoMemberCount()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "SELECT COUNT(*) FROM MTBL WHERE memAct = 'Taekwendo'";
                    SqlCommand cmd = new SqlCommand(query, con);

                    // ExecuteScalar is used to retrieve a single value (the count in this case)
                    int fitnessMemberCount = Convert.ToInt32(cmd.ExecuteScalar());

                    // Display the count in the label
                    Taekwendo.Text = fitnessMemberCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void DisplayYogaMemberCount()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "SELECT COUNT(*) FROM MTBL WHERE memAct = 'Yoga'";
                    SqlCommand cmd = new SqlCommand(query, con);

                    // ExecuteScalar is used to retrieve a single value (the count in this case)
                    int fitnessMemberCount = Convert.ToInt32(cmd.ExecuteScalar());

                    // Display the count in the label
                    yoga.Text = fitnessMemberCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void DisplayZumbaMemberCount()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "SELECT COUNT(*) FROM MTBL WHERE memAct = 'Zumba'";
                    SqlCommand cmd = new SqlCommand(query, con);

                    // ExecuteScalar is used to retrieve a single value (the count in this case)
                    int fitnessMemberCount = Convert.ToInt32(cmd.ExecuteScalar());

                    // Display the count in the label
                    zumba.Text = fitnessMemberCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void DisplayGymnastiqueMemberCount()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "SELECT COUNT(*) FROM MTBL WHERE memAct = 'Gymnastique'";
                    SqlCommand cmd = new SqlCommand(query, con);

                    // ExecuteScalar is used to retrieve a single value (the count in this case)
                    int fitnessMemberCount = Convert.ToInt32(cmd.ExecuteScalar());

                    // Display the count in the label
                    gymnas.Text = fitnessMemberCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void label29_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox11_Click_1(object sender, EventArgs e)
        {
            DisplayFitnessMemberCount();
            DisplayBoxeMemberCount();
            DisplayMMAMemberCount();
            DisplayAerobiqueMemberCount();
            DisplayTaekwendoMemberCount();
            DisplayYogaMemberCount();
            DisplayZumbaMemberCount();
            DisplayGymnastiqueMemberCount();


            fitnessCountLabel.Visible = true;
            BoxeCountLabel.Visible = true;
            MMACountLabel.Visible = true;
            aerolabel.Visible = true;
            Taekwendo.Visible = true;
            yoga.Visible = true;
            zumba.Visible = true;
            gymnas.Visible = true;


        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click_1(object sender, EventArgs e)
        {
            fitnessCountLabel.Visible = false;
            BoxeCountLabel.Visible = false;
            MMACountLabel.Visible = false;
            aerolabel.Visible = false;
            Taekwendo.Visible = false;
            yoga.Visible = false;
            zumba.Visible = false;
            gymnas.Visible = false;
        }
    }
}
