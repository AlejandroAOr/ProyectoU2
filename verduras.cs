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
    public partial class verduras : Form
    {
        public verduras()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btn_aplicar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MiPlan form = new MiPlan();
            // Pasar el valor al método público
            form.Show();
        }
    }
}
