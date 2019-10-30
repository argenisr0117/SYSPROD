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
using Intermedia;
using DevComponents.DotNetBar;

namespace Interfaz.Registros
{
    public partial class frmAgregarProducto : MetroForm
    {
        clsDestino D = new clsDestino();
        clsEmpleado E = new clsEmpleado();
        clsMaquina M = new clsMaquina();
        clsProducto P = new clsProducto();
        clsTurno T = new clsTurno();
        clsProduccion Pr = new clsProduccion();
        public DataTable dt = new DataTable();
        clsCliente C = new clsCliente();
        public string reporte
        {
            get;set;
        }
        
        public frmAgregarProducto()
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
        private void ComboO()
        {
            try
            {
                cboperador.DataSource = E.ListarO(true, true);
                cboperador.DisplayMember = "NOMBRE";
                cboperador.ValueMember = "ID_EMPLEADO";
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
                cbayudante.DataSource = E.ListarA(true, true);
                cbayudante.DisplayMember = "NOMBRE";
                cbayudante.ValueMember = "ID_EMPLEADO";
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
        private void ComboT()
        {
            try
            {
                cbturno.DataSource = T.Listar(true);
                cbturno.DisplayMember = "ID_TURNO";
                cbturno.ValueMember = "ID_TURNO";
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
                cbproducto.DisplayMember = "DESCRIPCION";
                cbproducto.ValueMember = "CODIGO";
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
                cmbCliente.DataSource = C.Listar(true);
                cmbCliente.DisplayMember = "DESCRIPCION";
                cmbCliente.ValueMember = "ID_CLIENTE";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void SecuenciaTarjeta()
        {
            try
            {
                int var=1;
                int var1=1;
                int var2=1;
                int var3=1;
                int max = 0;
                int[] valores = new int[3];
                valores = Pr.SecuenciaTarjeta();
                var=  valores[0];
                var1 = valores[1];
                var2 = valores[2];
                if (var==0 && var1==0 && var2==0)
                {
                    txttarjeta.Text ="0";       
                    SendKeys.Send("{TAB}");
                }
                else
                {
                    max = var;
                    if(var1>=max)
                    {
                        max = var1;
                    }
                    if(var2>=max)
                    {
                        max = var2;
                        if(var1>=var2)
                        {
                            max = var1;
                        }
                    }
                    var3 = max + 1;
                    txttarjeta.Text = var3.ToString();
                    SendKeys.Send("{TAB}");
                }

            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }

        }

        private void frmAgregarProducto_Load(object sender, EventArgs e)
        {
            SecuenciaTarjeta();
            ComboA();
            cbayudante.SelectedValue = "";
            ComboD();
            cbdestino.SelectedValue = "";
            ComboM();
            cbmaquina.SelectedValue = "";
            ComboS();
            cbsupervisor.SelectedValue = "";
            ComboO();
            cboperador.SelectedValue = "";
            ComboT();
            cbturno.SelectedValue = "";
            ComboP();
            cbproducto.SelectedValue = "";
            ComboC();
            cmbCliente.SelectedIndex = -1;
            Program.Evento = 0;
            dt.Columns.Add("Fecha");
            dt.Columns.Add("Supervisor");
            dt.Columns.Add("Operador");
            dt.Columns.Add("Ayudante");
            dt.Columns.Add("Turno");
            dt.Columns.Add("Tarjeta");
            dt.Columns.Add("Maquina");
            dt.Columns.Add("Producto");
            dt.Columns.Add("Destino");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Cliente");
            dtpfecha.Value = DateTime.Now;
            txttarjeta.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("¿Desea Salir?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            cbsupervisor.SelectedValue = "";
            cboperador.SelectedValue = "";
            cbayudante.SelectedValue = "";
            cbturno.SelectedValue = "";
            txttarjeta.Clear();
            cbmaquina.SelectedValue = "";
            cbproducto.SelectedValue = "";
            cbdestino.SelectedValue = "";
            cmbCliente.SelectedIndex = -1;
            txtcantidad.Clear();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Consultas.frmcProducto obj = new Consultas.frmcProducto();
            obj.lbinf.Text = "Doble click para seleccinar";
            obj.lbinf.Visible = true;
            obj.ShowDialog();
            if (Program.Evento == 1)
            {
                cbproducto.SelectedValue = Program.CodigoP;
            }
            Program.Evento = 0;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Utilidades.ValidarCombo(this, errorProvider1)==false)
            {
                return;
            }
            else
            {
                //frmProduccion obj = new frmProduccion();
                //DataRow nf = dt.NewRow();
                //nf[0] = dtpfecha.Text;
                //nf[1] = cbsupervisor.SelectedValue;
                //nf[2] = cboperador.SelectedValue;
                //nf[3] = cbayudante.SelectedValue;
                //nf[4] = cbturno.SelectedValue;
                //nf[5] = txttarjeta.Text.ToString();
                //nf[6] = cbmaquina.SelectedValue;
                //nf[7] = cbproducto.SelectedValue;
                //nf[8] = cbdestino.SelectedValue;
                //nf[9] = txtcantidad.Text;
                //dt.Rows.Add(nf);
                TimeSpan ts = new TimeSpan(08, 0, 0);
                Pr.Fecha = dtpfecha.Value;
                Pr.Hora = ts;
                Pr.Supervisor = cbsupervisor.SelectedValue.ToString();
                Pr.Operador = cboperador.SelectedValue.ToString();
                Pr.Ayudante = cbayudante.SelectedValue.ToString();
                Pr.Turno = cbturno.SelectedValue.ToString();
                Pr.Tarjeta = txttarjeta.Text.ToString();
                Pr.Maquina = cbmaquina.SelectedValue.ToString();
                Pr.Producto = cbproducto.SelectedValue.ToString();
                Pr.Destino = cbdestino.SelectedValue.ToString();
                Pr.Cantidad = Convert.ToDecimal(txtcantidad.Text);
                Pr.Reporte = reporte;
                Pr.Idcliente = Convert.ToInt32(cmbCliente.SelectedValue);
                Pr.RegistrarProduccion("registrar_produccion");
                MessageBoxEx.Show("Registro Agregado", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcantidad.Clear();
                txttarjeta.Focus();
                SecuenciaTarjeta();
                SendKeys.Send("{TAB}");
                txtcantidad.Focus();
            }
        }
    }
}
