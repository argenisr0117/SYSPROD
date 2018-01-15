﻿using System;
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
            this.WindowState = FormWindowState.Maximized;
            panel5.Location = new Point(this.ClientSize.Width / 2 - panel5.Size.Width / 2, this.ClientSize.Height / 2 - panel5.ClientSize.Height / 2);
            label2.Location = new Point(this.ClientSize.Width / 2 - label2.Size.Width / 2, 18);
            this.MaximizeBox = false;

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
            btnOrden.Enabled = Program.ordenprod;
            btnPruebasCalidad.Enabled = Program.controlcald;
            btnVerPruebasCald.Enabled = Program.vcontrolcald;
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
                this.MaximizeBox = true;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                this.MaximizeBox = false;
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
    }
}
