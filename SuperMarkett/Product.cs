using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static SuperMarkett.redBlack<string>;
using System.Linq;


namespace SuperMarkett
{
   
    public partial class ProductForm : Form
    {
       

        private redBlack<string> rbTree = new redBlack<string>();
        public static string product_file = @"C:\Users\Seemab\source\repos\SuperMarkett\SuperMarkett\Product.txt";
        public ProductForm()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manage_lbl_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ctgry_btn_Click(object sender, EventArgs e)
        {

        }

        private void cstmr_btn_Click(object sender, EventArgs e)
        {

        }

        private void selling_btn_Click(object sender, EventArgs e)
        {

        }

        private void id_lbl_Click(object sender, EventArgs e)
        {

        }

        private void price_lbl_Click(object sender, EventArgs e)
        {

        }

        private void quantity_txt_TextChanged(object sender, EventArgs e)
        {

        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            PopulateCategoryComboBox();
            try
            {
                StreamReader sr = new StreamReader(product_file);
                string content = sr.ReadToEnd();
                content = string.Join(Environment.NewLine, content.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries));
                sr.Close();

                StreamWriter sw = new StreamWriter(product_file, false);
                sw.Write(content);
                sw.Close();
                {
                    using (StreamReader reader = new StreamReader(product_file))
                    {
                        string[] lines = reader.ReadToEnd().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (string line in lines)
                        {
                            string[] fields = line.Split(',');

                            ProductProp product = new ProductProp
                            {
                                ID = int.Parse(fields[0]),
                                Name = fields[1],
                                Quantity = int.Parse(fields[2]),
                                Price = double.Parse(fields[3]),
                                Category = fields[4]
                            };
                            rbTree.Add(Convert.ToString(product.ID));
                            UpdateTreeView();
                        }
                        PopulateGridView();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error loading tree from file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void ID_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void rfrsh_btn_Click(object sender, EventArgs e)
        {
            ID_txt.Clear();
            name_txt.Clear();
            quantity_txt.Clear();
            price_txt.Clear();
        }
        private void UpdateTreeView()
        {
            treeView1.Nodes.Clear();
            if (rbTree != null && rbTree.root != null)
            {
                AddNodesToTreeView(treeView1.Nodes, rbTree.root);
            }
        }
        private void AddNodesToTreeView(TreeNodeCollection nodes, Node<string> currentNode)
        {
            if (currentNode != null)
            {
                // Add the current node to the TreeView
                TreeNode newNode = nodes.Add(currentNode.Item.ToString());
                newNode.ForeColor = currentNode.Red ? System.Drawing.Color.Red : System.Drawing.Color.Black;

                // Recursively add the left and right children
                AddNodesToTreeView(newNode.Nodes, currentNode.Left);
                AddNodesToTreeView(newNode.Nodes, currentNode.Right);
            }
        }
        private void PopulateGridView()
        {
            using (StreamReader reader = new StreamReader(product_file))
            {
                string[] lines = reader.ReadToEnd().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                List<ProductProp> productList = new List<ProductProp>();
                foreach (string line in lines)
                {
                    string[] fields = line.Split(',');
                    ProductProp category = new ProductProp
                    {
                        ID = int.Parse(fields[0]),
                        Name = fields[1],
                        Quantity = int.Parse(fields[2]),
                        Price = double.Parse(fields[3]),
                        Category = fields[4]
                    };
                    productList.Add(category);
                }
                ProductProp[] categories = productList.ToArray();
                dataGridView1.DataSource = productList;
            }
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            string selectedCategory = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedCategory))
            {
                MessageBox.Show("Please select a category for the product.", "Missing Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                rbTree.Add(ID_txt.Text);
                UpdateTreeView();
                using (StreamWriter sw = new StreamWriter(product_file, true))
                {
                    string csvLine = $"{ID_txt.Text}, {name_txt.Text}, {quantity_txt.Text}, {price_txt.Text}, {comboBox1.Text}";
                    sw.WriteLine(csvLine + Environment.NewLine);
                }
                PopulateGridView();

            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            int searchItem;

            if (int.TryParse(ID_txt.Text, out searchItem))
            {
                bool isFound = rbTree.Search(Convert.ToString(searchItem));

                if (isFound)
                {
                    MessageBox.Show($"Item {searchItem} is found in the Red-Black Tree.", "Search Result");
                }
                else
                {
                    MessageBox.Show($"Item {searchItem} is not found in the Red-Black Tree.", "Search Result");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer for the search.", "Invalid Input");
            }
        }
        private void dlt_btn_Click(object sender, EventArgs e)
        {
            try
            {
                rbTree.Remove(ID_txt.Text);
                UpdateTreeView();

                using (StreamWriter sw = new StreamWriter(product_file, true))
                {
                    string csvLine = $"{ID_txt.Text}, {name_txt.Text}, {quantity_txt.Text},{price_txt.Text}";
                    sw.WriteLine(Environment.NewLine + csvLine);
                }
                PopulateGridView();
                if (int.TryParse(ID_txt.Text, out int idToRemove))
                {
                    try
                    {
                        List<string> lines = File.ReadAllLines(product_file).ToList();
                        lines.RemoveAll(line => line.StartsWith(idToRemove.ToString() + ","));
                        File.WriteAllLines(product_file, lines);
                        UpdateTreeView();
                        PopulateGridView();
                        MessageBox.Show($"Row with ID {idToRemove} removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error removing row: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid ID format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private List<string> GetCategories()
        {
            List<string> categoriess = new List<string>();
            string categoryFile = @"C:\Users\Seemab\source\repos\SuperMarkett\SuperMarkett\Category_File.txt";
            try
            {
                using (StreamReader reader = new StreamReader(categoryFile))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] fields = line.Split(',');

                        string categories = fields[1].Trim();
                        categoriess.Add(categories);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return categoriess;
        }
        private void PopulateCategoryComboBox()
        {
            List<string> categories = GetCategories();
            comboBox1.DataSource = categories;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void quantity_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void ID_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void price_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    public class ProductProp
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
    }

}