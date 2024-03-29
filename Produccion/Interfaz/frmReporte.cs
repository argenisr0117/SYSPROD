﻿using System;
using DevComponents.DotNetBar.Metro;
using Microsoft.Reporting.WinForms;


namespace Interfaz
{
    public partial class frmReporte : MetroForm
    {
        public frmReporte()
        {
            InitializeComponent();
        }

        #region Variables
        public string NoReporte { get; set; }
        public string Order1 { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Fechai { get; set; }
        public DateTime Fechaf { get; set; }
        public string Destino { get; set; }
        public string Turno { get; set; }
        public string Dpto { get; set; }
        public string Iddpto { get; set; }
        public string Idempresa { get; set; }
        public string Idempleado { get; set; }
        public string Titulo { get; set; }
        public string Titulo1 { get; set; }
        public string Reporte { get; set; }
        public string Nombre { get; set; }
        public double Acerado { get; set; }
        public double Galvanizado { get; set; }
        public double Recocido { get; set; }
        public double Aceradoa { get; set; }
        public double Galvanizadoa { get; set; }
        public double Recocidoa { get; set; }
        public int Valor { get; set; }
        public int idMotivo { get; set; }
        public int Valor_ { get; set; }
        public int Idpacking { get; set; }
        public int Idrepcalidad { get; set; }
        public string Empresa { get; set; }
        public string Incentivo { get; set; }
        public int Inicio { get; set; }
        public int Inicio1 { get; set; }
        public int Final { get; set; }
        public int Final1 { get; set; }
        public int Idalmacen { get; set; }
        public int Iduso { get; set; }
        public string Almacen { get; set; }

        public string gSupervisor { get; set; }
        public string gOperador { get; set; }
        public string gCliente { get; set; }
        public string gMaquina { get; set; }
        public string gProducto { get; set; }
        public string gAyudante { get; set; }
        public string gCategoria { get; set; }
        public string _Supervisor { get; set; }
        public string _Operador { get; set; }
        public string _Cliente { get; set; }
        public string _Maquina { get; set; }
        public string _Producto { get; set; }
        public string _Ayudante { get; set; }
<<<<<<< HEAD

        public string Pedido { get; set; }

        public int _IdRollo { get; set; }
=======
>>>>>>> bf1dba918529b9e8fe8f30955f8e6ec0e9182058
        #endregion



        //tickets
        #region TicketVariables
        public int Id { get; set; }
        public int Idcliente { get; set; }
        public string Supervisor { get; set; }
        public string Operador { get; set; }
        public string Ayudante { get; set; }
        public string Maquina { get; set; }
        public string Producto { get; set; }
        public string Calibre { get; set; }
        public string Cliente { get; set; }
        public string Colada { get; set; }
        public int Tarjeta { get; set; }
        public string Orden { get; set; }
        public string Peso { get; set; }
        public string Pesokg { get; set; }
        public string Diametro { get; set; }
        public string Sae { get; set; }
        public string Medio { get; set; }
        public string Longft { get; set; }
        public string Longmt { get; set; }
        public string VerLong { get; set; }
        #endregion

        private void frmReporte_Load(object sender, EventArgs e)
        {
            if (Valor == 1)
            {
                CierreMensual();
            }
            else if (Valor == 0)
            {
                ReporteDiario();
            }
            else if (Valor == 2)
            {
                Incentivos();
            }
            else if (Valor == 3)
            {
                Incentivo_Rollos();
            }
            else if (Valor == 4)
            {
                Incentivo_Trefilado();
            }
            else if (Valor == 5)
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
            else if (Valor == 8)
            {
                IncentivoMecanicoIndm();
            }
            else if (Valor == 9)
            {
                ReporteIndm();
            }
            else if (Valor == 10)
            {
                FiltrarProduccion();
            }
            else if (Valor == 11)
            {
                TicketTrefilado2();
            }
            else if (Valor == 12)
            {
                TicketGalvanizado();
            }
            else if (Valor == 13)
            {
                TicketGalvanizado2();
            }
            else if (Valor == 14)
            {
                PackingList();
            }
            else if (Valor == 15)
            {
                CertificadoCalidad();
            }
            else if (Valor == 16)
            {
                GraficosCertificadoCalidad();
            }
            else if (Valor == 17)
            {
                HistorialProduccion();
            }
            else if (Valor == 18)
            {
                InventarioDetallado();
            }
            else if (Valor == 19)
            {
                EntradaInventario();
            }
            else if (Valor == 20)
            {
                SalidaInventario();
            }
            else if (Valor == 21)
            {
                FiltrarProduccionResumido();
            }
            else if (Valor == 22)
            {
                GraficosMaqParada();
            }
            else if (Valor == 23)
            {
                HorasExtras();
            }
            else if (Valor == 24)
            {
                HistorialAsistencia();
            }
<<<<<<< HEAD
            else if (Valor == 25)
            {
                RecepcionAlambron();
            }
            else if (Valor == 26)
            {
                RollosAlambron();
            }
            else if (Valor == 27)
            {
                InvResumidoAlambron();
            }
            else if (Valor == 28)
            {
                InvDetalladoAlambron();
            }
            else if (Valor == 29)
            {
                TicketAlambron();
            }
            else if(Valor == 30)
            {
                SalidaInventarioAlambron();
            }
        }

        private void TicketAlambron()
        {
            //ReportParameter[] parametros = new ReportParameter[13];
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.Ticket_AlambronTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.Ticket_AlambronTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            //NoReporte = "0000002";
            rgta.Fill(ds.Ticket_Alambron,_IdRollo);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["Ticket_Alambron"]);
            reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.SetParameters(parametros);
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

=======
        }

>>>>>>> bf1dba918529b9e8fe8f30955f8e6ec0e9182058
        #region Methods
        private void TicketTrefilado2()
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
            rgta.Fill(ds.reimprimir_ticket, Id, 0);
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
        private void TicketTrefilado()
        {
            ReportParameter[] parametros = new ReportParameter[13];
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.codigo_barraTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.codigo_barraTableAdapter();
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
            rgta.Fill(ds.codigo_barra);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["codigo_barra"]);
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
        private void TicketGalvanizado()
        {
            ReportParameter[] parametros = new ReportParameter[20];
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.codigo_barra_galvTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.codigo_barra_galvTableAdapter();
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
            parametros[13] = new ReportParameter("Ayudante", Ayudante.ToString());
            parametros[14] = new ReportParameter("Orden", Orden.ToString());
            parametros[15] = new ReportParameter("Peso1", Pesokg.ToString());
            parametros[16] = new ReportParameter("Longft", Longft.ToString());
            parametros[17] = new ReportParameter("Longmt", Longmt.ToString());
            parametros[18] = new ReportParameter("Verlong", VerLong.ToString());
            parametros[19] = new ReportParameter("Empresa", Empresa.ToString());
            //NoReporte = "0000002";
            rgta.Fill(ds.codigo_barra_galv);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["codigo_barra_galv"]);
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
            //AutoPrintCls autoprintme = new AutoPrintCls(lc); **OTRA CLASE PARA IMPRIMIR AUTOMATICAMENTE 
            //autoprintme.Print();
            //cerrar();
            lc.PrintToPrinter();
            cerrar();
        }
        private void TicketGalvanizado2()
        {
            ReportParameter[] parametros = new ReportParameter[20];
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
            parametros[13] = new ReportParameter("Ayudante", Ayudante.ToString());
            parametros[14] = new ReportParameter("Orden", Orden.ToString());
            parametros[15] = new ReportParameter("Peso1", Pesokg.ToString());
            parametros[16] = new ReportParameter("Longft", Longft.ToString());
            parametros[17] = new ReportParameter("Longmt", Longmt.ToString());
            parametros[18] = new ReportParameter("Verlong", VerLong.ToString());
            parametros[19] = new ReportParameter("Empresa", Empresa.ToString());
            //NoReporte = "0000002";
            rgta.Fill(ds.reimprimir_ticket, Id, 1);
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
            //AutoPrintCls autoprintme = new AutoPrintCls(lc);
            //autoprintme.Print();
            lc.PrintToPrinter();
            cerrar();
        }
        private void cerrar()
        {
            Close();
        }
        private void ReporteDiario()
        {
            ReportParameter[] parametros = new ReportParameter[5];
            Text = Reporte;
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
            reportViewer1.RefreshReport();
        }
        private void PackingList()
        {
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.obtener_packing_listTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.obtener_packing_listTableAdapter();
            PRODUCCIONDataSetTableAdapters.obtener_detalle_packing_listTableAdapter rgta1 = new PRODUCCIONDataSetTableAdapters.obtener_detalle_packing_listTableAdapter();
            PRODUCCIONDataSetTableAdapters.obtener_detalle_packing_list2TableAdapter rgta2 = new PRODUCCIONDataSetTableAdapters.obtener_detalle_packing_list2TableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            rgta.Fill(ds.obtener_packing_list, Idpacking);
            rgta1.Fill(ds.obtener_detalle_packing_list, Idpacking, Inicio, Final);
            rgta2.Fill(ds.obtener_detalle_packing_list2, Idpacking, Inicio1, Final1);
            ReportDataSource rds = new ReportDataSource();
            ReportDataSource rds1 = new ReportDataSource();
            ReportDataSource rds2 = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["obtener_packing_list"]);
            rds1.Name = "DataSet2";
            rds1.Value = (ds.Tables["obtener_detalle_packing_list"]);
            rds2.Name = "DataSet3";
            rds2.Value = (ds.Tables["obtener_detalle_packing_list2"]);
            reportViewer1.LocalReport.DataSources.Clear();
            lc.DataSources.Add(rds);
            lc.DataSources.Add(rds1);
            lc.DataSources.Add(rds2);

