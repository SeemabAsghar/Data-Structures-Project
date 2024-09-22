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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void prdct_btn_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
        }
        private void ctgry_btn_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();
        }
        private void invntry_btn_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.Show();
        }
        private void cstmr_btn_Click(object sender, EventArgs e)
        {
        }
        private void logout_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to logout?");
            Close();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
