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
        int inactivo = 0;
        private void Principal_Load(object sender, EventArgs e)
        {
            Permisos();
            ObtenerHora();
            timer1.Start();
            WindowState = FormWindowState.Maximized;
            panel5.Location = new Point(ClientSize.Width / 2 - panel5.Size.Width / 2, ClientSize.Height / 2 - panel5.ClientSize.Height / 2);
            label2.Location = new Point(ClientSize.Width / 2 - label2.Size.Width / 2, 18);
            MaximizeBox = false;

        }
        private void ObtenerHora()
        {
            lbfecha.Text = DateTime.Now.ToLongDateString();
            lbhora.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ObtenerHora();
            inactivo = inactivo + 1;
            if (inactivo > 1500)
            {
                Application.Exit();
            }
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
            btnOrden.Enabled = Program.ordenprod;
            btnPruebasCalidad.Enabled = Program.controlcald;
            btnVerPruebasCald.Enabled = Program.vcontrolcald;
            btnAlmacenIntermedios.Enabled = Program.almintermedios;
            btnAlmacenTerminados.Enabled = Program.almterminados;
            btnAlmacenLineaGalv.Enabled = Program.almlg;
            btnMonitoreomaq.Enabled = Program.monmaq;
            btnTemperatura.Enabled = Program.montemp;
            btnRegHoras.Enabled = Program.reghora;
            btnMaquinasParadas.Enabled = Program.maqpar;
            btnRecepcionAlambron.Enabled = Program.recpalm;
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
                if (form == "frmProduccionGalv")
                {
                    frmProduccionGalv obj = new frmProduccionGalv();
                    obj.Show();
                }
                if (form == "frmcOrdenProduccion")
                {
                    Consultas.frmcOrdenProduccion obj = new Consultas.frmcOrdenProduccion();
                    obj.Show();
                }
                if (form == "frmControlCalidad")
                {
                    frmControlCalidad obj = new frmControlCalidad();
                    obj.Show();
                }
                if (form == "frmcPruebasCalidad")
                {
                    Consultas.frmcPruebasCalidad obj = new Consultas.frmcPruebasCalidad();
                    obj.Show();
                }
                if (form == "frmControlAlm")
                {
                    frmControlAlm obj = new frmControlAlm();
                    obj.Show();
                }
                if (form == "MainForm")
                {
                    TempSys.MainForm obj = new TempSys.MainForm();
                    obj.Show();
                }
                if (form == "frmcMonitoreoMaquinas")
                {
                    Consultas.frmcMonitoreoMaquinas obj = new Consultas.frmcMonitoreoMaquinas();
                    obj.Show();
                }
                if (form == "frmMaquinasParadas")
                {
                    frmMaquinasParadas obj = new frmMaquinasParadas();
                    obj.Show();
                }
                if (form == "frmPonche")
                {
                    frmPonche obj = new frmPonche();
                    obj.Show();
                }
<<<<<<< HEAD
                if (form == "frmRecepcionAlambron")
                {
                    frmRecepcionAlambron obj = new frmRecepcionAlambron();
                    obj.Show();
                }
=======
>>>>>>> bf1dba918529b9e8fe8f30955f8e6ec0e9182058
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

        private void btnGalvanizado_Click(object sender, EventArgs e)
        {
            form = "frmProduccionGalv";
            AbrirForm(form);
        }

        private void Principal_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                MaximizeBox = true;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                MaximizeBox = false;
            }

        }

        private void btnOrden_Click(object sender, EventArgs e)
        {
            form = "frmcOrdenProduccion";
            AbrirForm(form);
        }

        private void btnPruebasCalidad_Click(object sender, EventArgs e)
        {
            form = "frmControlCalidad";
            AbrirForm(form);
        }

        private void btnVerPruebasCald_Click(object sender, EventArgs e)
        {
            form = "frmcPruebasCalidad";
            AbrirForm(form);
        }

        private void btnAlmacenIntermedios_Click(object sender, EventArgs e)
        {
            Program.Almacen = "INTERMEDIOS";
            form = "frmControlAlm";
            AbrirForm(form);
        }

        private void btnAlmacenTerminados_Click(object sender, EventArgs e)
        {
            Program.Almacen = "TERMINADOS";
            form = "frmControlAlm";
            AbrirForm(form);
        }

        private void btnAlmacenLineaGalv_Click(object sender, EventArgs e)
        {
            Program.Almacen = "LINEA GALV";
            form = "frmControlAlm";
            AbrirForm(form);
        }

        private void btnTemperatura_Click(object sender, EventArgs e)
        {
            form = "MainForm";
            AbrirForm(form);
        }

        private void btnMonitoreomaq_Click(object sender, EventArgs e)
        {
            form = "frmcMonitoreoMaquinas";
            AbrirForm(form);
        }

        private void btnMaquinasParadas_Click(object sender, EventArgs e)
        {
            form = "frmMaquinasParadas";
            AbrirForm(form);
        }

        private void btnRegHoras_Click(object sender, EventArgs e)
        {
            form = "frmPonche";
            AbrirForm(form);
        }

        private void Principal_MouseMove(object sender, MouseEventArgs e)
        {
            inactivo = 0;
        }
<<<<<<< HEAD

        private void btnRecepcionAlambron_Click(object sender, EventArgs e)
        {
            form = "frmRecepcionAlambron";
            AbrirForm(form);
        }
=======
>>>>>>> bf1dba918529b9e8fe8f30955f8e6ec0e9182058
    }
}
