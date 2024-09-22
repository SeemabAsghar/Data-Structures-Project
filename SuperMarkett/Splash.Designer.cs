
namespace SuperMarkett
{
    partial class Splash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.wlcm_lbl = new System.Windows.Forms.Label();
            this.progress = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // wlcm_lbl
            // 
            this.wlcm_lbl.AutoSize = true;
            this.wlcm_lbl.BackColor = System.Drawing.Color.Crimson;
            this.wlcm_lbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wlcm_lbl.ForeColor = System.Drawing.Color.Black;
            this.wlcm_lbl.Location = new System.Drawing.Point(107, 43);
            this.wlcm_lbl.Name = "wlcm_lbl";
            this.wlcm_lbl.Size = new System.Drawing.Size(175, 22);
            this.wlcm_lbl.TabIndex = 13;
            this.wlcm_lbl.Text = "MEESEE\'s STORE";
            // 
            // progress
            // 
            this.progress.FillColor = System.Drawing.Color.Crimson;
            this.progress.Location = new System.Drawing.Point(-1, 282);
            this.progress.Name = "progress";
            this.progress.ProgressColor = System.Drawing.Color.Black;
            this.progress.ProgressColor2 = System.Drawing.Color.Black;
            this.progress.Size = new System.Drawing.Size(492, 10);
            this.progress.TabIndex = 15;
            this.progress.Text = "guna2ProgressBar1";
            this.progress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(104, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(404, 292);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.wlcm_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wlcm_lbl;
        private Guna.UI2.WinForms.Guna2ProgressBar progress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}