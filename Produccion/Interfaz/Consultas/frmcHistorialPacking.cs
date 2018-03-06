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
    public partial class frmcHistorialPacking : MetroForm
    {
        public frmcHistorialPacking()
        {
            InitializeComponent();
        }
        clsProducto P = new clsProducto();
        clsCliente C = new clsCliente();
        clsOrdenProduccion PC = new clsOrdenProduccion();
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
                cmbCliente.DataSource = C.Listado_Cliente_Combo(true, "Galv");
                cmbCliente.DisplayMember = "DESCRIPCION";
                cmbCliente.ValueMember = "ID_CLIENTE";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void LlenarGrid()
        {
            try
            {
                DataTable dt = new DataTable();
                PC.Fecha = dtpdesde.Value;
                PC.Fechaf = dtpHasta.Value;
                PC.Producto = "";
                PC.Cliente = 0;
                if (cmbProducto.SelectedIndex != -1)
                {
                    PC.Producto = cmbProducto.SelectedValue.ToString();
                }
                if (cmbCliente.SelectedIndex != -1)
                {
                    PC.Cliente = Convert.ToInt16(cmbCliente.SelectedValue);
                }
                dt = PC.BuscarPakingList();
                dtgPackingList.DataSource = null;
                dtgPackingList.DataSource = dt;
                dtgPackingList.Columns[0].Visible = false;
                dtgPackingList.Columns[6].Visible = false;
                dtgPackingList.Columns[7].Visible = false;
                dtgPackingList.Columns["CODIGO_PRODUCTO"].Visible = false;
                dtgPackingList.Columns["ID_REPORTE"].Visible = false;
                dtgPackingList.Columns["ID_CLIENTE"].Visible = false;
                dtgPackingList.Columns["ID_TIPO"].Visible = false;
                dtgPackingList.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7, FontStyle.Bold);
                //dtgPruebasCald.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 6);
                dtgPackingList.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void frmcHistorialPacking_Load(object sender, EventArgs e)
        {
            ComboP();
            ComboC();
            Limpiar();
            LlenarGrid();
        }
        private void Limpiar()
        {
            cmbProducto.SelectedIndex = -1;
            cmbCliente.SelectedIndex = -1;
        }
        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            if (dtpdesde.Value.Date <= dtpHasta.Value.Date)
            {
                LlenarGrid();
            }
            else
            {
                MessageBoxEx.Show("Fecha inicial no puede ser mayor que la final", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Consultas.frmcProducto obj = new Consultas.frmcProducto();
            obj.lbinf.Text = "Doble click para seleccinar";
            obj.lbinf.Visible = true;
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgPackingList.SelectedRows.Count > 0)
                {
                    Program.FechaS =(dtgPackingList.CurrentRow.Cells[1].Value.ToString());
                    Program.Idpacking= Convert.ToInt16(dtgPackingList.CurrentRow.Cells[0].Value);
                    Program.Idrptcald= Convert.ToInt16(dtgPackingList.CurrentRow.Cells["ID_REPORTE"].Value);
                    Program.Cliente=Convert.ToInt16(dtgPackingList.CurrentRow.Cells[8].Value);
                    Program.Producto= dtgPackingList.CurrentRow.Cells["CODIGO_PRODUCTO"].Value.ToString();
                    Program.Contenedor= dtgPackingList.CurrentRow.Cells[5].Value.ToString();
                    Program.Empresa= dtgPackingList.CurrentRow.Cells[6].Value.ToString();
                    Program.Tamano= Convert.ToInt16(dtgPackingList.CurrentRow.Cells[7].Value);
                    Program.Orden= dtgPackingList.CurrentRow.Cells[2].Value.ToString();
                    Program.Idtipoorden= Convert.ToInt16(dtgPackingList.CurrentRow.Cells["ID_TIPO"].Value);
                    Program.Valor = 6;
                    Registros.frmPackingList obj = new Registros.frmPackingList();
                    obj.ShowDialog();
                    LlenarGrid();
                    Program.Valor = 0;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("¿Desea Salir?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
            }
        }
    }
}
