namespace Proyecto2
{
    partial class General
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(General));
            this.lbl_pregunta2 = new System.Windows.Forms.Label();
            this.Btn_PlanNutri = new System.Windows.Forms.Button();
            this.Btn_ContarCal = new System.Windows.Forms.Button();
            this.img_1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_pregunta2
            // 
            this.lbl_pregunta2.AutoSize = true;
            this.lbl_pregunta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pregunta2.Location = new System.Drawing.Point(137, 135);
            this.lbl_pregunta2.Name = "lbl_pregunta2";
            this.lbl_pregunta2.Size = new System.Drawing.Size(247, 20);
            this.lbl_pregunta2.TabIndex = 2;
            this.lbl_pregunta2.Text = "¿Como deseas conseguirlo?";
            // 
            // Btn_PlanNutri
            // 
            this.Btn_PlanNutri.Image = ((System.Drawing.Image)(resources.GetObject("Btn_PlanNutri.Image")));
            this.Btn_PlanNutri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_PlanNutri.Location = new System.Drawing.Point(51, 294);
            this.Btn_PlanNutri.Name = "Btn_PlanNutri";
            this.Btn_PlanNutri.Size = new System.Drawing.Size(410, 55);
            this.Btn_PlanNutri.TabIndex = 1;
            this.Btn_PlanNutri.Text = "No se que comer. Necesito sugerencias de comidas";
            this.Btn_PlanNutri.UseVisualStyleBackColor = true;
            this.Btn_PlanNutri.Click += new System.EventHandler(this.Btn_PlanNutri_Click);
            // 
            // Btn_ContarCal
            // 
            this.Btn_ContarCal.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ContarCal.Image")));
            this.Btn_ContarCal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ContarCal.Location = new System.Drawing.Point(51, 228);
            this.Btn_ContarCal.Name = "Btn_ContarCal";
            this.Btn_ContarCal.Size = new System.Drawing.Size(410, 51);
            this.Btn_ContarCal.TabIndex = 0;
            this.Btn_ContarCal.Text = "Se que comer. Necesito monitorias mis calorias ";
            this.Btn_ContarCal.UseVisualStyleBackColor = true;
            this.Btn_ContarCal.Click += new System.EventHandler(this.Btn_ContarCal_Click);
            // 
            // img_1
            // 
            this.img_1.Image = ((System.Drawing.Image)(resources.GetObject("img_1.Image")));
            this.img_1.Location = new System.Drawing.Point(215, 59);
            this.img_1.Name = "img_1";
            this.img_1.Size = new System.Drawing.Size(64, 64);
            this.img_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.img_1.TabIndex = 3;
            this.img_1.TabStop = false;
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(541, 520);
            this.Controls.Add(this.img_1);
            this.Controls.Add(this.lbl_pregunta2);
            this.Controls.Add(this.Btn_PlanNutri);
            this.Controls.Add(this.Btn_ContarCal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "General";
            this.Text = "General";
            ((System.ComponentModel.ISupportInitialize)(this.img_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_ContarCal;
        private System.Windows.Forms.Button Btn_PlanNutri;
        private System.Windows.Forms.Label lbl_pregunta2;
        private System.Windows.Forms.PictureBox img_1;
    }
}