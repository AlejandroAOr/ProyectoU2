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
            
            

            // Los valores válidos para usuario y contraseña  
            string usuarioValido = "hola";
             
            name = Txt_NombreUser.Text;
            // Validación  
            bool usuarioCorrecto = Usuario == usuarioValido;
            

            if (usuarioCorrecto )
            {
                this.Hide(); // Ocultar la ventana de inicio de sesión  
                Form form = new Bienvenida(); // Cambiar a la ventana principal  
                form.ShowDialog();
            }
            else
            {
                if (!usuarioCorrecto )
                {
                    MessageBox.Show("Usuario incorrecto.");
                }
               

                // Limpiar campos y enfocar en el usuario  
                Txt_NombreUser.Clear();
                Txt_NombreUser.Focus();
                
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

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la ventana de inicio de sesión  
            Form form = new Registro(); // Cambiar a la ventana principal  
            form.ShowDialog();
        }

        private void lbl_Contra_Click(object sender, EventArgs e)
        {

        }

        private void Txt_ContraseñaUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_privacy3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_privacidad2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_privacidad1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_iniSes2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_iniSes1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_privacy4_Click(object sender, EventArgs e)
        {

        }

        private void pbi_apple_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la ventana de inicio de sesión  
            Form form = new Registro(); // Cambiar a la ventana principal  
            form.ShowDialog();
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            // Declarar y usar el ToolTip con el alias
            WinFormsToolTip toolTip1 = new WinFormsToolTip();
            toolTip1.SetToolTip(textBox1, "NO ACEPTA LETRAS");
        }
    }

}
