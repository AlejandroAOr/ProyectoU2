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

namespace Proyecto2
{
    public partial class Sobre_Ti : Form
    {
        public Sobre_Ti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void edadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_Continuar_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la ventana de inicio de sesión  
            Form form = new Actividad(); // Cambiar a la ventana principal  
            form.ShowDialog();
        }

        private void Edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;// Bloquea cualquier entrada de teclado
        }

        private void Genero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; 

        }

        private void Altura_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Altura_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Peso_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++) // Agrega de 1 kg a 100 kg
            {
                Peso.Items.Add(i + " kg");
            }

        }
    }
}
