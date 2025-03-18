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
    public partial class Carnes_rojas : Form
    {
        public Carnes_rojas()
        {
            InitializeComponent();
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
