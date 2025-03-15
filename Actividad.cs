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
    public partial class Actividad : Form
    {
        public Actividad()
        {
            InitializeComponent();
        }

        private void lbl_descripcion_Click(object sender, EventArgs e)
        {

        }

        private void Actividad_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Sede_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la ventana de inicio de sesión  
            Form form = new Objetivo(); // Cambiar a la ventana principal  
            form.ShowDialog();
        }

        private void Btn_Acti_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la ventana de inicio de sesión  
            Form form = new Objetivo(); // Cambiar a la ventana principal  
            form.ShowDialog();
        }

        private void Btn_MoActi_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la ventana de inicio de sesión  
            Form form = new Objetivo(); // Cambiar a la ventana principal  
            form.ShowDialog();
        }

        private void Btn_MActi_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la ventana de inicio de sesión  
            Form form = new Objetivo(); // Cambiar a la ventana principal  
            form.ShowDialog();
        }
    }
}
