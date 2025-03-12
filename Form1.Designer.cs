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
            this.Txt_ContraseñaUser = new System.Windows.Forms.TextBox();
            this.Txt_NombreUser = new System.Windows.Forms.TextBox();
            this.Btn_iniciar = new System.Windows.Forms.Button();
            this.lbl_Contra = new System.Windows.Forms.Label();
            this.lbl_logo = new System.Windows.Forms.Label();
            this.lbl_iniSes1 = new System.Windows.Forms.Label();
            this.lbl_iniSes2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_ContraseñaUser
            // 
            this.Txt_ContraseñaUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_ContraseñaUser.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ContraseñaUser.Location = new System.Drawing.Point(212, 542);
            this.Txt_ContraseñaUser.Multiline = true;
            this.Txt_ContraseñaUser.Name = "Txt_ContraseñaUser";
            this.Txt_ContraseñaUser.Size = new System.Drawing.Size(176, 39);
            this.Txt_ContraseñaUser.TabIndex = 0;
            // 
            // Txt_NombreUser
            // 
            this.Txt_NombreUser.BackColor = System.Drawing.Color.White;
            this.Txt_NombreUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_NombreUser.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NombreUser.Location = new System.Drawing.Point(42, 247);
            this.Txt_NombreUser.Multiline = true;
            this.Txt_NombreUser.Name = "Txt_NombreUser";
            this.Txt_NombreUser.Size = new System.Drawing.Size(482, 39);
            this.Txt_NombreUser.TabIndex = 1;
            this.Txt_NombreUser.Tag = "";
            this.Txt_NombreUser.TextChanged += new System.EventHandler(this.Txt_NombreUser_TextChanged);
            // 
            // Btn_iniciar
            // 
            this.Btn_iniciar.BackColor = System.Drawing.Color.Black;
            this.Btn_iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_iniciar.ForeColor = System.Drawing.Color.White;
            this.Btn_iniciar.Location = new System.Drawing.Point(42, 292);
            this.Btn_iniciar.Name = "Btn_iniciar";
            this.Btn_iniciar.Size = new System.Drawing.Size(482, 52);
            this.Btn_iniciar.TabIndex = 2;
            this.Btn_iniciar.Text = "Continue";
            this.Btn_iniciar.UseVisualStyleBackColor = false;
            this.Btn_iniciar.Click += new System.EventHandler(this.Btn_iniciar_Click);
            // 
            // lbl_Contra
            // 
            this.lbl_Contra.AutoSize = true;
            this.lbl_Contra.BackColor = System.Drawing.Color.LightGreen;
            this.lbl_Contra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Contra.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contra.Location = new System.Drawing.Point(42, 549);
            this.lbl_Contra.Name = "lbl_Contra";
            this.lbl_Contra.Size = new System.Drawing.Size(141, 32);
            this.lbl_Contra.TabIndex = 4;
            this.lbl_Contra.Text = "Contraseña";
            // 
            // lbl_logo
            // 
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logo.Location = new System.Drawing.Point(178, 30);
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
            this.lbl_iniSes1.Location = new System.Drawing.Point(191, 149);
            this.lbl_iniSes1.Name = "lbl_iniSes1";
            this.lbl_iniSes1.Size = new System.Drawing.Size(172, 25);
            this.lbl_iniSes1.TabIndex = 6;
            this.lbl_iniSes1.Text = "Crea una cuenta";
            // 
            // lbl_iniSes2
            // 
            this.lbl_iniSes2.AutoSize = true;
            this.lbl_iniSes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_iniSes2.Location = new System.Drawing.Point(146, 174);
            this.lbl_iniSes2.Name = "lbl_iniSes2";
            this.lbl_iniSes2.Size = new System.Drawing.Size(257, 25);
            this.lbl_iniSes2.TabIndex = 7;
            this.lbl_iniSes2.Text = "Ingresa tu correo electrónico";
            this.lbl_iniSes2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(37, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "---------------------------- or ---------------------------";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(482, 63);
            this.button1.TabIndex = 9;
            this.button1.Text = "Continue with Google";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(548, 621);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_iniSes2);
            this.Controls.Add(this.lbl_iniSes1);
            this.Controls.Add(this.lbl_logo);
            this.Controls.Add(this.lbl_Contra);
            this.Controls.Add(this.Btn_iniciar);
            this.Controls.Add(this.Txt_NombreUser);
            this.Controls.Add(this.Txt_ContraseñaUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InicioSesion";
            this.Text = "InicioSesion";
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_ContraseñaUser;
        private System.Windows.Forms.TextBox Txt_NombreUser;
        private System.Windows.Forms.Button Btn_iniciar;
        private System.Windows.Forms.Label lbl_Contra;
        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.Label lbl_iniSes1;
        private System.Windows.Forms.Label lbl_iniSes2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

