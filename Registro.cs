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
