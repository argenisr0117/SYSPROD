using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using Intermedia;
using System;
using System.Data;
using System.Windows.Forms;

namespace Interfaz.Registros
{
    public partial class frmChofer : MetroForm
    {
        public frmChofer()
        {
            InitializeComponent();
        }
        clsRecepAlambron R = new clsRecepAlambron();
        string msj = "";


        private void LlenarGrid()
        {

            DataTable dt = R.ListadoChofer();
            dtgvChofer.DataSource = null;
            dtgvChofer.DataSource = dt;
            dtgvChofer.ClearSelection();

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtChofer.Text))
            {
                R.Chofer = txtChofer.Text;
                if (Program.Valor3 == 1)
                {

                    R.Valor = 2;
                }
                else
                {
                    R.IdChofer = 0;
                    R.Valor = 1;

                }
                msj = R.RegistrarActChofer();

                if (msj == "1")
                {
                    LlenarGrid();
                    MessageBoxEx.Show("Chofer guardado", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBoxEx.Show("Ha ocurrido un error. Ya existe este chofer", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                Program.Valor3 = 0;
                R.IdChofer = 0;
                txtChofer.Text = string.Empty;
                txtChofer.ReadOnly = false;

            }
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dtgvChofer.SelectedRows.Count > 0)
            {

                //txtFabricante.ReadOnly = true;
                Program.Valor3 = 1;
                R.IdChofer = Convert.ToInt32(dtgvChofer.CurrentRow.Cells[0].Value);
                txtChofer.Text = dtgvChofer.CurrentRow.Cells[1].Value.ToString();

            }

        }
    }
}
