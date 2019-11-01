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
    public partial class frmcOrdenProduccion : MetroForm
    {
        clsOrdenProduccion O = new clsOrdenProduccion();
        public frmcOrdenProduccion()
        {
            InitializeComponent();
        }
        private void ComboT()
        {
            try
            {
                cmbTipo.DataSource = O.ListadoTipoOrden(true);
                cmbTipo.DisplayMember = "DESCRIPCION";
                cmbTipo.ValueMember = "ID_TIPO";
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
                if (cmbEstado.SelectedIndex == 0)
                {
                    dt = O.ListadoOrdenes(false,Convert.ToInt16(cmbTipo.SelectedValue));
                }
                else
                {
                    dt = O.ListadoOrdenes(true,Convert.ToInt16(cmbTipo.SelectedValue));
                }
                dtgOrdenes.DataSource = null;
                dtgOrdenes.DataSource = dt;
                dtgOrdenes.ClearSelection();
                dtgOrdenes.Columns[9].Visible = false;
                dtgOrdenes.Columns[10].Visible = false;
                dtgOrdenes.Columns[11].Visible = false;
                dtgOrdenes.Columns[12].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void frmcOrdenProduccion_Load(object sender, EventArgs e)
        {
            cmbTipo.SelectedValue = 1;
            cmbEstado.SelectedIndex = 1;
            ComboT();
            LlenarGrid();
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registros.frmOrdenProduccion obj = new Registros.frmOrdenProduccion();  //crear nueva orden de produccion
            obj.ShowDialog();
            LlenarGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgOrdenes.SelectedRows.Count > 0)
                {
                    Program.Orden = dtgOrdenes.CurrentRow.Cells[1].Value.ToString();
                    Program.Producto = dtgOrdenes.CurrentRow.Cells[4].Value.ToString();
                    Program.Cliente1 = dtgOrdenes.CurrentRow.Cells[5].Value.ToString();
                    Program.Dpto = dtgOrdenes.CurrentRow.Cells[3].Value.ToString();
                    Program.Cantidad = Convert.ToInt16(dtgOrdenes.CurrentRow.Cells[6].Value);
                    Program.Idtipoorden= Convert.ToInt16(dtgOrdenes.CurrentRow.Cells[12].Value);
                    Program.Pedido= dtgOrdenes.CurrentRow.Cells[2].Value.ToString();
                    Program.Valor = 5;
                    Registros.frmOrdenProduccion obj = new Registros.frmOrdenProduccion();
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
<<<<<<< HEAD
                Dispose();
                Close();
=======
                this.Dispose();
                this.Close();
>>>>>>> bf1dba918529b9e8fe8f30955f8e6ec0e9182058
            }
        }

        private void btnPacking_Click(object sender, EventArgs e)
        {
            if (dtgOrdenes.SelectedRows.Count > 0)
            {
                Program.Orden = dtgOrdenes.CurrentRow.Cells[1].Value.ToString();
                Program.Producto = dtgOrdenes.CurrentRow.Cells[9].Value.ToString();
                Program.Cliente =Convert.ToInt16(dtgOrdenes.CurrentRow.Cells[10].Value);
                Program.Dpto = dtgOrdenes.CurrentRow.Cells[3].Value.ToString();
                Program.Idtipoorden= Convert.ToInt16(dtgOrdenes.CurrentRow.Cells[12].Value);
                Registros.frmPackingList obj = new Registros.frmPackingList();
                obj.ShowDialog();

            }
            else
            {
                MessageBoxEx.Show("Debe seleccionar una orden", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            frmcHistorialPacking obj = new frmcHistorialPacking();
            obj.ShowDialog();
            Program.Orden = "";
            Program.Producto = "";
            Program.Cliente = 0;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                bool msj = false;
                DialogResult var;
                if (dtgOrdenes.SelectedRows.Count > 0)
                {
                    var = MessageBoxEx.Show("Desea registrar la producción?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (var == DialogResult.Yes)
                    {
                        O.Id = Convert.ToInt16(dtgOrdenes.CurrentRow.Cells[11].Value);
                        msj = O.EliminarOrdenProduccion();
                        if (msj == true)
                        {

                            MessageBoxEx.Show("Ordén eliminada", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LlenarGrid();
                        }
                        else
                        {
                            MessageBoxEx.Show("No se ha podido eliminar", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
           
        }

        private void cmbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cmbTipo.SelectedValue.ToString()=="System.Data.DataRowView")
            {
                //nada
            }
            else
            {
                LlenarGrid();

            }
        }
    }

   
}
