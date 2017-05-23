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
    public partial class frmEditarRegistroTref : MetroForm
    {
        public frmEditarRegistroTref()
        {
            InitializeComponent();
        }
        clsProducto P = new clsProducto();
        clsEmpleado E = new clsEmpleado();
        clsMaquina M = new clsMaquina();
        clsProduccionTref PT = new clsProduccionTref();
        clsCliente C = new clsCliente();
        public string Producto;
        public string Supervisor;
        public string Operador;
        public string Maquina;
        public string Cliente;
        public int Id;
        public string Peso;
        private void ComboP()
        {
            try
            {
                cmbProducto.DataSource = P.Listado_Productos_Dpto(1);
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
        private void ComboO()
        {
            try
            {
                cmbOperador.DataSource = E.Listado_Operadores_Tref();
                cmbOperador.DisplayMember = "NOMBRE";
                cmbOperador.ValueMember = "ID_EMPLEADO";
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
                cmbSupervisor.DataSource = E.Listado_Supervisores_Tref();
                cmbSupervisor.DisplayMember = "NOMBRE";
                cmbSupervisor.ValueMember = "ID_EMPLEADO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void frmEditarRegistroTref_Load(object sender, EventArgs e)
        {
            ComboP();
            ComboM();
            ComboO();
            ComboS();
            ComboC();
            LlenarCampos();
        }
        private void LlenarCampos()
        {
            try
            {
                cmbSupervisor.Text = Supervisor;
                cmbOperador.Text = Operador;
                cmbMaquina.Text = Maquina;
                cmbCliente.Text = Cliente;
                cmbProducto.Text = Producto;
                txtPeso.Text = Peso;
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
          
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Utilidades.ValidarForm(this, errorProvider1) == false)
            {
                return;
            }
            string mensaje = "";
            try
            {
                PT.Id = Id;
                PT.Supervisor = cmbSupervisor.SelectedValue.ToString().Trim();
                PT.Operador = cmbOperador.SelectedValue.ToString().Trim();
                PT.Maquina = cmbMaquina.SelectedValue.ToString().Trim();
                PT.Producto = cmbProducto.SelectedValue.ToString().Trim();
                PT.Cliente = Convert.ToInt32(cmbCliente.SelectedValue);
                PT.PesoNeto = Convert.ToDouble(txtPeso.Text.Trim());
                PT.Dpto = "Trefilado";
                mensaje = PT.ActualizarRegistroDpto();
                if (mensaje =="1")
                {
                    MessageBoxEx.Show("Actualizado correctamente!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBoxEx.Show("Ha ocurrido un error!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                Program.Valor = 1;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("¿Desea Salir?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
            }
        }
    }
}
