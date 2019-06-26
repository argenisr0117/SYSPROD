using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Intermedia;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar;

namespace Interfaz.Registros
{
    public partial class frmTurno : MetroForm
    {
        clsTurno T = new clsTurno();
        public frmTurno()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (DevComponents.DotNetBar.MessageBoxEx.Show("¿Desea Salir?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Utilidades.ValidarForm(this, errorProvider1) == false)
            {
                return;
            }
            string mensaje = "";
            try
            {
                T.Idturno = txtabreviacion.Text;
                T.Descripcion = txtturno.Text;
                T.HoraComida = cbHoraComida.Checked;
                T.InicioHent = dtpIniciohent.Value;
                T.FinHent = dtpFinHEnt.Value;
                T.InicioHsal = dtpInicioHsal.Value;
                T.FinHsal = dtpFinHSal.Value;
                T.HoraInicio = dtpHorainicio.Value;
                T.HoraFin = dtpHorafin.Value;
                T.Duracion = Convert.ToInt32(nupDuracion.Value);
                T.Amanecida = cbAmanecida.Checked;
                if (Program.Evento == 0)
                {

                    mensaje = T.RegistrarTurno();
                    if (mensaje == "Turno ya existe!")
                    {
                        MessageBoxEx.Show(mensaje, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBoxEx.Show(mensaje, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                }
                else
                {
                    MessageBoxEx.Show(T.ActualizarTurno(), "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                LlenarGrid();
                btnregistrar.Text = "REGISTRAR";
                Program.Evento = 0;
                txtabreviacion.Enabled = true;
                txtabreviacion.Focus();
            }

            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
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
            dt = T.Listar(valor);
            try
            {
                //for (int x = 0; x < dt.Rows.Count; x++)
                //{
                //    dtgvTurno.Rows.Add(dt.Rows[x][0]);
                //    dtgvTurno.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                //    dtgvTurno.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                //    dtgvTurno.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                //}
                dtgvTurno.DataSource = dt;
                dtgvTurno.Columns[2].Visible = false;
                dtgvTurno.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Limpiar()
        {
            txtabreviacion.Clear();
            txtturno.Clear();
            txtabreviacion.Focus();
            cbHoraComida.Checked = false;
            cbAmanecida.Checked = false;
            cbestado.SelectedIndex = 0;
            dtpFinHEnt.Value = new DateTime(2018, 10, 11, 00, 00, 00);
            dtpFinHSal.Value = new DateTime(2018, 10, 11, 00, 00, 00);
            dtpHorafin.Value = new DateTime(2018, 10, 11, 00, 00, 00);
            dtpHorainicio.Value = new DateTime(2018, 10, 11, 00, 00, 00);
            dtpIniciohent.Value = new DateTime(2018, 10, 11, 00, 00, 00);
            dtpInicioHsal.Value = new DateTime(2018, 10, 11, 00, 00, 00);
            nupDuracion.Value = 0;

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dtgvTurno.SelectedRows.Count > 0)
            {
                btnregistrar.Text = "GUARDAR";
                txtabreviacion.Text = dtgvTurno.CurrentRow.Cells[0].Value.ToString();
                txtabreviacion.Enabled = false;
                txtturno.Text = dtgvTurno.CurrentRow.Cells[1].Value.ToString();
                nupDuracion.Value = Convert.ToInt32(dtgvTurno.CurrentRow.Cells[3].Value);
                cbHoraComida.Checked = Convert.ToBoolean(dtgvTurno.CurrentRow.Cells["H_COMIDA"].Value);
                cbAmanecida.Checked = Convert.ToBoolean(dtgvTurno.CurrentRow.Cells["AMANECIDA"].Value);
                dtpHorainicio.Value = Convert.ToDateTime((dtgvTurno.CurrentRow.Cells["HORA_INICIO"].Value.ToString()));
                dtpHorafin.Value = Convert.ToDateTime(dtgvTurno.CurrentRow.Cells["HORA_FIN"].Value.ToString());
                dtpIniciohent.Value = Convert.ToDateTime(dtgvTurno.CurrentRow.Cells["Inicio Entrada"].Value.ToString());
                dtpFinHEnt.Value = Convert.ToDateTime(dtgvTurno.CurrentRow.Cells["Fin Entrada"].Value.ToString());
                dtpInicioHsal.Value = Convert.ToDateTime(dtgvTurno.CurrentRow.Cells["Inicio Salida"].Value.ToString());
                dtpFinHSal.Value = Convert.ToDateTime(dtgvTurno.CurrentRow.Cells["Fin Salida"].Value.ToString());
                Program.Evento = 1;
            }
            else
            {
                MessageBoxEx.Show("Seleccione un registro!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmTurno_Load(object sender, EventArgs e)
        {
            Limpiar();
            Program.Evento = 0;
            LlenarGrid();
            txtabreviacion.Focus();
            cbestado.SelectedIndex = 0;
        }

        private void btnactivar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            try
            {
                if (dtgvTurno.SelectedRows.Count > 0)
                {
                    T.Idturno = "'" + dtgvTurno.CurrentRow.Cells[0].Value.ToString() + "'";
                    T.Estado = Convert.ToBoolean(dtgvTurno.CurrentRow.Cells[2].Value);
                    mensaje = T.ActivarTurno();
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
        }
    }
}
