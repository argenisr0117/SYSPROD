using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Intermedia;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar;

namespace Interfaz.Registros
{
    public partial class frmEditarInvPuas1 : MetroForm
    {
        public frmEditarInvPuas1()
        {
            InitializeComponent();
        }

        clsProducto P = new clsProducto();
        clsEmpleado E = new clsEmpleado();
        clsMaquina M = new clsMaquina();
        clsProduccionIndM Pi = new clsProduccionIndM();
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
        private void frmEditarInvPuas1_Load(object sender, EventArgs e)
        {
            ComboO();
            ComboP();
            ComboM();
            LlenarCampos();
        }

        private void LlenarCampos()
        {
            cmbOperador.Text = Program.Empleado;
            cmbMaquina.Text = Program.Maquina;
            cmbProducto.Text = Program.Producto;
            txtCantidad.Text = Program.Cantidad.ToString();
         
            cmbMaquina.Enabled = false;
            cmbOperador.Enabled = false;
            cmbProducto.Enabled = false;
            txtCantidad.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int mensaje;
            errorProvider1.Clear();
            try
            {
                if (Utilidades.ValidarForm(this, errorProvider1) == false)
                {
                    return;
                }
                Pi.Idproducto = cmbProducto.SelectedValue.ToString();
                Pi.Idmaquina = cmbMaquina.SelectedValue.ToString();
                Pi.Idempleado = cmbOperador.SelectedValue.ToString();
                Pi.Cantidad1 = Convert.ToInt32(txtCantidad.Text);
                mensaje=Pi.EditarInvPuas();
                if(mensaje==1)
                {
                    MessageBoxEx.Show("Se ha actualizado!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.Evento = 10;
                    Dispose();
                    Close();
                }
                else
                {
                    MessageBoxEx.Show("Ha ocurrido un error!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               

            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
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
    }
}
