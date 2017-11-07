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

        private void frmProductoClienteLongitud_Load(object sender, EventArgs e)
        {
            ComboC();
            ComboP();
            cbestado.SelectedIndex = 0;
            LlenarGrid();
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
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                string mensaje = "";
                O.Producto = cmbProducto.SelectedValue.ToString();
                O.Cliente = Convert.ToInt16(cmbCliente.SelectedValue);
                mensaje = O.RelacionProductoClienteLongitud();
                if (mensaje == "1")
                {
                    MessageBoxEx.Show("Relacionado", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarGrid();

                }
                else if(mensaje=="2")
                {
                    MessageBoxEx.Show("Ha ocurrido un error", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch(Exception ex)
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
    }
}
