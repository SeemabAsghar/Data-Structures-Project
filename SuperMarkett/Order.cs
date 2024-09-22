using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Collections.Generic;
namespace SuperMarkett
{
    public partial class Order : Form
    {
        private List<string> categories;
        private List<ProductProp> product;
        List<ProductProp> filteredProducts;
        public Order()
        {
            InitializeComponent();
            LoadProductName();
            LoadProductPrice();
            comboBoxCategory_SelectedIndexChanged();
            comboBoxProduct_SelectedIndexChanged();
        }
        string categoryFile = @"C:\Users\Seemab\source\repos\SuperMarkett\SuperMarkett\Category_File.txt";
        string productFile = @"C:\Users\Seemab\source\repos\SuperMarkett\SuperMarkett\Product.txt";
        private void LoadProductName()
        {
            //categories = GetCategories();
            comboBox2.DataSource = categories;
            product = GetProducts(comboBox2.SelectedItem?.ToString());
            comboBox1.DataSource = product;
            comboBox1.DisplayMember = "Name";
        }

        private void LoadProductPrice()
        {
            string product_price = "0";
            try
            {
                using (StreamReader reader = new StreamReader(productFile))
                {
                    // MessageBox.Show(comboBox1.SelectedItem);
                    string[] lines = reader.ReadToEnd().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        ProductProp product = new ProductProp
                        {
                            Name = fields[1].Trim(),
                            Price = double.Parse(fields[3].Trim()),
                            Category = fields[4].Trim()
                        };
                        if (comboBox1.SelectedItem?.ToString() == product.Name)
                        {
                            product_price = Convert.ToString(product.Price);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            price_txt.Text = product_price;
        }
        //private List<string> GetCategories()
        //{
        //    List<string> categories = new List<string>();

        //    try
        //    {
        //        using (StreamReader reader = new StreamReader(categoryFile))
        //        {
        //            while (!reader.EndOfStream)
        //            {
        //                string line = reader.ReadLine();
        //                string[] fields = line.Split(',');
        //                string category = fields[1].Trim();
        //                categories.Add(category);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error reading categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //    return categories;
        //}
        private List<ProductProp> GetProducts(string selectedCategory)
        {
            List<ProductProp> productList = new List<ProductProp>();
            try
            {
                using (StreamReader reader = new StreamReader(productFile))
                {

                    if (selectedCategory == null)
                    {
                        selectedCategory = "Select Category";
                    }
                    string[] lines = reader.ReadToEnd().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        ProductProp product = new ProductProp
                        {

                            Name = fields[1].Trim(),
                            Price = double.Parse(fields[3].Trim()),
                            Category = fields[4].Trim()

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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return productList;

        }


        private void comboBoxCategory_SelectedIndexChanged()
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
                comboBox2.DataSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void comboBoxProduct_SelectedIndexChanged()
        {
            //// Update the price label based on the selected product
            //if (comboBox1.SelectedItem != null)
            //{
            //    ProductProp selectedProduct = (ProductProp)comboBox1.SelectedItem;
            //    double selectedPrice = selectedProduct.Price;
            //    price_txt.Text = $"Price: {selectedPrice:C}";
            //}
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            // Perform the purchase logic here
            // You can access the selected product, category, and quantity from comboBoxProduct, comboBoxCategory, and textBoxQuantity

            // Calculate total price
            if (comboBox1.SelectedItem != null && int.TryParse(quantity_txt.Text, out int quantity))
            {
                double selectedPrice = (double)comboBox1.SelectedValue;
                double totalPrice = selectedPrice * quantity;
                MessageBox.Show($"Total Price: {totalPrice:C}", "Purchase Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid input. Please select a product, category, and enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void Order_Load(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void price_txt_Leave(object sender, EventArgs e)
        {
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        private void quantity_txt_TextChanged(object sender, EventArgs e)
        {

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void total_txt_TextChanged(object sender, EventArgs e)
        {

        }
        private void price_txt_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to Close?");
            Close();
        }

        private void rfrsh_btn_Click(object sender, EventArgs e)
        {
            quantity_txt.Clear();
            price_txt.Clear();
            total_txt.Clear();
        }

        private void exit_btn_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to Close?");
            Close();
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProductName();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadProductPrice();

            // Update the price label based on the selected product
            if (comboBox1.SelectedItem != null)
            {
                ProductProp selectedProduct = (ProductProp)comboBox1.SelectedItem;

                price_txt.Text = Convert.ToString(selectedProduct.Price);
                //double selectedPrice = selectedProduct.Price;
                //price_txt.Text = $"Price: {selectedPrice:C}";
            }
        }

        private void quantity_txt_TextChanged_1(object sender, EventArgs e)
        {
            string quantity = quantity_txt.Text;
        }

        private void total_txt_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
        // Convert text values to numeric types
        if (int.TryParse(quantity_txt.Text, out int quantity) && double.TryParse(price_txt.Text, out double price))
        {
            // Calculate the total and update the total_txt textbox
            total_txt.Text = (quantity * price).ToString("C");
        }
        else
        {
            throw new FormatException("Invalid input. Please enter valid numeric values for quantity and price.");
        }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string category = comboBox2.SelectedItem?.ToString() ?? "No category selected";
            //string productName = comboBox1.SelectedItem?.ToString() ?? "No product selected";

            ProductProp selectedProduct = (ProductProp)comboBox1.SelectedItem;

            string productName = Convert.ToString(selectedProduct.Name);

            double price = 0;
            int quantity = 0;

            if (double.TryParse(price_txt.Text, out double parsedPrice))
            {
                price = parsedPrice;
            }

            if (int.TryParse(quantity_txt.Text, out int parsedQuantity))
            {
                quantity = parsedQuantity;
            }

            double total = 0;
            if (double.TryParse(total_txt.Text, out double parsedTotal))
            {
                total = parsedTotal;
            }

            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            string message = $"Category: {category}\nProduct: {productName}\nPrice: {price:C}\nQuantity: {quantity}\nTotal: {total_txt.Text:C}\nDate: {date}";

            MessageBox.Show(message, "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rfrsh_btn_Click_1(object sender, EventArgs e)
        {
            quantity_txt.Clear();
            price_txt.Clear();
            total_txt.Clear();
        }
    }
}
