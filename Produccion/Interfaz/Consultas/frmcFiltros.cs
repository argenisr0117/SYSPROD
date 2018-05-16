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
                cmbCliente.DataSource = C.Listar(true);
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
                cmbMaquina.DataSource = M.Listar(true);
                cmbMaquina.DisplayMember = "DESCRIPCION";
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
        private void ComboA()
        {
            try
            {
                cmbAyudante.DataSource = E.ListarA(true, true);
                cmbAyudante.DisplayMember = "NOMBRE";
                cmbAyudante.ValueMember = "ID_EMPLEADO";
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

        //private void btnFiltrar_Click(object sender, EventArgs e)
        //{
        //    int diferencia = 0;
        //    TimeSpan fechas = new TimeSpan();
        //    DateTime fechaft = dtphasta.Value.AddDays(-1);
        //    if (dtpdesde.Value.Date < dtphasta.Value.Date)
        //    {
        //        fechas = dtphasta.Value.Date - dtpdesde.Value.Date;
        //        diferencia = fechas.Days;
        //        if (diferencia > 1)
        //        {
        //            Program.Fechai = dtpdesde.Value;
        //            Program.Fechaft = fechaft;
        //            Program.Fechaf = dtphasta.Value;
        //            //Limpiar();   
        //        }
        //        else
        //        {
        //            Program.Fechai = dtpdesde.Value;
        //            Program.Fechaf = dtphasta.Value;
        //            Program.Fechaft = Convert.ToDateTime("1/1/1753 12:00:00 AM");
        //            //Limpiar();

        //        }
        //        try
        //        {
        //            if (cmbSupervisor.SelectedIndex > -1)
        //            {
        //                Program.Supervisor = cmbSupervisor.SelectedValue.ToString().Trim();
        //            }
        //            else
        //            {
        //                PT.Supervisor = "";
        //            }
        //            if (cmbMaquina.SelectedIndex > -1)
        //            {
        //                Program.Maquina = cmbMaquina.SelectedValue.ToString().Trim();
        //            }
        //            else
        //            {
        //                PT.Maquina = "";
        //            }

        //            Program.Cliente = Convert.ToInt32(cmbCliente.SelectedValue);
        //            if (cmbProducto.SelectedIndex > -1)
        //            {
        //                Program.Producto = cmbProducto.SelectedValue.ToString().Trim();
        //            }
        //            else
        //            {
        //                PT.Producto = "";
        //            }

        //            Program.Valor = 1;
        //            this.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        }
        //    }
        //    else
        //    {
        //        MessageBoxEx.Show("Fecha inicial mayor que Fecha final", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}

        private void frmcFiltros_Load(object sender, EventArgs e)
        {
            ComboS();
            ComboA();
            ComboC();
            ComboM();
            ComboP();
            ComboO();
            radioResumido.Checked = true;
            radioProducto.Checked=true;

            cmbSupervisor.SelectedValue = "";
            cmbProducto.SelectedValue = "";
            cmbMaquina.SelectedValue = "";
            cmbAyudante.SelectedValue = "";
            cmbOperador.SelectedValue = "";
            cmbCliente.SelectedValue = 0;
            Limpiar();
        }

        private void Limpiar()
        {
            cmbSupervisor.SelectedValue = "";
            cmbAyudante.SelectedValue = "";
            cmbProducto.SelectedValue = "";
            cmbMaquina.SelectedValue = "";
            cmbOperador.SelectedValue = "";
            cmbCliente.SelectedValue = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmcProducto obj = new frmcProducto();
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
            try
            {
                if (dtpdesde.Value.Date <= dtphasta.Value.Date)
                {
                    frmReporte obj = new frmReporte();
                    obj.Fechai = dtpdesde.Value;
                    obj.Fechaf = dtphasta.Value;
                    obj._Producto = "";
                    obj._Cliente = "";
                    obj._Maquina = "";
                    obj._Supervisor = "";
                    obj._Operador = "";
                    obj._Ayudante = "";
                    if (cmbSupervisor.SelectedIndex != -1) //(cmbSupervisor.SelectedValue != null)
                    {
                        obj.Supervisor = cmbSupervisor.SelectedValue.ToString();
                        obj._Supervisor = cmbSupervisor.Text;
                    }
                    else
                       obj.Supervisor ="0";

                    if (cmbOperador.SelectedIndex != -1) //(cmbOperador.SelectedValue != null)
                    {
                        obj.Operador = cmbOperador.SelectedValue.ToString();
                        obj._Operador = cmbOperador.Text;
                    }
                    else
                        obj.Operador ="0";

                    if (cmbMaquina.SelectedIndex != -1)// (cmbMaquina.SelectedValue != null)
                    {
                        obj.Maquina = cmbMaquina.SelectedValue.ToString();
                        obj._Maquina = cmbMaquina.Text;
                    }
                    else
                        obj.Maquina = "0";

                    if (cmbProducto.SelectedIndex != -1) //(cmbProducto.SelectedValue != null)
                    {
                        obj.Producto = cmbProducto.SelectedValue.ToString();
                        obj._Producto = cmbProducto.Text;
                    }
                    else
                        obj.Producto = "0";

                    if (cmbCliente.SelectedIndex != -1 ) //(cmbCliente.SelectedValue != null)
                    {
                        obj.Cliente = cmbCliente.SelectedValue.ToString();
                        obj._Cliente = cmbCliente.Text;
                    }
                    else
                        obj.Cliente = "0";
                    if (cmbAyudante.SelectedIndex != -1) //(cmbProducto.SelectedValue != null)
                    {
                        obj.Ayudante = cmbAyudante.SelectedValue.ToString();
                        obj._Ayudante = cmbAyudante.Text;
                    }
                    else
                        obj.Ayudante = "0";

                    if (radioDetallado.Checked)
                    {
                        obj.Valor = 10;
                        obj.Nombre = "filtrar_prod_detalle.rdlc";
                        obj.Order1 = "1";
                    }
                    else if (radioResumido.Checked)
                    {
                        obj.Valor = 21;
                        obj.Nombre = "filtrar_prod_resumido.rdlc";
                        obj.gProducto = "0";
                        obj.gCliente = "0";
                        obj.gMaquina = "0";
                        obj.gSupervisor = "0";
                        obj.gOperador = "0";
                        obj.gAyudante = "0";
                  
                        if (radioCliente.Checked)
                        {
                            obj.gCliente = "1";
                        }
                        else if (radioOperador.Checked)
                        {
                            obj.gOperador = "1";
                        }
                        else if (radioSupervisor.Checked)
                        {
                            obj.gSupervisor = "1";
                        }
                        else if (radioMaquina.Checked)
                        {
                            obj.gMaquina = "1";
                        }
                        else if (radioProducto.Checked)
                        {
                            obj.gProducto = "1";
                            obj.gAyudante = "1";
                        }
                    }
                    obj.Show();
                    //obj.Operador = cmbOperador.SelectedValue.ToString();
                    //obj.Maquina = cmbMaquina.SelectedValue.ToString();
                    //obj.Producto =cmbProducto.SelectedValue.ToString();
                    //obj.Cliente =cmbCliente.SelectedValue.ToString();
                }
                else
                {
                    MessageBoxEx.Show("Fecha inicial mayor que Fecha final", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}