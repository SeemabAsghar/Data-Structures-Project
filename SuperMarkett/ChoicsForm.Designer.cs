
namespace SuperMarkett
{
    partial class ChoicsForm
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
            this.login_lbl = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.login_lbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_lbl.ForeColor = System.Drawing.Color.Black;
            this.login_lbl.Location = new System.Drawing.Point(51, 59);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(279, 28);
            this.login_lbl.TabIndex = 4;
            this.login_lbl.Text = "PRESS ON YOUR ROLE";
            this.login_lbl.Click += new System.EventHandler(this.login_lbl_Click);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Black;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.Crimson;
            this.login_btn.Location = new System.Drawing.Point(133, 207);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(103, 33);
            this.login_btn.TabIndex = 12;
            this.login_btn.Text = "Customer";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(133, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "Admin";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.login_btn);
            this.panel1.Controls.Add(this.login_lbl);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 276);
            this.panel1.TabIndex = 14;
            // 
            // exit_btn
            // 
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.exit_btn.ForeColor = System.Drawing.Color.Black;
            this.exit_btn.Location = new System.Drawing.Point(343, 0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(29, 29);
            this.exit_btn.TabIndex = 14;
            this.exit_btn.Text = "x";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click_1);
            // 
            // ChoicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 276);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChoicsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChoicsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit_btn;
    }
}