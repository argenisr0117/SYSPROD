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
    public partial class frmcHistorialMonitoreo : MetroForm
    {
        public frmcHistorialMonitoreo()
        {
            InitializeComponent();
        }
        clsMaquina M = new clsMaquina();
        clsTurno T = new clsTurno();
        private void ComboM()
        {
            try
            {
                cmbMaquina.DataSource = M.Listar(true);
                cmbMaquina.DisplayMember = "DESCRIPCION";
                cmbMaquina.ValueMember = "ID_MAQUINA";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
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
        private void frmcHistorialMonitoreo_Load(object sender, EventArgs e)
        {
            ComboM();
            ComboT();
            cmbMaquina.SelectedIndex = -1;
            cmbTurno.SelectedIndex = -1;
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpDesde.Value.Date <= dtpHasta.Value.Date)
                {
                    frmReporte obj = new frmReporte();
                    obj.Fechai = dtpDesde.Value;
                    obj.Fechaf = dtpHasta.Value;
                    obj.Valor = 17;
                    obj.Nombre = "historial_produccion.rdlc";
                    if (cmbMaquina.SelectedIndex != -1) //(cmbSupervisor.SelectedValue != null)
                    {
                        obj.Maquina= cmbMaquina.SelectedValue.ToString();
                    }
                    else
                        obj.Maquina = "";

                    if (cmbTurno.SelectedIndex != -1) //(cmbOperador.SelectedValue != null)
                    {
                        obj.Turno = cmbTurno.SelectedValue.ToString();
                    }
                    else
                        obj.Turno = "";
                    obj.Show();
                }
        
            else
            {
                MessageBoxEx.Show("Fecha inicial mayor que Fecha final", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
