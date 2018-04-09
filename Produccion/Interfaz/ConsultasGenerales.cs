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

namespace Interfaz
{  
    public partial class ConsultasGenerales : MetroForm
    {
        clsProduccion Pr = new clsProduccion();
        public DataTable dt1 = new DataTable();
        public DataTable dt = new DataTable();
        private clsEmpresa P = new clsEmpresa();
        public DateTime Fechai { get; set; }
        public DateTime Fechaf { get; set; }
        public ConsultasGenerales()
        {
            InitializeComponent();
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte obj = new frmReporte();
            dt1 = Pr.TotalProduccion("Acerados");
            double acerado;
            double galvanizado;
            double recocido;
            double aceradoa;
            double galvanizadoa;
            double recocidoa;
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

            dt = Pr.AnualTotalProduccion("Acerados");
            if (string.IsNullOrEmpty(dt.Rows[0]["Total"].ToString()))
            {
                aceradoa = 0.00;
            }
            else
            {
                aceradoa = Convert.ToDouble(dt.Rows[0]["Total"]);
            }
            dt = Pr.AnualTotalProduccion("Galvanizados");
            if (string.IsNullOrEmpty(dt.Rows[0]["Total"].ToString()))
            {
                galvanizadoa = 0.00;
            }
            else
            {
                galvanizadoa = Convert.ToDouble(dt.Rows[0]["Total"]);
            }
            dt = Pr.AnualTotalProduccion("Recocidos");
            if (string.IsNullOrEmpty(dt.Rows[0]["Total"].ToString()))
            {
                recocidoa = 0.00;
            }
            else
            {
                recocidoa = Convert.ToDouble(dt.Rows[0]["Total"]);
            }
            dt = Pr.FechaCierre();
            if(string.IsNullOrEmpty(dt.Rows[0]["Fecha"].ToString()))
            {
                obj.Fecha =Convert.ToDateTime(DateTime.Now.ToShortDateString());
            }
            else
            {
                obj.Fecha = Convert.ToDateTime(dt.Rows[0]["Fecha"]);
            }

            obj.Valor = 1;
            obj.Acerado = acerado;
            obj.Galvanizado = galvanizado;
            obj.Recocido = recocido;
            obj.Aceradoa = aceradoa;
            obj.Galvanizadoa = galvanizadoa;
            obj.Recocidoa = recocidoa;
            obj.Nombre = "cierre_general.rdlc";
            obj.Destino = "";
            obj.Reporte = "CIERRE MENSUAL";
            obj.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnmensual_Click(object sender, EventArgs e)
        {
            string mensaje = "";
          DialogResult var=MessageBoxEx.Show("Desea realizar cierre mensual?","Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(var==DialogResult.Yes)
            {
                try
                {
                    mensaje = Pr.CerrarMes();
                    MessageBoxEx.Show(mensaje, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBoxEx.Show(ex.Message);
                }
            
            }
        }

        private void intermediosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte obj = new frmReporte();
            dt1 = Pr.TotalProduccion("Acerados");
            double acerado;
            double galvanizado;
            double recocido;
            double aceradoa;
            double galvanizadoa;
            double recocidoa;
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

            dt = Pr.AnualTotalProduccion("Acerados");
            if (string.IsNullOrEmpty(dt.Rows[0]["Total"].ToString()))
            {
                aceradoa = 0.00;
            }
            else
            {
                aceradoa = Convert.ToDouble(dt.Rows[0]["Total"]);
            }
            dt = Pr.AnualTotalProduccion("Galvanizados");
            if (string.IsNullOrEmpty(dt.Rows[0]["Total"].ToString()))
            {
                galvanizadoa = 0.00;
            }
            else
            {
                galvanizadoa = Convert.ToDouble(dt.Rows[0]["Total"]);
            }
            dt = Pr.AnualTotalProduccion("Recocidos");
            if (string.IsNullOrEmpty(dt.Rows[0]["Total"].ToString()))
            {
                recocidoa = 0.00;
            }
            else
            {
                recocidoa = Convert.ToDouble(dt.Rows[0]["Total"]);
            }
            dt = Pr.FechaCierre();
            if (string.IsNullOrEmpty(dt.Rows[0]["Fecha"].ToString()))
            {
                obj.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            }
            else
            {
                obj.Fecha = Convert.ToDateTime(dt.Rows[0]["Fecha"]);
            }

            obj.Valor = 1;
            obj.Acerado = acerado;
            obj.Galvanizado = galvanizado;
            obj.Recocido = recocido;
            obj.Aceradoa = aceradoa;
            obj.Galvanizadoa = galvanizadoa;
            obj.Recocidoa = recocidoa;
            obj.Nombre = "cierre_intermedios.rdlc";
            obj.Destino = "Intermedios";
            obj.Reporte = "CIERRE MENSUAL";
            obj.Show();
        }

        private void terminadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte obj = new frmReporte();
            dt1 = Pr.TotalProduccion("Acerados");
            double acerado;
            double galvanizado;
            double recocido;
            double aceradoa;
            double galvanizadoa;
            double recocidoa;
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

            dt = Pr.AnualTotalProduccion("Acerados");
            if (string.IsNullOrEmpty(dt.Rows[0]["Total"].ToString()))
            {
                aceradoa = 0.00;
            }
            else
            {
                aceradoa = Convert.ToDouble(dt.Rows[0]["Total"]);
            }
            dt = Pr.AnualTotalProduccion("Galvanizados");
            if (string.IsNullOrEmpty(dt.Rows[0]["Total"].ToString()))
            {
                galvanizadoa = 0.00;
            }
            else
            {
                galvanizadoa = Convert.ToDouble(dt.Rows[0]["Total"]);
            }
            dt = Pr.AnualTotalProduccion("Recocidos");
            if (string.IsNullOrEmpty(dt.Rows[0]["Total"].ToString()))
            {
                recocidoa = 0.00;
            }
            else
            {
                recocidoa = Convert.ToDouble(dt.Rows[0]["Total"]);
            }
            dt = Pr.FechaCierre();
            if (string.IsNullOrEmpty(dt.Rows[0]["Fecha"].ToString()))
            {
                obj.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            }
            else
            {
                obj.Fecha = Convert.ToDateTime(dt.Rows[0]["Fecha"]);
            }

            obj.Valor = 1;
            obj.Acerado = acerado;
            obj.Galvanizado = galvanizado;
            obj.Recocido = recocido;
            obj.Aceradoa = aceradoa;
            obj.Galvanizadoa = galvanizadoa;
            obj.Recocidoa = recocidoa;
            obj.Nombre = "cierre_terminados.rdlc";
            obj.Destino = "Terminados";
            obj.Reporte = "CIERRE MENSUAL";
            obj.Show();
        }

        private void lineaGalvanizadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte obj = new frmReporte();
            dt1 = Pr.TotalProduccion("Acerados");
            double acerado;
            double galvanizado;
            double recocido;
            double aceradoa;
            double galvanizadoa;
            double recocidoa;
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

            dt = Pr.AnualTotalProduccion("Acerados");
            if (string.IsNullOrEmpty(dt.Rows[0]["Total"].ToString()))
            {
                aceradoa = 0.00;
            }
            else
            {
                aceradoa = Convert.ToDouble(dt.Rows[0]["Total"]);
            }
            dt = Pr.AnualTotalProduccion("Galvanizados");
            if (string.IsNullOrEmpty(dt.Rows[0]["Total"].ToString()))
            {
                galvanizadoa = 0.00;
            }
            else
            {
                galvanizadoa = Convert.ToDouble(dt.Rows[0]["Total"]);
            }
            dt = Pr.AnualTotalProduccion("Recocidos");
            if (string.IsNullOrEmpty(dt.Rows[0]["Total"].ToString()))
            {
                recocidoa = 0.00;
            }
            else
            {
                recocidoa = Convert.ToDouble(dt.Rows[0]["Total"]);
            }
            dt = Pr.FechaCierre();
            if (string.IsNullOrEmpty(dt.Rows[0]["Fecha"].ToString()))
            {
                obj.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            }
            else
            {
                obj.Fecha = Convert.ToDateTime(dt.Rows[0]["Fecha"]);
            }

            obj.Valor = 1;
            obj.Acerado = acerado;
            obj.Galvanizado = galvanizado;
            obj.Recocido = recocido;
            obj.Aceradoa = aceradoa;
            obj.Galvanizadoa = galvanizadoa;
            obj.Recocidoa = recocidoa;
            obj.Nombre = "cierre_lineagalv.rdlc";
            obj.Destino = "Linea Galv";
            obj.Reporte = "CIERRE MENSUAL";
            obj.Show();
        }
        private void LlenarComboP()
        {
            try
            {
                tscbempresa.ComboBox.BindingContext = this.BindingContext;
                tscbempresa.ComboBox.DataSource = P.Listar(true);
                tscbempresa.ComboBox.DisplayMember = "DESCRIPCION";
                tscbempresa.ComboBox.ValueMember = "ID_EMPRESA";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }

        }
        private void Permisos()
        {
            btnmensual.Enabled = Program.ciecong;
            btnanual.Enabled = Program.cieacong;
            btnFiltros.Enabled = Program.filcong;
            acumuladoMensualToolStripMenuItem.Enabled = Program.acucong;
            incentivosToolStripMenuItem.Enabled = Program.inccong;
            empresaToolStripMenuItem.Enabled = Program.empcong;
        }
        private void ConsultasGenerales_Load(object sender, EventArgs e)
        {
            LlenarComboP();
            tscbempresa.ComboBox.SelectedValue = "ACERO";
            Permisos();
        }

