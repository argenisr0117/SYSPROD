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
using Microsoft.Reporting.WinForms;
using System.IO;


namespace Interfaz
{
    public partial class frmReporte : MetroForm
    {
        public frmReporte()
        {
            InitializeComponent();
        }
        public string NoReporte { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Fechai { get; set; }
        public DateTime Fechaf { get; set; }
        public string Destino { get; set; }
        public string Reporte { get; set; }
        public string Nombre { get; set; }
        public double Acerado { get; set; }
        public double Galvanizado { get; set; }
        public double Recocido { get; set; }
        public double Aceradoa { get; set; }
        public double Galvanizadoa { get; set; }
        public double Recocidoa { get; set; }
        public int Valor { get; set; }
        public string Empresa { get; set; }
        public string Incentivo { get; set; }

        //tickets
        public int Id { get; set; }
        public string Supervisor { get; set; }
        public string Operador { get; set; }
        public string Maquina { get; set; }
        public string Producto { get; set; }
        public string Calibre { get; set; }
        public string Cliente { get; set; }
        public string Colada { get; set; }
        public int Tarjeta { get; set; }
        public string Peso { get; set; }
        public string Diametro { get; set; }
        public string Sae { get; set; }
        public string Medio { get; set; }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            if(Valor==1)
            {
                CierreMensual();
            }
            else if(Valor==0)
            {
                ReporteDiario();
            }
            else if(Valor==2)
            {
                Incentivos();
            }
            else if(Valor==3)
            {
                Incentivo_Rollos();
            }
            else if(Valor==4)
            {
                Incentivo_Trefilado();
            }
            else if(Valor==5)
            {
                Incentivo_Flejado();
            }
            else if (Valor == 6)
            {
                Incentivo_Galvanizado();
            }
            else if (Valor == 7)
            {
                TicketTrefilado();
            }
            else if(Valor==8)
            {
                IncentivoMecanicoIndm();
            }
            else if(Valor==9)
            {
                ReporteIndm();
            }
        }

