using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using Intermedia;
using System;
using System.Data;
using System.Windows.Forms;

namespace Interfaz.Registros
{
    public partial class frmFabricante : MetroForm
    {
        public frmFabricante()
        {
            InitializeComponent();
        }
        clsRecepAlambron R = new clsRecepAlambron();
        string msj = "";


        private void LlenarGrid()
        {

            DataTable dt = R.ListadoFabricante();
            dtgvFabricante.DataSource = null;
            dtgvFabricante.DataSource = dt;
            dtgvFabricante.ClearSelection();

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFabricante.Text))
            {
                R.Fabricante = txtFabricante.Text;
                if (Program.Valor3 == 1)
                {

                    R.Valor = 2;
                }
                else
                {
                    R.IdFabricante = 0;
                    R.Valor = 1;

                }
                msj = R.RegistrarActFabricante();

                if (msj == "1")
                {
                    LlenarGrid();
                    MessageBoxEx.Show("Fabricante guardado", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBoxEx.Show("Ha ocurrido un error. Ya existe este fabricante", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                Program.Valor3 = 0;
                R.IdFabricante = 0;
                txtFabricante.Text = string.Empty;
                txtFabricante.ReadOnly = false;


            }
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dtgvFabricante.SelectedRows.Count > 0)
            {

                //txtFabricante.ReadOnly = true;
                Program.Valor3 = 1;
                R.IdFabricante = Convert.ToInt32(dtgvFabricante.CurrentRow.Cells[0].Value);
                txtFabricante.Text = dtgvFabricante.CurrentRow.Cells[1].Value.ToString();

            }

        }
    }
}