        private void grapasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte obj = new frmReporte();
            frmReporte obj1 = new frmReporte();
            obj.Destino = tscbempresa.ComboBox.Text;
            obj1.Destino = tscbempresa.ComboBox.Text;
            dt = Pr.FechaCierre();
            if (string.IsNullOrEmpty(dt.Rows[0]["Fecha"].ToString()))
            {
                obj.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                obj1.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            }
            else
            {
                obj.Fecha = Convert.ToDateTime(dt.Rows[0]["Fecha"]);
                obj1.Fecha = Convert.ToDateTime(dt.Rows[0]["Fecha"]);
            }
            obj.Incentivo = "Grapas";
            obj.Empresa = tscbempresa.ComboBox.SelectedValue.ToString();
            obj.Nombre = "incentivo_grapas.rdlc";
            obj.Reporte = "INCENTIVO GRAPAS";
            obj.Idcliente = 0;
            obj.Valor = 2;
            obj.Show();

            /////INCENTIVO PUAS KINNOX///////
            obj1.Incentivo = "Grapas";
            obj1.Empresa = tscbempresa.ComboBox.SelectedValue.ToString();
            obj1.Nombre = "incentivo_grapas.rdlc";
            obj1.Reporte = "INCENTIVO GRAPAS";
            obj1.Valor = 2;
            obj1.Idcliente = 43;
            obj1.Show();
        }

