namespace Proyecto2
{
    partial class Actividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actividad));
            this.lbl_Actividad = new System.Windows.Forms.Label();
            this.Btn_Sede = new System.Windows.Forms.Button();
            this.Btn_Acti = new System.Windows.Forms.Button();
            this.Btn_MActi = new System.Windows.Forms.Button();
            this.Btn_MoActi = new System.Windows.Forms.Button();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.pickA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pickA)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Actividad
            // 
            this.lbl_Actividad.AutoSize = true;
            this.lbl_Actividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Actividad.Location = new System.Drawing.Point(157, 110);
            this.lbl_Actividad.Name = "lbl_Actividad";
            this.lbl_Actividad.Size = new System.Drawing.Size(237, 20);
            this.lbl_Actividad.TabIndex = 0;
            this.lbl_Actividad.Text = "¿Cual es tu nivel de actividad?";
            // 
            // Btn_Sede
            // 
            this.Btn_Sede.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sede.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Sede.Location = new System.Drawing.Point(183, 193);
            this.Btn_Sede.Name = "Btn_Sede";
            this.Btn_Sede.Size = new System.Drawing.Size(211, 54);
            this.Btn_Sede.TabIndex = 1;
            this.Btn_Sede.Text = "Sedentario\r\nPoco o nada de ejercicio";
            this.Btn_Sede.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Sede.UseVisualStyleBackColor = true;
            this.Btn_Sede.Click += new System.EventHandler(this.Btn_Sede_Click);
            // 
            // Btn_Acti
            // 
            this.Btn_Acti.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Acti.Location = new System.Drawing.Point(183, 297);
            this.Btn_Acti.Name = "Btn_Acti";
            this.Btn_Acti.Size = new System.Drawing.Size(211, 51);
            this.Btn_Acti.TabIndex = 2;
            this.Btn_Acti.Text = "Ligeramente Activo\r\nEjercicio 2 a 3 dias por semana";
            this.Btn_Acti.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Acti.UseVisualStyleBackColor = true;
            this.Btn_Acti.Click += new System.EventHandler(this.Btn_Acti_Click);
            // 
            // Btn_MActi
            // 
            this.Btn_MActi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_MActi.Location = new System.Drawing.Point(181, 504);
            this.Btn_MActi.Name = "Btn_MActi";
            this.Btn_MActi.Size = new System.Drawing.Size(213, 53);
            this.Btn_MActi.TabIndex = 3;
            this.Btn_MActi.Text = "Muy activo\r\nEjercicio de 6 a 7 dias por semana";
            this.Btn_MActi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_MActi.UseVisualStyleBackColor = true;
            this.Btn_MActi.Click += new System.EventHandler(this.Btn_MActi_Click);
            // 
            // Btn_MoActi
            // 
            this.Btn_MoActi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_MoActi.Location = new System.Drawing.Point(183, 404);
            this.Btn_MoActi.Name = "Btn_MoActi";
            this.Btn_MoActi.Size = new System.Drawing.Size(211, 53);
            this.Btn_MoActi.TabIndex = 4;
            this.Btn_MoActi.Text = "Moderadamente Activo\r\nEjercicio 4 a 5 dias por semana";
            this.Btn_MoActi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_MoActi.UseVisualStyleBackColor = true;
            this.Btn_MoActi.Click += new System.EventHandler(this.Btn_MoActi_Click);
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(226, 222);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(0, 16);
            this.lbl_descripcion.TabIndex = 5;
            this.lbl_descripcion.Click += new System.EventHandler(this.lbl_descripcion_Click);
            // 
            // pickA
            // 
            this.pickA.Image = ((System.Drawing.Image)(resources.GetObject("pickA.Image")));
            this.pickA.Location = new System.Drawing.Point(254, 46);
            this.pickA.Name = "pickA";
            this.pickA.Size = new System.Drawing.Size(48, 48);
            this.pickA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pickA.TabIndex = 6;
            this.pickA.TabStop = false;
            // 
            // Actividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(586, 750);
            this.Controls.Add(this.pickA);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.Btn_MoActi);
            this.Controls.Add(this.Btn_MActi);
            this.Controls.Add(this.Btn_Acti);
            this.Controls.Add(this.Btn_Sede);
            this.Controls.Add(this.lbl_Actividad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Actividad";
            this.Text = "Actividad";
            this.Load += new System.EventHandler(this.Actividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pickA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Actividad;
        private System.Windows.Forms.Button Btn_Sede;
        private System.Windows.Forms.Button Btn_Acti;
        private System.Windows.Forms.Button Btn_MActi;
        private System.Windows.Forms.Button Btn_MoActi;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.PictureBox pickA;
    }
}