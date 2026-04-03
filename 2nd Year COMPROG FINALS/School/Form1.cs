namespace School
{
    public partial class Form1 : Form
    {
        // GLOBAL VARIABLES
        public static string usernameAdmin = "admin";
        public static string passAdmin = "root";
        public static string username = " ";
        public static string pass = " ";
        int attempts = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            // IF MOUSE HOVER THE BUTTON
            btnLogin.BackColor = Color.Teal;
            btnLogin.ForeColor = Color.WhiteSmoke;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            // IF MOUSE LEAVE THE BUTTON
            btnLogin.BackColor = Color.WhiteSmoke;
            btnLogin.ForeColor = Color.Black;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // TO SHOW THE PASSWORD
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // LOGIN BUTTON
            username = textBox1.Text;
            pass = textBox2.Text;

            if (username.Equals(usernameAdmin) && pass.Equals(passAdmin))
            {
                // FOR ADMIN LOGIN
                MessageBox.Show($"Welcome back {username} to the system ", "Login successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Dashboard dashboardForm = new Dashboard();
                dashboardForm.ShowDialog();

            }
            else
            {
                // Invalid login attempt
                MessageBox.Show("Invalid username and password, Try again", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                attempts++;
            }

            if (attempts == 3)
            {
                // Exiting the application after 3 failed attempts
                MessageBox.Show("Too many failed attempts, You're now exiting this system", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit(); // exit the application
            }
        }

       
    }
}
