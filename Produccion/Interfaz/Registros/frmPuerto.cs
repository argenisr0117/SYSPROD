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
using System.IO.Ports;
using Intermedia;

namespace Interfaz.Registros
{
    public partial class frmPuerto : MetroForm
    {
        clsProduccionTref PT = new clsProduccionTref();
        clsDepartamento D = new clsDepartamento();
        public frmPuerto()
        {
            InitializeComponent();
        }
        private void LlenarCombo()
        {

            cmbDpto.DataSource = D.Listar(true);
            cmbDpto.DisplayMember = "DEPARTAMENTO";
            cmbDpto.ValueMember = "ID_DPTO";


        }
        public string PortName;
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (cmbPuerto.SelectedIndex > -1 && cmbSpeed.SelectedIndex > -1)
            {
                string mensaje = "";
                PT.Puerto = cmbPuerto.Text;
                PT.Id = Program.Idpuerto;
                PT.Baud = Convert.ToInt32(cmbSpeed.SelectedItem);
                PT.Iddpto = cmbDpto.SelectedValue.ToString();
                try
                {
                    mensaje = PT.ActualizarPuerto();
                    if (mensaje == "1")
                    {
                        MessageBoxEx.Show("Configuración Actualizada", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ConfiguracionActual();
                        Program.Valor3 = 1;
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBoxEx.Show("Campos vacios, completelos!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmPuerto_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cmbPuerto.Items.Add(port);

            }
            LlenarCombo();
            cmbDpto.SelectedValue = "Tref";
            ConfiguracionActual();
            //cmbDpto.Enabled = false;
        }
        private void ConfiguracionActual()
        {
            DataTable dt = new DataTable();
            dt = PT.Configuracion_Puerto(cmbDpto.SelectedValue.ToString());
            Program.Idpuerto = 0;
            lbPort.Text = "";
            lbBaud.Text = "";
            try
            {
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    Program.Idpuerto = Convert.ToInt16(dt.Rows[x][0]);
                    lbPort.Text = dt.Rows[x][1].ToString();
                    lbBaud.Text = dt.Rows[x][2].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbDpto_SelectedValueChanged(object sender, EventArgs e)
        {
            ConfiguracionActual();
        }
    }
}
