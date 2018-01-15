using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using Intermedia;
using System.Windows.Forms.DataVisualization.Charting;


namespace Interfaz.Consultas
{
    public partial class frmcDetalleProduccionMaquinas : MetroForm
    {
        public frmcDetalleProduccionMaquinas()
        {
            InitializeComponent();
        }
        clsMaquina M = new clsMaquina();
        clsTurno T = new clsTurno();
        clsMonitoreoMaq Mo = new clsMonitoreoMaq();
        double min = 0;
        double max = 0;
        private void frmcDetalleProduccionMaquinas_Load(object sender, EventArgs e)
        {
            ComboM();
            ComboT();
            cmbMaquina1.SelectedIndex = -1;
            cmbTurno1.SelectedIndex = -1;
            //LlenarChart();
        }
        private void ComboM()
        {
            try
            {
                cmbMaquina.DataSource = M.Listar(true);
                cmbMaquina.DisplayMember = "DESCRIPCION";
                cmbMaquina.ValueMember = "ID_MAQUINA";
                cmbMaquina1.DataSource = M.Listar(true);
                cmbMaquina1.DisplayMember = "DESCRIPCION";
                cmbMaquina1.ValueMember = "ID_MAQUINA";
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
                cmbTurno.DataSource = T.Listar(true);
                cmbTurno.DisplayMember = "ID_TURNO";
                cmbTurno.ValueMember = "ID_TURNO";
                cmbTurno1.DataSource = T.Listar(true);
                cmbTurno1.DisplayMember = "ID_TURNO";
                cmbTurno1.ValueMember = "ID_TURNO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void LlenarChart()
        {
            try
            {
                
                if (produccionChart.Series.Count>0)
                {
                    produccionChart.Series[0].Points.Clear();
                    produccionChart.Series.RemoveAt(0);
                    txtProdMin.Clear();
                    txtUtilizacion.Clear();
 
                }
                var series = new Series("ROLLOS");
                DateTime[] xvalues=new DateTime[] { };
                DateTime[] xvalues2=new DateTime[] { };
                if (cmbTurno.SelectedValue.ToString()=="06AM02PM")
                {
                    min = 0.25;
                    max = 0.59;
                   xvalues = new DateTime []
                        {
                            new DateTime(2017,11,15,06,00,00),
                            new DateTime(2017,11,15,07,00,00),
                            new DateTime(2017,11,15,08,00,00),
                            new DateTime(2017,11,15,09,00,00),
                            new DateTime(2017,11,15,10,00,00),
                            new DateTime(2017,11,15,11,00,00),
                            new DateTime(2017,11,15,12,00,00),
                            new DateTime(2017,11,15,13,00,00),
                            new DateTime(2017,11,15,14,00,00)


                        };
                    xvalues2 = new DateTime[]
                       {
                            new DateTime(2017,11,15,07,00,00),
                            new DateTime(2017,11,15,08,00,00),
                            new DateTime(2017,11,15,09,00,00),
                            new DateTime(2017,11,15,10,00,00),
                            new DateTime(2017,11,15,11,00,00),
                            new DateTime(2017,11,15,12,00,00),
                            new DateTime(2017,11,15,13,00,00),
                            new DateTime(2017,11,15,14,00,00)

                       };
                }
                else if (cmbTurno.SelectedValue.ToString() == "02PM10PM")
                {
                    min = 0.58;
                    max = 0.94;
                    xvalues = new DateTime[]
                        {
                            new DateTime(2017,11,15,14,00,00),
                            new DateTime(2017,11,15,15,00,00),
                            new DateTime(2017,11,15,16,00,00),
                            new DateTime(2017,11,15,17,00,00),
                            new DateTime(2017,11,15,18,00,00),
                            new DateTime(2017,11,15,19,00,00),
                            new DateTime(2017,11,15,20,00,00),
                            new DateTime(2017,11,15,21,00,00),
                            new DateTime(2017,11,15,22,00,00)


                        };
                    xvalues2 = new DateTime[]
                        {
                            new DateTime(2017,11,15,15,00,00),
                            new DateTime(2017,11,15,16,00,00),
                            new DateTime(2017,11,15,17,00,00),
                            new DateTime(2017,11,15,18,00,00),
                            new DateTime(2017,11,15,19,00,00),
                            new DateTime(2017,11,15,20,00,00),
                            new DateTime(2017,11,15,21,00,00),
                            new DateTime(2017,11,15,22,00,00)

                        };
                }
                else if (cmbTurno.SelectedValue.ToString() == "10PM06AM")
                {
                    xvalues = new DateTime[]
                      {
                            new DateTime(2017,11,15,22,00,00),
                            new DateTime(2017,11,15,23,00,00),
                            new DateTime(2017,11,16,00,00,00),
                            new DateTime(2017,11,16,01,00,00),
                            new DateTime(2017,11,16,02,00,00),
                            new DateTime(2017,11,16,03,00,00),
                            new DateTime(2017,11,16,04,00,00),
                            new DateTime(2017,11,16,05,00,00)

                        };
                    xvalues2 = new DateTime[]
                      {
                            new DateTime(2017,11,15,23,00,00),
                            new DateTime(2017,11,15,00,00,00),
                            new DateTime(2017,11,16,01,00,00),
                            new DateTime(2017,11,16,02,00,00),
                            new DateTime(2017,11,16,03,00,00),
                            new DateTime(2017,11,16,04,00,00),
                            new DateTime(2017,11,16,05,00,00),
                            new DateTime(2017,11,16,06,00,00)

                        };
                }
                else if (cmbTurno.SelectedValue.ToString() == "08AM05PM")
                {
                    min = 0.33;
                    max = 0.71;
                    xvalues = new DateTime[]
                      {
                            new DateTime(2017,11,15,08,00,00),
                            new DateTime(2017,11,15,09,00,00),
                            new DateTime(2017,11,16,10,00,00),
                            new DateTime(2017,11,16,11,00,00),
                            new DateTime(2017,11,16,12,00,00),
                            new DateTime(2017,11,16,13,00,00),
                            new DateTime(2017,11,16,14,00,00),
                            new DateTime(2017,11,16,15,00,00),
                            new DateTime(2017,11,16,17,00,00)

                        };
                    xvalues2 = new DateTime[]
                      {
                            new DateTime(2017,11,15,09,00,00),
                            new DateTime(2017,11,15,10,00,00),
                            new DateTime(2017,11,16,11,00,00),
                            new DateTime(2017,11,16,12,00,00),
                            new DateTime(2017,11,16,13,00,00),
                            new DateTime(2017,11,16,14,00,00),
                            new DateTime(2017,11,16,15,00,00),
                            new DateTime(2017,11,16,17,00,00)

                        };
                }

                produccionChart.ChartAreas[0].AxisX.Interval = 1;
                produccionChart.ChartAreas[0].AxisY.Interval =3;
                series.ChartType = SeriesChartType.Line;         
                DataTable dt = new DataTable();
                DateTime aument;
                int tiempo = 0;
                int prod = 0;
                int[] yvalues= new int[xvalues.Length];
               
                Mo.Fecha = dtpFecha.Value;
                Mo.Idmaquina = cmbMaquina.SelectedValue.ToString();
                Mo.Idturno = cmbTurno.SelectedValue.ToString();
                yvalues[0] = 0;
                int b = 0;
                for(int x=1;x<=xvalues2.Length;x++)
                {
                    Mo.Horai = xvalues[b];
                    aument = xvalues[b];
                    aument=aument.AddMinutes(59);
                    aument=aument.AddSeconds(59);
                    Mo.Horaf = aument;
                    dt = Mo.ObtenerDetalleProduccion();
                    if (dt.Rows.Count > 0)
                    {
                        if (b == 0)
                        {
                            yvalues[x] = Convert.ToInt16(dt.Rows[0][0]);
                         

                        }
                        else 
                        {
                            yvalues[x] = Convert.ToInt16(dt.Rows[0][0])+yvalues[x-1];

                        }
                    }
                    dt.Rows.Clear();
                    b++;

                }
                txtUtilizacion.Clear();
                dt = Mo.ObtenerTotalDetalleProduccion();
                if (dt.Rows.Count > 0)
                {
                    tiempo = Convert.ToInt16(dt.Rows[0][0]);
                    prod = Convert.ToInt16(dt.Rows[0][1]);
                    tiempo = tiempo / 60;
                    double utilizacion = ((double)tiempo / (double)450);
                    utilizacion = Math.Round(utilizacion, 2)*100;
                    txtUtilizacion.Text = "Utilización: " + utilizacion.ToString()+" %";
                    double prodd = (double)tiempo / (double)prod;
                    prodd = Math.Round(prodd, 1);
                    txtProdMin.Text = "Mins/Rollo: " + prodd.ToString();
                    txtUtilizacion.Visible = true;
                    txtProdMin.Visible = true;
                }
               
                series.XValueType = ChartValueType.Time;
                //series.Points.DataBindXY(new[] { 14, 15, 16, 17 },new[] { 0, 4, 10, 13});
                series.Points.Clear();
                series.Points.DataBindXY(xvalues,yvalues);
                produccionChart.Series.Add(series);
                produccionChart.Series[0].BorderWidth = 3;
                produccionChart.Series[0].IsValueShownAsLabel=true;
                produccionChart.Series[0].LabelToolTip = "Rollos";
                //Console.Write(produccionChart.ChartAreas[0].AxisX.Minimum);
                produccionChart.ChartAreas[0].AxisX.Minimum = min;
                produccionChart.ChartAreas[0].AxisX.Maximum = max;
                //produccionChart.Series.RemoveAt(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            LlenarChart();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpDesde.Value.Date <= dtpHasta.Value.Date)
                {
                    frmReporte obj = new frmReporte();
                    obj.Fechai = dtpDesde.Value;
                    obj.Fechaf = dtpHasta.Value;
                    obj.Valor = 17;
                    obj.Nombre = "historial_produccion.rdlc";
                    if (cmbMaquina1.SelectedIndex != -1) //(cmbSupervisor.SelectedValue != null)
                    {
                        obj.Maquina = cmbMaquina1.SelectedValue.ToString();
                    }
                    else
                        obj.Maquina = "";

                    if (cmbTurno1.SelectedIndex != -1) //(cmbOperador.SelectedValue != null)
                    {
                        obj.Turno = cmbTurno1.SelectedValue.ToString();
                    }
                    else
                        obj.Turno = "";
                    obj.Show();
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
