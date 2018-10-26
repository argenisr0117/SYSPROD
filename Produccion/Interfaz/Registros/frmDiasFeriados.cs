using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using Intermedia;

namespace Interfaz.Registros
{
    public partial class frmDiasFeriados : MetroForm
    {
        public frmDiasFeriados()
        {
            InitializeComponent();
            LlenarGrid();
        }
        clsTurno T = new clsTurno();

        private void LlenarGrid()
        {
            DataTable dt = new DataTable();
            dt = T.ObtDiasFeriados();
            dtgvDiasFeriados.DataSource = null;
            dtgvDiasFeriados.DataSource = dt;
            dtgvDiasFeriados.Columns[0].Visible = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string msj = "";
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                T.Nombre = txtNombre.Text;
                T.Fecha = dtpFecha.Value;
                msj = T.RegistrarDiasFeriados();
                if (msj == "1")
                {
                    MessageBoxEx.Show("Registro guardado", "SysProd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarGrid();
                    txtNombre.Text = string.Empty;
                }
                else
                {
                    MessageBoxEx.Show("ERROR..\n Ya existe este día.", "SysProd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgvDiasFeriados.SelectedRows.Count > 0)
            {
                DialogResult var = MessageBoxEx.Show("¿Desea eliminar el registro?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (var == DialogResult.Yes)
                {
                    string msj = "";
                    T.Id = Convert.ToInt16(dtgvDiasFeriados.CurrentRow.Cells[0].Value);
                    msj = T.EliminarDiasFeriados();
                    T.Id = 0;
                    if (msj == "1")
                    {
                        MessageBoxEx.Show("Registro eliminado", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LlenarGrid();
                    }
                    else
                    {
                        MessageBoxEx.Show("Ha ocurrido un error.", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dtgvDiasFeriados_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtgvDiasFeriados.ClearSelection();
        }
    }
}
