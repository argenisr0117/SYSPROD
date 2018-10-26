using System;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar;
using Intermedia;
using System.Linq;

namespace Interfaz.Registros
{
    public partial class frmPonche : MetroForm
    {
        AttendanceClass Att = new AttendanceClass();
        clsPonche P = new clsPonche();
        clsTurno T = new clsTurno();
        clsEmpleado E = new clsEmpleado();
        clsDepartamento D = new clsDepartamento();
        string form = "";
        public frmPonche()
        {
            InitializeComponent();
            RealTime_Dtg.Columns[2].Width = 125;
        }

        private void Connect()
        {
            Cursor = Cursors.WaitCursor;
            DataTable Dt = new DataTable();
            P.Id = 0;
            try
            {
                Dt = P.GetDeviceParams();
                if (Dt.Rows.Count > 0)
                {
                    int ret = Att.sta_ConnectTCP(lbSysOutputInfo, Dt.Rows[0]["IP"].ToString(), Dt.Rows[0]["PUERTO"].ToString(), Dt.Rows[0]["CM_KEY"].ToString(), Dt.Rows[0]["NOMBRE"].ToString());

                    if (Att.GetConnectState())
                    {
                        Att.sta_getBiometricType();
                    }
                    if (ret == 1)
                    {
                        //getCapacityInfo();
                        //getDeviceInfo();


                        cONECTARToolStripMenuItem.Enabled = false;
                        dESCONECTARToolStripMenuItem.Enabled = true;
                        dESCARGARREGISTROSToolStripMenuItem.Enabled = true;
                        bORRARREGISTROSToolStripMenuItem.Enabled = true;

                    }
                    else if (ret == -2)
                    {

                        cONECTARToolStripMenuItem.Enabled = true;
                        dESCONECTARToolStripMenuItem.Enabled = false;
                        dESCARGARREGISTROSToolStripMenuItem.Enabled = false;
                        bORRARREGISTROSToolStripMenuItem.Enabled = false;
                    }
                }
                else
                {
                    MessageBoxEx.Show("No existe dispositivo al cual conectarse..", "SysProd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //public ListBox RealTimeEventListBox()
        //{
        //    ListBox dtg = lbRTOutputInfo;
        //    return dtg;
        //}
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
        public DataGridView RealTimeEventDtg()
        {
            DataGridView dtg = RealTime_Dtg;
            return dtg;
        }
        private void frmPonche_Load(object sender, EventArgs e)
        {
            cONECTARToolStripMenuItem.Enabled = true;
            dESCONECTARToolStripMenuItem.Enabled = false;
            dESCARGARREGISTROSToolStripMenuItem.Enabled = false;
            bORRARREGISTROSToolStripMenuItem.Enabled = false;
            //Att.sta_SetRTLogListBox(RealTimeEventListBox);
            Att.sta_SetRTLogDtg(RealTimeEventDtg);
            ComboD();
        }

        private void cONECTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void dESCONECTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void dESCARGARREGISTROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBoxEx.Show("Desea descargar los registros de asistencia?", "SysProd", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes)
            {
                Cursor = Cursors.WaitCursor;
                DataTable dt_period = new DataTable("dt_period");
                Attlog_Dtg.AutoGenerateColumns = true;
                Attlog_Dtg.Columns.Clear();
                //dt_period.Columns.Add("Count", System.Type.GetType("System.Int32"));
                //dt_period.Columns.Add("User ID", System.Type.GetType("System.String"));
                //dt_period.Columns.Add("Verify Date", System.Type.GetType("System.String"));
                //dt_period.Columns.Add("Verify Type", System.Type.GetType("System.Int32"));
                //dt_period.Columns.Add("Verify State", System.Type.GetType("System.Int32"));
                //dt_period.Columns.Add("WorkCode", System.Type.GetType("System.Int32"));

                Att.sta_readAttLog(lbSysOutputInfo);
                dt_period = T.ObtDailyAttendance();
                Attlog_Dtg.DataSource = null;
                Attlog_Dtg.DataSource = dt_period;

                Cursor = Cursors.Default;
            }
        }

        private void mANTTURNOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTurno obj = new frmTurno();
            obj.Show();
        }

        private void aSIGNARTURNOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form = "frmAsignarTurno";
            AbrirForm(form);
        }

        private void rEGISTROMANUALHORASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form = "frmHoraExtra";
            AbrirForm(form);
        }

        private void aSIGNARPERMISOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form = "frmAttControl";
            AbrirForm(form);
        }

        private void bORRARREGISTROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBoxEx.Show("Desea borrar los registros de asistencia?", "SysProd", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes)
            {

                Att.sta_DeleteAttLog(lbSysOutputInfo);
            }
            else
                return;
        }

        private void mANTEMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form = "frmEmpleado";
            AbrirForm(form);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                //Cursor = Cursors.WaitCursor;

                for (DateTime dtp = dtpFecha.Value.Date; dtp <= dtpHasta.Value.Date; dtp = dtp.AddDays(1))
                {
                    E.Fecha = dtp;
                    E.Iddpto = cmbDpto.SelectedValue.ToString();
                    E.RegistrarDailyAtt();
                }

               // Cursor = Cursors.Default;
                MessageBoxEx.Show("Calculo procesado", "SysProd", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "SysProd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hORASREGISTRADASToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            form = "frmcHoraExtra";
            AbrirForm(form);
        }

        private void AbrirForm(string form)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre =>
          pre.Name == form).SingleOrDefault<Form>();

            if (existe != null)
            {
                existe.WindowState = FormWindowState.Normal;
                existe.BringToFront();
            }
            else
            {
                if (form == "frmcHoraExtra")
                {
                    Consultas.frmcHoraExtra obj = new Consultas.frmcHoraExtra();
                    obj.Show();
                }
                if (form == "frmEmpleado")
                {
                    frmEmpleado obj = new frmEmpleado();
                    obj.Show();
                }
                if (form == "frmAsignarTurno")
                {
                    frmAsignarTurno obj = new frmAsignarTurno();
                    obj.Show();
                }
                if (form == "frmAttControl")
                {
                    frmAttControl obj = new frmAttControl();
                    obj.Show();
                }
                if (form == "frmHoraExtra")
                {
                    frmHoraExtra obj = new frmHoraExtra();
                    obj.Show();
                }
            }
          
        }
        private void dIASFERIADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiasFeriados obj = new frmDiasFeriados();
            obj.Show();
        }
    }
}
