using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarkett
{
    public partial class ChoicsForm : Form
    {
        public ChoicsForm()
        {
            InitializeComponent();
        }

        private void login_lbl_Click(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();
        }

        private void exit_btn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
