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
using DevComponents.DotNetBar;
using Intermedia;

namespace Interfaz.Consultas
{
    public partial class frmcProducto : MetroForm
    {
        clsProducto P = new clsProducto();
        public frmcProducto()
        {
            InitializeComponent();
        }
        private void LlenarGrid()
        {
            bool valor = true;
            if (cbestado.SelectedIndex == 0)
            {
                valor = true;
            }
            else if (cbestado.SelectedIndex == 1)
            {
                valor = false;
            }
            DataTable dt = new DataTable();
            dt = P.Consulta(valor);
            try
            {
                dtgvProducto.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgvProducto.Rows.Add(dt.Rows[x][0]);
                    dtgvProducto.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgvProducto.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgvProducto.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                    dtgvProducto.Rows[x].Cells[3].Value = dt.Rows[x][3].ToString();
                    dtgvProducto.Rows[x].Cells[4].Value = dt.Rows[x][4].ToString();
                }
                dtgvProducto.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LlenarGrid2(string texto)
        {
            bool valor = true;
            if (cbestado.SelectedIndex == 0)
            {
                valor = true;
            }
            else if (cbestado.SelectedIndex == 1)
            {
                valor = false;
            }
            DataTable dt = new DataTable();
            if(rbCodigo.Checked)
            {
                dt = P.BuscarC(valor, texto);
            }
            else if(rbDescripcion.Checked)
            {
                dt = P.BuscarD(valor, texto,0);
            }
           
            try
            {
                dtgvProducto.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgvProducto.Rows.Add(dt.Rows[x][0]);
                    dtgvProducto.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgvProducto.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgvProducto.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                    dtgvProducto.Rows[x].Cells[3].Value = dt.Rows[x][3].ToString();
                    dtgvProducto.Rows[x].Cells[4].Value = dt.Rows[x][4].ToString();
                }
                dtgvProducto.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmcProducto_Load(object sender, EventArgs e)
        {
            txtbuscar.Focus();
            cbestado.SelectedIndex = 0;
            rbCodigo.Checked = true;
            LlenarGrid();
        }

        private void cbestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            LlenarGrid2(txtbuscar.Text);
        }

        private void dtgvProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.CodigoP = dtgvProducto.CurrentRow.Cells[0].Value.ToString();
            Program.DescripcionP = dtgvProducto.CurrentRow.Cells[1].Value.ToString();
            Program.UnidadP = dtgvProducto.CurrentRow.Cells[2].Value.ToString();
            Program.CalibreP = Convert.ToDouble(dtgvProducto.CurrentRow.Cells[3].Value);
            Program.CategoriaP = dtgvProducto.CurrentRow.Cells[4].Value.ToString();
            Program.Evento = 1;
            this.Close();
        }

        private void rbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            LlenarGrid2(txtbuscar.Text);
            txtbuscar.Focus();
        }

        private void rbDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            LlenarGrid2(txtbuscar.Text);
            txtbuscar.Focus();
        }
    }
}
