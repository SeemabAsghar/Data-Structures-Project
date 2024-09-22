
namespace SuperMarkett
{
    partial class CategoryForm
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
            this.search_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.search_lbl = new System.Windows.Forms.Label();
            this.search_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.rfrsh_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.dlt_btn = new System.Windows.Forms.Button();
            this.descript_lbl = new System.Windows.Forms.Label();
            this.descript_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.name_lbl = new System.Windows.Forms.Label();
            this.name_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.id_lbl = new System.Windows.Forms.Label();
            this.ID_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.manage_ctgr_lbl = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.search_lbl);
            this.panel1.Controls.Add(this.search_txt);
            this.panel1.Controls.Add(this.rfrsh_btn);
            this.panel1.Controls.Add(this.add_btn);
            this.panel1.Controls.Add(this.dlt_btn);
            this.panel1.Controls.Add(this.descript_lbl);
            this.panel1.Controls.Add(this.descript_txt);
            this.panel1.Controls.Add(this.name_lbl);
            this.panel1.Controls.Add(this.name_txt);
            this.panel1.Controls.Add(this.id_lbl);
            this.panel1.Controls.Add(this.ID_txt);
            this.panel1.Controls.Add(this.manage_ctgr_lbl);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 464);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.White;
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.Black;
            this.search_btn.Location = new System.Drawing.Point(191, 319);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(102, 39);
            this.search_btn.TabIndex = 34;
            this.search_btn.Text = "SEARCH";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(351, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(396, 192);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(351, 295);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(396, 126);
            this.treeView1.TabIndex = 29;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // search_lbl
            // 
            this.search_lbl.AutoSize = true;
            this.search_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_lbl.ForeColor = System.Drawing.Color.Black;
            this.search_lbl.Location = new System.Drawing.Point(475, 60);
            this.search_lbl.Name = "search_lbl";
            this.search_lbl.Size = new System.Drawing.Size(79, 19);
            this.search_lbl.TabIndex = 28;
            this.search_lbl.Text = "SEARCH:";
            this.search_lbl.Click += new System.EventHandler(this.search_lbl_Click);
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
            this.search_txt.Location = new System.Drawing.Point(560, 52);
            this.search_txt.Name = "search_txt";
            this.search_txt.PasswordChar = '\0';
            this.search_txt.PlaceholderText = "";
            this.search_txt.SelectedText = "";
            this.search_txt.Size = new System.Drawing.Size(187, 27);
            this.search_txt.TabIndex = 27;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            this.search_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.search_txt_KeyPress);
            // 
            // rfrsh_btn
            // 
            this.rfrsh_btn.BackColor = System.Drawing.Color.White;
            this.rfrsh_btn.FlatAppearance.BorderSize = 0;
            this.rfrsh_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfrsh_btn.ForeColor = System.Drawing.Color.Black;
            this.rfrsh_btn.Location = new System.Drawing.Point(83, 319);
            this.rfrsh_btn.Name = "rfrsh_btn";
            this.rfrsh_btn.Size = new System.Drawing.Size(102, 39);
            this.rfrsh_btn.TabIndex = 21;
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
            this.add_btn.Location = new System.Drawing.Point(83, 274);
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
            this.dlt_btn.Location = new System.Drawing.Point(191, 274);
            this.dlt_btn.Name = "dlt_btn";
            this.dlt_btn.Size = new System.Drawing.Size(102, 39);
            this.dlt_btn.TabIndex = 15;
            this.dlt_btn.Text = "DELETE";
            this.dlt_btn.UseVisualStyleBackColor = false;
            this.dlt_btn.Click += new System.EventHandler(this.dlt_btn_Click);
            // 
            // descript_lbl
            // 
            this.descript_lbl.AutoSize = true;
            this.descript_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descript_lbl.ForeColor = System.Drawing.Color.Black;
            this.descript_lbl.Location = new System.Drawing.Point(5, 208);
            this.descript_lbl.Name = "descript_lbl";
            this.descript_lbl.Size = new System.Drawing.Size(123, 19);
            this.descript_lbl.TabIndex = 10;
            this.descript_lbl.Text = "DESCRIPTION:";
            this.descript_lbl.Click += new System.EventHandler(this.descript_lbl_Click);
            // 
            // descript_txt
            // 
            this.descript_txt.AutoSize = true;
            this.descript_txt.BackColor = System.Drawing.Color.Black;
            this.descript_txt.BorderColor = System.Drawing.Color.Black;
            this.descript_txt.BorderThickness = 3;
            this.descript_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descript_txt.DefaultText = "";
            this.descript_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.descript_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.descript_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descript_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descript_txt.FillColor = System.Drawing.Color.Crimson;
            this.descript_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.descript_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.descript_txt.ForeColor = System.Drawing.Color.Black;
            this.descript_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.descript_txt.Location = new System.Drawing.Point(134, 200);
            this.descript_txt.Name = "descript_txt";
            this.descript_txt.PasswordChar = '\0';
            this.descript_txt.PlaceholderText = "";
            this.descript_txt.SelectedText = "";
            this.descript_txt.Size = new System.Drawing.Size(187, 27);
            this.descript_txt.TabIndex = 9;
            this.descript_txt.TextChanged += new System.EventHandler(this.descript_txt_TextChanged);
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.ForeColor = System.Drawing.Color.Black;
            this.name_lbl.Location = new System.Drawing.Point(65, 175);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(63, 19);
            this.name_lbl.TabIndex = 8;
            this.name_lbl.Text = "NAME:";
            this.name_lbl.Click += new System.EventHandler(this.name_lbl_Click);
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
            this.name_txt.Location = new System.Drawing.Point(134, 167);
            this.name_txt.Name = "name_txt";
            this.name_txt.PasswordChar = '\0';
            this.name_txt.PlaceholderText = "";
            this.name_txt.SelectedText = "";
            this.name_txt.Size = new System.Drawing.Size(187, 27);
            this.name_txt.TabIndex = 7;
            this.name_txt.TextChanged += new System.EventHandler(this.name_txt_TextChanged);
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lbl.ForeColor = System.Drawing.Color.Black;
            this.id_lbl.Location = new System.Drawing.Point(95, 140);
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
            this.ID_txt.Location = new System.Drawing.Point(134, 132);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.PasswordChar = '\0';
            this.ID_txt.PlaceholderText = "";
            this.ID_txt.SelectedText = "";
            this.ID_txt.Size = new System.Drawing.Size(187, 27);
            this.ID_txt.TabIndex = 5;
            this.ID_txt.TextChanged += new System.EventHandler(this.ID_txt_TextChanged);
            this.ID_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_txt_KeyPress);
            // 
            // manage_ctgr_lbl
            // 
            this.manage_ctgr_lbl.AutoSize = true;
            this.manage_ctgr_lbl.BackColor = System.Drawing.Color.Crimson;
            this.manage_ctgr_lbl.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.manage_ctgr_lbl.Location = new System.Drawing.Point(278, 19);
            this.manage_ctgr_lbl.Name = "manage_ctgr_lbl";
            this.manage_ctgr_lbl.Size = new System.Drawing.Size(228, 22);
            this.manage_ctgr_lbl.TabIndex = 3;
            this.manage_ctgr_lbl.Text = "MANAGE CATEGORIES";
            this.manage_ctgr_lbl.Click += new System.EventHandler(this.manage_ctgr_lbl_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.exit_btn.ForeColor = System.Drawing.Color.Black;
            this.exit_btn.Location = new System.Drawing.Point(747, 0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(29, 29);
            this.exit_btn.TabIndex = 7;
            this.exit_btn.Text = "x";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 462);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button dlt_btn;
        private System.Windows.Forms.Label descript_lbl;
        private Guna.UI2.WinForms.Guna2TextBox descript_txt;
        private System.Windows.Forms.Label name_lbl;
        private Guna.UI2.WinForms.Guna2TextBox name_txt;
        private System.Windows.Forms.Label id_lbl;
        private Guna.UI2.WinForms.Guna2TextBox ID_txt;
        private System.Windows.Forms.Label manage_ctgr_lbl;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button rfrsh_btn;
        private System.Windows.Forms.Label search_lbl;
        private Guna.UI2.WinForms.Guna2TextBox search_txt;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button search_btn;
    }
}