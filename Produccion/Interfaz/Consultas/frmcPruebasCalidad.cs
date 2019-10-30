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
    public partial class frmcPruebasCalidad : MetroForm
    {
        clsPruebasCald PC = new clsPruebasCald();
        clsProducto P = new clsProducto();
        clsCliente C = new clsCliente();
        public frmcPruebasCalidad()
        {
            InitializeComponent();
        }
        private void ComboP()
        {
            try
            {
                cmbProducto.DataSource = P.Listado_Productos_Dpto(5);
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
                if (cmbProducto.SelectedIndex!=-1)
                {
                    PC.Producto = cmbProducto.SelectedValue.ToString();
                }
                if (cmbCliente.SelectedIndex != -1)
                {
                    PC.Cliente = Convert.ToInt16(cmbCliente.SelectedValue);
                }
                dt = PC.BuscarPruebasCalidad();
                dtgPruebasCald.DataSource = null;
                dtgPruebasCald.DataSource = dt;
                dtgPruebasCald.Columns[0].Visible = false;
                dtgPruebasCald.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7,FontStyle.Bold);
                //dtgPruebasCald.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 6);
                dtgPruebasCald.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void frmcOrdenProduccion_Load(object sender, EventArgs e)
        {
            ComboP();
            ComboC();
            Limpiar();
            LlenarGrid();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registros.frmOrdenProduccion obj = new Registros.frmOrdenProduccion();
            obj.ShowDialog();
            LlenarGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgPruebasCald.SelectedRows.Count > 0)
                {
                    Program.Idprueba = Convert.ToInt16(dtgPruebasCald.CurrentRow.Cells[0].Value);
                    Program.Producto = dtgPruebasCald.CurrentRow.Cells[2].Value.ToString();
                    Program.Cliente1 = dtgPruebasCald.CurrentRow.Cells[3].Value.ToString();
                    Program.Maquina = dtgPruebasCald.CurrentRow.Cells[4].Value.ToString();
                    Program.Colada = dtgPruebasCald.CurrentRow.Cells[5].Value.ToString();
                    Program.Sae= dtgPruebasCald.CurrentRow.Cells[6].Value.ToString();
                    Program.Pesozinc= dtgPruebasCald.CurrentRow.Cells[9].Value.ToString();
                    Program.Pesoszinc= dtgPruebasCald.CurrentRow.Cells[10].Value.ToString();
                    Program.Muestra2= dtgPruebasCald.CurrentRow.Cells[12].Value.ToString();
                    Program.Resistenia= dtgPruebasCald.CurrentRow.Cells[13].Value.ToString();
                    Program.Valor = 5;
                    Registros.frmControlCalidad obj = new Registros.frmControlCalidad();
                    obj.ShowDialog();
                    LlenarGrid();
                    Program.Valor = 0;
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("¿Desea Salir?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Dispose();
                Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
    }

   
}
