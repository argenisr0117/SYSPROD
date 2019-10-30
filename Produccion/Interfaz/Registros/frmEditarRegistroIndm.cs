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
    public partial class frmEditarRegistroIndm : MetroForm
    {
        public frmEditarRegistroIndm()
        {
            InitializeComponent();
        }
        clsProducto P = new clsProducto();
        clsEmpleado E = new clsEmpleado();
        clsMaquina M = new clsMaquina();
        clsProduccionIndM Pi = new clsProduccionIndM();
        public string Producto;
        public string Ayudante;
        public string Operador;
        public string Maquina;
        public string Cliente;
        public int Tarjeta;
        public decimal Peso;
        private void ComboP()
        {
            try
            {
                cmbProducto.DataSource = P.Listado_Productos_Dpto(2);
                cmbProducto.DisplayMember = "DESCRIPCION";
                cmbProducto.ValueMember = "CODIGO";
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
                cmbMaquina.DataSource = M.Listado_Maquinas_IndMenor();
                cmbMaquina.DisplayMember = "DESCRIPCION";
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
                cmbOperador.DataSource = E.ListarOA();
                cmbOperador.DisplayMember = "NOMBRE";
                cmbOperador.ValueMember = "ID_EMPLEADO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void ComboA()
        {
            try
            {
                cmbAyudante.DataSource = E.ListarOA();
                cmbAyudante.DisplayMember = "NOMBRE";
                cmbAyudante.ValueMember = "ID_EMPLEADO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void ComboCli()
        {
            try
            {
                cmbCliente.DataSource = Pi.ListadoCliente2();
                cmbCliente.DisplayMember = "DESCRIPCION";
                cmbCliente.ValueMember = "ID_CLIENTE";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void frmEditarRegistroIndm_Load(object sender, EventArgs e)
        {
            ComboA();
            ComboM();
            ComboO();
            ComboP();
            ComboCli();
            LlenarCampos();
        }
        private void LlenarCampos()
        {
            try
            {
                cmbAyudante.Text = Ayudante;
                cmbOperador.Text = Operador;
                cmbMaquina.Text = Maquina;
                cmbProducto.Text = Producto;
                cmbCliente.Text = Cliente;
                txtPeso.Text = Peso.ToString();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("¿Desea Salir?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Dispose();
                Close();
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
                Pi.Tarjeta = Tarjeta;
                Pi.Ayudante = cmbAyudante.SelectedValue.ToString().Trim();
                Pi.Operador = cmbOperador.SelectedValue.ToString().Trim();
                Pi.Idmaquina = cmbMaquina.SelectedValue.ToString().Trim();
                Pi.Idproducto = cmbProducto.SelectedValue.ToString().Trim();
                Pi.Cantidad = Convert.ToDecimal(txtPeso.Text.Trim());
                Pi.Idcliente = Convert.ToInt16(cmbCliente.SelectedValue);
                mensaje = Pi.ActualizarRegistros();
                if (mensaje == "1")
                {
                    MessageBoxEx.Show("Actualizado correctamente!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBoxEx.Show("Ha ocurrido un error!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                Program.Valor = 1;
                Close();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
