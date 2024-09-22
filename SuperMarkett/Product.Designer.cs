
namespace SuperMarkett
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.category_lbl = new System.Windows.Forms.Label();
            this.search_lbl = new System.Windows.Forms.Label();
            this.search_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.price_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.rfrsh_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.dlt_btn = new System.Windows.Forms.Button();
            this.quantity_lbl = new System.Windows.Forms.Label();
            this.quantity_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.name_lbl = new System.Windows.Forms.Label();
            this.name_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.id_lbl = new System.Windows.Forms.Label();
            this.ID_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.manage_pr_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Controls.Add(this.search_btn);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.category_lbl);
            this.panel1.Controls.Add(this.search_lbl);
            this.panel1.Controls.Add(this.search_txt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.price_txt);
            this.panel1.Controls.Add(this.rfrsh_btn);
            this.panel1.Controls.Add(this.add_btn);
            this.panel1.Controls.Add(this.dlt_btn);
            this.panel1.Controls.Add(this.quantity_lbl);
            this.panel1.Controls.Add(this.quantity_txt);
            this.panel1.Controls.Add(this.name_lbl);
            this.panel1.Controls.Add(this.name_txt);
            this.panel1.Controls.Add(this.id_lbl);
            this.panel1.Controls.Add(this.ID_txt);
            this.panel1.Controls.Add(this.manage_pr_lbl);
            this.panel1.Location = new System.Drawing.Point(-38, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 466);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // exit_btn
            // 
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.exit_btn.ForeColor = System.Drawing.Color.Black;
            this.exit_btn.Location = new System.Drawing.Point(772, 0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(29, 29);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Text = "x";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.White;
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.Black;
            this.search_btn.Location = new System.Drawing.Point(198, 369);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(102, 39);
            this.search_btn.TabIndex = 33;
            this.search_btn.Text = "SEARCH";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(372, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(396, 199);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(372, 289);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(396, 162);
            this.treeView1.TabIndex = 31;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Dairy",
            "Fresh",
            "Bakery",
            "Seafood",
            "Bevarages",
            "Kitchen",
            "Frozen"});
            this.comboBox1.Location = new System.Drawing.Point(161, 256);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 27);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.Text = "Select Category";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // category_lbl
            // 
            this.category_lbl.AutoSize = true;
            this.category_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_lbl.ForeColor = System.Drawing.Color.Black;
            this.category_lbl.Location = new System.Drawing.Point(50, 264);
            this.category_lbl.Name = "category_lbl";
            this.category_lbl.Size = new System.Drawing.Size(99, 19);
            this.category_lbl.TabIndex = 26;
            this.category_lbl.Text = "CATEGORY:";
            // 
            // search_lbl
            // 
            this.search_lbl.AutoSize = true;
            this.search_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_lbl.ForeColor = System.Drawing.Color.Black;
            this.search_lbl.Location = new System.Drawing.Point(496, 50);
            this.search_lbl.Name = "search_lbl";
            this.search_lbl.Size = new System.Drawing.Size(79, 19);
            this.search_lbl.TabIndex = 24;
            this.search_lbl.Text = "SEARCH:";
            // 
            // search_txt
            // 
            this.search_txt.BackColor = System.Drawing.Color.Black;
            this.search_txt.BorderColor = System.Drawing.Color.Black;
            this.search_txt.BorderThickness = 3;
            this.search_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_txt.DefaultText = "";
            this.search_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_txt.FillColor = System.Drawing.Color.Crimson;
            this.search_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.search_txt.ForeColor = System.Drawing.Color.Black;
            this.search_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_txt.Location = new System.Drawing.Point(581, 42);
            this.search_txt.Name = "search_txt";
            this.search_txt.PasswordChar = '\0';
            this.search_txt.PlaceholderText = "";
            this.search_txt.SelectedText = "";
            this.search_txt.Size = new System.Drawing.Size(187, 27);
            this.search_txt.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(87, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "PRICE:";
            // 
            // price_txt
            // 
            this.price_txt.BackColor = System.Drawing.Color.Black;
            this.price_txt.BorderColor = System.Drawing.Color.Black;
            this.price_txt.BorderThickness = 3;
            this.price_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.price_txt.DefaultText = "";
            this.price_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.price_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.price_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.price_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.price_txt.FillColor = System.Drawing.Color.Crimson;
            this.price_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.price_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.price_txt.ForeColor = System.Drawing.Color.Black;
            this.price_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.price_txt.Location = new System.Drawing.Point(161, 187);
            this.price_txt.Name = "price_txt";
            this.price_txt.PasswordChar = '\0';
            this.price_txt.PlaceholderText = "";
            this.price_txt.SelectedText = "";
            this.price_txt.Size = new System.Drawing.Size(187, 27);
            this.price_txt.TabIndex = 21;
            this.price_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_txt_KeyPress);
            // 
            // rfrsh_btn
            // 
            this.rfrsh_btn.BackColor = System.Drawing.Color.White;
            this.rfrsh_btn.FlatAppearance.BorderSize = 0;
            this.rfrsh_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfrsh_btn.ForeColor = System.Drawing.Color.Black;
            this.rfrsh_btn.Location = new System.Drawing.Point(91, 369);
            this.rfrsh_btn.Name = "rfrsh_btn";
            this.rfrsh_btn.Size = new System.Drawing.Size(102, 39);
            this.rfrsh_btn.TabIndex = 20;
            this.rfrsh_btn.Text = "REFRESH";
            this.rfrsh_btn.UseVisualStyleBackColor = false;
            this.rfrsh_btn.Click += new System.EventHandler(this.rfrsh_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.White;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.Black;
            this.add_btn.Location = new System.Drawing.Point(90, 326);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(102, 39);
            this.add_btn.TabIndex = 17;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // dlt_btn
            // 
            this.dlt_btn.BackColor = System.Drawing.Color.White;
            this.dlt_btn.FlatAppearance.BorderSize = 0;
            this.dlt_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlt_btn.ForeColor = System.Drawing.Color.Black;
            this.dlt_btn.Location = new System.Drawing.Point(198, 326);
            this.dlt_btn.Name = "dlt_btn";
            this.dlt_btn.Size = new System.Drawing.Size(102, 39);
            this.dlt_btn.TabIndex = 15;
            this.dlt_btn.Text = "DELETE";
            this.dlt_btn.UseVisualStyleBackColor = false;
            this.dlt_btn.Click += new System.EventHandler(this.dlt_btn_Click);
            // 
            // quantity_lbl
            // 
            this.quantity_lbl.AutoSize = true;
            this.quantity_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_lbl.ForeColor = System.Drawing.Color.Black;
            this.quantity_lbl.Location = new System.Drawing.Point(54, 162);
            this.quantity_lbl.Name = "quantity_lbl";
            this.quantity_lbl.Size = new System.Drawing.Size(95, 19);
            this.quantity_lbl.TabIndex = 10;
            this.quantity_lbl.Text = "QUANTITY:";
            // 
            // quantity_txt
            // 
            this.quantity_txt.BackColor = System.Drawing.Color.Black;
            this.quantity_txt.BorderColor = System.Drawing.Color.Black;
            this.quantity_txt.BorderThickness = 3;
            this.quantity_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantity_txt.DefaultText = "";
            this.quantity_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.quantity_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.quantity_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantity_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantity_txt.FillColor = System.Drawing.Color.Crimson;
            this.quantity_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantity_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quantity_txt.ForeColor = System.Drawing.Color.Black;
            this.quantity_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantity_txt.Location = new System.Drawing.Point(161, 154);
            this.quantity_txt.Name = "quantity_txt";
            this.quantity_txt.PasswordChar = '\0';
            this.quantity_txt.PlaceholderText = "";
            this.quantity_txt.SelectedText = "";
            this.quantity_txt.Size = new System.Drawing.Size(187, 27);
            this.quantity_txt.TabIndex = 9;
            this.quantity_txt.TextChanged += new System.EventHandler(this.quantity_txt_TextChanged);
            this.quantity_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantity_txt_KeyPress);
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.ForeColor = System.Drawing.Color.Black;
            this.name_lbl.Location = new System.Drawing.Point(86, 129);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(63, 19);
            this.name_lbl.TabIndex = 8;
            this.name_lbl.Text = "NAME:";
            // 
            // name_txt
            // 
            this.name_txt.BackColor = System.Drawing.Color.Black;
            this.name_txt.BorderColor = System.Drawing.Color.Black;
            this.name_txt.BorderThickness = 3;
            this.name_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name_txt.DefaultText = "";
            this.name_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.name_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.name_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name_txt.FillColor = System.Drawing.Color.Crimson;
            this.name_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.name_txt.ForeColor = System.Drawing.Color.Black;
            this.name_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_txt.Location = new System.Drawing.Point(161, 121);
            this.name_txt.Name = "name_txt";
            this.name_txt.PasswordChar = '\0';
            this.name_txt.PlaceholderText = "";
            this.name_txt.SelectedText = "";
            this.name_txt.Size = new System.Drawing.Size(187, 27);
            this.name_txt.TabIndex = 7;
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lbl.ForeColor = System.Drawing.Color.Black;
            this.id_lbl.Location = new System.Drawing.Point(117, 95);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(32, 19);
            this.id_lbl.TabIndex = 6;
            this.id_lbl.Text = "ID:";
            this.id_lbl.Click += new System.EventHandler(this.id_lbl_Click);
            // 
            // ID_txt
            // 
            this.ID_txt.BackColor = System.Drawing.Color.Black;
            this.ID_txt.BorderColor = System.Drawing.Color.Black;
            this.ID_txt.BorderThickness = 3;
            this.ID_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ID_txt.DefaultText = "";
            this.ID_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ID_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ID_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ID_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ID_txt.FillColor = System.Drawing.Color.Crimson;
            this.ID_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ID_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ID_txt.ForeColor = System.Drawing.Color.Black;
            this.ID_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ID_txt.Location = new System.Drawing.Point(161, 84);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.PasswordChar = '\0';
            this.ID_txt.PlaceholderText = "";
            this.ID_txt.SelectedText = "";
            this.ID_txt.Size = new System.Drawing.Size(187, 27);
            this.ID_txt.TabIndex = 5;
            this.ID_txt.TextChanged += new System.EventHandler(this.ID_txt_TextChanged);
            this.ID_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_txt_KeyPress);
            // 
            // manage_pr_lbl
            // 
            this.manage_pr_lbl.AutoSize = true;
            this.manage_pr_lbl.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.manage_pr_lbl.Location = new System.Drawing.Point(278, 19);
            this.manage_pr_lbl.Name = "manage_pr_lbl";
            this.manage_pr_lbl.Size = new System.Drawing.Size(207, 22);
            this.manage_pr_lbl.TabIndex = 3;
            this.manage_pr_lbl.Text = "MANAGE PRODUCTS";
            this.manage_pr_lbl.Click += new System.EventHandler(this.manage_lbl_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 463);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label manage_pr_lbl;
        private System.Windows.Forms.Label id_lbl;
        private Guna.UI2.WinForms.Guna2TextBox ID_txt;
        private System.Windows.Forms.Label quantity_lbl;
        private Guna.UI2.WinForms.Guna2TextBox quantity_txt;
        private System.Windows.Forms.Label name_lbl;
        private Guna.UI2.WinForms.Guna2TextBox name_txt;
        private System.Windows.Forms.Button rfrsh_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button dlt_btn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox price_txt;
        private System.Windows.Forms.Label search_lbl;
        private Guna.UI2.WinForms.Guna2TextBox search_txt;
        private System.Windows.Forms.Label category_lbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button search_btn;
    }
}