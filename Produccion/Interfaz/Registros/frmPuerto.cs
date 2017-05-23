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
        public frmPuerto()
        {
            InitializeComponent();
        }

        public string PortName;
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if(cmbPuerto.SelectedIndex >-1 && cmbSpeed.SelectedIndex >-1)
            {
            string mensaje = "";
            PT.Puerto = cmbPuerto.Text;
            PT.Id = 1;
            PT.Baud = Convert.ToInt32(cmbSpeed.SelectedItem);
            try
            {
                mensaje = PT.ActualizarPuerto();
                if (mensaje == "1")
                {
                    MessageBoxEx.Show("Configuración Actualizada", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConfiguracionActual();
                    Program.Valor3 = 1;
                    this.Close();
                }
            }
            catch(Exception ex)
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
            ConfiguracionActual();
           
        }
        private void ConfiguracionActual()
        {
            DataTable dt = new DataTable();
            dt=PT.Configuracion_Puerto();
            try
            {
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    lbPort.Text = dt.Rows[x][1].ToString();
                    lbBaud.Text = dt.Rows[x][2].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
