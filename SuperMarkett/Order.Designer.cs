
namespace SuperMarkett
{
    partial class Order
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
            this.rfrsh_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.wlcm_lbl = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.total_txt = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.quantity_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rfrsh_btn
            // 
            this.rfrsh_btn.BackColor = System.Drawing.Color.White;
            this.rfrsh_btn.FlatAppearance.BorderSize = 0;
            this.rfrsh_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfrsh_btn.ForeColor = System.Drawing.Color.Black;
            this.rfrsh_btn.Location = new System.Drawing.Point(396, 402);
            this.rfrsh_btn.Name = "rfrsh_btn";
            this.rfrsh_btn.Size = new System.Drawing.Size(102, 39);
            this.rfrsh_btn.TabIndex = 20;
            this.rfrsh_btn.Text = "RESET";
            this.rfrsh_btn.UseVisualStyleBackColor = false;
            this.rfrsh_btn.Click += new System.EventHandler(this.rfrsh_btn_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Controls.Add(this.wlcm_lbl);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.price_txt);
            this.panel1.Controls.Add(this.total_txt);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.quantity_txt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rfrsh_btn);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 464);
            this.panel1.TabIndex = 29;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(419, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 29);
            this.button2.TabIndex = 45;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.exit_btn.ForeColor = System.Drawing.Color.Black;
            this.exit_btn.Location = new System.Drawing.Point(536, 0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(29, 29);
            this.exit_btn.TabIndex = 30;
            this.exit_btn.Text = "x";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click_1);
            // 
            // wlcm_lbl
            // 
            this.wlcm_lbl.AutoSize = true;
            this.wlcm_lbl.BackColor = System.Drawing.Color.Crimson;
            this.wlcm_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wlcm_lbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.wlcm_lbl.Location = new System.Drawing.Point(68, 30);
            this.wlcm_lbl.Name = "wlcm_lbl";
            this.wlcm_lbl.Padding = new System.Windows.Forms.Padding(5);
            this.wlcm_lbl.Size = new System.Drawing.Size(402, 38);
            this.wlcm_lbl.TabIndex = 44;
            this.wlcm_lbl.Text = "WELCOME TO MEESEE\'s STORE";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(232, 94);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(179, 27);
            this.comboBox2.TabIndex = 43;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 42;
            this.label3.Text = "Product Category";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 29);
            this.button1.TabIndex = 39;
            this.button1.Text = "Purchase item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(232, 287);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(238, 26);
            this.dateTimePicker1.TabIndex = 38;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // price_txt
            // 
            this.price_txt.Location = new System.Drawing.Point(232, 172);
            this.price_txt.Margin = new System.Windows.Forms.Padding(5);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(179, 26);
            this.price_txt.TabIndex = 37;
            // 
            // total_txt
            // 
            this.total_txt.Location = new System.Drawing.Point(232, 252);
            this.total_txt.Margin = new System.Windows.Forms.Padding(5);
            this.total_txt.Name = "total_txt";
            this.total_txt.Size = new System.Drawing.Size(179, 26);
            this.total_txt.TabIndex = 36;
            this.total_txt.TextChanged += new System.EventHandler(this.total_txt_TextChanged_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(232, 131);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 27);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // quantity_txt
            // 
            this.quantity_txt.Location = new System.Drawing.Point(232, 215);
            this.quantity_txt.Margin = new System.Windows.Forms.Padding(5);
            this.quantity_txt.Name = "quantity_txt";
            this.quantity_txt.Size = new System.Drawing.Size(179, 26);
            this.quantity_txt.TabIndex = 34;
            this.quantity_txt.TextChanged += new System.EventHandler(this.quantity_txt_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(111, 287);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 19);
            this.label6.TabIndex = 33;
            this.label6.Text = "Purchase Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 19);
            this.label5.TabIndex = 32;
            this.label5.Text = "Product Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 31;
            this.label4.Text = "Product Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Product Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Product Name";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 464);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button rfrsh_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.TextBox total_txt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox quantity_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label wlcm_lbl;
        private System.Windows.Forms.Button button2;
    }
}