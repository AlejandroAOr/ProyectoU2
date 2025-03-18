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
    public partial class MenuSemanal : Form
    {
        public MenuSemanal()
        {
            InitializeComponent();
        }

        private void btn_desayuno_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_snack_Click(object sender, EventArgs e)
        {

        }

        private void desayuno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void desayuno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;// Bloquea cualquier entrada de teclado
        }

        private void comida_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;// Bloquea cualquier entrada de teclado
        }

        private void cena_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;// Bloquea cualquier entrada de teclado
        }

        private void MenuSemanal_Load(object sender, EventArgs e)
        {

        }
    }
}
