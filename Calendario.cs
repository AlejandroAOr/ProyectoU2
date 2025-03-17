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
    public partial class Calendario : Form
    {
        public Calendario()
        {
            InitializeComponent();
        }

        private void Calendario_Load(object sender, EventArgs e)
        {
            
        }

        private void lbl_fechaselect_Click(object sender, EventArgs e)
        {

        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            //para marcar fechas seleccionadas por el usuario
            DateTime inicio = mc_calendario.SelectionStart;
            DateTime final = mc_calendario.SelectionEnd;

            //Colocamos en las etiquetas
            lbl_fechaselect.Text = inicio.ToString();
            
        }

        private void pb_editar_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la ventana de inicio de sesión  
            Form form = new MenuSemanal(); // Cambiar a la ventana principal  
            form.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la ventana de inicio de sesión  
            Form form = new MiPlan(); // Cambiar a la ventana principal  
            form.ShowDialog();
        }

        private void mc_calendario_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void pb_home_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la ventana de inicio de sesión  
            Form form = new mme(); // Cambiar a la ventana principal  
            form.ShowDialog();
        }

        private void pb_recetas_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la ventana de inicio de sesión  
            Form form = new MenuSemanal(); // Cambiar a la ventana principal  
            form.ShowDialog();
        }

        private void pb_perfil_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la ventana de inicio de sesión  
            Form form = new Perfil(); // Cambiar a la ventana principal  
            form.ShowDialog();
        }
    }
}
