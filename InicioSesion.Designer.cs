namespace Proyecto2
{
    partial class InicioSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.Txt_NombreUser = new System.Windows.Forms.TextBox();
            this.Btn_iniciar = new System.Windows.Forms.Button();
            this.lbl_logo = new System.Windows.Forms.Label();
            this.lbl_iniSes1 = new System.Windows.Forms.Label();
            this.lbl_iniSes2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_privacidad1 = new System.Windows.Forms.Label();
            this.lbl_privacidad2 = new System.Windows.Forms.Label();
            this.lbl_privacy3 = new System.Windows.Forms.Label();
            this.lbl_privacy4 = new System.Windows.Forms.Label();
            this.pbi_apple = new System.Windows.Forms.PictureBox();
            this.pbi_google = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbi_apple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbi_google)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_NombreUser
            // 
            this.Txt_NombreUser.BackColor = System.Drawing.Color.White;
            this.Txt_NombreUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_NombreUser.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NombreUser.Location = new System.Drawing.Point(42, 223);
            this.Txt_NombreUser.Multiline = true;
            this.Txt_NombreUser.Name = "Txt_NombreUser";
            this.Txt_NombreUser.Size = new System.Drawing.Size(482, 39);
            this.Txt_NombreUser.TabIndex = 1;
            this.Txt_NombreUser.Tag = "";
            this.Txt_NombreUser.TextChanged += new System.EventHandler(this.Txt_NombreUser_TextChanged);
            this.Txt_NombreUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_NombreUser_KeyPress);
            this.Txt_NombreUser.MouseEnter += new System.EventHandler(this.Txt_NombreUser_MouseEnter);
            // 
            // Btn_iniciar
            // 
            this.Btn_iniciar.BackColor = System.Drawing.Color.Black;
            this.Btn_iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_iniciar.ForeColor = System.Drawing.Color.White;
            this.Btn_iniciar.Location = new System.Drawing.Point(42, 360);
            this.Btn_iniciar.Name = "Btn_iniciar";
            this.Btn_iniciar.Size = new System.Drawing.Size(482, 52);
            this.Btn_iniciar.TabIndex = 2;
            this.Btn_iniciar.Text = "Continue";
            this.Btn_iniciar.UseVisualStyleBackColor = false;
            this.Btn_iniciar.Click += new System.EventHandler(this.Btn_iniciar_Click);
            // 
            // lbl_logo
            // 
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logo.Location = new System.Drawing.Point(174, 98);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(210, 52);
            this.lbl_logo.TabIndex = 5;
            this.lbl_logo.Text = "NutriSync";
            this.lbl_logo.Click += new System.EventHandler(this.lbl_logo_Click);
            // 
            // lbl_iniSes1
            // 
            this.lbl_iniSes1.AutoSize = true;
            this.lbl_iniSes1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_iniSes1.Location = new System.Drawing.Point(178, 170);
            this.lbl_iniSes1.Name = "lbl_iniSes1";
            this.lbl_iniSes1.Size = new System.Drawing.Size(170, 25);
            this.lbl_iniSes1.TabIndex = 6;
            this.lbl_iniSes1.Text = "cuenta existente";
            this.lbl_iniSes1.Click += new System.EventHandler(this.lbl_iniSes1_Click);
            // 
            // lbl_iniSes2
            // 
            this.lbl_iniSes2.AutoSize = true;
            this.lbl_iniSes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_iniSes2.Location = new System.Drawing.Point(37, 195);
            this.lbl_iniSes2.Name = "lbl_iniSes2";
            this.lbl_iniSes2.Size = new System.Drawing.Size(265, 25);
            this.lbl_iniSes2.TabIndex = 7;
            this.lbl_iniSes2.Text = "Ingresa tu nombre de usuario";
            this.lbl_iniSes2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_iniSes2.Click += new System.EventHandler(this.lbl_iniSes2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(37, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "---------------------------- or ---------------------------";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_privacidad1
            // 
            this.lbl_privacidad1.AutoSize = true;
            this.lbl_privacidad1.Location = new System.Drawing.Point(92, 636);
            this.lbl_privacidad1.Name = "lbl_privacidad1";
            this.lbl_privacidad1.Size = new System.Drawing.Size(227, 16);
            this.lbl_privacidad1.TabIndex = 11;
            this.lbl_privacidad1.Text = "By clicking continue, you agree to our";
            this.lbl_privacidad1.Click += new System.EventHandler(this.lbl_privacidad1_Click);
            // 
            // lbl_privacidad2
            // 
            this.lbl_privacidad2.AutoSize = true;
            this.lbl_privacidad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_privacidad2.Location = new System.Drawing.Point(319, 636);
            this.lbl_privacidad2.Name = "lbl_privacidad2";
            this.lbl_privacidad2.Size = new System.Drawing.Size(117, 16);
            this.lbl_privacidad2.TabIndex = 12;
            this.lbl_privacidad2.Text = "Term of Service";
            this.lbl_privacidad2.Click += new System.EventHandler(this.lbl_privacidad2_Click);
            // 
            // lbl_privacy3
            // 
            this.lbl_privacy3.AutoSize = true;
            this.lbl_privacy3.Location = new System.Drawing.Point(225, 656);
            this.lbl_privacy3.Name = "lbl_privacy3";
            this.lbl_privacy3.Size = new System.Drawing.Size(30, 16);
            this.lbl_privacy3.TabIndex = 13;
            this.lbl_privacy3.Text = "and";
            this.lbl_privacy3.Click += new System.EventHandler(this.lbl_privacy3_Click);
            // 
            // lbl_privacy4
            // 
            this.lbl_privacy4.AutoSize = true;
            this.lbl_privacy4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_privacy4.Location = new System.Drawing.Point(260, 656);
            this.lbl_privacy4.Name = "lbl_privacy4";
            this.lbl_privacy4.Size = new System.Drawing.Size(106, 16);
            this.lbl_privacy4.TabIndex = 14;
            this.lbl_privacy4.Text = "Privacy Polyci";
            this.lbl_privacy4.Click += new System.EventHandler(this.lbl_privacy4_Click);
            // 
            // pbi_apple
            // 
            this.pbi_apple.BackColor = System.Drawing.Color.White;
            this.pbi_apple.Image = ((System.Drawing.Image)(resources.GetObject("pbi_apple.Image")));
            this.pbi_apple.Location = new System.Drawing.Point(42, 555);
            this.pbi_apple.Name = "pbi_apple";
            this.pbi_apple.Size = new System.Drawing.Size(482, 49);
            this.pbi_apple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbi_apple.TabIndex = 10;
            this.pbi_apple.TabStop = false;
            this.pbi_apple.Click += new System.EventHandler(this.pbi_apple_Click);
            // 
            // pbi_google
            // 
            this.pbi_google.BackColor = System.Drawing.Color.White;
            this.pbi_google.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbi_google.Image = ((System.Drawing.Image)(resources.GetObject("pbi_google.Image")));
            this.pbi_google.Location = new System.Drawing.Point(42, 481);
            this.pbi_google.Name = "pbi_google";
            this.pbi_google.Size = new System.Drawing.Size(482, 50);
            this.pbi_google.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbi_google.TabIndex = 9;
            this.pbi_google.TabStop = false;
            this.pbi_google.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(42, 297);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(482, 39);
            this.textBox1.TabIndex = 15;
            this.textBox1.Tag = "";
            this.textBox1.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ingresa tu contraseña";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(548, 787);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_privacy4);
            this.Controls.Add(this.lbl_privacy3);
            this.Controls.Add(this.lbl_privacidad2);
            this.Controls.Add(this.lbl_privacidad1);
            this.Controls.Add(this.pbi_apple);
            this.Controls.Add(this.pbi_google);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_iniSes2);
            this.Controls.Add(this.lbl_iniSes1);
            this.Controls.Add(this.lbl_logo);
            this.Controls.Add(this.Btn_iniciar);
            this.Controls.Add(this.Txt_NombreUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InicioSesion";
            this.Text = "InicioSesion";
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbi_apple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbi_google)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_NombreUser;
        private System.Windows.Forms.Button Btn_iniciar;
        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.Label lbl_iniSes1;
        private System.Windows.Forms.Label lbl_iniSes2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbi_google;
        private System.Windows.Forms.PictureBox pbi_apple;
        private System.Windows.Forms.Label lbl_privacidad1;
        private System.Windows.Forms.Label lbl_privacidad2;
        private System.Windows.Forms.Label lbl_privacy3;
        private System.Windows.Forms.Label lbl_privacy4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

