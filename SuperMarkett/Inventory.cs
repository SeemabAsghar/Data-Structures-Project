using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SuperMarkett
{

    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
            InitializeControls();
            PopulateComboBox();
        }
        private readonly string productFile = @"C:\Users\Seemab\source\repos\SuperMarkett\SuperMarkett\Product.txt";
        private readonly string categoryFile = @"C:\Users\Seemab\source\repos\SuperMarkett\SuperMarkett\Category_File.txt";

        private List<string> categories;
        private void price_lbl_Click(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {

        }
        private void PopulateComboBox()
        {
            try
            {
                categories = new List<string>();
                categories.Add("Select Category");
                using (StreamReader reader = new StreamReader(categoryFile))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] fields = line.Split(',');

                        string categoryName = fields[1].Trim();
                        categories.Add(categoryName);
                    }
                }
                comboBox1.DataSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InitializeControls()
        {
            comboBox1.SelectedIndexChanged += ComboBoxCategory_SelectedIndexChanged;
        }

        
        private void ComboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = comboBox1.SelectedItem?.ToString();
            if (selectedCategory != null)
            {
                PopulateProductsByCategory(selectedCategory);
            }
        }

        private void PopulateProductsByCategory(string selectedCategory)
        {
            try
            {
                using (StreamReader reader = new StreamReader(productFile))
                {
                    string[] lines = reader.ReadToEnd().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    List<ProductProp> productList = new List<ProductProp>();
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        ProductProp product = new ProductProp
                        {
                            ID = int.Parse(fields[0]),
                            Name = fields[1].Trim(),
                            Quantity = int.Parse(fields[2]),
                            Price = double.Parse(fields[3]),
                            Category = fields[4].Trim(),
                        };
                        if (selectedCategory == "Select Category")
                        {
                            productList.Add(product);
                        }
                        else if (product.Category.ToLower() == selectedCategory.ToLower())
                        {
                            productList.Add(product);
                        }
                    }
                    //MessageBox.Show(selectedCategory);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = productList;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }
}