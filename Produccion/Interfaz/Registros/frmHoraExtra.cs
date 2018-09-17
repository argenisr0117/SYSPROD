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
    public partial class frmHoraExtra : MetroForm
    {
        public frmHoraExtra()
        {
            InitializeComponent();
        }
        clsTurno T = new clsTurno();
        clsEmpleado E = new clsEmpleado();
        clsDepartamento D = new clsDepartamento();
        clsEmpresa Em = new clsEmpresa();
        int editar = 0;
        int Idhora = 0;

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
        private void ComboEm()
        {
            try
            {
                cmbEmpresa.DataSource = Em.Listar(true);
                cmbEmpresa.DisplayMember = "DESCRIPCION";
                cmbEmpresa.ValueMember = "ID_EMPRESA";
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
                E.Empresa = cmbEmpresa.SelectedValue.ToString();
                DataTable dt = E.ObtRegistrosHorasExtras();
                dtgvHorasExtra.DataSource = null;
                dtgvHorasExtra.DataSource = dt;
                dtgvHorasExtra.ClearSelection();
                dtgvHorasExtra.Columns[0].Visible = false;
                dtgvHorasExtra.Columns[8].Visible = false;
                dtgvHorasExtra.Columns[9].Visible = false;
                dtgvHorasExtra.Columns[10].Visible = false;
                dtgvHorasExtra.Columns[11].Visible = false;
                dtgvHorasExtra.Columns[12].Visible = false;
                dtgvHorasExtra.Columns[13].Visible = false;
                dtgvHorasExtra.Columns[14].Visible = false;
                dtgvHorasExtra.Columns[15].Visible = false;
                dtgvHorasExtra.Columns[16].Visible = false;
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
            ComboEm();
            cmbEmpresa.SelectedValue = "ACERO";
            dtpHoraEntrada.Value = dtpHoraEntrada.Value.AddDays(-1);
            dtpHoraEntrada.Value = new DateTime(dtpHoraEntrada.Value.Year, dtpHoraEntrada.Value.Month, dtpHoraEntrada.Value.Day, 6, 0, 0);
            dtpHoraSalida.Value = dtpHoraSalida.Value.AddDays(-1);
            dtpHoraSalida.Value = new DateTime(dtpHoraSalida.Value.Year, dtpHoraSalida.Value.Month, dtpHoraSalida.Value.Day, 14, 0, 0);
            LlenarGrid();
            cmbTurno.SelectedIndex = 0;
            cmbTurno_SelectionChangeCommitted(e, e);

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
                if (dtpHoraEntrada.Value >= dtpHoraSalida.Value)
                {
                    MessageBoxEx.Show("Hora de entrada no puede ser mayor que hora de salida", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    E.HoraEnt = dtpHoraEntrada.Value;
                    E.HoraSal = dtpHoraSalida.Value;
                    E.Idempleado = cmbEmpleado.SelectedValue.ToString();
                    E.Idturno = cmbTurno.SelectedValue.ToString();
                    E.Corrido = chbCorrido.Checked;
                    E.Feriado = chbFeriado.Checked;
                    E.Vacaciones = chbVacaciones.Checked;
                    E.Inasistencia = chbInasistencia.Checked;
                    E.Incapacidad = chbIncapacidad.Checked;
                    E.Permiso = chbPermiso.Checked;
                    if (editar == 1)
                    {
                        E.Idhora = Idhora;
                        msj = E.RegistrarActHorasExtras();
                    }
                    else
                    {
                        E.Idhora = 0;
                        msj = E.RegistrarActHorasExtras();
                    }
                    if (msj == "1")
                    {
                        MessageBoxEx.Show("Registro guardado", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        editar = 0;
                        Idhora = 0;
                        Limpiar();
                        LlenarGrid();
                    }
                    else
                    {
                        MessageBoxEx.Show("ERROR..\n Ya existe un registro para este empleado este día.", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {

            }
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

        private void Limpiar()
        {
            chbCorrido.Checked = false;
            chbFeriado.Checked = false;
            chbVacaciones.Checked = false;
            chbIncapacidad.Checked = false;
            chbInasistencia.Checked = false;
            chbPermiso.Checked = false;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dtgvHorasExtra.SelectedRows.Count > 0)
            {
                Idhora = Convert.ToInt32(dtgvHorasExtra.CurrentRow.Cells[0].Value);
                cmbDpto.SelectedValue = dtgvHorasExtra.CurrentRow.Cells[9].Value.ToString();
                cmbEmpleado.Text = dtgvHorasExtra.CurrentRow.Cells[1].Value.ToString();
                cmbTurno.SelectedValue = dtgvHorasExtra.CurrentRow.Cells[8].Value.ToString();
                dtpHoraEntrada.Value = Convert.ToDateTime(dtgvHorasExtra.CurrentRow.Cells[3].Value);
                dtpHoraSalida.Value = Convert.ToDateTime(dtgvHorasExtra.CurrentRow.Cells[4].Value);
                chbFeriado.Checked = Convert.ToBoolean(dtgvHorasExtra.CurrentRow.Cells[10].Value);
                chbCorrido.Checked = Convert.ToBoolean(dtgvHorasExtra.CurrentRow.Cells[11].Value);
                chbVacaciones.Checked = Convert.ToBoolean(dtgvHorasExtra.CurrentRow.Cells[13].Value);
                chbIncapacidad.Checked = Convert.ToBoolean(dtgvHorasExtra.CurrentRow.Cells[14].Value);
                chbInasistencia.Checked = Convert.ToBoolean(dtgvHorasExtra.CurrentRow.Cells[15].Value);
                chbPermiso.Checked = Convert.ToBoolean(dtgvHorasExtra.CurrentRow.Cells[16].Value);
                editar = 1;
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            int diferencia = (int)(dtpFechaHasta.Value - dtpFechaDesde.Value).TotalDays;
            if (diferencia <= 17)
            {
                if (dtpFechaDesde.Value.Date <= dtpFechaHasta.Value.Date)
                {
                    frmReporte obj = new frmReporte();
                    obj.Valor = 23;
                    obj.Nombre = "horas_extra.rdlc";
                    obj.Fechai = dtpFechaDesde.Value;
                    obj.Fechaf = dtpFechaHasta.Value;
                    obj.Empresa = cmbEmpresa.Text;
                    obj.Dpto = cmbDpto2.Text;
                    obj.Iddpto = cmbDpto2.SelectedValue.ToString();
                    obj.Idempresa = cmbEmpresa.SelectedValue.ToString();
                    obj.Show();
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void cmbTurno_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (cmbTurno.SelectedIndex > -1)
            //{

            //}

        }

        private void cmbTurno_SelectionChangeCommitted(object sender, EventArgs e)
        {
            T.Idturno = cmbTurno.SelectedValue.ToString();
            DataTable dt = T.ObtenerInicioFinTurno();
            dtpHoraEntrada.Value = new DateTime(dtpHoraEntrada.Value.Year, dtpHoraEntrada.Value.Month, dtpHoraEntrada.Value.Day, Convert.ToInt16(dt.Rows[0][0]), 0, 0);
            dtpHoraSalida.Value = new DateTime(dtpHoraSalida.Value.Year, dtpHoraSalida.Value.Month, dtpHoraSalida.Value.Day, Convert.ToInt16(dt.Rows[0][1]), 0, 0);
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
    }
}
