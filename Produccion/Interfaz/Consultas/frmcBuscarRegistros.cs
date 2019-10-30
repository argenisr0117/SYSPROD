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
    public partial class frmcBuscarRegistros : MetroForm
    {
        clsDestino D = new clsDestino();
        clsEmpleado E = new clsEmpleado();
        clsMaquina M = new clsMaquina();
        clsProducto P = new clsProducto();
        clsTurno T = new clsTurno();
        clsProduccion Pr = new clsProduccion();
        public DataTable dt = new DataTable();
        public DataTable dt3 = new DataTable();
        public string reporte
        {
            get;set;
        }
        public frmcBuscarRegistros()
        {
            InitializeComponent();
        }
        private void ComboD()
        {
            try
            {
                cbdestino.DataSource = D.Listar(true);
                cbdestino.DisplayMember = "DESTINO";
                cbdestino.ValueMember = "DESTINO";
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
                cbsupervisor.DataSource = E.ListarS(true, true);
                cbsupervisor.DisplayMember = "NOMBRE";
                cbsupervisor.ValueMember = "ID_EMPLEADO";
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
                cbmaquina.DataSource = M.Listar(true);
                cbmaquina.DisplayMember = "ID_MAQUINA";
                cbmaquina.ValueMember = "ID_MAQUINA";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void ComboP()
        {
            try
            {
                cbproducto.DataSource = P.Listar(true);
                cbproducto.DisplayMember = "CODIGO";
                cbproducto.ValueMember = "CODIGO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            cbsupervisor.SelectedValue = "";
            txttarjeta.Clear();
            cbmaquina.SelectedValue = "";
            cbproducto.SelectedValue = "";
            cbdestino.SelectedValue = "";
            txtcantidad.Clear();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            frmcProducto obj = new frmcProducto();
            obj.lbinf.Text = "Doble click para seleccinar";
            obj.lbinf.Visible = true;
            obj.ShowDialog();
            if (Program.Evento == 1)
            {
                cbproducto.SelectedValue = Program.CodigoP;
            }
            Program.Evento = 0;
        }
        private void BuscarRegistros()
        {
            try
            {
                if (Convert.ToBoolean(cbsupervisor.SelectedIndex == -1))
                {
                    Pr.Supervisor = "";
                }
                else
                {
                    Pr.Supervisor = cbsupervisor.SelectedValue.ToString();
                }
                if (Convert.ToBoolean(cbmaquina.SelectedIndex == -1))
                {
                    Pr.Maquina = "";
                }
                else
                {
                    Pr.Maquina = cbmaquina.SelectedValue.ToString();
                }
                if (Convert.ToBoolean(cbproducto.SelectedIndex == -1))
                {
                    Pr.Producto = "";
                }
                else
                {
                    Pr.Producto = cbproducto.SelectedValue.ToString();
                }
                if (Convert.ToBoolean(cbdestino.SelectedIndex == -1))
                {
                    Pr.Destino = "";
                }
                else
                {
                    Pr.Destino = cbdestino.SelectedValue.ToString();
                }

                if (string.IsNullOrEmpty(txttarjeta.Text))
                {
                    Pr.Tarjeta = "";
                }
                else
                {
                    Pr.Tarjeta = txttarjeta.Text;
                }
                Pr.Reporte = reporte;
                dt3 = Pr.BuscarRegistro();
                if (dt3.Rows.Count > 0)
                {
                    MessageBoxEx.Show("Se mostraran los registros", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    Program.Valor = 0;
                    MessageBoxEx.Show("No se han encontrado registros!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
            Program.Valor = 0;
        }

        private void frmcBuscarRegistros_Load(object sender, EventArgs e)
        {
            ComboD();
            cbdestino.SelectedValue = "";
            ComboM();
            cbmaquina.SelectedValue = "";
            ComboS();
            cbsupervisor.SelectedValue = "";
            ComboP();
            cbproducto.SelectedValue = "";
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("¿Desea Salir?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Dispose();
                Close();
            }
        }

        private void btnbuscar2_Click(object sender, EventArgs e)
        {
            BuscarRegistros();
        }
    }
}
