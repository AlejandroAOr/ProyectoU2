namespace Proyecto2
{
    partial class Objetivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Objetivo));
            this.lbl_title = new System.Windows.Forms.Label();
            this.PesoA = new System.Windows.Forms.ComboBox();
            this.PesoOb = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_objetivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(142, 72);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(201, 20);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Personaliza tu objetivo";
            // 
            // PesoA
            // 
            this.PesoA.FormattingEnabled = true;
            this.PesoA.Location = new System.Drawing.Point(182, 187);
            this.PesoA.Name = "PesoA";
            this.PesoA.Size = new System.Drawing.Size(161, 24);
            this.PesoA.TabIndex = 1;
            this.PesoA.Text = "Peso Actual";
            this.PesoA.SelectedIndexChanged += new System.EventHandler(this.PesoA_SelectedIndexChanged);
            // 
            // PesoOb
            // 
            this.PesoOb.FormattingEnabled = true;
            this.PesoOb.Location = new System.Drawing.Point(182, 273);
            this.PesoOb.Name = "PesoOb";
            this.PesoOb.Size = new System.Drawing.Size(161, 24);
            this.PesoOb.TabIndex = 2;
            this.PesoOb.Text = "Peso Objetivo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(144, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(144, 265);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btn_objetivo
            // 
            this.btn_objetivo.Location = new System.Drawing.Point(207, 434);
            this.btn_objetivo.Name = "btn_objetivo";
            this.btn_objetivo.Size = new System.Drawing.Size(75, 23);
            this.btn_objetivo.TabIndex = 5;
            this.btn_objetivo.Text = "Aplicar";
            this.btn_objetivo.UseVisualStyleBackColor = true;
            this.btn_objetivo.Click += new System.EventHandler(this.btn_objetivo_Click);
            // 
            // Objetivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(543, 675);
            this.Controls.Add(this.btn_objetivo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PesoOb);
            this.Controls.Add(this.PesoA);
            this.Controls.Add(this.lbl_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Objetivo";
            this.Text = "Objetivo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.ComboBox PesoA;
        private System.Windows.Forms.ComboBox PesoOb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_objetivo;
    }
}