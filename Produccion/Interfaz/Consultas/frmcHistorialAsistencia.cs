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
    public partial class frmcHistorialAsistencia : MetroForm
    {
        public frmcHistorialAsistencia()
        {
            InitializeComponent();
        }
        clsTurno T = new clsTurno();
        clsEmpleado E = new clsEmpleado();
        clsDepartamento D = new clsDepartamento();
       //int editar = 0;
        //int Idhora = 0;

        private void ComboE()
        {
            try
            {
                cmbEmpleado.DataSource = E.Listar(true);
                cmbEmpleado.DisplayMember = "NOMBRE";
                cmbEmpleado.ValueMember = "ID_EMPLEADO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void LlenarGrid()
        {
            if (dtpFechaDesde.Value.Date <= dtpFechaHasta.Value.Date)
            {
                E.Desde = dtpFechaDesde.Value;
                E.Hasta = dtpFechaHasta.Value;
                E.Iddpto = cmbDpto2.SelectedValue.ToString();
                if (cmbEmpleado.Text == "")
                {
                    E.Idempleado = "";
                }
                else
                {
                    E.Idempleado = cmbEmpleado.SelectedValue.ToString();
                }
                DataTable dt = E.ObtHistorialAsistencia();
                dtgvHorasExtra.DataSource = null;
                dtgvHorasExtra.DataSource = dt;
                dtgvHorasExtra.ClearSelection();
                dtgvHorasExtra.ColumnHeadersDefaultCellStyle.Font = new Font(dtgvHorasExtra.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            }
            else
            {
                MessageBoxEx.Show("Fecha inicial no puede ser mayor que fecha final.", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ComboD()
        {
            try
            {
                cmbDpto2.DataSource = D.Listar2(true);
                cmbDpto2.DisplayMember = "DEPARTAMENTO";
                cmbDpto2.ValueMember = "ID_DPTO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void frmHoraExtra_Load(object sender, EventArgs e)
        {
            ComboD();
            ComboE();
            cmbEmpleado.SelectedValue = "";
            //LlenarGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                LlenarGrid();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

            if (dtpFechaDesde.Value.Date <= dtpFechaHasta.Value.Date)
            {
                frmReporte obj = new frmReporte();
                obj.Valor = 24;
                obj.Nombre = "historial_asistencia.rdlc";
                obj.Fechai = dtpFechaDesde.Value;
                obj.Fechaf = dtpFechaHasta.Value;
                if (cmbEmpleado.Text == "")
                {
                    obj.Idempleado = "";
                }
                else
                {
                    obj.Idempleado = cmbEmpleado.SelectedValue.ToString();
                }
                obj.Iddpto = cmbDpto2.SelectedValue.ToString();
                obj.Show();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgvHorasExtra.SelectedRows.Count > 0)
            {
                DialogResult var = MessageBoxEx.Show("¿Desea eliminar el registro?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (var == DialogResult.Yes)
                {
                    string msj = "";
                    E.Idhora = Convert.ToInt16(dtgvHorasExtra.CurrentRow.Cells[0].Value);
                    msj = E.EliminarRegHoraExtra();
                    if (msj == "1")
                    {
                        MessageBoxEx.Show("Registro eliminado", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LlenarGrid();
                    }
                    else
                    {
                        MessageBoxEx.Show("Ha ocurrido un error.", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cmbDpto2_SelectedValueChanged(object sender, EventArgs e)
        {
            E.Iddpto = cmbDpto2.SelectedValue.ToString();
            ComboE();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbEmpleado.SelectedValue = "";
        }
    }
}
