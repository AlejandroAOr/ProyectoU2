﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
// Usar un alias para la clase ToolTip
using WinFormsToolTip = System.Windows.Forms.ToolTip;
using VisualStylesToolTip = System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;


namespace Proyecto2
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();

        }

        private void Btn_iniciar_Click(object sender, EventArgs e)
        {
            String Usuario, contraseña,name;
            Usuario = Txt_NombreUser.Text;
            contraseña = Txt_ContraseñaUser.Text;
            

            // Los valores válidos para usuario y contraseña  
            string usuarioValido = "hola";
            string contrasenaValida = "1234"; // Cambia esto a la contraseña que desees  
            name = Txt_NombreUser.Text;
            // Validación  
            bool usuarioCorrecto = Usuario == usuarioValido;
            bool contrasenaCorrecta = contraseña == contrasenaValida;

            if (usuarioCorrecto && contrasenaCorrecta)
            {
                this.Hide(); // Ocultar la ventana de inicio de sesión  
                Form form = new inicio(); // Cambiar a la ventana principal  
                form.ShowDialog();
            }
            else
            {
                if (!usuarioCorrecto && !contrasenaCorrecta)
                {
                    MessageBox.Show("Usuario y contraseña incorrectos.");
                }
                else if (!usuarioCorrecto)
                {
                    MessageBox.Show("Usuario no válido.");
                }
                else if (!contrasenaCorrecta)
                {
                    MessageBox.Show("Contraseña incorrecta.");
                }

                // Limpiar campos y enfocar en el usuario  
                Txt_NombreUser.Clear();
                Txt_NombreUser.Focus();
                Txt_ContraseñaUser.Clear();
            }
        }

        private void Btn_CrearCuenta_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la ventana de inicio de sesión  
            Form form = new Registro(); // Cambiar a la ventana principal  
            form.ShowDialog();
        }

        private void Txt_NombreUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void lbl_logo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la ventana de inicio de sesión  
            Form form = new Registro(); // Cambiar a la ventana principal  
            form.ShowDialog();
        }

        private void Txt_ContraseñaUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txt_NombreUser_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Permitir solo letras (mayúsculas y minúsculas) y teclas de control (como retroceso)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txt_NombreUser_MouseEnter(object sender, EventArgs e)
        {
            // Declarar y usar el ToolTip con el alias
            WinFormsToolTip toolTip1 = new WinFormsToolTip();
            toolTip1.SetToolTip(Txt_NombreUser, "NO ACEPTA NUMEROS");

        }

        private void Txt_ContraseñaUser_MouseEnter(object sender, EventArgs e)
        {
            // Declarar y usar el ToolTip con el alias
            WinFormsToolTip toolTip1 = new WinFormsToolTip();
            toolTip1.SetToolTip(Txt_ContraseñaUser, "NO ACEPTA LETRAS");
        }
    }

}
