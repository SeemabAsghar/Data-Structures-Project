using System;
using System.Windows.Forms;
using BCrypt.Net;
namespace SuperMarkett
{
    public partial class Login : Form
    {
        private const string AdminUsername = "admin";
        private static readonly string AdminPassword = BCrypt.Net.BCrypt.HashPassword ("0101");
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        

        private void reset_btn_Click(object sender, EventArgs e)
        {
            username_txt.Clear();
            password_txt.Clear();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void wlcm_lbl_Click(object sender, EventArgs e)
        {

        }
        private void login_btn_Click(object sender, EventArgs e)
        {
            try {
                
                string username = username_txt.Text;
                string password = password_txt.Text;
               
                if (username == AdminUsername && BCrypt.Net.BCrypt.Verify(password, AdminPassword))
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
            }
            catch(InvalidOperationException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void password_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            Order signupForm = new Order();
            signupForm.Show();
        }

        private void reset_btn_Click_1(object sender, EventArgs e)
        {
            username_txt.Clear();
            password_txt.Clear();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
