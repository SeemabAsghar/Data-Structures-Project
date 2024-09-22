
namespace SuperMarkett
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.wlcm_lbl = new System.Windows.Forms.Label();
            this.prdct_btn = new System.Windows.Forms.Button();
            this.invntry_btn = new System.Windows.Forms.Button();
            this.ctgry_btn = new System.Windows.Forms.Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logout_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // wlcm_lbl
            // 
            this.wlcm_lbl.AutoSize = true;
            this.wlcm_lbl.BackColor = System.Drawing.Color.Crimson;
            this.wlcm_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wlcm_lbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.wlcm_lbl.Location = new System.Drawing.Point(152, 33);
            this.wlcm_lbl.Name = "wlcm_lbl";
            this.wlcm_lbl.Padding = new System.Windows.Forms.Padding(5);
            this.wlcm_lbl.Size = new System.Drawing.Size(402, 38);
            this.wlcm_lbl.TabIndex = 0;
            this.wlcm_lbl.Text = "WELCOME TO MEESEE\'s STORE";
            // 
            // prdct_btn
            // 
            this.prdct_btn.BackColor = System.Drawing.Color.Black;
            this.prdct_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prdct_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prdct_btn.ForeColor = System.Drawing.Color.Crimson;
            this.prdct_btn.Location = new System.Drawing.Point(334, 298);
            this.prdct_btn.Name = "prdct_btn";
            this.prdct_btn.Size = new System.Drawing.Size(197, 49);
            this.prdct_btn.TabIndex = 14;
            this.prdct_btn.Text = "MANAGE PRODUCTS";
            this.prdct_btn.UseVisualStyleBackColor = false;
            this.prdct_btn.Click += new System.EventHandler(this.prdct_btn_Click);
            // 
            // invntry_btn
            // 
            this.invntry_btn.BackColor = System.Drawing.Color.Black;
            this.invntry_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.invntry_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invntry_btn.ForeColor = System.Drawing.Color.Crimson;
            this.invntry_btn.Location = new System.Drawing.Point(334, 448);
            this.invntry_btn.Name = "invntry_btn";
            this.invntry_btn.Size = new System.Drawing.Size(197, 49);
            this.invntry_btn.TabIndex = 17;
            this.invntry_btn.Text = "MANAGE INVENTORY";
            this.invntry_btn.UseVisualStyleBackColor = false;
            this.invntry_btn.Click += new System.EventHandler(this.invntry_btn_Click);
            // 
            // ctgry_btn
            // 
            this.ctgry_btn.BackColor = System.Drawing.Color.Black;
            this.ctgry_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ctgry_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctgry_btn.ForeColor = System.Drawing.Color.Crimson;
            this.ctgry_btn.Location = new System.Drawing.Point(334, 154);
            this.ctgry_btn.Name = "ctgry_btn";
            this.ctgry_btn.Size = new System.Drawing.Size(197, 49);
            this.ctgry_btn.TabIndex = 18;
            this.ctgry_btn.Text = "MANAGE CATEGORIES";
            this.ctgry_btn.UseVisualStyleBackColor = false;
            this.ctgry_btn.Click += new System.EventHandler(this.ctgry_btn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Crimson;
            this.guna2Panel1.Controls.Add(this.pictureBox3);
            this.guna2Panel1.Controls.Add(this.pictureBox2);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.logout_btn);
            this.guna2Panel1.Controls.Add(this.wlcm_lbl);
            this.guna2Panel1.Controls.Add(this.ctgry_btn);
            this.guna2Panel1.Controls.Add(this.prdct_btn);
            this.guna2Panel1.Controls.Add(this.invntry_btn);
            this.guna2Panel1.Location = new System.Drawing.Point(-3, -2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(735, 577);
            this.guna2Panel1.TabIndex = 19;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(171, 402);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.Black;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logout_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.Crimson;
            this.logout_btn.Location = new System.Drawing.Point(620, 531);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(103, 33);
            this.logout_btn.TabIndex = 19;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(171, 113);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(171, 257);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(137, 122);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 574);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label wlcm_lbl;
        private System.Windows.Forms.Button prdct_btn;
        private System.Windows.Forms.Button invntry_btn;
        private System.Windows.Forms.Button ctgry_btn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}