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
    public partial class frmOrdenProduccion : MetroForm
    {
        clsProducto P = new clsProducto();
        clsCliente C = new clsCliente();
        clsDepartamento D = new clsDepartamento();
        clsOrdenProduccion O = new clsOrdenProduccion();
        public string dpto = "";
        public int dpt = 0;
        public frmOrdenProduccion()
        {
            InitializeComponent();
        }
        private void ComboP()
        {
            try
            {
                cmbProducto.DataSource = P.Listado_Productos_Dpto(dpt);
                cmbProducto.DisplayMember = "DESCRIPCION";
                cmbProducto.ValueMember = "CODIGO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void ComboT()
        {
            try
            {
                cmbTipo.DataSource = O.ListadoTipoOrden(true);
                cmbTipo.DisplayMember = "DESCRIPCION";
                cmbTipo.ValueMember = "ID_TIPO";
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
                cmbCliente.DataSource = C.Listado_Cliente_Combo(true, dpto);
                cmbCliente.DisplayMember = "DESCRIPCION";
                cmbCliente.ValueMember = "ID_CLIENTE";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void ComboD()
        {
            try
            {
                cmbDpto.DataSource = D.Listar(true);
                cmbDpto.DisplayMember = "DEPARTAMENTO";
                cmbDpto.ValueMember = "ID_DPTO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }

        }
        private void NumeroPedido()
        {
            string pedido = O.ObtenerNumeroPedido();
            txtNumeroPedido.Text = pedido;
        }
        private void frmOrdenProduccion_Load(object sender, EventArgs e)
        {
            dpt = 5;
            ComboD();
            ComboC();
            ComboP();
            ComboT();
            if (Program.Valor == 5)
            {
                txtNumOrden.Text = Program.Orden;
                txtCantidad.Text = Program.Cantidad.ToString();
                txtNumeroPedido.Text = Program.Pedido;
                //Console.Write(Program.Cliente1);
                cmbCliente.Text = Program.Cliente1;
                cmbDpto.Text = Program.Dpto;
                cmbProducto.Text = Program.Producto;
                cmbTipo.SelectedValue = Program.Idtipoorden;
                txtNumOrden.Enabled = false;
                cmbProducto.Enabled = false;
                cmbDpto.Enabled = false;
                cmbCliente.Enabled = false;
                btnBuscar.Enabled = false;
                txtCantidad.Focus();
            }
            else
            {
                NumeroPedido();
                //cmbCliente.Enabled = false;
                cmbCliente.SelectedIndex = -1;
                cmbDpto.SelectedValue = "Galv";
                cmbProducto.SelectedValue = "";
                cmbTipo.SelectedIndex = -1;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Consultas.frmcProducto obj = new Consultas.frmcProducto();
            obj.lbinf.Text = "Doble click para seleccinar";
            obj.lbinf.Visible = true;
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

        private void cmbDpto_SelectedValueChanged(object sender, EventArgs e)
        {
            dpto = cmbDpto.SelectedValue.ToString();
            ComboC();
            if (Program.Valor == 5)
            {
                cmbCliente.Text = Program.Cliente1;
            }
            else
            {
                cmbCliente.SelectedIndex = -1;
            }
            if (dpto == "Tref")
            {
                dpt = 1;
                ComboP();
            }
            else if(dpto == "Galv")
            {
                dpt = 5;
                ComboP();
            }
            else if (dpto == "IndM")
            {
                dpt = 2;
                ComboP();
            }
        }

        private void Limpiar()
        {
            txtCantidad.Clear();
            txtNumOrden.Clear();
            cmbCliente.SelectedIndex = -1;
            cmbProducto.SelectedValue = "";
            cmbDpto.SelectedValue = "Galv";
            cmbTipo.SelectedIndex = -1;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Utilidades.ValidarForm(this, errorProvider1) == false)
            {
                return;
            }
            bool mensaje;
            try
            {               
                if(cmbCliente.SelectedIndex!=-1 && cmbProducto.SelectedValue.ToString() != "" && cmbTipo.SelectedIndex!=-1)
                {
                    O.Numorden = txtNumOrden.Text;
                    O.Idusuario = Program.Idusuario;
                    O.Cliente = Convert.ToInt16(cmbCliente.SelectedValue);
                    O.Dpto = cmbDpto.SelectedValue.ToString();
                    O.Producto = cmbProducto.SelectedValue.ToString();
                    O.Cantidad = Convert.ToDouble(txtCantidad.Text);
                    O.Pedido = txtNumeroPedido.Text;
                    O.Idtipo= Convert.ToInt16(cmbTipo.SelectedValue);
                    if (Program.Valor == 5)
                    {
                        mensaje = O.ActualizarOrdenProduccion();
                        if (mensaje == true)
                        {

                            MessageBoxEx.Show("Ordén actualizada", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                            Program.Valor = 0;
                            this.Close();
                        }
                        else
                        {
                            MessageBoxEx.Show("Cantidad no puede ser menor a lo ya producido", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        mensaje = O.RegistrarOrdenProduccion();
                        if (mensaje == true)
                        {

                            MessageBoxEx.Show("Ordén registrada", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                            NumeroPedido();
                        }
                        else
                        {
                            MessageBoxEx.Show("Error\nNúmero de ordén ya existe", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    
                }
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
    }
}
