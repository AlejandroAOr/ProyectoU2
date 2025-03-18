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
            this.Txt_NomUs = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_EmailU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_ConUs = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Registro = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_NomUs
            // 
            this.Txt_NomUs.BackColor = System.Drawing.Color.White;
            this.Txt_NomUs.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomUs.Location = new System.Drawing.Point(45, 269);
            this.Txt_NomUs.Multiline = true;
            this.Txt_NomUs.Name = "Txt_NomUs";
            this.Txt_NomUs.Size = new System.Drawing.Size(438, 33);
            this.Txt_NomUs.TabIndex = 2;
            this.Txt_NomUs.TextChanged += new System.EventHandler(this.Txt_NomUs_TextChanged);
            this.Txt_NomUs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_NomUs_KeyPress);
            this.Txt_NomUs.MouseEnter += new System.EventHandler(this.Txt_NomUs_MouseEnter);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(40, 182);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(186, 30);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "Crear una cuenta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Direccion de correo electronico";
            // 
            // Txt_EmailU
            // 
            this.Txt_EmailU.BackColor = System.Drawing.Color.White;
            this.Txt_EmailU.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_EmailU.Location = new System.Drawing.Point(45, 348);
            this.Txt_EmailU.Multiline = true;
            this.Txt_EmailU.Name = "Txt_EmailU";
            this.Txt_EmailU.Size = new System.Drawing.Size(438, 33);
            this.Txt_EmailU.TabIndex = 10;
            this.Txt_EmailU.TextChanged += new System.EventHandler(this.Txt_EmailU_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Contraseña";
            // 
            // Txt_ConUs
            // 
            this.Txt_ConUs.BackColor = System.Drawing.Color.White;
            this.Txt_ConUs.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ConUs.Location = new System.Drawing.Point(45, 420);
            this.Txt_ConUs.Multiline = true;
            this.Txt_ConUs.Name = "Txt_ConUs";
            this.Txt_ConUs.Size = new System.Drawing.Size(438, 33);
            this.Txt_ConUs.TabIndex = 12;
            this.Txt_ConUs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_ConUs_KeyPress);
            this.Txt_ConUs.MouseEnter += new System.EventHandler(this.Txt_ConUs_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto2.Properties.Resources.IMG_6673;
            this.pictureBox1.Location = new System.Drawing.Point(45, -50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(438, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Registro
            // 
            this.Btn_Registro.BackColor = System.Drawing.Color.Black;
            this.Btn_Registro.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Registro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Registro.Location = new System.Drawing.Point(144, 483);
            this.Btn_Registro.Name = "Btn_Registro";
            this.Btn_Registro.Size = new System.Drawing.Size(233, 52);
            this.Btn_Registro.TabIndex = 3;
            this.Btn_Registro.Text = "Para registrar";
            this.Btn_Registro.UseVisualStyleBackColor = false;
            this.Btn_Registro.Click += new System.EventHandler(this.Btn_Registro_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 608);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "¿Ya tienes una cuenta?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DodgerBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 608);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Click aqui";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(518, 673);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_ConUs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_EmailU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.Btn_Registro);
            this.Controls.Add(this.Txt_NomUs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_NomUs;
        private System.Windows.Forms.Button Btn_Registro;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_EmailU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_ConUs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}