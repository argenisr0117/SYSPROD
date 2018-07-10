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
        private void ComboD()
        {
            try
            {
                cmbDpto.DataSource = D.Listar2(true);
                cmbDpto.DisplayMember = "DEPARTAMENTO";
                cmbDpto.ValueMember = "ID_DPTO";
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
            dtpHoraEntrada.Value = dtpHoraEntrada.Value.AddDays(-1);
            dtpHoraEntrada.Value = new DateTime(dtpHoraEntrada.Value.Year, dtpHoraEntrada.Value.Month, dtpHoraEntrada.Value.Day, 6, 0, 0);
            dtpHoraSalida.Value = dtpHoraSalida.Value.AddDays(-1);
            dtpHoraSalida.Value = new DateTime(dtpHoraSalida.Value.Year, dtpHoraSalida.Value.Month, dtpHoraSalida.Value.Day, 14, 0, 0);

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
                        chbCorrido.Checked = false;
                        chbFeriado.Checked = false;
                    }
                    else
                    {
                        MessageBoxEx.Show("Ha ocurrido un error", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
