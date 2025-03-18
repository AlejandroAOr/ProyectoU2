namespace Proyecto2
{
    partial class inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Peso = new System.Windows.Forms.Button();
            this.Btn_Gains = new System.Windows.Forms.Button();
            this.Btn_PGrasa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSalmon;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 30F);
            this.label1.Location = new System.Drawing.Point(5, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 65);
            this.label1.TabIndex = 3;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "¿Cual es tu objetivo?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Calcularemos tus calorias necesarias para lograrlo";
            // 
            // Btn_Peso
            // 
            this.Btn_Peso.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Peso.Image")));
            this.Btn_Peso.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Peso.Location = new System.Drawing.Point(177, 523);
            this.Btn_Peso.Name = "Btn_Peso";
            this.Btn_Peso.Size = new System.Drawing.Size(140, 56);
            this.Btn_Peso.TabIndex = 6;
            this.Btn_Peso.Text = "Mantener Peso";
            this.Btn_Peso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Peso.UseVisualStyleBackColor = true;
            this.Btn_Peso.Click += new System.EventHandler(this.Btn_progreso_Click);
            // 
            // Btn_Gains
            // 
            this.Btn_Gains.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Gains.Image")));
            this.Btn_Gains.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Gains.Location = new System.Drawing.Point(177, 397);
            this.Btn_Gains.Name = "Btn_Gains";
            this.Btn_Gains.Size = new System.Drawing.Size(140, 61);
            this.Btn_Gains.TabIndex = 5;
            this.Btn_Gains.Text = "Ganar Musculo";
            this.Btn_Gains.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Gains.UseVisualStyleBackColor = true;
            this.Btn_Gains.Click += new System.EventHandler(this.Btn_Gains_Click);
            // 
            // Btn_PGrasa
            // 
            this.Btn_PGrasa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_PGrasa.Image = ((System.Drawing.Image)(resources.GetObject("Btn_PGrasa.Image")));
            this.Btn_PGrasa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_PGrasa.Location = new System.Drawing.Point(177, 239);
            this.Btn_PGrasa.Name = "Btn_PGrasa";
            this.Btn_PGrasa.Size = new System.Drawing.Size(140, 59);
            this.Btn_PGrasa.TabIndex = 4;
            this.Btn_PGrasa.Text = "Perder Grasa";
            this.Btn_PGrasa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_PGrasa.UseVisualStyleBackColor = true;
            this.Btn_PGrasa.Click += new System.EventHandler(this.Btn_PGrasa_Click);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Proyecto2.Properties.Resources.Captura_de_pantalla_2025_03_10_000453;
            this.ClientSize = new System.Drawing.Size(538, 806);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Peso);
            this.Controls.Add(this.Btn_Gains);
            this.Controls.Add(this.Btn_PGrasa);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "inicio";
            this.Text = "inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_PGrasa;
        private System.Windows.Forms.Button Btn_Gains;
        private System.Windows.Forms.Button Btn_Peso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}