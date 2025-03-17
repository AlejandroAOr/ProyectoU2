namespace Proyecto2
{
    partial class Calendario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendario));
            this.mc_calendario = new System.Windows.Forms.MonthCalendar();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.pb_editar = new System.Windows.Forms.PictureBox();
            this.pb_logocalendar = new System.Windows.Forms.PictureBox();
            this.lbl_fechaselect = new System.Windows.Forms.Label();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.lbl_fechFinal = new System.Windows.Forms.Label();
            this.lbl_fin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logocalendar)).BeginInit();
            this.SuspendLayout();
            // 
            // mc_calendario
            // 
            this.mc_calendario.BackColor = System.Drawing.Color.White;
            this.mc_calendario.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.mc_calendario.Font = new System.Drawing.Font("Tw Cen MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mc_calendario.ForeColor = System.Drawing.SystemColors.InfoText;
            this.mc_calendario.Location = new System.Drawing.Point(90, 153);
            this.mc_calendario.MaxSelectionCount = 30;
            this.mc_calendario.Name = "mc_calendario";
            this.mc_calendario.ShowToday = false;
            this.mc_calendario.TabIndex = 0;
            this.mc_calendario.TitleBackColor = System.Drawing.Color.Aquamarine;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(80, 34);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(72, 25);
            this.lbl_fecha.TabIndex = 1;
            this.lbl_fecha.Text = "Fecha";
            // 
            // pb_editar
            // 
            this.pb_editar.Image = ((System.Drawing.Image)(resources.GetObject("pb_editar.Image")));
            this.pb_editar.Location = new System.Drawing.Point(398, 34);
            this.pb_editar.Name = "pb_editar";
            this.pb_editar.Size = new System.Drawing.Size(43, 39);
            this.pb_editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_editar.TabIndex = 2;
            this.pb_editar.TabStop = false;
            this.pb_editar.Click += new System.EventHandler(this.pb_editar_Click);
            // 
            // pb_logocalendar
            // 
            this.pb_logocalendar.Image = ((System.Drawing.Image)(resources.GetObject("pb_logocalendar.Image")));
            this.pb_logocalendar.Location = new System.Drawing.Point(12, 34);
            this.pb_logocalendar.Name = "pb_logocalendar";
            this.pb_logocalendar.Size = new System.Drawing.Size(69, 54);
            this.pb_logocalendar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logocalendar.TabIndex = 3;
            this.pb_logocalendar.TabStop = false;
            // 
            // lbl_fechaselect
            // 
            this.lbl_fechaselect.AutoSize = true;
            this.lbl_fechaselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechaselect.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_fechaselect.Location = new System.Drawing.Point(85, 63);
            this.lbl_fechaselect.Name = "lbl_fechaselect";
            this.lbl_fechaselect.Size = new System.Drawing.Size(129, 25);
            this.lbl_fechaselect.TabIndex = 4;
            this.lbl_fechaselect.Text = "Sep 12 -15 ...";
            this.lbl_fechaselect.Click += new System.EventHandler(this.lbl_fechaselect_Click);
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Location = new System.Drawing.Point(181, 590);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(114, 42);
            this.btn_seleccionar.TabIndex = 5;
            this.btn_seleccionar.Text = "Seleccionar";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // lbl_fechFinal
            // 
            this.lbl_fechFinal.AutoSize = true;
            this.lbl_fechFinal.Location = new System.Drawing.Point(221, 63);
            this.lbl_fechFinal.Name = "lbl_fechFinal";
            this.lbl_fechFinal.Size = new System.Drawing.Size(0, 16);
            this.lbl_fechFinal.TabIndex = 6;
            // 
            // lbl_fin
            // 
            this.lbl_fin.AutoSize = true;
            this.lbl_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_fin.Location = new System.Drawing.Point(227, 63);
            this.lbl_fin.Name = "lbl_fin";
            this.lbl_fin.Size = new System.Drawing.Size(20, 25);
            this.lbl_fin.TabIndex = 7;
            this.lbl_fin.Text = "-";
            // 
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(467, 699);
            this.Controls.Add(this.lbl_fin);
            this.Controls.Add(this.lbl_fechFinal);
            this.Controls.Add(this.btn_seleccionar);
            this.Controls.Add(this.lbl_fechaselect);
            this.Controls.Add(this.pb_logocalendar);
            this.Controls.Add(this.pb_editar);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.mc_calendario);
            this.Name = "Calendario";
            this.Text = "Calendario";
            this.Load += new System.EventHandler(this.Calendario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logocalendar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mc_calendario;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.PictureBox pb_editar;
        private System.Windows.Forms.PictureBox pb_logocalendar;
        private System.Windows.Forms.Label lbl_fechaselect;
        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.Label lbl_fechFinal;
        private System.Windows.Forms.Label lbl_fin;
    }
}