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
using DevComponents.DotNetBar;
using Intermedia;

namespace Interfaz.Consultas
{
    public partial class frmcOrdenProduccion : MetroForm
    {
        clsOrdenProduccion O = new clsOrdenProduccion();
        public frmcOrdenProduccion()
        {
            InitializeComponent();
        }
        private void LlenarGrid()
        {
            try
            {
                DataTable dt = new DataTable();
                if (cmbEstado.SelectedIndex == 0)
                {
                    dt = O.ListadoOrdenes(false);
                }
                else
                {
                    dt = O.ListadoOrdenes(true);
                }
                dtgOrdenes.DataSource = null;
                dtgOrdenes.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void frmcOrdenProduccion_Load(object sender, EventArgs e)
        {
            cmbEstado.SelectedIndex = 1;
            LlenarGrid();
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registros.frmOrdenProduccion obj = new Registros.frmOrdenProduccion();
            obj.ShowDialog();
            LlenarGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgOrdenes.SelectedRows.Count > 0)
                {
                    Program.Orden = dtgOrdenes.CurrentRow.Cells[1].Value.ToString();
                    Program.Producto = dtgOrdenes.CurrentRow.Cells[2].Value.ToString();
                    Program.Cliente1 = dtgOrdenes.CurrentRow.Cells[3].Value.ToString();
                    Program.Dpto = dtgOrdenes.CurrentRow.Cells[6].Value.ToString();
                    Program.Cantidad = Convert.ToInt16(dtgOrdenes.CurrentRow.Cells[4].Value);
                    Program.Valor = 5;
                    Registros.frmOrdenProduccion obj = new Registros.frmOrdenProduccion();
                    obj.ShowDialog();
                    LlenarGrid();
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("¿Desea Salir?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
            }
        }
    }

   
}