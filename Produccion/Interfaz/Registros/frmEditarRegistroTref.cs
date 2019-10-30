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
        clsProduccionGalv PG = new clsProduccionGalv();
        clsCliente C = new clsCliente();
        public string Producto;
        public string Supervisor;
        public string Operador;
        public string Ayudante;
        public string Maquina;
        public string Cliente;
        public int Id;
        public string Peso;
        private void ComboP()
        {
            try
            {
                if (Program.Editar == 0)
                {
                    cmbProducto.DataSource = P.Listado_Productos_Dpto(1);

                }
                else if (Program.Editar == 1)
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

                if (Program.Editar == 0)
                {
                     cmbCliente.DataSource = C.Listado_Cliente_Combo(true, "Tref");

                }
                else if (Program.Editar == 1)
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
                if (Program.Editar == 0)
                {
                    cmbMaquina.DataSource = M.Listado_Maquinas_Tref();
                }
                else if (Program.Editar == 1)
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
        private void ComboO()
        {
            try
            {
                if (Program.Editar == 0)
                {
                    cmbOperador.DataSource = E.Listado_Operadores_Tref();
                }
                else if (Program.Editar == 1)
                {
                    cmbOperador.DataSource = E.Listado_Operadores_Galv();
                }
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
                if (Program.Editar == 0)
                {
                    cmbAyudante.DataSource = E.Listado_Ayudantes_Galv();
                }
                else if (Program.Editar == 1)
                {
                    cmbAyudante.DataSource = E.Listado_Ayudantes_Galv();
                }
                cmbAyudante.DisplayMember = "NOMBRE";
                cmbAyudante.ValueMember = "ID_EMPLEADO";
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
                if (Program.Editar == 0)
                {
                    cmbSupervisor.DataSource = E.Listado_Supervisores_Tref();

                }
                else if (Program.Editar == 1)
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

        private void frmEditarRegistroTref_Load(object sender, EventArgs e)
        {
            ComboP();
            ComboM();
            ComboO();
            ComboS();
            ComboC();
            ComboA();
            LlenarCampos();
            if (Program.Editar == 0)
            {
                cmbAyudante.Enabled = false;
            }
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
                cmbAyudante.Text = Ayudante;
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
                if(Program.Editar==0)
                {
                    PT.Id = Id;
                    PT.Supervisor = cmbSupervisor.SelectedValue.ToString().Trim();
                    PT.Operador = cmbOperador.SelectedValue.ToString().Trim();
                    PT.Maquina = cmbMaquina.SelectedValue.ToString().Trim();
                    PT.Producto = cmbProducto.SelectedValue.ToString().Trim();
                    PT.Cliente = Convert.ToInt32(cmbCliente.SelectedValue);
                    PT.PesoNeto = Convert.ToDouble(txtPeso.Text.Trim());
                    PT.Dpto = "Trefilado";
                    PT.Idusuario = Program.Idusuario;
                    PT.Pcname = Environment.MachineName;
                    mensaje = PT.ActualizarRegistroDpto();
                }
                else if (Program.Editar == 1)
                {
                    PG.Id = Id;
                    PG.Supervisor = cmbSupervisor.SelectedValue.ToString().Trim();
                    PG.Operador = cmbOperador.SelectedValue.ToString().Trim();
                    PG.Ayudante= cmbAyudante.SelectedValue.ToString().Trim();
                    PG.Maquina = cmbMaquina.SelectedValue.ToString().Trim();
                    PG.Producto = cmbProducto.SelectedValue.ToString().Trim();
                    PG.Cliente = Convert.ToInt32(cmbCliente.SelectedValue);
                    PG.PesoNeto = Convert.ToDouble(txtPeso.Text.Trim());
                    PG.Dpto = "Galvanizado";
                    PG.Idusuario = Program.Idusuario;
                    PG.Pcname = Environment.MachineName;
                    mensaje = PG.ActualizarRegistroDpto();
                    PG.Id = 0;
                    PG.Supervisor = "";
                    PG.Operador = "";
                    PG.Ayudante = "";
                    PG.Maquina = "";
                    PG.Producto = "";
                    PG.Cliente = 0;
                    PG.PesoNeto = 0;
                    PG.Dpto = "";
                }
               
                if (mensaje =="1")
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
            catch(Exception ex)
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
    }
}
