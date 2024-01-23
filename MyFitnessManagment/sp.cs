namespace MyFitnessManagment
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 2;

            // If the panel has reached the desired width, stop the timer and navigate to LoginForm
            if (panel1.Width >= 430)  // Change 300 to your desired width
            {
                timer1.Stop();

                // Navigate to LoginForm
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}