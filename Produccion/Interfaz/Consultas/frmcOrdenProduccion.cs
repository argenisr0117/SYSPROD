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
    public partial class frmcOrdenProduccion : MetroForm
    {
        clsOrdenProduccion O = new clsOrdenProduccion();
        public frmcOrdenProduccion()
        {
            InitializeComponent();
        }
        private void LlenarGrid()
        {
            try
            {
                DataTable dt = new DataTable();
                if (cmbEstado.SelectedIndex == 0)
                {
                    dt = O.ListadoOrdenes(false);
                }
                else
                {
                    dt = O.ListadoOrdenes(true);
                }
                dtgOrdenes.DataSource = null;
                dtgOrdenes.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void frmcOrdenProduccion_Load(object sender, EventArgs e)
        {
            cmbEstado.SelectedIndex = 1;
            LlenarGrid();
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarGrid();
        }
    }

   
}
