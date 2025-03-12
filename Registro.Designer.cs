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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
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
            this.Txt_EmailU.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_EmailU.Location = new System.Drawing.Point(205, 370);
            this.Txt_EmailU.Name = "Txt_EmailU";
            this.Txt_EmailU.Size = new System.Drawing.Size(100, 38);
            this.Txt_EmailU.TabIndex = 0;
            // 
            // Txt_ConUs
            // 
            this.Txt_ConUs.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ConUs.Location = new System.Drawing.Point(205, 467);
            this.Txt_ConUs.Name = "Txt_ConUs";
            this.Txt_ConUs.Size = new System.Drawing.Size(100, 38);
            this.Txt_ConUs.TabIndex = 1;
            // 
            // Txt_NomUs
            // 
            this.Txt_NomUs.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomUs.Location = new System.Drawing.Point(205, 264);
            this.Txt_NomUs.Name = "Txt_NomUs";
            this.Txt_NomUs.Size = new System.Drawing.Size(100, 38);
            this.Txt_NomUs.TabIndex = 2;
            // 
            // Btn_Registro
            // 
            this.Btn_Registro.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Registro.Location = new System.Drawing.Point(175, 557);
            this.Btn_Registro.Name = "Btn_Registro";
            this.Btn_Registro.Size = new System.Drawing.Size(162, 52);
            this.Btn_Registro.TabIndex = 3;
            this.Btn_Registro.Text = "Registrar";
            this.Btn_Registro.UseVisualStyleBackColor = true;
            this.Btn_Registro.Click += new System.EventHandler(this.Btn_Registro_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(207, 209);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(98, 30);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "Usuario";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(223, 322);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(73, 30);
            this.lbl_email.TabIndex = 5;
            this.lbl_email.Text = "Email";
            // 
            // lbl_ContR
            // 
            this.lbl_ContR.AutoSize = true;
            this.lbl_ContR.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ContR.Location = new System.Drawing.Point(188, 434);
            this.lbl_ContR.Name = "lbl_ContR";
            this.lbl_ContR.Size = new System.Drawing.Size(139, 30);
            this.lbl_ContR.TabIndex = 6;
            this.lbl_ContR.Text = "Contraseña";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 621);
            this.Controls.Add(this.lbl_ContR);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.Btn_Registro);
            this.Controls.Add(this.Txt_NomUs);
            this.Controls.Add(this.Txt_ConUs);
            this.Controls.Add(this.Txt_EmailU);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
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