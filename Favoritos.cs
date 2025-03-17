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
    public partial class Favoritos : Form
    {
        public Favoritos()
        {
            InitializeComponent();
        }

        private void Favoritos_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la ventana de inicio de sesión  
            Form form = new mme(); // Cambiar a la ventana principal  
            form.ShowDialog();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la ventana de inicio de sesión  
            Form form = new Calendario(); // Cambiar a la ventana principal  
            form.ShowDialog();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la ventana de inicio de sesión  
            Form form = new MiPlan(); // Cambiar a la ventana principal  
            form.ShowDialog();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la ventana de inicio de sesión  
            Form form = new MenuSemanal(); // Cambiar a la ventana principal  
            form.ShowDialog();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la ventana de inicio de sesión  
            Form form = new Perfil(); // Cambiar a la ventana principal  
            form.ShowDialog();
        }

        private void btn_carnes_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la ventana de inicio de sesión  
            Form form = new carne(); // Cambiar a la ventana principal  
            form.ShowDialog();
        }
    }
}
