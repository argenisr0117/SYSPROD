using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using Intermedia;
using System;
using System.Data;
using System.Windows.Forms;

namespace Interfaz.Registros
{
    public partial class frmPedido : MetroForm
    {
        public frmPedido()
        {
            InitializeComponent();
        }
        clsRecepAlambron R = new clsRecepAlambron();
        string msj = "";


        private void LlenarGrid()
        {

            DataTable dt = R.ListadoPedidos();
            dtgvPedidos.DataSource = null;
            dtgvPedidos.DataSource = dt;
            dtgvPedidos.ClearSelection();

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPedido.Text))
            {
                R.Pedido = txtPedido.Text;
                if (Program.Valor3 == 1)
                {

                    R.Valor = 2;
                    R.EstadoP = chbEstado.Checked;
                }
                else
                {
                    R.IdPedido = 0;
                    R.Valor = 1;
                    R.EstadoP = chbEstado.Checked;

                }
                msj = R.RegistrarActPedido();

                if (msj == "1")
                {
                    LlenarGrid();
                    MessageBoxEx.Show("Pedido guardado", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBoxEx.Show("Ha ocurrido un error. Ya existe este pedido", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                Program.Valor3 = 0;
                R.IdPedido = 0;
                txtPedido.Text = string.Empty;
                txtPedido.ReadOnly = false;


            }
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            LlenarGrid();
            lbinf.Visible = Program.VerLabel;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dtgvPedidos.SelectedRows.Count > 0)
            {

                txtPedido.ReadOnly = true;
                Program.Valor3 = 1;
                R.IdPedido = Convert.ToInt32(dtgvPedidos.CurrentRow.Cells[0].Value);
                txtPedido.Text = dtgvPedidos.CurrentRow.Cells[2].Value.ToString();
                chbEstado.Checked = Convert.ToBoolean(dtgvPedidos.CurrentRow.Cells[3].Value);

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgvPedidos.SelectedRows.Count > 0)
            {
                DialogResult var = MessageBoxEx.Show("¿Desea eliminar el pedido?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (var == DialogResult.Yes)
                {
                    R.IdPedido = Convert.ToInt32(dtgvPedidos.CurrentRow.Cells[0].Value);

                    msj = R.EliminarPedido();
                    if (msj == "1")
                    {
                        LlenarGrid();
                        txtPedido.Text = string.Empty;
                        MessageBoxEx.Show("Pedido eliminado", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBoxEx.Show("No puede eliminar un pedido que ya tenga recepciones hechas", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void dtgvPedidos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvPedidos.SelectedRows.Count > 0)
            {
                Program.IdPedido = Convert.ToInt32(dtgvPedidos.CurrentRow.Cells[0].Value);
                Program.Pedido = dtgvPedidos.CurrentRow.Cells[2].Value.ToString();
                Close();
            }
        }
    }
}
