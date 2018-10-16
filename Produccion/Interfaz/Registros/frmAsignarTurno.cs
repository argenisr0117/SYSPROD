using System;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar;
using Intermedia;
namespace Interfaz.Registros
{
    public partial class frmAsignarTurno : MetroForm
    {
        public frmAsignarTurno()
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
                cmbTurno.DataSource = T.Listar(true);
                cmbTurno.DisplayMember = "ID_TURNO";
                cmbTurno.ValueMember = "ID_TURNO";
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

            DataTable dt = T.ObtenerAsignacionTurno();
            dtgvHorasExtra.DataSource = null;
            dtgvHorasExtra.DataSource = dt;
            dtgvHorasExtra.Columns[0].Visible = false;
            dtgvHorasExtra.ClearSelection();
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
            ComboE();
            ComboT();
            LlenarGrid();
            cmbTurno.SelectedIndex = 0;
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
                T.IdEmpleado = cmbEmpleado.SelectedValue.ToString();
                T.Idturno = cmbTurno.SelectedValue.ToString();
                T.Semana = chSemana.Checked;
                T.FinSemana = chFinsemana.Checked;
                if (editar == 1)
                {
                    T.Id = Id;
                    msj = T.RegistrarAsignacionTurno();
                }
                else
                {
                    T.Id = 0;
                    msj = T.RegistrarAsignacionTurno();
                }
                if (msj == "1")
                {
                    MessageBoxEx.Show("Registro guardado", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    editar = 0;
                    Id = 0;
                    Limpiar();
                    LlenarGrid();
                }
                else
                {
                    MessageBoxEx.Show("ERROR..\n Ya existe un registro para este empleado.", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void Limpiar()
        {
            chFinsemana.Checked = false;
            chSemana.Checked = false;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dtgvHorasExtra.SelectedRows.Count > 0)
            {
                Id = Convert.ToInt32(dtgvHorasExtra.CurrentRow.Cells[0].Value);
                cmbEmpleado.Text = dtgvHorasExtra.CurrentRow.Cells[1].Value.ToString();
                cmbTurno.SelectedValue = dtgvHorasExtra.CurrentRow.Cells[2].Value.ToString();
                chSemana.Checked = Convert.ToBoolean(dtgvHorasExtra.CurrentRow.Cells[3].Value);
                chFinsemana.Checked = Convert.ToBoolean(dtgvHorasExtra.CurrentRow.Cells[4].Value);
                editar = 1;
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void cmbDpto2_SelectedValueChanged(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgvHorasExtra.SelectedRows.Count > 0)
            {
                DialogResult var = MessageBoxEx.Show("¿Desea eliminar el registro?", "SysProd", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (var == DialogResult.Yes)
                {
                    string msj = "";
                    T.Id = Convert.ToInt16(dtgvHorasExtra.CurrentRow.Cells[0].Value);
                    msj = T.EliminarAsignacionTurno();
                    if (msj == "1")
                    {
                        MessageBoxEx.Show("Registro eliminado", "SysProd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LlenarGrid();
                    }
                    else
                    {
                        MessageBoxEx.Show("Ha ocurrido un error.", "SysProd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
