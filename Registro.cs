using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string usuarioValido = "luis";
            string emailValido = "luis@gmail.com";
            string contrasenaValida = "1234"; // Cambia esto a la contraseña que desees  

            // Validación  
            bool usuarioCorrecto = Usuario == usuarioValido;
            bool emailCorrecto = email == emailValido;
            bool contrasenaCorrecta = contraseña == contrasenaValida;

            if (usuarioCorrecto && emailCorrecto && contrasenaCorrecta)
            {
                MessageBox.Show("se creo la cuenta con exito", "⚠️", MessageBoxButtons.OK, MessageBoxIcon.Warning);


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

        private void pb_logo_Click(object sender, EventArgs e)
        {

        }
    }
}
