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
    public partial class mme : Form
    {
        public mme()
        {
            InitializeComponent();
        }

        private void mme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            //ToolTip toolTip = new ToolTip();
            //toolTip.SetToolTip(button1, "Haz clic para obtener más información");
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la ventana de inicio de sesión  
            Form form = new Favoritos(); // Cambiar a la ventana principal  
            form.ShowDialog();
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(pictureBox7, "Inico");
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la ventana de inicio de sesión  
            Form form = new MiPlan(); // Cambiar a la ventana principal  
            form.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la ventana de inicio de sesión  
            Form form = new carne(); // Cambiar a la ventana principal  
            form.Show();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la ventana de inicio de sesión  
            Form form = new MiPlan(); // Cambiar a la ventana principal  
            form.Show();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la ventana de inicio de sesión  
            Form form = new Calendario(); // Cambiar a la ventana principal  
            form.ShowDialog();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la ventana de inicio de sesión  
            Form form = new Calendario(); // Cambiar a la ventana principal  
            form.ShowDialog();
        }

        private void img_6_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la ventana de inicio de sesión  
            Form form = new Pollo(); // Cambiar a la ventana principal  
            form.ShowDialog();
        }
    }
}
