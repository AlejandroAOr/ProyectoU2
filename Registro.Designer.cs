namespace Proyecto2
{
    partial class Registro
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
            this.Txt_EmailU = new System.Windows.Forms.TextBox();
            this.Txt_ConUs = new System.Windows.Forms.TextBox();
            this.Txt_NomUs = new System.Windows.Forms.TextBox();
            this.Btn_Registro = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_ContR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_EmailU
            // 
            this.Txt_EmailU.Location = new System.Drawing.Point(121, 198);
            this.Txt_EmailU.Name = "Txt_EmailU";
            this.Txt_EmailU.Size = new System.Drawing.Size(100, 22);
            this.Txt_EmailU.TabIndex = 0;
            // 
            // Txt_ConUs
            // 
            this.Txt_ConUs.Location = new System.Drawing.Point(121, 281);
            this.Txt_ConUs.Name = "Txt_ConUs";
            this.Txt_ConUs.Size = new System.Drawing.Size(100, 22);
            this.Txt_ConUs.TabIndex = 1;
            // 
            // Txt_NomUs
            // 
            this.Txt_NomUs.Location = new System.Drawing.Point(121, 114);
            this.Txt_NomUs.Name = "Txt_NomUs";
            this.Txt_NomUs.Size = new System.Drawing.Size(100, 22);
            this.Txt_NomUs.TabIndex = 2;
            // 
            // Btn_Registro
            // 
            this.Btn_Registro.Location = new System.Drawing.Point(137, 343);
            this.Btn_Registro.Name = "Btn_Registro";
            this.Btn_Registro.Size = new System.Drawing.Size(75, 32);
            this.Btn_Registro.TabIndex = 3;
            this.Btn_Registro.Text = "Registrar";
            this.Btn_Registro.UseVisualStyleBackColor = true;
            this.Btn_Registro.Click += new System.EventHandler(this.Btn_Registro_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(142, 95);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(54, 16);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "Usuario";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(149, 179);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(41, 16);
            this.lbl_email.TabIndex = 5;
            this.lbl_email.Text = "Email";
            // 
            // lbl_ContR
            // 
            this.lbl_ContR.AutoSize = true;
            this.lbl_ContR.Location = new System.Drawing.Point(136, 262);
            this.lbl_ContR.Name = "lbl_ContR";
            this.lbl_ContR.Size = new System.Drawing.Size(76, 16);
            this.lbl_ContR.TabIndex = 6;
            this.lbl_ContR.Text = "Contraseña";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 471);
            this.Controls.Add(this.lbl_ContR);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.Btn_Registro);
            this.Controls.Add(this.Txt_NomUs);
            this.Controls.Add(this.Txt_ConUs);
            this.Controls.Add(this.Txt_EmailU);
            this.Name = "Registro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_EmailU;
        private System.Windows.Forms.TextBox Txt_ConUs;
        private System.Windows.Forms.TextBox Txt_NomUs;
        private System.Windows.Forms.Button Btn_Registro;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_ContR;
    }
}