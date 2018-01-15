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
using System.Globalization;
using System.Threading;

namespace Interfaz.Registros
{
    public partial class frmProduccion : MetroForm
    {
        clsDestino D = new clsDestino();
        clsEmpleado E = new clsEmpleado();
        clsMaquina M = new clsMaquina();
        clsProducto P = new clsProducto();
        clsTurno T = new clsTurno();
        clsProduccion Pr = new clsProduccion();
        public BindingSource bs = new BindingSource();
        public DataTable dt = new DataTable();
        public DataTable dt1 = new DataTable();
        public DataTable dt3 = new DataTable();
        public frmProduccion()
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
            catch(Exception ex)
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
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
           
        }
        private void ComboM()
        {
            try
            { 
            cbmaquina.DataSource = M.Listar(true);
            cbmaquina.DisplayMember = "DESCRIPCION";
            cbmaquina.ValueMember = "ID_MAQUINA";
            }
            catch(Exception ex)
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
        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("¿Desea Salir?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
            }
        }

        private void SecuenciaReporte()
        {
            try
            {
                int var;
                int var2;
                string secuencia;
                DataTable dtt = new DataTable();
                dtt = Pr.SecuenciaReporte();
                if (string.IsNullOrEmpty(dtt.Rows[0]["Reporte"].ToString().Trim()))
                {
                    txtreporte.Text = "1";
                    secuencia = txtreporte.Text;
                    txtreporte.Text = secuencia.PadLeft(7, '0');
                    SendKeys.Send("{TAB}");
                }
                else
                {
                    var = Convert.ToInt32(dtt.Rows[0]["Reporte"]);
                    var2 = var + 1;
                    txtreporte.Text = var2.ToString();
                    secuencia = txtreporte.Text;
                    txtreporte.Text = secuencia.PadLeft(7, '0');
                    SendKeys.Send("{TAB}");
                }

            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }

        }