            reportViewer1.RefreshReport();
        }

        private void CertificadoCalidad()
        {
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.obtener_header_certificado_calidadTableAdapter rtga = new PRODUCCIONDataSetTableAdapters.obtener_header_certificado_calidadTableAdapter();
            PRODUCCIONDataSetTableAdapters.obtener_detalle_certificado_calidadTableAdapter rtga1 = new PRODUCCIONDataSetTableAdapters.obtener_detalle_certificado_calidadTableAdapter();
            //PRODUCCIONDataSetTableAdapters.obtener_temp_grafico_diametroTableAdapter rtga2 = new PRODUCCIONDataSetTableAdapters.obtener_temp_grafico_diametroTableAdapter();
            //PRODUCCIONDataSetTableAdapters.obtener_temp_grafico_recubrimientoTableAdapter rtga3 = new PRODUCCIONDataSetTableAdapters.obtener_temp_grafico_recubrimientoTableAdapter();
            //PRODUCCIONDataSetTableAdapters.obtener_temp_grafico_resistenciaTableAdapter rtga4 = new PRODUCCIONDataSetTableAdapters.obtener_temp_grafico_resistenciaTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            rtga.Fill(ds.obtener_header_certificado_calidad, Idrepcalidad);
            rtga1.Fill(ds.obtener_detalle_certificado_calidad, Idrepcalidad);
            //rtga2.Fill(ds.obtener_temp_grafico_diametro);
            //rtga3.Fill(ds.obtener_temp_grafico_recubrimiento);
            //rtga4.Fill(ds.obtener_temp_grafico_resistencia);
            ReportDataSource rds = new ReportDataSource();
            ReportDataSource rds1 = new ReportDataSource();
            //ReportDataSource rds2 = new ReportDataSource();
            //ReportDataSource rds3 = new ReportDataSource();
            //ReportDataSource rds4 = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["obtener_header_certificado_calidad"]);
            rds1.Name = "DataSet2";
            rds1.Value = (ds.Tables["obtener_detalle_certificado_calidad"]);
            //rds2.Name = "DataSet3";
            //rds2.Value = (ds.Tables["obtener_temp_grafico_diametro"]);
            //rds3.Name = "DataSet4";
            //rds3.Value = (ds.Tables["obtener_temp_grafico_recubrimiento"]);
            //rds4.Name = "DataSet5";
            //rds4.Value = (ds.Tables["obtener_temp_grafico_resistencia"]);
            reportViewer1.LocalReport.DataSources.Clear();
            lc.DataSources.Add(rds);
            lc.DataSources.Add(rds1);
            //lc.DataSources.Add(rds2);
            //lc.DataSources.Add(rds3);
            //lc.DataSources.Add(rds4);

            reportViewer1.RefreshReport();
        }
        private void GraficosCertificadoCalidad()
        {
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.obtener_header_certificado_calidadTableAdapter rtga = new PRODUCCIONDataSetTableAdapters.obtener_header_certificado_calidadTableAdapter();
            //PRODUCCIONDataSetTableAdapters.obtener_detalle_certificado_calidadTableAdapter rtga1 = new PRODUCCIONDataSetTableAdapters.obtener_detalle_certificado_calidadTableAdapter();
            PRODUCCIONDataSetTableAdapters.obtener_temp_grafico_diametroTableAdapter rtga2 = new PRODUCCIONDataSetTableAdapters.obtener_temp_grafico_diametroTableAdapter();
            PRODUCCIONDataSetTableAdapters.obtener_temp_grafico_recubrimientoTableAdapter rtga3 = new PRODUCCIONDataSetTableAdapters.obtener_temp_grafico_recubrimientoTableAdapter();
            PRODUCCIONDataSetTableAdapters.obtener_temp_grafico_resistenciaTableAdapter rtga4 = new PRODUCCIONDataSetTableAdapters.obtener_temp_grafico_resistenciaTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            rtga.Fill(ds.obtener_header_certificado_calidad, Idrepcalidad);
            //rtga1.Fill(ds.obtener_detalle_certificado_calidad, Idrepcalidad);
            rtga2.Fill(ds.obtener_temp_grafico_diametro);
            rtga3.Fill(ds.obtener_temp_grafico_recubrimiento);
            rtga4.Fill(ds.obtener_temp_grafico_resistencia);
            ReportDataSource rds = new ReportDataSource();
            //ReportDataSource rds1 = new ReportDataSource();
            ReportDataSource rds2 = new ReportDataSource();
            ReportDataSource rds3 = new ReportDataSource();
            ReportDataSource rds4 = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["obtener_header_certificado_calidad"]);
            //rds1.Name = "DataSet2";
            //rds1.Value = (ds.Tables["obtener_detalle_certificado_calidad"]);
            rds2.Name = "DataSet3";
            rds2.Value = (ds.Tables["obtener_temp_grafico_diametro"]);
            rds3.Name = "DataSet4";
            rds3.Value = (ds.Tables["obtener_temp_grafico_recubrimiento"]);
            rds4.Name = "DataSet5";
            rds4.Value = (ds.Tables["obtener_temp_grafico_resistencia"]);
            reportViewer1.LocalReport.DataSources.Clear();
            lc.DataSources.Add(rds);
            //lc.DataSources.Add(rds1);
            lc.DataSources.Add(rds2);
            lc.DataSources.Add(rds3);
            lc.DataSources.Add(rds4);

            reportViewer1.RefreshReport();
        }
        private void PackingList()
        {
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.obtener_packing_listTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.obtener_packing_listTableAdapter();
            PRODUCCIONDataSetTableAdapters.obtener_detalle_packing_listTableAdapter rgta1 = new PRODUCCIONDataSetTableAdapters.obtener_detalle_packing_listTableAdapter();
            PRODUCCIONDataSetTableAdapters.obtener_detalle_packing_list2TableAdapter rgta2 = new PRODUCCIONDataSetTableAdapters.obtener_detalle_packing_list2TableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            rgta.Fill(ds.obtener_packing_list, Idpacking);
            rgta1.Fill(ds.obtener_detalle_packing_list, Idpacking, Inicio, Final);
            rgta2.Fill(ds.obtener_detalle_packing_list2, Idpacking, Inicio1, Final1);
            ReportDataSource rds = new ReportDataSource();
            ReportDataSource rds1 = new ReportDataSource();
            ReportDataSource rds2 = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["obtener_packing_list"]);
            rds1.Name = "DataSet2";
            rds1.Value = (ds.Tables["obtener_detalle_packing_list"]);
            rds2.Name = "DataSet3";
            rds2.Value = (ds.Tables["obtener_detalle_packing_list2"]);
            reportViewer1.LocalReport.DataSources.Clear();
            lc.DataSources.Add(rds);
            lc.DataSources.Add(rds1);
            lc.DataSources.Add(rds2);

            this.reportViewer1.RefreshReport();
        }

        private void CertificadoCalidad()
        {
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.obtener_header_certificado_calidadTableAdapter rtga = new PRODUCCIONDataSetTableAdapters.obtener_header_certificado_calidadTableAdapter();
            PRODUCCIONDataSetTableAdapters.obtener_detalle_certificado_calidadTableAdapter rtga1 = new PRODUCCIONDataSetTableAdapters.obtener_detalle_certificado_calidadTableAdapter();
            //PRODUCCIONDataSetTableAdapters.obtener_temp_grafico_diametroTableAdapter rtga2 = new PRODUCCIONDataSetTableAdapters.obtener_temp_grafico_diametroTableAdapter();
            //PRODUCCIONDataSetTableAdapters.obtener_temp_grafico_recubrimientoTableAdapter rtga3 = new PRODUCCIONDataSetTableAdapters.obtener_temp_grafico_recubrimientoTableAdapter();
            //PRODUCCIONDataSetTableAdapters.obtener_temp_grafico_resistenciaTableAdapter rtga4 = new PRODUCCIONDataSetTableAdapters.obtener_temp_grafico_resistenciaTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            rtga.Fill(ds.obtener_header_certificado_calidad, Idrepcalidad);
            rtga1.Fill(ds.obtener_detalle_certificado_calidad, Idrepcalidad);
            //rtga2.Fill(ds.obtener_temp_grafico_diametro);
            //rtga3.Fill(ds.obtener_temp_grafico_recubrimiento);
            //rtga4.Fill(ds.obtener_temp_grafico_resistencia);
            ReportDataSource rds = new ReportDataSource();
            ReportDataSource rds1 = new ReportDataSource();
            //ReportDataSource rds2 = new ReportDataSource();
            //ReportDataSource rds3 = new ReportDataSource();
            //ReportDataSource rds4 = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["obtener_header_certificado_calidad"]);
            rds1.Name = "DataSet2";
            rds1.Value = (ds.Tables["obtener_detalle_certificado_calidad"]);
            //rds2.Name = "DataSet3";
            //rds2.Value = (ds.Tables["obtener_temp_grafico_diametro"]);
            //rds3.Name = "DataSet4";
            //rds3.Value = (ds.Tables["obtener_temp_grafico_recubrimiento"]);
            //rds4.Name = "DataSet5";
            //rds4.Value = (ds.Tables["obtener_temp_grafico_resistencia"]);
            reportViewer1.LocalReport.DataSources.Clear();
            lc.DataSources.Add(rds);
            lc.DataSources.Add(rds1);
            //lc.DataSources.Add(rds2);
            //lc.DataSources.Add(rds3);
            //lc.DataSources.Add(rds4);

            this.reportViewer1.RefreshReport();
        }
        private void GraficosCertificadoCalidad()
        {
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.obtener_header_certificado_calidadTableAdapter rtga = new PRODUCCIONDataSetTableAdapters.obtener_header_certificado_calidadTableAdapter();
            //PRODUCCIONDataSetTableAdapters.obtener_detalle_certificado_calidadTableAdapter rtga1 = new PRODUCCIONDataSetTableAdapters.obtener_detalle_certificado_calidadTableAdapter();
            PRODUCCIONDataSetTableAdapters.obtener_temp_grafico_diametroTableAdapter rtga2 = new PRODUCCIONDataSetTableAdapters.obtener_temp_grafico_diametroTableAdapter();
            PRODUCCIONDataSetTableAdapters.obtener_temp_grafico_recubrimientoTableAdapter rtga3 = new PRODUCCIONDataSetTableAdapters.obtener_temp_grafico_recubrimientoTableAdapter();
            PRODUCCIONDataSetTableAdapters.obtener_temp_grafico_resistenciaTableAdapter rtga4 = new PRODUCCIONDataSetTableAdapters.obtener_temp_grafico_resistenciaTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            rtga.Fill(ds.obtener_header_certificado_calidad, Idrepcalidad);
            //rtga1.Fill(ds.obtener_detalle_certificado_calidad, Idrepcalidad);
            rtga2.Fill(ds.obtener_temp_grafico_diametro);
            rtga3.Fill(ds.obtener_temp_grafico_recubrimiento);
            rtga4.Fill(ds.obtener_temp_grafico_resistencia);
            ReportDataSource rds = new ReportDataSource();
            //ReportDataSource rds1 = new ReportDataSource();
            ReportDataSource rds2 = new ReportDataSource();
            ReportDataSource rds3 = new ReportDataSource();
            ReportDataSource rds4 = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["obtener_header_certificado_calidad"]);
            //rds1.Name = "DataSet2";
            //rds1.Value = (ds.Tables["obtener_detalle_certificado_calidad"]);
            rds2.Name = "DataSet3";
            rds2.Value = (ds.Tables["obtener_temp_grafico_diametro"]);
            rds3.Name = "DataSet4";
            rds3.Value = (ds.Tables["obtener_temp_grafico_recubrimiento"]);
            rds4.Name = "DataSet5";
            rds4.Value = (ds.Tables["obtener_temp_grafico_resistencia"]);
            reportViewer1.LocalReport.DataSources.Clear();
            lc.DataSources.Add(rds);
            //lc.DataSources.Add(rds1);
            lc.DataSources.Add(rds2);
            lc.DataSources.Add(rds3);
            lc.DataSources.Add(rds4);

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
            rgta.Fill(ds.cierre_mensual, Destino);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["cierre_mensual"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);

