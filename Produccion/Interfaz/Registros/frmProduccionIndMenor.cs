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
    public partial class frmProduccionIndMenor : MetroForm
    {
        public frmProduccionIndMenor()
        {
            InitializeComponent();
        }
        clsProducto P = new clsProducto();
        clsEmpleado E = new clsEmpleado();
        clsMaquina M = new clsMaquina();
        clsProduccionIndM Pi = new clsProduccionIndM();

        //void cmbProducto_MouseWheel(object sender, MouseEventArgs e)
        //{
        //    ((HandledMouseEventArgs)e).Handled = true;
        //}
        //void cmbProducto2_MouseWheel(object sender, MouseEventArgs e)
        //{
        //    ((HandledMouseEventArgs)e).Handled = true;
        //}
        //void cmbOperador_MouseWheel(object sender, MouseEventArgs e)
        //{
        //    ((HandledMouseEventArgs)e).Handled = true;
        //}
        //void cmbOperador2_MouseWheel(object sender, MouseEventArgs e)
        //{
        //    ((HandledMouseEventArgs)e).Handled = true;
        //}
        //void cmbMaquina_MouseWheel(object sender, MouseEventArgs e)
        //{
        //    ((HandledMouseEventArgs)e).Handled = true;
        //}
        //void cmbAyudante_MouseWheel(object sender, MouseEventArgs e)
        //{
        //    ((HandledMouseEventArgs)e).Handled = true;
        //}

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
        private void ComboP2()
        {
            try
            {
                cmbProducto2.DataSource = P.Listado_Productos_Dpto(4);
                cmbProducto2.DisplayMember = "DESCRIPCION";
                cmbProducto2.ValueMember = "CODIGO";
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
                cmbOperador2.DataSource = E.ListarOA();
                cmbOperador2.DisplayMember = "NOMBRE";
                cmbOperador2.ValueMember = "ID_EMPLEADO";
                
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
        private void Limpiar()
        {
            cmbProducto.SelectedValue = "";
            cmbMaquina.SelectedValue = "";
            cmbOperador.SelectedValue = "";
            cmbAyudante.SelectedValue = "";
            txtCantidad.Clear();
        }

        private void frmProduccionIndMenor_Load(object sender, EventArgs e)
        {
            Permisos();
            //cmbProducto.MouseWheel += new MouseEventHandler(cmbProducto_MouseWheel);
            //cmbOperador.MouseWheel += new MouseEventHandler(cmbOperador_MouseWheel);
            //cmbProducto2.MouseWheel += new MouseEventHandler(cmbProducto2_MouseWheel);
            //cmbOperador2.MouseWheel += new MouseEventHandler(cmbOperador2_MouseWheel);
            //cmbMaquina.MouseWheel += new MouseEventHandler(cmbMaquina_MouseWheel);
            //cmbAyudante.MouseWheel += new MouseEventHandler(cmbAyudante_MouseWheel);
            dtgvProduccion.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7);
            dtgvProduccion.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7);
            ComboO();
            ComboA();
            ComboP();
            ComboS();
            ComboM();
            ComboP2();
            cmbSupervisor.SelectedValue = "";
            cmbOperador2.SelectedValue = "";
            cmbAyudante.SelectedValue = "DESC-01";
            cmbAyudante.Enabled = false;
            Limpiar();
            LlenarGrid();
            Program.Valor = 0;
            try
            {
                cmbProducto2.SelectedValue = "";

            }
            catch (Exception ex)
            {

            }
            Ocultar();
            Program.Cantidad = 0;
            Program.Empleado = "";
            Program.Producto = "";
            Program.Supervisor = "";
            Program.Ayudante = "";
            Permisos();
        }
        private void Permisos()
        {
            btnEliminar.Enabled = Program.eliindm;
            btnExportar.Enabled = Program.expindm;
            btnBuscar1.Enabled = Program.mosindm;
            dtpdesde.Enabled = Program.fdesindm;
            dtphasta.Enabled = Program.fhasindm;
            btnEditar.Enabled = Program.ediindm;
        }
        private void LlenarGrid()
        {
            dtgvProduccion.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7);
            dtgvProduccion.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7);
            DataTable dt = new DataTable();
            Pi.Fecha1 = dtpdesde.Value;
            Pi.Fechaf = dtphasta.Value;
            dt = Pi.MostrarRegistros();
            try
            {
                dtgvProduccion.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgvProduccion.Rows.Add(dt.Rows[x][0]);
                    dtgvProduccion.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgvProduccion.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgvProduccion.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                    dtgvProduccion.Rows[x].Cells[3].Value = dt.Rows[x][3].ToString();
                    dtgvProduccion.Rows[x].Cells[4].Value = dt.Rows[x][4].ToString();
                    dtgvProduccion.Rows[x].Cells[5].Value = dt.Rows[x][5].ToString();
                    dtgvProduccion.Rows[x].Cells[6].Value = dt.Rows[x][6].ToString();
                }
                dtgvProduccion.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cmbProducto2_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                Ocultar();
                M.Idproducto = cmbProducto2.SelectedValue.ToString();
                dt = M.ObtenerProductoMaquina();
                if(dt.Rows.Count>=5)
                {
                    lbMaq1.Text = dt.Rows[0][1].ToString();
                    lbMaq2.Text = dt.Rows[1][1].ToString();
                    lbMaq3.Text = dt.Rows[2][1].ToString();
                    lbMaq4.Text = dt.Rows[3][1].ToString();
                    lbMaq5.Text = dt.Rows[4][1].ToString();
                    Mostrar();
                }
                else if(dt.Rows.Count>=2)
                {
                    lbMaq1.Text = dt.Rows[0][1].ToString();
                    lbMaq2.Text = dt.Rows[1][1].ToString();
                    Mostrar2();
                }            
          
            }        
            catch(Exception ex)
            {
                //MessageBoxEx.Show(ex.Message);
            }
                          
        }
        private void Mostrar()
        {
            lbMaq1.Visible = true;
            lbMaq2.Visible = true;
            lbMaq3.Visible = true;
            lbMaq4.Visible = true;
            lbMaq5.Visible = true;
            txtCantidad1.Visible = true;
            txtCantidad2.Visible = true;
            txtCantidad3.Visible = true;
            txtCantidad4.Visible = true;
            txtCantidad5.Visible = true;
        }
        private void Mostrar2()
        {
            lbMaq1.Visible = true;
            lbMaq2.Visible = true;
            txtCantidad1.Visible = true;
            txtCantidad2.Visible = true;
        }
        private void Ocultar()
        {
            lbMaq1.Visible = false;
            lbMaq2.Visible = false;
            lbMaq3.Visible = false;
            lbMaq4.Visible = false;
            lbMaq5.Visible = false;
            txtCantidad1.Visible = false;
            txtCantidad2.Visible = false;
            txtCantidad3.Visible = false;
            txtCantidad4.Visible = false;
            txtCantidad5.Visible = false;
        }

        private void Limpiar2()
        {
            txtCantidad1.Clear();
            txtCantidad2.Clear();
            txtCantidad3.Clear();
            txtCantidad4.Clear();
            txtCantidad5.Clear();
            cmbOperador2.SelectedValue = "";
            try
            {
                cmbProducto2.SelectedValue = "";

            }
            catch (Exception ex)
            {

            }
        }

        private void btnRegistrar2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string mensaje="";
            int[] array = new int[5];
            M.Idproducto = cmbProducto2.SelectedValue.ToString();
            dt = M.ObtenerProductoMaquina();
            try
            {
                if (dt.Rows.Count == 5)
                {
                    if (string.IsNullOrEmpty(txtCantidad1.Text))
                    {
                        txtCantidad1.Text = "0";
                        array[0] = Convert.ToInt32(txtCantidad1.Text);
                    }
                    else
                    {
                        array[0] = Convert.ToInt32(txtCantidad1.Text);
                    }
                    if (string.IsNullOrEmpty(txtCantidad2.Text))
                    {
                        txtCantidad2.Text = "0";
                        array[1] = Convert.ToInt32(txtCantidad2.Text);
                    }
                    else
                    {
                        array[1] = Convert.ToInt32(txtCantidad2.Text);
                    }
                    if (string.IsNullOrEmpty(txtCantidad3.Text))
                    {
                        txtCantidad3.Text = "0";
                        array[2] = Convert.ToInt32(txtCantidad3.Text);
                    }
                    else
                    {
                        array[2] = Convert.ToInt32(txtCantidad3.Text);
                    }
                    if (string.IsNullOrEmpty(txtCantidad4.Text))
                    {
                        txtCantidad4.Text = "0";
                        array[3] = Convert.ToInt32(txtCantidad4.Text);
                    }
                    else
                    {
                        array[3] = Convert.ToInt32(txtCantidad4.Text);
                    }
                    if (string.IsNullOrEmpty(txtCantidad5.Text))
                    {
                        txtCantidad5.Text = "0";
                        array[4] = Convert.ToInt32(txtCantidad5.Text);
                    }
                    else
                    {
                        array[4] = Convert.ToInt32(txtCantidad5.Text);
                    }

                    for (int x = 0; x < 5; x++)
                    {
                        Pi.Idempleado = cmbOperador2.SelectedValue.ToString();
                        Pi.Idmaquina = dt.Rows[x][2].ToString();
                        Pi.Idproducto = cmbProducto2.SelectedValue.ToString();
                        Pi.Cantidad1 = array[x];
                        mensaje = Pi.RegistrarInvPuas();

                    }
                    MessageBoxEx.Show(mensaje, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }               

                else if (dt.Rows.Count == 2)
                {
                    if (string.IsNullOrEmpty(txtCantidad1.Text))
                    {
                        txtCantidad1.Text = "0";
                        array[0] = Convert.ToInt32(txtCantidad1.Text);
                    }
                    else
                    {
                        array[0] = Convert.ToInt32(txtCantidad1.Text);
                    }
                    if (string.IsNullOrEmpty(txtCantidad2.Text))
                    {
                        txtCantidad2.Text = "0";
                        array[1] = Convert.ToInt32(txtCantidad2.Text);
                    }
                    else
                    {
                        array[1] = Convert.ToInt32(txtCantidad2.Text);
                    }
                    for (int x = 0; x < 2; x++)
                    {
                        Pi.Idempleado = cmbOperador2.SelectedValue.ToString();
                        Pi.Idmaquina = dt.Rows[x][2].ToString();
                        Pi.Idproducto = cmbProducto2.SelectedValue.ToString();
                        Pi.Cantidad1 = array[x];
                        mensaje = Pi.RegistrarInvPuas();

                    }
                    MessageBoxEx.Show(mensaje, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
            Limpiar2();
            Ocultar();       
        }
        private void cmbProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string valor;
                Pi.Idproducto = cmbProducto.SelectedValue.ToString();
                valor = Pi.VerificarCategoria();
                if (valor == "1")
                {
                    cmbAyudante.Enabled = true;
                }
                else
                {
                    cmbAyudante.Enabled = false;
                    cmbAyudante.SelectedValue = "DESC-01";
                }
            }
            catch(Exception ex)
            {

            }
           
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Consultas.frmcProductosDpto obj = new Consultas.frmcProductosDpto();
            Program.Valor3 = 2;
            Program.Valor2 = 4;
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            errorProvider1.Clear();
            DataTable dt = new DataTable();
            if (Utilidades.ValidarForm2(tabPage1, errorProvider1) == false)
            {
                return;
            }
            try
            {
                M.Idproducto = cmbProducto.SelectedValue.ToString();
                dt = M.ObtenerProductoMaquina();
                if(dt.Rows.Count>0)
                {
                    dt.Rows.Clear();
                    frmInventarioPuas obj = new frmInventarioPuas();
                    Pi.Idempleado = cmbOperador.SelectedValue.ToString();
                    Pi.Idproducto = cmbProducto.SelectedValue.ToString();
                    dt = Pi.VerificarPuasOperador();
                    if(!string.IsNullOrEmpty(dt.Rows[0][0].ToString()))
                    {
                        if (Convert.ToInt32(txtCantidad.Text) > Convert.ToInt32(dt.Rows[0][0]))
                        {
                            MessageBoxEx.Show("Cantidad excede al acumulado del operador", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCantidad.Focus();
                        }
                        else
                        {
                            Program.Cantidad = Convert.ToInt32(txtCantidad.Text);
                            Program.Empleado = cmbOperador.SelectedValue.ToString();
                            Program.Producto = cmbProducto.SelectedValue.ToString();
                            Program.Supervisor = cmbSupervisor.SelectedValue.ToString();
                            Program.Ayudante = cmbAyudante.SelectedValue.ToString();
                            obj.ShowDialog();
                            if(Program.Evento==4)
                            {
                                Limpiar();
                                LlenarGrid();
                                //tabControl1.SelectedTab = tabPage2;
                            }
                            else
                            {
                                return;
                            }
                            
                        }

                    }
                    else
                    {
                        MessageBoxEx.Show("Operador no poseé púas en invenatario!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                  

                }
             
                else
                {
                    Pi.Supervisor = cmbSupervisor.SelectedValue.ToString();
                    Pi.Operador = cmbOperador.SelectedValue.ToString();
                    Pi.Ayudante = cmbAyudante.SelectedValue.ToString();
                    Pi.Idproducto = cmbProducto.SelectedValue.ToString();
                    Pi.Destino = "TERMINADOS";
                    Pi.Idmaquina = cmbMaquina.SelectedValue.ToString();
                    Pi.Cantidad = Convert.ToDecimal(txtCantidad.Text);
                    mensaje = Pi.RegistrarProduccionIndM();
                    MessageBoxEx.Show(mensaje, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    LlenarGrid();
                    tabPage2.Select();
                }               
             
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
            Program.Valor = 0;

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            frmReporte obj = new frmReporte();
            obj.Fecha = dtpdesde.Value;
            obj.Fechaf = dtphasta.Value;
            obj.Valor = 9;
            obj.Reporte = "REPORTE DIARIO INDUSTRIA MENOR";
            obj.Nombre = "diario_indm.rdlc";
            obj.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgvProduccion.SelectedRows.Count > 0)
            {
                DialogResult var = MessageBoxEx.Show("¿Desea eliminar el registro?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (var == DialogResult.Yes)
                {
                    //dtgvproduccion.Rows.RemoveAt(dtgvproduccion.CurrentRow.Index);
                    int tarjeta = Convert.ToInt32(dtgvProduccion.CurrentRow.Cells[0].Value);
                    Pi.EliminarRegistro(tarjeta);
                    MessageBoxEx.Show("Registro eliminado!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarGrid();
                }
            }
            else
            {
                MessageBoxEx.Show("Seleccione un registro!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dtgvProduccion.SelectedRows.Count > 0)
            {
                frmEditarRegistroIndm obj = new frmEditarRegistroIndm();
                obj.Ayudante = dtgvProduccion.CurrentRow.Cells[3].Value.ToString();
                obj.Operador = dtgvProduccion.CurrentRow.Cells[2].Value.ToString();
                obj.Producto = dtgvProduccion.CurrentRow.Cells[4].Value.ToString();
                obj.Maquina = dtgvProduccion.CurrentRow.Cells[6].Value.ToString();
                obj.Peso =Convert.ToDecimal(dtgvProduccion.CurrentRow.Cells[5].Value);
                obj.Tarjeta = Convert.ToInt32(dtgvProduccion.CurrentRow.Cells[0].Value);
                obj.ShowDialog();
                if (Program.Valor == 1)
                {
                    LlenarGrid();
                    Program.Valor = 0;
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBoxEx.Show("Seleccione un registro!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Program.Valor = 0;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            string reporte;
            DialogResult var;
            try
            {
                var = MessageBoxEx.Show("Desea exportar registros?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (var == DialogResult.Yes)
                {
                    if (dtpdesde.Value.Date > dtphasta.Value.Date)
                    {
                        MessageBoxEx.Show("Fecha inicial no puede ser mayor que la final!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        reporte = SecuenciaReporte();
                        Pi.Reporte = reporte;
                        Pi.Valor = 2;
                        Pi.Fecha1 = dtpdesde.Value;
                        Pi.Fechaf = dtphasta.Value;
                        Pi.Fechaft = Convert.ToDateTime("1/1/1753 12:00:00 AM");
                        mensaje = Pi.ExportarRegistroDpto();
                        if (mensaje == "1")
                        {
                            MessageBoxEx.Show("Registros Exportados!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBoxEx.Show("Ha ocurrido un error!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else
                {
                    return;
                }
            }
           
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string SecuenciaReporte()
        {
            string reporte = "";
            try
            {
                int var;
                int var2;
                string secuencia;

                DataTable dtt = new DataTable();
                dtt = Pi.SecuenciaReporte();
                if (string.IsNullOrEmpty(dtt.Rows[0]["Reporte"].ToString().Trim()))
                {
                    reporte = "1";
                    secuencia = reporte;
                    reporte = secuencia.PadLeft(7, '0');
                }
                else
                {
                    var = Convert.ToInt32(dtt.Rows[0]["Reporte"]);
                    var2 = var + 1;
                    reporte = var2.ToString();
                    secuencia = reporte;
                    reporte = secuencia.PadLeft(7, '0');

                }
                //return reporte;
            }

            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
            return reporte;

        }

        private void btnBuscar1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpdesde.Value.Date > dtphasta.Value.Date)
                {
                    MessageBoxEx.Show("Fecha inicial no puede ser mayor que la final!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    LlenarGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
