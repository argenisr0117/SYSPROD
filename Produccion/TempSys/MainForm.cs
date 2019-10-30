using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TempSys
{
    public partial class MainForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        string errormsj = "";
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        string tm;
        private MccDaq.MccBoard DaqBoard;

        //Initialize variables
        public MccDaq.ErrorInfo ULStat;
        public float MyTemp = 0.0f;
        Global g = new Global();
        DataTable dt;
        DataTable dt2;
        int k = 0;
        public string TipoHorno = "";
        public int Min = 0;
        public int Max = 0;
        public int E0 = 0;
        public int E1 = 0;
        public int E2 = 0;
        public int E3 = 0;
        public int E4 = 0;
        public int E5 = 0;
        public int E6 = 0;
        public int E7 = 0;
        public bool UpdateDb = false;
        public bool UpdateLecturasDesdeBd = false;
        public int seleccionada = 0;
        public MainForm()
        {
            InitializeComponent();
            DaqBoard = new MccDaq.MccBoard(0);

        }

        private void barraSup_pn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public string ObtenerEntradas(int numeroEntrada)
        {
            string nombreEntrada = "Entrada " + numeroEntrada.ToString() + " no asignada";
            TipoHorno = "none";
            g.Numentrada = numeroEntrada;
            dt = g.ObtenerNombreEntradas();
            if (dt.Rows.Count > 0)
            {
                nombreEntrada = dt.Rows[0][0].ToString();
                TipoHorno = dt.Rows[0][1].ToString();

            }
            return nombreEntrada;

        }

        public void ValoresMinimosMaximosHornos(string horno)
        {

            g.TipoHorno = horno;
            dt = g.ObtenerMinMaxTipoHorno();
            if (dt.Rows.Count > 0)
            {
                Min = Convert.ToInt32(dt.Rows[0][0].ToString());
                Max = Convert.ToInt32(dt.Rows[0][1].ToString());

            }
            else
            {
                Min = 0;
                Max = 0;
            }

        }

        public void ActualizarValores(Int64 ValorTemperatura, Label lbl, string error)
        {
            if (error == "No error has occurred.")
            {
                if (Min == 0 && Max == 0)
                {
                    lbl.Text = "0 °F";
                    lbl.ForeColor = Color.White;

                }
                else if (ValorTemperatura <= Min)
                {
                    lbl.Text = ValorTemperatura.ToString() + " °F";
                    lbl.ForeColor = Color.Yellow;
                }
                else if (ValorTemperatura >= Max)
                {
                    lbl.Text = ValorTemperatura.ToString() + " °F";
                    lbl.ForeColor = Color.Red;
                }
                else
                {
                    lbl.Text = ValorTemperatura.ToString() + " °F";
                    lbl.ForeColor = Color.DarkGreen;
                }
            }
        }

        public void LlenarDtgTemperatura()
        {

            if (k == 0)
            {
                temps_dtgv.DataSource = null;
                temps_dtgv.DataSource = dt2;
                k = 1;
                Temp_timer.Start();
                UpdateDb_timer.Start();
            }
            else
            {
                dt2 = g.ObtenerRegistrosTemperatura();
                temps_dtgv.DataSource = null;
                temps_dtgv.DataSource = dt2;
            }

        }
        private void Temp_timer_Tick(object sender, EventArgs e)
        {
            try
            {
                Temp_timer.Stop();
                //TIn Method has the following configuration:
                //ULStat = Daqboard.TIn(Chan, Scale, TempValue, Options)
                //Where:
                //Chan is the ChannelNumber of the WLS-TC/TEMP you want to read, 
                //       select a value between 0 and 7, 128 for CJC0, 129 for CJC1

                //Scale sets the temperature scale
                //   Select a value of:
                //       MccDaq.TempScale.Celsius
                //       MccDaq.TempScale.Fahrenheit
                //       MccDaq.TempScale.Kelvin
                //       MccDaq.TempScale.NoScale
                //       MccDaq.TempScale.Volts (Volts is not supported for these devices.
                //                               Do not use it this scale, use the 'NoScale')

                //MyTemp is declared as a Single, and hold the Temperature data that is 
                //returned from the Method call.

                //Options are the bit fields that enable or disable filters
                //   Select a value of:
                //       MccDaq.ThermocoupleOptions.Filter
                //       MccDaq.ThermocoupleOptions.NoFilter

                //ULStat is the return code for errors.
                //you can choose to just show the error message as is demonstrated here by invoking
                //it with the syntax:  ULStat.Message
                //OR you can use the return code numeric value (0, 1, 2, etc.) and use a case statement
                //to service the error.  You use it with the syntax: ULStat.Value.


                lb_Entrada1.Text = ObtenerEntradas(0).ToUpper();

                //ULStat = DaqBoard.TIn(0, MccDaq.TempScale.Fahrenheit, out MyTemp, MccDaq.ThermocoupleOptions.NoFilter);
                //ValoresMinimosMaximosHornos(TipoHorno);
                //E0 = Convert.ToInt32(MyTemp);
                ////lblCh0Error.Text = ULStat.Message;
                //errormsj = ULStat.Message;
                //lb_error.Text = "Module Status: " + errormsj;
                //ActualizarValores(Convert.ToInt64(MyTemp), lb_entradaValue1, errormsj);

                lb_Entrada2.Text = ObtenerEntradas(1).ToUpper();
                //ULStat = DaqBoard.TIn(1, MccDaq.TempScale.Fahrenheit, out MyTemp, MccDaq.ThermocoupleOptions.NoFilter);
                //ValoresMinimosMaximosHornos(TipoHorno);
                //ActualizarValores(Convert.ToInt64(MyTemp), lb_entradaValue2, errormsj);
                //E1 = Convert.ToInt32(MyTemp);


                lb_Entrada3.Text = ObtenerEntradas(2).ToUpper();
                //ULStat = DaqBoard.TIn(2, MccDaq.TempScale.Fahrenheit, out MyTemp, MccDaq.ThermocoupleOptions.NoFilter);
                //ValoresMinimosMaximosHornos(TipoHorno);
                //ActualizarValores(Convert.ToInt64(MyTemp), lb_entradaValue3, errormsj);
                //E2 = Convert.ToInt32(MyTemp);
                ////lblCh2Error.Text = ULStat.Message;

                lb_Entrada4.Text = ObtenerEntradas(3).ToUpper();
                //ULStat = DaqBoard.TIn(3, MccDaq.TempScale.Fahrenheit, out MyTemp, MccDaq.ThermocoupleOptions.NoFilter);
                //ValoresMinimosMaximosHornos(TipoHorno);
                //ActualizarValores(Convert.ToInt64(MyTemp), lb_entradaValue4, errormsj);
                //E3 = Convert.ToInt32(MyTemp);
                ////lblCh3Error.Text = ULStat.Message;

                lb_Entrada5.Text = ObtenerEntradas(4).ToUpper();
                //ULStat = DaqBoard.TIn(4, MccDaq.TempScale.Fahrenheit, out MyTemp, MccDaq.ThermocoupleOptions.NoFilter);
                //ValoresMinimosMaximosHornos(TipoHorno);
                //ActualizarValores(Convert.ToInt64(MyTemp), lb_entradaValue5, errormsj);
                ////lblCh4Error.Text = ULStat.Message;
                //E4 = Convert.ToInt32(MyTemp);

                lb_Entrada6.Text = ObtenerEntradas(5).ToUpper();
                //ULStat = DaqBoard.TIn(5, MccDaq.TempScale.Fahrenheit, out MyTemp, MccDaq.ThermocoupleOptions.NoFilter);
                //ValoresMinimosMaximosHornos(TipoHorno);
                //ActualizarValores(Convert.ToInt64(MyTemp), lb_entradaValue6, errormsj);
                //E5 = Convert.ToInt32(MyTemp);
                ////lblCh5Error.Text = ULStat.Message;

                lb_Entrada7.Text = ObtenerEntradas(6).ToUpper();
                //ULStat = DaqBoard.TIn(6, MccDaq.TempScale.Fahrenheit, out MyTemp, MccDaq.ThermocoupleOptions.NoFilter);
                //ValoresMinimosMaximosHornos(TipoHorno);
                //ActualizarValores(Convert.ToInt64(MyTemp), lb_entradaValue7, errormsj);
                //E6 = Convert.ToInt32(MyTemp);
                ////lblCh6Error.Text = ULStat.Message;

                lb_Entrada8.Text = ObtenerEntradas(7).ToUpper();
                //ULStat = DaqBoard.TIn(7, MccDaq.TempScale.Fahrenheit, out MyTemp, MccDaq.ThermocoupleOptions.NoFilter);
                //ValoresMinimosMaximosHornos(TipoHorno);
                //ActualizarValores(Convert.ToInt64(MyTemp), lb_entradaValue8, errormsj);
                //E7 = Convert.ToInt32(MyTemp);
                Chart[] charts = { chartPlomoG, chartZincG, chartPlomoP };
                if (UpdateDb && errormsj == "No error has occurred.")
                {

                    g.E0 = E0;
                    g.E1 = E1;
                    g.E2 = E2;
                    g.E3 = E3;
                    g.E4 = E4;
                    g.E5 = E5;
                    g.E6 = E6;
                    g.E7 = E7;
                    g.Reg_Temperatura();
                    if (temps_dtgv.SelectedRows.Count > 0)
                    {
                        seleccionada = Convert.ToInt32(temps_dtgv.CurrentRow.Index);
                    }
                    LlenarDtgTemperatura();
                    LlenarChart();
                    LlenarChart2();
                    LlenarChart3();
                    temps_dtgv.ClearSelection();
                    temps_dtgv.Rows[seleccionada + 1].Selected = true;
                    seleccionada = Convert.ToInt32(temps_dtgv.Rows[seleccionada + 1].Index);
                    UpdateDb = false;
                    tm = DateTime.Now.ToString("HH:mm");
                    //if (tm == "07:58")
                    //{
                    //    EnviarCorreo(charts);
                    //}

                }
                if (UpdateLecturasDesdeBd && errormsj != "No error has occurred.")
                {
                    LlenarDtgTemperatura();
                    LeerTemperaturaDesdeBD();
                    tm = DateTime.Now.ToString("HH:mm");
                    //if (tm == "07:58")
                    //{
                    //    EnviarCorreo(charts);
                    //}
                }
                errormsj = "";
                Temp_timer.Start();
                //lblCh7Error.Text = ULStat.Message;

                //ULStat = DaqBoard.TIn(128, MccDaq.TempScale.Fahrenheit, out MyTemp, MccDaq.ThermocoupleOptions.NoFilter);
                //lblCJC0Value.Text = MyTemp.ToString();
                ////lblCJC0Error.Text = ULStat.Message;

                //ULStat = DaqBoard.TIn(129, MccDaq.TempScale.Fahrenheit, out MyTemp, MccDaq.ThermocoupleOptions.NoFilter);
                //lblCJC1Value.Text = MyTemp.ToString();
                ////lblCJC1Error.Text = ULStat.Message;
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public void LeerTemperaturaDesdeBD()
        {
            try
            {
                string msj = "No error has occurred.";
                DataTable dt1 = new DataTable();
                dt1 = g.ObtenerRegistrosTemperatura();
                if (dt1.Rows.Count > 0)
                {
                    ObtenerEntradas(0);
                    ValoresMinimosMaximosHornos(TipoHorno);
                    ActualizarValores(Convert.ToInt32(dt1.Rows[0][1]), lb_entradaValue1, msj); // entrada 0
                    ObtenerEntradas(1);
                    ValoresMinimosMaximosHornos(TipoHorno);

                    ActualizarValores(Convert.ToInt32(dt1.Rows[0][2]), lb_entradaValue2, msj); // entrada 1
                    ObtenerEntradas(2);
                    ValoresMinimosMaximosHornos(TipoHorno);

                    ActualizarValores(Convert.ToInt32(dt1.Rows[0][3]), lb_entradaValue3, msj); // entrada 2
                    ObtenerEntradas(3);
                    ValoresMinimosMaximosHornos(TipoHorno);

                    ActualizarValores(Convert.ToInt32(dt1.Rows[0][4]), lb_entradaValue4, msj); // entrada 3
                    ObtenerEntradas(4);
                    ValoresMinimosMaximosHornos(TipoHorno);

                    ActualizarValores(Convert.ToInt32(dt1.Rows[0][5]), lb_entradaValue5, msj); // entrada 4
                    ObtenerEntradas(5);
                    ValoresMinimosMaximosHornos(TipoHorno);

                    ActualizarValores(Convert.ToInt32(dt1.Rows[0][6]), lb_entradaValue6, msj); // entrada 5
                    ObtenerEntradas(6);
                    ValoresMinimosMaximosHornos(TipoHorno);

                    ActualizarValores(Convert.ToInt32(dt1.Rows[0][7]), lb_entradaValue7, msj); // entrada 6
                    ObtenerEntradas(7);
                    ValoresMinimosMaximosHornos(TipoHorno);

                    ActualizarValores(Convert.ToInt32(dt1.Rows[0][8]), lb_entradaValue8, msj); // entrada 7
                    UpdateLecturasDesdeBd = false;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cerrar_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            Temp_timer_Tick(e, e);
            LeerTemperaturaDesdeBD();
            LlenarChart();
            LlenarChart2();
            LlenarChart3();
            Temp_timer.Start();
            UpdateDb_timer.Start();
            backgroundWorker1.RunWorkerAsync();


        }

        private void UpdateDb_timer_Tick(object sender, EventArgs e)
        {
            UpdateDb = true;
            UpdateLecturasDesdeBd = true;
        }

        private void config_btn_Click(object sender, EventArgs e)
        {
            InputsForm obj = new InputsForm();
            obj.ShowDialog();
        }

        private void LlenarChart()
        {
            try
            {

                if (chartPlomoG.Series.Count > 0)
                {
                    //chartE0.Series[0].Points.Clear();
                    //chartE0.Series.RemoveAt(0);
                    ////chartE0.Series[1].Points.Clear();
                    //chartE0.Series.RemoveAt(1);
                    for (int y = 0; y <= chartPlomoG.Series.Count; y++)
                    {
                        chartPlomoG.Series[0].Points.Clear();
                        chartPlomoG.Series.RemoveAt(0);
                    }
                }
                var series = new Series("Entrada");
                var series1 = new Series("Salida");

                chartPlomoG.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Hours;
                chartPlomoG.ChartAreas[0].AxisX.Interval = 2;
                chartPlomoG.ChartAreas[0].AxisY.Interval = 25;
                series.ChartType = SeriesChartType.Line;
                series1.ChartType = SeriesChartType.Line;

                DataTable dt = new DataTable();

                dt = g.ObtenerRegistrosTemperaturaGrafico();
                var minY = dt.AsEnumerable().Min(x => x[5]);
                var maxY = dt.AsEnumerable().Max(x => x[6]);
                //double minLavel = Convert.ToDouble(dt.Compute("min(["+6+"])", string.Empty));
                //double minLavel = Convert.ToDouble(dt.Compute("min([Entrada Plomo Gde])", string.Empty));
                DateTime[] xvalues = new DateTime[dt.Rows.Count];
                int[] yvalues = new int[dt.Rows.Count];
                //chartE0.DataSource = dt;
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    xvalues[x] = Convert.ToDateTime(dt.Rows[x][0]);
                    yvalues[x] = Convert.ToInt32(dt.Rows[x][5]);
                }
                DateTime min = Convert.ToDateTime(xvalues[0]);
                DateTime max = Convert.ToDateTime(xvalues[dt.Rows.Count - 1]);
                max = max.AddHours(1);
                double min_ = min.ToOADate();
                double max_ = max.ToOADate();
                //series.XValueType = ChartValueType.DateTime;

                chartPlomoG.ChartAreas[0].AxisX.LabelStyle.Format = "dd-MM-yyyy hh:mm tt";
                //series.Points.DataBindXY(new[] { 14, 15, 16, 17 },new[] { 0, 4, 10, 13});
                series.Points.Clear();
                series.Points.DataBindXY(xvalues, yvalues);
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    xvalues[x] = Convert.ToDateTime(dt.Rows[x][0]);
                    yvalues[x] = Convert.ToInt32(dt.Rows[x][6]);
                }
                series1.Points.Clear();
                series1.Points.DataBindXY(xvalues, yvalues);
                chartPlomoG.Series.Add(series);
                chartPlomoG.Series.Add(series1);
                chartPlomoG.Series[0].BorderWidth = 2;
                chartPlomoG.Series[1].BorderWidth = 2;
                chartPlomoG.Series[1].Color = Color.Red;
                chartPlomoG.Series[0].Color = Color.DarkGreen;
                //chartPlomoG.Series[0].IsValueShownAsLabel = true;
                //chartE0.Series[0].LabelToolTip = "Fahrenheit";
                ////Console.Write(chartE0.ChartAreas[0].AxisX.Minimum);
                chartPlomoG.ChartAreas[0].AxisX.LabelStyle.Angle = -30;
                chartPlomoG.ChartAreas[0].AxisX.Minimum = min_;
                chartPlomoG.ChartAreas[0].AxisX.Maximum = max_;
                chartPlomoG.ChartAreas[0].AxisY.Minimum = Convert.ToDouble(minY) - 25;
                chartPlomoG.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(maxY) + 25;
                chartPlomoG.Series[0].ToolTip = "Temp. Ent: #VALY{} °F";
                chartPlomoG.Series[1].ToolTip = "Temp. Sal: #VALY{} °F";
                //chartE0.Series.RemoveAt(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } // plomo grande
        private void LlenarChart2()
        {
            try
            {

                if (chartZincG.Series.Count > 0)
                {
                    //chartE0.Series[0].Points.Clear();
                    //chartE0.Series.RemoveAt(0);
                    ////chartE0.Series[1].Points.Clear();
                    //chartE0.Series.RemoveAt(1);
                    for (int y = 0; y <= chartZincG.Series.Count; y++)
                    {
                        chartZincG.Series[0].Points.Clear();
                        chartZincG.Series.RemoveAt(0);
                    }
                }
                var series = new Series("Entrada");
                var series1 = new Series("Salida");

                chartZincG.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Hours;
                chartZincG.ChartAreas[0].AxisX.Interval = 2;
                chartZincG.ChartAreas[0].AxisY.Interval = 30;
                series.ChartType = SeriesChartType.Line;
                series1.ChartType = SeriesChartType.Line;

                DataTable dt = new DataTable();

                dt = g.ObtenerRegistrosTemperaturaGrafico();
                var minY = dt.AsEnumerable().Min(x => x[1]);
                var maxY = dt.AsEnumerable().Max(x => x[2]);
                DateTime[] xvalues = new DateTime[dt.Rows.Count];
                int[] yvalues = new int[dt.Rows.Count];
                //chartE0.DataSource = dt;
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    xvalues[x] = Convert.ToDateTime(dt.Rows[x][0]);
                    yvalues[x] = Convert.ToInt32(dt.Rows[x][1]);
                }
                DateTime min = Convert.ToDateTime(xvalues[0]);
                DateTime max = Convert.ToDateTime(xvalues[dt.Rows.Count - 1]);
                max = max.AddHours(1);
                double min_ = min.ToOADate();
                double max_ = max.ToOADate();
                //series.XValueType = ChartValueType.DateTime;

                chartZincG.ChartAreas[0].AxisX.LabelStyle.Format = "dd-MM-yyyy hh:mm tt";
                //series.Points.DataBindXY(new[] { 14, 15, 16, 17 },new[] { 0, 4, 10, 13});
                series.Points.Clear();
                series.Points.DataBindXY(xvalues, yvalues);
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    xvalues[x] = Convert.ToDateTime(dt.Rows[x][0]);
                    yvalues[x] = Convert.ToInt32(dt.Rows[x][2]);
                }
                series1.Points.Clear();
                series1.Points.DataBindXY(xvalues, yvalues);
                chartZincG.Series.Add(series);
                chartZincG.Series.Add(series1);
                chartZincG.Series[0].BorderWidth = 2;
                chartZincG.Series[1].BorderWidth = 2;
                chartZincG.Series[1].Color = Color.Red;
                chartZincG.Series[0].Color = Color.DarkGreen;
                chartZincG.Series[0].ToolTip = "Temp. Ent: #VALY{} °F";
                chartZincG.Series[1].ToolTip = "Temp. Sal: #VALY{} °F";
                //chartE0.Series[0].IsValueShownAsLabel = true;
                //chartE0.Series[0].LabelToolTip = "Fahrenheit";
                ////Console.Write(chartE0.ChartAreas[0].AxisX.Minimum);
                chartZincG.ChartAreas[0].AxisX.LabelStyle.Angle = -30;
                chartZincG.ChartAreas[0].AxisX.Minimum = min_;
                chartZincG.ChartAreas[0].AxisX.Maximum = max_;
                chartZincG.ChartAreas[0].AxisY.Minimum = Convert.ToDouble(minY) - 40;
                chartZincG.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(maxY) + 40;
                //chartE0.Series.RemoveAt(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } // zinc grande

        private void LlenarChart3()
        {
            try
            {

                if (chartPlomoP.Series.Count > 0)
                {
                    //chartE0.Series[0].Points.Clear();
                    //chartE0.Series.RemoveAt(0);
                    ////chartE0.Series[1].Points.Clear();
                    //chartE0.Series.RemoveAt(1);
                    for (int y = 0; y < chartPlomoP.Series.Count; y++)
                    {
                        chartPlomoP.Series[0].Points.Clear();
                        chartPlomoP.Series.RemoveAt(0);
                    }
                }
                //var series = new Series("Entrada");
                var series1 = new Series("Salida");

                chartPlomoP.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Hours;
                chartPlomoP.ChartAreas[0].AxisX.Interval = 2;
                chartPlomoP.ChartAreas[0].AxisY.Interval = 25;
                //series.ChartType = SeriesChartType.Line;
                series1.ChartType = SeriesChartType.Line;

                DataTable dt = new DataTable();

                dt = g.ObtenerRegistrosTemperaturaGrafico();
                DateTime[] xvalues = new DateTime[dt.Rows.Count];
                int[] yvalues = new int[dt.Rows.Count];
                var minY = dt.AsEnumerable().Min(x => x[7]);
                var maxY = dt.AsEnumerable().Max(x => x[7]);
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    xvalues[x] = Convert.ToDateTime(dt.Rows[x][0]);
                    yvalues[x] = Convert.ToInt32(dt.Rows[x][7]);
                }
                DateTime min = Convert.ToDateTime(xvalues[0]);
                DateTime max = Convert.ToDateTime(xvalues[dt.Rows.Count - 1]);
                max = max.AddHours(1);
                double min_ = min.ToOADate();
                double max_ = max.ToOADate();
                //series.XValueType = ChartValueType.DateTime;

                chartPlomoP.ChartAreas[0].AxisX.LabelStyle.Format = "dd-MM-yyyy hh:mm tt";
                //series.Points.DataBindXY(new[] { 14, 15, 16, 17 },new[] { 0, 4, 10, 13});
                //series.Points.Clear();
                //series.Points.DataBindXY(xvalues, yvalues);
                //for (int x = 0; x < dt.Rows.Count; x++)
                //{
                //    xvalues[x] = Convert.ToDateTime(dt.Rows[x][0]);
                //    yvalues[x] = Convert.ToInt32(dt.Rows[x][8]);
                //}
                series1.Points.Clear();
                series1.Points.DataBindXY(xvalues, yvalues);
                //chartE0.Series.Add(series);
                chartPlomoP.Series.Add(series1);
                chartPlomoP.Series[0].BorderWidth = 2;
                // chartE2.Series[1].BorderWidth = 2;
                //chartE2.Series[1].Color = Color.Red;
                chartPlomoP.Series[0].Color = Color.DarkGreen;
                //chartE0.Series[0].IsValueShownAsLabel = true;
                //chartE0.Series[0].LabelToolTip = "Fahrenheit";
                ////Console.Write(chartE0.ChartAreas[0].AxisX.Minimum);
                chartPlomoP.ChartAreas[0].AxisX.LabelStyle.Angle = -30;
                chartPlomoP.ChartAreas[0].AxisX.Minimum = min_;
                chartPlomoP.ChartAreas[0].AxisX.Maximum = max_;
                chartPlomoP.ChartAreas[0].AxisY.Minimum = Convert.ToDouble(minY) - 25;
                chartPlomoP.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(maxY) + 25;
                chartPlomoP.Series[0].ToolTip = "Temp. Ent: #VALY{} °F";
                //chartE2.Series[1].ToolTip = "Temp. Sal: #VALY{} °F";
                //chartE0.Series.RemoveAt(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } // plomo grande

        //private void EnviarCorreo(Chart[] chart)
        //{

        //    using (MemoryStream ms = new MemoryStream())
        //    {

        //        var correo = new MailMessage { From = new MailAddress(Properties.Settings.Default.correo, "Sistema de Producción") };
        //        correo.To.Add("rbrito@acerodelcibao.com");
        //        correo.Subject = "Gráficos de Temperatura";

        //        chart[0].SaveImage(ms, ChartImageFormat.Jpeg);
        //        byte[] i = ms.ToArray();
        //        ms.SetLength(0);
        //        correo.Attachments.Add(new Attachment(new MemoryStream(i), "PlomoGrande.jpeg"));
        //        chart[1].SaveImage(ms, ChartImageFormat.Jpeg);
        //        byte[] i1 = ms.ToArray();
        //        ms.SetLength(0);
        //        correo.Attachments.Add(new Attachment(new MemoryStream(i1), "ZincGrande.jpeg"));
        //        chart[2].SaveImage(ms, ChartImageFormat.Jpeg);
        //        byte[] i2 = ms.ToArray();
        //        correo.Attachments.Add(new Attachment(new MemoryStream(i2), "PlomoPeq.jpeg"));

        //        //correo.Attachments.Add(new Attachment(new MemoryStream(i), "Grafico.jpeg"));
        //        using (var smtpclient = new SmtpClient("acerodelcibao.com"))
        //        {
        //            smtpclient.EnableSsl = false;
        //            smtpclient.Port = 2500;
        //            smtpclient.Credentials = new System.Net.NetworkCredential(Properties.Settings.Default.correo, Properties.Settings.Default.clave);
        //            smtpclient.Send(correo);
        //        }


        //    }

        //}

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            LlenarDtgTemperatura();
            label2.Visible = false;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            dt2 = g.ObtenerRegistrosTemperatura();

        }
    }
}
