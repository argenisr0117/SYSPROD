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
    public partial class frmcFiltros : MetroForm
    {
        public frmcFiltros()
        {
            InitializeComponent();
        }

        clsProducto P = new clsProducto();
        clsEmpleado E = new clsEmpleado();
        clsMaquina M = new clsMaquina();
        clsProduccionTref PT = new clsProduccionTref();
        clsCliente C = new clsCliente();

        private void ComboP()
        {
            try
            {
                cmbProducto.DataSource = P.Listar(true);
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
                cmbCliente.DataSource = C.Listado_Cliente_Combo(true, "Tref");
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
                cmbMaquina.DataSource = M.Listado_Maquinas_Tref();
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
                cmbSupervisor.DataSource = E.ListarS(true,true);
                cmbSupervisor.DisplayMember = "NOMBRE";
                cmbSupervisor.ValueMember = "ID_EMPLEADO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void ComboO()
        {
            try
            {
                cmbOperador.DataSource = E.ListarO(true, true);
                cmbOperador.DisplayMember = "NOMBRE";
                cmbOperador.ValueMember = "ID_EMPLEADO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
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
                    Program.Fechaft = fechaft;
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
                    this.Close();
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

        private void frmcFiltros_Load(object sender, EventArgs e)
        {
            ComboS();
            ComboC();
            ComboM();
            ComboP();
            ComboO();
            radioResumido.Checked = true;
            radioProducto.Checked=true;

            cmbSupervisor.SelectedValue = "";
            cmbProducto.SelectedValue = "";
            cmbMaquina.SelectedValue = "";
            cmbOperador.SelectedValue = "";
            cmbCliente.SelectedValue = 0;
            Limpiar();
        }

        private void Limpiar()
        {
            cmbSupervisor.SelectedValue = "";
            cmbProducto.SelectedValue = "";
            cmbMaquina.SelectedValue = "";
            cmbOperador.SelectedValue = "";
            cmbCliente.SelectedValue = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Consultas.frmcProducto obj = new Consultas.frmcProducto();
            Program.Valor3 = 1;
            Program.Valor2 = 1;
            obj.ShowDialog();
            if (string.IsNullOrEmpty(Program.CodigoP))
            {
                return;
            }
            else
            {
                cmbProducto.SelectedValue = Program.CodigoP;
            }
            Program.Evento = 0;
            Program.Valor3 = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("¿Desea Salir?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {

        }
    }
}
