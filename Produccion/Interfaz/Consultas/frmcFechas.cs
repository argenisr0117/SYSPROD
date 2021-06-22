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

namespace Interfaz.Consultas
{
    public partial class frmcFechas : MetroForm
    {
        public frmcFechas()
        {
            InitializeComponent();
        }

        private void frmcFechas_Load(object sender, EventArgs e)
        {

        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            if (dtpdesde.Value.Date <= dtphasta.Value.Date)
            {
                Program.Valor2 = 1;
                Program.Fechai = dtpdesde.Value;
                Program.Fechaf = dtphasta.Value;
<<<<<<< HEAD
                Close();
=======
                this.Close();
>>>>>>> bf1dba918529b9e8fe8f30955f8e6ec0e9182058
            }
            else return;
         
        }
    }
}
