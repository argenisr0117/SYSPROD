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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        PictureBox[] fotos;
        int contador = 0;
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            fotos = new PictureBox[5] {circulo1, circulo2, circulo3, circulo4, circulo5};
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (contador < 5)
            {

                fotos[contador].BackgroundImage = Properties.Resources.Bollino_rosso_converted;
                contador++;
                label1.Text = "Cargando al " + (contador * 20) + " %";
            }
            else
            {
                timer1.Stop();
                timer1.Dispose();
                this.Close();
            }
        }

        private void SplashScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Principal obj = new Principal();
            obj.Show();
        }
    }
}