        private void púasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte obj = new frmReporte();
            frmReporte obj1 = new frmReporte();
            obj.Destino = tscbempresa.ComboBox.Text;
            obj1.Destino = tscbempresa.ComboBox.Text;
            dt = Pr.FechaCierre();
            if (string.IsNullOrEmpty(dt.Rows[0]["Fecha"].ToString()))
            {
                obj.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                obj1.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            }
            else
            {
                obj.Fecha = Convert.ToDateTime(dt.Rows[0]["Fecha"]);
                obj1.Fecha = Convert.ToDateTime(dt.Rows[0]["Fecha"]);
            }
            obj.Incentivo = "Puas";
            obj.Empresa = tscbempresa.ComboBox.SelectedValue.ToString();
            obj.Nombre = "incentivo_puas.rdlc";
            obj.Reporte = "INCENTIVO PUAS";
            obj.Valor = 2;
            obj.Idcliente = 0;
            obj.Show();

            /////INCENTIVO PUAS KINNOX///////
            obj1.Incentivo = "Puas";
            obj1.Empresa = tscbempresa.ComboBox.SelectedValue.ToString();
            obj1.Nombre = "incentivo_puas.rdlc";
            obj1.Reporte = "INCENTIVO PUAS";
            obj1.Valor = 2;
            obj1.Idcliente = 43;
            obj1.Show();
        }

        private void mallasGallineroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte obj = new frmReporte();
            frmReporte obj1 = new frmReporte();
            obj.Destino = tscbempresa.ComboBox.Text;
            obj1.Destino = tscbempresa.ComboBox.Text;
            dt = Pr.FechaCierre();
            if (string.IsNullOrEmpty(dt.Rows[0]["Fecha"].ToString()))
            {
                obj.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                obj1.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            }
            else
            {
                obj.Fecha = Convert.ToDateTime(dt.Rows[0]["Fecha"]);
                obj1.Fecha = Convert.ToDateTime(dt.Rows[0]["Fecha"]);
            }
            obj.Incentivo = "Mallas Gallinero";
            obj.Empresa = tscbempresa.ComboBox.SelectedValue.ToString();
            obj.Nombre = "incentivo_mallas_gallinero.rdlc";
            obj.Reporte = "INCENTIVO MALLAS GALLINERO";
            obj.Valor = 2;
            obj.Idcliente = 0;
            obj.Show();

            /////INCENTIVO MALLAS KINNOX///////
            obj1.Incentivo = "Mallas Gallinero";
            obj1.Empresa = tscbempresa.ComboBox.SelectedValue.ToString();
            obj1.Nombre = "incentivo_mallas_gallinero.rdlc";
            obj1.Reporte = "INCENTIVO MALLAS GALLINERO";
            obj1.Valor = 2;
            obj1.Idcliente = 43;
            obj1.Show();
        }

        private void mallasCiclonicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte obj = new frmReporte();
            frmReporte obj1 = new frmReporte();
            obj.Destino = tscbempresa.ComboBox.Text;
            obj1.Destino = tscbempresa.ComboBox.Text;
            dt = Pr.FechaCierre();
            if (string.IsNullOrEmpty(dt.Rows[0]["Fecha"].ToString()))
            {
                obj.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                obj1.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            }
            else
            {
                obj.Fecha = Convert.ToDateTime(dt.Rows[0]["Fecha"]);
                obj1.Fecha = Convert.ToDateTime(dt.Rows[0]["Fecha"]);
            }
            obj.Incentivo = "Mallas Ciclonicas";
            obj.Empresa = tscbempresa.ComboBox.SelectedValue.ToString();
            obj.Nombre = "incentivo_mallas_ciclonicas.rdlc";
            obj.Reporte = "INCENTIVO MALLAS CICLONICAS";
            obj.Idcliente = 0;
            obj.Valor = 2;
            obj.Show();

            /////INCENTIVO MALLAS KINNOX///////
            obj1.Incentivo = "Mallas Ciclonicas";
            obj1.Empresa = tscbempresa.ComboBox.SelectedValue.ToString();
            obj1.Nombre = "incentivo_mallas_ciclonicas.rdlc";
            obj1.Reporte = "INCENTIVO MALLAS CICLONICAS";
            obj1.Valor = 2;
            obj1.Idcliente = 43;
            obj1.Show();
        }

        private void sunchosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte obj = new frmReporte();
            obj.Destino = tscbempresa.ComboBox.Text;
            dt = Pr.FechaCierre();
            if (string.IsNullOrEmpty(dt.Rows[0]["Fecha"].ToString()))
            {
                obj.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            }
            else
            {
                obj.Fecha = Convert.ToDateTime(dt.Rows[0]["Fecha"]);
            }
            obj.Incentivo = "Sunchos";
            obj.Empresa = tscbempresa.ComboBox.SelectedValue.ToString();
            obj.Nombre = "incentivo_sunchos.rdlc";
            obj.Reporte = "INCENTIVO SUNCHOS";
            obj.Valor = 2;
            obj.Show();
        }

        private void rollosRollitosCortadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte obj = new frmReporte();
            Consultas.frmcFechas obj1 = new Consultas.frmcFechas();
            obj.Destino = tscbempresa.ComboBox.Text;
            dt = Pr.FechaCierre();
            if (string.IsNullOrEmpty(dt.Rows[0]["Fecha"].ToString()))
            {
                obj.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            }
            else
            {
                obj.Fecha = Convert.ToDateTime(dt.Rows[0]["Fecha"]);
            }
            obj.Incentivo = "Rollos,Rollitos,Cortado";
            obj.Empresa = tscbempresa.ComboBox.SelectedValue.ToString();
            obj.Nombre = "incentivo_rollos_cort.rdlc";
            obj.Reporte = "INCENTIVO ROLLOS,ROLLITOS,CORTADO";
            obj.Valor = 3;
            obj1.ShowDialog();
            if(Program.Valor2==1)
            {
                obj.Fechai = Program.Fechai;
                obj.Fechaf = Program.Fechaf;
                obj.Show();
            }
           
        }

        private void trefiladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte obj = new frmReporte();
            obj.Destino = tscbempresa.ComboBox.Text;
            dt = Pr.FechaCierre();
            if (string.IsNullOrEmpty(dt.Rows[0]["Fecha"].ToString()))
            {
                obj.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            }
            else
            {
                obj.Fecha = Convert.ToDateTime(dt.Rows[0]["Fecha"]);
            }
            obj.Empresa = tscbempresa.ComboBox.SelectedValue.ToString();
            obj.Nombre = "incentivo_trefilado.rdlc";
            obj.Reporte = "INCENTIVO TREFILADO";
            obj.Valor = 4;
            obj.Show();
        }

        private void flejadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte obj = new frmReporte();
            obj.Destino = tscbempresa.ComboBox.Text;
            dt = Pr.FechaCierre();
            if (string.IsNullOrEmpty(dt.Rows[0]["Fecha"].ToString()))
            {
                obj.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            }
            else
            {
                obj.Fecha = Convert.ToDateTime(dt.Rows[0]["Fecha"]);
            }
            obj.Empresa = tscbempresa.ComboBox.SelectedValue.ToString();
            obj.Nombre = "incentivo_flejado.rdlc";
            obj.Reporte = "INCENTIVO FLEJADO";
            obj.Valor = 5;
            obj.Show();
        }

        private void lineaGalvanizadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReporte obj = new frmReporte();
            obj.Destino = tscbempresa.ComboBox.Text;
            dt = Pr.FechaCierre();
            if (string.IsNullOrEmpty(dt.Rows[0]["Fecha"].ToString()))
            {
                obj.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            }
            else
            {
                obj.Fecha = Convert.ToDateTime(dt.Rows[0]["Fecha"]);
            }
            obj.Empresa = tscbempresa.ComboBox.SelectedValue.ToString();
            obj.Nombre = "incentivo_galvanizado.rdlc";
            obj.Reporte = "INCENTIVO GALVANIZADO";
            obj.Valor = 6;
            obj.Show();
        }

        private void varillasAceradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte obj = new frmReporte();
            obj.Destino = tscbempresa.ComboBox.Text;
            dt = Pr.FechaCierre();
            if (string.IsNullOrEmpty(dt.Rows[0]["Fecha"].ToString()))
            {
                obj.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            }
            else
            {
                obj.Fecha = Convert.ToDateTime(dt.Rows[0]["Fecha"]);
            }
            obj.Incentivo = "Varillas Aceradas";
            obj.Empresa = tscbempresa.ComboBox.SelectedValue.ToString();
            obj.Nombre = "incentivo_varillas_aceradas.rdlc";
            obj.Reporte = "INCENTIVO VARILLAS ACERADAS";
            obj.Valor = 2;
            obj.Show();
        }

        private void mecanicoIndustriaMenorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte obj = new frmReporte();
            frmReporte obj2 = new frmReporte();
            Consultas.frmcFechas obj1 = new Consultas.frmcFechas();
            obj.Destino = tscbempresa.ComboBox.Text;
            obj2.Destino = tscbempresa.ComboBox.Text;
            dt = Pr.FechaCierre();
            if (string.IsNullOrEmpty(dt.Rows[0]["Fecha"].ToString()))
            {
                obj.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                obj2.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            }
            else
            {
                obj.Fecha = Convert.ToDateTime(dt.Rows[0]["Fecha"]);
                obj2.Fecha = Convert.ToDateTime(dt.Rows[0]["Fecha"]);
            }
            //obj.Incentivo = "Mecanico Industria Menor";
            obj.Empresa = tscbempresa.ComboBox.SelectedValue.ToString();
            obj.Nombre = "incentivo_mecanico_indm.rdlc";
            obj.Reporte = "INCENTIVO MECANICO INDUSTRIA MENOR";
            obj.Valor = 8;
            obj.Idcliente = 0;

            ///INCENTIVO KINNOX/////
            obj2.Empresa = tscbempresa.ComboBox.SelectedValue.ToString();
            obj2.Nombre = "incentivo_mecanico_indm.rdlc";
            obj2.Reporte = "INCENTIVO MECANICO INDUSTRIA MENOR";
            obj2.Valor = 8;
            obj2.Idcliente = 43;
            obj1.ShowDialog();
            if (Program.Valor2 == 1)
            {
                obj.Fechai = Program.Fechai;
                obj.Fechaf = Program.Fechaf;
                obj.Show();
                obj2.Fechai = Program.Fechai;
                obj2.Fechaf = Program.Fechaf;
                obj2.Show();
            }
        }

        private void btnFiltros_Click(object sender, EventArgs e)
        {
            Consultas.frmcFiltros obj = new Consultas.frmcFiltros();
            obj.ShowDialog();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Consultas.frmcDetalleProduccionMaquinas obj = new Consultas.frmcDetalleProduccionMaquinas();
            obj.ShowDialog();
        }

        private void btnMonitoreo_Click(object sender, EventArgs e)
        {
            Consultas.frmcMonitoreoMaquinas obj = new Consultas.frmcMonitoreoMaquinas();
            obj.ShowDialog();
        }

        private void kINNOXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte obj = new frmReporte();
            dt1 = Pr.TotalProduccion("Acerados");
            double acerado;
            double galvanizado;
            double recocido;
            double aceradoa;
            double galvanizadoa;
            double recocidoa;
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

            dt = Pr.AnualTotalProduccion("Acerados");
            if (string.IsNullOrEmpty(dt.Rows[0]["Total"].ToString()))
            {
                aceradoa = 0.00;
            }
            else
            {
                aceradoa = Convert.ToDouble(dt.Rows[0]["Total"]);
            }
            dt = Pr.AnualTotalProduccion("Galvanizados");
            if (string.IsNullOrEmpty(dt.Rows[0]["Total"].ToString()))
            {
                galvanizadoa = 0.00;
            }
            else
            {
                galvanizadoa = Convert.ToDouble(dt.Rows[0]["Total"]);
            }
            dt = Pr.AnualTotalProduccion("Recocidos");
            if (string.IsNullOrEmpty(dt.Rows[0]["Total"].ToString()))
            {
                recocidoa = 0.00;
            }
            else
            {
                recocidoa = Convert.ToDouble(dt.Rows[0]["Total"]);
            }
            dt = Pr.FechaCierre();
            if (string.IsNullOrEmpty(dt.Rows[0]["Fecha"].ToString()))
            {
                obj.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            }
            else
            {
                obj.Fecha = Convert.ToDateTime(dt.Rows[0]["Fecha"]);
            }

            obj.Valor = 1;
            obj.Acerado = acerado;
            obj.Galvanizado = galvanizado;
            obj.Recocido = recocido;
            obj.Aceradoa = aceradoa;
            obj.Galvanizadoa = galvanizadoa;
            obj.Recocidoa = recocidoa;
            obj.Nombre = "cierre_general_kinnox.rdlc";
            obj.Destino = "KINNOX";
            obj.Reporte = "CIERRE MENSUAL";
            obj.Show();
        }

        private void btnanual_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            DialogResult var = MessageBoxEx.Show("Desea realizar cierre anual?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (var == DialogResult.Yes)
            {
                try
                {
                    mensaje = Pr.CerrarAno();
                    MessageBoxEx.Show(mensaje, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBoxEx.Show(ex.Message);
                }

            }
        }
    }
    
}
