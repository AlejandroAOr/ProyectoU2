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
    public partial class Objetivo : Form
    {
        public Objetivo()
        {
            InitializeComponent();
        }

        private void PesoA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_objetivo_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la ventana de inicio de sesión  
            Form form = new mme (); // Cambiar a la ventana principal  
            form.Show();
        }
    }
}
