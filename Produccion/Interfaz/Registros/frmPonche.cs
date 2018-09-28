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
    public partial class frmPonche : MetroForm
    {
        AttendanceClass Att = new AttendanceClass();
        clsPonche P = new clsPonche();
        public frmPonche()
        {
            InitializeComponent();
            RealTime_Dtg.Columns[2].Width = 125;
        }

        private void btnTCPConnect_Click(object sender, EventArgs e)
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

                        btnTCPConnect.Text = "DESCONECTAR";
                        btnTCPConnect.Refresh();
                        cONECTARToolStripMenuItem.Enabled = false;
                        dESCONECTARToolStripMenuItem.Enabled = true;
                        dESCARGARREGISTROSToolStripMenuItem.Enabled = true;
                        bORRARREGISTROSToolStripMenuItem.Enabled = true;

                    }
                    else if (ret == -2)
                    {
                        btnTCPConnect.Text = "CONECTAR";
                        btnTCPConnect.Refresh();
                        cONECTARToolStripMenuItem.Enabled = true;
                        dESCONECTARToolStripMenuItem.Enabled = false;
                        dESCARGARREGISTROSToolStripMenuItem.Enabled = false;
                        bORRARREGISTROSToolStripMenuItem.Enabled = false;
                    }
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
        }

        private void cONECTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnTCPConnect_Click(e, e);
        }

        private void dESCONECTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnTCPConnect_Click(e, e);
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
                dt_period.Columns.Add("Count", System.Type.GetType("System.Int32"));
                dt_period.Columns.Add("User ID", System.Type.GetType("System.String"));
                dt_period.Columns.Add("Verify Date", System.Type.GetType("System.String"));
                dt_period.Columns.Add("Verify Type", System.Type.GetType("System.Int32"));
                dt_period.Columns.Add("Verify State", System.Type.GetType("System.Int32"));
                dt_period.Columns.Add("WorkCode", System.Type.GetType("System.Int32"));
                Attlog_Dtg.DataSource = dt_period;

                Att.sta_readAttLog(lbSysOutputInfo, dt_period);
                Cursor = Cursors.Default;
            }
        }
    }
}
