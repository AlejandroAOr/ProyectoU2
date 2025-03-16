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
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void btn_empezar_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la ventana de inicio de sesión  
            Form form = new inicio(); // Cambiar a la ventana principal  
            form.Show();
        }
    }
}
