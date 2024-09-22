using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static SuperMarkett.redBlack<string>;
using System.Linq;

namespace SuperMarkett
{

   
    public partial class CategoryForm : Form
    {
       
        private redBlack<string> rbTree = new redBlack<string>();
        public static string category_file =@"C:\Users\Seemab\source\repos\SuperMarkett\SuperMarkett\Category_File.txt";
        public CategoryForm()
        {
            InitializeComponent();
    }
        private void name_lbl_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rfrsh_btn_Click(object sender, EventArgs e)
        {
            ID_txt.Clear();
            name_txt.Clear();
            descript_txt.Clear();
        }

        private void dlt_btn_Click(object sender, EventArgs e)
        {
            try
            {
                rbTree.Remove(ID_txt.Text);
                UpdateTreeView();
                using (StreamWriter sw = new StreamWriter(category_file, true))
                {
                    string csvLine = $"{ID_txt.Text}, {name_txt.Text}, {descript_txt.Text}";
                    sw.WriteLine(Environment.NewLine + csvLine);
                }
                PopulateGridView();
                if (int.TryParse(ID_txt.Text, out int idToRemove))
                {
                    try
                    {
                        List<string> lines = File.ReadAllLines(category_file).ToList();
                        lines.RemoveAll(line => line.StartsWith(idToRemove.ToString() + ","));
                        File.WriteAllLines(category_file, lines);
                        UpdateTreeView();
                        PopulateGridView();
                        MessageBox.Show($"ID {idToRemove} deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void UpdateTreeView()
        {
            treeView1.Nodes.Clear();
            if (rbTree != null && rbTree.root != null)
            {
                AddNodesToTreeView(treeView1.Nodes, rbTree.root);
            }
        }
        private void PopulateGridView()
        {
            using (StreamReader reader = new StreamReader(category_file))
            {
                string[] lines = reader.ReadToEnd().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                List<CategoryProp> categoryList = new List<CategoryProp>();

                foreach (string line in lines)
                {
                    string[] fields = line.Split(',');

                    CategoryProp category = new CategoryProp
                    {
                        ID = int.Parse(fields[0]),
                        Name = fields[1],
                        Description = fields[2]
                    };

                    categoryList.Add(category);

                }
                CategoryProp[] categories = categoryList.ToArray();
                dataGridView1.DataSource = categoryList;
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

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                rbTree.Add(ID_txt.Text);
                UpdateTreeView();

                using (StreamWriter sw = new StreamWriter(category_file, true))
                {
                    string csvLine = $"{ID_txt.Text}, {name_txt.Text}, {descript_txt.Text}";
                    sw.WriteLine(Environment.NewLine+csvLine);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader(category_file);
                string content = sr.ReadToEnd();
                content = string.Join(Environment.NewLine, content.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries));
                sr.Close();

                StreamWriter sw = new StreamWriter(category_file, false);
                sw.Write(content);
                sw.Close();


                using (StreamReader reader = new StreamReader(category_file))
                {
                    string[] lines = reader.ReadToEnd().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        CategoryProp category = new CategoryProp
                        {
                            ID = int.Parse(fields[0]),
                            Name = fields[1],
                            Description = fields[2]
                        };
                        rbTree.Add(Convert.ToString(category.ID));
                        UpdateTreeView();
                    }
                    PopulateGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tree from file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ID_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void search_lbl_Click(object sender, EventArgs e)
        {

        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
           
    }

        private void descript_lbl_Click(object sender, EventArgs e)
        {

        }

        private void descript_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_lbl_Click(object sender, EventArgs e)
        {

        }

        private void manage_ctgr_lbl_Click(object sender, EventArgs e)
        {

        }

        private void prdct_btn_Click(object sender, EventArgs e)
        {

        }

        private void selling_btn_Click(object sender, EventArgs e)
        {

        }

        private void cstmr_btn_Click(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            int searchItem;

            if (int.TryParse(search_txt.Text, out searchItem))
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

        private void search_txt_KeyPress(object sender, KeyPressEventArgs e)
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
    }
    public class CategoryProp
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
