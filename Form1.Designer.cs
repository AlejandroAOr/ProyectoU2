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
            this.lbl_Nuser = new System.Windows.Forms.Label();
            this.lbl_Contra = new System.Windows.Forms.Label();
            this.Btn_CrearCuenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_ContraseñaUser
            // 
            this.Txt_ContraseñaUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_ContraseñaUser.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ContraseñaUser.Location = new System.Drawing.Point(191, 362);
            this.Txt_ContraseñaUser.Multiline = true;
            this.Txt_ContraseñaUser.Name = "Txt_ContraseñaUser";
            this.Txt_ContraseñaUser.Size = new System.Drawing.Size(176, 39);
            this.Txt_ContraseñaUser.TabIndex = 0;
            // 
            // Txt_NombreUser
            // 
            this.Txt_NombreUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_NombreUser.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NombreUser.Location = new System.Drawing.Point(191, 230);
            this.Txt_NombreUser.Multiline = true;
            this.Txt_NombreUser.Name = "Txt_NombreUser";
            this.Txt_NombreUser.Size = new System.Drawing.Size(176, 39);
            this.Txt_NombreUser.TabIndex = 1;
            this.Txt_NombreUser.TextChanged += new System.EventHandler(this.Txt_NombreUser_TextChanged);
            // 
            // Btn_iniciar
            // 
            this.Btn_iniciar.Location = new System.Drawing.Point(123, 308);
            this.Btn_iniciar.Name = "Btn_iniciar";
            this.Btn_iniciar.Size = new System.Drawing.Size(129, 67);
            this.Btn_iniciar.TabIndex = 2;
            this.Btn_iniciar.Text = "Iniciar";
            this.Btn_iniciar.UseVisualStyleBackColor = false;
            this.Btn_iniciar.Click += new System.EventHandler(this.Btn_iniciar_Click);
            // 
            // lbl_Nuser
            // 
            this.lbl_Nuser.AutoSize = true;
            this.lbl_Nuser.BackColor = System.Drawing.Color.LightGreen;
            this.lbl_Nuser.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nuser.Location = new System.Drawing.Point(162, 188);
            this.lbl_Nuser.Name = "lbl_Nuser";
            this.lbl_Nuser.Size = new System.Drawing.Size(233, 30);
            this.lbl_Nuser.TabIndex = 3;
            this.lbl_Nuser.Text = "Nombre de Usuario";
            // 
            // lbl_Contra
            // 
            this.lbl_Contra.AutoSize = true;
            this.lbl_Contra.BackColor = System.Drawing.Color.LightGreen;
            this.lbl_Contra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Contra.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contra.Location = new System.Drawing.Point(209, 318);
            this.lbl_Contra.Name = "lbl_Contra";
            this.lbl_Contra.Size = new System.Drawing.Size(141, 32);
            this.lbl_Contra.TabIndex = 4;
            this.lbl_Contra.Text = "Contraseña";
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 437);
            this.Controls.Add(this.lbl_Contra);
            this.Controls.Add(this.lbl_Nuser);
            this.Controls.Add(this.Btn_iniciar);
            this.Controls.Add(this.Txt_NombreUser);
            this.Controls.Add(this.Txt_ContraseñaUser);
            this.Controls.Add(this.pb_logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InicioSesion";
            this.Text = "InicioSesion";
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_ContraseñaUser;
        private System.Windows.Forms.TextBox Txt_NombreUser;
        private System.Windows.Forms.Button Btn_iniciar;
        private System.Windows.Forms.Label lbl_Nuser;
        private System.Windows.Forms.Label lbl_Contra;
    }
}

