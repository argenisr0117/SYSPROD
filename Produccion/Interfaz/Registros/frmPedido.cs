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
                R.IdPedido = 0;
                R.Valor = 1;
                R.Pedido = txtPedido.Text;
                R.EstadoP = chbEstado.Checked;
                msj = R.RegistrarActPedido();
                if (msj == "1")
                {
                    LlenarGrid();
                    txtPedido.Text = string.Empty;
                }
                else
                {
                    MessageBoxEx.Show("Ha ocurrido un error", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