        private void frmProduccion_Load(object sender, EventArgs e)
        {
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
            cbproducto.SelectedValue ="";
            dtgvproduccion.MouseWheel += new MouseEventHandler(dtgvproduccion_MouseWheel);
            tabControl.MouseWheel += new MouseEventHandler(tabControl1_MouseWheel);
            //tabregistro.KeyPress += new KeyPressEventHandler (tabregistro_KeyPress);
            lbdescripcion.Visible = false;
            SecuenciaReporte();
            ContarRegistros();
            Program.Valor = 0;
            dtpdesde.Value = DateTime.Now.AddDays(-1);
            dtp2.Value = DateTime.Now.AddDays(-1);
            dtgvproduccion.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7);
            dtgvproduccion.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8);

        }
        private void LabelCambia()
        {
            DataTable dtp = new DataTable();
            dtp = P.Listar(true);
            //string valu = cbproducto.SelectedValue.ToString();
            try
            {
                if (cbproducto.Text=="System.Data.DataRowView")
                {
                    return;
                }
                else
                {
                    string valor = cbproducto.SelectedValue.ToString();
                    DataRow[] buscar;
                    buscar = dtp.Select("CODIGO='" + valor + "'");
                    lbdescripcion.Text = buscar[0]["DESCRIPCION"].ToString();
                }
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
        }
        //void tabregistro_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    try
        //    {
        //        if (Program.Valor == 1)
        //        {
        //            if (e.KeyChar == (char)Keys.Enter)
        //            {
        //                BuscarRegistros();
        //            }
        //            else
        //            {
        //                return;
        //            }
        //        }
        //        else
        //        {
        //            return;
        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBoxEx.Show(ex.Message);
        //    }
        //    ContarRegistros();
        //    tabregistro.Focus();

        //}
        void dtgvproduccion_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
                SendKeys.Send("{DOWN}");
            else
                SendKeys.Send("{UP}");
        }
        public void tabControl1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                SendKeys.Send("{DOWN}");
                bs.MoveNext();
                LabelCambia();
            }
            else
            {
                SendKeys.Send("{UP}");
                bs.MovePrevious();
                LabelCambia();
            }
        }

        private void btnimportar_Click(object sender, EventArgs e)
        {
            try
            {
                dt = Utilidades.ImportarExcel();
                if (dt.Rows.Count == 0)
                {
                    return;
                }
                else
                {  
                    btnimportar.Enabled = false;
                    lbdescripcion.Visible = true;
                    dtgvproduccion.DataSource = null;
                    dtpfecha.DataBindings.Clear();
                    cbsupervisor.DataBindings.Clear();
                    cboperador.DataBindings.Clear();
                    cbayudante.DataBindings.Clear();
                    cbturno.DataBindings.Clear();
                    txttarjeta.DataBindings.Clear();
                    cbmaquina.DataBindings.Clear();
                    cbproducto.DataBindings.Clear();
                    cbdestino.DataBindings.Clear();
                    txtcantidad.DataBindings.Clear();
                    bs.DataSource = null;
                    bs.DataSource = dt;
                    dtgvproduccion.DataSource = bs;
                    for (int x = 0; x < dtgvproduccion.Rows.Count; x++)
                    {
                        Pr.Fecha = Convert.ToDateTime(dtgvproduccion.Rows[x].Cells[0].Value);
                        Pr.Hora =TimeSpan.Parse(dtgvproduccion.Rows[x].Cells[1].Value.ToString()); 
                        Pr.Supervisor = dtgvproduccion.Rows[x].Cells[2].Value.ToString();
                        Pr.Operador = dtgvproduccion.Rows[x].Cells[3].Value.ToString();
                        Pr.Ayudante = dtgvproduccion.Rows[x].Cells[4].Value.ToString();
                        Pr.Turno = dtgvproduccion.Rows[x].Cells[5].Value.ToString();
                        Pr.Tarjeta = dtgvproduccion.Rows[x].Cells[6].Value.ToString();
                        Pr.Maquina = dtgvproduccion.Rows[x].Cells[7].Value.ToString();
                        Pr.Producto = dtgvproduccion.Rows[x].Cells[8].Value.ToString();
                        Pr.Destino = dtgvproduccion.Rows[x].Cells[9].Value.ToString();
                        Pr.Cantidad = Convert.ToDecimal(dtgvproduccion.Rows[x].Cells[10].Value.ToString());
                        Pr.Idcliente = Convert.ToInt32(dtgvproduccion.Rows[x].Cells[11].Value.ToString());
                        Pr.Reporte = txtreporte.Text;
                        Pr.RegistrarProduccion("registrar_produccion");
                    }
                    LlenarGrid();
                    bs.DataSource = null;
                    dtgvproduccion.DataSource = null;
                    bs.DataSource = dt;
                    dtgvproduccion.DataSource = bs;
                    tabControl.SelectedTab = tablistado;
                    dtpfecha.DataBindings.Add("Text", bs, "FECHA");
                    cbsupervisor.DataBindings.Add("SelectedValue", bs, "SUPERVISOR", true);
                    cboperador.DataBindings.Add("selectedvalue", bs, "OPERADOR");
                    cbayudante.DataBindings.Add("selectedvalue", bs, "AYUDANTE");
                    cbturno.DataBindings.Add("selectedvalue", bs, "TURNO");
                    txttarjeta.DataBindings.Add("Text", bs, "TARJETA");
                    cbmaquina.DataBindings.Add("selectedvalue", bs, "MÁQUINA");
                    cbproducto.DataBindings.Add("selectedvalue", bs, "PRODUCTO");
                    cbdestino.DataBindings.Add("selectedvalue", bs, "DESTINO");
                    txtcantidad.DataBindings.Add("Text", bs, "CANTIDAD");
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.ToString());
            }
            ContarRegistros();
        }
        private void LlenarGrid()
        {
            dtgvproduccion.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7);
            dtgvproduccion.DefaultCellStyle.Font= new Font("Microsoft Sans Serif", 8);
            dt = Pr.MostrarRegistros();
            if(dt.Rows.Count>0)
            {
                dt.Columns[0].ColumnName = "FECHA";
                dt.Columns[1].ColumnName = "HORA";
                dt.Columns[2].ColumnName = "SUPERVISOR";
                dt.Columns[3].ColumnName = "OPERADOR";
                dt.Columns[4].ColumnName = "AYUDANTE";
                dt.Columns[5].ColumnName = "TURNO";
                dt.Columns[7].ColumnName = "TARJETA";
                dt.Columns[6].ColumnName = "MÁQUINA";
                dt.Columns[9].ColumnName = "PRODUCTO";
                dt.Columns[10].ColumnName = "DESTINO";
                dt.Columns[8].ColumnName = "CANTIDAD";
                dt.Columns[11].ColumnName = "REPORTE";
                dt.Columns[12].ColumnName = "CLIENTE";
            }
            else
            {
                return;
            }
            
        }
        //private string[,] LlenarArray()
        //{
        //    int tamf = dtgvproduccion.Rows.Count;
        //    int tamc = dtgvproduccion.ColumnCount;
        //    string[,] datos = new string[tamf, tamc];
        //    for (int f = 0; f < tamf; f++)
        //    {
        //        for (int c = 0; c < tamc; c++)
        //        {
        //            datos[f, c] = dtgvproduccion.Rows[f].Cells[c].Value.ToString();
        //        }
        //    }
        //    return datos;
        //}
        private void btneliminar1_Click(object sender, EventArgs e)
        {
            if (dtgvproduccion.SelectedRows.Count > 0)
            {
                DialogResult var = MessageBoxEx.Show("¿Desea eliminar el registro?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (var == DialogResult.Yes)
                {
                    //dtgvproduccion.Rows.RemoveAt(dtgvproduccion.CurrentRow.Index);
                    string tarjeta = dtgvproduccion.CurrentRow.Cells[7].Value.ToString();
                    Pr.EliminarRegistro(tarjeta);
                    LlenarGrid();
                    dtgvproduccion.DataSource = null;
                    bs.DataSource = dt;
                    dtgvproduccion.DataSource = bs;
                }
            }
            else
            {
                MessageBoxEx.Show("Seleccione un registro!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            ContarRegistros();
        }

        private void btneliminart_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvproduccion.Rows.Count > 0)
                {
                    DialogResult var = MessageBoxEx.Show("¿Desea eliminar todos los registros?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (var == DialogResult.Yes)
                    {
                        Pr.EliminarRegistros(txtreporte.Text,0);
                        Limpiar();
                        SecuenciaReporte();
                    }
                }
                else
                {
                    MessageBoxEx.Show("No hay registros para eliminar!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
            ContarRegistros();
            btnimportar.Enabled = true;

        }
        private void cbsupervisor_SelectedValueChanged(object sender, EventArgs e)
        {
            //lbsupervisor.Text = cbsupervisor.SelectedValue.ToString();
            //tabregistro.Focus();
        }

        private void dtpfecha_ValueChanged(object sender, EventArgs e)
        {
            tabregistro.Focus();
        }

        private void tabregistro_MouseEnter(object sender, EventArgs e)
        {
            if(Program.Valor==0)
            {
                tabregistro.Focus();
            }
            else
            {
                tabregistro.Focus();
            }
          
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if(dtgvproduccion.Rows.Count>0)
            {
                DialogResult var = MessageBoxEx.Show("¿Desea eliminar el registro?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (var == DialogResult.Yes)
                {
                    if (!string.IsNullOrEmpty(txttarjeta.Text))
                    {
                        string tarjeta = dtgvproduccion.CurrentRow.Cells[7].Value.ToString();
                        Pr.EliminarRegistro(tarjeta);
                        dtgvproduccion.DataSource = null;
                        LlenarGrid();
                        if (dt.Rows.Count>0)
                        {
                            LlenarGrid();
                            dtgvproduccion.DataSource = null;
                            bs.DataSource = dt;
                            dtgvproduccion.DataSource = bs;
                        }
                        else
                        {
                            Limpiar();
                            Limpiar2();
                        }
                     
                    }
                    else
                    {
                        txttarjeta.Clear();
                        txtcantidad.Clear();
                    }
                }

            }
            else
            {
                MessageBoxEx.Show("No hay registro para borrar!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar2();
            }
            ContarRegistros();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Consultas.frmcProducto obj = new Consultas.frmcProducto();
            obj.lbinf.Text = "Doble click para seleccinar";
            obj.lbinf.Visible = true;
            obj.ShowDialog();
            if(string.IsNullOrEmpty(Program.CodigoP))
            {
                return;
            }
            else
            {
                cbproducto.SelectedValue = Program.CodigoP;
            }
            Program.Evento = 0;
            Program.CodigoP = "";
        }

        private void cbproducto_SelectedValueChanged(object sender, EventArgs e)
        {
           //Actualizar();
           LabelCambia();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            frmAgregarProducto obj = new frmAgregarProducto();
            obj.reporte = txtreporte.Text;
            try
            {
                if (obj.ShowDialog() == DialogResult.OK)
                {
                    //if (dt.Rows.Count > 0)
                    //{
                        MostrarTodos();
                        //if (dt2.Rows.Count > 0)
                        //{
                        //    for (int x = 0; x < dt2.Rows.Count; x++)
                        //    {
                        //        TimeSpan ts = new TimeSpan(08, 0, 0);
                        //        Pr.Fecha =Convert.ToDateTime(dt2.Rows[x][0]);
                        //        Pr.Hora =ts;
                        //        Pr.Supervisor = dt2.Rows[x][1].ToString();
                        //        Pr.Operador = dt2.Rows[x][2].ToString();
                        //        Pr.Ayudante = dt2.Rows[x][3].ToString();
                        //        Pr.Turno = dt2.Rows[x][4].ToString();
                        //        Pr.Tarjeta = dt2.Rows[x][5].ToString();
                        //        Pr.Maquina = dt2.Rows[x][6].ToString();
                        //        Pr.Producto = dt2.Rows[x][7].ToString();
                        //        Pr.Destino = dt2.Rows[x][8].ToString();
                        //        Pr.Cantidad =Convert.ToDecimal(dt2.Rows[x][9]);
                        //        Pr.RegistrarProduccion("registrar_produccion");
                        //    }
                            //dtpfecha.DataBindings.Clear();
                            //cbsupervisor.DataBindings.Clear();
                            //cboperador.DataBindings.Clear();
                            //cbayudante.DataBindings.Clear();
                            //cbturno.DataBindings.Clear();
                            //txttarjeta.DataBindings.Clear();
                            //cbmaquina.DataBindings.Clear();
                            //cbproducto.DataBindings.Clear();
                            //cbdestino.DataBindings.Clear();
                            //txtcantidad.DataBindings.Clear();
                            //lbdescripcion.Visible = false;

                            //LlenarGrid();
                            //bs.DataSource = null;
                            //dtgvproduccion.DataSource = null;
                            //bs.DataSource = dt;
                            //dtgvproduccion.DataSource = bs;
                            //tabControl1.SelectedTab = tablistado;
                            //dtpfecha.DataBindings.Add("Text", bs, "FECHA");
                            //cbsupervisor.DataBindings.Add("SelectedValue", bs, "SUPERVISOR", true);
                            //cboperador.DataBindings.Add("selectedvalue", bs, "OPERADOR");
                            //cbayudante.DataBindings.Add("selectedvalue", bs, "AYUDANTE");
                            //cbturno.DataBindings.Add("selectedvalue", bs, "TURNO");
                            //txttarjeta.DataBindings.Add("Text", bs, "TARJETA");
                            //cbmaquina.DataBindings.Add("selectedvalue", bs, "MÁQUINA");
                            //cbproducto.DataBindings.Add("selectedvalue", bs, "PRODUCTO");
                            //cbdestino.DataBindings.Add("selectedvalue", bs, "DESTINO");
                            //txtcantidad.DataBindings.Add("Text", bs, "CANTIDAD");
                        //}
                    //}
                    //else
                    //{
                        //if(dt3.Columns.Count==0)
                        //{
                        //    btnimportar.Enabled = false;
                        //    dt3.Columns.Add("FECHA");
                        //    dt3.Columns.Add("SUPERVISOR");
                        //    dt3.Columns.Add("OPERADOR");
                        //    dt3.Columns.Add("AYUDANTE");
                        //    dt3.Columns.Add("TURNO");
                        //    dt3.Columns.Add("TARJETA");
                        //    dt3.Columns.Add("MÁQUINA");
                        //    dt3.Columns.Add("PRODUCTO");
                        //    dt3.Columns.Add("DESTINO");
                        //    dt3.Columns.Add("CANTIDAD");
                        //}
                        //dt2 = obj.dt; 
                        //for(int x=0;x<dt2.Rows.Count;x++)
                        //{
                        //    DataRow nf = dt3.NewRow();
                        //    nf[0] = dt2.Rows[x][0].ToString();
                        //    nf[1] = dt2.Rows[x][1].ToString();
                        //    nf[2] = dt2.Rows[x][2].ToString();
                        //    nf[3] = dt2.Rows[x][3].ToString();
                        //    nf[4] = dt2.Rows[x][4].ToString();
                        //    nf[5] = dt2.Rows[x][5].ToString();
                        //    nf[6] = dt2.Rows[x][6].ToString();
                        //    nf[7] = dt2.Rows[x][7].ToString();
                        //    nf[8] = dt2.Rows[x][8].ToString();
                        //    nf[9] = dt2.Rows[x][9].ToString();
                        //    dt3.Rows.Add(nf);
                        //}
                        //lbdescripcion.Visible = true;                                         
                        //bs.DataSource = null;
                        //bs.DataSource = dt3;
                        //dtgvproduccion.DataSource = bs;
                        //dtpfecha.DataBindings.Add("Text", bs, "FECHA");
                        //cbsupervisor.DataBindings.Add("SelectedValue", bs, "SUPERVISOR", true);
                        //cboperador.DataBindings.Add("selectedvalue", bs, "OPERADOR");
                        //cbayudante.DataBindings.Add("selectedvalue", bs, "AYUDANTE");
                        //cbturno.DataBindings.Add("selectedvalue", bs, "TURNO");
                        //txttarjeta.DataBindings.Add("Text", bs, "TARJETA");
                        //cbmaquina.DataBindings.Add("selectedvalue", bs, "MÁQUINA");
                        //cbproducto.DataBindings.Add("selectedvalue", bs, "PRODUCTO");
                        //cbdestino.DataBindings.Add("selectedvalue", bs, "DESTINO");
                        //txtcantidad.DataBindings.Add("Text", bs, "CANTIDAD");
                    //}
                }
                else
                {
                    return;
                }
            }
        
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
            ContarRegistros();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if(btnregistrar.Text=="Registrar")
            {
                string mensaje = "";
                DialogResult var;
                if (dt.Rows.Count > 0)
                {
                    var = MessageBoxEx.Show("Desea registrar la producción?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (var == DialogResult.Yes)
                    {
                        try
                        {
                            if (Program.Evento == 0)
                            {
                                for (int x = 0; x < dtgvproduccion.Rows.Count; x++)
                                {
                                    Pr.Fecha = Convert.ToDateTime(dtgvproduccion.Rows[x].Cells[0].Value);
                                    Pr.Hora = TimeSpan.Parse(dtgvproduccion.Rows[x].Cells[1].Value.ToString());
                                    Pr.Supervisor = dtgvproduccion.Rows[x].Cells[2].Value.ToString();
                                    Pr.Operador = dtgvproduccion.Rows[x].Cells[3].Value.ToString();
                                    Pr.Ayudante = dtgvproduccion.Rows[x].Cells[4].Value.ToString();
                                    Pr.Turno = dtgvproduccion.Rows[x].Cells[5].Value.ToString();
                                    Pr.Tarjeta = dtgvproduccion.Rows[x].Cells[7].Value.ToString();
                                    Pr.Maquina = dtgvproduccion.Rows[x].Cells[6].Value.ToString();
                                    Pr.Producto = dtgvproduccion.Rows[x].Cells[9].Value.ToString();
                                    Pr.Destino = dtgvproduccion.Rows[x].Cells[10].Value.ToString();
                                    Pr.Cantidad = Convert.ToDecimal(dtgvproduccion.Rows[x].Cells[8].Value.ToString());
                                    Pr.Reporte = txtreporte.Text;
                                    Pr.Idcliente = Convert.ToInt32(dtgvproduccion.Rows[x].Cells[12].Value.ToString());
                                    mensaje = Pr.RegistrarProduccion("registrar_produccion1");
                                    Pr.RegistrarProduccion("registrar_produccion12");
                                    //if(mensaje== "Producción registrada!")
                                    //{
                                    //    MessageBoxEx.Show(mensaje, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    //}
                                    //SecuenciaReporte();
                                    if (mensaje == "2627")
                                    {
                                        MessageBoxEx.Show("La tarjeta " + dtgvproduccion.Rows[x].Cells[7].Value.ToString() + " esta repetida!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Pr.EliminarRegistros(txtreporte.Text,1);
                                        MessageBoxEx.Show("Arregle campos erroneos", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        break;
                                    }
                                    else if (mensaje == "547")
                                    {
                                        MessageBoxEx.Show("Campos erroneos en la fila con la tarjeta " + dtgvproduccion.Rows[x].Cells[7].Value.ToString(), "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Pr.EliminarRegistros(txtreporte.Text,1);
                                        MessageBoxEx.Show("Arregle campos erroneos", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        break;
                                    }
                                }
                            }
                            if (mensaje == "2627")
                            {

                            }
                            else if (mensaje == "547")
                            {

                            }
                            else
                            {
                                MessageBoxEx.Show(mensaje, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Program.Evento = 0;
                                //Limpiar();
                            }

                        }

                        catch (Exception ex)
                        {
                            MessageBoxEx.Show(ex.Message);
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBoxEx.Show("No hay registros!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                string mensaje = "";
                DialogResult var;
                if (dt.Rows.Count > 0)
                {
                    var = MessageBoxEx.Show("Desea actualizar la producción?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (var == DialogResult.Yes)
                    {
                        try
                        {
                            if (Program.Evento == 0)
                            {
                                for (int x = 0; x < dtgvproduccion.Rows.Count; x++)
                                {
                                    Pr.Fecha = Convert.ToDateTime(dtgvproduccion.Rows[x].Cells[0].Value);
                                    Pr.Hora = TimeSpan.Parse(dtgvproduccion.Rows[x].Cells[1].Value.ToString());
                                    Pr.Supervisor = dtgvproduccion.Rows[x].Cells[2].Value.ToString();
                                    Pr.Operador = dtgvproduccion.Rows[x].Cells[3].Value.ToString();
                                    Pr.Ayudante = dtgvproduccion.Rows[x].Cells[4].Value.ToString();
                                    Pr.Turno = dtgvproduccion.Rows[x].Cells[5].Value.ToString();
                                    Pr.Tarjeta = dtgvproduccion.Rows[x].Cells[7].Value.ToString();
                                    Pr.Maquina = dtgvproduccion.Rows[x].Cells[6].Value.ToString();
                                    Pr.Producto = dtgvproduccion.Rows[x].Cells[9].Value.ToString();
                                    Pr.Destino = dtgvproduccion.Rows[x].Cells[10].Value.ToString();
                                    Pr.Cantidad = Convert.ToDecimal(dtgvproduccion.Rows[x].Cells[8].Value.ToString());
                                    Pr.Reporte = txtreporte.Text;
                                    Pr.Idcliente = Convert.ToInt32(dtgvproduccion.Rows[x].Cells[12].Value.ToString());
                                    mensaje = Pr.Actualizar1();
                                    //SecuenciaReporte();
                                    if (mensaje == "2627")
                                    {
                                        MessageBoxEx.Show("La tarjeta " + dtgvproduccion.Rows[x].Cells[7].Value.ToString() + " esta repetida!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        //Pr.EliminarRegistros(txtreporte.Text);
                                        MessageBoxEx.Show("Arregle campos erroneos", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        break;
                                    }
                                    else if (mensaje == "547")
                                    {
                                        MessageBoxEx.Show("Campos erroneos en la fila con la tarjeta " + dtgvproduccion.Rows[x].Cells[7].Value.ToString(), "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        //Pr.EliminarRegistros(txtreporte.Text);
                                        MessageBoxEx.Show("Arregle campos erroneos", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        break;
                                    }
                                }
                            }
                            if (mensaje == "2627")
                            {

                            }
                            else if (mensaje == "547")
                            {

                            }
                            else
                            {
                                MessageBoxEx.Show(mensaje, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Program.Evento = 0;
                                //Limpiar();
                            }

                        }

                        catch (Exception ex)
                        {
                            MessageBoxEx.Show(ex.Message);
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBoxEx.Show("No hay registros!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
            ContarRegistros();
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actualizar();
            frmReporte obj = new frmReporte();
            dt1 = Pr.TotalProduccion("Acerados");
            double acerado;
            double galvanizado;
            double recocido;
            if(string.IsNullOrEmpty(dt1.Rows[0]["Total"].ToString()))
            {
                acerado = 0.00;
            }
            else
            {
                acerado = Convert.ToDouble(dt1.Rows[0]["Total"]);
            }
            dt1 = Pr.TotalProduccion("Galvanizados");
            if (string.IsNullOrEmpty(dt1.Rows[0]["Total"].ToString()))
            {
                galvanizado = 0.00;
            }
            else
            {
                galvanizado = Convert.ToDouble(dt1.Rows[0]["Total"]);
            }
            dt1 = Pr.TotalProduccion("Recocidos");
            if (string.IsNullOrEmpty(dt1.Rows[0]["Total"].ToString()))
            {
                recocido = 0.00;
            }
            else
            {
                recocido = Convert.ToDouble(dt1.Rows[0]["Total"]);
            }
            obj.Valor = 0;
            obj.Acerado = acerado;
            obj.Galvanizado = galvanizado;
            obj.Recocido = recocido;
            obj.NoReporte = txtreporte.Text;
            obj.Fecha = dtp2.Value;
            obj.Nombre = "reporte_general.rdlc";
            obj.Destino = "";
            obj.Reporte = "REPORTE GENERAL";
            obj.Show();
        }

        private void intermediosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actualizar();
            frmReporte obj = new frmReporte();
            dt1 = Pr.TotalProduccion("Acerados");
            double acerado;
            double galvanizado;
            double recocido;
            if (string.IsNullOrEmpty(dt1.Rows[0]["Total"].ToString()))
            {
                acerado = 0.00;
            }
            else
            {
                acerado = Convert.ToDouble(dt1.Rows[0]["Total"]);
            }
            dt1 = Pr.TotalProduccion("Galvanizados");
            if (string.IsNullOrEmpty(dt1.Rows[0]["Total"].ToString()))
            {
                galvanizado = 0.00;
            }
            else
            {
                galvanizado = Convert.ToDouble(dt1.Rows[0]["Total"]);
            }
            dt1 = Pr.TotalProduccion("Recocidos");
            if (string.IsNullOrEmpty(dt1.Rows[0]["Total"].ToString()))
            {
                recocido = 0.00;
            }
            else
            {
                recocido = Convert.ToDouble(dt1.Rows[0]["Total"]);
            }
            obj.Valor = 0;
            obj.Acerado = acerado;
            obj.Galvanizado = galvanizado;
            obj.Recocido = recocido;
            obj.NoReporte = txtreporte.Text;
            obj.Fecha = dtp2.Value;
            obj.Nombre = "reporte_intermedios.rdlc";
            obj.Destino = "Intermedios";
            obj.Reporte = "REPORTE INTERMEDIOS";
            obj.Show();
        }

        private void terminadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actualizar();
            frmReporte obj = new frmReporte();
            dt1 = Pr.TotalProduccion("Acerados");
            double acerado;
            double galvanizado;
            double recocido;
            if (string.IsNullOrEmpty(dt1.Rows[0]["Total"].ToString()))
            {
                acerado = 0.00;
            }
            else
            {
                acerado = Convert.ToDouble(dt1.Rows[0]["Total"]);
            }
            dt1 = Pr.TotalProduccion("Galvanizados");
            if (string.IsNullOrEmpty(dt1.Rows[0]["Total"].ToString()))
            {
                galvanizado = 0.00;
            }
            else
            {
                galvanizado = Convert.ToDouble(dt1.Rows[0]["Total"]);
            }
            dt1 = Pr.TotalProduccion("Recocidos");
            if (string.IsNullOrEmpty(dt1.Rows[0]["Total"].ToString()))
            {
                recocido = 0.00;
            }
            else
            {
                recocido = Convert.ToDouble(dt1.Rows[0]["Total"]);
            }
            obj.Valor = 0;
            obj.Acerado = acerado;
            obj.Galvanizado = galvanizado;
            obj.Recocido = recocido;
            obj.NoReporte = txtreporte.Text;
            obj.Fecha = dtp2.Value;
            obj.Nombre = "reporte_terminados.rdlc";
            obj.Destino = "Terminados";
            obj.Reporte = "REPORTE TERMINADOS";
            obj.Show();
        }
        private void Limpiar()
        {
            dtgvproduccion.DataSource = null;
            dt.Clear();
            //bs.Clear();
            dtgvproduccion.Rows.Clear();
            dtpfecha.DataBindings.Clear();
            cbsupervisor.DataBindings.Clear();
            cboperador.DataBindings.Clear();
            cbayudante.DataBindings.Clear();
            cbturno.DataBindings.Clear();
            txttarjeta.DataBindings.Clear();
            cbmaquina.DataBindings.Clear();
            cbproducto.DataBindings.Clear();
            cbdestino.DataBindings.Clear();
            txtcantidad.DataBindings.Clear();
            lbdescripcion.Visible = false;
            btnimportar.Enabled = true;
        }
        private void Limpiar2()
        {
            cbsupervisor.SelectedValue = "";
            cboperador.SelectedValue = "";
            cbayudante.SelectedValue = "";
            cbturno.SelectedValue = "";
            txttarjeta.Clear();
            cbmaquina.SelectedValue = "";
            cbproducto.SelectedValue = "";
            cbdestino.SelectedValue = "";
            txtcantidad.Clear();
        }
        private void Actualizar()
        {
            try
            {
                if (dtgvproduccion.Rows.Count > 0)
                {
                    for(int x=0;x<dtgvproduccion.Rows.Count;x++)
                    {
                        Pr.Fecha = Convert.ToDateTime(dtgvproduccion.Rows[x].Cells[0].Value);
                        Pr.Hora = TimeSpan.Parse(dtgvproduccion.Rows[x].Cells[1].Value.ToString());
                        Pr.Supervisor = dtgvproduccion.Rows[x].Cells[2].Value.ToString();
                        Pr.Operador = dtgvproduccion.Rows[x].Cells[3].Value.ToString();
                        Pr.Ayudante = dtgvproduccion.Rows[x].Cells[4].Value.ToString();
                        Pr.Turno = dtgvproduccion.Rows[x].Cells[5].Value.ToString();
                        Pr.Tarjeta = dtgvproduccion.Rows[x].Cells[7].Value.ToString();
                        Pr.Maquina = dtgvproduccion.Rows[x].Cells[6].Value.ToString();
                        Pr.Producto = dtgvproduccion.Rows[x].Cells[9].Value.ToString();
                        Pr.Destino = dtgvproduccion.Rows[x].Cells[10].Value.ToString();
                        Pr.Cantidad = Convert.ToDecimal(dtgvproduccion.Rows[x].Cells[8].Value.ToString());
                        Pr.Idcliente= Convert.ToInt32(dtgvproduccion.Rows[x].Cells[12].Value.ToString());
                        Pr.ActualizaRegistros();
                    }
                 
                }
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
            
        }

        private void dtpfecha_ValueChanged_1(object sender, EventArgs e)
        {
           
        }

        private void cbsupervisor_SelectedValueChanged_1(object sender, EventArgs e)
        {
            //Actualizar();
        }

        private void cboperador_SelectedValueChanged(object sender, EventArgs e)
        {
            //Actualizar();
        }

        private void cbayudante_SelectedValueChanged(object sender, EventArgs e)
        {
            //Actualizar();
        }

        private void cbturno_SelectedValueChanged(object sender, EventArgs e)
        {
            //Actualizar();
        }

        private void txttarjeta_TextChanged(object sender, EventArgs e)
        {
            //Actualizar();
        }

        private void cbmaquina_SelectedValueChanged(object sender, EventArgs e)
        {
            //Actualizar();
        }

        private void cbdestino_SelectedValueChanged(object sender, EventArgs e)
        {
            //Actualizar();
        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {
            //Actualizar();
        }

        private void btnbuscar1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dt.Rows.Count > 0)
                {
                    Limpiar2();
                    Program.Valor = 1;
                    Limpiar();
                    ContarRegistros();
                    Consultas.frmcBuscarRegistros obj = new Consultas.frmcBuscarRegistros();
                    obj.reporte = txtreporte.Text;
                    if (obj.ShowDialog() == DialogResult.OK)
                    {
                        dt.Clear();
                        dt = obj.dt3;
                        dt.Columns[0].ColumnName = "FECHA";
                        dt.Columns[1].ColumnName = "HORA";
                        dt.Columns[2].ColumnName = "SUPERVISOR";
                        dt.Columns[3].ColumnName = "OPERADOR";
                        dt.Columns[4].ColumnName = "AYUDANTE";
                        dt.Columns[5].ColumnName = "TURNO";
                        dt.Columns[6].ColumnName = "MÁQUINA";
                        dt.Columns[7].ColumnName = "TARJETA";
                        dt.Columns[9].ColumnName = "PRODUCTO";
                        dt.Columns[10].ColumnName = "DESTINO";
                        dt.Columns[8].ColumnName = "CANTIDAD";
                        dt.Columns[11].ColumnName = "REPORTE";
                        dt.Columns[12].ColumnName = "CLIENTE";
                        bs.DataSource = dt;
                        tabControl.SelectedTab = tablistado;
                        dtgvproduccion.DataSource = bs;
                        dtpfecha.DataBindings.Add("Text", bs, "FECHA");
                        cbsupervisor.DataBindings.Add("SelectedValue", bs, "SUPERVISOR", true);
                        cboperador.DataBindings.Add("selectedvalue", bs, "OPERADOR");
                        cbayudante.DataBindings.Add("selectedvalue", bs, "AYUDANTE");
                        cbturno.DataBindings.Add("selectedvalue", bs, "TURNO");
                        txttarjeta.DataBindings.Add("Text", bs, "TARJETA");
                        cbmaquina.DataBindings.Add("selectedvalue", bs, "MÁQUINA");
                        cbproducto.DataBindings.Add("selectedvalue", bs, "PRODUCTO");
                        cbdestino.DataBindings.Add("selectedvalue", bs, "DESTINO");
                        txtcantidad.DataBindings.Add("Text", bs, "CANTIDAD");
                        lbdescripcion.Visible = true;
                        ContarRegistros();
                        btnimportar.Enabled = false;
                    }
                    else
                    {
                        MostrarTodos();
                    }
                }
                else
                {
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ContarRegistros();

        }
        private void ContarRegistros()
        {
           label20.Text=dtgvproduccion.Rows.Count.ToString();
        }
        //private void BuscarRegistros()
        //{
        //    try
        //    {
        //        DataTable dt3 = new DataTable();
        //        if (dtpfecha.Value != DateTimePicker.MinimumDateTime)
        //        {
        //            Pr.Fecha1 = dtpfecha.Value.ToShortDateString();
        //        }
        //        else
        //        {
        //            Pr.Fecha1 = "";
        //        }
        //        if (Convert.ToBoolean(cbsupervisor.SelectedIndex == -1))
        //        {
        //            Pr.Supervisor = "";
        //        }
        //        else
        //        {
        //            Pr.Supervisor = cbsupervisor.SelectedValue.ToString();
        //        }
  
        //        if(Convert.ToBoolean(cboperador.SelectedIndex==-1))
        //        {
        //            Pr.Operador = "";
        //        }
        //        else
        //        {
        //            Pr.Operador = cboperador.SelectedValue.ToString();
        //        }
        //        if (Convert.ToBoolean(cbayudante.SelectedIndex == -1))
        //        {
        //            Pr.Ayudante = "";
        //        }
        //        else
        //        {
        //            Pr.Ayudante = cbayudante.SelectedValue.ToString();
        //        }
        //        if (Convert.ToBoolean(cbturno.SelectedIndex == -1))
        //        {
        //            Pr.Turno = "";
        //        }
        //        else
        //        {
        //            Pr.Turno = cbturno.SelectedValue.ToString();
        //        }
        //        if (Convert.ToBoolean(cbmaquina.SelectedIndex == -1))
        //        {
        //            Pr.Maquina = "";
        //        }
        //        else
        //        {
        //            Pr.Maquina = cbmaquina.SelectedValue.ToString();
        //        }
        //        if (Convert.ToBoolean(cbproducto.SelectedIndex == -1))
        //        {
        //            Pr.Producto = "";
        //        }
        //        else
        //        {
        //            Pr.Producto = cbproducto.SelectedValue.ToString();
        //        }
        //        if (Convert.ToBoolean(cbdestino.SelectedIndex == -1))
        //        {
        //            Pr.Destino = "";
        //        }
        //        else
        //        {
        //            Pr.Destino = cbdestino.SelectedValue.ToString();
        //        }

        //        if (string.IsNullOrEmpty(txttarjeta.Text))
        //        {
        //            Pr.Tarjeta = "";
        //        }
        //        else
        //        {
        //            Pr.Tarjeta = txttarjeta.Text;
        //        }
        //        Pr.Reporte = txtreporte.Text;
        //        dt3=Pr.BuscarRegistro();
        //        if(dt3.Rows.Count>0)
        //        {
        //            dt3.Columns[0].ColumnName = "FECHA";
        //            dt3.Columns[1].ColumnName = "HORA";
        //            dt3.Columns[2].ColumnName = "SUPERVISOR";
        //            dt3.Columns[3].ColumnName = "OPERADOR";
        //            dt3.Columns[4].ColumnName = "AYUDANTE";
        //            dt3.Columns[5].ColumnName = "TURNO";
        //            dt3.Columns[7].ColumnName = "TARJETA";
        //            dt3.Columns[6].ColumnName = "MÁQUINA";
        //            dt3.Columns[9].ColumnName = "PRODUCTO";
        //            dt3.Columns[10].ColumnName = "DESTINO";
        //            dt3.Columns[8].ColumnName = "CANTIDAD";
        //            dt = dt3;
        //            bs.DataSource = dt;
        //            dtgvproduccion.DataSource = bs;
        //            dtpfecha.DataBindings.Add("Text", bs, "FECHA");
        //            cbsupervisor.DataBindings.Add("SelectedValue", bs, "SUPERVISOR", true);
        //            cboperador.DataBindings.Add("selectedvalue", bs, "OPERADOR");
        //            cbayudante.DataBindings.Add("selectedvalue", bs, "AYUDANTE");
        //            cbturno.DataBindings.Add("selectedvalue", bs, "TURNO");
        //            txttarjeta.DataBindings.Add("Text", bs, "TARJETA");
        //            cbmaquina.DataBindings.Add("selectedvalue", bs, "MÁQUINA");
        //            cbproducto.DataBindings.Add("selectedvalue", bs, "PRODUCTO");
        //            cbdestino.DataBindings.Add("selectedvalue", bs, "DESTINO");
        //            txtcantidad.DataBindings.Add("Text", bs, "CANTIDAD");
        //            lbdescripcion.Visible = true;
        //        }
        //        else
        //        {
        //            Program.Valor = 0;
        //            MessageBoxEx.Show("");
        //            MessageBoxEx.Show("No se han encontrado registros!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            MessageBoxEx.Show("Se mostraran todos.", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            MostrarTodos();
        //        }            
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBoxEx.Show(ex.Message);
        //    }
        //    Program.Valor = 0;
        //}
        private void btnmostrar_Click(object sender, EventArgs e)
        {
            MostrarTodos();
            ContarRegistros();
        }
        private void MostrarTodos()
        {
            Actualizar();
            LlenarGrid();
            if(dt.Rows.Count>0)
            {
                bs.DataSource = dt;
                dtgvproduccion.DataSource = bs;
                tabControl.SelectedTab = tablistado;
                dtpfecha.DataBindings.Clear();
                cbsupervisor.DataBindings.Clear();
                cboperador.DataBindings.Clear();
                cbayudante.DataBindings.Clear();
                cbturno.DataBindings.Clear();
                txttarjeta.DataBindings.Clear();
                cbmaquina.DataBindings.Clear();
                cbproducto.DataBindings.Clear();
                cbdestino.DataBindings.Clear();
                txtcantidad.DataBindings.Clear();
                dtpfecha.DataBindings.Add("Text", bs, "FECHA");
                cbsupervisor.DataBindings.Add("SelectedValue", bs, "SUPERVISOR", true);
                cboperador.DataBindings.Add("selectedvalue", bs, "OPERADOR");
                cbayudante.DataBindings.Add("selectedvalue", bs, "AYUDANTE");
                cbturno.DataBindings.Add("selectedvalue", bs, "TURNO");
                txttarjeta.DataBindings.Add("Text", bs, "TARJETA");
                cbmaquina.DataBindings.Add("selectedvalue", bs, "MÁQUINA");
                cbproducto.DataBindings.Add("selectedvalue", bs, "PRODUCTO");
                cbdestino.DataBindings.Add("selectedvalue", bs, "DESTINO");
                txtcantidad.DataBindings.Add("Text", bs, "CANTIDAD");
                txtreporte.Text = dt.Rows[0][11].ToString();
                lbdescripcion.Visible = true;
            }
            else
            {
                return;
            }
        
        }

        private void procesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actualizar();
            frmReporte obj = new frmReporte();
            dt1 = Pr.TotalProduccion("Acerados");
            double acerado;
            double galvanizado;
            double recocido;
            if (string.IsNullOrEmpty(dt1.Rows[0]["Total"].ToString()))
            {
                acerado = 0.00;
            }
            else
            {
                acerado = Convert.ToDouble(dt1.Rows[0]["Total"]);
            }
            dt1 = Pr.TotalProduccion("Galvanizados");
            if (string.IsNullOrEmpty(dt1.Rows[0]["Total"].ToString()))
            {
                galvanizado = 0.00;
            }
            else
            {
                galvanizado = Convert.ToDouble(dt1.Rows[0]["Total"]);
            }
            dt1 = Pr.TotalProduccion("Recocidos");
            if (string.IsNullOrEmpty(dt1.Rows[0]["Total"].ToString()))
            {
                recocido = 0.00;
            }
            else
            {
                recocido = Convert.ToDouble(dt1.Rows[0]["Total"]);
            }
            obj.Valor = 0;
            obj.Acerado = acerado;
            obj.Galvanizado = galvanizado;
            obj.Recocido = recocido;
            obj.NoReporte = txtreporte.Text;
            obj.Fecha = dtp2.Value;
            obj.Nombre = "procesos.rdlc";
            obj.Destino = "Procesos";
            obj.Reporte = "REPORTE PROCESOS";
            obj.Show();
        }

        private void desperdiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actualizar();
            frmReporte obj = new frmReporte();
            dt1 = Pr.TotalProduccion("Acerados");
            double acerado;
            double galvanizado;
            double recocido;
            if (string.IsNullOrEmpty(dt1.Rows[0]["Total"].ToString()))
            {
                acerado = 0.00;
            }
            else
            {
                acerado = Convert.ToDouble(dt1.Rows[0]["Total"]);
            }
            dt1 = Pr.TotalProduccion("Galvanizados");
            if (string.IsNullOrEmpty(dt1.Rows[0]["Total"].ToString()))
            {
                galvanizado = 0.00;
            }
            else
            {
                galvanizado = Convert.ToDouble(dt1.Rows[0]["Total"]);
            }
            dt1 = Pr.TotalProduccion("Recocidos");
            if (string.IsNullOrEmpty(dt1.Rows[0]["Total"].ToString()))
            {
                recocido = 0.00;
            }
            else
            {
                recocido = Convert.ToDouble(dt1.Rows[0]["Total"]);
            }
            obj.Valor = 0;
            obj.Acerado = acerado;
            obj.Galvanizado = galvanizado;
            obj.Recocido = recocido;
            obj.NoReporte = txtreporte.Text;
            obj.Fecha = dtp2.Value;
            obj.Nombre = "desperdicios.rdlc";
            obj.Destino = "Desperdicios";
            obj.Reporte = "REPORTE DESPERDICIOS";
            obj.Show();
        }

        private void lineaGalvanizadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actualizar();
            frmReporte obj = new frmReporte();
            dt1 = Pr.TotalProduccion("Acerados");
            double acerado;
            double galvanizado;
            double recocido;
            if (string.IsNullOrEmpty(dt1.Rows[0]["Total"].ToString()))
            {
                acerado = 0.00;
            }
            else
            {
                acerado = Convert.ToDouble(dt1.Rows[0]["Total"]);
            }
            dt1 = Pr.TotalProduccion("Galvanizados");
            if (string.IsNullOrEmpty(dt1.Rows[0]["Total"].ToString()))
            {
                galvanizado = 0.00;
            }
            else
            {
                galvanizado = Convert.ToDouble(dt1.Rows[0]["Total"]);
            }
            dt1 = Pr.TotalProduccion("Recocidos");
            if (string.IsNullOrEmpty(dt1.Rows[0]["Total"].ToString()))
            {
                recocido = 0.00;
            }
            else
            {
                recocido = Convert.ToDouble(dt1.Rows[0]["Total"]);
            }
            obj.Valor = 0;
            obj.Acerado = acerado;
            obj.Galvanizado = galvanizado;
            obj.Recocido = recocido;
            obj.NoReporte = txtreporte.Text;
            obj.Fecha = dtp2.Value;
            obj.Nombre = "linea_galv.rdlc";
            obj.Destino = "Linea Galv";
            obj.Reporte = "REPORTE LINEA GALVANIZADO";
            obj.Show();
        }

        private void listadoIntermediosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearExcel("INTERMEDIOS", "LISTADO INTERMEDIOS");
        }

        private void CrearExcel(string destino,string archivo)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(Pr.Listado(destino));
            saveFileDialog1.FileName = archivo+".xlsx";
            saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.OverwritePrompt = false;
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            string TargetFilename = saveFileDialog1.FileName;
            try
            {
                if(Utilidades.CreateExcelDocument(ds, TargetFilename))
                {
                    MessageBoxEx.Show("Archivo creado exitosamente", "Sistema de producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo crear el archivo.\r\nException: " + ex.Message);
                return;
            }
        }

        private void listadoTerminadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearExcel("Terminados", "LISTADO TERMINADOS");
        }

        private void btnbuscar3_Click(object sender, EventArgs e)
        {
            int diferencia = 0;
            btnimportar.Enabled = false;
            TimeSpan fechas = new TimeSpan();
            DateTime fechaft = dtphasta.Value.AddDays(-1);
            if (dtpdesde.Value.Date < dtphasta.Value.Date)
            {
                fechas = dtphasta.Value.Date - dtpdesde.Value.Date;
                diferencia = fechas.Days;
                if (diferencia > 1)
                {
                    Pr.Fecha1 = dtpdesde.Value;
                    Pr.Fechaft = fechaft;
                    Pr.Fechaf = dtphasta.Value;
                    Limpiar();
                    bs.DataSource = null;
                    dtgvproduccion.DataSource = null;
                    dt = Pr.BuscarProduccion();
                    if (dt.Rows.Count > 0)
                    {
                        txtreporte.Text = dt.Rows[0][11].ToString();
                        MostrarTodos();
                        btnregistrar.Text = "Actualizar";
                        //bs.DataSource = dt;
                        //dtgvproduccion.DataSource = bs;
                        //tabControl.SelectedTab = tablistado;
                        //dtpfecha.DataBindings.Clear();
                        //cbsupervisor.DataBindings.Clear();
                        //cboperador.DataBindings.Clear();
                        //cbayudante.DataBindings.Clear();
                        //cbturno.DataBindings.Clear();
                        //txttarjeta.DataBindings.Clear();
                        //cbmaquina.DataBindings.Clear();
                        //cbproducto.DataBindings.Clear();
                        //cbdestino.DataBindings.Clear();
                        //txtcantidad.DataBindings.Clear();
                        //dtpfecha.DataBindings.Add("Text", bs, "FECHA");
                        //cbsupervisor.DataBindings.Add("SelectedValue", bs, "SUPERVISOR", true);
                        //cboperador.DataBindings.Add("selectedvalue", bs, "OPERADOR");
                        //cbayudante.DataBindings.Add("selectedvalue", bs, "AYUDANTE");
                        //cbturno.DataBindings.Add("selectedvalue", bs, "TURNO");
                        //txttarjeta.DataBindings.Add("Text", bs, "TARJETA");
                        //cbmaquina.DataBindings.Add("selectedvalue", bs, "MÁQUINA");
                        //cbproducto.DataBindings.Add("selectedvalue", bs, "PRODUCTO");
                        //cbdestino.DataBindings.Add("selectedvalue", bs, "DESTINO");
                        //txtcantidad.DataBindings.Add("Text", bs, "CANTIDAD");
                        //lbdescripcion.Visible = true;
                        ContarRegistros();

                    }
                    else
                    {
                    MessageBoxEx.Show("No se encontraron registros", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    Pr.Fecha1 = dtpdesde.Value;
                    Pr.Fechaf = dtphasta.Value;
                    Pr.Fechaft = Convert.ToDateTime("1/1/1753 12:00:00 AM");
                    Limpiar();            
                    bs.DataSource = null;
                    dtgvproduccion.DataSource = null;
                    dt = Pr.BuscarProduccion();

                    if (dt.Rows.Count > 0)
                    {
                        txtreporte.Text = dt.Rows[0][11].ToString();
                        MostrarTodos();
                        btnregistrar.Text = "Actualizar";
                        //bs.DataSource = dt;
                        //dtgvproduccion.DataSource = bs;
                        //tabControl.SelectedTab = tablistado;
                        //dtpfecha.DataBindings.Clear();
                        //cbsupervisor.DataBindings.Clear();
                        //cboperador.DataBindings.Clear();
                        //cbayudante.DataBindings.Clear();
                        //cbturno.DataBindings.Clear();
                        //txttarjeta.DataBindings.Clear();
                        //cbmaquina.DataBindings.Clear();
                        //cbproducto.DataBindings.Clear();
                        //cbdestino.DataBindings.Clear();
                        //txtcantidad.DataBindings.Clear();
                        //dtpfecha.DataBindings.Add("Text", bs, "FECHA");
                        //cbsupervisor.DataBindings.Add("SelectedValue", bs, "SUPERVISOR", true);
                        //cboperador.DataBindings.Add("selectedvalue", bs, "OPERADOR");
                        //cbayudante.DataBindings.Add("selectedvalue", bs, "AYUDANTE");
                        //cbturno.DataBindings.Add("selectedvalue", bs, "TURNO");
                        //txttarjeta.DataBindings.Add("Text", bs, "TARJETA");
                        //cbmaquina.DataBindings.Add("selectedvalue", bs, "MÁQUINA");
                        //cbproducto.DataBindings.Add("selectedvalue", bs, "PRODUCTO");
                        //cbdestino.DataBindings.Add("selectedvalue", bs, "DESTINO");
                        //txtcantidad.DataBindings.Add("Text", bs, "CANTIDAD");
                        //lbdescripcion.Visible = true;
                        ContarRegistros();

                    }
                    else
                    {
                        MessageBoxEx.Show("No se encontraron registros", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBoxEx.Show("Fecha inicial mayor que Fecha final", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lISTADOLINEAGALVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearExcel("LINEA GALV", "LISTADO LINEA GALVANIZADO");
        }
    }
}
