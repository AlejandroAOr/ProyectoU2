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
    public partial class Contraseña : Form
    {
        public Contraseña()
        {
            InitializeComponent();
        }

        private void Txt_NombreUser_TextChanged(object sender, EventArgs e)
        {

        }
        private void Txt_ContraseñaUser_MouseEnter(object sender, EventArgs e)
        {
            // Declarar y usar el ToolTip con el alias
            WinFormsToolTip toolTip1 = new WinFormsToolTip();
            toolTip1.SetToolTip(Txt_ContraseñaUser, "NO ACEPTA LETRAS");
        }

        private void Btn_iniciar_Click(object sender, EventArgs e)
        {
            string contraseña;
            contraseña = Txt_ContraseñaUser.Text;

            //Los valores validos para contraseña
            string contrasenaValida = "1234"; // Cambia esto a la contraseña que desees

            //Validacion
            bool contrasenaCorrecta = contraseña == contrasenaValida;

            if ( contrasenaCorrecta)
            {
                this.Hide(); // Ocultar la ventana de inicio de sesión  
                Form form = new Home(); // Cambiar a la ventana principal  
                form.ShowDialog();
            }
            else
            {
                if ( !contrasenaCorrecta)
                {
                    MessageBox.Show("Contraseña incorrecta.");
                }
                

                // Limpiar campos y enfocar en el usuario 
                Txt_ContraseñaUser.Focus();
                Txt_ContraseñaUser.Clear();
            }
        }
    }
}
