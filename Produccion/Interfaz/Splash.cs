using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        PictureBox[] pict;
        int contador = 0;

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            pict = new PictureBox[5] { circulo1, circulo2, circulo3, circulo4, circulo5 };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (contador < 5)
            {
                pict[contador].BackgroundImage = Properties.Resources.Bollino_rosso_converted;
                contador++;
                label1.Text = "Cargando al " + (contador * 10) + " %";
            }
            else
            {
                timer1.Enabled = false;
                Principal obj = new Principal();
                this.Hide();
                obj.ShowDialog();
                this.Close();

            }
        }

        private void Splash_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }
    }
}
