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
using System.IO.Ports;
using System.IO;
using System.Text.RegularExpressions;
namespace Interfaz.Registros
{
    public partial class frmProduccionTrefilado : MetroForm
    {
        delegate void SetTextCallback(string text);
        clsProducto P = new clsProducto();
        clsEmpleado E = new clsEmpleado();
        clsMaquina M = new clsMaquina();
        clsProduccionTref PT = new clsProduccionTref();
        clsColada Co = new clsColada();
        clsPeso_Canasto Pc = new clsPeso_Canasto();
        clsCliente C = new clsCliente();
        clsProduccion Pr = new clsProduccion();
        public string sae1;
        public string calibre;
        public string medio;


        public frmProduccionTrefilado()
        {
            InitializeComponent();
        }

        public void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtPesoBruto.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                //var doubleArray = Regex.Split(text, @"[^0-9\.]+")
                //.Where(c => c != "." && c.Trim() != "");
                //string result = Regex.Replace(text, @"[^\d]+[^\.]$", "");
                string result = Regex.Replace(text, "[^0-9*.]", "");
                //string result = Regex.Replace(text, @"^[0-9]*\.?[0-9]*$", "");
                //text =(text.Trim(new Char[] { 'G', 'S', 'U', '+', 'l','b','.', ' ' }));
                //double var = Convert.ToDouble(result);
               // MessageBox.Show(result);
               // int num = (int)Convert.ToInt32(result);
               // MessageBox.Show(num.ToString());
                decimal res =decimal.Truncate(Convert.ToDecimal(result));
                this.txtPesoBruto.Text = res.ToString(); 
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                string indata = sp.ReadLine();
                //MessageBox.Show(indata);
                SetText(indata);
                //ClosePuertoSerial();
            }
            catch(Exception ex)
            {
                //MessageBoxEx.Show(ex.Message);
            }


        }

        private void puertoSerial()
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            DataTable dt = new DataTable();
            dt = PT.Configuracion_Puerto("Tref");
            try
            {
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    serialPort1.PortName = dt.Rows[x][1].ToString();
                    serialPort1.BaudRate = Convert.ToInt32(dt.Rows[x][2]);
                }
                serialPort1.Open();

            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ClosePuertoSerial()
        {
           
            serialPort1.Close();
            
        }
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
        private void ComboCo()
        {
            try
            {
                cmbColada.DataSource = Co.Listar(true);
                cmbColada.DisplayMember = "COLADA";
                cmbColada.ValueMember = "ID_COLADA";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void ComboPc()
        {
            try
            {
                cmbPesocanasto.DataSource = Pc.Listar(true);
                cmbPesocanasto.DisplayMember = "PESO_CANASTO";
                cmbPesocanasto.ValueMember = "PESO_CANASTO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        //void cmbProducto_MouseWheel(object sender, MouseEventArgs e)
        //{
        //    ((HandledMouseEventArgs)e).Handled = true;
        //}
        //void cmbSupervisor_MouseWheel(object sender, MouseEventArgs e)
        //{
        //    ((HandledMouseEventArgs)e).Handled = true;
        //}
        //void cmbCliente_MouseWheel(object sender, MouseEventArgs e)
        //{
        //    ((HandledMouseEventArgs)e).Handled = true;
        //}
        //void cmbOperador_MouseWheel(object sender, MouseEventArgs e)
        //{
        //    ((HandledMouseEventArgs)e).Handled = true;
        //}
        //void cmbColada_MouseWheel(object sender, MouseEventArgs e)
        //{
        //    ((HandledMouseEventArgs)e).Handled = true;
        //}
        //void cmbMaquina_MouseWheel(object sender, MouseEventArgs e)
        //{
        //    ((HandledMouseEventArgs)e).Handled = true;
        //}
        //void cmbPesocanasto_MouseWheel(object sender, MouseEventArgs e)
        //{
        //    ((HandledMouseEventArgs)e).Handled = true;
        //}
        private void frmProduccionTrefilado_Load(object sender, EventArgs e)
        {
            Permisos();
            //cmbProducto.MouseWheel += new MouseEventHandler(cmbProducto_MouseWheel);
            //cmbOperador.MouseWheel += new MouseEventHandler(cmbOperador_MouseWheel);
            //cmbCliente.MouseWheel += new MouseEventHandler(cmbCliente_MouseWheel);
            //cmbSupervisor.MouseWheel += new MouseEventHandler(cmbSupervisor_MouseWheel);
            //cmbColada.MouseWheel += new MouseEventHandler(cmbColada_MouseWheel);
            //cmbMaquina.MouseWheel += new MouseEventHandler(cmbMaquina_MouseWheel);
            //cmbPesocanasto.MouseWheel += new MouseEventHandler(cmbPesocanasto_MouseWheel);
            dtphasta.Value = DateTime.Now.AddDays(1);
            puertoSerial();
            cmbDiametro.SelectedIndex = 0;
            ComboP();
            ComboM();
            ComboO();
            ComboS();
            ComboPc();
            ComboCo();
            ComboC();
            cmbSupervisor.SelectedValue = "";
            Limpiar();
            PT.Valor = 2;
            LlenarGrid();
            Produccion_Total();    
        }
        private void Permisos()
        {
            btnEliminar.Enabled = Program.elitref;
            btnExportar.Enabled = Program.exptref;
            btnbuscar1.Enabled = Program.mostref;
            dtpdesde.Enabled = Program.fdestref;
            dtphasta.Enabled = Program.fhastref;
            btnFiltrar.Enabled = Program.filtref;
            btnEditar.Enabled = Program.editref;
            btnReimprimir.Enabled = Program.reimtref;
        }
        private void LlenarGrid()
        {
            int diferencia = 0;
            TimeSpan fechas = new TimeSpan();
            DateTime fechaft = dtphasta.Value.AddDays(-1);
            if (dtpdesde.Value.Date < dtphasta.Value.Date)
            {
                fechas = dtphasta.Value.Date - dtpdesde.Value.Date;
                diferencia = fechas.Days;
                if (diferencia > 1)
                {
                    PT.Fecha1 = dtpdesde.Value;
                    PT.Fechaft = fechaft;
                    PT.Fechaf = dtphasta.Value;
                    //Limpiar();   
                }
                else
                {
                    PT.Fecha1 = dtpdesde.Value;
                    PT.Fechaf = dtphasta.Value;
                    PT.Fechaft = Convert.ToDateTime("1/1/1753 12:00:00 AM");
                    //Limpiar();
 
                }
            }
            else
            {
                MessageBoxEx.Show("Fecha inicial mayor que Fecha final", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataTable dt = new DataTable();
            dt = PT.Produccion_Diaria();
            try
            {
                dtgvProduccion.DataSource = null;
                dtgvProduccion.DataSource = dt;
                //for (int x = 0; x < dt.Rows.Count; x++)
                //{
                //    dtgvProduccion.Rows.Add(dt.Rows[x][0]);
                //    dtgvProduccion.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                //    dtgvProduccion.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                //    dtgvProduccion.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                //    dtgvProduccion.Rows[x].Cells[3].Value = dt.Rows[x][3].ToString();
                //    dtgvProduccion.Rows[x].Cells[4].Value = dt.Rows[x][4].ToString();
                //    dtgvProduccion.Rows[x].Cells[5].Value = dt.Rows[x][5].ToString();
                //    dtgvProduccion.Rows[x].Cells[6].Value = dt.Rows[x][6].ToString();
                //    dtgvProduccion.Rows[x].Cells[7].Value = dt.Rows[x][7].ToString();
                //    dtgvProduccion.Rows[x].Cells[8].Value = dt.Rows[x][8].ToString();
                //    dtgvProduccion.Rows[x].Cells[9].Value = dt.Rows[x][9].ToString();
                //}
                dtgvProduccion.ClearSelection();
                dtgvProduccion.Columns[9].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LlenarGrid2()
        {
            DataTable dt = new DataTable();
            dt = PT.Produccion_Diaria();
            try
            {
                dtgvProduccion.DataSource = null;
                dtgvProduccion.DataSource = dt;
                //dtgvProduccion.Rows.Clear();
                //for (int x = 0; x < dt.Rows.Count; x++)
                //{
                //    dtgvProduccion.Rows.Add(dt.Rows[x][0]);
                //    dtgvProduccion.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                //    dtgvProduccion.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                //    dtgvProduccion.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                //    dtgvProduccion.Rows[x].Cells[3].Value = dt.Rows[x][3].ToString();
                //    dtgvProduccion.Rows[x].Cells[4].Value = dt.Rows[x][4].ToString();
                //    dtgvProduccion.Rows[x].Cells[5].Value = dt.Rows[x][5].ToString();
                //    dtgvProduccion.Rows[x].Cells[6].Value = dt.Rows[x][6].ToString();
                //    dtgvProduccion.Rows[x].Cells[7].Value = dt.Rows[x][7].ToString();
                //    dtgvProduccion.Rows[x].Cells[8].Value = dt.Rows[x][8].ToString();
                //    dtgvProduccion.Rows[x].Cells[9].Value = dt.Rows[x][9].ToString();
                //}
                dtgvProduccion.ClearSelection();
                dtgvProduccion.Columns[9].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            cmbProducto.SelectedValue = "";
            cmbMaquina.SelectedValue = "";
            cmbOperador.SelectedValue = "";
            cmbCliente.SelectedValue = 0;
            cmbPesocanasto.SelectedValue = -1;
            cmbColada.SelectedValue = 0;
            txtDiametro.Clear();
            txtCalibre.Clear();
            txtPesoBruto.Clear();
            label14.Text = "";
        }

        private void cmbMaquina_DropDown(object sender, EventArgs e)
        {
            ComboM();
        }

        private void cmbOperador_DropDown(object sender, EventArgs e)
        {
            ComboO();
        }

        private void cmbProducto_DropDown(object sender, EventArgs e)
        {
            ComboP();
        }

        private void cmbSupervisor_DropDown(object sender, EventArgs e)
        {
            ComboS();
        }

        private void cmbProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            SeleccionarDiametro();
        }

        private void SeleccionarDiametro()
        {
            try
            {
                if (cmbProducto.SelectedValue.ToString() != "")
                {
                    DataTable dt = new DataTable();
                    bool sae;
                    sae1 = "";
                    medio = "";
                    calibre = "";
                    int p = 0;
                    dt = PT.Diametro_Producto(cmbProducto.SelectedValue.ToString());
                    string[] words = dt.Rows[0][0].ToString().Split(' ');
                    foreach (string word in words)
                    {
                        if (p == 0)
                        {
                            calibre = word;
                        }
                        else if (p==1)
                        {
                            medio = word;
                        }
                        else
                        {
                            medio = "";
                        }
                        p++;
                    }
                    if (sae = cmbProducto.SelectedValue.ToString().Contains("LC"))
                    {
                        txtCalibre.Text = dt.Rows[0][0].ToString();
                        label14.Text = "BC";
                        sae1 = "BC";
                    }
                    else if(sae = cmbProducto.SelectedValue.ToString().Contains("MC"))
                    {
                        txtCalibre.Text = dt.Rows[0][0].ToString();
                        label14.Text = "MC";
                        sae1 = "MC";
                    }
                    else if (sae = cmbProducto.SelectedValue.ToString().Contains("HC"))
                    {
                        txtCalibre.Text = dt.Rows[0][0].ToString();
                        label14.Text = "HC";
                        sae1 = "HC";
                    }
                    else
                    {
                        txtCalibre.Text = dt.Rows[0][0].ToString();
                    }

                    if (cmbDiametro.SelectedIndex == 0)
                    {
                        txtDiametro.Text = dt.Rows[0][2].ToString();
                    }
                    else
                    {
                        txtDiametro.Text = dt.Rows[0][1].ToString();
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                return;
            }

        }

        private void cmbDiametro_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeleccionarDiametro();
        }

        private void coladasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColada obj = new frmColada();
            obj.ShowDialog();
        }

        private void pesoCanastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesocanasto obj = new frmPesocanasto();
            obj.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Consultas.frmcProductosDpto obj = new Consultas.frmcProductosDpto();
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

        private void pUERTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPuerto obj = new frmPuerto();
            obj.PortName = serialPort1.PortName;
            obj.ShowDialog();
            if (Program.Valor3 == 1)
            {
                puertoSerial();
            }
        }

        private void Produccion_Total()
        {
            DataTable dt = new DataTable();
            double total=0;
            int canasto = 0;
            int a = 0;
            int b = 0;
            dt = PT.Total_Produccion();
            try
            {
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    if(dt.Rows[x][0].ToString()== "06AM02PM")
                    {
                        lbTurno1.Text = "TURNO1";
                        lbProdT1.Text =(Convert.ToDouble(dt.Rows[x][1])/100).ToString()+" QQS";
                        a = 1;
                    }
                    if(a==0)
                    {
                        lbProdT1.Text = "";
                    }
                    if (dt.Rows[x][0].ToString() == "02PM10PM")
                    {
                        lbTurno2.Text = "TURNO2";
                        lbProdT2.Text = (Convert.ToDouble(dt.Rows[x][1]) / 100).ToString() + " QQS";
                        b = 1;
                    }
                    if(b==0)
                    {
                        lbProdT2.Text = "";
                    }
                    total = total + (Convert.ToDouble(dt.Rows[x][1]) / 100);
                    canasto=canasto+ (Convert.ToInt32(dt.Rows[x][2]));
                }
                lbTotalP.Text = total.ToString() + " QQS";
                lbTotalC.Text = canasto.ToString();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                int h = DateTime.Now.Hour;
                if (cmbProducto.SelectedIndex > -1 && cmbPesocanasto.SelectedIndex > -1 && cmbSupervisor.SelectedIndex > -1 && cmbOperador.SelectedIndex > -1 && cmbMaquina.SelectedIndex > -1 && cmbProducto.SelectedIndex > -1 && cmbColada.SelectedIndex > -1 && txtPesoBruto.Text!="")
                {
                    if(Convert.ToDouble(cmbPesocanasto.Text)>Convert.ToDouble(txtPesoBruto.Text))
                    {
                        MessageBoxEx.Show("Peso del canasto no puede ser mayor que el peso bruto!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string mensaje = "";
                        int tarjeta = PT.SecuenciaTarjeta();
                        DateTime hora = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
                        TimeSpan hora1 = TimeSpan.Parse(hora.ToString("H\\:mm"));
                        PT.Supervisor = cmbSupervisor.SelectedValue.ToString();
                        PT.Operador = cmbOperador.SelectedValue.ToString();
                        PT.Ayudante = "DESC-01";
                        PT.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        PT.Hora = hora1;
                        PT.Cliente = Convert.ToInt32(cmbCliente.SelectedValue);
                        PT.Colada = Convert.ToInt32(cmbColada.SelectedValue);
                        PT.Producto = cmbProducto.SelectedValue.ToString();
                        PT.Maquina = cmbMaquina.SelectedValue.ToString();
                        PT.Tarjeta = tarjeta;
                        if (h > 5 && h < 14)
                        {
                            PT.Turno = "06AM02PM";
                        }
                        else if (h > 13 && h < 22)
                        {
                            PT.Turno = "02PM10PM";
                        }
                        else
                        {
                            PT.Turno = "10PM06AM";
                        }
                        double peso = Convert.ToDouble(txtPesoBruto.Text) - Convert.ToDouble(cmbPesocanasto.SelectedValue);
                        PT.PesoNeto = peso;
                        Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                        pictureBox1.Image = barcode.Draw(tarjeta.ToString() + "P" + peso.ToString(), 25);
                        MemoryStream ms = new MemoryStream();
                        pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] Pic = ms.ToArray();
                        PT.Barcode = Pic;
                        mensaje = PT.RegistrarProduccion();
                        if (mensaje == "1")
                        {
                            MessageBoxEx.Show("Registrado con éxito!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (mensaje == "2")
                        {
                            MessageBoxEx.Show("Error,no se ha podido registrar! ", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        frmReporte obj = new frmReporte();
                        obj.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        obj.Valor = 7;
                        obj.Supervisor = cmbSupervisor.Text;
                        obj.Maquina = cmbMaquina.Text;
                        obj.Cliente = cmbCliente.Text;
                        obj.Colada = cmbColada.Text;
                        obj.Calibre = calibre;
                        obj.Operador = cmbOperador.SelectedValue.ToString();
                        obj.Peso = peso.ToString();
                        obj.Tarjeta = tarjeta;
                        obj.Diametro = txtDiametro.Text + " " + cmbDiametro.Text;
                        obj.Nombre = "ticket_trefilado.rdlc";
                        obj.Producto = cmbProducto.Text;
                        obj.Reporte = "Rollo "+tarjeta +" "+ txtCalibre.Text+" "+ sae1;
                        obj.Sae = sae1;
                        obj.Medio = medio;
                        obj.ShowDialog();
                        Limpiar();
                        PT.Valor = 2;
                        LlenarGrid();
                        Produccion_Total();
                    }
                   
                }
                else
                {
                    MessageBoxEx.Show("Complete todos los campos!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
               
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.ToString(), "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void frmProduccionTrefilado_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClosePuertoSerial();
        }

        private void btnbuscar1_Click(object sender, EventArgs e)
        {
            PT.Valor = 1;
            PT.Supervisor = "";
            PT.Maquina = "";
            PT.Cliente = 0;
            PT.Producto = "";
            lbProdT1.Text = "0.00";
            lbProdT2.Text = "0.00";
            LlenarGrid();
            Produccion_Total();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dtgvProduccion.SelectedRows.Count > 0)
            {
                frmEditarRegistroTref obj = new frmEditarRegistroTref();
                obj.Supervisor= dtgvProduccion.CurrentRow.Cells[2].Value.ToString();
                obj.Operador= dtgvProduccion.CurrentRow.Cells[3].Value.ToString();
                obj.Producto= dtgvProduccion.CurrentRow.Cells[4].Value.ToString();
                obj.Maquina= dtgvProduccion.CurrentRow.Cells[5].Value.ToString();
                obj.Peso= dtgvProduccion.CurrentRow.Cells[7].Value.ToString();
                obj.Cliente = dtgvProduccion.CurrentRow.Cells[8].Value.ToString();
                obj.Id = Convert.ToInt32(dtgvProduccion.CurrentRow.Cells[9].Value);
                obj.ShowDialog();
                if(Program.Valor==1)
                {
                    PT.Valor = 1;
                    LlenarGrid();
                    Produccion_Total();
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
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            if (dtgvProduccion.SelectedRows.Count > 0)
            {
                DialogResult var = MessageBoxEx.Show("¿Desea eliminar el registro?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (var == DialogResult.Yes)
                {
                    PT.Id= Convert.ToInt32(dtgvProduccion.CurrentRow.Cells[9].Value);
                    PT.Dpto = "Trefilado";
                    mensaje=PT.EliminarRegistro();
                    if(mensaje=="1")
                    {
                        MessageBoxEx.Show("Registro Eliminado!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PT.Valor = 1;
                        LlenarGrid();
                        Produccion_Total();
                    }
                    else
                    {
                        MessageBoxEx.Show("Ha ocurrido un error!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                  
                }
            }
            else
            {
                MessageBoxEx.Show("Seleccione un registro!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Consultas.frmcFiltrarRegistros obj = new Consultas.frmcFiltrarRegistros();
            obj.ShowDialog();
            if(Program.Valor==1)
            {
                PT.Supervisor = Program.Supervisor;
                PT.Maquina = Program.Maquina;
                PT.Producto = Program.Producto;
                PT.Cliente = Program.Cliente;
                PT.Fecha1 = Program.Fechai;
                PT.Fechaf = Program.Fechaf;
                PT.Fechaft = Program.Fechaft;
                PT.Valor = 1;
                LlenarGrid2();
                Produccion_Total();
            }
            else
            {
                return;
            }
            Program.Valor = 0;
            Program.Supervisor = "";
            Program.Maquina = "";
            Program.Producto = "";
            Program.Cliente = 0;
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
                    int diferencia = 0;
                    TimeSpan fechas = new TimeSpan();
                    DateTime fechaft = dtphasta.Value.AddDays(-1);
                    if (dtpdesde.Value.Date < dtphasta.Value.Date)
                    {
                        fechas = dtphasta.Value.Date - dtpdesde.Value.Date;
                        diferencia = fechas.Days;
                        if (diferencia > 1)
                        {
                            PT.Fecha1 = dtpdesde.Value;
                            PT.Fechaft = fechaft;
                            PT.Fechaf = dtphasta.Value;
                            //Limpiar();   
                        }
                        else
                        {
                            PT.Fecha1 = dtpdesde.Value;
                            PT.Fechaf = dtphasta.Value;
                            PT.Fechaft = Convert.ToDateTime("1/1/1753 12:00:00 AM");
                            //Limpiar();

                        }
                    }
                    else
                    {
                        MessageBoxEx.Show("Fecha inicial mayor que Fecha final", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    reporte = SecuenciaReporte();
                    PT.Reporte = reporte;
                    PT.Valor = 1;
                    mensaje = PT.ExportarRegistroDpto();
                    if (mensaje == "1")
                    {
                        MessageBoxEx.Show("Registros Exportados!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBoxEx.Show("Ha ocurrido un error!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string reporte="";
            try
            {
                int var;
                int var2;
                string secuencia;
          
                DataTable dtt = new DataTable();
                dtt = Pr.SecuenciaReporte();
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
                    reporte= var2.ToString();
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

        private void btnReimprimir_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (dtgvProduccion.SelectedRows.Count > 0)
                {
                    DataTable dt;
                    dt = PT.Reimprimir(Convert.ToInt32(dtgvProduccion.CurrentRow.Cells[9].Value));
                    SeleccionarDiametro2(dt.Rows[0][10].ToString());
                    frmReporte obj = new frmReporte();
                    obj.Id = Convert.ToInt32(dtgvProduccion.CurrentRow.Cells[9].Value);
                    obj.Valor = 11;
                    obj.Fecha = Convert.ToDateTime(dt.Rows[0][0]);
                    obj.Supervisor = dt.Rows[0][1].ToString();
                    obj.Operador = dt.Rows[0][2].ToString();
                    obj.Maquina = dt.Rows[0][3].ToString();
                    obj.Colada = dt.Rows[0][4].ToString();
                    obj.Peso = dt.Rows[0][5].ToString();
                    obj.Producto = dt.Rows[0][6].ToString();
                    obj.Diametro = dt.Rows[0][7].ToString() + " " + "PULG";
                    obj.Cliente = dt.Rows[0][8].ToString();
                    obj.Tarjeta=Convert.ToInt32(dt.Rows[0][11]);
                    obj.Calibre = calibre;
                    obj.Nombre = "ticket_trefilado2.rdlc";                 
                    obj.Reporte = "Ticket";
                    obj.Sae = sae1;
                    obj.Medio = medio;
                    obj.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                return;
            }
        }
        private void SeleccionarDiametro2(string CodigoProducto)
        {
            try
            {              
                    DataTable dt = new DataTable();
                    bool sae;
                    sae1 = "";
                    medio = "";
                    calibre = "";
                    int p = 0;
                    dt = PT.Diametro_Producto(CodigoProducto);
                    string[] words = dt.Rows[0][0].ToString().Split(' ');
                    foreach (string word in words)
                    {
                        if (p == 0)
                        {
                            calibre = word;
                        }
                        else if (p == 1)
                        {
                            medio = word;
                        }
                        else
                        {
                            medio = "";
                        }
                        p++;
                    }
                    if (sae = CodigoProducto.Contains("LC"))
                    {

                        sae1 = "BC";
                    }
                    else if (sae = CodigoProducto.Contains("MC"))
                    {

                        sae1 = "MC";
                    }
                    else if (sae = CodigoProducto.Contains("HC"))
                    {

                        sae1 = "HC";
                    }               
             
            }
            catch (Exception ex)
            {
                return;
            }

        }
    }
}
