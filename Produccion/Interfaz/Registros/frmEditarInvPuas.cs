using System;
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

namespace Interfaz.Registros
{
    public partial class frmEditarInvPuas : MetroForm
    {
        clsProduccionIndM Pi = new clsProduccionIndM();
        public frmEditarInvPuas()
        {
            InitializeComponent();
        }

        private void LlenarGrid()
        {
           
            DataTable dt = new DataTable();
            dt = Pi.ObtenerInvPuas();
            try
            {
                dtgvInvPuas.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgvInvPuas.Rows.Add(dt.Rows[x][0]);
                    dtgvInvPuas.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgvInvPuas.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgvInvPuas.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                    dtgvInvPuas.Rows[x].Cells[3].Value = dt.Rows[x][3].ToString();
                }
                dtgvInvPuas.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmEditarInvPuas_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dtgvInvPuas.SelectedRows.Count > 0)
            {
                Program.Producto = dtgvInvPuas.CurrentRow.Cells[2].Value.ToString();
                Program.Maquina = dtgvInvPuas.CurrentRow.Cells[3].Value.ToString();
                Program.Empleado= dtgvInvPuas.CurrentRow.Cells[0].Value.ToString();
                Program.Cantidad = Convert.ToInt32(dtgvInvPuas.CurrentRow.Cells[1].Value);
                frmEditarInvPuas1 obj = new frmEditarInvPuas1();
                obj.ShowDialog();
                if(Program.Evento==10)
                {
                    LlenarGrid();
                }
            }
            else
            {
                MessageBoxEx.Show("Seleccione un registro!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Program.Evento = 0;
        }
    }
}
