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

namespace Interfaz.Registros
{
    public partial class frmMaquinaPuas : MetroForm
    {
        clsMaquina M = new clsMaquina();
        clsProducto P = new clsProducto();
        public frmMaquinaPuas()
        {
            InitializeComponent();
        }
        private void ComboP2()
        {
            try
            {
                cmbProducto.DataSource = P.Listado_Productos_Dpto(4);
                cmbProducto.DisplayMember = "DESCRIPCION";
                cmbProducto.ValueMember = "CODIGO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void ComboM()
        {
            try
            {
                cmbMaquina.DataSource = M.Listado_Maquinas_IndMenor();
                cmbMaquina.DisplayMember = "DESCRIPCION";
                cmbMaquina.ValueMember = "ID_MAQUINA";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void frmMaquinaPuas_Load(object sender, EventArgs e)
        {
            ComboM();
            ComboP2();
            LlenarGrid();
        }

        private void LlenarGrid()
        {
            dtgvProductoMaq.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7);
            dtgvProductoMaq.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7);
            DataTable dt = new DataTable();
            dt = M.ListadoProductoMaquina();
            try
            {
                dtgvProductoMaq.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgvProductoMaq.Rows.Add(dt.Rows[x][0]);
                    dtgvProductoMaq.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgvProductoMaq.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgvProductoMaq.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                    dtgvProductoMaq.Rows[x].Cells[3].Value = dt.Rows[x][3].ToString();
                }
                dtgvProductoMaq.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            try
            {
                M.Idmaquina = cmbMaquina.SelectedValue.ToString();
                M.Idproducto = cmbProducto.SelectedValue.ToString();
                mensaje = M.RegistrarProductoMaquina();
                if(mensaje=="1")
                {
                    MessageBoxEx.Show("Máquina ya se ha asignado!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(mensaje=="0")
                {
                    MessageBoxEx.Show("Registrado con éxito!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LlenarGrid();
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgvProductoMaq.SelectedRows.Count > 0)
            {
                DialogResult var = MessageBoxEx.Show("¿Desea eliminar el registro?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (var == DialogResult.Yes)
                {
                    //dtgvproduccion.Rows.RemoveAt(dtgvproduccion.CurrentRow.Index);
                    M.Idproducto= (dtgvProductoMaq.CurrentRow.Cells[2].Value).ToString();
                    M.Idmaquina = (dtgvProductoMaq.CurrentRow.Cells[3].Value).ToString();
                    M.EliminarProductoMaquina();
                    MessageBoxEx.Show("Registro eliminado!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarGrid();
                }
            }
            else
            {
                MessageBoxEx.Show("Seleccione un registro!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
