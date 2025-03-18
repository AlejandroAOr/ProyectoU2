using System;
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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Btn_Registro_Click(object sender, EventArgs e)
        {
            String Usuario, email, contraseña;
            Usuario = Txt_NomUs.Text;
            email = Txt_EmailU.Text;
            contraseña = Txt_ConUs.Text;

            // Los valores válidos para usuario y contraseña  
            string usuarioValido = "Hola";
            string emailValido = "alex@gmail.com";
            string contrasenaValida = "1234"; // Cambia esto a la contraseña que desees  

            // Validación  
            bool usuarioCorrecto = Usuario == usuarioValido;
            bool emailCorrecto = email == emailValido;
            bool contrasenaCorrecta = contraseña == contrasenaValida;

            if (usuarioCorrecto && emailCorrecto && contrasenaCorrecta)
            {
                this.Hide(); // Ocultar la ventana de inicio de sesión  
                Form form = new InicioSesion(); // Cambiar a la ventana principal  
                form.ShowDialog();
            }
            else
            {
                if (!usuarioCorrecto && !emailCorrecto && !contrasenaCorrecta)
                {
                    MessageBox.Show("Usuario y contraseña incorrectos.");
                }
                else if (!usuarioCorrecto)
                {
                    MessageBox.Show("Usuario no válido.");
                }
                else if (!emailCorrecto)
                {
                    MessageBox.Show("Email incorrecto");
                }
                else if (!contrasenaCorrecta)
                {
                    MessageBox.Show("Contraseña incorrecta.");
                }

                // Limpiar campos y enfocar en el usuario  
                Txt_NomUs.Clear();
                Txt_EmailU.Clear();
                Txt_ConUs.Clear();
                Txt_NomUs.Focus();
            }

            }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void Txt_NomUs_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la ventana de inicio de sesión  
            Form form = new InicioSesion(); // Cambiar a la ventana principal  
            form.Show();

        }

        private void Txt_NomUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras (mayúsculas y minúsculas) y teclas de control (como retroceso)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txt_ConUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txt_EmailU_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_NomUs_MouseEnter(object sender, EventArgs e)
        {
            // Declarar y usar el ToolTip con el alias
            WinFormsToolTip toolTip1 = new WinFormsToolTip();
            toolTip1.SetToolTip(Txt_NomUs, "NO ACEPTA NUMEROS(4)");
        }

        private void Txt_ConUs_MouseEnter(object sender, EventArgs e)
        {
            WinFormsToolTip toolTip1 = new WinFormsToolTip();
            toolTip1.SetToolTip(Txt_ConUs, "NO ACEPTA LETRAS(4)");
        }
    }
}
