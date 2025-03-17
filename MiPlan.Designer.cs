namespace Proyecto2
{
    partial class MiPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiPlan));
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox_tablas = new System.Windows.Forms.PictureBox();
            this.pictureBox_use = new System.Windows.Forms.PictureBox();
            this.lbl_ini = new System.Windows.Forms.Label();
            this.pictureBox_diagrama = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_consu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tablas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_use)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_diagrama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(205, 3);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(203, 204);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            // 
            // pictureBox_tablas
            // 
            this.pictureBox_tablas.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_tablas.Image")));
            this.pictureBox_tablas.Location = new System.Drawing.Point(12, 21);
            this.pictureBox_tablas.Name = "pictureBox_tablas";
            this.pictureBox_tablas.Size = new System.Drawing.Size(44, 41);
            this.pictureBox_tablas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_tablas.TabIndex = 1;
            this.pictureBox_tablas.TabStop = false;
            this.pictureBox_tablas.Click += new System.EventHandler(this.pictureBox_tablas_Click);
            // 
            // pictureBox_use
            // 
            this.pictureBox_use.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_use.Image")));
            this.pictureBox_use.Location = new System.Drawing.Point(504, 5);
            this.pictureBox_use.Name = "pictureBox_use";
            this.pictureBox_use.Size = new System.Drawing.Size(107, 110);
            this.pictureBox_use.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_use.TabIndex = 2;
            this.pictureBox_use.TabStop = false;
            // 
            // lbl_ini
            // 
            this.lbl_ini.AutoSize = true;
            this.lbl_ini.Font = new System.Drawing.Font("Palatino Linotype", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ini.Location = new System.Drawing.Point(210, 2);
            this.lbl_ini.Name = "lbl_ini";
            this.lbl_ini.Size = new System.Drawing.Size(180, 58);
            this.lbl_ini.TabIndex = 3;
            this.lbl_ini.Text = "Mi Plan";
            // 
            // pictureBox_diagrama
            // 
            this.pictureBox_diagrama.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_diagrama.Image")));
            this.pictureBox_diagrama.Location = new System.Drawing.Point(97, 213);
            this.pictureBox_diagrama.Name = "pictureBox_diagrama";
            this.pictureBox_diagrama.Size = new System.Drawing.Size(419, 242);
            this.pictureBox_diagrama.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_diagrama.TabIndex = 4;
            this.pictureBox_diagrama.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(415, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 86);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.Location = new System.Drawing.Point(3, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(196, 86);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_consu
            // 
            this.lbl_consu.AutoSize = true;
            this.lbl_consu.Location = new System.Drawing.Point(12, 163);
            this.lbl_consu.Name = "lbl_consu";
            this.lbl_consu.Size = new System.Drawing.Size(14, 16);
            this.lbl_consu.TabIndex = 7;
            this.lbl_consu.Text = "0";
            // 
            // MiPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(618, 630);
            this.Controls.Add(this.lbl_consu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox_diagrama);
            this.Controls.Add(this.lbl_ini);
            this.Controls.Add(this.pictureBox_use);
            this.Controls.Add(this.pictureBox_tablas);
            this.Controls.Add(this.pictureBox_logo);
            this.Name = "MiPlan";
            this.Text = "Mi Plan";
            this.Load += new System.EventHandler(this.MiPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tablas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_use)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_diagrama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.PictureBox pictureBox_tablas;
        private System.Windows.Forms.PictureBox pictureBox_use;
        private System.Windows.Forms.Label lbl_ini;
        private System.Windows.Forms.PictureBox pictureBox_diagrama;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_consu;
    }
}