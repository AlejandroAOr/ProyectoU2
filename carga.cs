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
    public partial class carga : Form
    {
        private int progreso;
        public carga()
        {
            InitializeComponent();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

       
            timer1 = new Timer();
            timer1.Interval = 500; // 5000 milisegundos = 5 segundos
            timer1.Tick += new EventHandler(AccionDespuesDe5Segundos);

            // Iniciar el timer
            timer1.Start();
        }
        private void AccionDespuesDe5Segundos(object sender, EventArgs e)

        {
            progreso += 10; // Aumenta el progreso
            progressBar1.Value = progreso;

            if (progreso >= 100)
            {
               

                this.Hide(); // Ocultar la ventana de inicio de sesión  
                Form form = new InicioSesion(); // Cambiar a la ventana principal  
                form.Show();
                timer1.Stop(); // Detener el timer
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void carga_Load(object sender, EventArgs e)
        {

        }
    }
}
