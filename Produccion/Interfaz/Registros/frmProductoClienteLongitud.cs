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
    public partial class frmProductoClienteLongitud : MetroForm
    {
        clsProducto P = new clsProducto();
        clsCliente C = new clsCliente();
        clsOrdenProduccion O = new clsOrdenProduccion();
        clsEmpresa E = new clsEmpresa();
        int Id = 0;
        public frmProductoClienteLongitud()
        {
            InitializeComponent();
        }
        private void ComboP()
        {
            try
            {
                cmbProducto.DataSource = P.Listar(true);
                cmbProducto.DisplayMember = "DESCRIPCION";
                cmbProducto.ValueMember = "CODIGO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void ComboC()
        {
            try
            {
                cmbCliente.DataSource = C.Listar(true);
                cmbCliente.DisplayMember = "DESCRIPCION";
                cmbCliente.ValueMember = "ID_CLIENTE";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void LlenarComboE()
        {
            try
            {
                cbempresa.DataSource = E.Listar(true);
                cbempresa.DisplayMember = "DESCRIPCION";
                cbempresa.ValueMember = "ID_EMPRESA";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }

        }

        private void frmProductoClienteLongitud_Load(object sender, EventArgs e)
        {
            ComboC();
            ComboP();
            LlenarComboE();
            cbestado.SelectedIndex = 0;
            LlenarGrid();
            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("¿Desea Salir?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
            }
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
            dt = O.ObtenerProductoClienteLongitud(valor);
            try
            {
                //dtgvProducto.Rows.Clear();
                dtgvProducto.DataSource = null;
                dtgvProducto.DataSource = dt;
                //dtgvProducto.ClearSelection();
                dtgvProducto.Columns[0].Visible = false;
                dtgvProducto.Columns[3].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Limpiar()
        {
            cmbCliente.SelectedIndex = -1;
            cmbProducto.SelectedIndex = -1;
            cbempresa.SelectedIndex = -1;
            cbTicket.Checked = false;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Consultas.frmcProducto obj = new Consultas.frmcProducto();
            Program.Valor3 = 1;
            Program.Valor2 = 1;
            obj.ShowDialog();
            if (string.IsNullOrEmpty(Program.CodigoP))
            {
                return;
            }
            else
            {
                cmbProducto.SelectedValue = Program.CodigoP;
            }
            Program.Evento = 0;
            Program.Valor3 = 0;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProducto.Text == "" || cmbCliente.Text == "" || cbempresa.Text == "")
                {
                    MessageBoxEx.Show("Campos vacios, llenelos.", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                string mensaje = "";
                O.Id = Id;
                O.Producto = cmbProducto.SelectedValue.ToString();
                O.Cliente = Convert.ToInt16(cmbCliente.SelectedValue);
                O.Ticket = cbTicket.Checked;
                O.Idempresa = cbempresa.SelectedValue.ToString();
                mensaje = O.RelacionProductoClienteLongitud();
                if (mensaje == "1")
                {
                    MessageBoxEx.Show("Relacionado", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarGrid();
                    Limpiar();

                }
                else if(mensaje=="2")
                {
                    MessageBoxEx.Show("Ha ocurrido un error", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (mensaje == "3")
                {
                    MessageBoxEx.Show("Actualizado", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarGrid();
                    Limpiar();
                }
                Id = 0;
                }


            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            try
            {
                if (dtgvProducto.SelectedRows.Count > 0)
                {
                    O.Idd = "'" + dtgvProducto.CurrentRow.Cells[0].Value.ToString() + "'";
                    O.Estado = Convert.ToBoolean(dtgvProducto.CurrentRow.Cells[3].Value);
                    mensaje = O.Activar();
                    if (mensaje == "Desactivado!")
                    {
                        MessageBoxEx.Show(mensaje, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBoxEx.Show(mensaje, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBoxEx.Show("Seleccione un registro!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("Error:" + ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LlenarGrid();
        }

        private void cbestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarGrid();
            if (cbestado.SelectedIndex == 0)
            {
                btnActivar.Text = "DESACTIVAR";
            }
            else
            {
                btnActivar.Text = "ACTIVAR";

            }
        }

        private void dtgvProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           cmbProducto.Text=dtgvProducto.CurrentRow.Cells[1].Value.ToString();
           cmbCliente.Text= dtgvProducto.CurrentRow.Cells[2].Value.ToString();
           cbempresa.Text= dtgvProducto.CurrentRow.Cells[5].Value.ToString();
           cbTicket.Checked = Convert.ToBoolean(dtgvProducto.CurrentRow.Cells[4].Value);
           Id= Convert.ToInt16(dtgvProducto.CurrentRow.Cells[0].Value);

        }
    }
}
