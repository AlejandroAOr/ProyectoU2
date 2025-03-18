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
   
    public partial class Pollo : Form
    {
        int contador1 = 0;
        int contador2 = 0;
        int contador3 = 0;
        int contador4 = 0;
        int sumaTotal = 0;
        public Pollo()
        {
            InitializeComponent();
            lbl_n1.Text = "Fajitas con pimiento :";
            lbl_n2.Text = "Pollo en salsa de teriyaki :";
            lbl_n3.Text = "Pechuga de pollo :";
            lbl_n4.Text = "Ensalada de pollo :";
            lbl_sumac.Text = "Suma Total: 0";

            // Asignar el mismo evento a los cuatro PictureBox
            pictureBox5.Click += new EventHandler(PictureBox_Click);
            pictureBox6.Click += new EventHandler(PictureBox_Click);
            pictureBox7.Click += new EventHandler(PictureBox_Click);
            pictureBox8.Click += new EventHandler(PictureBox_Click);
        }

        private void Pollo_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            int valor = 0;

            if (pictureBox == pictureBox5)
            {
                contador1++;
                valor = 500;
                lbl_n1.Text = "Fajitas con pimiento: " + contador1;
            }
            else if (pictureBox == pictureBox6)
            {
                contador2++;
                valor = 400;
                lbl_n2.Text = "Pollo en salsa teriyaki : " + contador2;
            }
            else if (pictureBox == pictureBox7)
            {
                contador3++;
                valor = 350;
                lbl_n3.Text = "Pechuga al horno : " + contador3;
            }
            else if (pictureBox == pictureBox8)
            {
                contador4++;
                valor = 280;
                lbl_n4.Text = "Ensalada de pollo : " + contador4;
            }


            sumaTotal += valor;
            lbl_sumat.Text = "Suma Total: " + sumaTotal;


        }

        private void btn_aplicar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MiPlan form = new MiPlan();
            form.SetValorA(sumaTotal);  // Pasar el valor al método público
            form.Show();
        }
    }
}
