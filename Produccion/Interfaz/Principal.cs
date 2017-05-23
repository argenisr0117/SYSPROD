using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Interfaz.Registros;

namespace Interfaz
{
    public partial class Principal : MetroForm
    {
        public Principal()
        {
            InitializeComponent();
        }
        string form;
        private void Principal_Load(object sender, EventArgs e)
        {
            Permisos();
            ObtenerHora();
            timer1.Start();
           
        }
        private void ObtenerHora()
        {
            lbfecha.Text = DateTime.Now.ToLongDateString();
            lbhora.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ObtenerHora();
        }

        private void btnregistros_Click(object sender, EventArgs e)
        {
            form = "RegistrosGenerales";
            AbrirForm(form);
            //RegistrosGenerales obj = new RegistrosGenerales();
            //obj.Show();
        }

        private void Permisos()
        {
            btnconsultas.Enabled = Program.congen;
            btnGalvanizado.Enabled = Program.prodgalv;
            btnproduccion.Enabled = Program.proddiaria;
            btnregistros.Enabled = Program.reggen;
            btnTrefilado.Enabled = Program.prodtref;
            btnIndustriaMenor.Enabled = Program.prodindm;
        }
        private void AbrirForm(string form)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => 
            pre.Name == form).SingleOrDefault<Form>();

            if (existe != null)
            {
                existe.WindowState = FormWindowState.Normal;
                existe.BringToFront();
            }
            else
            {
               if(form=="RegistrosGenerales")
                {
                    RegistrosGenerales obj = new RegistrosGenerales();
                    obj.Show();
                }
                if (form == "frmProduccion")
                {
                    frmProduccion obj = new frmProduccion();
                    obj.Show();
                }
                if (form == "ConsultasGenerales")
                {
                    ConsultasGenerales obj = new ConsultasGenerales();
                    obj.Show();
                }
                if (form == "frmProduccionTrefilado")
                {
                    frmProduccionTrefilado obj = new frmProduccionTrefilado();
                    obj.Show();
                }
                if (form == "frmProduccionIndMenor")
                {
                    frmProduccionIndMenor obj = new frmProduccionIndMenor();
                    obj.Show();
                }
            }
        }

        private void btnproduccion_Click(object sender, EventArgs e)
        {
            form = "frmProduccion";
            AbrirForm(form);
        }

        private void btnconsultas_Click(object sender, EventArgs e)
        {
            form = "ConsultasGenerales";
            AbrirForm(form);
        }

        private void btnTrefilado_Click(object sender, EventArgs e)
        {
            form = "frmProduccionTrefilado";
            AbrirForm(form);
        }

        private void btnIndustriaMenor_Click(object sender, EventArgs e)
        {
            form = "frmProduccionIndMenor";
            AbrirForm(form);
        }
    }
}
