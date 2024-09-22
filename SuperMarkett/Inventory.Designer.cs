
namespace SuperMarkett
{
    partial class InventoryForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.manage_pr_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.manage_pr_lbl);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(834, 529);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.White;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.exit_btn.ForeColor = System.Drawing.Color.Black;
            this.exit_btn.Location = new System.Drawing.Point(805, 0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(29, 29);
            this.exit_btn.TabIndex = 5;
            this.exit_btn.Text = "x";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.Size = new System.Drawing.Size(782, 416);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(622, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(186, 27);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.Text = "Select Category";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // manage_pr_lbl
            // 
            this.manage_pr_lbl.AutoSize = true;
            this.manage_pr_lbl.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.manage_pr_lbl.Location = new System.Drawing.Point(278, 19);
            this.manage_pr_lbl.Name = "manage_pr_lbl";
            this.manage_pr_lbl.Size = new System.Drawing.Size(216, 22);
            this.manage_pr_lbl.TabIndex = 3;
            this.manage_pr_lbl.Text = "MANAGE INVENTORY";
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 527);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label manage_pr_lbl;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}