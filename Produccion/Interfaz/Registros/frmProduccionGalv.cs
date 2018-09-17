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
    public partial class frmProduccionGalv : MetroForm
    {
        delegate void SetTextCallback(string text);
        clsProducto P = new clsProducto();
        clsEmpleado E = new clsEmpleado();
        clsMaquina M = new clsMaquina();
        clsProduccionGalv PG = new clsProduccionGalv();
        clsColada Co = new clsColada();
        clsPeso_Canasto Pc = new clsPeso_Canasto();
        clsCliente C = new clsCliente();
        clsProduccion Pr = new clsProduccion();
        public string sae1;
        public string calibre;
        public string medio;
        public string ind = "";
        frmReporte reporte = new frmReporte();


        public frmProduccionGalv()
        {
            InitializeComponent();
            Permisos();
            dtphasta.Value = DateTime.Now.AddDays(1);
            puertoSerial();
            cmbDiametro.SelectedIndex = 1;
            ComboP();
            ComboM();
            ComboO();
            ComboS();
            ComboPc();
            ComboCo();
            ComboC();
            ComboA();
            cmbSupervisor.SelectedValue = "";
            Limpiar();
            PG.Valor = 1; //valor para filtrar total produccion
            LlenarGrid();
            Produccion_Total();
            cmbOperador.SelectedValue = "";
            cmbAyudante.SelectedValue = "";
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
                //decimal res =decimal.Truncate(Convert.ToDecimal(result));
                this.txtPesoBruto.Text = result;
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                //while (sp.ReadExisting() != "CZ")
                //{
                string indata = sp.ReadLine();
                //ind = ind + indata;
                //}
                SetText(indata);
                //Console.Write(indata);
                //MessageBox.Show(indata);

                //ind = "";
                //ClosePuertoSerial();
            }
            catch (Exception ex)
            {
                //MessageBoxEx.Show(ex.Message);
            }


        }

        private void puertoSerial()
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
                DataTable dt = new DataTable();
                string[] ports = SerialPort.GetPortNames();
                dt = PG.Configuracion_Puerto("Galv");
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    serialPort1.PortName = dt.Rows[x][1].ToString();
                    serialPort1.BaudRate = Convert.ToInt32(dt.Rows[x][2]);
                }
                if (ports.Contains(serialPort1.PortName))
                {
                    serialPort1.Open();
                    serialPort1.NewLine = "\r";  //para que termine la linea;
                }
                if (timer1.Enabled == false)
                {
                    timer1.Enabled = true;
                }


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
                cmbProducto.DataSource = P.Listado_Productos_Dpto(5);
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
                cmbCliente.DataSource = C.Listado_Cliente_Combo(true, "Galv");
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
                cmbMaquina.DataSource = M.Listado_Maquinas_Galv();
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
                cmbOperador.DataSource = E.Listado_Operadores_Galv();
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
                cmbSupervisor.DataSource = E.Listado_Supervisores_Galv();
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
                cmbAyudante.DataSource = E.Listado_Ayudantes_Galv();
                cmbAyudante.DisplayMember = "NOMBRE";
                cmbAyudante.ValueMember = "ID_EMPLEADO";
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

        private void Permisos()
        {
            btnEliminar.Enabled = Program.eligalv;
            btnExportar.Enabled = Program.expgalv;
            btnbuscar1.Enabled = Program.mosgalv;
            dtpdesde.Enabled = Program.fdesgalv;
            dtphasta.Enabled = Program.fhasgalv;
            btnFiltrar.Enabled = Program.filgalv;
            btnEditar.Enabled = Program.edigalv;
            btnReimprimir.Enabled = Program.reimgalv;
        }
        private void LlenarGrid()
        {
            //int diferencia = 0;
            //TimeSpan fechas = new TimeSpan();
            DateTime fechaft = dtphasta.Value.AddDays(-1);
            if (dtpdesde.Value.Date < dtphasta.Value.Date)
            {
                lbProdT1.Text = "0.00";
                lbProdT2.Text = "0.00";
                lbProdT3.Text = "0.00";
                //fechas = dtphasta.Value.Date - dtpdesde.Value.Date;
                //diferencia = fechas.Days;
                //if (diferencia > 1)
                //{
                PG.Fecha1 = dtpdesde.Value;
                PG.Fechaft = fechaft;
                PG.Fechaf = dtphasta.Value;
                DataTable dt = new DataTable();
                dt = PG.Produccion_Diaria();
                try
                {
                    dtgvProduccion.DataSource = null;
                    dtgvProduccion.DataSource = dt;
                    dtgvProduccion.ClearSelection();
                    dtgvProduccion.Columns[10].Visible = false;
                    dtgvProduccion.Columns[11].Visible = false;
                    dtgvProduccion.Columns[12].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBoxEx.Show("Fecha inicial mayor que Fecha final", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void LlenarGrid2()
        {
            DataTable dt = new DataTable();
            dt = PG.Produccion_Diaria();
            try
            {
                dtgvProduccion.DataSource = null;
                dtgvProduccion.DataSource = dt;
                dtgvProduccion.ClearSelection();
                dtgvProduccion.Columns[10].Visible = false;

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
            //cmbOperador.SelectedValue = "";
            //cmbAyudante.SelectedValue = "";
            cmbCliente.SelectedValue = 0;
            cmbPesocanasto.SelectedValue = -1;
            cmbColada.SelectedValue = 0;
            txtDiametro.Clear();
            txtCalibre.Clear();
            txtPesoBruto.Clear();
            label14.Text = "";
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
                    dt = PG.Diametro_Producto(cmbProducto.SelectedValue.ToString());
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
                    if (sae = cmbProducto.SelectedValue.ToString().Contains("LC"))
                    {
                        txtCalibre.Text = dt.Rows[0][0].ToString();
                        label14.Text = "BC";
                        sae1 = "BC";
                    }
                    else if (sae = cmbProducto.SelectedValue.ToString().Contains("MC"))
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
            catch (Exception)
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
            var obj = new frmColada();
            obj.ShowDialog();
        }

        private void pesoCanastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new frmPesocanasto();
            obj.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var obj = new Consultas.frmcProductosDpto();
            Program.Valor3 = 5;
            Program.Valor2 = 2;
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
            double total = 0;
            int canasto = 0;
            int a = 0;
            int b = 0;
            int c = 0;
            try
            {
                if (dtpdesde.Value.Date < dtphasta.Value.Date)
                {
                    dt = PG.Total_Produccion();
                    for (int x = 0; x < dt.Rows.Count; x++)
                    {
                        if (dt.Rows[x][0].ToString() == "06AM02PM")
                        {
                            lbTurno1.Text = "TURNO1";
                            lbProdT1.Text = (Convert.ToDouble(dt.Rows[x][1]) / 100).ToString() + " QQS";
                            a = 1;
                        }
                        if (a == 0)
                        {
                            lbProdT1.Text = "";
                        }
                        if (dt.Rows[x][0].ToString() == "02PM10PM")
                        {
                            lbTurno2.Text = "TURNO2";
                            lbProdT2.Text = (Convert.ToDouble(dt.Rows[x][1]) / 100).ToString() + " QQS";
                            b = 1;
                        }
                        if (b == 0)
                        {
                            lbProdT2.Text = "";
                        }
                        if (dt.Rows[x][0].ToString() == "10PM06AM")
                        {
                            lbTurno3.Text = "TURNO3";
                            lbProdT3.Text = (Convert.ToDouble(dt.Rows[x][1]) / 100).ToString() + " QQS";
                            c = 1;
                        }
                        if (c == 0)
                        {
                            lbProdT3.Text = "";
                        }
                        total = total + (Convert.ToDouble(dt.Rows[x][1]) / 100);
                        canasto = canasto + (Convert.ToInt32(dt.Rows[x][2]));
                    }
                    lbTotalP.Text = total.ToString() + " QQS";
                    lbTotalC.Text = canasto.ToString();

                }
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
                DialogResult var = new DialogResult();
                var = MessageBoxEx.Show("Desea registrar el canasto?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (var == DialogResult.Yes)
                {
                    int h = DateTime.Now.Hour;
                    DataTable dt = new DataTable();
                    string Orden = "";
                    double qqs = 0;
                    if (cmbProducto.SelectedIndex > -1 && cmbPesocanasto.SelectedIndex > -1 && cmbSupervisor.SelectedIndex > -1 && cmbOperador.SelectedIndex > -1 && cmbMaquina.SelectedIndex > -1 && cmbProducto.SelectedIndex > -1 && cmbColada.SelectedIndex > -1 && txtPesoBruto.Text != "")
                    {
                        if (Convert.ToDouble(cmbPesocanasto.Text) > Convert.ToDouble(txtPesoBruto.Text))
                        {
                            MessageBoxEx.Show("Peso del canasto no puede ser mayor que el peso bruto!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            string mensaje = "";
                            int tarjeta = PG.SecuenciaTarjeta();
                            DateTime hora = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
                            TimeSpan hora1 = TimeSpan.Parse(hora.ToString("H\\:mm:ss"));
                            PG.Supervisor = cmbSupervisor.SelectedValue.ToString();
                            PG.Operador = cmbOperador.SelectedValue.ToString();
                            PG.Ayudante = cmbAyudante.SelectedValue.ToString();
                            PG.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                            PG.Hora = hora1;
                            PG.Cliente = Convert.ToInt32(cmbCliente.SelectedValue);
                            PG.Colada = Convert.ToInt32(cmbColada.SelectedValue);
                            PG.Producto = cmbProducto.SelectedValue.ToString();
                            PG.Maquina = cmbMaquina.SelectedValue.ToString();
                            PG.Tarjeta = tarjeta;
                            PG.Dpto = "Galv";
                            double peso = Convert.ToDouble(txtPesoBruto.Text) - Convert.ToDouble(cmbPesocanasto.SelectedValue);
                            qqs = peso / 100;
                            qqs = Math.Round(qqs, 2);
                            PG.PesoNeto = peso;
                            //////FUNCION PARA IDENTIFICAR LA EMPRESA Y EL TIPO DE TICKET///////
                            IdentificarTicket_Longitud(peso);
                            ///IDENTIFICAR ORDEN DEL CANASTO Y ACTUALIZAR DICHA ORDEN//
                            dt = PG.ObtenerOrdenCanasto();
                            for (int x = 0; x < dt.Rows.Count; x++)
                            {
                                Double cantidad = Convert.ToDouble(dt.Rows[x][2]);
                                Double cant_prod = Convert.ToDouble(dt.Rows[x][3]);
                                Double cantidad2 = cantidad;
                                if (cantidad == 0) //IDENTIFICAR SI EXISTE ALGUNA ORDEN PARA ESTE CLIENTE Y ESTE PRODUCTO, SI ES CERO, ASIGNAR S/N
                                {
                                    PG.Idorden = Convert.ToInt16(dt.Rows[x][0]);
                                    Orden = dt.Rows[x][1].ToString();
                                    break;
                                }
                                else
                                {
                                    cant_prod = cant_prod + qqs;
                                    cantidad = cantidad + 10;
                                    if (cant_prod > cantidad) //COMPLETAR ORDEN
                                    {
                                        PG.Idorden = Convert.ToInt16(dt.Rows[x][0]);
                                        PG.CompletarOrdenProduccion();
                                        if (dt.Rows.Count == 1)
                                        {
                                            Orden = "S/N";
                                            PG.Idorden = 0;
                                            break;
                                        }
                                    }
                                    else  //ACTUALIZAR ORDEN 
                                    {
                                        PG.Idorden = Convert.ToInt16(dt.Rows[x][0]);
                                        PG.PesoNeto = qqs;
                                        PG.ActCantOrdenProduccion();
                                        PG.PesoNeto = peso;
                                        Orden = dt.Rows[x][1].ToString();
                                        break;
                                    }
                                }
                            }
                            ///IDENTIFICAR ORDEN DEL CANASTO Y ACTUALIZAR DICHA ORDEN//
                            if (h > 5 && h < 14)
                            {
                                PG.Turno = "06AM02PM";
                            }
                            else if (h > 13 && h < 22)
                            {
                                PG.Turno = "02PM10PM";
                            }
                            else
                            {
                                PG.Turno = "10PM06AM";
                            }

                            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                            pictureBox1.Image = barcode.Draw(tarjeta.ToString() + "P" + peso.ToString(), 25);
                            MemoryStream ms = new MemoryStream();
                            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            byte[] Pic = ms.ToArray();
                            PG.Barcode = Pic;
                            mensaje = PG.RegistrarProduccion();
                            if (mensaje == "1")
                            {
                                MessageBoxEx.Show("Registrado con éxito!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else if (mensaje == "2")
                            {
                                MessageBoxEx.Show("Error,no se ha podido registrar! ", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            reporte.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                            reporte.Valor = 12;
                            reporte.Supervisor = cmbSupervisor.SelectedValue.ToString();
                            reporte.Maquina = cmbMaquina.Text;
                            reporte.Cliente = cmbCliente.Text;
                            reporte.Colada = cmbColada.Text;
                            reporte.Calibre = calibre;
                            reporte.Operador = cmbOperador.SelectedValue.ToString();
                            reporte.Ayudante = cmbAyudante.SelectedValue.ToString();
                            reporte.Peso = peso.ToString();
                            reporte.Tarjeta = tarjeta;
                            reporte.Diametro = txtDiametro.Text + " " + cmbDiametro.Text;
                            reporte.Producto = cmbProducto.Text;
                            reporte.Reporte = "Rollo " + tarjeta + " " + txtCalibre.Text + " " + sae1;
                            reporte.Sae = sae1;
                            reporte.Medio = medio;
                            reporte.Orden = Orden;
                            reporte.Pesokg = (peso * 0.4536).ToString("N0");
                            reporte.ShowDialog();
                            Limpiar();
                            PG.Valor = 1; //VALOR PARA FILTRAR TOTAL PROD
                            dtpdesde.Value = DateTime.Now;
                            dtphasta.Value = dtpdesde.Value.AddDays(1);
                            LlenarGrid();
                            Produccion_Total();
                        }

                    }
                    else
                    {
                        MessageBoxEx.Show("Complete todos los campos!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.ToString(), "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IdentificarTicket_Longitud(double peso)
        {
            DataTable dt2 = new DataTable();
            dt2 = PG.ObtenerProductoLongitudConversion();
            reporte.Nombre = "ticket_galvanizado.rdlc";
            reporte.Empresa = "ACERO DEL CIBAO,SRL.";
            if (dt2.Rows.Count > 0)
            {
                reporte.VerLong = "1";
                reporte.Longft = (peso * Convert.ToDouble(dt2.Rows[0][0])).ToString("N2");
                reporte.Longmt = (peso * Convert.ToDouble(dt2.Rows[0][1])).ToString("N2");
                reporte.Empresa = dt2.Rows[0][3].ToString();
                if (Convert.ToBoolean(dt2.Rows[0][2]))
                {
                    reporte.Nombre = "ticket_galvanizado_steel.rdlc";
                }
            }
            else
            {
                reporte.VerLong = "0";
                reporte.Longft = "0.00";
                reporte.Longmt = "0.00";
            }

        }
        private void frmProduccionTrefilado_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClosePuertoSerial();
        }

        private void btnbuscar1_Click(object sender, EventArgs e)
        {
            PG.Valor = 1; //VALOR PARA FILTRAR TOTAL PRODUCCION
            PG.Supervisor = "";
            PG.Maquina = "";
            PG.Cliente = 0;
            PG.Producto = "";

            LlenarGrid();
            Produccion_Total();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dtgvProduccion.SelectedRows.Count > 0)
            {
                var obj = new frmEditarRegistroTref();
                Program.Editar = 1;
                obj.Supervisor = dtgvProduccion.CurrentRow.Cells[2].Value.ToString();
                obj.Operador = dtgvProduccion.CurrentRow.Cells[3].Value.ToString();
                obj.Ayudante = dtgvProduccion.CurrentRow.Cells[4].Value.ToString();
                obj.Producto = dtgvProduccion.CurrentRow.Cells[5].Value.ToString();
                obj.Maquina = dtgvProduccion.CurrentRow.Cells[6].Value.ToString();
                obj.Peso = dtgvProduccion.CurrentRow.Cells[8].Value.ToString();
                obj.Cliente = dtgvProduccion.CurrentRow.Cells[9].Value.ToString();
                obj.Id = Convert.ToInt32(dtgvProduccion.CurrentRow.Cells[10].Value);
                obj.ShowDialog();
                if (Program.Valor == 1)
                {
                    PG.Valor = 1;//VALOR PARA FILTRAR TOTAL PRODUCCION
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
            Program.Editar = 2;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            if (dtgvProduccion.SelectedRows.Count > 0)
            {
                DialogResult var = MessageBoxEx.Show("¿Desea eliminar el registro?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (var == DialogResult.Yes)
                {
                    PG.Id = Convert.ToInt32(dtgvProduccion.CurrentRow.Cells[10].Value);
                    PG.Dpto = "Galvanizado";
                    PG.Idusuario = Program.Idusuario;
                    PG.Pcname = Environment.MachineName;
                    mensaje = PG.EliminarRegistro();
                    if (mensaje == "1")
                    {
                        MessageBoxEx.Show("Registro Eliminado!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PG.Valor = 1;//VALOR PARA FILTRAR TOTAL PRODUCCION
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
            Program.Filtrar = 1;
            Program.Fechai = dtpdesde.Value;
            Program.Fechaf = dtphasta.Value;
            obj.ShowDialog();
            if (Program.Valor == 1)
            {
                PG.Supervisor = Program.Supervisor;
                PG.Maquina = Program.Maquina;
                PG.Producto = Program.Producto;
                PG.Cliente = Program.Cliente;
                PG.Fecha1 = Program.Fechai;
                PG.Fechaf = Program.Fechaf;
                PG.Fechaft = Program.Fechaft;
                PG.Valor = 1;//VALOR PARA FILTRAR TOTAL PRODUCCION
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
            Program.Filtrar = 2;
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
                            PG.Fecha1 = dtpdesde.Value;
                            PG.Fechaft = fechaft;
                            PG.Fechaf = dtphasta.Value;
                            //Limpiar();   
                        }
                        else
                        {
                            PG.Fecha1 = dtpdesde.Value;
                            PG.Fechaf = dtphasta.Value;
                            PG.Fechaft = Convert.ToDateTime("1/1/1753 12:00:00 AM");
                            //Limpiar();

                        }
                    }
                    else
                    {
                        MessageBoxEx.Show("Fecha inicial mayor que Fecha final", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    reporte = SecuenciaReporte();
                    PG.Reporte = reporte;
                    PG.Valor = 3;
                    mensaje = PG.ExportarRegistroDpto();
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
            string reporte = "";
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

        private void btnReimprimir_Click(object sender, EventArgs e)
        {
            try
            {

                if (dtgvProduccion.SelectedRows.Count > 0)
                {
                    DataTable dt;
                    dt = PG.Reimprimir(Convert.ToInt32(dtgvProduccion.CurrentRow.Cells[10].Value), 1);
                    SeleccionarDiametro2(dt.Rows[0][10].ToString());
                    reporte.Id = Convert.ToInt32(dtgvProduccion.CurrentRow.Cells[10].Value);
                    reporte.Valor = 13;
                    reporte.Fecha = Convert.ToDateTime(dt.Rows[0][0]);
                    reporte.Supervisor = dt.Rows[0][1].ToString();
                    reporte.Operador = dt.Rows[0][2].ToString();
                    reporte.Maquina = dt.Rows[0][3].ToString();
                    reporte.Colada = dt.Rows[0][4].ToString();
                    reporte.Peso = dt.Rows[0][5].ToString();
                    reporte.Pesokg = (Convert.ToDouble(dt.Rows[0][5]) * 0.4536).ToString("N0");
                    reporte.Producto = dt.Rows[0][6].ToString();
                    reporte.Diametro = dt.Rows[0][7].ToString() + " " + "MM";
                    reporte.Cliente = dt.Rows[0][8].ToString();
                    reporte.Tarjeta = Convert.ToInt32(dt.Rows[0][11]);
                    reporte.Calibre = calibre;
                    //reporte.Nombre = "ticket_galvanizado2.rdlc";
                    reporte.Reporte = "Ticket";
                    reporte.Sae = sae1;
                    reporte.Medio = medio;
                    reporte.Ayudante = dt.Rows[0][12].ToString();
                    reporte.Orden = dt.Rows[0][13].ToString();
                    PG.Producto = dtgvProduccion.CurrentRow.Cells[12].Value.ToString();
                    PG.Cliente = Convert.ToInt32(dtgvProduccion.CurrentRow.Cells[11].Value);
                    IdentificarTicket_Longitud(Convert.ToDouble(dt.Rows[0][5]));
                    reporte.ShowDialog();
                }
            }
            catch (Exception ex)
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
                dt = PG.Diametro_Producto(CodigoProducto);
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

        private void timer1_Tick(object sender, EventArgs e) //timer para enviar peso de la balanza cada 1 segundo
        {
            try
            {
                SerialPort sp = new SerialPort();
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                }
                else
                {
                    byte[] code = { 0x05 }; //codigo para que la balanza envie el peso
                                            //string code1 = code.ToString("X2");
                                            //code1 = "0" + code1;
                    serialPort1.Write(code, 0, code.Length);
                    //Console.WriteLine(code1);
                }
            }
            catch (Exception ex)
            {
                timer1.Enabled = false;
            }


        }
    }
}
