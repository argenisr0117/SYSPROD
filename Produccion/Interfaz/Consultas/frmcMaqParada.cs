﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Intermedia;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar;

namespace Interfaz.Consultas
{
    public partial class frmcMaqParada : MetroForm
    {
        public frmcMaqParada()
        {
            InitializeComponent();
        }
        clsMaquina M = new clsMaquina();
        clsDepartamento D = new clsDepartamento();
        clsMonitoreoMaq Mo = new clsMonitoreoMaq();
        private void ComboM()
        {
            try
            {
                cmbMaquina.DataSource = M.Listar(true);
                cmbMaquina.DisplayMember = "DESCRIPCION";
                cmbMaquina.ValueMember = "ID_MAQUINA";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void ComboDpto()
        {
            try
            {
                cmbDpto.DataSource = D.Listar2(true);
                cmbDpto.DisplayMember = "DEPARTAMENTO";
                cmbDpto.ValueMember = "ID_DPTO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void ComboMotivo()
        {
            try
            {
                cmbMotivo.DataSource = Mo.ListadoMotivos();
                cmbMotivo.DisplayMember = "DESCRIPCION";
                cmbMotivo.ValueMember = "ID_MOTIVO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void frmcMaqParada_Load(object sender, EventArgs e)
        {
            ComboM();
            ComboDpto();
            ComboMotivo();
            Limpiar();
            rbDpto.Checked = true;
        }

        private void Limpiar()
        {
            cmbDpto.SelectedValue = "";
            cmbMaquina.SelectedValue = "";
            cmbMotivo.SelectedIndex = -1;
        }

        private void rbMaquina_CheckedChanged(object sender, EventArgs e)
        {
            cmbMaquina.Enabled = true;
            cmbMotivo.Enabled = false;
            cmbDpto.Enabled = false;
            cmbMaquina.SelectedIndex = 0;
        }

        private void rbDpto_CheckedChanged(object sender, EventArgs e)
        {
            cmbMotivo.Enabled = false;
            cmbDpto.Enabled = true;
            cmbMaquina.Enabled = false;
            cmbDpto.SelectedIndex = 0;
        }

        private void rbMotivo_CheckedChanged(object sender, EventArgs e)
        {
            cmbMotivo.Enabled = true;
            cmbDpto.Enabled = false;
            cmbMaquina.Enabled = false;
            Limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            rbMaquina.Checked = true;
            rbMaquina_CheckedChanged(e, e);
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpDesde.Value.Date <= dtpHasta.Value.Date)
                {
                    frmReporte obj = new frmReporte();
                    obj.Fechai = dtpDesde.Value;
                    obj.Fechaf = dtpHasta.Value;
                    if (rbMaquina.Checked)
                    {
                        obj.Maquina = cmbMaquina.SelectedValue.ToString();
                        obj.Valor_ = 0;
                        obj.Titulo = "GRÁFICO RESUMEN HORAS DE MOTIVOS DE PARADAS - MÁQUINA: " + cmbMaquina.Text;
                        obj.Titulo1 = "GRÁFICO FRECUENCIA DE MOTIVOS DE PARADAS - MÁQUINA: " + cmbMaquina.Text;
                    }
                    else
                    {
                        obj.Maquina = "0";
                    }
                    if (rbDpto.Checked)
                    {
                        obj.Dpto = cmbDpto.SelectedValue.ToString();
                        obj.Valor_ = 1;
                        obj.Titulo = "GRÁFICO RESUMEN HORAS DE PARADAS DE MÁQUINAS - DEPARTAMENTO: " + cmbDpto.Text;
                        obj.Titulo1 = "GRÁFICO FRECUENCIA DE PARADAS DE MÁQUINAS - DEPARTAMENTO: " + cmbDpto.Text;

                    }
                    else
                    {
                        obj.Dpto = "0";
                    }
                    if (rbMotivo.Checked)
                    {
                        obj.idMotivo = Convert.ToInt16(cmbMotivo.SelectedValue);
                        obj.Valor_ = 3;
                        obj.Titulo = "GRÁFICO RESUMEN HORAS PARADAS POR: " + cmbMotivo.Text;
                        obj.Titulo1 = "GRÁFICO FRECUENCIA DE PARADAS DE MÁQUINAS POR: " + cmbMotivo.Text;
                    }
                    else
                    {
                        obj.idMotivo = 0;
                    }
                    if(rbMotivo.Checked && cmbMotivo.SelectedIndex < 0)
                    {
                        obj.idMotivo = 0;
                        obj.Valor_ = 2;
                        obj.Titulo = "GRÁFICO RESUMEN HORAS PARADAS MOTIVOS";
                        obj.Titulo1 = "GRÁFICO FRECUENCIA DE PARADAS POR MOTIVOS" ;
                    }
                    obj.Nombre = "graficos_maq_parada_dpto.rdlc";
                    obj.Valor = 22;
                    obj.Show();
                }
                else
                {

                }
            }
            catch( Exception ex)
            {

            }
            
        }
    }
}
