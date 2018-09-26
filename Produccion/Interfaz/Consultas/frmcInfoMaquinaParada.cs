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
using System.Windows.Forms.DataVisualization.Charting;

namespace Interfaz.Consultas
{
    public partial class frmcInfoMaquinaParada : MetroForm
    {
        public frmcInfoMaquinaParada()
        {
            InitializeComponent();
        }
        clsMonitoreoMaq Mo = new clsMonitoreoMaq();
        public string Idmaquina = "";
        double min = 0;
        double max = 0;
        string turno = "";
        int Hora;
        private void frmcInfoMaquinaParada_Load(object sender, EventArgs e)
        {
            LlenarCampos();
        }

        private void LlenarCampos()
        {
            try
            {
                Mo.Idmaquina = Idmaquina;
                DataTable dt = Mo.ObtenerDetalleMaqParada();
                if (dt.Rows.Count > 0)
                {
                    panel1.Visible = true;
                    lblEstado.Visible = false;
                    txtUtilizacion.Visible = false;
                    txtProdMin.Visible = false;
                    produccionChart.Visible = false;
                    string Dpto = dt.Rows[0]["Dpto"].ToString();
                    txtMaquina.Text = dt.Rows[0]["Maquina"].ToString();
                    txtMotivo.Text = dt.Rows[0]["Motivo"].ToString();
                    dtpFecha.Value = Convert.ToDateTime(dt.Rows[0]["Fecha"]);
                    txtComentario.Text = dt.Rows[0]["Comentario"].ToString();
                    double promedio = Convert.ToDouble(dt.Rows[0]["Promedio"]);
                    DateTime fechainicial = dtpFecha.Value;
                    DateTime fechafinal = DateTime.Now;
                    DateTime fechaf2 = DateTime.Now;
                    fechaf2 = Convert.ToDateTime(fechaf2.Date.ToShortDateString() + " 10:00 PM");
                    double rollosp = 0;
                    //int cont = 0;
                    double duracion = (int)(fechaf2 - fechainicial).TotalMinutes;
                    double seg = 0;
                    if (Dpto == "Galv")
                    {
                        Mo.Duracion = Convert.ToInt16(duracion);
                    }
                    else if (Dpto == "Puas" || Dpto == "Tref" || Dpto == "IndM")
                    {
                        //double diferencia = (int)(fechaf2 - fechainicial).TotalDays;
                        double minutos = Convert.ToDouble(dt.Rows[0]["Duracion"]);
                        seg = (int)minutos * 60;
                       
                        rollosp = minutos / promedio;
                        txtTiempoparada.Text = (seg / 3600).ToString("#") + " Hrs " + ((seg % 3600) / 60).ToString("#") + " Mins";
                        rollosp = Math.Ceiling(rollosp);
                        if (promedio == 0)
                        {
                            rollosp = 0.00;
                        }
                        txtRollos.Text = rollosp.ToString() + " Rollos";

                    }
                }
                else
                {
                    panel1.Visible = false;
                    lblEstado.Visible = false;
                    txtProdMin.Visible = true;
                    txtUtilizacion.Visible = true;
                    produccionChart.Visible = true;
                    //produccionChart.BringToFront();
                    LlenarChart();
                    //lblEstado.Text = "LA MÁQUINA ESTA TRABAJANDO, SI SE MUESTRA APAGADA PUEDE QUE SE DEBA A \nQUE ESTAN SACANDO UN ROLLO O EL SUPERVISOR NO LA HA REGISTRADO COMO PARADA";
                }
            }


            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LlenarChart()
        {
            try
            {

                if (produccionChart.Series.Count > 0)
                {
                    produccionChart.Series[0].Points.Clear();
                    produccionChart.Series.RemoveAt(0);
                    //txtProdMin.Clear();
                    //txtUtilizacion.Clear();

                }
                Hora = DateTime.Now.Hour;
                if (Hora >= 8 && Hora <= 17 && (Idmaquina == "PC01" || Idmaquina == "PC02")) 
                { turno = "08AM05PM"; }
                else if (Hora > 6 && Hora <= 13)
                { turno = "06AM02PM"; }
                else if (Hora >= 14 && Hora <= 22)
                { turno = "02PM10PM"; }
                else { turno = "10PM06AM"; }

                var series = new Series("ROLLOS");
                DateTime[] xvalues = new DateTime[] { };
                DateTime[] xvalues2 = new DateTime[] { };
                if (turno == "06AM02PM")
                {
                    min = 0.25;
                    max = 0.59;
                    xvalues = new DateTime[]
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
                else if (turno == "02PM10PM")
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
                else if (turno == "10PM06AM")
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
                else if (turno == "08AM05PM")
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
                produccionChart.ChartAreas[0].AxisY.Interval = 3;
                series.ChartType = SeriesChartType.Line;
                DataTable dt = new DataTable();
                DateTime aument;
                int tiempo = 0;
                int prod = 0;
                int[] yvalues = new int[xvalues.Length];

                Mo.Fecha = DateTime.Now;
                Mo.Idmaquina = Idmaquina;
                Mo.Idturno = turno;
                yvalues[0] = 0;
                int b = 0;
                for (int x = 1; x <= xvalues2.Length; x++)
                {
                    Mo.Horai = xvalues[b];
                    aument = xvalues[b];
                    aument = aument.AddMinutes(59);
                    aument = aument.AddSeconds(59);
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
                            yvalues[x] = Convert.ToInt16(dt.Rows[0][0]) + yvalues[x - 1];

                        }
                    }
                    dt.Rows.Clear();
                    b++;

                }
                txtUtilizacion.Clear();
                txtProdMin.Clear();
                dt = Mo.ObtenerTotalDetalleProduccion();
                if (dt.Rows.Count > 0)
                {
                    tiempo = Convert.ToInt16(dt.Rows[0][0]);
                    prod = Convert.ToInt16(dt.Rows[0][1]);
                    tiempo = tiempo / 60;
                    double utilizacion = ((double)tiempo / (double)450);
                    utilizacion = Math.Round(utilizacion, 2) * 100;
                    txtUtilizacion.Text = "Utilización: " + utilizacion.ToString() + " %";
                    double prodd = (double)tiempo / (double)prod;
                    prodd = Math.Round(prodd, 1);
                    txtProdMin.Text = "Mins/Rollo: " + prodd.ToString();
                    txtUtilizacion.Visible = true;
                    txtProdMin.Visible = true;
                }

                series.XValueType = ChartValueType.Time;
                //series.Points.DataBindXY(new[] { 14, 15, 16, 17 },new[] { 0, 4, 10, 13});
                series.Points.Clear();
                series.Points.DataBindXY(xvalues, yvalues);
                produccionChart.Series.Add(series);
                produccionChart.Series[0].BorderWidth = 3;
                produccionChart.Series[0].IsValueShownAsLabel = true;
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
    }
}

