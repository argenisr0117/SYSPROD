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

namespace Interfaz.Consultas
{
    public partial class frmcProductosDpto : MetroForm
    {
        clsProducto P = new clsProducto();
        public frmcProductosDpto()
        {
            InitializeComponent();
        }
        private void LlenarGrid()
        {
            DataTable dt = new DataTable();
            dt = P.Listado_Productos_Dpto(Program.Valor3);
            try
            {
                dtgvProducto.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgvProducto.Rows.Add(dt.Rows[x][0]);
                    dtgvProducto.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgvProducto.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                }
                dtgvProducto.ClearSelection();
            }
            catch (Exception ex)
            {
               MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmcProductosDpto_Load(object sender, EventArgs e)
        {
            LlenarGrid();
            txtBuscar.Focus();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            LlenarGrid2(txtBuscar.Text.Trim());
        }

        private void LlenarGrid2(string texto)
        {
            DataTable dt = new DataTable();
            dt = P.BuscarD(true, texto,Program.Valor2);
            try
            {
                dtgvProducto.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgvProducto.Rows.Add(dt.Rows[x][0]);
                    dtgvProducto.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgvProducto.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                }
                dtgvProducto.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Program.CodigoP = dtgvProducto.CurrentRow.Cells[0].Value.ToString();
            Program.Evento = 1;
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("¿Desea Salir?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Dispose();
                Close();
            }
        }
    }
}