<<<<<<< HEAD
            reportViewer1.RefreshReport();
=======
            this.reportViewer1.RefreshReport();
>>>>>>> bf1dba918529b9e8fe8f30955f8e6ec0e9182058
        }
        private void Incentivos()
        {
            ReportParameter[] parametros = new ReportParameter[3];
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.generar_incentivoTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.generar_incentivoTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            parametros[0] = new ReportParameter("Fecha", Fecha.ToShortDateString());
            parametros[1] = new ReportParameter("Empresa", Destino.ToString());
            parametros[2] = new ReportParameter("Idcliente", Idcliente.ToString());
            rgta.Fill(ds.generar_incentivo, Incentivo, Empresa, Fechai, Fechaf, Idcliente);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["generar_incentivo"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        private void IncentivoMecanicoIndm()
        {
            ReportParameter[] parametros = new ReportParameter[4];
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.incentivo_mecanicoTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.incentivo_mecanicoTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            //reportViewer1.ProcessingMode = ProcessingMode.Remote;
            LocalReport lc = reportViewer1.LocalReport;
            //ServerReport sr = reportViewer1.ServerReport;
            //System.Net.ICredentials credentials = System.Net.CredentialCache.DefaultCredentials;
            //ReportServerCredentials rsCredentials = sr.ReportServerCredentials;
            //rsCredentials.NetworkCredentials = credentials;

            //sr.ReportServerUrl = new Uri("http://computos-pc:8081/ReportServer");
            //sr.ReportPath = "/incentivo_mecanico_indm";
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            //parametros[0] = new ReportParameter("Fecha", Fecha.ToShortDateString());
            parametros[0] = new ReportParameter("Empresa", Destino.ToString());
            parametros[1] = new ReportParameter("Fechai", Fechai.ToShortDateString());
            parametros[2] = new ReportParameter("Fechaf", Fechaf.ToShortDateString());
            parametros[3] = new ReportParameter("Idcliente", Idcliente.ToString());
            rgta.Fill(ds.incentivo_mecanico, Empresa, Fechai, Fechaf, Idcliente);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["incentivo_mecanico"]);
            reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.ServerReport.SetParameters(parametros);
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        private void GraficosMaqParada()
        {
            ReportParameter[] parametros = new ReportParameter[4];
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.obt_graficos_maq_paradaTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.obt_graficos_maq_paradaTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            parametros[0] = new ReportParameter("Fechai", Fechai.ToShortDateString());
            parametros[1] = new ReportParameter("Fechaf", Fechaf.ToShortDateString());
            parametros[2] = new ReportParameter("Titulo", Titulo);
            parametros[3] = new ReportParameter("Titulo1", Titulo1);
            rgta.Fill(ds.obt_graficos_maq_parada, Maquina, Dpto, idMotivo, Valor_, Fechai, Fechaf);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["obt_graficos_maq_parada"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
<<<<<<< HEAD
            reportViewer1.RefreshReport();
=======
            this.reportViewer1.RefreshReport();
>>>>>>> bf1dba918529b9e8fe8f30955f8e6ec0e9182058
        }
        private void Incentivo_Rollos()
        {
            ReportParameter[] parametros = new ReportParameter[5];
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.incentivo_rollos_cortTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.incentivo_rollos_cortTableAdapter();
            PRODUCCIONDataSetTableAdapters.incentivo_rollos_cort1TableAdapter rgta1 = new PRODUCCIONDataSetTableAdapters.incentivo_rollos_cort1TableAdapter();
            PRODUCCIONDataSetTableAdapters.incentivo_rollos_cort2TableAdapter rgta2 = new PRODUCCIONDataSetTableAdapters.incentivo_rollos_cort2TableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            parametros[0] = new ReportParameter("Fecha", Fecha.ToShortDateString());
            parametros[1] = new ReportParameter("Empresa", Destino.ToString());
            parametros[2] = new ReportParameter("Fechai", Fechai.ToShortDateString());
            parametros[3] = new ReportParameter("Fechaf", Fechaf.ToShortDateString());
            parametros[4] = new ReportParameter("Idcliente", Idcliente.ToString());
            rgta.Fill(ds.incentivo_rollos_cort, Incentivo, Empresa, Fechai, Fechaf, Idcliente);
            rgta1.Fill(ds.incentivo_rollos_cort1, Incentivo, Empresa, Fechai, Fechaf, Idcliente);
            rgta2.Fill(ds.incentivo_rollos_cort2, Incentivo, Empresa, Fechai, Fechaf, Idcliente);
            ReportDataSource rds = new ReportDataSource();
            ReportDataSource rds1 = new ReportDataSource();
            ReportDataSource rds2 = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["incentivo_rollos_cort"]);
            rds1.Name = "DataSet2";
            rds1.Value = (ds.Tables["incentivo_rollos_cort1"]);
            rds2.Name = "DataSet3";
            rds2.Value = (ds.Tables["incentivo_rollos_cort2"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            lc.DataSources.Add(rds1);
            lc.DataSources.Add(rds2);
            reportViewer1.RefreshReport();
        }
        private void Incentivo_Trefilado()
        {
            ReportParameter[] parametros = new ReportParameter[3];
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.incentivo_trefiladoTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.incentivo_trefiladoTableAdapter();
            PRODUCCIONDataSetTableAdapters.incentivo_tref_indirectoTableAdapter rgta1 = new PRODUCCIONDataSetTableAdapters.incentivo_tref_indirectoTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            parametros[0] = new ReportParameter("Fecha", Fecha.ToShortDateString());
            parametros[1] = new ReportParameter("Empresa", Destino.ToString());
            parametros[2] = new ReportParameter("Idcliente", Idcliente.ToString());
            rgta.Fill(ds.incentivo_trefilado, Empresa, Idcliente);
            rgta1.Fill(ds.incentivo_tref_indirecto, Empresa, Idcliente);
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
            reportViewer1.RefreshReport();
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
            reportViewer1.RefreshReport();
        }
        private void HorasExtras()
        {
            ReportParameter[] parametros = new ReportParameter[4];
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.obt_registros_horas_extrasTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.obt_registros_horas_extrasTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            parametros[0] = new ReportParameter("Empresa", Empresa.ToString());
            parametros[1] = new ReportParameter("Fechai", Fechai.ToShortDateString());
            parametros[2] = new ReportParameter("Fechaf", Fechaf.ToShortDateString());
            parametros[3] = new ReportParameter("Dpto", Dpto.ToString());
            rgta.Fill(ds.obt_registros_horas_extras, Fechai, Fechaf, Iddpto, Idempresa);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["obt_registros_horas_extras"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            reportViewer1.ZoomPercent = 125;
            reportViewer1.RefreshReport();
        }
        private void HistorialAsistencia()
        {
            ReportParameter[] parametros = new ReportParameter[2];
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.obt_historial_asistenciaTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.obt_historial_asistenciaTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;

            parametros[0] = new ReportParameter("Fechai", Fechai.ToShortDateString());
            parametros[1] = new ReportParameter("Fechaf", Fechaf.ToShortDateString());
            rgta.Fill(ds.obt_historial_asistencia, Fechai, Fechaf, Iddpto, Idempleado);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["obt_historial_asistencia"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            reportViewer1.ZoomPercent = 125;
            reportViewer1.RefreshReport();
        }
        private void HorasExtras()
        {
            ReportParameter[] parametros = new ReportParameter[4];
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.obt_registros_horas_extrasTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.obt_registros_horas_extrasTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            parametros[0] = new ReportParameter("Empresa", Empresa.ToString());
            parametros[1] = new ReportParameter("Fechai", Fechai.ToShortDateString());
            parametros[2] = new ReportParameter("Fechaf", Fechaf.ToShortDateString());
            parametros[3] = new ReportParameter("Dpto", Dpto.ToString());
            rgta.Fill(ds.obt_registros_horas_extras, Fechai, Fechaf, Iddpto, Idempresa);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["obt_registros_horas_extras"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            reportViewer1.ZoomPercent = 125;
            this.reportViewer1.RefreshReport();
        }
        private void HistorialAsistencia()
        {
            ReportParameter[] parametros = new ReportParameter[2];
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.obt_historial_asistenciaTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.obt_historial_asistenciaTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;

            parametros[0] = new ReportParameter("Fechai", Fechai.ToShortDateString());
            parametros[1] = new ReportParameter("Fechaf", Fechaf.ToShortDateString());
            rgta.Fill(ds.obt_historial_asistencia, Fechai, Fechaf, Iddpto, Idempleado);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["obt_historial_asistencia"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            reportViewer1.ZoomPercent = 125;
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
            reportViewer1.RefreshReport();
        }
        private void ReporteIndm()
        {
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("Fecha", Fecha.ToShortDateString());
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.reporte_diario_indmTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.reporte_diario_indmTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            //NoReporte = "0000002";
            rgta.Fill(ds.reporte_diario_indm, Fecha, Fechaf);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["reporte_diario_indm"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);

            reportViewer1.RefreshReport();
        }
        private void FiltrarProduccion()
        {
            ReportParameter[] parametros = new ReportParameter[3];
            Text = Reporte;
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.filtrar_produccionTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.filtrar_produccionTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            parametros[0] = new ReportParameter("Fechai", Fechai.ToShortDateString());
            parametros[1] = new ReportParameter("Fechaf", Fechaf.ToShortDateString());
            parametros[2] = new ReportParameter("Orden1", Order1.ToString());
            rgta.Fill(ds.filtrar_produccion, Supervisor, int.Parse(Cliente), Maquina, Producto, Operador, Ayudante, Fechai, Fechaf, 1);
<<<<<<< HEAD
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["filtrar_produccion"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        private void FiltrarProduccionResumido()
        {
            ReportParameter[] parametros = new ReportParameter[15];
            Text = Reporte;
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.filtrar_produccionTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.filtrar_produccionTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            parametros[0] = new ReportParameter("Fechai", Fechai.ToShortDateString());
            parametros[1] = new ReportParameter("Fechaf", Fechaf.ToShortDateString());
            parametros[2] = new ReportParameter("Goperador", gOperador.ToString());
            parametros[3] = new ReportParameter("Gcliente", gCliente.ToString());
            parametros[4] = new ReportParameter("Gsupervisor", gSupervisor.ToString());
            parametros[5] = new ReportParameter("Gproducto", gProducto.ToString());
            parametros[6] = new ReportParameter("Gmaquina", gMaquina.ToString());
            parametros[7] = new ReportParameter("Gayudante", gAyudante.ToString());
            parametros[8] = new ReportParameter("Operador", _Operador.ToString());
            parametros[9] = new ReportParameter("Cliente", _Cliente.ToString());
            parametros[10] = new ReportParameter("Supervisor", _Supervisor.ToString());
            parametros[11] = new ReportParameter("Producto", _Producto.ToString());
            parametros[12] = new ReportParameter("Maquina", _Maquina.ToString());
            parametros[13] = new ReportParameter("Ayudante", _Ayudante.ToString());
            parametros[14] = new ReportParameter("Gcategoria", gCategoria.ToString());
            rgta.Fill(ds.filtrar_produccion, Supervisor, int.Parse(Cliente), Maquina, Producto, Operador, Ayudante, Fechai, Fechaf, 1);
=======
>>>>>>> bf1dba918529b9e8fe8f30955f8e6ec0e9182058
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["filtrar_produccion"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        private void HistorialProduccion()
        {
            ReportParameter[] parametros = new ReportParameter[2];
            Text = Reporte;
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.Obtener_produccion_totalTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.Obtener_produccion_totalTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            parametros[0] = new ReportParameter("Fechai", Fechai.ToShortDateString());
            parametros[1] = new ReportParameter("Fechaf", Fechaf.ToShortDateString());
            //parametros[2] = new ReportParameter("Orden1", Order1.ToString());
            rgta.Fill(ds.Obtener_produccion_total, Fechai, Fechaf, Turno, Maquina);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["Obtener_produccion_total"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        private void InventarioDetallado()
        {
            ReportParameter[] parametros = new ReportParameter[1];
            Text = Reporte;
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.rpt_inv_alm_detTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.rpt_inv_alm_detTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            parametros[0] = new ReportParameter("Almacen", Almacen.ToString());
            //parametros[2] = new ReportParameter("Orden1", Order1.ToString());
            rgta.Fill(ds.rpt_inv_alm_det, Idalmacen);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["rpt_inv_alm_det"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void EntradaInventario()
        {
            ReportParameter[] parametros = new ReportParameter[3];
            Text = Reporte;
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.obt_ent_almTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.obt_ent_almTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            parametros[0] = new ReportParameter("Fechai", Fechai.ToShortDateString());
            parametros[1] = new ReportParameter("Fechaf", Fechaf.ToShortDateString());
            parametros[2] = new ReportParameter("Almacen", Almacen.ToString());
            rgta.Fill(ds.obt_ent_alm, Fechai, Fechaf, Idalmacen, NoReporte);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["obt_ent_alm"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        private void SalidaInventario()
        {
            ReportParameter[] parametros = new ReportParameter[3];
            Text = Reporte;
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.obt_sal_almTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.obt_sal_almTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            parametros[0] = new ReportParameter("Fechai", Fechai.ToShortDateString());
            parametros[1] = new ReportParameter("Fechaf", Fechaf.ToShortDateString());
            parametros[2] = new ReportParameter("Almacen", Almacen.ToString());
            rgta.Fill(ds.obt_sal_alm, Idalmacen, Iduso, Producto, Fechai, Fechaf);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["obt_sal_alm"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void SalidaInventarioAlambron()
        {
            ReportParameter[] parametros = new ReportParameter[3];
            Text = Reporte;
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.obt_sal_alm_alambronTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.obt_sal_alm_alambronTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            parametros[0] = new ReportParameter("Fechai", Fechai.ToShortDateString());
            parametros[1] = new ReportParameter("Fechaf", Fechaf.ToShortDateString());
            parametros[2] = new ReportParameter("Almacen", Almacen.ToString());
            rgta.Fill(ds.obt_sal_alm_alambron, Idalmacen, Idcliente, Fechai, Fechaf);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["obt_sal_alm_alambron"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        private void RecepcionAlambron()
        {
            //ReportParameter[] parametros = new ReportParameter[3];
            Text = Reporte;
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.Rpt_Recep_AlambronTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.Rpt_Recep_AlambronTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            //parametros[0] = new ReportParameter("Fechai", Fechai.ToShortDateString());
            //parametros[1] = new ReportParameter("Fechaf", Fechaf.ToShortDateString());
            //parametros[2] = new ReportParameter("Almacen", Almacen.ToString());
            rgta.Fill(ds.Rpt_Recep_Alambron, Pedido,Idcliente);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["Rpt_Recep_Alambron"]);
            reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        private void FiltrarProduccionResumido()
        {
            ReportParameter[] parametros = new ReportParameter[15];
            this.Text = Reporte;
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.filtrar_produccionTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.filtrar_produccionTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            parametros[0] = new ReportParameter("Fechai", Fechai.ToShortDateString());
            parametros[1] = new ReportParameter("Fechaf", Fechaf.ToShortDateString());
            parametros[2] = new ReportParameter("Goperador", gOperador.ToString());
            parametros[3] = new ReportParameter("Gcliente", gCliente.ToString());
            parametros[4] = new ReportParameter("Gsupervisor", gSupervisor.ToString());
            parametros[5] = new ReportParameter("Gproducto", gProducto.ToString());
            parametros[6] = new ReportParameter("Gmaquina", gMaquina.ToString());
            parametros[7] = new ReportParameter("Gayudante", gAyudante.ToString());
            parametros[8] = new ReportParameter("Operador", _Operador.ToString());
            parametros[9] = new ReportParameter("Cliente", _Cliente.ToString());
            parametros[10] = new ReportParameter("Supervisor", _Supervisor.ToString());
            parametros[11] = new ReportParameter("Producto", _Producto.ToString());
            parametros[12] = new ReportParameter("Maquina", _Maquina.ToString());
            parametros[13] = new ReportParameter("Ayudante", _Ayudante.ToString());
            parametros[14] = new ReportParameter("Gcategoria", gCategoria.ToString());
            rgta.Fill(ds.filtrar_produccion, Supervisor, int.Parse(Cliente), Maquina, Producto, Operador, Ayudante, Fechai, Fechaf, 1);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["filtrar_produccion"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
        private void HistorialProduccion()
        {
            ReportParameter[] parametros = new ReportParameter[2];
            this.Text = Reporte;
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.Obtener_produccion_totalTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.Obtener_produccion_totalTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            parametros[0] = new ReportParameter("Fechai", Fechai.ToShortDateString());
            parametros[1] = new ReportParameter("Fechaf", Fechaf.ToShortDateString());
            //parametros[2] = new ReportParameter("Orden1", Order1.ToString());
            rgta.Fill(ds.Obtener_produccion_total, Fechai, Fechaf, Turno, Maquina);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["Obtener_produccion_total"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
        private void InventarioDetallado()
        {
            ReportParameter[] parametros = new ReportParameter[1];
            this.Text = Reporte;
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.rpt_inv_alm_detTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.rpt_inv_alm_detTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            parametros[0] = new ReportParameter("Almacen", Almacen.ToString());
            //parametros[2] = new ReportParameter("Orden1", Order1.ToString());
            rgta.Fill(ds.rpt_inv_alm_det, Idalmacen);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["rpt_inv_alm_det"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }

<<<<<<< HEAD
        private void RollosAlambron()
        {
            ReportParameter[] parametros = new ReportParameter[2];
            Text = Reporte;
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.Rpt_Rollos_RangoFechaTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.Rpt_Rollos_RangoFechaTableAdapter();
=======
        private void EntradaInventario()
        {
            ReportParameter[] parametros = new ReportParameter[3];
            this.Text = Reporte;
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.obt_ent_almTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.obt_ent_almTableAdapter();
>>>>>>> bf1dba918529b9e8fe8f30955f8e6ec0e9182058
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
<<<<<<< HEAD
            parametros[0] = new ReportParameter("Desde", Fechai.ToShortDateString());
            parametros[1] = new ReportParameter("Hasta", Fechaf.ToShortDateString());
            //parametros[2] = new ReportParameter("Almacen", Almacen.ToString());
            rgta.Fill(ds.Rpt_Rollos_RangoFecha, Fechai,Fechaf, Idcliente);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["Rpt_Rollos_RangoFecha"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void InvResumidoAlambron()
        {
            //ReportParameter[] parametros = new ReportParameter[1];
            Text = Reporte;
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.Inventario_res_alambronTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.Inventario_res_alambronTableAdapter();
=======
            parametros[0] = new ReportParameter("Fechai", Fechai.ToShortDateString());
            parametros[1] = new ReportParameter("Fechaf", Fechaf.ToShortDateString());
            parametros[2] = new ReportParameter("Almacen", Almacen.ToString());
            rgta.Fill(ds.obt_ent_alm, Fechai, Fechaf, Idalmacen, NoReporte);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["obt_ent_alm"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
        private void SalidaInventario()
        {
            ReportParameter[] parametros = new ReportParameter[3];
            this.Text = Reporte;
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.obt_sal_almTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.obt_sal_almTableAdapter();
>>>>>>> bf1dba918529b9e8fe8f30955f8e6ec0e9182058
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
<<<<<<< HEAD
            //parametros[0] = new ReportParameter("Almacen", Almacen.ToString());
            //parametros[2] = new ReportParameter("Orden1", Order1.ToString());
            rgta.Fill(ds.Inventario_res_alambron,Idcliente);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["Inventario_res_alambron"]);
            reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void InvDetalladoAlambron()
        {
            //ReportParameter[] parametros = new ReportParameter[1];
            Text = Reporte;
            PRODUCCIONDataSet ds = new PRODUCCIONDataSet();
            PRODUCCIONDataSetTableAdapters.Inventario_det_alambronTableAdapter rgta = new PRODUCCIONDataSetTableAdapters.Inventario_det_alambronTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Nombre;
            lc.ReportPath = ruta;
            //parametros[0] = new ReportParameter("Almacen", Almacen.ToString());
            //parametros[2] = new ReportParameter("Orden1", Order1.ToString());
            rgta.Fill(ds.Inventario_det_alambron,Idcliente);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["Inventario_det_alambron"]);
            reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            reportViewer1.RefreshReport();
=======
            parametros[0] = new ReportParameter("Fechai", Fechai.ToShortDateString());
            parametros[1] = new ReportParameter("Fechaf", Fechaf.ToShortDateString());
            parametros[2] = new ReportParameter("Almacen", Almacen.ToString());
            rgta.Fill(ds.obt_sal_alm, Idalmacen, Iduso, Producto, Fechai, Fechaf);
            ReportDataSource rds = new ReportDataSource();
            reportViewer1.LocalReport.DisplayName = Reporte;
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["obt_sal_alm"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
>>>>>>> bf1dba918529b9e8fe8f30955f8e6ec0e9182058
        }
        #endregion
    }
}