        private void TicketTrefilado()
        {
            ReportParameter[] parametros = new ReportParameter[13];
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.reimprimir_ticketTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.reimprimir_ticketTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            parametros[0] = new ReportParameter("Fecha", Fecha.ToShortDateString());
            parametros[1] = new ReportParameter("Supervisor", Supervisor.ToString());
            parametros[2] = new ReportParameter("Operador", Operador.ToString());
            parametros[3] = new ReportParameter("Maquina", Maquina.ToString());
            parametros[4] = new ReportParameter("Producto", Producto.ToString());
            parametros[5] = new ReportParameter("Calibre", Calibre.ToString());
            parametros[6] = new ReportParameter("Cliente", Cliente.ToString());
            parametros[7] = new ReportParameter("Tarjeta", Tarjeta.ToString());
            parametros[8] = new ReportParameter("Peso", Peso.ToString());
            parametros[9] = new ReportParameter("Colada", Colada.ToString());
            parametros[10] = new ReportParameter("Diametro", Diametro.ToString());
            parametros[11] = new ReportParameter("Sae", Sae.ToString());
            parametros[12] = new ReportParameter("Medio", Medio.ToString());
            //NoReporte = "0000002";
            rgta.Fill(ds.reimprimir_ticket,Id);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["reimprimir_ticket"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            //this.reportViewer1.RefreshReport();
            //lc.PrintToPrinter();
            //Byte[] mybytes = lc.Render("PDF"); //PDF //EXCEL
            //using (FileStream fs = File.Create(@"C:\Users\COMPUTOS\Documents\Visual Studio 2010\prueba.pdf"))
            //{
            //    fs.Write(mybytes, 0, mybytes.Length);
            //}
            //this.reportViewer1.RefreshReport();
            AutoPrintCls autoprintme = new AutoPrintCls(lc);
            autoprintme.Print();
            cerrar();
        }
        private void cerrar()
        {
            this.Close();
        }
        private void ReporteDiario()
        {
            ReportParameter[] parametros = new ReportParameter[5];
            this.Text = Reporte;
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.reporte_generalTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.reporte_generalTableAdapter();
            PRODUCCIONDataSetTableAdapters.reporte_general1TableAdapter rgta1 = new PRODUCCIONDataSetTableAdapters.reporte_general1TableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            parametros[0] = new ReportParameter("Fecha", Fecha.ToLongDateString());
            parametros[1] = new ReportParameter("NoReporte", NoReporte.ToString());
            parametros[2] = new ReportParameter("Acerado", Acerado.ToString());
            parametros[3] = new ReportParameter("Galvanizado", Galvanizado.ToString());
            parametros[4] = new ReportParameter("Recocido", Recocido.ToString());
            //NoReporte = "0000002";
            rgta.Fill(ds.reporte_general, NoReporte, Destino);
            rgta1.Fill(ds.reporte_general1);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["reporte_general1"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }

        private void CierreMensual()
        {
            ReportParameter[] parametros = new ReportParameter[7];
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.cierre_mensualTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.cierre_mensualTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            parametros[0] = new ReportParameter("Fecha", Fecha.ToShortDateString());
            parametros[1] = new ReportParameter("Acerado", Acerado.ToString());
            parametros[2] = new ReportParameter("Galvanizado", Galvanizado.ToString());
            parametros[3] = new ReportParameter("Recocido", Recocido.ToString());
            parametros[4] = new ReportParameter("Aceradoa", Aceradoa.ToString());
            parametros[5] = new ReportParameter("Galvanizadoa", Galvanizadoa.ToString());
            parametros[6] = new ReportParameter("Recocidoa", Recocidoa.ToString());
            //NoReporte = "0000002";
            rgta.Fill(ds.cierre_mensual,Destino);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["cierre_mensual"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
      
            this.reportViewer1.RefreshReport();
        }

        private void Incentivos()
        {
            ReportParameter[] parametros = new ReportParameter[2];
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();            
            PRODUCCIONDataSetTableAdapters.generar_incentivoTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.generar_incentivoTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            parametros[0] = new ReportParameter("Fecha", Fecha.ToShortDateString());
            parametros[1] = new ReportParameter("Empresa", Destino.ToString());
            rgta.Fill(ds.generar_incentivo, Incentivo,Empresa,Fechai,Fechaf);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["generar_incentivo"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
        private void IncentivoMecanicoIndm()
        {
            ReportParameter[] parametros = new ReportParameter[4];
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.incentivo_mecanicoTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.incentivo_mecanicoTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            parametros[0] = new ReportParameter("Fecha", Fecha.ToShortDateString());
            parametros[1] = new ReportParameter("Empresa", Destino.ToString());
            parametros[2] = new ReportParameter("Fechai", Fechai.ToShortDateString());
            parametros[3] = new ReportParameter("Fechaf", Fechaf.ToShortDateString());
            rgta.Fill(ds.incentivo_mecanico, Empresa, Fechai,Fechaf);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["incentivo_mecanico"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }


        private void Incentivo_Rollos()
        {
            ReportParameter[] parametros = new ReportParameter[4];
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.incentivo_rollos_cortTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.incentivo_rollos_cortTableAdapter();
            PRODUCCIONDataSetTableAdapters.incentivo_rollos_cort1TableAdapter rgta1 = new PRODUCCIONDataSetTableAdapters.incentivo_rollos_cort1TableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            parametros[0] = new ReportParameter("Fecha", Fecha.ToShortDateString());
            parametros[1] = new ReportParameter("Empresa", Destino.ToString());
            parametros[2] = new ReportParameter("Fechai", Fechai.ToShortDateString());
            parametros[3] = new ReportParameter("Fechaf", Fechaf.ToShortDateString());
            rgta.Fill(ds.incentivo_rollos_cort, Incentivo, Empresa, Fechai, Fechaf);
            rgta1.Fill(ds.incentivo_rollos_cort1, Incentivo, Empresa, Fechai, Fechaf);
            ReportDataSource rds = new ReportDataSource();
            ReportDataSource rds1 = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["incentivo_rollos_cort"]);
            rds1.Name = "DataSet2";
            rds1.Value = (ds.Tables["incentivo_rollos_cort1"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            lc.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();
        }

        private void Incentivo_Trefilado()
        {
            ReportParameter[] parametros = new ReportParameter[2];
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.incentivo_trefiladoTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.incentivo_trefiladoTableAdapter();
            PRODUCCIONDataSetTableAdapters.incentivo_tref_indirectoTableAdapter rgta1 = new PRODUCCIONDataSetTableAdapters.incentivo_tref_indirectoTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            parametros[0] = new ReportParameter("Fecha", Fecha.ToShortDateString());
            parametros[1] = new ReportParameter("Empresa", Destino.ToString());
            rgta.Fill(ds.incentivo_trefilado, Empresa);
            rgta1.Fill(ds.incentivo_tref_indirecto, Empresa);
            ReportDataSource rds = new ReportDataSource();
            ReportDataSource rds1 = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["incentivo_trefilado"]);
            rds1.Name = "DataSet2";
            rds1.Value = (ds.Tables["incentivo_tref_indirecto"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            lc.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();
        }
        private void Incentivo_Flejado()
        {
            ReportParameter[] parametros = new ReportParameter[2];
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.incentivo_flejadoTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.incentivo_flejadoTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            parametros[0] = new ReportParameter("Fecha", Fecha.ToShortDateString());
            parametros[1] = new ReportParameter("Empresa", Destino.ToString());
            rgta.Fill(ds.incentivo_flejado, Empresa);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["incentivo_flejado"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
        private void Incentivo_Galvanizado()
        {
            ReportParameter[] parametros = new ReportParameter[2];
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.incentivo_sup_lgTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.incentivo_sup_lgTableAdapter();
            PRODUCCIONDataSetTableAdapters.incentivo_ope_lgTableAdapter rgta1 = new PRODUCCIONDataSetTableAdapters.incentivo_ope_lgTableAdapter();
            PRODUCCIONDataSetTableAdapters.incentivo_ayu_lgTableAdapter rgta2 = new PRODUCCIONDataSetTableAdapters.incentivo_ayu_lgTableAdapter();
            PRODUCCIONDataSetTableAdapters.incentivo_total_lgTableAdapter rgta3 = new PRODUCCIONDataSetTableAdapters.incentivo_total_lgTableAdapter();
            PRODUCCIONDataSetTableAdapters.incentivo_uti_lgTableAdapter rgta4 = new PRODUCCIONDataSetTableAdapters.incentivo_uti_lgTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            parametros[0] = new ReportParameter("Fecha", Fecha.ToShortDateString());
            parametros[1] = new ReportParameter("Empresa", Destino.ToString());
            rgta.Fill(ds.incentivo_sup_lg, Empresa);
            rgta1.Fill(ds.incentivo_ope_lg, Empresa);
            rgta2.Fill(ds.incentivo_ayu_lg, Empresa);
            rgta3.Fill(ds.incentivo_total_lg, Empresa);
            rgta4.Fill(ds.incentivo_uti_lg, Empresa);
            ReportDataSource rds = new ReportDataSource();
            ReportDataSource rds1 = new ReportDataSource();
            ReportDataSource rds2 = new ReportDataSource();
            ReportDataSource rds3 = new ReportDataSource();
            ReportDataSource rds4 = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["incentivo_sup_lg"]);
            rds1.Name = "DataSet2";
            rds1.Value = (ds.Tables["incentivo_ope_lg"]);
            rds2.Name = "DataSet3";
            rds2.Value = (ds.Tables["incentivo_ayu_lg"]);
            rds3.Name = "DataSet4";
            rds3.Value = (ds.Tables["incentivo_total_lg"]);
            rds4.Name = "DataSet5";
            rds4.Value = (ds.Tables["incentivo_uti_lg"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            lc.DataSources.Add(rds1);
            lc.DataSources.Add(rds2);
            lc.DataSources.Add(rds3);
            lc.DataSources.Add(rds4);
            this.reportViewer1.RefreshReport();
        }

        private void ReporteIndm()
        {
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.reporte_diario_indmTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.reporte_diario_indmTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            //NoReporte = "0000002";
            rgta.Fill(ds.reporte_diario_indm, Fecha,Fechaf);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["reporte_diario_indm"]);
            reportViewer1.LocalReport.DataSources.Clear();
            lc.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }
    }
}
