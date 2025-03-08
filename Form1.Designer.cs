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
            this.Txt_ContraseñaUser = new System.Windows.Forms.TextBox();
            this.Txt_NombreUser = new System.Windows.Forms.TextBox();
            this.Btn_iniciar = new System.Windows.Forms.Button();
            this.lbl_Nuser = new System.Windows.Forms.Label();
            this.lbl_Contra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_ContraseñaUser
            // 
            this.Txt_ContraseñaUser.Location = new System.Drawing.Point(112, 224);
            this.Txt_ContraseñaUser.Name = "Txt_ContraseñaUser";
            this.Txt_ContraseñaUser.Size = new System.Drawing.Size(100, 22);
            this.Txt_ContraseñaUser.TabIndex = 0;
            // 
            // Txt_NombreUser
            // 
            this.Txt_NombreUser.Location = new System.Drawing.Point(104, 135);
            this.Txt_NombreUser.Name = "Txt_NombreUser";
            this.Txt_NombreUser.Size = new System.Drawing.Size(122, 22);
            this.Txt_NombreUser.TabIndex = 1;
            // 
            // Btn_iniciar
            // 
            this.Btn_iniciar.Location = new System.Drawing.Point(123, 308);
            this.Btn_iniciar.Name = "Btn_iniciar";
            this.Btn_iniciar.Size = new System.Drawing.Size(75, 23);
            this.Btn_iniciar.TabIndex = 2;
            this.Btn_iniciar.Text = "Iniciar";
            this.Btn_iniciar.UseVisualStyleBackColor = true;
            this.Btn_iniciar.Click += new System.EventHandler(this.Btn_iniciar_Click);
            // 
            // lbl_Nuser
            // 
            this.lbl_Nuser.AutoSize = true;
            this.lbl_Nuser.Location = new System.Drawing.Point(101, 116);
            this.lbl_Nuser.Name = "lbl_Nuser";
            this.lbl_Nuser.Size = new System.Drawing.Size(125, 16);
            this.lbl_Nuser.TabIndex = 3;
            this.lbl_Nuser.Text = "Nombre de Usuario";
            // 
            // lbl_Contra
            // 
            this.lbl_Contra.AutoSize = true;
            this.lbl_Contra.Location = new System.Drawing.Point(122, 205);
            this.lbl_Contra.Name = "lbl_Contra";
            this.lbl_Contra.Size = new System.Drawing.Size(76, 16);
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
            this.Name = "InicioSesion";
            this.Text = "InicioSesion";
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

