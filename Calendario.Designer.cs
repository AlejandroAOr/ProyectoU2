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
            this.lbl_fechaselect = new System.Windows.Forms.Label();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.lbl_fechFinal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_perfil = new System.Windows.Forms.PictureBox();
            this.pb_recetas = new System.Windows.Forms.PictureBox();
            this.pb_calendar = new System.Windows.Forms.PictureBox();
            this.pb_miPlan = new System.Windows.Forms.PictureBox();
            this.pb_home = new System.Windows.Forms.PictureBox();
            this.pb_grande = new System.Windows.Forms.PictureBox();
            this.pictureBx_usu = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pb_editar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_perfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_recetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_calendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_miPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_grande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBx_usu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editar)).BeginInit();
            this.SuspendLayout();
            // 
            // mc_calendario
            // 
            this.mc_calendario.BackColor = System.Drawing.Color.White;
            this.mc_calendario.Font = new System.Drawing.Font("Tw Cen MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mc_calendario.ForeColor = System.Drawing.SystemColors.InfoText;
            this.mc_calendario.Location = new System.Drawing.Point(85, 165);
            this.mc_calendario.MaxSelectionCount = 30;
            this.mc_calendario.Name = "mc_calendario";
            this.mc_calendario.ShowToday = false;
            this.mc_calendario.TabIndex = 0;
            this.mc_calendario.TitleBackColor = System.Drawing.Color.Aquamarine;
            this.mc_calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mc_calendario_DateChanged);
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
            this.btn_seleccionar.Location = new System.Drawing.Point(167, 413);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto2.Properties.Resources._42446;
            this.pictureBox1.Location = new System.Drawing.Point(14, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // pb_perfil
            // 
            this.pb_perfil.Image = global::Proyecto2.Properties.Resources._3106921;
            this.pb_perfil.Location = new System.Drawing.Point(389, 655);
            this.pb_perfil.Name = "pb_perfil";
            this.pb_perfil.Size = new System.Drawing.Size(60, 32);
            this.pb_perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_perfil.TabIndex = 48;
            this.pb_perfil.TabStop = false;
            this.pb_perfil.Click += new System.EventHandler(this.pb_perfil_Click);
            // 
            // pb_recetas
            // 
            this.pb_recetas.Image = global::Proyecto2.Properties.Resources.pngtree_paper_line_icon_png_image_9040756;
            this.pb_recetas.Location = new System.Drawing.Point(290, 655);
            this.pb_recetas.Name = "pb_recetas";
            this.pb_recetas.Size = new System.Drawing.Size(60, 32);
            this.pb_recetas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_recetas.TabIndex = 47;
            this.pb_recetas.TabStop = false;
            this.pb_recetas.Click += new System.EventHandler(this.pb_recetas_Click);
            // 
            // pb_calendar
            // 
            this.pb_calendar.Image = global::Proyecto2.Properties.Resources._42446;
            this.pb_calendar.Location = new System.Drawing.Point(204, 655);
            this.pb_calendar.Name = "pb_calendar";
            this.pb_calendar.Size = new System.Drawing.Size(60, 32);
            this.pb_calendar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_calendar.TabIndex = 46;
            this.pb_calendar.TabStop = false;
            this.pb_calendar.Click += new System.EventHandler(this.pictureBox20_Click);
            // 
            // pb_miPlan
            // 
            this.pb_miPlan.Image = global::Proyecto2.Properties.Resources._156838;
            this.pb_miPlan.Location = new System.Drawing.Point(111, 655);
            this.pb_miPlan.Name = "pb_miPlan";
            this.pb_miPlan.Size = new System.Drawing.Size(60, 32);
            this.pb_miPlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_miPlan.TabIndex = 45;
            this.pb_miPlan.TabStop = false;
            this.pb_miPlan.Click += new System.EventHandler(this.pictureBox21_Click);
            // 
            // pb_home
            // 
            this.pb_home.Image = global::Proyecto2.Properties.Resources.png_transparent_computer_icons_home_house_home_angle_building_rectangle_thumbnail_removebg_preview;
            this.pb_home.Location = new System.Drawing.Point(15, 655);
            this.pb_home.Name = "pb_home";
            this.pb_home.Size = new System.Drawing.Size(60, 32);
            this.pb_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_home.TabIndex = 44;
            this.pb_home.TabStop = false;
            this.pb_home.Click += new System.EventHandler(this.pb_home_Click);
            // 
            // pb_grande
            // 
            this.pb_grande.BackColor = System.Drawing.Color.White;
            this.pb_grande.Location = new System.Drawing.Point(-31, 635);
            this.pb_grande.Name = "pb_grande";
            this.pb_grande.Size = new System.Drawing.Size(525, 70);
            this.pb_grande.TabIndex = 43;
            this.pb_grande.TabStop = false;
            // 
            // pictureBx_usu
            // 
            this.pictureBx_usu.Image = global::Proyecto2.Properties.Resources._3106921;
            this.pictureBx_usu.Location = new System.Drawing.Point(389, 655);
            this.pictureBx_usu.Name = "pictureBx_usu";
            this.pictureBx_usu.Size = new System.Drawing.Size(60, 32);
            this.pictureBx_usu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBx_usu.TabIndex = 42;
            this.pictureBx_usu.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::Proyecto2.Properties.Resources.pngtree_paper_line_icon_png_image_9040756;
            this.pictureBox13.Location = new System.Drawing.Point(290, 655);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(60, 32);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 41;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::Proyecto2.Properties.Resources._42446;
            this.pictureBox12.Location = new System.Drawing.Point(204, 655);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(60, 32);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 40;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Proyecto2.Properties.Resources._156838;
            this.pictureBox11.Location = new System.Drawing.Point(111, 655);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(60, 32);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 39;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Proyecto2.Properties.Resources.png_transparent_computer_icons_home_house_home_angle_building_rectangle_thumbnail_removebg_preview;
            this.pictureBox7.Location = new System.Drawing.Point(15, 655);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(60, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 38;
            this.pictureBox7.TabStop = false;
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
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(467, 699);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pb_perfil);
            this.Controls.Add(this.pb_recetas);
            this.Controls.Add(this.pb_calendar);
            this.Controls.Add(this.pb_miPlan);
            this.Controls.Add(this.pb_home);
            this.Controls.Add(this.pb_grande);
            this.Controls.Add(this.pictureBx_usu);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.lbl_fechFinal);
            this.Controls.Add(this.btn_seleccionar);
            this.Controls.Add(this.lbl_fechaselect);
            this.Controls.Add(this.pb_editar);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.mc_calendario);
            this.Name = "Calendario";
            this.Text = "Calendario";
            this.Load += new System.EventHandler(this.Calendario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_perfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_recetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_calendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_miPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_grande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBx_usu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mc_calendario;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.PictureBox pb_editar;
        private System.Windows.Forms.Label lbl_fechaselect;
        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.Label lbl_fechFinal;
        private System.Windows.Forms.PictureBox pb_perfil;
        private System.Windows.Forms.PictureBox pb_recetas;
        private System.Windows.Forms.PictureBox pb_calendar;
        private System.Windows.Forms.PictureBox pb_miPlan;
        private System.Windows.Forms.PictureBox pb_home;
        private System.Windows.Forms.PictureBox pb_grande;
        private System.Windows.Forms.PictureBox pictureBx_usu;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}