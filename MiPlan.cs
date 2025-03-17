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
    public partial class MiPlan : Form
    {
        public MiPlan()
        {
            InitializeComponent();
            

        }
        public void SetValorA(int valor)
        {
            
            lbl_consu.Text = "Calorías: " + valor;
            
        }

        private void pictureBox_tablas_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la ventana de inicio de sesión  
            Form form = new mme(); // Cambiar a la ventana principal  
            form.Show();
        }

        private void MiPlan_Load(object sender, EventArgs e)
        {

        }
    }
}
