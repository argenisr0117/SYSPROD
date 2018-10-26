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
    public partial class frmAttControl : MetroForm
    {
        public frmAttControl()
        {
            InitializeComponent();
        }
        clsTurno T = new clsTurno();
        clsEmpleado E = new clsEmpleado();
        clsDepartamento D = new clsDepartamento();
        clsEmpresa Em = new clsEmpresa();
        int editar = 0;
        int Id = 0;

        private void ComboT()
        {
            try
            {
                cmbTipo.DataSource = T.ObtAttControlTypes();
                cmbTipo.DisplayMember = "DESCRIPCION";
                cmbTipo.ValueMember = "TYPE_ID";
                cmbTipo2.DataSource = T.ObtAttControlTypes();
                cmbTipo2.DisplayMember = "DESCRIPCION";
                cmbTipo2.ValueMember = "TYPE_ID";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
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
            T.Iddpto = cmbDpto2.SelectedValue.ToString();
            T.Typeid = Convert.ToInt32(cmbTipo2.SelectedValue);
            DataTable dt = T.ObtRegAttControl();
            dtgvRegAttControl.DataSource = null;
            dtgvRegAttControl.DataSource = dt;
            dtgvRegAttControl.ClearSelection();
            dtgvRegAttControl.Columns[0].Visible = false;
            dtgvRegAttControl.ColumnHeadersDefaultCellStyle.Font = new Font(dtgvRegAttControl.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
        }
        private void ComboD()
        {
            try
            {
                cmbDpto.DataSource = D.Listar2(true);
                cmbDpto.DisplayMember = "DEPARTAMENTO";
                cmbDpto.ValueMember = "ID_DPTO";
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
            E.Iddpto = cmbDpto.SelectedValue.ToString();
            T.Iddpto= cmbDpto.SelectedValue.ToString();
            ComboE();
            ComboT();
            dtpFechaInicio.Value = dtpFechaInicio.Value.AddDays(-1);
            dtpFechaInicio.Value = new DateTime(dtpFechaInicio.Value.Year, dtpFechaInicio.Value.Month, dtpFechaInicio.Value.Day, 8, 0, 0);
            dtpFechaFin.Value = dtpFechaFin.Value.AddDays(-1);
            dtpFechaFin.Value = new DateTime(dtpFechaFin.Value.Year, dtpFechaFin.Value.Month, dtpFechaFin.Value.Day, 8, 0, 0);
            LlenarGrid();
            cmbTipo.SelectedIndex = 0;
            cmbTipo2.SelectedIndex = 0;

        }

        private void cmbDpto_SelectedValueChanged(object sender, EventArgs e)
        {
            E.Iddpto = cmbDpto.SelectedValue.ToString();
            ComboE();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string msj = "";
                if (dtpFechaInicio.Value.Date > dtpFechaFin.Value.Date)
                {
                    MessageBoxEx.Show("Fecha inicio no puede ser mayor que fecha final", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    T.HoraInicio = dtpFechaInicio.Value;
                    T.HoraFin = dtpFechaFin.Value;
                    T.IdEmpleado = cmbEmpleado.SelectedValue.ToString();
                    T.Typeid = Convert.ToInt32(cmbTipo.SelectedValue);
                    if (editar == 1)
                    {
                        T.Id = Id;
                        msj = T.RegistrarActAttControl();
                    }
                    else
                    {
                        T.Id = 0;
                        msj = T.RegistrarActAttControl();
                    }
                    if (msj == "1")
                    {
                        MessageBoxEx.Show("Registro guardado", "SysProd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        editar = 0;
                        Id = 0;
                        Limpiar();
                        LlenarGrid();
                    }
                    else
                    {
                        MessageBoxEx.Show("ERROR..\n Ya existe un registro para este empleado este día.", "SysProd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void Limpiar()
        {

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dtgvRegAttControl.SelectedRows.Count > 0)
            {
                Id = Convert.ToInt32(dtgvRegAttControl.CurrentRow.Cells[0].Value);
                cmbDpto.SelectedValue = dtgvRegAttControl.CurrentRow.Cells[9].Value.ToString();
                cmbEmpleado.Text = dtgvRegAttControl.CurrentRow.Cells[1].Value.ToString();
                cmbTipo.SelectedValue = dtgvRegAttControl.CurrentRow.Cells[8].Value.ToString();
                dtpFechaInicio.Value = Convert.ToDateTime(dtgvRegAttControl.CurrentRow.Cells[3].Value);
                dtpFechaFin.Value = Convert.ToDateTime(dtgvRegAttControl.CurrentRow.Cells[4].Value);
                editar = 1;
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgvRegAttControl.SelectedRows.Count > 0)
            {
                DialogResult var = MessageBoxEx.Show("¿Desea eliminar el registro?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (var == DialogResult.Yes)
                {
                    string msj = "";
                    E.Id = Convert.ToInt16(dtgvRegAttControl.CurrentRow.Cells[0].Value);
                    msj = E.EliminarRegAttControl();
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

        private void cmbDpto2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void cmbTipo2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LlenarGrid();
        }
    }
}
