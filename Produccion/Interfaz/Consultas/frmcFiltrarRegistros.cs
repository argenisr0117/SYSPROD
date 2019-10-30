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
    public partial class frmcFiltrarRegistros : MetroForm
    {
        public frmcFiltrarRegistros()
        {
            InitializeComponent();
        }

        clsProducto P = new clsProducto();
        clsEmpleado E = new clsEmpleado();
        clsMaquina M = new clsMaquina();
        clsProduccionTref PT = new clsProduccionTref();
        clsProduccionGalv PG = new clsProduccionGalv();
        clsCliente C = new clsCliente();

        private void ComboP()
        {
            try
            {
                if(Program.Filtrar==0)
                {
                    cmbProducto.DataSource = P.Listado_Productos_Dpto(1);

                }
                else if(Program.Filtrar==1)
                {
                    cmbProducto.DataSource = P.Listado_Productos_Dpto(5);
                }
                cmbProducto.DisplayMember = "DESCRIPCION";
                cmbProducto.ValueMember = "CODIGO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void ComboC()
        {
            try
            {
                if (Program.Filtrar == 0)
                {
                    cmbCliente.DataSource = C.Listado_Cliente_Combo(true, "Tref");

                }
                else if (Program.Filtrar == 1)
                {
                    cmbCliente.DataSource = C.Listado_Cliente_Combo(true, "Galv");

                }
                cmbCliente.DisplayMember = "DESCRIPCION";
                cmbCliente.ValueMember = "ID_CLIENTE";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void ComboM()
        {
            try
            {
                if (Program.Filtrar == 0)
                {
                    cmbMaquina.DataSource = M.Listado_Maquinas_Tref();

                }
                else if (Program.Filtrar == 1)
                {
                    cmbMaquina.DataSource = M.Listado_Maquinas_Galv();

                }
                cmbMaquina.DisplayMember = "ID_MAQUINA";
                cmbMaquina.ValueMember = "ID_MAQUINA";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void ComboS()
        {
            try
            {
                if (Program.Filtrar == 0)
                {
                    cmbSupervisor.DataSource = E.Listado_Supervisores_Tref();

                }
                else if (Program.Filtrar == 1)
                {
                    cmbSupervisor.DataSource = E.Listado_Supervisores_Galv();

                }
                cmbSupervisor.DisplayMember = "NOMBRE";
                cmbSupervisor.ValueMember = "ID_EMPLEADO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void frmcFiltrarRegistros_Load(object sender, EventArgs e)
        {
            ComboS();
            ComboC();
            ComboM();
            ComboP();
            Limpiar();
            dtpdesde.Value = Program.Fechai;
            dtphasta.Value = Program.Fechaf;
        }
        private void Limpiar()
        {
            cmbProducto.SelectedValue = "";
            cmbMaquina.SelectedValue = "";
            cmbCliente.SelectedValue = 0;
            cmbSupervisor.SelectedValue = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            int diferencia = 0;
            TimeSpan fechas = new TimeSpan();
            DateTime fechaft = dtphasta.Value.AddDays(-1);
            if (dtpdesde.Value.Date < dtphasta.Value.Date)
            {
                fechas = dtphasta.Value.Date - dtpdesde.Value.Date;
                diferencia = fechas.Days;
                if (diferencia > 1)
                {
                    Program.Fechai = dtpdesde.Value;
                    Program.Fechaft= fechaft;
                    Program.Fechaf = dtphasta.Value;
                    //Limpiar();   
                }
                else
                {
                    Program.Fechai = dtpdesde.Value;
                    Program.Fechaf = dtphasta.Value;
                    Program.Fechaft = Convert.ToDateTime("1/1/1753 12:00:00 AM");
                    //Limpiar();

                }
                try
                {
                    if (cmbSupervisor.SelectedIndex > -1)
                    {
                        Program.Supervisor = cmbSupervisor.SelectedValue.ToString().Trim();
                    }
                    else
                    {
                        PT.Supervisor = "";
                    }
                    if (cmbMaquina.SelectedIndex > -1)
                    {
                        Program.Maquina = cmbMaquina.SelectedValue.ToString().Trim();
                    }
                    else
                    {
                        PT.Maquina = "";
                    }

                    Program.Cliente = Convert.ToInt32(cmbCliente.SelectedValue);
                    if (cmbProducto.SelectedIndex > -1)
                    {
                        Program.Producto = cmbProducto.SelectedValue.ToString().Trim();
                    }
                    else
                    {
                        PT.Producto = "";
                    }

                    Program.Valor = 1;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBoxEx.Show("Fecha inicial mayor que Fecha final", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }
    }
}
